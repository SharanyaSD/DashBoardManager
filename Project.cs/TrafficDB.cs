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
    public partial class TrafficDB : Form
    {
        public TrafficDB()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dsh = new Dashboard();
            dsh.Show();
        }

        private void TrafficDB_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel7.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel5.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel9.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel10.BackColor = Color.FromArgb(100, 0, 0, 0);
            l1.BackColor = Color.Transparent;
            l2.BackColor = Color.Transparent;
            l3.BackColor = Color.Transparent;
            l4.BackColor = Color.Transparent;
            l5.BackColor = Color.Transparent;
            l6.BackColor = Color.Transparent;
            l7.BackColor = Color.Transparent;
            l8.BackColor = Color.Transparent;
            l9.BackColor = Color.Transparent;
            l10.BackColor = Color.Transparent;
            l11.BackColor = Color.Transparent;

            p1.BackColor = Color.Transparent;
            p2.BackColor = Color.Transparent;
            p3.BackColor = Color.Transparent;
            p4.BackColor = Color.Transparent;
            fill1();
            fill2();
            fill3();
            fill4();

            timer1.Start();
            timer2.Start();
        }

        private void fill3()
        {
            chart3.Series["series1"].Points.AddXY("0.0", "11");
            chart3.Series["series1"].Points.AddXY("0.1", "33");
            chart3.Series["series1"].Points.AddXY("0.2", "62");
            chart3.Series["series1"].Points.AddXY("0.3", "50");
            chart3.Series["series1"].Points.AddXY("0.4", "9");
            //chart title  
        }

        private void fill4()
        {
            chart4.Series["series1"].Points.AddXY("0.1", "11");
            chart4.Series["series1"].Points.AddXY("0.2", "30");
            chart4.Series["series1"].Points.AddXY("0.3", "22");
            chart4.Series["series1"].Points.AddXY("0.4", "5");
            chart4.Series["series1"].Points.AddXY("0.5", "9");
            //chart title  
            
        }

        private void fill1()
        {
            chart1.Series["Series1"].Points.AddXY("2019", "34");
            chart1.Series["Series1"].Points.AddXY("2010", "42");
            chart1.Series["Series1"].Points.AddXY("2019", "43");
            chart1.Series["Series1"].Points.AddXY("2019", "36");
            chart1.Series["Series1"].Points.AddXY("2021", "39");
            chart1.Series["Series1"].Points.AddXY("2021", "194");
            //chart title  

            chart1.Titles.Add("Users");
        }

        private void fill2()
        {
            chart2.Series["Series1"].Points.AddXY("2019", "34");
            chart2.Series["Series1"].Points.AddXY("2010", "20");
            chart2.Series["Series1"].Points.AddXY("2019", "45");
            chart2.Series["Series1"].Points.AddXY("2019", "70");
            chart2.Series["Series1"].Points.AddXY("2021", "39");
            chart2.Series["Series1"].Points.AddXY("2021", "65");
            //chart title  

            chart2.Titles.Add("Conversion");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void l7_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int val3 = Convert.ToInt16(l5.Text);
            if (val3 < 300)
            {
                val3 += 1;
                l5.Text = val3.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int val3 = Convert.ToInt16(l6.Text);
            if (val3 < 100)
            {
                val3 += 1;
                l6.Text = val3.ToString();
            }
            else
            {
                timer2.Stop();
            }
        }
    }
}
