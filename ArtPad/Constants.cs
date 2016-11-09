using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ArtPad {
    public static class Constants {
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

        public const string VERSION = "ArtPad 1.0.0";
        public static IntPtr hForegroundWindow { get; set; } = IntPtr.Zero;

        public static IntPtr getForegroundWindow() {
            return GetForegroundWindow();
        }

        public static bool setForegroundWindow(IntPtr hWnd) {
            return SetForegroundWindow(hWnd);
        }

        public static string getActiveWindowTitle() {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr HWnd = GetForegroundWindow();

            if (GetWindowText(HWnd, Buff, nChars) > 0) {
                return Buff.ToString();
            }
            return null;
        }

        public static string getWindowTitle(IntPtr hWnd) {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            if (GetWindowText(hWnd, Buff, nChars) > 0) {
                return Buff.ToString();
            }
            return null;
        }

        public static List<KeyConfig> TestKeyConfigs
        {
            get
            {
                {
                    return new List<KeyConfig>{
            new KeyConfig("A","+A", KeyConfig.KeyType.NORMAL, 0, 0),
            new KeyConfig("B","+B", KeyConfig.KeyType.NORMAL, 0, 1),
            new KeyConfig("C","+C", KeyConfig.KeyType.NORMAL, 0, 2),
            new KeyConfig("D","+D", KeyConfig.KeyType.NORMAL, 0, 3),
            new KeyConfig("a","a", KeyConfig.KeyType.NORMAL, 1, 0),
            new KeyConfig("b","b", KeyConfig.KeyType.NORMAL, 1, 1),
            new KeyConfig("c","c", KeyConfig.KeyType.NORMAL, 1, 2),
            new KeyConfig("d","d", KeyConfig.KeyType.NORMAL, 1, 3),
            new KeyConfig("Ctrl","^", KeyConfig.KeyType.HOLD, 2, 0),
            new KeyConfig("Alt","%", KeyConfig.KeyType.NORMAL, 2, 1),
            new KeyConfig("Copy","^C", KeyConfig.KeyType.NORMAL, 2, 2),
            new KeyConfig("Paste","^V", KeyConfig.KeyType.NORMAL, 2, 3),
        };
                }
            }
        }
    }
}


