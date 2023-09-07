using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class AddDoctor : Form
    {
        public DbAccess.DbConnection con;


        public AddDoctor()
        {
            InitializeComponent();
            con = new DbAccess.DbConnection();
            this.FormClosing += AddDoctor_FormClosing;
        }


        private void AddDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string emailVal = Email.Text;
            if (!Regex.IsMatch(emailVal, pattern))
            {
                EmailError.Show();
                Submit.Enabled = false;
            }
            else
            {
                EmailError.Hide();
                Submit.Enabled = true;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Contact.Text = string.Empty;
            Title.Text = string.Empty;
            Fullname.Text = string.Empty;
            Email.Text = string.Empty;
            GenderF.Checked = true;
            EmailError.Visible = false;
            Submit.Enabled = true;
            Address.Text = string.Empty;
            Medical.Text = string.Empty;
            Qualification.Text = string.Empty;
            Hospital.Text = string.Empty;
            Speciality.Text = string.Empty;
            Experiance.Text = string.Empty;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string gender = GenderF.Checked ? "Female" : "Male";
            string contactText = Contact.Text.Replace(" ", ""); // Remove whitespace
            int contact = int.TryParse(contactText, out int parsedContact) ? parsedContact : 0;
            string title = Title.Text;
            string fullname = Fullname.Text;
            string email = Email.Text;
            string address = Address.Text;
            string medical = Medical.Text;
            string qualification = Qualification.Text;
            string hospital = Hospital.Text;
            string speciality = Speciality.Text;
            string experiance = Experiance.Text;

            // Validate non-empty variables
            if (string.IsNullOrEmpty(title) ||
                string.IsNullOrEmpty(fullname) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(medical) ||
                string.IsNullOrEmpty(qualification) ||
                string.IsNullOrEmpty(hospital) ||
                string.IsNullOrEmpty(speciality) ||
                string.IsNullOrEmpty(experiance))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //check duplicate values
                string emailquery_exist = "SELECT * FROM tbl_doctor WHERE email='" + email + "' AND status!='removed'";
                bool chkEmailRow = con.DoesRowExist(emailquery_exist);

                if (chkEmailRow)
                {
                    MessageBox.Show("This Email Address is Already Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string contactquery_exist = "SELECT * FROM tbl_doctor WHERE contact='" + contact + "' AND status!='removed'";
                bool chkcontactRow = con.DoesRowExist(contactquery_exist);

                if (chkcontactRow)
                {
                    MessageBox.Show("This Contact is Already Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string medquery_exist = "SELECT * FROM tbl_doctor WHERE contact='" + contact + "' AND status!='removed'";
                bool chkmedRow = con.DoesRowExist(medquery_exist);

                if (chkmedRow)
                {
                    MessageBox.Show("This Medical License is Already Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Doctor doctor = new Doctor
                {
                    Gender = gender,
                    Contact = contact,
                    Title = title,
                    FullName = fullname,
                    Email = email,
                    Address = address,
                    License = medical,
                    Qualifications = qualification,
                    Hospital = hospital,
                    Specialty = speciality,
                    Experiance = experiance
                };

                // Assuming you have a DbAccess.DbConnection instance named 'con' available
                doctor.InsertDoctor(con);

                MessageBox.Show("Registration is Successful...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

    }
}
