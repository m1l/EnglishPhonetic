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
        //ARPABET list from https://en.wikipedia.org/wiki/ARPABET
        public static Dictionary<string, string> cyrillic = new Dictionary<string, string>()
        {
            { "AA", "а" }, //bOt
            { "AE", "е" }, //bAt 
            { "AH", "а" }, //bUtt
            //{ "AH", "" }, //bUtt sometimes silent
            { "AO", "о" }, //stOry
            { "AW", "ау" }, //bOUt ???
            { "AX", "а" }, //commA //new
            { "AXR", "р" }, //lettER //new
            { "AY", "ај" }, //bIte //new
            { "B", "б" }, //Buy
            { "CH", "ч" }, //CHina
            { "D", "д" }, //Die
            { "DH", "д" }, //THy
            { "DX", "д" }, //buTTEr //maybe empty
            { "EH", "е" }, //bEt
            { "EL", "л" }, //bottLE
            { "EM", "м" }, //rythM
            { "EN", "н" }, //buttON
            { "ER", "р" }, //bIRd
            { "EY", "еј" }, //bAIt
            { "F", "ф" }, //Fight
            { "G", "г" }, //Guy
            { "HH", "х" }, //High
            { "H", "х" }, //High
            { "IH", "и" }, //bIt
            { "IX", "и" }, //rabbIt
            { "IY", "и" }, //bIt
            { "JH", "џ" }, //Jive
            { "K", "к" }, //Kite
            { "L", "л" }, //Lie
            { "M", "м" }, //My
            { "N", "н" }, //Nigh
            { "NG", "нг" }, //siNG
            { "NX", "нг" }, //wiNNer
            { "OW", "оу" }, //bOAt
            { "OY", "ој" }, //bOY
            { "P", "п" }, //Pie
            { "Q", "" }, //"oh-oh"
            { "R", "р" }, //Rye
            { "S", "с" }, //Sigh
            { "SH", "ш" }, //SHy
            { "T", "т" }, //Tie
            { "TH", "т" }, //Thigh
            { "UH", "у" }, //bOOk
            { "UW", "у" }, //bOOt
            { "UX", "у" }, //dUde
            { "V", "в" }, //Vie
            { "W", "у" }, //Wise
            { "WH", "у" }, //WHy
            { "Y", "ј" }, //Yacht
            { "Z", "з" }, //Zoo
            { "ZH", "ж" } //pleaSure
        };
    }
}

