
namespace MDManager.Forms
{
    partial class CreateSolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSolution));
            this.crudCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBoxPrime = new System.Windows.Forms.CheckBox();
            this.entityFrameworkCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBoxFrontEnd = new System.Windows.Forms.CheckBox();
            this.webApiCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.solutionNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.propertyNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.propertyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.propertyRequiredCheckBox = new System.Windows.Forms.CheckBox();
            this.propertyKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dockerComposeCheckBox = new System.Windows.Forms.CheckBox();
            this.runInDockerComposeButton = new System.Windows.Forms.Button();
            this.downDockerComposeButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crudCheckBox
            // 
            this.crudCheckBox.AutoSize = true;
            this.crudCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.crudCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.crudCheckBox.Location = new System.Drawing.Point(24, 132);
            this.crudCheckBox.Name = "crudCheckBox";
            this.crudCheckBox.Size = new System.Drawing.Size(57, 17);
            this.crudCheckBox.TabIndex = 15;
            this.crudCheckBox.Text = "CRUD";
            this.crudCheckBox.UseVisualStyleBackColor = false;
            // 
            // checkBoxPrime
            // 
            this.checkBoxPrime.AutoSize = true;
            this.checkBoxPrime.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPrime.ForeColor = System.Drawing.Color.Transparent;
            this.checkBoxPrime.Location = new System.Drawing.Point(212, 106);
            this.checkBoxPrime.Name = "checkBoxPrime";
            this.checkBoxPrime.Size = new System.Drawing.Size(68, 17);
            this.checkBoxPrime.TabIndex = 16;
            this.checkBoxPrime.Text = "PrimeNG";
            this.checkBoxPrime.UseVisualStyleBackColor = false;
            // 
            // entityFrameworkCheckBox
            // 
            this.entityFrameworkCheckBox.AutoSize = true;
            this.entityFrameworkCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.entityFrameworkCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.entityFrameworkCheckBox.Location = new System.Drawing.Point(24, 106);
            this.entityFrameworkCheckBox.Name = "entityFrameworkCheckBox";
            this.entityFrameworkCheckBox.Size = new System.Drawing.Size(107, 17);
            this.entityFrameworkCheckBox.TabIndex = 17;
            this.entityFrameworkCheckBox.Text = "Entity Framework";
            this.entityFrameworkCheckBox.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.Enabled = false;
            this.checkBox5.ForeColor = System.Drawing.Color.Transparent;
            this.checkBox5.Location = new System.Drawing.Point(416, 106);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(65, 17);
            this.checkBox5.TabIndex = 18;
            this.checkBox5.Text = "SQL DB";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBoxFrontEnd
            // 
            this.checkBoxFrontEnd.AutoSize = true;
            this.checkBoxFrontEnd.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFrontEnd.ForeColor = System.Drawing.Color.Transparent;
            this.checkBoxFrontEnd.Location = new System.Drawing.Point(212, 80);
            this.checkBoxFrontEnd.Name = "checkBoxFrontEnd";
            this.checkBoxFrontEnd.Size = new System.Drawing.Size(72, 17);
            this.checkBoxFrontEnd.TabIndex = 19;
            this.checkBoxFrontEnd.Text = "Front-End";
            this.checkBoxFrontEnd.UseVisualStyleBackColor = false;
            // 
            // webApiCheckBox
            // 
            this.webApiCheckBox.AutoSize = true;
            this.webApiCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.webApiCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.webApiCheckBox.Location = new System.Drawing.Point(24, 80);
            this.webApiCheckBox.Name = "webApiCheckBox";
            this.webApiCheckBox.Size = new System.Drawing.Size(69, 17);
            this.webApiCheckBox.TabIndex = 20;
            this.webApiCheckBox.Text = "Web API";
            this.webApiCheckBox.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(24, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Create Solution";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(21, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Web API Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Solution Path";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Lines = new string[] {
        "3000"};
            this.metroTextBox2.Location = new System.Drawing.Point(24, 214);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.Size = new System.Drawing.Size(172, 23);
            this.metroTextBox2.TabIndex = 9;
            this.metroTextBox2.Text = "3000";
            this.metroTextBox2.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(24, 35);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.Size = new System.Drawing.Size(471, 23);
            this.metroTextBox1.TabIndex = 10;
            this.metroTextBox1.UseSelectable = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "SolutionPath";
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 22);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(209, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Solution Name";
            // 
            // solutionNameTextBox
            // 
            this.solutionNameTextBox.Lines = new string[0];
            this.solutionNameTextBox.Location = new System.Drawing.Point(212, 214);
            this.solutionNameTextBox.MaxLength = 32767;
            this.solutionNameTextBox.Name = "solutionNameTextBox";
            this.solutionNameTextBox.PasswordChar = '\0';
            this.solutionNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.solutionNameTextBox.SelectedText = "";
            this.solutionNameTextBox.Size = new System.Drawing.Size(283, 23);
            this.solutionNameTextBox.TabIndex = 23;
            this.solutionNameTextBox.TabStop = false;
            this.solutionNameTextBox.UseSelectable = true;
            // 
            // propertyNameTextBox
            // 
            this.propertyNameTextBox.Lines = new string[0];
            this.propertyNameTextBox.Location = new System.Drawing.Point(557, 35);
            this.propertyNameTextBox.MaxLength = 32767;
            this.propertyNameTextBox.Name = "propertyNameTextBox";
            this.propertyNameTextBox.PasswordChar = '\0';
            this.propertyNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.propertyNameTextBox.SelectedText = "";
            this.propertyNameTextBox.Size = new System.Drawing.Size(103, 23);
            this.propertyNameTextBox.TabIndex = 25;
            this.propertyNameTextBox.TabStop = false;
            this.propertyNameTextBox.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(554, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Property Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(554, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Type";
            // 
            // propertyTypeComboBox
            // 
            this.propertyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyTypeComboBox.FormattingEnabled = true;
            this.propertyTypeComboBox.Items.AddRange(new object[] {
            "String",
            "Int",
            "Bool"});
            this.propertyTypeComboBox.Location = new System.Drawing.Point(557, 101);
            this.propertyTypeComboBox.Name = "propertyTypeComboBox";
            this.propertyTypeComboBox.Size = new System.Drawing.Size(103, 21);
            this.propertyTypeComboBox.TabIndex = 31;
            // 
            // propertyRequiredCheckBox
            // 
            this.propertyRequiredCheckBox.AutoSize = true;
            this.propertyRequiredCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.propertyRequiredCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.propertyRequiredCheckBox.Location = new System.Drawing.Point(557, 145);
            this.propertyRequiredCheckBox.Name = "propertyRequiredCheckBox";
            this.propertyRequiredCheckBox.Size = new System.Drawing.Size(69, 17);
            this.propertyRequiredCheckBox.TabIndex = 32;
            this.propertyRequiredCheckBox.Text = "Required";
            this.propertyRequiredCheckBox.UseVisualStyleBackColor = false;
            // 
            // propertyKeyCheckBox
            // 
            this.propertyKeyCheckBox.AutoSize = true;
            this.propertyKeyCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.propertyKeyCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.propertyKeyCheckBox.Location = new System.Drawing.Point(557, 170);
            this.propertyKeyCheckBox.Name = "propertyKeyCheckBox";
            this.propertyKeyCheckBox.Size = new System.Drawing.Size(44, 17);
            this.propertyKeyCheckBox.TabIndex = 33;
            this.propertyKeyCheckBox.Text = "Key";
            this.propertyKeyCheckBox.UseVisualStyleBackColor = false;
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.addPropertyButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.addPropertyButton.FlatAppearance.BorderSize = 0;
            this.addPropertyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addPropertyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addPropertyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPropertyButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addPropertyButton.Image = ((System.Drawing.Image)(resources.GetObject("addPropertyButton.Image")));
            this.addPropertyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPropertyButton.Location = new System.Drawing.Point(557, 210);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(103, 27);
            this.addPropertyButton.TabIndex = 34;
            this.addPropertyButton.Text = "Add Property";
            this.addPropertyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPropertyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addPropertyButton.UseVisualStyleBackColor = false;
            this.addPropertyButton.UseWaitCursor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(691, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 290);
            this.listBox1.TabIndex = 35;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(688, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Properties Added";
            // 
            // dockerComposeCheckBox
            // 
            this.dockerComposeCheckBox.AutoSize = true;
            this.dockerComposeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.dockerComposeCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.dockerComposeCheckBox.Location = new System.Drawing.Point(557, 308);
            this.dockerComposeCheckBox.Name = "dockerComposeCheckBox";
            this.dockerComposeCheckBox.Size = new System.Drawing.Size(108, 17);
            this.dockerComposeCheckBox.TabIndex = 37;
            this.dockerComposeCheckBox.Text = "Docker-Compose";
            this.dockerComposeCheckBox.UseVisualStyleBackColor = false;
            // 
            // runInDockerComposeButton
            // 
            this.runInDockerComposeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.runInDockerComposeButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.runInDockerComposeButton.FlatAppearance.BorderSize = 0;
            this.runInDockerComposeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.runInDockerComposeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.runInDockerComposeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runInDockerComposeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.runInDockerComposeButton.Image = ((System.Drawing.Image)(resources.GetObject("runInDockerComposeButton.Image")));
            this.runInDockerComposeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.runInDockerComposeButton.Location = new System.Drawing.Point(24, 309);
            this.runInDockerComposeButton.Name = "runInDockerComposeButton";
            this.runInDockerComposeButton.Size = new System.Drawing.Size(172, 27);
            this.runInDockerComposeButton.TabIndex = 38;
            this.runInDockerComposeButton.Text = "Run in Docker-Compose";
            this.runInDockerComposeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.runInDockerComposeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.runInDockerComposeButton.UseVisualStyleBackColor = false;
            this.runInDockerComposeButton.UseWaitCursor = true;
            this.runInDockerComposeButton.Click += new System.EventHandler(this.runInDockerComposeButton_Click);
            // 
            // downDockerComposeButton
            // 
            this.downDockerComposeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.downDockerComposeButton.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.downDockerComposeButton.FlatAppearance.BorderSize = 0;
            this.downDockerComposeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.downDockerComposeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.downDockerComposeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downDockerComposeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.downDockerComposeButton.Image = ((System.Drawing.Image)(resources.GetObject("downDockerComposeButton.Image")));
            this.downDockerComposeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.downDockerComposeButton.Location = new System.Drawing.Point(212, 309);
            this.downDockerComposeButton.Name = "downDockerComposeButton";
            this.downDockerComposeButton.Size = new System.Drawing.Size(172, 27);
            this.downDockerComposeButton.TabIndex = 39;
            this.downDockerComposeButton.Text = "Down in Docker-Compose";
            this.downDockerComposeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.downDockerComposeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.downDockerComposeButton.UseVisualStyleBackColor = false;
            this.downDockerComposeButton.UseWaitCursor = true;
            this.downDockerComposeButton.Click += new System.EventHandler(this.downDockerComposeButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(416, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 40;
            this.checkBox1.Text = "In Memory DB";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Enabled = false;
            this.checkBox2.ForeColor = System.Drawing.Color.Transparent;
            this.checkBox2.Location = new System.Drawing.Point(416, 132);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 17);
            this.checkBox2.TabIndex = 41;
            this.checkBox2.Text = "Mongo DB";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // CreateSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(999, 416);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.downDockerComposeButton);
            this.Controls.Add(this.runInDockerComposeButton);
            this.Controls.Add(this.dockerComposeCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addPropertyButton);
            this.Controls.Add(this.propertyKeyCheckBox);
            this.Controls.Add(this.propertyRequiredCheckBox);
            this.Controls.Add(this.propertyTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.propertyNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.solutionNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crudCheckBox);
            this.Controls.Add(this.checkBoxPrime);
            this.Controls.Add(this.entityFrameworkCheckBox);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBoxFrontEnd);
            this.Controls.Add(this.webApiCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Name = "CreateSolution";
            this.Text = "CreateSolution";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox crudCheckBox;
        private System.Windows.Forms.CheckBox checkBoxPrime;
        private System.Windows.Forms.CheckBox entityFrameworkCheckBox;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBoxFrontEnd;
        private System.Windows.Forms.CheckBox webApiCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox solutionNameTextBox;
        private MetroFramework.Controls.MetroTextBox propertyNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox propertyTypeComboBox;
        private System.Windows.Forms.CheckBox propertyRequiredCheckBox;
        private System.Windows.Forms.CheckBox propertyKeyCheckBox;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox dockerComposeCheckBox;
        private System.Windows.Forms.Button runInDockerComposeButton;
        private System.Windows.Forms.Button downDockerComposeButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}