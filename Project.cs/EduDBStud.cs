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
    public partial class EduDBStud : Form
    {
        public EduDBStud()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EducationDB edu = new EducationDB();
            edu.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EduDBStud_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel5.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(100, 0, 0, 0);
            fillmain();
            fillChart1();
            fillChart2();
            fillChart3();
            fillChart4();
            timer1.Start();
        }

        private void fillmain()
        {
            chart5.Series["Series1"].Points.AddXY("2019", "34");
            chart5.Series["Series1"].Points.AddXY("2010", "42");
            chart5.Series["Series1"].Points.AddXY("2019", "43");
            chart5.Series["Series1"].Points.AddXY("2019", "36");
            chart5.Series["Series1"].Points.AddXY("2021", "39");
            chart5.Series["Series1"].Points.AddXY("2021", "194");
            //chart title  

            chart5.Titles.Add("Awards");
        }

        private void fillChart1()
        {
            chart1.Series["Series1"].Points.AddXY("Yes ", "43");
            chart1.Series["Series1"].Points.AddXY("No", "57");
            //chart title  
            
        }

        private void fillChart2()
        {
            chart2.Series["Series1"].Points.AddXY("Yes ", "89");
            chart2.Series["Series1"].Points.AddXY("No ", "11");
            //chart title  
            
        }

        private void fillChart3()
        {
            chart3.Series["Series1"].Points.AddXY("Yes ", "51");
            chart3.Series["Series1"].Points.AddXY("No ", "49");
            //chart title  
            
        }

        private void fillChart4()
        {
            chart4.Series["Series1"].Points.AddXY("Yes ", "25");
            chart4.Series["Series1"].Points.AddXY("No ", "75");
            //chart title  
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void chart5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblUniversity_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int val = Convert.ToInt16(label25.Text);
            if (val < 60)
            {
                val += 1;
                label25.Text = val.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
