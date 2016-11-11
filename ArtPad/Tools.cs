using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

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

        private static IntPtr hForegroundWindow = IntPtr.Zero;

        public static void saveForegroundWindow() {
            HForegroundWindow = GetForegroundWindow();
        }

        public static bool setForegroundWindowFromSaved() {
            if (Tools.HForegroundWindow != IntPtr.Zero) {
                return SetForegroundWindow(HForegroundWindow);
            }
            return false;
        }

        public static string getForegroundWindowTitle() {
            IntPtr hWnd = GetForegroundWindow();
            if (hWnd.Equals(IntPtr.Zero)) {
                return "<NotFound>";
            }
            return getWindowTitle(hWnd);
        }

        public static string getSavedForegroundWindowTitle() {
            IntPtr hWnd = HForegroundWindow;
            if (hWnd.Equals(IntPtr.Zero)) {
                return "NotFound>";
            }
            return getWindowTitle(hWnd);
        }

        public static string getWindowTitle(IntPtr hWnd) {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            if (GetWindowText(hWnd, Buff, nChars) > 0) {
                return Buff.ToString();
            }
            return "<empty>";
        }

#if DEBUG
        public static void debugForegroundWindows(string method) {
            Debug.Print(method + ": Foreground: "
                + getForegroundWindowTitle()
                + ", Saved: " + getSavedForegroundWindowTitle());
        }
#endif

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


