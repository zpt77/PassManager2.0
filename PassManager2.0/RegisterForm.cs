using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager2._0
{
    public partial class RegisterForm : Form, IDataProtection
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
                    Password = Encrypt(UserPassword.InputText),
                    Name = UserName.InputText,
                    Surname = UserSurname.InputText,
                    Email = UserEmail.InputText
                };
                ctx.Users.Add(user);
                ctx.SaveChanges();
                MessageBox.Show("User created");

            }


            




        }

        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public string Encrypt(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public string Decrypt(string x)
        {
            MessageBox.Show("Cannot perform this operation");
            throw new NotImplementedException();
        }
    }
}
