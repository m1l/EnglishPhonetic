using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DictionaryBuilderDll
{
    public class TextParser
    {
        public static string Parse(string input, ref Dictionary<string, string> dict)
        {
            var inputArray = input.ToCharArray();
            string output = string.Empty;
            string word = string.Empty;
            long p = 0;
            while (p<inputArray.Length)
            {
                word = string.Empty;
                char c = inputArray[p];
                if (!char.IsLetter(c))
                {
                    output += c;
                    p++;
                }
                else
                {
                    bool isUppercase = char.IsUpper(inputArray[p]);
                    while (char.IsLetter(inputArray[p]))
                    {
                        word += inputArray[p];
                        p++;
                        if (p >= inputArray.Length)
                            break;
                    }
                    string translated  = Translate(word, ref dict);
                    if (isUppercase && translated != "aj") //avoid uppercasing I into Aj
                    {
                        output += translated.First().ToString().ToUpper();
                        if (translated.Length > 1)
                            output += translated.Substring(1);
                    }
                    else
                        output += translated;
                    //output += inputArray[p];
                }
                
            }
            return output;
        }

        private static string Translate(string word, ref Dictionary<string, string> dict)
        {
            string translation = string.Empty;
            if (dict.TryGetValue(word.ToLowerInvariant(), out translation))
                return translation;
            else if (dict.TryGetValue(word.ToLowerInvariant() + "s", out translation))
            {
                return translation + "sss";
            }
            else return word;


        }
    }
}
