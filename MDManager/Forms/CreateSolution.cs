using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDManager.Forms
{
    public partial class CreateSolution : Form
    {
        public List<string> props = new List<string>();
        public List<string> types = new List<string>();
        public List<string> required = new List<string>();
        public List<string> key = new List<string>();

        public CreateSolution()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SolutionInstallPath = metroTextBox1.Text;
            string SolutionFolder = solutionNameTextBox.Text;
            string ProjectName = SolutionFolder + "Api";
            string WebApiName = ProjectName + "Service";
            string ApiPortNo = metroTextBox2.Text;
            string HostName = "http://localhost";
            string DevelopmentApi = HostName + ":" + ApiPortNo + "/api/" + ProjectName + "/";
            string FrontendName = SolutionFolder + "Frontend";
            string ProductionApi = ""; //Dont know what this is doing

            string propsJoined = string.Join("-", props);
            string typesJoined = string.Join("-", types);
            string requiredJoined = string.Join("-", required);
            string keysJoined = string.Join("-", key);

            CreateFolders(SolutionFolder, SolutionInstallPath, FrontendName);

            if (webApiCheckBox.Checked)
            {
                InstallWebApi(SolutionFolder, WebApiName, SolutionInstallPath);

                if (entityFrameworkCheckBox.Checked)
                {
                InstallEntetyFrameworkAndAutomapper(SolutionFolder, WebApiName, SolutionInstallPath);
                }

                if (crudCheckBox.Checked)
                {
                    AddCRUDConfiguration(propsJoined, typesJoined, requiredJoined, keysJoined, SolutionFolder, WebApiName, ProjectName, SolutionInstallPath);
                }

                if (runWebAPICheckBox.Checked)
                {
                    RunWebApi(SolutionFolder, WebApiName, HostName, ApiPortNo, ProjectName, SolutionInstallPath);
                }
            }

            if (dockerComposeCheckBox.Checked)
            {
                AddDocker(SolutionFolder, WebApiName, SolutionInstallPath, ApiPortNo);
            }

            if (checkBoxFrontEnd.Checked)
            {
                InstallAngular(SolutionInstallPath, SolutionFolder, FrontendName);
                if (checkBoxPrime.Checked)
                {
                PrimeNGAndSetup(FrontendName, SolutionFolder, SolutionInstallPath);
                }
                if (checkBoxServe.Checked)
                {
                NGServe(SolutionInstallPath, FrontendName, SolutionFolder);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string folderpath = "";
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.ShowNewFolderButton = false;
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            DialogResult dr = fbd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                folderpath = fbd.SelectedPath;
            }

            if (folderpath != "")
            {
                metroTextBox1.Text = folderpath;
            }
        }

        public void PrimeNGAndSetup(string FrontendName, string SolutionFolder, string SolutionInstallPath)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"..\..\Scripts\angular2.ps1"))
                    .AddParameter(null, FrontendName)
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, SolutionInstallPath);
            ps.Invoke();
            PowerShell ps1 = PowerShell.Create();
            ps1.AddScript(File.ReadAllText(@"..\..\Scripts\angular3.ps1"))
                    .AddParameter(null, FrontendName)
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, SolutionInstallPath);
            ps1.Invoke();
            PowerShell ps2 = PowerShell.Create();
            ps2.AddScript(File.ReadAllText(@"..\..\Scripts\angular4.ps1"))
                    .AddParameter(null, FrontendName)
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, SolutionInstallPath);
            ps2.Invoke();
        }

        public void CreateFolders(string SolutionFolder, string SolutionInstallPath, string FrontendName)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"..\..\Scripts\createsolution.ps1"))
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, SolutionInstallPath)
                    .AddParameter(null, FrontendName);
            ps.Invoke();
        }

        public void InstallAngular(string SolutionInstallPath, string SolutionFolder, string FrontendName)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"..\..\Scripts\angular1.ps1"))
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, SolutionInstallPath)
                    .AddParameter(null, FrontendName);
            ps.Invoke();

            string path = SolutionInstallPath +"\\"+ SolutionFolder;

            // this will be the path to your app
            var workingDirectory = @"" + path + "";

            // location of ng command 
            var command = @"ng.cmd";

            // any arguments you want to pass to ng
            //var arguments = "build --prod --base-href /helloworld/ --output-path=prod";
            var arguments = "new " + FrontendName + " --style=scss --routing=true";

            var process = new Process();
            var currentDirectory = Environment.CurrentDirectory;
            try
            {
                Environment.CurrentDirectory = workingDirectory;
                process.StartInfo.FileName = command;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WorkingDirectory = workingDirectory;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();

                // wait for the app to run and grab any output/errors generated
                process.WaitForExit();
                var output = process.StandardOutput.ReadToEnd();
                var errors = process.StandardError.ReadToEnd();
                Console.WriteLine("Output: " + output);
                Console.WriteLine("Errors: " + errors);
            }
            finally
            {
                Environment.CurrentDirectory = currentDirectory;
            }
        }

        public void NGServe(string SolutionInstallPath, string FrontendName, string SolutionFolder)
        {
            string path = SolutionInstallPath + "\\" + SolutionFolder + "\\" + FrontendName;

            // this will be the path to your app
            var workingDirectory = @"" + path + "";

            // location of ng command 
            var command = @"ng.cmd";

            // any arguments you want to pass to ng
            //var arguments = "build --prod --base-href /helloworld/ --output-path=prod";
            var arguments = "serve -o";

            var process = new Process();
            var currentDirectory = Environment.CurrentDirectory;
            try
            {
                Environment.CurrentDirectory = workingDirectory;
                process.StartInfo.FileName = command;
                process.StartInfo.Arguments = arguments;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.WorkingDirectory = workingDirectory;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.Start();

                // wait for the app to run and grab any output/errors generated
                process.WaitForExit();
                var output = process.StandardOutput.ReadToEnd();
                var errors = process.StandardError.ReadToEnd();
                Console.WriteLine("Output: " + output);
                Console.WriteLine("Errors: " + errors);
            }
            finally
            {
                Environment.CurrentDirectory = currentDirectory;
            }
        }

        public void InstallWebApi(string SolutionFolder, string WebApiName, string SolutionInstallPath)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"..\..\Scripts\webapi1.ps1"))
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, WebApiName)
                    .AddParameter(null, SolutionInstallPath);
            ps.Invoke();
        }

        public void InstallEntetyFrameworkAndAutomapper(string SolutionFolder, string WebApiName, string SolutionInstallPath)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"..\..\Scripts\webapi2.ps1"))
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, WebApiName)
                    .AddParameter(null, SolutionInstallPath);
            ps.Invoke();
        }
        
        public void AddCRUDConfiguration(string propsJoined, string typesJoined, string requiredJoined, string keysJoined, string SolutionFolder, string WebApiName, string ProjectName, string SolutionInstallPath)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"..\..\Scripts\webapi3.ps1"))
                    .AddParameter(null, propsJoined)
                    .AddParameter(null, typesJoined)
                    .AddParameter(null, requiredJoined)
                    .AddParameter(null, keysJoined)
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, WebApiName)
                    .AddParameter(null, ProjectName)
                    .AddParameter(null, SolutionInstallPath);
            ps.Invoke();
        }

        public void RunWebApi(string SolutionFolder, string WebApiName, string HostName, string ApiPortNo, string ProjectName, string SolutionInstallPath)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"..\..\Scripts\webapi4.ps1"))
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, WebApiName)
                    .AddParameter(null, HostName)
                    .AddParameter(null, ApiPortNo)
                    .AddParameter(null, ProjectName)
                    .AddParameter(null, SolutionInstallPath)
            .Invoke();
        }

        public void AddDocker(string SolutionFolder, string WebApiName, string SolutionInstallPath, string ApiPortNo)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"..\..\Scripts\webapi-docker.ps1"))
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, WebApiName)
                    .AddParameter(null, SolutionInstallPath)
                    .AddParameter(null, ApiPortNo)
            .Invoke();
        }

        //int B = 1;
        private void addPropertyButton_Click(object sender, EventArgs e)
        {          
            if (propertyNameTextBox.Text != "")
            {
                props.Add(propertyNameTextBox.Text);
                propertyNameTextBox.Clear();
            }

            types.Add(propertyTypeComboBox.Text.ToLower());
            

            if (propertyRequiredCheckBox.Checked)
            {
                required.Add("[Required]");
            }
            else
            {
                required.Add("//x");
            }

            if (propertyKeyCheckBox.Checked)
            {
                key.Add("[Key]");
            }
            else
            {
                key.Add("//x");
            }

            listBox1.Items.Clear();
            int counterOfArraylist = props.Count;
            string[] str = new string[counterOfArraylist];
            for (int i = 0; i < str.Length; i++)
            {
            listBox1.Items.Add("Name: " + props[i] + "  Type: " + types[i] + "  Required: " + required[i] + "  Key: " + key[i]);
            }
        

        }
        
        //public System.Windows.Forms.Label AddPropertyLabel()
        //{
        //    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
        //    this.Controls.Add(label);
        //    label.Top = B * 228;
        //    label.Left = 450;
        //    label.Text = "New Property" + this.B.ToString();
        //    B = B + 1;

        //    return label;
        //}
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void runInDockerComposeButton_Click(object sender, EventArgs e)
        {
            string SolutionInstallPath = metroTextBox1.Text;
            string SolutionFolder = solutionNameTextBox.Text;
            RunDockerCompose(SolutionFolder, SolutionInstallPath);
        }

        public void RunDockerCompose(string SolutionFolder, string SolutionInstallPath)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"..\..\Scripts\docker-compose-up.ps1"))
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, SolutionInstallPath)
            .Invoke();
        }

        private void downDockerComposeButton_Click(object sender, EventArgs e)
        {
            string SolutionInstallPath = metroTextBox1.Text;
            string SolutionFolder = solutionNameTextBox.Text;
            DownDockerCompose(SolutionFolder, SolutionInstallPath);
        }

        public void DownDockerCompose(string SolutionFolder, string SolutionInstallPath)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(File.ReadAllText(@"..\..\Scripts\docker-compose-down.ps1"))
                    .AddParameter(null, SolutionFolder)
                    .AddParameter(null, SolutionInstallPath)
            .Invoke();
        }
    }
}
