using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Management.Automation;
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

namespace Design_4
{
    /// <summary>
    /// Interaction logic for AddNewTemplate.xaml
    /// </summary>
    public partial class AddNewTemplate : Page
    {
        public AddNewTemplate()
        {
            InitializeComponent();
        }

        private void findNugetFileBtn(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Nuget files (*.nupkg)|*.nupkg|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
                templatePathTextBox.Text = openFileDialog.FileName;
            //templatePathTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+openFileDialog.FileName;

        }

        private void nextBtnAddNewTemplate(object sender, MouseButtonEventArgs e)
        {
;
        }

        private void RunScript(string script)
        {
            
            using (var powershell = PowerShell.Create())
            {
                powershell.AddScript(script);
                Collection<PSObject> results = powershell.Invoke();

                foreach (PSObject result in results)
                {
                    powerShellOutputListBox.Items.Add(result.ToString());
                }
            }
        }

        private void installTemplateBtn(object sender, RoutedEventArgs e)
        {
            string templatePath = templatePathTextBox.Text;
            templatePath = templatePath.Replace(" ", "` ");
            string script = @$"dotnet new --install {templatePath}";
            RunScript(script);
        }
    }
}
