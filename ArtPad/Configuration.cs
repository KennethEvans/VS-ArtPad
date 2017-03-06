using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace ArtPad {
    public class Configuration {
        private List<KeyDef> keyDefs = new List<KeyDef>();
        private Size size = new Size(300, 150);
        private int rows = 0;
        private int cols = 0;
        private string fontName = "";
        private float fontSize;
        private FontStyleFlags fontFlags = new FontStyleFlags();
        private string fgColorString = "";
        private string bgColorString = "";

        /// <summary>
        /// Reads a configuration from the specified file name.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static Configuration readConfig(string fileName) {
            try {
                Configuration newConfig = JsonConvert.
                    DeserializeObject<Configuration>
                    (System.IO.File.ReadAllText(fileName));
                return newConfig;
            } catch (Exception ex) {
                Utils.excMsg("Error reading configuration from "
                     + fileName, ex);
                return null;
            }
        }

        /// <summary>
        /// Writes the specified configuration to the specified file.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="fileName"></param>
        public static void writeConfig(Configuration config, string fileName) {
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            System.IO.File.WriteAllText(fileName, json);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        /// <returns></returns>
        public static Configuration generateNewConfiguration(int rows, int cols) {
            if (rows < 0 || cols < 0) {
                return null;
            }
            Configuration config = new Configuration();
            List<KeyDef> keyDefs = config.KeyDefs;
            for (int row = 0; row < rows; row++) {
                for (int col = 0; col < cols; col++) {
                    keyDefs.Add(new KeyDef("", "", KeyDef.KeyType.UNUSED, row, col));
                }
            }
            config.sort();
            config.calculateRowsCols();
            return config;
        }

        /// <summary>
        /// Calculates the number of rows and columns.
        /// </summary>
        public void calculateRowsCols() {
            // Get the table size
            rows = -1;
            cols = -1;
            foreach (KeyDef keyDef in keyDefs) {
                if (keyDef.Col > cols) cols = keyDef.Col;
                if (keyDef.Row > rows) rows = keyDef.Row;
            }
            rows += 1;
            cols += 1;
        }

        /// <summary>
        /// Delete the specified row.
        /// </summary>
        /// <param name="row"></param>
        public void deleteRow(int row) {
            keyDefs.RemoveAll(keyDef => keyDef.Row == row);
            // Decrease row numbers
            foreach (KeyDef keyDef in keyDefs) {
                if (keyDef.Row > row) keyDef.Row--;
            }
            calculateRowsCols();
        }

        /// <summary>
        /// Delete the specified column.
        /// </summary>
        /// <param name="col"></param>
        public void deleteCol(int col) {
            keyDefs.RemoveAll(keyDef => keyDef.Col == col);
            // Decrease col numbers
            foreach (KeyDef keyDef in keyDefs) {
                if (keyDef.Col > col) keyDef.Col--;
            }
            calculateRowsCols();
        }

        /// <summary>
        /// Insert a row of KeyDef's with type UNUSED before the specified row.
        /// </summary>
        /// <param name="row"></param>
        public void insertRowBefore(int row) {
            if (row < 0) return;
            // Increase row numbers
            foreach (KeyDef keyDef in keyDefs) {
                if (keyDef.Row >= row) keyDef.Row++;
            }
            // Add Rows
            for (int col = 0; col < Cols; col++) {
                keyDefs.Add(
                    new KeyDef("", "", KeyDef.KeyType.UNUSED, row, col));
            }
            calculateRowsCols();
        }

        /// <summary>
        /// Insert a row of KeyDef's with type UNUSED after the specified row.
        /// </summary>
        /// <param name="row"></param>
        public void insertRowAfter(int row) {
            if (row < 0) return;
            // Increase row numbers
            foreach (KeyDef keyDef in keyDefs) {
                if (keyDef.Row > row) keyDef.Row++;
            }
            // Add Rows
            for (int col = 0; col < Cols; col++) {
                keyDefs.Add(
                    new KeyDef("", "", KeyDef.KeyType.UNUSED, row + 1, col));
            }
            calculateRowsCols();
        }

        /// <summary>
        /// Insert a column of KeyDef's with type UNUSED before the specified
        /// column.
        /// </summary>
        /// <param name="col"></param>
        public void insertColBefore(int col) {
            if (col < 0) return;
            // Increase col numbers
            foreach (KeyDef keyDef in keyDefs) {
                if (keyDef.Col >= col) keyDef.Col++;
            }
            // Add Rows
            for (int row = 0; row < Rows; row++) {
                keyDefs.Add(
                    new KeyDef("", "", KeyDef.KeyType.UNUSED, row, col));
            }
            calculateRowsCols();
        }

        /// <summary>
        /// Insert a column of KeyDef's with type UNUSED after the specified
        /// column.
        /// </summary>
        /// <param name="col"></param>
        public void insertColAfter(int col) {
            if (col < 0) return;
            // Increase col numbers
            foreach (KeyDef keyDef in keyDefs) {
                if (keyDef.Col > col) keyDef.Col++;
            }
            // Add Rows
            for (int row = 0; row < Rows; row++) {
                keyDefs.Add(
                    new KeyDef("", "", KeyDef.KeyType.UNUSED, row, col + 1));
            }
            calculateRowsCols();
        }

        /// <summary>
        /// Sort the list according to row then column.
        /// </summary>
        public void sort() {
            keyDefs.Sort((keyDef1, keyDef2) => {
                int res = keyDef1.Row.CompareTo(keyDef2.Row);
                if (res == 0) res = keyDef1.Col.CompareTo(keyDef2.Col);
                return res;
            });
            calculateRowsCols();
        }

        /// <summary>
        /// Sets the size as a multiple of the specified width and height.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void setSizeForKeySize(int width, int height) {
            calculateRowsCols();
            Size = new Size(Cols * width, Rows * height);
        }

        /// <summary>
        /// Checks if the Configuration has a valid FG color string.
        /// </summary>
        /// <returns></returns>
        public bool isValidFGColorString() {
            return isValidColorString(fgColorString);
        }

        /// <summary>
        /// Checks if the Configuration has a valid BG color string.
        /// </summary>
        /// <returns></returns>
        public bool isValidBGColorString() {
            return isValidColorString(bgColorString);
        }

        /// <summary>
        /// Gets a Color for the foreground. It is better to check if the 
        /// current colorString is valid first to avoid an Exception.  Color 
        /// is not nullable so there is always a return Color, not null.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">
        /// Thrown for invalid colorString</exception>
        public Color getFgColor() {
            return hexStringToColor(fgColorString);
        }

        /// <summary>
        /// Gets a Color for the background. It is better to check if the 
        /// current colorString is valid first to avoid an Exception.  Color 
        /// is not nullable so there is always a return Color, not null.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">
        /// Thrown for invalid colorString</exception>
        public Color getBgColor() {
            return hexStringToColor(bgColorString);
        }

        /// <summary>
        /// Checks if a color string is valid, i.e., of the form #RRGGBB where
        /// R, G, and B are valid hex characters.
        /// </summary>
        /// <param name="colorString"></param>
        /// <returns></returns>
        public static bool isValidColorString(string colorString) {
            if (colorString == null || colorString.Length != 7
                || !colorString.StartsWith("#")) {
                return false;
            }
            bool isValid;
            char[] charArray = colorString.Substring(1).ToCharArray();
            foreach (char c in charArray) {
                isValid = ((c >= '0' && c <= '9') ||
                         (c >= 'a' && c <= 'f') ||
                         (c >= 'A' && c <= 'F'));

                if (!isValid) return false;
            }
            return true;
        }

        /// <summary>
        /// Converts a Color to a string of the form #RRGGBB.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static string colorToHexString(Color color) {
            return String.Format("#{0:X2}{1:X2}{2:X2}",
                color.R, color.G, color.B);
        }

        /// <summary>
        /// Converts a string of the form #RRGGBB to a Color.
        /// </summary>
        /// <param name="colorString"></param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">
        /// Thrown for invalid colorString</exception>
        public static Color hexStringToColor(String colorString) {
            if (!isValidColorString(colorString)) {
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

        /// <summary>
        /// Gets the combined FontStyle from the FontStyleFlags.
        /// </summary>
        /// <returns></returns>
        public FontStyle getFontStyle() {
            FontStyle style = FontStyle.Regular;
            if (fontFlags.Bold) style |= FontStyle.Bold;
            if (fontFlags.Italic) style |= FontStyle.Italic;
            if (fontFlags.Underline) style |= FontStyle.Underline;
            if (fontFlags.Strikeout) style |= FontStyle.Strikeout;
            return style;
        }

        /// <summary>
        /// Set the FontStyleFlags from the given paramters.
        /// </summary>
        /// <param name="bold"></param>
        /// <param name="italic"></param>
        /// <param name="strikeout"></param>
        /// <param name="underline"></param>
        public void setFontStyle(bool bold, bool italic, bool underline, bool strikeout) {
            fontFlags.Bold = bold;
            fontFlags.Italic = italic;
            fontFlags.Strikeout = strikeout;
            fontFlags.Underline = underline;
        }

        // Getters and setters
        public List<KeyDef> KeyDefs
        {
            get
            {
                return keyDefs;
            }

            set
            {
                keyDefs = value;
                calculateRowsCols();
            }
        }

        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public int Rows
        {
            get
            {
                return rows;
            }

            set
            {
                rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return cols;
            }

            set
            {
                cols = value;
            }
        }

        public string FontName
        {
            get
            {
                return fontName;
            }

            set
            {
                fontName = value;
            }
        }

        public float FontSize
        {
            get
            {
                return fontSize;
            }

            set
            {
                fontSize = value;
            }
        }

        public FontStyleFlags FontFlags
        {
            get
            {
                return fontFlags;
            }

            set
            {
                fontFlags = value;
            }
        }

        public string FgColorString
        {
            get
            {
                return fgColorString;
            }

            set
            {
                fgColorString = value;
            }
        }

        public string BgColorString
        {
            get
            {
                return bgColorString;
            }

            set
            {
                bgColorString = value;
            }
        }

        /// <summary>
        /// Class to manage font styles.
        /// </summary>
        public class FontStyleFlags {
            private bool bold;
            private bool italic;
            private bool strikeout;
            private bool underline;

            public FontStyleFlags() {
            }

            public bool Bold
            {
                get
                {
                    return bold;
                }

                set
                {
                    bold = value;
                }
            }

            public bool Italic
            {
                get
                {
                    return italic;
                }

                set
                {
                    italic = value;
                }
            }

            public bool Strikeout
            {
                get
                {
                    return strikeout;
                }

                set
                {
                    strikeout = value;
                }
            }

            public bool Underline
            {
                get
                {
                    return underline;
                }

                set
                {
                    underline = value;
                }
            }
        }
    }
}
