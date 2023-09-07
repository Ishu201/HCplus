using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class EditPatient : Form
    {
        public DbAccess.DbConnection con;
        private int selectedPatientId;


        public EditPatient(int patientId)
        {
            InitializeComponent();
            selectedPatientId = patientId;
            con = new DbAccess.DbConnection();
            LoadPatientData();
            this.FormClosing += EditPatient_FormClosing;
        }


        private void LoadPatientData()
        {
            string query_patient = "SELECT * FROM tbl_patient WHERE patient_id ='" + selectedPatientId + "'";
            bool chkDoc = con.DoesRowExist(query_patient);

            if (chkDoc)
            {
                string query_med = "SELECT * FROM tbl_medical_history WHERE patient_id ='" + selectedPatientId + "'";
                Fullname.Text = con.GetColumnValue(query_patient, "fullname").ToString();
                if (con.GetColumnValue(query_patient, "gender").ToString() == "Female")
                {
                    GenderF.Checked = true;
                }
                else
                {
                    GenderM.Checked = true;
                }

                string dobDateString = Convert.ToDateTime(con.GetColumnValue(query_patient, "dob")).ToString("yyyy-MM-dd");
                DateTime dobDate;
                if (DateTime.TryParseExact(dobDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dobDate))
                {
                    Dob.Value = dobDate;
                }

                Contact.Text = "0" + con.GetColumnValue(query_patient, "contact").ToString();
                Email.Text = con.GetColumnValue(query_patient, "email").ToString();
                Nic.Text = con.GetColumnValue(query_patient, "nic").ToString();
                Address.Text = con.GetColumnValue(query_patient, "address").ToString();

                SpConditions.Text = con.GetColumnValue(query_med, "medical_condition").ToString();
                Allergies.Text = con.GetColumnValue(query_med, "allergies").ToString();
                FamHistory.Text = con.GetColumnValue(query_med, "previous_surgeries").ToString();
                HCpreferance.Text = con.GetColumnValue(query_med, "family_history").ToString();
                PrevSurgeries.Text = con.GetColumnValue(query_med, "healthcare_preferance").ToString();
            }
            else
            {
                MessageBox.Show("Patient not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void EditPatient_FormClosing(object sender, FormClosingEventArgs e)
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
                EmailError.Text = "Email Address is Incorrect..";
                EmailError.Show();
                Submit.Enabled = false;
            }
            else
            {
                EmailError.Hide();

                string emailquery_patient = "SELECT * FROM tbl_patient WHERE patient_id!='" + selectedPatientId + "' AND email='" + emailVal + "' AND status!='removed'";
                bool chkEmailRow = con.DoesRowExist(emailquery_patient);

                if (chkEmailRow)
                {
                    EmailError.Text = "This Email Address is Already Registered..";
                    EmailError.Show();
                }
                else
                {
                    Submit.Enabled = true;
                }
            }
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            string fullname = Fullname.Text;
            string gender = GenderF.Checked ? "Female" : "Male";
            string contactText = Contact.Text.Replace(" ", ""); // Remove whitespace
            int contact = int.TryParse(contactText, out int parsedContact) ? parsedContact : 0;
            string email = Email.Text;
            string address = Address.Text;
            string nic = Nic.Text;
            string dob = Dob.Text;

            string spCondition = SpConditions.Text;
            string allergies = Allergies.Text;
            string famHistory = FamHistory.Text;
            string hcPreferance = HCpreferance.Text;
            string prevSurge = PrevSurgeries.Text;

            // Validate non-empty variables
            bool isValid = !string.IsNullOrWhiteSpace(fullname) &&
               !string.IsNullOrWhiteSpace(contactText) &&
               !string.IsNullOrWhiteSpace(email) &&
               !string.IsNullOrWhiteSpace(address) &&
               !string.IsNullOrWhiteSpace(spCondition) &&
               !string.IsNullOrWhiteSpace(allergies) &&
               !string.IsNullOrWhiteSpace(famHistory) &&
               !string.IsNullOrWhiteSpace(hcPreferance) &&
               !string.IsNullOrWhiteSpace(prevSurge);

            if (!isValid)
            {
                MessageBox.Show("All fields except NIC required to Register a Patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Check duplicate values
                string emailquery_patient = "SELECT * FROM tbl_patient WHERE  patient_id !='" + selectedPatientId + "' AND email='" + email + "' AND status!='removed'";
                bool chkEmailRow = con.DoesRowExist(emailquery_patient);

                if (chkEmailRow)
                {
                    MessageBox.Show("This Email Address is Already Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Patient patient = new Patient
                {
                    ID = selectedPatientId,
                    Fullname = fullname,
                    DOB = dob,
                    Gender = gender,
                    NIC = nic,
                    Contact = contact,
                    Address = address,
                    Email = email,

                    MedicalCondition = spCondition,
                    Allergies = allergies,
                    PrevSurgeries = famHistory,
                    FamiliHistory = hcPreferance,
                    HealthcarePreferance = prevSurge
                };

                patient.UpdatePatient(con);

                MessageBox.Show("Patient Update is Successful...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }



        private void Nic_TextChanged(object sender, EventArgs e)
        {
            string nicPattern = @"^\d{9}[0-9V]$"; // 9 digits followed by either digit or 'V'
            string nicValue = Nic.Text;

            if (nicValue.Length == 10 && Regex.IsMatch(nicValue, nicPattern))
            {
                NicErr.Hide();
                Submit.Enabled = true;
            }
            else
            {
                NicErr.Show();
                Submit.Enabled = false;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int patientIDToRemove = selectedPatientId;

            DialogResult result = MessageBox.Show("Are you sure you want to remove this Patient's record?", "Confirm Removal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Patient patient = new Patient();
                patient.ID = patientIDToRemove;

                patient.RemovePatient(con); // Call the remove function

                MessageBox.Show("Patient record removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Patient record removal canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
