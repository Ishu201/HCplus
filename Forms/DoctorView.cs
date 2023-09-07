using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class DoctorView : Form
    {
        public DbAccess.DbConnection con;

        private int selectedDoctorId;
        public DoctorView(int doctorId)
        {
            InitializeComponent();
            selectedDoctorId = doctorId;
            con = new DbAccess.DbConnection();

            LoadDoctorData();
            this.FormClosing += DoctorView_FormClosing;
        }


        private void LoadDoctorData()
        {
            string query_exist = "SELECT CONCAT(`titles`, ' ', `fullname`) AS `title_and_fullname`, `gender`, `contact`, `address`, `email`, `specialty`, `hospital`, `medical_license`, `qualification`, `work_experiance`, `availability` FROM tbl_doctor WHERE doctor_id ='" + selectedDoctorId + "'";
            bool chkDoc = con.DoesRowExist(query_exist);

            if (chkDoc)
            {
                fullname.Text = con.GetColumnValue(query_exist, "title_and_fullname").ToString();
                gender.Text = con.GetColumnValue(query_exist, "gender").ToString();
                contact.Text = con.GetColumnValue(query_exist, "contact").ToString();
                email.Text = con.GetColumnValue(query_exist, "email").ToString();
                address.Text = con.GetColumnValue(query_exist, "address").ToString();
                medicalLicense.Text = con.GetColumnValue(query_exist, "medical_license").ToString();
                qualifications.Text = con.GetColumnValue(query_exist, "qualification").ToString();
                speciality.Text = con.GetColumnValue(query_exist, "specialty").ToString();
                availability.Text = con.GetColumnValue(query_exist, "availability").ToString();
                hospital.Text = con.GetColumnValue(query_exist, "hospital").ToString();
                experiance.Text = con.GetColumnValue(query_exist, "work_experiance").ToString();

                //MessageBox.Show("Doctor details loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Doctor not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void DoctorView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditDoctor view = new EditDoctor(selectedDoctorId);
            view.Show();

            this.Hide();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int doctorIDToRemove = selectedDoctorId;

            DialogResult result = MessageBox.Show("Are you sure you want to remove this doctor's record?", "Confirm Removal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Doctor doctor = new Doctor();
                doctor.ID = doctorIDToRemove;

                doctor.RemoveDoctor(con); // Call the remove function

                MessageBox.Show("Doctor record removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Doctor record removal canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
