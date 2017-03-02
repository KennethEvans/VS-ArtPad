using System;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace ArtPad {
    public class Configuration {
        private List<KeyDef> keyDefs = new List<KeyDef>();
        private Size size = new Size(300, 300);
        private int rows = 0;
        private int cols = 0;
        private string fontName="";
        private float fontSize;

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
    }
}
