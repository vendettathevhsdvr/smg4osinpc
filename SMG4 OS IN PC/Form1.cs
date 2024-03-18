using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SMG4_OS_IN_PC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); // This is bad
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(); // This is bad
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"\SMG4 OS ON PC\sounds\intro_P11.wav");
            player.Play();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5(); // This is bad
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 f = new Form4(); // This is bad
            f.Show();
        }
    }
}
