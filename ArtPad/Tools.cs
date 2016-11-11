using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using WindowsInput.Native;
using WindowsInput;

namespace ArtPad {
    public static class Tools {
        public const string VERSION = "ArtPad 1.0.0";
        private const int WS_EX_NOACTIVATE = 0x08000000;
        private const int GWL_EXSTYLE = -20;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr WindowHandle);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        /// <summary>
        /// The saved value of the foreground window to be restored later.
        /// </summary>
        private static IntPtr hForegroundWindow = IntPtr.Zero;

        /// <summary>
        /// Saves the current foreground window to be restored later.
        /// </summary>
        public static void saveForegroundWindow() {
            HForegroundWindow = GetForegroundWindow();
        }

        /// <summary>
        /// Sets the current foreground window to the saved one.
        /// </summary>
        /// <returns></returns>
        public static bool setForegroundWindowFromSaved() {
            if (Tools.HForegroundWindow != IntPtr.Zero) {
                return SetForegroundWindow(HForegroundWindow);
            }
            return false;
        }

        /// <summary>
        /// Get the title for the current foreground window.
        /// </summary>
        /// <returns></returns>
        public static string getForegroundWindowTitle() {
            IntPtr hWnd = GetForegroundWindow();
            if (hWnd.Equals(IntPtr.Zero)) {
                return "<NotFound>";
            }
            return getWindowTitle(hWnd);
        }

        /// <summary>
        /// Gets the title for the current saved window handle.
        /// </summary>
        /// <returns></returns>
        public static string getSavedForegroundWindowTitle() {
            IntPtr hWnd = HForegroundWindow;
            if (hWnd.Equals(IntPtr.Zero)) {
                return "NotFound>";
            }
            return getWindowTitle(hWnd);
        }

        /// <summary>
        /// Gets the title for the given window handle.
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static string getWindowTitle(IntPtr hWnd) {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            if (GetWindowText(hWnd, Buff, nChars) > 0) {
                return Buff.ToString();
            }
            return "<empty>";
        }

        /// <summary>
        /// Gets a VirtualKeyCode for the given KeyConfig.
        /// </summary>
        /// <param name="key">The key to use.</param>
        /// <returns></returns>
        public static VirtualKeyCode getKeyCode(KeyConfig key) {
            VirtualKeyCode keyCode;
            if (key.KeyString.Equals("^")) { // Ctrl
                keyCode = VirtualKeyCode.CONTROL;
            } else if (key.KeyString.Equals("%")) { // Alt
                keyCode = VirtualKeyCode.MENU;
            } else if (key.KeyString.Equals("+")) { // Shift
                keyCode = VirtualKeyCode.SHIFT;
            } else {
                throw new ArgumentException(key.KeyString
                    + " is not supported");
            }
            return keyCode;
        }

        /// <summary>
        /// Sends up events for any pressed keys in the given keyConfig list.
        /// </summary>
        /// <param name="TestKeyConfigs">List of keys to use.</param>
        public static void sendUpEventsForPressedKeys(List<KeyConfig> keys) {
            if (keys == null) {
                return;
            }
            foreach (KeyConfig key in keys) {
                if (key.Type == KeyConfig.KeyType.HOLD && key.Pressed == true) {
                    VirtualKeyCode keyCode;
                    try {
                        keyCode = Tools.getKeyCode(key);
                    } catch (System.ArgumentException) {
                        continue;
                    }
                    key.Pressed = false;
                    var sim = new InputSimulator();
                    sim.Keyboard.KeyUp(keyCode);
                }
            }
        }


#if DEBUG
        /// <summary>
        /// Generic debugging printout for examining foreground windows.
        /// </summary>
        /// <param name="method"></param>
        public static void debugForegroundWindows(string method) {
            Debug.Print(method + ": Foreground: "
                + getForegroundWindowTitle()
                + ", Saved: " + getSavedForegroundWindowTitle());
        }
#endif

        /// <summary>
        /// A hard-coded list of KeyConfig's for testing.
        /// </summary>
        public static List<KeyConfig> TestKeyConfigs
        {
            get
            {
                {
                    return new List<KeyConfig>{
            new KeyConfig("A","+A", KeyConfig.KeyType.NORMAL, 0, 0),
            new KeyConfig("B","+B", KeyConfig.KeyType.NORMAL, 0, 1),
            new KeyConfig("C","+C", KeyConfig.KeyType.NORMAL, 0, 2),
            new KeyConfig("g","+g", KeyConfig.KeyType.NORMAL, 0, 3),
            new KeyConfig("x","x", KeyConfig.KeyType.NORMAL, 1, 0),
            new KeyConfig("y","y", KeyConfig.KeyType.NORMAL, 1, 1),
            new KeyConfig("z","z", KeyConfig.KeyType.NORMAL, 1, 2),
            new KeyConfig("f","f", KeyConfig.KeyType.NORMAL, 1, 3),
            new KeyConfig("Ctrl","^", KeyConfig.KeyType.HOLD, 2, 0),
            new KeyConfig("Alt","%", KeyConfig.KeyType.HOLD, 2, 1),
            new KeyConfig("Shift","+", KeyConfig.KeyType.HOLD, 2, 2),
            new KeyConfig("OSK",@"osk.exe", KeyConfig.KeyType.COMMAND, 2, 3),
        };
                }
            }
        }

        public static IntPtr HForegroundWindow
        {
            get
            {
                return hForegroundWindow;
            }

            set
            {
                hForegroundWindow = value;
            }
        }
    }
}


