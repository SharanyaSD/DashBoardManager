using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project.cs
{
    public partial class Dashboard : Form
    {

        [DllImport("Gdi32.dll",EntryPoint ="CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthRect,
            int nHeightRect
    );

     

        public Dashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            Dashboard dsh = new Dashboard();
            dsh.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timerEarnings.Start();
            timerSales.Start();
            timerDownloads.Start();
            fillChart1();
            fillChart2();

        }
        private void fillChart1()
        {
            chart1.ChartAreas[0].AxisX.TitleForeColor = System.Drawing.Color.Red;
            chart1.ChartAreas[0].AxisY.TitleForeColor = System.Drawing.Color.Red;
            //AddXY value in chart1 in series named as Salary  
            chart1.Series["series1"].Points.AddXY("Baconator", "10000");
            chart1.Series["series1"].Points.AddXY("Big Mac", "8000");
            chart1.Series["series1"].Points.AddXY("French Fries", "7000");
            chart1.Series["series1"].Points.AddXY("Frosty", "10000");
            chart1.Series["series1"].Points.AddXY("Snack Wrap", "8500");
            //chart title  
            
            chart1.Titles.Add("Product sales");
        }

        private void fillChart2()
        {
            chart2.ChartAreas[0].AxisX.TitleForeColor = System.Drawing.Color.Red;
            chart2.ChartAreas[0].AxisY.TitleForeColor = System.Drawing.Color.Red;
            //AddXY value in chart1 in series named as Salary  
            chart2.Series["series1"].Points.AddXY("Baconator", "10000");
            chart2.Series["series1"].Points.AddXY("Big Mac", "8000");
            chart2.Series["series1"].Points.AddXY("French Fries", "7000");
            chart2.Series["series1"].Points.AddXY("Frosty", "10000");
            chart2.Series["series1"].Points.AddXY("Snack Wrap", "8500");
            //chart title  

            chart2.Titles.Add("Product sales");
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            Analytics an = new Analytics();
            an.Show();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);

            Calender cal = new Calender();
            cal.Show();
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            
        }

        

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(0,0,0);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(0, 0, 0);
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            SearchDirectionHint sdh = SearchDirectionHint.Right;
            bool includesubitems = true;
            int index = 84;
            bool isprefix = true;
            bool istext = false;
            int start = 34;
            Point startpoint = new Point(64, 35);
            string text = "HiThere!";

            SearchForVirtualItemEventArgs sengine = new SearchForVirtualItemEventArgs(istext, isprefix, includesubitems, text, startpoint, sdh, start);
            sengine.Equals(sdh)
                */

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //this.exit
            Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void timerEarnings_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(labelEarnings.Text);
            if(val<50000)
            {
                val += 1;
                labelEarnings.Text = val.ToString();
            }
            else
            {
                timerEarnings.Stop();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelEarnings_Click(object sender, EventArgs e)
        {

        }

        private void timerSales_Tick(object sender, EventArgs e)
        {
            int val1 = Convert.ToInt16(labelSales1.Text);
            if (val1 < 2000)
            {
                val1 += 5;
                labelSales1.Text = val1.ToString();
            }
            else
            {
                timerSales.Stop();
            }

            int val2 = Convert.ToInt16(labelSales2.Text);
            if (val2 < 1500)
            {
                val2 += 1;
                labelSales2.Text = val2.ToString();
            }
            else
            {
                timerSales.Stop();
            }

            int val3 = Convert.ToInt16(labelSales3.Text);
            if (val3 < 3000)
            {
                val3 += 3;
                labelSales3.Text = val3.ToString();
            }
            else
            {
                timerSales.Stop();
            }

        }

        private void labelSales2_Click(object sender, EventArgs e)
        {

        }

        private void timerDownloads_Tick(object sender, EventArgs e)
        {
            int val3 = Convert.ToInt16(labelDownloads.Text);
            if (val3 < 300)
            {
                val3 += 1;
                labelDownloads.Text = val3.ToString();
            }
            else
            {
                timerDownloads.Stop();
            }
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            int saleToday = Convert.ToInt16(labelSales1.Text);
            int saleMonth = Convert.ToInt16(labelSales3.Text);

            if(saleToday>saleMonth)
            {
                textBoxMessage.Text = "Sales are greater than last month";
            }
            else
            {
                textBoxMessage.Text = "Sales are less than last month";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        { //not working
            /*
            int saleToday = Convert.ToInt16(labelSales1.Text);
            int saleMonth = Convert.ToInt16(labelSales3.Text);
            int val;
            if (saleToday > saleMonth)
            {
                progressBar1.Value = saleMonth - saleToday;
            }

            else if (saleToday < saleMonth)
            {
                progressBar1.Value =  saleToday- saleMonth;
            } 

            else if(saleToday == saleMonth)
            {
                progressBar1.Value = saleToday;
            }

    */
        }

        private void button8_Click(object sender, EventArgs e)
        {

            pnlNav.Height = button8.Height;
            pnlNav.Top = button8.Top;
            button8.BackColor = Color.FromArgb(46, 51, 73);

            ConactUs co = new ConactUs();
            co.Show();
        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnlNav.Height = button1.Height;
            pnlNav.Top = button1.Top;
            button1.BackColor = Color.FromArgb(46, 51, 73);

            SalesDB sal = new SalesDB();
            sal.Show();
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSocial.Height;
            pnlNav.Top = btnSocial.Top;
            btnSocial.BackColor = Color.FromArgb(46, 51, 73);

            SocialDB sl = new SocialDB();
            sl.Show();
        }

        private void btnEdu_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEdu.Height;
            pnlNav.Top = btnEdu.Top;
            btnEdu.BackColor = Color.FromArgb(46, 51, 73);

            EducationDB ed = new EducationDB();
            ed.Show();
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHealth.Height;
            pnlNav.Top = btnHealth.Top;
            btnHealth.BackColor = Color.FromArgb(46, 51, 73);

            HaelthDB ed = new HaelthDB();
            ed.Show();
        }

        

        private void btnTraffic_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTraffic.Height;
            pnlNav.Top = btnTraffic.Top;
            btnTraffic.BackColor = Color.FromArgb(46, 51, 73);

            TrafficDB ed = new TrafficDB();
            ed.Show();
        }

        private void labelSales1_Click(object sender, EventArgs e)
        {

        }

        private void labelSales3_Click(object sender, EventArgs e)
        {

        }

        private void labelDownloads_Click(object sender, EventArgs e)
        {

        }
    }
}
