
namespace MDManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlLable = new System.Windows.Forms.Label();
            this.Subtitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createProject = new System.Windows.Forms.Button();
            this.createSolution = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tlLable);
            this.panel1.Controls.Add(this.Subtitle);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 63);
            this.panel1.TabIndex = 0;
            // 
            // tlLable
            // 
            this.tlLable.AutoSize = true;
            this.tlLable.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlLable.Location = new System.Drawing.Point(564, 29);
            this.tlLable.Name = "tlLable";
            this.tlLable.Size = new System.Drawing.Size(44, 23);
            this.tlLable.TabIndex = 4;
            this.tlLable.Text = "Home";
            this.tlLable.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Subtitle
            // 
            this.Subtitle.AutoSize = true;
            this.Subtitle.Location = new System.Drawing.Point(63, 36);
            this.Subtitle.Name = "Subtitle";
            this.Subtitle.Size = new System.Drawing.Size(334, 16);
            this.Subtitle.TabIndex = 3;
            this.Subtitle.Text = "Build, Manage & Test Microservices with Docker, Kubernetes, Angular, C# & SQL";
            this.Subtitle.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(62, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(215, 23);
            this.Title.TabIndex = 2;
            this.Title.Text = "Microservice Developer Manager";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.createProject);
            this.panel2.Controls.Add(this.createSolution);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 478);
            this.panel2.TabIndex = 1;
            // 
            // createProject
            // 
            this.createProject.BackColor = System.Drawing.Color.Transparent;
            this.createProject.FlatAppearance.BorderSize = 0;
            this.createProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.createProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.createProject.Location = new System.Drawing.Point(0, 49);
            this.createProject.Name = "createProject";
            this.createProject.Size = new System.Drawing.Size(171, 52);
            this.createProject.TabIndex = 7;
            this.createProject.Text = "Create Project";
            this.createProject.UseVisualStyleBackColor = false;
            this.createProject.Click += new System.EventHandler(this.createProject_Click);
            // 
            // createSolution
            // 
            this.createSolution.BackColor = System.Drawing.Color.Transparent;
            this.createSolution.FlatAppearance.BorderSize = 0;
            this.createSolution.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.createSolution.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSolution.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.createSolution.Location = new System.Drawing.Point(0, 0);
            this.createSolution.Name = "createSolution";
            this.createSolution.Size = new System.Drawing.Size(171, 52);
            this.createSolution.TabIndex = 6;
            this.createSolution.Text = "Create Solution";
            this.createSolution.UseVisualStyleBackColor = false;
            this.createSolution.Click += new System.EventHandler(this.createSolution_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(171, 63);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(834, 478);
            this.panelDesktopPane.TabIndex = 9;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1005, 541);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "MD Manager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Subtitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button createSolution;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label tlLable;
        private System.Windows.Forms.Button createProject;
    }
}

