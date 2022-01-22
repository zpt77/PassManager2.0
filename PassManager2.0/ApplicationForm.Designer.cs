
namespace PassManager2._0
{
    partial class ApplicationForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPasswords = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddDetails = new PassManager.Controls.NamedTextbox();
            this.AddURL = new PassManager.Controls.NamedTextbox();
            this.AddLogin = new PassManager.Controls.NamedTextbox();
            this.AddPassword = new PassManager.Controls.NamedTextbox();
            this.AddEmail = new PassManager.Controls.NamedTextbox();
            this.AddTitle = new PassManager.Controls.NamedTextbox();
            this.mailCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.AddPasswordToDB = new System.Windows.Forms.Button();
            this.ChangeLogin = new PassManager.Controls.NamedTextbox();
            this.ChangePassword = new PassManager.Controls.NamedTextbox();
            this.ChangeEmail = new PassManager.Controls.NamedTextbox();
            this.ChangeApplyButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.appName1 = new PassManager.Controls.AppName();
            this.passwordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLoginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPasswords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPasswords);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.ItemSize = new System.Drawing.Size(69, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPasswords
            // 
            this.tabPasswords.BackColor = System.Drawing.Color.White;
            this.tabPasswords.Controls.Add(this.deleteButton);
            this.tabPasswords.Controls.Add(this.dataGridView1);
            this.tabPasswords.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPasswords.Location = new System.Drawing.Point(4, 22);
            this.tabPasswords.Name = "tabPasswords";
            this.tabPasswords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPasswords.Size = new System.Drawing.Size(1025, 424);
            this.tabPasswords.TabIndex = 2;
            this.tabPasswords.Text = "Passwords";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pTitleDataGridViewTextBoxColumn,
            this.pLoginDataGridViewTextBoxColumn,
            this.pEmailDataGridViewTextBoxColumn,
            this.pPasswordDataGridViewTextBoxColumn,
            this.pURLDataGridViewTextBoxColumn,
            this.pDetailsDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.passwordBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(871, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 48);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.copyToClipboardToolStripMenuItem.Text = "copy to clipboard";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.SteelBlue;
            this.tabSettings.Controls.Add(this.groupBox3);
            this.tabSettings.Controls.Add(this.groupBox2);
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(877, 424);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChangeApplyButton);
            this.groupBox2.Controls.Add(this.ChangeEmail);
            this.groupBox2.Controls.Add(this.ChangePassword);
            this.groupBox2.Controls.Add(this.ChangeLogin);
            this.groupBox2.Location = new System.Drawing.Point(414, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.AddPasswordToDB);
            this.groupBox1.Controls.Add(this.passwordCheckBox);
            this.groupBox1.Controls.Add(this.mailCheckBox);
            this.groupBox1.Controls.Add(this.AddDetails);
            this.groupBox1.Controls.Add(this.AddURL);
            this.groupBox1.Controls.Add(this.AddLogin);
            this.groupBox1.Controls.Add(this.AddPassword);
            this.groupBox1.Controls.Add(this.AddEmail);
            this.groupBox1.Controls.Add(this.AddTitle);
            this.groupBox1.Location = new System.Drawing.Point(8, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Password";
            // 
            // AddDetails
            // 
            this.AddDetails.GroupName = "Details";
            this.AddDetails.InputText = "";
            this.AddDetails.Location = new System.Drawing.Point(6, 263);
            this.AddDetails.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddDetails.Name = "AddDetails";
            this.AddDetails.Size = new System.Drawing.Size(200, 50);
            this.AddDetails.TabIndex = 5;
            // 
            // AddURL
            // 
            this.AddURL.GroupName = "URL";
            this.AddURL.InputText = "";
            this.AddURL.Location = new System.Drawing.Point(6, 183);
            this.AddURL.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddURL.Name = "AddURL";
            this.AddURL.Size = new System.Drawing.Size(200, 50);
            this.AddURL.TabIndex = 4;
            // 
            // AddLogin
            // 
            this.AddLogin.GroupName = "Login";
            this.AddLogin.InputText = "";
            this.AddLogin.Location = new System.Drawing.Point(212, 24);
            this.AddLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddLogin.Name = "AddLogin";
            this.AddLogin.Size = new System.Drawing.Size(150, 50);
            this.AddLogin.TabIndex = 3;
            // 
            // AddPassword
            // 
            this.AddPassword.GroupName = "Password";
            this.AddPassword.InputText = "";
            this.AddPassword.Location = new System.Drawing.Point(6, 104);
            this.AddPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddPassword.Name = "AddPassword";
            this.AddPassword.Size = new System.Drawing.Size(200, 50);
            this.AddPassword.TabIndex = 2;
            // 
            // AddEmail
            // 
            this.AddEmail.GroupName = "E-mail";
            this.AddEmail.InputText = "";
            this.AddEmail.Location = new System.Drawing.Point(212, 104);
            this.AddEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddEmail.Name = "AddEmail";
            this.AddEmail.Size = new System.Drawing.Size(150, 50);
            this.AddEmail.TabIndex = 1;
            // 
            // AddTitle
            // 
            this.AddTitle.GroupName = "Title";
            this.AddTitle.InputText = "";
            this.AddTitle.Location = new System.Drawing.Point(6, 24);
            this.AddTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(200, 50);
            this.AddTitle.TabIndex = 0;
            // 
            // mailCheckBox
            // 
            this.mailCheckBox.AutoSize = true;
            this.mailCheckBox.Location = new System.Drawing.Point(213, 183);
            this.mailCheckBox.Name = "mailCheckBox";
            this.mailCheckBox.Size = new System.Drawing.Size(111, 20);
            this.mailCheckBox.TabIndex = 6;
            this.mailCheckBox.Text = "Default E-mail";
            this.mailCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Location = new System.Drawing.Point(213, 210);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(136, 20);
            this.passwordCheckBox.TabIndex = 7;
            this.passwordCheckBox.Text = "Random Password";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddPasswordToDB
            // 
            this.AddPasswordToDB.Location = new System.Drawing.Point(249, 276);
            this.AddPasswordToDB.Name = "AddPasswordToDB";
            this.AddPasswordToDB.Size = new System.Drawing.Size(75, 23);
            this.AddPasswordToDB.TabIndex = 8;
            this.AddPasswordToDB.Text = "Confirm";
            this.AddPasswordToDB.UseVisualStyleBackColor = true;
            this.AddPasswordToDB.Click += new System.EventHandler(this.AddPasswordToDB_Click);
            // 
            // ChangeLogin
            // 
            this.ChangeLogin.GroupName = "Change Login";
            this.ChangeLogin.InputText = "";
            this.ChangeLogin.Location = new System.Drawing.Point(15, 23);
            this.ChangeLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeLogin.Name = "ChangeLogin";
            this.ChangeLogin.Size = new System.Drawing.Size(150, 50);
            this.ChangeLogin.TabIndex = 0;
            // 
            // ChangePassword
            // 
            this.ChangePassword.GroupName = "Change Password";
            this.ChangePassword.InputText = "";
            this.ChangePassword.Location = new System.Drawing.Point(223, 24);
            this.ChangePassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(188, 50);
            this.ChangePassword.TabIndex = 1;
            // 
            // ChangeEmail
            // 
            this.ChangeEmail.GroupName = "Change E-mail";
            this.ChangeEmail.InputText = "";
            this.ChangeEmail.Location = new System.Drawing.Point(15, 81);
            this.ChangeEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ChangeEmail.Name = "ChangeEmail";
            this.ChangeEmail.Size = new System.Drawing.Size(150, 50);
            this.ChangeEmail.TabIndex = 2;
            // 
            // ChangeApplyButton
            // 
            this.ChangeApplyButton.Location = new System.Drawing.Point(270, 108);
            this.ChangeApplyButton.Name = "ChangeApplyButton";
            this.ChangeApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeApplyButton.TabIndex = 3;
            this.ChangeApplyButton.Text = "Apply";
            this.ChangeApplyButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.appName1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(414, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 203);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "User Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(361, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Surname:";
            // 
            // appName1
            // 
            this.appName1.color = System.Drawing.Color.White;
            this.appName1.Dock = System.Windows.Forms.DockStyle.Top;
            this.appName1.Location = new System.Drawing.Point(3, 19);
            this.appName1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appName1.Name = "appName1";
            this.appName1.Size = new System.Drawing.Size(449, 63);
            this.appName1.TabIndex = 8;
            // 
            // passwordBindingSource
            // 
            this.passwordBindingSource.DataSource = typeof(PassManager2._0.Password);
            // 
            // pTitleDataGridViewTextBoxColumn
            // 
            this.pTitleDataGridViewTextBoxColumn.DataPropertyName = "PTitle";
            this.pTitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.pTitleDataGridViewTextBoxColumn.Name = "pTitleDataGridViewTextBoxColumn";
            // 
            // pLoginDataGridViewTextBoxColumn
            // 
            this.pLoginDataGridViewTextBoxColumn.DataPropertyName = "PLogin";
            this.pLoginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.pLoginDataGridViewTextBoxColumn.Name = "pLoginDataGridViewTextBoxColumn";
            // 
            // pEmailDataGridViewTextBoxColumn
            // 
            this.pEmailDataGridViewTextBoxColumn.DataPropertyName = "PEmail";
            this.pEmailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.pEmailDataGridViewTextBoxColumn.Name = "pEmailDataGridViewTextBoxColumn";
            // 
            // pPasswordDataGridViewTextBoxColumn
            // 
            this.pPasswordDataGridViewTextBoxColumn.DataPropertyName = "PPassword";
            this.pPasswordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.pPasswordDataGridViewTextBoxColumn.Name = "pPasswordDataGridViewTextBoxColumn";
            // 
            // pURLDataGridViewTextBoxColumn
            // 
            this.pURLDataGridViewTextBoxColumn.DataPropertyName = "PURL";
            this.pURLDataGridViewTextBoxColumn.HeaderText = "URL";
            this.pURLDataGridViewTextBoxColumn.Name = "pURLDataGridViewTextBoxColumn";
            // 
            // pDetailsDataGridViewTextBoxColumn
            // 
            this.pDetailsDataGridViewTextBoxColumn.DataPropertyName = "PDetails";
            this.pDetailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.pDetailsDataGridViewTextBoxColumn.Name = "pDetailsDataGridViewTextBoxColumn";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(916, 33);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationForm";
            this.Text = "PassManager 2.0";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPasswords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabPasswords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.BindingSource passwordBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private PassManager.Controls.NamedTextbox AddDetails;
        private PassManager.Controls.NamedTextbox AddURL;
        private PassManager.Controls.NamedTextbox AddLogin;
        private PassManager.Controls.NamedTextbox AddPassword;
        private PassManager.Controls.NamedTextbox AddEmail;
        private PassManager.Controls.NamedTextbox AddTitle;
        private System.Windows.Forms.CheckBox mailCheckBox;
        private System.Windows.Forms.Button AddPasswordToDB;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeApplyButton;
        private PassManager.Controls.NamedTextbox ChangeEmail;
        private PassManager.Controls.NamedTextbox ChangePassword;
        private PassManager.Controls.NamedTextbox ChangeLogin;
        private PassManager.Controls.AppName appName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLoginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
    }
}