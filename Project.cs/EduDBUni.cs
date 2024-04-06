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
    public partial class EduDBUni : Form
    {
        public EduDBUni()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EduDBUni_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel5.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel7.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel8.BackColor = Color.FromArgb(100, 0, 0, 0);

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EducationDB edu = new EducationDB();
            edu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int val3 = Convert.ToInt16(lbl1.Text);
            if (val3 < 160)
            {
                val3 += 1;
                lbl1.Text = val3.ToString();
            }
            else
            {
                timer1.Stop();
            }

            



        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int val2 = Convert.ToInt16(lbl2.Text);
            if (val2 < 250)
            {
                val2 += 1;
                lbl2.Text = val2.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            int val = Convert.ToInt16(lbl3.Text);
            if (val < 70)
            {
                val += 1;
                lbl3.Text = val.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {


            int val4 = Convert.ToInt16(lbl4.Text);
            if (val4 < 910)
            {
                val4 += 1;
                lbl4.Text = val4.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            
            int val5 = Convert.ToInt16(lbl5.Text);
            if (val5 < 870)
            {
                val5 += 1;
                lbl5.Text = val5.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
