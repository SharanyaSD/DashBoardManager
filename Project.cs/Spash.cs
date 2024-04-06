using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.cs
{
    public partial class Spash : Form
    {
        int ticks;
        public Spash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 3)
            {
                

                this.Hide();
                timer1.Stop();
                Form1 fml = new Form1();
                fml.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbuser_Click(object sender, EventArgs e)
        {

        }

        private void Spash_Load(object sender, EventArgs e)
        {
            lblsplash.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
