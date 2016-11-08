using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtPad {
    public static class Constants {
        public const string VERSION = "ArtPad 1.0.0";


        public static List<KeyConfig> TestKeyConfigs
        {
            get
            {
                {
                    return new List<KeyConfig>{
            new KeyConfig("A","A", KeyConfig.KeyType.NORMAL, 0, 0),
            new KeyConfig("B","B", KeyConfig.KeyType.NORMAL, 0, 1),
            new KeyConfig("C","C", KeyConfig.KeyType.NORMAL, 0, 2),
            new KeyConfig("D","D", KeyConfig.KeyType.NORMAL, 0, 3),
            new KeyConfig("a","a", KeyConfig.KeyType.NORMAL, 1, 0),
            new KeyConfig("b","b", KeyConfig.KeyType.NORMAL, 1, 1),
            new KeyConfig("c","c", KeyConfig.KeyType.NORMAL, 1, 2),
            new KeyConfig("d","d", KeyConfig.KeyType.NORMAL, 1, 3),
            new KeyConfig("Ctrl","Ctrl", KeyConfig.KeyType.HOLD, 2, 0),
            new KeyConfig("Alt","Alt", KeyConfig.KeyType.NORMAL, 2, 1),
            new KeyConfig("Copy","Ctrl+C", KeyConfig.KeyType.NORMAL, 2, 2),
            new KeyConfig("Paste","Ctrl+V", KeyConfig.KeyType.NORMAL, 2, 3),
        };
                }
            }
        }
    }
}


