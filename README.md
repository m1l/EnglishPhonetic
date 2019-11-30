# EnglishPhonetic
##What it does
This program just converts English text into phonetic alphabet. Serbian Language has phonetic ortography and with the cyrilic alphabet it has "one-letter-one-sound" system. This program explores readability of text written this way and will be extended with support for other alphabet. 
and this produces:
Дис проугрем џист канвртс Ингглиш текст инту фанетик елфабет. Србин Ленггвиџ хез фанетик ortography енд вид ди cyrilic елфабет ит хез "вн-летр-вн-саунд" систм. Дис проугрем иксплорз ридабилити ав текст ритн дис веј енд вил би икстендид вид сапорт фор адр елфабет. 

Phonetic spelling  uses dictionary
CMUdict from Carnegie Mellon University

##For devlopers
You need VS2019 and .NET 
Open DictionaryBuilder.sln
If you run DictionaryBuilderConsole  project, it will use
DictionaryBuilder\DictionaryBuilder\dict.txt
and parse it through rules from
DictionaryBuilder\DictionaryBuilderDll\PhoneticDictionaries.cs
and create new dictionary
DictionaryBuilder\DictionaryBuilder\bin\Debug\netcoreapp3.0\CyrillicDict.txt
which will contain pairs like
percent,прсент
Then if you run "PhoneticTranslator" project you will get a WPF GUI app. Read the non-developers part...

##For non-developers
You can directly run already compiled
DictionaryBuilder\PhoneticTranslator\bin\Debug\netcoreapp3.0\PhoneticTranslator.exe
On the start it will ask you to select a dictionary. This is the one created with DictionaryBuilderConsole
Select the 
DictionaryBuilder\DictionaryBuilder\bin\Debug\netcoreapp3.0\CyrillicDict.txt
Now you can paste any text into the text are and click Convert button

##Future
Croatian or Lattin alphabet, then a version for German, Esperanto, and Spanish can be added 





