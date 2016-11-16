using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ArtPad {
    public class Configuration {
        private List<KeyDef> keyDefs = new List<KeyDef>();
        private Size size = new Size(300, 300);

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

        public static void writeConfig(Configuration config, string fileName) {
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            System.IO.File.WriteAllText(fileName, json);
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
    }
}
