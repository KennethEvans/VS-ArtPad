using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using WindowsInput;
using WindowsInput.Native;

namespace ArtPad {
    public static class Tools {
        public const string VERSION = "ArtPad 1.1.0";

        /// <summary>
        /// The saved value of the foreground window to be restored later.
        /// </summary>
        private static IntPtr hForegroundWindow = IntPtr.Zero;

        /// <summary>
        /// Saves the current foreground window to be restored later.
        /// </summary>
        public static void saveForegroundWindow() {
            HForegroundWindow = NativeMethods.GetForegroundWindow();
        }

        /// <summary>
        /// Sets the current foreground window to the saved one.
        /// </summary>
        /// <returns></returns>
        public static bool setForegroundWindowFromSaved() {
            if (Tools.HForegroundWindow != IntPtr.Zero) {
                return NativeMethods.SetForegroundWindow(HForegroundWindow);
            }
            return false;
        }

        /// <summary>
        /// Get the title for the current foreground window.
        /// </summary>
        /// <returns></returns>
        public static string getForegroundWindowTitle() {
            IntPtr hWnd = NativeMethods.GetForegroundWindow();
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
            if (NativeMethods.GetWindowText(hWnd, Buff, nChars) > 0) {
                return Buff.ToString();
            }
            return "<empty>";
        }

        /// <summary>
        /// Gets a VirtualKeyCode for the given KeyConfig.
        /// </summary>
        /// <param name="keyDef">The key definition to use.</param>
        /// <returns></returns>
        public static VirtualKeyCode getKeyCode(KeyDef keyDef) {
            VirtualKeyCode keyCode;
            if (keyDef.KeyString.Equals("^")) { // Ctrl
                keyCode = VirtualKeyCode.CONTROL;
            } else if (keyDef.KeyString.Equals("%")) { // Alt
                keyCode = VirtualKeyCode.MENU;
            } else if (keyDef.KeyString.Equals("+")) { // Shift
                keyCode = VirtualKeyCode.SHIFT;
            } else {
                throw new ArgumentException(keyDef.KeyString
                    + " is not supported");
            }
            return keyCode;
        }

        /// <summary>
        /// Sends up events for any pressed keys in the given keyConfig list.
        /// </summary>
        /// <param name="keyDefs">List of key definitions to use.</param>
        public static void sendUpEventsForPressedKeys(List<KeyDef> keyDefs) {
            if (keyDefs == null) {
                return;
            }
            foreach (KeyDef keyDef in keyDefs) {
                if (keyDef.Type == KeyDef.KeyType.HOLD) {
                    VirtualKeyCode keyCode;
                    try {
                        keyCode = Tools.getKeyCode(keyDef);
                    } catch (System.ArgumentException) {
                        continue;
                    }
                    keyDef.Pressed = false;
                    var sim = new InputSimulator();
                    sim.Keyboard.KeyUp(keyCode);
                }
            }
        }

        #region DEBUG
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

        /// <summary>
        /// Prints PortableExecutableKinds and PortableExecutableKinds
        /// information for the Manifest Module or for each module in the
        /// assembly.
        /// </summary>
        public static void printModuleInfo() {
            PortableExecutableKinds peKinds;
            ImageFileMachine imageFileMachine;

            var assembly = Assembly.GetExecutingAssembly();
            assembly.ManifestModule.GetPEKind(out peKinds, out imageFileMachine);
            Debug.Print("*********************************************");
            Debug.Print(assembly.ManifestModule.Name + ": " + peKinds
                + " " + imageFileMachine);
            Debug.Print("*********************************************");

#if false
            // Do this for all the modules
            var modules = assembly.GetModules();
            var kinds = new List<PortableExecutableKinds>();
            var images = new List<ImageFileMachine>();
            Debug.Print("*********************************************");
            foreach (var module in modules) {
                module.GetPEKind(out peKinds, out imageFileMachine);
                Debug.Print(module.Name + ": " + peKinds
                    + " " + imageFileMachine);

                kinds.Add(peKinds);
                images.Add(imageFileMachine);
            }
            Debug.Print("*********************************************");
            var distinctKinds = kinds.Distinct().ToList();
            var distinctImages = images.Distinct().ToList();
#endif // false
        }
#endif // Debug
        #endregion DEBUG

        /// <summary>
        /// A hard-coded list of KeyConfig's for testing.
        /// </summary>
        public static List<KeyDef> TestKeyDefs
        {
            get
            {
                {
                    return new List<KeyDef>{
            new KeyDef("Zoom-","^-", KeyDef.KeyType.NORMAL, 0, 0),
            new KeyDef("Brush-","[", KeyDef.KeyType.NORMAL, 0,1),
            new KeyDef("Undo","^z", KeyDef.KeyType.NORMAL, 0,2),
            new KeyDef("Zoom+","{+}", KeyDef.KeyType.NORMAL, 1,0),
            new KeyDef("Brush+","]", KeyDef.KeyType.NORMAL, 1,1),
            new KeyDef("Redo","+^z", KeyDef.KeyType.NORMAL, 1,2),
            new KeyDef("Save","^s", KeyDef.KeyType.NORMAL, 2,0),
            new KeyDef("Actual","^1", KeyDef.KeyType.NORMAL, 2, 1),
            new KeyDef("Fit","^0", KeyDef.KeyType.NORMAL, 2,2),
            new KeyDef("ArtPad","ArtPad.exe", KeyDef.KeyType.COMMAND, 3,0),
            new KeyDef("OSK","\\windows\\system32\\osk.exe", KeyDef.KeyType.COMMAND, 3,1),
            new KeyDef("TabTip",
            "\\Program Files\\Common Files\\Microsoft Shared\\ink\\TabTip.exe",
            KeyDef.KeyType.COMMAND, 3, 2),
            new KeyDef("Cut","^x", KeyDef.KeyType.NORMAL, 4, 0),
            new KeyDef("Copy","^c", KeyDef.KeyType.NORMAL, 4,1),
            new KeyDef("Paste","^v", KeyDef.KeyType.NORMAL, 4, 2),
            new KeyDef("Ctrl","^", KeyDef.KeyType.HOLD, 5, 0),
            new KeyDef("Shift","+", KeyDef.KeyType.HOLD, 5,1),
            new KeyDef("Alt","%", KeyDef.KeyType.HOLD, 5, 2),
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

    /// <summary>
    /// Class for native methods.
    /// </summary>
    internal static class NativeMethods {
        internal const int WS_EX_NOACTIVATE = 0x08000000;
        internal const int GWL_EXSTYLE = -20;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern int SetWindowLong(IntPtr hwnd, int index,
            int newStyle);

        [DllImport("user32.dll")]
        internal static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        internal static extern bool SetForegroundWindow(IntPtr WindowHandle);

        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern int GetWindowText(IntPtr hWnd,
            StringBuilder lpString, int nMaxCount);
    }
}
