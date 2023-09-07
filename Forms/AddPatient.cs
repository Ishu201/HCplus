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
    public partial class AddPatient : Form
    {
        public DbAccess.DbConnection con;


        public AddPatient()
        {
            InitializeComponent();
            con = new DbAccess.DbConnection();
            this.FormClosing += AddPatient_FormClosing;
        }


        private void AddPatient_FormClosing(object sender, FormClosingEventArgs e)
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

                string emailquery_exist = "SELECT * FROM tbl_patient WHERE email='" + emailVal + "' AND status!='removed'";
                bool chkEmailRow = con.DoesRowExist(emailquery_exist);

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

        private void Clear_Click(object sender, EventArgs e)
        {
            Contact.Text = string.Empty;
            Fullname.Text = string.Empty;
            Email.Text = string.Empty;
            GenderF.Checked = true;
            EmailError.Visible = false;
            Submit.Enabled = true;
            Address.Text = string.Empty;
            Dob.Text = string.Empty;
            Nic.Text = string.Empty;

            SpConditions.Text = string.Empty;
            Allergies.Text = string.Empty;
            FamHistory.Text = string.Empty;
            HCpreferance.Text = string.Empty;
            PrevSurgeries.Text = string.Empty;
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
                string emailquery_exist = "SELECT * FROM tbl_patient WHERE email='" + email + "' AND status!='removed'";
                bool chkEmailRow = con.DoesRowExist(emailquery_exist);

                if (chkEmailRow)
                {
                    MessageBox.Show("This Email Address is Already Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Patient patient = new Patient
                {
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

                patient.InsertPatient(con);
                string getLastInsertedIdQuery = "SELECT MAX(patient_id) AS maxno FROM tbl_patient";
                string patientID = con.GetColumnValue(getLastInsertedIdQuery, "maxno").ToString();

                patient.InsertPatientMedical(con, patientID);

                MessageBox.Show("Registration is Successful...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    }
}
