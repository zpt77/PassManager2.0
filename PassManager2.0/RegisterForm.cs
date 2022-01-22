using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager2._0
{
    public partial class RegisterForm : Form
    {
       

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var ctx = new PassManagerDB())
            {
                var user = new User()
                {
                    LoginName = UserLogin.InputText,
                    Password = UserPassword.InputText,
                    Name = UserName.InputText,
                    Surname = UserSurname.InputText,
                    Email = UserEmail.InputText
                };
                ctx.Users.Add(user);
                ctx.SaveChanges();
            }


            




        }
    }
}
