using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS_2023
{
    public partial class Form1 : Form
    {
        Borovets f1 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f1 == null)
            {
                f1 = new Borovets();
                f1.Show();
            }
            else
            if (f1.IsDisposed)
            {
                f1 = new Borovets();
                f1.Show();
            }
            else
            {
                if (f1.WindowState == FormWindowState.Minimized)
                    f1.WindowState = FormWindowState.Normal;
                else
                    if (!f1.Focused)
                    f1.Focus();
            }
        }
    }
}
