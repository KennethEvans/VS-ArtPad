using System;
using System.Windows.Forms;

namespace ArtPad {
    public static class Utils {
        public static string LF = System.Environment.NewLine;

        /// <summary>
        /// Error message.
        /// </summary>
        /// <param name="msg"></param>
        public static void errMsg(string msg) {
            MessageBox.Show(msg, "Error");
        }

        /// <summary>
        /// Exception message.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        public static void excMsg(string msg, Exception ex) {
            MessageBox.Show(msg += LF + "Exception: " + ex + LF
            + ex.Message, "Exception");
        }

        /// <summary>
        /// Warning message.
        /// </summary>
        /// <param name="msg"></param>
        public static void warnMsg(string msg) {
            MessageBox.Show(msg, "Warning");
        }

        /// <summary>
        /// Information message.
        /// </summary>
        /// <param name="msg"></param>
        public static void infoMsg(string msg) {
            MessageBox.Show(msg, "Information");
        }

    }
}
