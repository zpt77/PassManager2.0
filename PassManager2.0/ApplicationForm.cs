using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;


namespace PassManager2._0
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        PassManagerDB db;

        public void ApplicationForm_Load(object sender, EventArgs e)
        {

            db = new PassManagerDB();
            db.Passwords.Load();
            passwordBindingSource.DataSource = db.Passwords.Local;


            


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
            using(var ctx = new PassManagerDB())
            {
                var password = new Password()
                {
                    PTitle = AddTitle.InputText,
                    PLogin = AddLogin.InputText,
                    PEmail = AddEmail.InputText,
                    PPassword = AddPassword.InputText,
                    PURL = AddURL.InputText,
                    PDetails = AddDetails.InputText,
                    UserId = 1
                };
                ctx.Passwords.Add(password);
                ctx.SaveChanges();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            using (var ctx = new PassManagerDB())
            {
                var password = new Password { Id = id };
                ctx.Passwords.Attach(password);
                ctx.Passwords.Remove(password);
                ctx.SaveChanges();
            }

        }

        //private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    System.Windows.Forms.Clipboard.SetText();

        //}
    }
}
