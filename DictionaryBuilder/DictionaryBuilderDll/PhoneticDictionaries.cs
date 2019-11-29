using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryBuilderDll
{
    public enum Alphabets
    {
        Cyrillic,
        Croatian,
        German
    }
    class PhoneticDictionaries
    {
        public static Dictionary<string, string> GetPhonticDictionary(Alphabets alphabet)
        {
            switch (alphabet)
            {
                case Alphabets.Cyrillic:
                    return cyrillic; break;
                case Alphabets.Croatian:
                    return cyrillic; break;
                case Alphabets.German:
                    return cyrillic; break;
            }
            return cyrillic;
        }
        //"ACCUSATION  AE2 K Y AH0 Z EY1 SH AH0 N"
        public static Dictionary<string, string> cyrillic = new Dictionary<string, string>()
        {
            { "AA", "а" },
            { "AE", "a" }, //e
            { "AH", "" }, //a
            { "AO", "о" },
            { "AW", "ау" },
            { "AY", "ај" },
            { "B", "б" },
            { "CH", "ч" },
            { "D", "д" },
            { "DH", "д" },
            { "EH", "е" },
            { "ER", "р" },
            { "EY", "еј" },
            { "F", "ф" },
            { "G", "г" },
            { "HH", "х" },
            { "IH", "и" },
            { "IY", "и" },
            { "JH", "џ" },
            { "K", "к" },
            { "L", "л" },
            { "M", "м" },
            { "N", "н" },
            { "NG", "нг" },
            { "OW", "оу" },
            { "OY", "ој" },
            { "P", "п" },
            { "R", "р" },
            { "S", "с" },
            { "SH", "ш" },
            { "T", "т" },
            { "TH", "т" },
            { "UH", "у" },
            { "V", "в" },
            { "W", "у" },
            { "Y", "ј" },
            { "Z", "з" },
            { "ZH", "ж" }
        };
    }
}

