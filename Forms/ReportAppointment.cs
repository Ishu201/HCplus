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
    public partial class ReportAppointment : Form
    {
        public DbAccess.DbConnection con;
        private UserProfile userProfile; // User session

        public ReportAppointment(UserProfile userProfile)
        {
            InitializeComponent();
            this.userProfile = userProfile;
            string userRole = userProfile.UserType;
            UserType.Text = userRole;

            con = new DbAccess.DbConnection();
            LoadPatientData("No");
            LoadNames();
            Clinic_Load();
        }

        private void LoadPatientData(string Condition)
        {
            List<Appointment> appointments = Appointment.GetAllAppointmentsFromDatabase(con, Condition);

            // Assuming `clinics` is the data source for DataList DataGridView
            DataList.DataSource = appointments;

            if (appointments.Count == 0)
            {
                DataList.Hide();
                MessageBox.Show("No Appointment Booked...!!");
            }
            else
            {
                DataList.Show();
            }

            foreach (DataGridViewColumn column in DataList.Columns)
            {
                if (column.Name == "APPOINTID")
                {
                    column.DisplayIndex = 0;
                    column.HeaderText = "ID";
                    column.Width = 50;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (column.Name == "Patient")
                {
                    column.HeaderText = "Patient Name";
                    column.DisplayIndex = 1;
                }
                if (column.Name == "Clinic")
                {
                    column.HeaderText = "Clinic Name";
                    column.DisplayIndex = 2;
                }
                if (column.Name == "CDate")
                {
                    column.HeaderText = "Date";
                    column.DisplayIndex = 3;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (column.Name == "Doctor")
                {
                    column.DisplayIndex = 4;
                }
                if (column.Name == "RoomName")
                {
                    column.Visible = false;
                }
                if (column.Name == "AppointmentNO")
                {
                    column.HeaderText = "App No";
                    column.DisplayIndex = 5;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (column.Name == "Status")
                {
                    column.DisplayIndex = 6;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

            }

        }

        private Dictionary<string, string> patientNamesAndIds;

        private void LoadNames()
        {
            // Initialize the class-level dictionary
            patientNamesAndIds = Patient.GetAllPatientNamesandIDFromDatabase(con);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(patientNamesAndIds.Keys.ToArray());

            SearchPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SearchPatient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            SearchPatient.AutoCompleteCustomSource = autoCompleteCollection;
        }


        private void ClinicType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void SearchFilter_Click(object sender, EventArgs e)
        {
            string patientName = SearchPatient.Text;
            string patientID = null;
            if (patientNamesAndIds.TryGetValue(patientName, out string id))
            {
                patientID = id;
            }
            string clinicID = ClinicType.SelectedValue?.ToString();

            if (string.IsNullOrEmpty(patientName) && (string.IsNullOrEmpty(clinicID) || clinicID == "0"))
            {
                MessageBox.Show("Select the Patient Name and the Clinic Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string condition = "AND clinic_id='" + clinicID + "' AND patient_id='" + patientID + "' ";
            LoadPatientData(condition);

        }


        private void DataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataList.SelectedRows.Count > 0)
            {
                int appointId = (int)DataList.SelectedRows[0].Cells["APPOINTID"].Value;
                string appstatus = DataList.SelectedRows[0].Cells["Status"].Value.ToString(); // Ensure it's a string

                if (string.Equals(appstatus, "scheduled", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(appstatus, "Missed", StringComparison.OrdinalIgnoreCase))
                {
                    RescheduleApp view = new RescheduleApp(appointId);
                    view.Show();
                }
                else
                {
                    MessageBox.Show("This Appointment can't be Rescheduled or Cancelled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }



        private void Clinic_Load()
        {
            string query = "SELECT `clinic_id`, `clinic_name` FROM `tbl_clinics`";
            DataTable dataLists = con.GetComboList(query);

            // Add an empty row to the DataTable to be used as a placeholder
            DataRow emptyRow = dataLists.NewRow();
            emptyRow["clinic_id"] = "0";
            emptyRow["clinic_name"] = "Select a clinic..."; // Text to display in the placeholder
            dataLists.Rows.InsertAt(emptyRow, 0);

            ClinicType.DataSource = dataLists;
            ClinicType.DisplayMember = "clinic_name";
            ClinicType.ValueMember = "clinic_id";
        }






        //navigation functions
        private void AppointmentBtn_Click(object sender, EventArgs e)
        {
            ReportAppointment view = new ReportAppointment(userProfile);
            view.Show();
            this.Hide();
        }


        private void PaymentBtn_Click(object sender, EventArgs e)
        {

        }

        private void PatientListBtn_Click(object sender, EventArgs e)
        {

        }


        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home view = new Home(userProfile);
            view.Show();
            this.Hide();
        }

        private void MedicationBtn_Click(object sender, EventArgs e)
        {

        }

        private void OpRoomsBtn_Click(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            SearchPatient.Text = "";
            LoadPatientData("No");
        }
    }

}