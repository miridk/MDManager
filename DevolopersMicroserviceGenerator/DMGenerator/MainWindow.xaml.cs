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
using System.Management.Automation;

namespace DMGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string textToReplace;
        public string text;
        string rootfolder = @"C:\Temp\Template";
        public string efType;

        public List<string> props = new List<string>();
        public List<string> types = new List<string>();
        public List<string> required = new List<string>();
        public List<string> propsConcatList = new List<string>();
        public List<string> cPropsConcatList = new List<string>();
        public List<string> efPropsConcatList = new List<string>();
        public List<string> efDataContextPropsConcatList = new List<string>();

        

   



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
            rootfolder = @"C:\Temp\Template";
            string[] files = Directory.GetFiles(rootfolder, "*.*", SearchOption.AllDirectories);
            //TAG_{'modelName'}

            //foreach (string file in files)
            //{
            //    try
            //    {
            //        string contents = File.ReadAllText(file);
            //        contents = contents.Replace(@"TAG_{'controllerPutModel'}", modelNameReplaceTextBox.Text);
            //        // Make files writable
            //        File.SetAttributes(file, FileAttributes.Normal);
            //        File.WriteAllText(file, contents);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //TAG_{'modelNameToLower'}
            foreach (string file in files)
            {
                try
                {
                    string contents = File.ReadAllText(file);
                    contents = contents.Replace(@"TAG_{'modelNameToLower'}", modelNameReplaceTextBox.Text.ToLower());
                    // Make files writable
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.WriteAllText(file, contents);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }



            //Creating Properties Model
            for (int i = 0; i < props.Count; i++)
            {
                string propsConcat = required[i] + "\n        public " + types[i] + " " + (props[i]) + " { get; set; } = string.Empty;";
                propsConcatList.Add(propsConcat);
            }
            var propsJoined = String.Join("\n        ", propsConcatList.ToArray());

            //TAG_{'propertiesModel'}
            foreach (string file in files)
            {
                try
                {
                    string contents = File.ReadAllText(file);
                    contents = contents.Replace(@"TAG_{'propertiesModel'}", propsJoined);
                    // Make files writable
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.WriteAllText(file, contents);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            //Creating Controller Model
            for (int i = 0; i < props.Count; i++)
            {
                string propsConcat = "\n        dbtemplate." + props[i] + " = request." + props[i] + ";";
                cPropsConcatList.Add(propsConcat);
            }
            var cPropsJoined = String.Join("\n        ", cPropsConcatList.ToArray());

            //TAG_{'propertiesModel'}
            foreach (string file in files)
            {
                try
                {
                    string contents = File.ReadAllText(file);
                    contents = contents.Replace(@"TAG_{'controllerPutModel'}", cPropsJoined);
                    // Make files writable
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.WriteAllText(file, contents);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }



            //Creating Ef Properties Model

            for (int i = 0; i < props.Count; i++)
            {
                if (types[i] == "string")
                    efType = "nvarchar(max)";
                if(types[i] == "int")
                    efType = "int";
                if (types[i] == "boolean")
                    efType = "bool";
                
                string propsConcat = "\n                    Name = table.Column<" + types[i] + ">(type: \"" + efType + "\", nullable: false),";
                efPropsConcatList.Add(propsConcat);
            }
            var efPropsJoined = String.Join("\n                    ", efPropsConcatList.ToArray());


            //TAG_{ 'propertiesEf'}
            foreach (string file in files)
            {
                try
                {
                    string contents = File.ReadAllText(file);
                    contents = contents.Replace(@"TAG_{'propertiesEf'}", efPropsJoined);
                    // Make files writable
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.WriteAllText(file, contents);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            
            //Creating Ef Data Context Properties Model

            for (int i = 0; i < props.Count; i++)
            {
                if (types[i] == "string")
                    efType = "nvarchar(max)";
                if (types[i] == "int")
                    efType = "int";
                if (types[i] == "boolean")
                    efType = "bool";

                string propsConcat = "\n                    b.Property<" + types[i] + ">(\"" + props[i] + "\")\n                        .IsRequired()\n                        .HasColumnType(\"" + efType + "\");";
                efDataContextPropsConcatList.Add(propsConcat);
            }
            var efDataContextPropsJoined = String.Join("\n                    ", efDataContextPropsConcatList.ToArray());


            //TAG_{ 'propertiesEfDesigner'}
            foreach (string file in files)
            {
                try
                {
                    string contents = File.ReadAllText(file);
                    contents = contents.Replace(@"TAG_{'propertiesEfDesigner'}", efDataContextPropsJoined);
                    // Make files writable
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.WriteAllText(file, contents);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //TAG_{ 'ConnectionString'}
            foreach (string file in files)
            {
                try
                {
                    string contents = File.ReadAllText(file);
                    contents = contents.Replace(@"TAG_{'ConnectionString'}", connectionStringReplaceTextBox.Text);
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

        private void addPropertyButton_Click(object sender, RoutedEventArgs e)
        {
            if (propertyNameTextBox.Text != "")
            {
                props.Add(propertyNameTextBox.Text);
                propertyNameTextBox.Clear();
            }
            types.Add(propertyTypeComboBox.Text.ToLower());
            if (propertyRequiredCheckBox.IsChecked ?? false)
            {
                required.Add("[Required]");
            }
            else 
            {
                required.Add("");
            }
            propertiesAddedCheckBox.Items.Clear();
            int counterOfArraylist = props.Count;
            string[] str = new string[counterOfArraylist];
            for (int i = 0; i < str.Length; i++)
            {
                propertiesAddedCheckBox.Items.Add("public " + types[i] + " " + props[i] + " { get; set; } " + required[i]);
            }

        }

        private async void installTemplateFromNugetButton_Click(object sender, RoutedEventArgs e)
        {
            using (PowerShell ps = PowerShell.Create())
            {
                //string packageName = "";
                //PowerShell ps = PowerShell.Create();
                ps.AddScript(@"..\..\Scripts\InstallTemplate.ps1");
                //.AddParameter(null, packageName)
                var message = await ps.InvokeAsync().ConfigureAwait(false);
                //.Invoke();
                //string message = "Installed";
                MessageBox.Show(message.ToString());
            }
            

        }
    }
}
