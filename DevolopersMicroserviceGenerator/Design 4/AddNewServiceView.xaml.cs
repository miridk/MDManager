
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Design_4
{
    /// <summary>
    /// Interaction logic for AddNewServiceView.xaml
    /// </summary>
    public partial class AddNewServiceView : Page
    {
        static List<string> res = new List<string>();
        string script = "dotnet new -l";
        string cleanup;
        string dir;
        public AddNewServiceView()
        {

            //***********Trying to get info from JSON file*********
            //string currUsername = Environment.UserName;
            //string[] dirs = Directory.GetFiles(@$"C:\Users\{currUsername}\.templateengine\", "templatecache.json", SearchOption.AllDirectories);
            //dir = dirs[0];
            //string json = File.ReadAllText($"{dir}");
            //var message = JsonConvert.DeserializeObject<List<string>>(json);
            //foreach (var item in message)
            //{
            //    res.Add(item);
            //}
            //Console.WriteLine(message);
            //res.Add((string)obj.TemplateInfo.Parameters.Name);
            //*****************************************************

            InitializeComponent();
            FeedbackFromPowerShellRun(script);

            listBoxOfTemplates.Items.Clear();
            foreach (string r in res)
            {
                listBoxOfTemplates.Items.Add(r);
            }

            listBoxOfTemplates.SelectedIndex = 0;
        }

        private void nextBtnAddNewService(object sender, MouseButtonEventArgs e)
        {
            if (listBoxOfTemplates.SelectedItem != null)
            {
            Functionality.templateOfChoice = listBoxOfTemplates.SelectedItem.ToString();
            }
            else
            {
                Functionality.templateOfChoice = Functionality.templates[0].ToString();
            }
        }

        private static void FeedbackFromPowerShellRun(string script)
        {

            using (var powershell = PowerShell.Create())
            {
                string r;
                string[] listOfr;
                powershell.AddScript(script);
                Collection<PSObject> results = powershell.Invoke();

                for (int i = 0; i < results.Count; i++)
                {
                    r = results[i].ToString().Replace("   ", ",");
                    listOfr = r.Split(',');
                    res.Add(listOfr[0]);
                }
            }
        }

        private void addNewTemplate_Clicked(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
