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
    public partial class SocialDB : Form
    {
        public SocialDB()
        {
            InitializeComponent();
        }

        private void SocialDB_Load(object sender, EventArgs e)
        {

            
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel5.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel7.BackColor = Color.FromArgb(100, 0, 0, 0);
            label3.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;

            timer1.Start();

            fillmain();
        }

        private void fillmain()
        {
            chart1.Series["Year"].Points.AddXY("2019", "34");
            chart1.Series["Year"].Points.AddXY("2010", "42");
            chart1.Series["Year"].Points.AddXY("2019", "43");
            chart1.Series["Year"].Points.AddXY("2019", "36");
            chart1.Series["Year"].Points.AddXY("2021", "39");
            chart1.Series["Year"].Points.AddXY("2021", "194");
           
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label9_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(label9.Text);
            if (val < 45)
            {
                val += 1;
                label9.Text = val.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dsh = new Dashboard();
            dsh.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
