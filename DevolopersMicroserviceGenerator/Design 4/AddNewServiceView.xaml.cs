
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
            string currUsername = Environment.UserName;
            string[] dirs = Directory.GetFiles(@$"C:\Users\{currUsername}\.templateengine\", "templatecache.json", SearchOption.AllDirectories);
            dir = dirs[0];
            string json = File.ReadAllText($"{dir}");
            //var message = JsonConvert.DeserializeObject<List<string>>(json);

            //foreach (var item in message)
            //{
            //    res.Add(item);
            //}

            //Console.WriteLine(message);


            //res.Add((string)obj.TemplateInfo.Parameters.Name);
            //*****************************************************

            InitializeComponent();

            //Functionality.SeedingListOfTemplates();
            //FeedbackFromPowerShellRun(script);
            
            
            //res.Remove("Short Name");
            //res.Remove("Template Name");
            //res.Remove("These templates matched your input:");
            //res.Remove("  Language");
            //res.Remove(" Tags");
            //res.Remove("[C#]");
            //res.Remove("[F#]");

            foreach (string r in res)
            {
                listBoxOfTemplates.Items.Add(r);
            }


            //foreach (string template in Functionality.templates)
            //{
            //    listBoxOfTemplates.Items.Add(template);
            //}

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

        //private static void FeedbackFromPowerShellRun(string script)
        //{

        //    using (var powershell = PowerShell.Create())
        //    {
        //        string r;
        //        string[] listOfr;
        //        powershell.AddScript(script);
        //        Collection<PSObject> results = powershell.Invoke();

        //        foreach (PSObject result in results)
        //        {
        //            r = result.ToString().Replace("   ",",");
        //            r = r.Trim();
        //            listOfr = r.ToString().Split(',');
                    
        //            foreach (string s in listOfr)
        //            {

                            
        //                if (s != "")
                            
        //                    res.Add(s);
        //            }
        //            //r = result.ToString().Trim();
        //            //if (r.Contains(""))

                    
        //        }
        //    }
        //}
    }
}
