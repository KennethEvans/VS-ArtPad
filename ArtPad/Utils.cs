using System;
using System.Windows.Forms;

namespace ArtPad {
    public static class Utils {
        public static string LF = System.Environment.NewLine;

        /// <summary>
        /// Error message.
        /// </summary>
        /// <param name="s"></param>
        public static void errMsg(string s) {
            MessageBox.Show(s, "Error");
        }

        /// <summary>
        /// Exception message.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="ex"></param>
        public static void excMsg(string s, Exception ex) {
            MessageBox.Show(s += LF + "Exception: " + ex + LF
            + ex.Message, "Exception");
        }

        /// <summary>
        /// Warning message.
        /// </summary>
        /// <param name="s"></param>
        public static void warnMsg(string s) {
            MessageBox.Show(s, "Warning");
        }

         /// <summary>
         /// Information message.
         /// </summary>
         /// <param name="s"></param>
         public static void infoMsg(string s) {
            MessageBox.Show(s, "Information");
        }

    }
}
