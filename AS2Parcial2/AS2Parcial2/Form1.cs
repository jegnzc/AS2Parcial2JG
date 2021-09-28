using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2Parcial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form2 f2;

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.FormClosed += F2_FormClosed;
                f2.Show();
            }
            else
            {
                f2.Activate();
            }
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
        }
    }
}