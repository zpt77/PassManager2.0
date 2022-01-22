
namespace PassManager2._0
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.appName1 = new PassManager.Controls.AppName();
            this.UserLogin = new PassManager.Controls.NamedTextbox();
            this.UserName = new PassManager.Controls.NamedTextbox();
            this.UserSurname = new PassManager.Controls.NamedTextbox();
            this.UserEmail = new PassManager.Controls.NamedTextbox();
            this.UserPassword = new PassManager.Controls.NamedTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appName1
            // 
            this.appName1.color = System.Drawing.Color.White;
            this.appName1.Dock = System.Windows.Forms.DockStyle.Top;
            this.appName1.Location = new System.Drawing.Point(0, 0);
            this.appName1.Name = "appName1";
            this.appName1.Size = new System.Drawing.Size(318, 63);
            this.appName1.TabIndex = 0;
            // 
            // UserLogin
            // 
            this.UserLogin.GroupName = "Login name";
            this.UserLogin.InputText = "";
            this.UserLogin.Location = new System.Drawing.Point(79, 69);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(164, 49);
            this.UserLogin.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.GroupName = "Name";
            this.UserName.InputText = "";
            this.UserName.Location = new System.Drawing.Point(79, 179);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(164, 49);
            this.UserName.TabIndex = 2;
            // 
            // UserSurname
            // 
            this.UserSurname.GroupName = "Surname";
            this.UserSurname.InputText = "";
            this.UserSurname.Location = new System.Drawing.Point(79, 234);
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.Size = new System.Drawing.Size(164, 49);
            this.UserSurname.TabIndex = 3;
            // 
            // UserEmail
            // 
            this.UserEmail.GroupName = "E-mail";
            this.UserEmail.InputText = "";
            this.UserEmail.Location = new System.Drawing.Point(79, 289);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(164, 49);
            this.UserEmail.TabIndex = 4;
            // 
            // UserPassword
            // 
            this.UserPassword.GroupName = "Password";
            this.UserPassword.InputText = "";
            this.UserPassword.Location = new System.Drawing.Point(79, 124);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(164, 49);
            this.UserPassword.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(79, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(172, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(PassManager2._0.User);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(318, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.UserSurname);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.appName1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PassManager.Controls.AppName appName1;
        private PassManager.Controls.NamedTextbox UserLogin;
        private PassManager.Controls.NamedTextbox UserName;
        private PassManager.Controls.NamedTextbox UserSurname;
        private PassManager.Controls.NamedTextbox UserEmail;
        private PassManager.Controls.NamedTextbox UserPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}