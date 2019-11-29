using System;
using System.IO;
using DictionaryBuilderDll;

namespace DictionaryBuilderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DictionaryBuilder dictionaryBuilder = new DictionaryBuilder();
            string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), 
                @"dict.txt");
            var d = dictionaryBuilder.BuildDictFromFile(path, Alphabets.Cyrillic);
            //var test = DictionaryBuilder.BuildDicEntryFromLine("MARKETPLACE  M AA1 R K AH0 T P L EY2 S");
            //var testvalue = dictionaryBuilder.sum(1, 2);
            //Console.WriteLine(testvalue.ToString());
            Console.ReadLine();
        }


        
    }
}
