using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class EditDoctor : Form
    {
        public DbAccess.DbConnection con;
        private int selectedDoctorId;


        public EditDoctor(int doctorId)
        {
            InitializeComponent();
            selectedDoctorId = doctorId;
            con = new DbAccess.DbConnection();
            LoadDoctorData();
            this.FormClosing += EditDoctor_FormClosing;
        }


        //load selected doctor data
        private void LoadDoctorData()
        {
            string query_exist = "SELECT `titles`, `fullname`, `gender`, `contact`, `address`, `email`, `specialty`, `hospital`, `medical_license`, `qualification`, `work_experiance`, `availability` FROM tbl_doctor WHERE doctor_id ='" + selectedDoctorId + "'";
            bool chkDoc = con.DoesRowExist(query_exist);

            if (chkDoc)
            {
                Fullname.Text = con.GetColumnValue(query_exist, "fullname").ToString();
                Title.Text = con.GetColumnValue(query_exist, "titles").ToString();
                if (con.GetColumnValue(query_exist, "gender").ToString() == "Female")
                {
                    GenderF.Checked = true;
                }
                else
                {
                    GenderM.Checked = true;
                }
                Contact.Text = con.GetColumnValue(query_exist, "contact").ToString();
                Email.Text = con.GetColumnValue(query_exist, "email").ToString();
                Address.Text = con.GetColumnValue(query_exist, "address").ToString();
                Medical.Text = con.GetColumnValue(query_exist, "medical_license").ToString();
                Qualification.Text = con.GetColumnValue(query_exist, "qualification").ToString();
                Speciality.Text = con.GetColumnValue(query_exist, "specialty").ToString();
                Hospital.Text = con.GetColumnValue(query_exist, "hospital").ToString();
                Experiance.Text = con.GetColumnValue(query_exist, "work_experiance").ToString();

                //MessageBox.Show("Doctor details loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doctor not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void EditDoctor_FormClosing(object sender, FormClosingEventArgs e)
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
                Update.Enabled = false;
            }
            else
            {
                EmailError.Hide();
                Update.Enabled = true;
            }
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

            Doctor doctor = new Doctor();
            doctor.ID = selectedDoctorId;
            doctor.FullName = fullname;
            doctor.Email = email;
            doctor.Gender = gender;
            doctor.Contact = contact;
            doctor.Title = title;
            doctor.Address = address;
            doctor.License = medical;
            doctor.Qualifications = qualification;
            doctor.Hospital = hospital;
            doctor.Specialty = speciality;
            doctor.Experiance = experiance;

            doctor.UpdateDoctor(con); // Call the update function

            MessageBox.Show("Doctor information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

    }
}
