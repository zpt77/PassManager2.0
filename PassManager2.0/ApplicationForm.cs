using PassManager.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;


namespace PassManager2._0
{
    public partial class ApplicationForm : Form, IDataProtection
    {

        int LoggedUserId;

        public ApplicationForm(int userId)
        {
            LoggedUserId = userId;
            InitializeComponent();
        }

        PassManagerDB db;
        public void LoadPasswords()
        {
            
            db = new PassManagerDB();
            var ctx = new PassManagerDB();
            var userPasswords = ctx.Passwords.Where(p => p.UserId==LoggedUserId).ToList();

            passwordBindingSource.DataSource = userPasswords;

        }

        public void ApplicationForm_Load(object sender, EventArgs e)
        {
            LoadPasswords();
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public string GenerateRandomString()
        {
            return Membership.GeneratePassword(16, 6);
        }



        private void AddPasswordToDB_Click(object sender, EventArgs e)
        {
            string PasswordToAdd;
            string MailToAdd;

            if (passwordCheckBox.Checked == true)
            {
                PasswordToAdd = GenerateRandomString();
            } 
            else
            {
                PasswordToAdd = AddPassword.InputText;
            }

            if (mailCheckBox.Checked == true)
            {
                var ctx = new PassManagerDB();
                var userMail = ctx.Users.Where(u => u.Id == LoggedUserId).Select(u => u.Email).FirstOrDefault();
                MailToAdd = userMail;
            }
            else
            {
                MailToAdd = AddEmail.InputText;
            }

            using(var ctx = new PassManagerDB())
            {
                var password = new Password()
                {
                    PTitle = AddTitle.InputText,
                    PLogin = AddLogin.InputText,
                    PEmail = MailToAdd,
                    PPassword = Encrypt(PasswordToAdd),
                    PURL = AddURL.InputText,
                    PDetails = AddDetails.InputText,
                    UserId = LoggedUserId
                };
                ctx.Passwords.Add(password);
                ctx.SaveChanges();
                MessageBox.Show("Password added");
                

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
           
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            using (var ctx = new PassManagerDB())
            {
                var password = new Password { Id = id };
                ctx.Passwords.Attach(password);
                ctx.Passwords.Remove(password);
                ctx.SaveChanges();
                LoadPasswords();
                MessageBox.Show("Password deleted");


            }


        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            LoadPasswords();
        }

        public void checkBlock(CheckBox checkBox, NamedTextbox namedTextbox)
        {
            if (checkBox.Checked == true)
            {
                namedTextbox.InputText = "";
                namedTextbox.ReadOnly = true;
            }
            else
            {
                namedTextbox.ReadOnly = false;
            }
        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBlock(passwordCheckBox, AddPassword);
        }


        private void mailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBlock(mailCheckBox, AddEmail);

        }

        string hash = "s3cr3th@5h";

        public string Encrypt(string inputString)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(inputString);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using(TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider(){ Key=keys, Mode = CipherMode.ECB,Padding = PaddingMode.PKCS7}){
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public string Decrypt(string inputString)
        {
            byte[] data = Convert.FromBase64String(inputString);
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Password"].Value);
            Clipboard.SetDataObject(Decrypt(cellValue));
           
        }
    }
}
