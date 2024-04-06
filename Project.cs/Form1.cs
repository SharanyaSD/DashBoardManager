using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace Project.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            NewAdminReg newAdmin = new NewAdminReg();
            newAdmin.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {/*
            textBox1.Clear();
          //  pbuser.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            textBox1.ForeColor = Color.FromArgb(128, 128, 255);

           // pbpswd.BackgroundImage = Properties.Resources.hidden;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

           // pbmail.BackgroundImage = Properties.Resources.email;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;*/
        }

        

        private void textBox2_Click_1(object sender, EventArgs e)
        {/*
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            // pbpswd.BackgroundImage = Properties.Resources.hidden;
            panel2.BackColor = Color.FromArgb(128, 128, 255);
            textBox2.ForeColor = Color.FromArgb(128, 128, 255);

            // pbuser.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            //   pbmail.BackgroundImage = Properties.Resources.email;
            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;*/
        }

        private void textBox3_Click_1(object sender, EventArgs e)
        {/*
            textBox3.Clear();
            //   pbmail.BackgroundImage = Properties.Resources.email;
            panel3.BackColor = Color.FromArgb(128, 128, 255);
            textBox3.ForeColor = Color.FromArgb(128, 128, 255);

            //    pbuser.BackgroundImage = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            //  pbpswd.BackgroundImage = Properties.Resources.hidden;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;*/
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {/*
            label2.Text = dsh.Left.ToString();
            dsh.Left += 10;
            if(dsh.Left>=830)
            {
                timer1.Stop();
                this.TopMost = false;
                dsh.TopMost = true;
                timer2.Start();
            }*/
        }

        private void timer2_Tick(object sender, EventArgs e)
        {/*
            label2.Text = dsh.Left.ToString();
            dsh.Left += 10;
            if(dsh.Left<=525)
            {
                timer2.Stop();
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
          /*  if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Username is required to login");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }*/
            
        }

        public async void DataFromCloud()
        {
            Cursor.Current = Cursors.WaitCursor;
            var fb = new FirebaseClient(FBConfig.url);
            RegDB obj = new RegDB();

            obj.Password = textBox2.Text;
            obj.Email = textBox3.Text;
            var fbdata = await fb.Child("RegDB").OnceAsync<RegDB>();
            int id = 0;
            foreach (var data in fbdata)
            {
                RegDB rg = new RegDB();
                rg.Email = data.Object.Email;
                rg.Password = data.Object.Password;

                if (rg.Email == textBox3.Text && rg.Password == textBox2.Text)
                {
                    id = 1;
                    MessageBox.Show("Login done successfully");
                    Dashboard dsh = new Dashboard();
                    dsh.Show();
                    
                    textBox2.Text = "";
                    textBox3.Text = "";
                    return;
                }
            }
            if (id == 0)
            {
                MessageBox.Show("Invalid User");
            }
        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {

            DataFromCloud();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                errorProvider1.SetError(textBox2, "Password is required to login");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                e.Cancel = true;
                textBox3.Focus();
                errorProvider1.SetError(textBox3, "Email is required to login");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox3, "");
            }
        }
    }
}
