
namespace PassManager2._0
{
    partial class AuthenticationForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationForm));
            this.loginPanel1 = new PassManager.Controls.LoginPanel();
            this.appName1 = new PassManager.Controls.AppName();
            this.SuspendLayout();
            // 
            // loginPanel1
            // 
            this.loginPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loginPanel1.Location = new System.Drawing.Point(56, 52);
            this.loginPanel1.Login = "";
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.loginPanel1.Password = "";
            this.loginPanel1.Size = new System.Drawing.Size(185, 254);
            this.loginPanel1.TabIndex = 1;
            this.loginPanel1.LoginClick += new System.EventHandler(this.loginPanel1_LoginClick);
            this.loginPanel1.RegisterClick += new System.EventHandler(this.loginPanel1_RegisterClick);
            // 
            // appName1
            // 
            this.appName1.Dock = System.Windows.Forms.DockStyle.Top;
            this.appName1.Location = new System.Drawing.Point(0, 0);
            this.appName1.Name = "appName1";
            this.appName1.Size = new System.Drawing.Size(308, 63);
            this.appName1.TabIndex = 0;
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 341);
            this.Controls.Add(this.loginPanel1);
            this.Controls.Add(this.appName1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthenticationForm";
            this.Text = "PassManager 2.0";
            this.ResumeLayout(false);

        }

        #endregion

        private global::PassManager.Controls.AppName appName1;
        private global::PassManager.Controls.LoginPanel loginPanel1;
    }
}

