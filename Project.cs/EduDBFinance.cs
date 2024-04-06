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
    public partial class EduDBFinance : Form
    {
        public EduDBFinance()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EducationDB edu = new EducationDB();
            edu.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(lblMoney.Text);
            if (val < 300)
            {
                val += 1;
                lblMoney.Text = val.ToString();
            }
            else
            {
                timer1.Stop();
            }

            


        }

        private void EduDBFinance_Load(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel8.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            fillChart1();
            fillChart2();
            fillChart3();
            fillChart4();

        }


        private void fillChart1()
        { 
            chart1.Series["series1"].Points.AddXY("2019-$14.56K", "10");
            chart1.Series["series1"].Points.AddXY("2020-$12.36K", "30");
            chart1.Series["series1"].Points.AddXY("2021-$19.20K", "60");
            chart1.Series["series1"].Points.AddXY("2022-$1.6K", "40");
            chart1.Series["series1"].Points.AddXY("2023-$15.56K", "9");
            //chart title  

            chart1.Titles.Add("Grant Money");
        }
        
        private void fillChart2()
        {
            chart2.Series["series1"].Points.AddXY("2019-$14.56K", "20");
            chart2.Series["series1"].Points.AddXY("2020-$12.36K", "3");
            chart2.Series["series1"].Points.AddXY("2021-$19.20K", "19");
            chart2.Series["series1"].Points.AddXY("2022-$1.6K", "45");
            chart2.Series["series1"].Points.AddXY("2023-$15.56K", "19");
            //chart title  

            chart2.Titles.Add("Tution Costs");
        }

        private void fillChart3()
        {
            chart3.Series["series1"].Points.AddXY("2019-$14.56K", "55");
            chart3.Series["series1"].Points.AddXY("2020-$12.36K", "32");
            chart3.Series["series1"].Points.AddXY("2021-$19.20K", "6");
            chart3.Series["series1"].Points.AddXY("2022-$1.6K", "49");
            chart3.Series["series1"].Points.AddXY("2023-$15.56K", "17");
            //chart title  

            chart3.Titles.Add("Cost per Student");
        }

        private void fillChart4()
        {
            chart4.Series["series1"].Points.AddXY("2019-$14.56K", "11");
            chart4.Series["series1"].Points.AddXY("2020-$12.36K", "33");
            chart4.Series["series1"].Points.AddXY("2021-$19.20K", "62");
            chart4.Series["series1"].Points.AddXY("2022-$1.6K", "50");
            chart4.Series["series1"].Points.AddXY("2023-$15.56K", "9");
            //chart title  

            chart4.Titles.Add("Cost of Transit");
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            int val1 = Convert.ToInt16(lblTuition.Text);
            if (val1 < 20)
            {
                val1 += 1;
                lblTuition.Text = val1.ToString();
            }
            else
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int val2 = Convert.ToInt16(lblCostS.Text);
            if (val2 < 32)
            {
                val2 += 1;
                lblCostS.Text = val2.ToString();
            }
            else
            {
                timer3.Stop();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {



            int val3 = Convert.ToInt16(lblCostT.Text);
            if (val3 < 14)
            {
                val3 += 1;
                lblCostT.Text = val3.ToString();
            }
            else
            {
                timer4.Stop();
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
