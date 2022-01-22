using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassManager;

namespace PassManager.Controls
{
    public partial class LoginPanel : UserControl
    {

        public string Login
        {
            get
            {
                return loginBox.Text;
            }
            set
            {
                loginBox.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return passwordBox.Text;
            }
            set
            {
                passwordBox.Text = value;
            }
        }

        public LoginPanel()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks log in button")]
        public event EventHandler LoginClick;
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (this.LoginClick != null)
                this.LoginClick(this, e);
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks register button")]
        public event EventHandler RegisterClick;
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (this.RegisterClick != null)
                this.RegisterClick(this, e);
        }
    }
}
