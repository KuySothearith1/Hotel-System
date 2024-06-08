using Hotet_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotet_System.Forms
{
    public partial class FormLogin : Form
    {
        int logincount;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            //if (txtPassword.Text == "Password")
            //{
            //    txtPassword.Text = "";

            //    txtPassword.ForeColor = Color.Black;
            //}
            
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            //if (txtPassword.Text == "")
            //{

            //    txtPassword.Text = "Password";
            //    txtPassword.ForeColor = Color.Gray;
            //}
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ////txtUsername.Text = "Username";
            //txtPassword.Text = "Password";
            ////txtUsername.ForeColor = Color.Gray;
            //txtPassword.ForeColor = Color.Gray;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!DoValidation())
                return;

            AppUser user = AppUsers.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (user == null)
            {
                MessageBox.Show("Invalid Username and Password, Please enter again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logincount++;
                if (logincount == 3)
                {
                    Application.Exit();
                }

            }
            else
            {
                FormMain formMain = new FormMain();
                formMain.UserLogin = user;
                this.Hide();
                formMain.ShowDialog();
                this.Close();
            }
        }
        bool DoValidation()
        {
            bool result = true;
            if (txtUsername.Text.Trim() == "")
            {
                epUserName.SetError(txtUsername, "Username is required.");
                result = false;
            }
            if (txtPassword.Text.Trim() == "")
            {
                epPassword.SetError(txtPassword, "Password is required.");
                result = false;
            }
            return result;
        }
    }
}
