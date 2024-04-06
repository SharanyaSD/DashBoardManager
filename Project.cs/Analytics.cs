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
    public partial class Analytics : Form
    {
        public Analytics()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Analytics_Load(object sender, EventArgs e)
        {
            fillchart1();
            fillchart2();
            fillchart3();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
        }

        private void fillchart1()
        {
            chart1.Series["series1"].Points.AddXY("January", "55");
            chart1.Series["series1"].Points.AddXY("February", "32");
            chart1.Series["series1"].Points.AddXY("March", "6");
            chart1.Series["series1"].Points.AddXY("April", "49");
            chart1.Series["series1"].Points.AddXY("May", "17");
            chart1.Series["series1"].Points.AddXY("June", "55");
            chart1.Series["series1"].Points.AddXY("July", "32");
            chart1.Series["series1"].Points.AddXY("August", "6");
            chart1.Series["series1"].Points.AddXY("Sept", "49");
            chart1.Series["series1"].Points.AddXY("Oct", "17");
            chart1.Series["series1"].Points.AddXY("nov", "49");
            chart1.Series["series1"].Points.AddXY("Dec", "17");
            //chart title  

        }

        private void fillchart2()
        {
            chart2.Series["series1"].Points.AddXY("January", "55");
            chart2.Series["series1"].Points.AddXY("February", "11");
            chart2.Series["series1"].Points.AddXY("March", "6");
            chart2.Series["series1"].Points.AddXY("April", "77");
            chart2.Series["series1"].Points.AddXY("May", "44");
            chart2.Series["series1"].Points.AddXY("June", "55");
            chart2.Series["series1"].Points.AddXY("July", "13");
            chart2.Series["series1"].Points.AddXY("August", "6");
            chart2.Series["series1"].Points.AddXY("Sept", "49");
            chart2.Series["series1"].Points.AddXY("Oct", "42");
            chart2.Series["series1"].Points.AddXY("nov", "49");
            chart2.Series["series1"].Points.AddXY("Dec", "17");
            //chart title  
        }

        private void fillchart3()
        {
            chart3.Series["series1"].Points.AddXY("January", "50");
            chart3.Series["series1"].Points.AddXY("February", "10");
            chart3.Series["series1"].Points.AddXY("March", "60");
            chart3.Series["series1"].Points.AddXY("April", "20");
            chart3.Series["series1"].Points.AddXY("May", "11");
            chart3.Series["series1"].Points.AddXY("June", "22");
            chart3.Series["series1"].Points.AddXY("July", "10");
            chart3.Series["series1"].Points.AddXY("August", "6");
            chart3.Series["series1"].Points.AddXY("Sept", "49");
            chart3.Series["series1"].Points.AddXY("Oct", "17");
            chart3.Series["series1"].Points.AddXY("nov", "49");
            chart3.Series["series1"].Points.AddXY("Dec", "17");
            //chart title  

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int val3 = Convert.ToInt16(l1.Text);
            if (val3 < 299)
            {
                val3 += 1;
                l1.Text = val3.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int val3 = Convert.ToInt16(l2.Text);
            if (val3 < 50)
            {
                val3 += 1;
                l2.Text = val3.ToString();
            }
            else
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int val3 = Convert.ToInt16(l3.Text);
            if (val3 < 47)
            {
                val3 += 1;
                l3.Text = val3.ToString();
            }
            else
            {
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int val3 = Convert.ToInt16(l4.Text);
            if (val3 < 37)
            {
                val3 += 1;
                l4.Text = val3.ToString();
            }
            else
            {
                timer4.Stop();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
