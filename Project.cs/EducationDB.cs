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
    public partial class EducationDB : Form
    {
        public EducationDB()
        {
            InitializeComponent();
        }

        private void EducationDB_Load(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel5.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel6.BackColor = Color.FromArgb(100, 0, 0, 0);
            lblStud.BackColor = Color.Transparent;
            lblUniversity.BackColor = Color.Transparent;
            lblFinance.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EduDBStud st = new EduDBStud();
            st.Show();
        }

        private void lblStud_Click(object sender, EventArgs e)
        {
            this.Hide();
            EduDBStud st = new EduDBStud();
            st.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dsh = new Dashboard();
            dsh.Show();
        }

        private void lblFinance_Click(object sender, EventArgs e)
        {
            this.Hide();
            EduDBFinance fin = new EduDBFinance();
            fin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EduDBFinance fin = new EduDBFinance();
            fin.Show();
        }

        private void lblUniversity_Click(object sender, EventArgs e)
        {
            this.Hide();
            EduDBUni un = new EduDBUni();
            un.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EduDBUni un = new EduDBUni();
            un.Show();
        }
    }
}
