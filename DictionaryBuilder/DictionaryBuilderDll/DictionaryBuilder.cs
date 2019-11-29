using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DictionaryBuilderDll
{
    public class DictionaryBuilder
    {

        
        public Dictionary<string, string> BuildDictFromFile(string path, Alphabets alphabet)
        {
            var phoneticDict = PhoneticDictionaries.GetPhonticDictionary(alphabet);
            var dict = new Dictionary<string, string>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    var dictEntry = BuildDicEntryFromLine(line, phoneticDict);
                    dict.Add(dictEntry.Item1, dictEntry.Item2);
                }
            }
            return dict;
        }
        public static Tuple<string, string> BuildDicEntryFromLine(string line, Dictionary<string, string> phoneticDict)
        {
            //remove numbers for stress
            string cleanLine = new string(line.Where(c => (char.IsLetter(c) || char.IsWhiteSpace(c))).ToArray()); 
            
            string[] wordArray = cleanLine.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).ToArray(); 
            
            if (wordArray.Count() < 2) 
                return new Tuple<string, string>("", "");

            string phoneticWord = ArpabetArrayToPhonetic(wordArray, phoneticDict);
            return new Tuple<string, string>(wordArray[0], phoneticWord);
        }

        private static string ArpabetArrayToPhonetic(string[] arpaArray, Dictionary<string, string> phoneticDict)
        {
            string res = string.Empty;
            for (int i = 0; i < arpaArray.Length; i++)
            {
                string phonetic = string.Empty;
                phoneticDict.TryGetValue(arpaArray[i], out phonetic);
                res += phonetic;
            }
            return res;
        }
    }
}
