using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using DictionaryBuilderDll;
using Microsoft.Win32;

namespace PhoneticTranslator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, string> dict;
        public MainWindow()
        {
            InitializeComponent();
            textBox.Text = "The quick brown fox, jumps over the lazy dog. The End!";
            string phoneticDictPath = GetDictionaryPath();
            if (string.IsNullOrWhiteSpace(phoneticDictPath))
                return;
            dict = DictionaryBuilder.LoadDictFromFile(phoneticDictPath);
        }

        private string GetDictionaryPath()
        {
            string phoneticDictPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location),
                @"CyrillicDict.txt");
            if (!File.Exists(phoneticDictPath))
                phoneticDictPath = Properties.PhoneticTranslator.Default.PhoneticDictPath;
            while (!File.Exists(phoneticDictPath))
            {
                string DictionariesLocation = string.Empty;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == true)
                {
                    phoneticDictPath = openFileDialog.FileName;
                }
                else
                    break;
                Properties.PhoneticTranslator.Default.PhoneticDictPath = phoneticDictPath;
                Properties.PhoneticTranslator.Default.Save();
            }
            return phoneticDictPath;
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            string sourceText = textBox.Text;
            string parsedText = DictionaryBuilderDll.TextParser.Parse(sourceText, ref dict);
            textBox.Text = parsedText;
        }
    }
}
