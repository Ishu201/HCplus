using HCplus.Models;
using MySqlConnector;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class EditClinic : Form
    {
        public DbAccess.DbConnection con;
        private int selectedClinicId;


        public EditClinic(int clinicId)
        {
            InitializeComponent();
            selectedClinicId = clinicId;
            con = new DbAccess.DbConnection();
            Doctor_Load();
            Room_Load();
            Clinic_Load();
            LoadClinicData();
            this.FormClosing += EditClinic_FormClosing;
        }


        private void EditClinic_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }


        private void LoadClinicData()
        {
            string query_exist = "SELECT * FROM tbl_schedule WHERE schedule_id ='" + selectedClinicId + "'";
            bool chkRow = con.DoesRowExist(query_exist);

            if (chkRow)
            {
                string clinicDateString = Convert.ToDateTime(con.GetColumnValue(query_exist, "date")).ToString("yyyy-MM-dd");
                DateTime clinicDate;
                if (DateTime.TryParseExact(clinicDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out clinicDate))
                {
                    ClinicDate.Value = clinicDate;
                }

                ClinicType.SelectedValue = con.GetColumnValue(query_exist, "clinic_id").ToString();
                Doctor.SelectedValue = con.GetColumnValue(query_exist, "doctor_id").ToString();
                Location.SelectedValue = con.GetColumnValue(query_exist, "room_id").ToString();

                string startTimeString = con.GetColumnValue(query_exist, "start_time").ToString();
                DateTime startTime;
                if (DateTime.TryParseExact(startTimeString, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out startTime))
                {
                    Start.Value = startTime;
                }

                string endTimeString = con.GetColumnValue(query_exist, "end_time").ToString();
                DateTime endTime;
                if (DateTime.TryParseExact(endTimeString, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out endTime))
                {
                    End.Value = endTime;
                }

                PatientsNo.Text = con.GetColumnValue(query_exist, "total_patients").ToString();
            }
            else
            {
                MessageBox.Show("Clinic not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void Submit_Click(object sender, EventArgs e)
        {
            string clinicDate = ClinicDate.Text;
            string clinicID = ClinicType.SelectedValue?.ToString();
            string doctorID = Doctor.SelectedValue?.ToString();
            string roomID = Location.SelectedValue?.ToString();
            string startTime = Start.Text;
            string endTime = End.Text;
            string PatientsNum = PatientsNo.Text;
            int totPatients = int.TryParse(PatientsNum, out int parsedPatientsNo) ? parsedPatientsNo : 0;

            // Validate non-empty variables
            if (string.IsNullOrWhiteSpace(clinicDate) ||
                string.IsNullOrEmpty(clinicID) || clinicID == "0" ||
                string.IsNullOrEmpty(doctorID) || doctorID == "0" ||
                string.IsNullOrEmpty(roomID) || roomID == "0" ||
                string.IsNullOrWhiteSpace(startTime) ||
                string.IsNullOrWhiteSpace(endTime) ||
                string.IsNullOrWhiteSpace(PatientsNum))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (totPatients <= 0)
                {
                    MessageBox.Show("Please enter a valid number of patients.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //check Time and Consultation Room Availability
                string roomquery_exist = "SELECT * FROM tbl_schedule WHERE schedule_id!='" + selectedClinicId + "' AND date='" + clinicDate + "' AND room_id='" + roomID + "' AND TIME_FORMAT(start_time, '%h:%i %p') < '" + startTime + "' AND TIME_FORMAT(end_time, '%h:%i %p') > '" + startTime + "' AND status!='removed' ";
                bool chkRoomRow = con.DoesRowExist(roomquery_exist);

                if (chkRoomRow)
                {
                    MessageBox.Show("This Counsultation Room is Already Booked for the Selected Time in " + clinicDate + " .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //check doctor availability
                string doc_exist = "SELECT * FROM tbl_schedule WHERE  schedule_id!='" + selectedClinicId + "' AND date='" + clinicDate + "' AND doctor_id='" + doctorID + "' AND TIME_FORMAT(start_time, '%h:%i %p') < '" + startTime + "' AND TIME_FORMAT(end_time, '%h:%i %p') > '" + startTime + "' AND status!='removed'  ";
                bool chkDocRow = con.DoesRowExist(doc_exist);

                if (chkDocRow)
                {
                    MessageBox.Show("This Doctor is not Available for the Selected Time.. " + clinicDate + " .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Clinic clinic = new Clinic
                {
                    ID = selectedClinicId,
                    Doctor = doctorID,
                    RoomID = roomID,
                    ClinicName = clinicID,
                    CDate = clinicDate,
                    Start = startTime,
                    End = endTime,
                    TotalP = totPatients
                };

                // Assuming you have a DbAccess.DbConnection instance named 'con' available
                clinic.UpdateClinic(con);

                MessageBox.Show("Clinic Schedule Update is Successful...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void Start_ValueChanged(object sender, EventArgs e)
        {
            string clinicDate = ClinicDate?.Text;
            string roomID = Location?.SelectedValue?.ToString();
            string docID = Doctor?.SelectedValue?.ToString();
            string startTime = Start?.Text;

            string roomquery_exist = "SELECT * FROM tbl_schedule WHERE  schedule_id!='" + selectedClinicId + "' AND date='" + clinicDate + "' AND room_id='" + roomID + "' AND TIME_FORMAT(start_time, '%h:%i %p') < '" + startTime + "' AND TIME_FORMAT(end_time, '%h:%i %p') > '" + startTime + "' AND status!='removed'  ";
            bool chkRoomRow = con.DoesRowExist(roomquery_exist);

            if (chkRoomRow)
            {
                string StartTime = con.GetColumnValue(roomquery_exist, "start_time").ToString();
                string EndTime = con.GetColumnValue(roomquery_exist, "end_time").ToString();
                ScheduleErr.Text = "This Consultation Room is Booked From " + StartTime + " to " + EndTime + "...";
            }
            else
            {
                ScheduleErr.Text = "";
            }


            //check whether the doctor is available to schedule a clinic
            string doc_exist = "SELECT * FROM tbl_schedule WHERE  schedule_id!='" + selectedClinicId + "' AND date='" + clinicDate + "' AND doctor_id='" + docID + "' AND TIME_FORMAT(start_time, '%h:%i %p') < '" + startTime + "' AND TIME_FORMAT(end_time, '%h:%i %p') > '" + startTime + "' AND status!='removed'  ";
            bool chkDocRow = con.DoesRowExist(doc_exist);

            if (chkDocRow)
            {
                string StartTime = con.GetColumnValue(doc_exist, "start_time").ToString();
                string EndTime = con.GetColumnValue(doc_exist, "end_time").ToString();
                DocErr.Text = "Doctor Is not Available from  " + StartTime + " to " + EndTime + "...";
            }
            else
            {
                DocErr.Text = "";
            }
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            int clinicIDToRemove = selectedClinicId;

            DialogResult result = MessageBox.Show("Are you sure you want to Cancel this Clinic?", "Confirm Removal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Clinic clinic = new Clinic();
                clinic.ID = clinicIDToRemove;

                clinic.RemoveClinic(con); // Call the remove function

                MessageBox.Show("Clinic cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Clinic Cancelling is not Confirmed..", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        //helper functions
        private void Doctor_Load()
        {
            string query = "SELECT `doctor_id`, CONCAT(`titles`, ' ', `fullname`,' - ', `specialty`) AS `title_and_fullname` FROM `tbl_doctor` WHERE status='active'";
            DataTable dataLists = con.GetComboList(query);

            // Add an empty row to the DataTable to be used as a placeholder
            DataRow emptyRow = dataLists.NewRow();
            emptyRow["doctor_id"] = "0"; // Use a value that doesn't exist in your actual data (assuming 0 is not a valid ID)
            emptyRow["title_and_fullname"] = "Select a doctor...";
            dataLists.Rows.InsertAt(emptyRow, 0);

            Doctor.DataSource = dataLists;
            Doctor.DisplayMember = "title_and_fullname";
            Doctor.ValueMember = "doctor_id";

        }


        private void Room_Load()
        {
            string query = "SELECT `room_id`, CONCAT(`room_id`, ' - ', `location`, ' ', `room_type`) AS `room_name` FROM `tbl_rooms` WHERE room_type='Consultation Room'";
            DataTable dataLists = con.GetComboList(query);

            // Add an empty row to the DataTable to be used as a placeholder
            DataRow emptyRow = dataLists.NewRow();
            emptyRow["room_id"] = "0";
            emptyRow["room_name"] = "Select a location..."; // Text to display in the placeholder
            dataLists.Rows.InsertAt(emptyRow, 0);

            Location.DataSource = dataLists;
            Location.DisplayMember = "room_name";
            Location.ValueMember = "room_id";
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

        
    }
}
