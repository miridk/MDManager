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
using System.Windows.Shapes;

namespace DMGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string textToReplace;
        public string text;
        string rootfolder = @"C:\Temp";

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void replaceButton_Click(object sender, RoutedEventArgs e)
        {
            ReplaceTags();
        }

        public void ReplaceTags()
        {
            textToReplace = textToReplaceTextBox.Text;
            text = tagNameTextBox.Text;
            rootfolder = @"C:\Temp";
            string[] files = Directory.GetFiles(rootfolder, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                try
                {
                    string contents = File.ReadAllText(file);
                    contents = contents.Replace(textToReplace, text);
                    // Make files writable
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.WriteAllText(file, contents);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
