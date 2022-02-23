using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace Design_4
{
    /// <summary>
    /// Interaction logic for AddNewServiceView.xaml
    /// </summary>
    public partial class AddNewServiceView : Page
    {
        private static List<string> res = new List<string>();
        string script = "dotnet new -l";

        public AddNewServiceView()
        {
            InitializeComponent();

            res.Clear();
            FeedbackFromPowerShellRun(script);
            res.RemoveAt(0);
            res.RemoveAt(0);
            listBoxOfTemplates.Items.Clear();
            for (int b = 0 ; b < res.Count; b++)
            {
                listBoxOfTemplates.Items.Add(res[b].ToString());
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
            using var ps = PowerShell.Create();
            string r;
            string[] listOfr;
            ps.AddScript(script);
            Collection<PSObject> results = ps.Invoke();

            for (int i = 0; i < results.Count; i++)
            {
                r = Regex.Replace(results[i].ToString(), @"\s\s+", ",");

                listOfr = r.Split(',');

                if (listOfr.Length > 1)
                {
                    res.Add(listOfr[1]);
                }
            }
        }

        private void addNewTemplate_Clicked(object sender, MouseButtonEventArgs e)
        {
         
        }
    }
}
