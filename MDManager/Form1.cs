using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDManager
{
    public partial class Form1 : Form
    {

        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void createSolution_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CreateSolution(), sender);
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            tlLable.Text = childForm.Text;
            tlLable.TextAlign = ContentAlignment.MiddleRight;
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void createProject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CreateProject(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Home(), sender);
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        //PowerShell ps = PowerShell.Create();
        //ps.AddScript(File.ReadAllText(@"C:\temp\helloworld.ps1"))
        //        .AddParameter("Power")
        //        .Invoke();

        //MessageBox.Show("Log has been added");
    }
}
