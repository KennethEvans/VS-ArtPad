using Newtonsoft.Json;

namespace ArtPad {
    public class KeyDef {
        public enum KeyType { NORMAL, HOLD, COMMAND, UNUSED };

        private string name;
        private string keyString;
        private KeyType type = KeyType.NORMAL;
        private int row;
        private int col;
        private bool pressed;

        [JsonConstructor]
        public KeyDef(string name, string keyString, KeyType type, int row, int col) {
            this.name = name;
            this.keyString = keyString;
            this.type = type;
            this.row = row;
            this.col = col;
        }

        /// <summary>
        /// Copy constructor.
        /// </summary>
        /// <param name="keyDef"></param>
        public KeyDef(KeyDef keyDef) {
            this.name = keyDef.name;
            this.keyString = keyDef.keyString;
            this.type = keyDef.type;
            this.row = keyDef.row;
            this.col = keyDef.col;
        }

        // Getters and setters
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string KeyString
        {
            get
            {
                return keyString;
            }

            set
            {
                keyString = value;
            }
        }

        public KeyType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Row
        {
            get
            {
                return row;
            }

            set
            {
                row = value;
            }
        }

        public int Col
        {
            get
            {
                return col;
            }

            set
            {
                col = value;
            }
        }

        public bool Pressed
        {
            get
            {
                return pressed;
            }

            set
            {
                pressed = value;
            }
        }
    }
}
