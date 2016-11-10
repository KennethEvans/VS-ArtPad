using System;
using System.Windows.Forms;

namespace ArtPad {
    public static class Utils {
        public static void errMsg(String s) {
            MessageBox.Show(s, "Error");
        }

        public static void infoMsg(String s) {
            MessageBox.Show(s, "Information");
        }

    }
}
