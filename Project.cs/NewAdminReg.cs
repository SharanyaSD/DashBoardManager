using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using System.Text.RegularExpressions;

namespace Project.cs
{
    public partial class NewAdminReg : Form
    {
        public NewAdminReg()
        {
            InitializeComponent();
        }

        public async void RegDB()
        {
            Cursor.Current = Cursors.WaitCursor;
            FirebaseClient fb = new FirebaseClient(FBConfig.url);

            RegDB obj = new RegDB();
            obj.Username = TbUser.Text;
            obj.Email = TbEmail.Text;
            obj.Contact = TbContact.Text;
            obj.Password = TbPassw.Text;

            try
            {
                await fb.Child("RegDB").PostAsync(obj);
                MessageBox.Show("Registration successful");
                TbUser.Text = "";
                TbEmail.Text = "";
                TbContact.Text = "";
                TbPassw.Text = "";

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            Cursor.Current = Cursors.Default;
        }

        private void NewAdminReg_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            if (TbEmail.Text.Trim() != "")
            {
                if (TbEmail.Text.Trim().Contains('@') == false || TbEmail.Text.Trim().Contains('.') == false)
                {
                    MessageBox.Show("Please enter valid email ads");
                }
            }
            //----------Contact-------------------------------------------------------------------------------------------------------
            if (TbContact.Text.Length != 10 || TbContact.Text == null)
            {
                MessageBox.Show("Please enter valid contact");
            }
            //-------------Password-----------------------------------------------------------------------------------------------------

            Regex reg = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            if (!string.IsNullOrEmpty(TbPassw.Text.Trim()))
            {
                Match match = reg.Match(TbPassw.Text);
                if (!match.Success)
                {
                    MessageBox.Show("Password is not valid");
                }

            }

            //-------------Conform password--------------------------------------------------------------------------------------------------
            if (TbPassw.Text == TbConfPswd.Text)
            {
                MessageBox.Show("passwords matched");
            }
            else
            {
                MessageBox.Show("passwords don't match");
            }

          
            RegDB();
        }

        private void TbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPassw_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbConfPswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbUser.Text))
            {
                e.Cancel = true;
                TbUser.Focus();
                errorProvider1.SetError(TbUser, "Username is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TbUser, "");
            }
        }

        private void TbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbEmail.Text))
            {
                e.Cancel = true;
                TbEmail.Focus();
                errorProvider1.SetError(TbEmail, "Email ID is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TbEmail, "");
            }

        }

        private void TbContact_Validating(object sender, CancelEventArgs e)
        {
            string num = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            if (string.IsNullOrWhiteSpace(TbContact.Text))
            {
                e.Cancel = true;
                TbContact.Focus();
                errorProvider1.SetError(TbContact, "Contact number is required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TbContact, "");
            }
        }

        private void TbPassw_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbPassw.Text))
            {
                e.Cancel = true;
                TbPassw.Focus();
                errorProvider1.SetError(TbPassw, "Set Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TbPassw, "");
            }
        }

        private void TbConfPswd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbConfPswd.Text))
            {
                e.Cancel = true;
                TbConfPswd.Focus();
                errorProvider1.SetError(TbConfPswd, "Please reassure Password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TbConfPswd, "");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //not working
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
