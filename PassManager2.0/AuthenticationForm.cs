using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassManager.Controls;
using System.Security.Cryptography;



namespace PassManager2._0
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void loginPanel1_Load(object sender, EventArgs e)
        {
            
        }
        private void loginPanel1_LoginClick(object sender, EventArgs e)
        {
            //GetCredentials();
            var w = new ApplicationForm();
            w.Show();
        }
 

        private void loginPanel1_RegisterClick(object sender, EventArgs e)
        {
            var w = new RegisterForm();
            w.Show();
        }

        



        // methods for login 

        public string[] GetCredentials()
        {
            string[] credentials = new string[2];
            credentials[0] = loginPanel1.Login;
            credentials[1] = loginPanel1.Password;
            return credentials;
        }

        public int GetUsrID(string login)
        {
            int UsrID = 0;

            return UsrID;
        }


        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        public bool ComparePassword()
        {
            return true;
        }

        public void LoadData()
        {

        }

        
    }
}
