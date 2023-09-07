using HCplus.Helper;
using HCplus.Models;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class PatientList : Form
    {
        public DbAccess.DbConnection con;
        private UserProfile userProfile; // User session

        public PatientList(UserProfile userProfile)
        {
            InitializeComponent();
            LoadPatientData();

            // Assign the passed UserProfile to the local userProfile
            this.userProfile = userProfile;
            // Access and store the userType directly in the constructor
            string userRole = userProfile.UserType;
            UserType.Text = userRole;
            Check_userAccess(userRole);

            con = new DbAccess.DbConnection();
            LoadNames();
        }

        private void LoadPatientData()
        {
            List<Patient> patient = Patient.GetAllPatientsFromDatabase(con, "No");
            DataList.DataSource = patient;

            foreach (DataGridViewColumn column in DataList.Columns)
            {
                if (column.Name == "ID")
                {
                    column.Width = 50;
                }
                if (column.Name == "Fullname")
                {
                    column.Width = 200;
                }
                if (column.Name == "DOB")
                {
                    column.Width = 100;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (column.Name == "Gender")
                {
                    column.Width = 100;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (column.Name == "NIC")
                {
                    column.Width = 120;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (column.Name == "Contact")
                {
                    column.Width = 120;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }

        }


        private void Check_userAccess(string userRole)
        {
            if (userRole == "Reception")
            {
                HomeBtn.Hide();
                homeLbl.Hide();
                DiagnoseBtn.Hide();
                AppointmentLbl.Hide();
                PaymentBtn.Hide();
                PaymentLbl.Hide();
                PatientListBtn.Hide();
                PatientListLbl.Hide();

                PatientBtn.Location = new Point(26, 125);
                PatientLbl.Location = new Point(17, 156);

                AddBtn.Hide();
            }

            else if (userRole == "Nurse")
            {
                HomeBtn.Hide();
                homeLbl.Hide();
                PatientBtn.Hide();
                PatientLbl.Hide();
                PaymentBtn.Hide();
                PaymentLbl.Hide();
                PatientListBtn.Hide();
                PatientListLbl.Hide();

                DiagnoseBtn.Location = new Point(26, 125);
                AppointmentLbl.Location = new Point(13, 156);
            }
        }


        private void LoadNames()
        {
            List<string> patientNames = Patient.GetAllPatientNamesFromDatabase(con);
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(patientNames.ToArray());

            SearchPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SearchPatient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            SearchPatient.AutoCompleteCustomSource = autoCompleteCollection;

            // Attach the event handler for the KeyUp event
            SearchPatient.KeyUp += SearchPatient_KeyUp;
        }

        private void SearchPatient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string SearchingName = " AND fullname='" + SearchPatient.Text + "' ";
                List<Patient> patient = Patient.GetAllPatientsFromDatabase(con, SearchingName);
                DataList.DataSource = patient;

                foreach (DataGridViewColumn column in DataList.Columns)
                {
                    if (column.Name == "ID")
                    {
                        column.Width = 50;
                    }
                    if (column.Name == "Fullname")
                    {
                        column.Width = 200;
                    }
                    if (column.Name == "DOB")
                    {
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    if (column.Name == "Gender")
                    {
                        column.Width = 100;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    if (column.Name == "NIC")
                    {
                        column.Width = 120;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    if (column.Name == "Contact")
                    {
                        column.Width = 120;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            AddPatient view = new AddPatient();
            view.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadPatientData();
        }


        private void DataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string userRole = userProfile.UserType;
            if (userRole == "Admin")
            {
                // Open the new form
                if (DataList.SelectedRows.Count > 0)
                {
                    Patient selectedPatient = (Patient)DataList.SelectedRows[0].DataBoundItem;
                    int selectedPatientId = selectedPatient.ID;

                    // Open the other form and pass the selectedDoctorId
                    EditPatient view = new EditPatient(selectedPatientId);
                    view.Show();
                }
            }
        }





        //navigation functions
        private void PatientBtn_Click(object sender, EventArgs e)
        {
            PatientModule view = new PatientModule(userProfile);
            view.Show();
            this.Hide();
        }

        private void DiagnoseBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            DiagnoseModule view = new DiagnoseModule(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            PaymentModule view = new PaymentModule(userProfile);
            view.Show();
            this.Hide();
        }




        private void HomeBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            Home view = new Home(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }


        private void PatientListBtn_Click(object sender, EventArgs e)
        {
            PatientList view = new PatientList(userProfile);
            view.Show();
            this.Hide();
        }




    }

}