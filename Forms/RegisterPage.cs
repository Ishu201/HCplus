using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCplus.Forms
{
    public partial class RegisterPage : Form
    {
        private DbAccess.DbConnection con;

        public RegisterPage()
        {
            InitializeComponent();
            con = new DbAccess.DbConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Hide();

            // Open the new form
            LoginPage LoginPage = new LoginPage();
            LoginPage.Show();
        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password_static = Password.Text;
            string password_confirm = PasswordConfirm.Text;
            string password = CalculateMD5Hash(password_static);
            string userType;

            if (password_static != password_confirm)
            {
                MessageBox.Show("Passwords do not match..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if any of the fields is empty
            if ((username != "Username") && (password != "Password"))
            {
                if (NurseUser.Checked)
                {
                    userType = "Nurse";
                }
                else
                {
                    userType = "Reception";
                }

                Models.User newUser = new Models.User(username, password, userType);

                // Check for existing username and staff Id

                bool usernameChk = con.RecordExists("tbl_users", "username", newUser.Username);

                if (usernameChk)
                {
                    MessageBox.Show("This Username is already Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                newUser.AddUser(con); // Insert the new user record

                MessageBox.Show("Registration is Successful... You will be redirected to Home Page..!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the current form
                this.Hide();

                //assign the user role to UserProfile object
                UserProfile userProfile = new UserProfile(username, userType);

                if (userType == "Nurse")
                {
                    // Open the new form
                    DiagnoseModule view = new DiagnoseModule(userProfile);
                    view.Show();
                }
                else if (userType == "Reception")
                {
                    // Open the new form
                    PatientModule view = new PatientModule(userProfile);
                    view.Show();
                }
                else
                {
                    // Open the new form
                    LoginPage view = new LoginPage();
                    view.Show();

                    // Open the new form
                    Home view2 = new Home(userProfile);
                    view2.Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill All Required Fields..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = "";
            }
        }


        private void Username_Leave_1(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.PasswordChar = '*';
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.PasswordChar = '\0';
            }
        }

        private void PasswordConfirm_Enter(object sender, EventArgs e)
        {
            if (PasswordConfirm.Text == "Re-type Password")
            {
                PasswordConfirm.Text = "";
                PasswordConfirm.PasswordChar = '*';
            }
        }

        private void PasswordConfirm_Leave(object sender, EventArgs e)
        {
            if (PasswordConfirm.Text == "")
            {
                PasswordConfirm.Text = "Re-type Password";
                PasswordConfirm.PasswordChar = '\0';
            }
        }


        //helper functions 
        //password hashing function
        private string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2")); // Convert to hexadecimal
                }

                return builder.ToString();
            }
        }

    }
}
