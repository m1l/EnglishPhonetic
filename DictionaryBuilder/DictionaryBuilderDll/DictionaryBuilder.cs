using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace DictionaryBuilderDll
{
    public class DictionaryBuilder
    {

        
        public Dictionary<string, string> BuildDictFromFile(string path, Alphabets alphabet)
        {
            var phoneticDict = PhoneticDictionaries.GetPhonticDictionary(alphabet);
            var dict = new Dictionary<string, string>();
            string previousLine = string.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    var dictEntry = BuildDicEntryFromLine(line, phoneticDict);
                    if (dict.ContainsKey(dictEntry.Item1)) //tryadd is only in .NET Standard 2.1, and we are targetting 2.0
                    {
                        //this is the word in (1) as alternative pronouncination
                        //AH it better silent
                        if (Regex.Matches(previousLine, "AH", RegexOptions.None).Count >
                            Regex.Matches(line, "AH", RegexOptions.None).Count)
                        {
                            dict.Remove(dictEntry.Item1);
                        }
                        else
                            continue;
                    }
                    //if (dictEntry.Item1.ToLower().Equals("cause"))
                    //    continue;
                    dict.Add(dictEntry.Item1, dictEntry.Item2);
                    previousLine = line;
                }
            }
            return dict;
        }

        public void SaveDictionaryToFile(string path, Dictionary<string, string> dictionary)
        {
            FileStream fileStream = File.Open(path, FileMode.Create); // will create the file or overwrite it if it already exists
            using (StreamWriter sw = new StreamWriter(fileStream))
            {
                foreach (KeyValuePair<string, string> entry in dictionary)
                {
                    sw.WriteLine(entry.Key+","+entry.Value);
                }
            }
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
            for (int i = 1; i < arpaArray.Length; i++) //first is the word
            {
                string phonetic = string.Empty;
                //if (i == 1 && arpaArray[1].Equals("AH"))
                //    arpaArray[1] = "-AH"; //improvisation so we hear this sound

                if (i == arpaArray.Length - 2 && arpaArray[i].Equals("AH"))
                    continue; //ah is silent at the penultimate place
                //    arpaArray[1] = "-AH"; //improvisation so we hear this sound

                phoneticDict.TryGetValue(arpaArray[i], out phonetic);
                res += phonetic;
            }
            return res;
        }
    }
}
