using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassManager.Controls
{
    public partial class NamedTextbox : UserControl
    {
        public NamedTextbox()
        {
            InitializeComponent();
        }

        public string GroupName
        {
            get
            {
                return groupBox1.Text;
            }
            set
            {
                groupBox1.Text = value;
            }
        }

        public string InputText
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        public bool ReadOnly
        {
            get
            {
                return textBox1.ReadOnly;
            }
            set
            {
                textBox1.ReadOnly = value;
            }
        }

        private event EventHandler onReadOnlyChanged;

        public event EventHandler ReadOnlyChanged
        {
            add
            {
                onReadOnlyChanged += value;
            }
            remove
            {
                onReadOnlyChanged -= value;
            }
        }

        protected virtual void OnReadOnlyChanged(EventArgs e)
        {
            onReadOnlyChanged?.Invoke(this, e);
        }

        private void textBox1_ReadOnlyChanged(object sender, EventArgs e)
        {
            if (ReadOnly == true)
            {
                textBox1.BackColor = Color.LightSteelBlue;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
        }
    }
}
