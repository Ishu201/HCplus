using HCplus.Forms;
using HCplus.Helper;
using HCplus.Models;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using static HCplus.DbAccess.DbConnection;

namespace HCplus
{
    public partial class LoginPage : Form
    {
        private DbAccess.DbConnection con;
        public LoginPage()
        {
            InitializeComponent();
            con = new DbAccess.DbConnection();

            this.FormClosing += LoginForm_FormClosing;
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = "";
            }
        }

        private void Username_Leave(object sender, EventArgs e)
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

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            RegisterPage RegisterPage = new RegisterPage();
            RegisterPage.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password_static = Password.Text;
            string password = CalculateMD5Hash(password_static);

            if ((username != "Username") && (password != "Password"))
            {
                Models.User newUser = new Models.User(username: username, password: password);

                //check username
                bool usernameChk = con.RecordExists("tbl_users", "username", username);

                //check password
                string customQuery = "SELECT * FROM tbl_users WHERE username ='" + username + "' AND password='" + password + "'";
                bool passwordChk = con.DoesRowExist(customQuery);

                //check approval
                string customQuery2 = "SELECT * FROM tbl_users WHERE username ='" + username + "' AND approve='yes'";
                bool approveChk = con.DoesRowExist(customQuery);

                // login authentication
                if (!usernameChk)
                {
                    MessageBox.Show("This Username is not Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!passwordChk)
                {
                    MessageBox.Show("This Password is Incorrect..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (!approveChk)
                {
                    MessageBox.Show("Your Account is Deactivated.. Check with the Administration..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //check the user role for the username
                    string userRoleQuery = "SELECT * FROM tbl_users WHERE username ='" + username + "'";
                    object UserRole = con.GetColumnValue(userRoleQuery, "user_type");

                    //assign the user role to UserProfile object
                    UserProfile userProfile = new UserProfile(username, UserRole.ToString());

                    this.Hide();

                    if (UserRole.ToString() == "Nurse")
                    {
                        // Open the new form
                        DiagnoseModule view = new DiagnoseModule(userProfile);
                        view.Show();
                    }
                    else if (UserRole.ToString() == "Reception")
                    {
                        // Open the new form
                        PatientModule view = new PatientModule(userProfile);
                        view.Show();
                    }
                    else
                    {
                        // Open the new form
                        Home view = new Home(userProfile);
                        view.Show();
                    }
                    
                }

            }
            else
            {
                MessageBox.Show("Please Insert Username and Password Both..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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


        //close the application
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the form from closing directly
                e.Cancel = true;

                // Prompt the user if they want to exit the application
                DialogResult result = MessageBox.Show("Do you want to exit the application?", "Exit Application",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Exit the application
                    Application.Exit();
                }
            }
        }

    }
}