using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryBuilderDll
{
    public enum Alphabets
    {
        Cyrillic,
        Latin,
        German,
        Simple,
        Latinica
    }
    class PhoneticDictionaries
    {
        public static Dictionary<string, string> GetPhonticDictionary(Alphabets alphabet)
        {
            switch (alphabet)
            {
                case Alphabets.Cyrillic:
                    return cyrillic; break;
                case Alphabets.Simple:
                    return simple; break;
                case Alphabets.Latinica:
                    return latinica; break;
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
            { "W", "в" }, //Wise
            { "WH", "у" }, //WHy
            { "Y", "ј" }, //Yacht
            { "Z", "з" }, //Zoo
            { "ZH", "ж" } //pleaSure
        };

        public static Dictionary<string, string> simple = new Dictionary<string, string>()
        {
            { "AA", "a" }, //bOt
            { "AE", "e" }, //bAt 
            { "AH", "a" }, //bUtt
            //{ "AH", "" }, //bUtt sometimes silent
            { "AO", "o" }, //stOry
            { "AW", "ou" }, //bOUt ???
            { "AX", "a" }, //commA //new
            { "AXR", "er" }, //lettER //new
            { "AY", "aj" }, //bIte //new
            { "B", "b" }, //Buy
            { "CH", "ch" }, //CHina
            { "D", "d" }, //Die
            { "DH", "t" }, //THy
            { "DX", "t" }, //buTTEr //maybe empty
            { "EH", "e" }, //bEt
            { "EL", "le" }, //bottLE
            { "EM", "m" }, //rythM
            { "EN", "n" }, //buttON
            { "ER", "r" }, //bIRd
            { "EY", "ej" }, //bAIt
            { "F", "f" }, //Fight
            { "G", "g" }, //Guy
            { "HH", "h" }, //High
            { "H", "h" }, //High
            { "IH", "i" }, //bIt
            { "IX", "i" }, //rabbIt
            { "IY", "i" }, //bIt
            { "JH", "џ" }, //Jive
            { "K", "k" }, //Kite
            { "L", "l" }, //Lie
            { "M", "m" }, //My
            { "N", "n" }, //Nigh
            { "NG", "ng" }, //siNG
            { "NX", "n" }, //wiNNer
            { "OW", "ou" }, //bOAt
            { "OY", "oj" }, //bOY
            { "P", "p" }, //Pie
            { "Q", "" }, //"oh-oh"
            { "R", "r" }, //Rye
            { "S", "s" }, //Sigh
            { "SH", "s" }, //SHy
            { "T", "t" }, //Tie
            { "TH", "t" }, //Thigh
            { "UH", "u" }, //bOOk
            { "UW", "u" }, //bOOt
            { "UX", "u" }, //dUde
            { "V", "v" }, //Vie
            { "W", "v" }, //Wise
            { "WH", "wa" }, //WHy
            { "Y", "j" }, //Yacht
            { "Z", "z" }, //Zoo
            { "ZH", "z" } //pleaSure
        };


        public static Dictionary<string, string> latinica = new Dictionary<string, string>()
        {
            { "AA1", "a" }, //bOt
            { "AA0", "a" }, //PROGNOSIS  P R AA0 G N OW1 S AH0 S
            { "AE0", "e" }, //bAt 
            { "AE1", "e" }, //bAt 
            { "AH1", "a" }, //bUtt
            { "AH0", "" }, //bUtt
            //{ "AH", "" }, //bUtt sometimes silent
            { "AO", "o" }, //stOry
            { "AW", "ou" }, //bOUt ???
            { "AX", "a" }, //commA //new
            { "AXR", "er" }, //lettER //new
            { "AY", "aj" }, //bIte //new
            { "B", "b" }, //Buy
            { "CH", "č" }, //CHina
            { "D", "d" }, //Die
            { "DH", "ð" }, //THy THis https://en.wikipedia.org/wiki/D_with_stroke
            { "DX", "t" }, //buTTEr //maybe empty 
            { "EH1", "e" }, //bEt
            { "EL", "le" }, //bottLE
            { "EM", "m" }, //rythM
            { "EN", "n" }, //buttON
            { "ER", "ər" }, //bIRd
            { "EY", "ej" }, //bAIt
            { "F", "f" }, //Fight
            { "G", "g" }, //Guy
            { "HH", "h" }, //High
            { "H", "h" }, //High
            { "IH", "i" }, //bIt
            { "IH0", "i" }, // EVEN  IY1 V IH0 N , but EXISTING  IH0 G Z IH1 S T IH0 NG
            { "IX", "i" }, //rabbIt
            { "IY", "i" }, //bIt
            { "JH", "ƌ" }, //Jive https://altcodeunicode.com/alt-codes-letter-d-with-accents/
            { "K", "k" }, //Kite
            { "L", "l" }, //Lie
            { "M", "m" }, //My
            { "N", "n" }, //Nigh
            { "NG", "ng" }, //siNG
            { "NX", "n" }, //wiNNer
            { "OW", "ou" }, //bOAt
            { "OY", "oj" }, //bOY
            { "P", "p" }, //Pie
            { "Q", "" }, //"oh-oh"
            { "R", "r" }, //Rye
            { "S", "s" }, //Sigh
            { "SH", "š" }, //SHy
            { "T", "t" }, //Tie
            { "TH", "ŧ" }, //Thigh
            { "UH", "u" }, //bOOk
            { "UW", "ū" }, //bOOt
            { "UX", "ū" }, //dUde
            { "V", "v" }, //Vie
            { "W", "w" }, //Wise ʋ
            { "WH", "wa" }, //WHy
            { "Y", "j" }, //Yacht
            { "Z", "z" }, //Zoo
            { "ZH", "ž" } //pleaSure
        };
    }
}

