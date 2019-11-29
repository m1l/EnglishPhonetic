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
            Console.WriteLine("Building Dictionary from file...");
            var d = dictionaryBuilder.BuildDictFromFile(path, Alphabets.Cyrillic);

            Console.WriteLine("Saving Dictionary to file...");
            string savePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                @"CyrillicDict.txt");
            dictionaryBuilder.SaveDictionaryToFile(savePath, d);
            Console.WriteLine("Done");
            //var test = DictionaryBuilder.BuildDicEntryFromLine("MARKETPLACE  M AA1 R K AH0 T P L EY2 S");
            //var testvalue = dictionaryBuilder.sum(1, 2);
            //Console.WriteLine(testvalue.ToString());
            //Console.ReadLine();
        }


        
    }
}
