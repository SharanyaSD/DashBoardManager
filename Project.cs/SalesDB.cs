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
    public partial class SalesDB : Form
    {
        public SalesDB()
        {
            InitializeComponent();
        }

        private void timerSales_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(lblSales.Text);
            if (val < 144 )
            {
                val += 3;
                lblSales.Text = val.ToString();
            }
            else
            {
                timerSales.Stop();
            }
        }

        private void timerUnits_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(lblUnits.Text);
            if (val < 42)
            {
                val += 1;
                lblUnits.Text = val.ToString();
            }
            else
            {
                timerUnits.Stop();
            }
        }

        private void SalesDB_Load(object sender, EventArgs e)
        {
            timerUnits.Start();
            timerSales.Start();
            fillchartmain();
            fillpiechart();
        }

        private void fillchartmain()
        {
            chartMain.Series["mcd"].Points.AddXY("January", "55");
            chartMain.Series["burgerking"].Points.AddXY("January", "25");
            chartMain.Series["wendy"].Points.AddXY("January", "5");


            chartMain.Series["mcd"].Points.AddXY("February", "13");
            chartMain.Series["burgerking"].Points.AddXY("February", "41");
            chartMain.Series["wendy"].Points.AddXY("February", "11");


            chartMain.Series["mcd"].Points.AddXY("March", "6");
            chartMain.Series["burgerking"].Points.AddXY("March", "60");
            chartMain.Series["wendy"].Points.AddXY("March", "16");


            chartMain.Series["mcd"].Points.AddXY("April", "7");
            chartMain.Series["burgerking"].Points.AddXY("April", "17");
            chartMain.Series["wendy"].Points.AddXY("April", "47");

            chartMain.Series["mcd"].Points.AddXY("May", "74");
            chartMain.Series["burgerking"].Points.AddXY("May", "24");
            chartMain.Series["wendy"].Points.AddXY("May", "11");

            chartMain.Series["mcd"].Points.AddXY("June", "75");
            chartMain.Series["burgerking"].Points.AddXY("June", "25");
            chartMain.Series["wendy"].Points.AddXY("June", "5");

            chartMain.Series["mcd"].Points.AddXY("July", "11");
            chartMain.Series["burgerking"].Points.AddXY("July", "43");
            chartMain.Series["wendy"].Points.AddXY("July", "73");

            chartMain.Series["mcd"].Points.AddXY("August", "6");
            chartMain.Series["burgerking"].Points.AddXY("August", "60");
            chartMain.Series["wendy"].Points.AddXY("August", "67");

            chartMain.Series["mcd"].Points.AddXY("Sept", "59");
            chartMain.Series["burgerking"].Points.AddXY("Sept", "19");
            chartMain.Series["wendy"].Points.AddXY("Sept", "29");

            chartMain.Series["mcd"].Points.AddXY("Oct", "30");
            chartMain.Series["burgerking"].Points.AddXY("Oct", "40");
            chartMain.Series["wendy"].Points.AddXY("Oct", "14");

            chartMain.Series["mcd"].Points.AddXY("nov", "4");
            chartMain.Series["burgerking"].Points.AddXY("nov", "40");
            chartMain.Series["wendy"].Points.AddXY("nov", "59");


            chartMain.Series["mcd"].Points.AddXY("Dec", "17");
            chartMain.Series["burgerking"].Points.AddXY("Dec", "25");
            chartMain.Series["wendy"].Points.AddXY("Dec", "47");
            //chart title  
            
        }

        private void fillpiechart()
        {
            chart2.Series["Series2"].Points.AddXY("McDonald's", "11");
            chart2.Series["Series2"].Points.AddXY("Burger King", "33");
            chart2.Series["Series2"].Points.AddXY("Wendy's", "62");
            chart2.Series["Series2"].Points.AddXY("Pizza Hut", "50");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dsh = new Dashboard();
            dsh.Show();
        }

        private void chartMain_Click(object sender, EventArgs e)
        {
           
        }
    }
}
