using System;
using System.Drawing;
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

        /// <summary>
        /// Cnverts a Color to a string of the form #RRGGBB.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string colorToHexString(Color color) {
            return String.Format("#{0:X2}{1:X2}{2:X2}",
                color.R, color.G, color.B);
        }

        /// <summary>
        /// Converts a string of the for #RRGGBB to a Color.
        /// </summary>
        /// <param name="colorString"></param>
        /// <returns></returns>
        public static Color hexStringToColor(String colorString) {
            if (colorString.Length != 7 || !colorString.StartsWith("#")) {
                throw new ArgumentException("Invalid hex string (not #RRGGBB)"
                    + colorString);
            }
            int red = int.Parse(colorString.Substring(1, 2),
                System.Globalization.NumberStyles.HexNumber);
            int green = int.Parse(colorString.Substring(3, 2),
                System.Globalization.NumberStyles.HexNumber);
            int blue = int.Parse(colorString.Substring(5, 2),
                System.Globalization.NumberStyles.HexNumber);
            if (red > 255) red = 255;
            if (red < 0) red = 0;
            if (green > 255) red = 255;
            if (green < 0) red = 0;
            if (blue > 255) red = 255;
            if (blue < 0) red = 0;
            return Color.FromArgb(red, green, blue);
        }
    }
}
