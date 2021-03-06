using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
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
    /// Interaction logic for NameProject.xaml
    /// </summary>
    public partial class NameProject : Page
    {
        public static string projectName = "";
        public NameProject()
        {
            InitializeComponent();
        }

        public void nextBtnNameProject(object sender, MouseButtonEventArgs e)
        {
           
            string templ = Functionality.templateOfChoice;
            projectName = propertyNameTextBox.Text;
            projectName = projectName.Replace(" ", "_");
            //string script = @"dotnet new --install c:\temp\webapi.template.dotnet6.01.1.0.1.nupkg";
            //RunScript(script);
            string script = @$"dotnet new {templ} -o c:\temp\Template\{projectName}"; 
            RunScript(script);
        }


        private static void RunScript(string script)
        {
            using (var powershell = PowerShell.Create())
            {
                powershell.AddScript(script);
                Collection<PSObject> results = powershell.Invoke();

                foreach (PSObject result in results)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
