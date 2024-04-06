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
    public partial class HaelthDB : Form
    {
        public HaelthDB()
        {
            InitializeComponent();
        }

        private void HaelthDB_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            l1.BackColor = Color.Transparent;
            l2.BackColor = Color.Transparent;
            l3.BackColor = Color.Transparent;
            l4.BackColor = Color.Transparent;
            l5.BackColor = Color.Transparent;
            l6.BackColor = Color.Transparent;
            

            p1.BackColor = Color.Transparent;
            p2.BackColor = Color.Transparent;
            p3.BackColor = Color.Transparent;
            timer1.Start();
            fillchart1();
            fillchart2();
            fillchart3();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dsh = new Dashboard();
            dsh.Show();
        }

        private void labelDownloads_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int val3 = Convert.ToInt16(l5.Text);
            if (val3 < 37)
            {
                val3 += 1;
                l5.Text = val3.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
