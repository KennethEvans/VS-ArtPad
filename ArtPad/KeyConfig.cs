namespace ArtPad {
    public class KeyConfig {
        public enum KeyType { NORMAL, HOLD, COMMAND };

        private string name;
        private string keyString;
        private KeyType type = KeyType.NORMAL;
        private int row;
        private int col;
        private bool pressed;

        public KeyConfig(string name, string keyString, KeyType type, int row, int col) {
            this.name = name;
            this.keyString = keyString;
            this.type = type;
            this.row = row;
            this.col = col;
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
