using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMG4_OS_IN_PC
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1(); // This is bad
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6(); // This is bad
            f.Show();
        }
    }
}
