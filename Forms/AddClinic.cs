using HCplus.Models;
using MySqlConnector;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class AddClinic : Form
    {
        public DbAccess.DbConnection con;


        public AddClinic()
        {
            InitializeComponent();
            con = new DbAccess.DbConnection();
            Doctor_Load();
            Room_Load();
            Clinic_Load();
            this.FormClosing += AddClinic_FormClosing;
        }


        private void AddClinic_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }



        private void Clear_Click(object sender, EventArgs e)
        {
            ClinicDate.Text = string.Empty;
            ClinicType.Text = string.Empty;
            Doctor.Text = string.Empty;
            Location.Text = string.Empty;
            Start.Text = string.Empty;
            End.Text = string.Empty;
            PatientsNo.Value = 0;
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
                string roomquery_exist = "SELECT * FROM tbl_schedule WHERE date='" + clinicDate + "' AND room_id='" + roomID + "' AND TIME_FORMAT(start_time, '%h:%i %p') < '" + startTime + "' AND TIME_FORMAT(end_time, '%h:%i %p') > '" + startTime + "'  AND (status!='removed' AND status!='cancelled') ";
                bool chkRoomRow = con.DoesRowExist(roomquery_exist);

                if (chkRoomRow)
                {
                    MessageBox.Show("This Counsultation Room is Already Booked for the Selected Time.. " + clinicDate + " .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //check doctor availability
                string doc_exist = "SELECT * FROM tbl_schedule WHERE date='" + clinicDate + "' AND doctor_id='" + doctorID + "' AND TIME_FORMAT(start_time, '%h:%i %p') < '" + startTime + "' AND TIME_FORMAT(end_time, '%h:%i %p') > '" + startTime + "' AND (status!='removed' AND status!='cancelled') ";
                bool chkDocRow = con.DoesRowExist(doc_exist);

                if (chkDocRow)
                {
                    MessageBox.Show("This Doctor is not Available for the Selected Time.. " + clinicDate + " .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                //check inventory number duplication
                string query_exist = "SELECT *  FROM tbl_schedule WHERE date='" + clinicDate + "' AND doctor_id='" + doctorID + "' AND clinic_id='" + clinicID + "'";
                bool chkRow = con.DoesRowExist(query_exist);

                if (chkRow)
                {
                    MessageBox.Show("This Clinic is Already Regsitered for " + clinicDate + " .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Clinic clinic = new Clinic
                {
                    Doctor = doctorID,
                    RoomID = roomID,
                    ClinicName = clinicID,
                    CDate = clinicDate,
                    Start = startTime,
                    End = endTime,
                    TotalP = totPatients,
                    BookedP = 0,
                };

                // Assuming you have a DbAccess.DbConnection instance named 'con' available
                clinic.InsertClinic(con);

                MessageBox.Show("Clinic Scheduling is Successful...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void Start_ValueChanged(object sender, EventArgs e)
        {
            //check whether the room is available to schedule a clinic
            string clinicDate = ClinicDate?.Text;
            string roomID = Location?.SelectedValue?.ToString();
            string docID = Doctor?.SelectedValue?.ToString();
            string startTime = Start?.Text;

            string roomquery_exist = "SELECT * FROM tbl_schedule WHERE date='" + clinicDate + "' AND room_id='" + roomID + "' AND TIME_FORMAT(start_time, '%h:%i %p') < '" + startTime + "' AND TIME_FORMAT(end_time, '%h:%i %p') > '" + startTime + "' AND (status!='removed' AND status!='cancelled') ";
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
            string doc_exist = "SELECT * FROM tbl_schedule WHERE date='" + clinicDate + "' AND doctor_id='" + docID + "' AND TIME_FORMAT(start_time, '%h:%i %p') < '" + startTime + "' AND TIME_FORMAT(end_time, '%h:%i %p') > '" + startTime + "' AND (status!='removed' AND status!='cancelled') ";
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
