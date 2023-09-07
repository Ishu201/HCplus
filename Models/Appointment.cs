using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HCplus.DbAccess.DbConnection;

namespace HCplus.Models
{
    
    internal class Appointment
    {
        public int APPOINTID { get; set; }
        public string Clinic { get; set; }
        public string Doctor { get; set; }
        public string RoomName { get; set; }
        public string CDate { get; set; }

        public int AppointmentNO { get; set; }
        public string Patient { get; set; }
        public string Status { get; set; }


        public Appointment()
        {
            // Initialize properties with default values
            APPOINTID = 0;
            Clinic = string.Empty;
            Doctor = string.Empty;
            RoomName = string.Empty;
            CDate = string.Empty;
            AppointmentNO = 0;
            Patient = string.Empty;
            Status = string.Empty;
        }



        //add clinic to database
        public void InsertAppointment(DbAccess.DbConnection con)
        {
            string tableName = "tbl_appointments";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "schedule_id", Clinic },
                { "patient_id", Patient },
                { "appointment_no", AppointmentNO }
            };

            con.ExecuteInsertQuery(tableName, columnsAndValues);

            string updateQuery = "UPDATE tbl_schedule SET booked_patients = booked_patients + 1 WHERE schedule_id = @scheduleId";

            using (MySqlConnection connection = con.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                cmd.Parameters.AddWithValue("@scheduleId", Clinic);
                int rowsAffected = cmd.ExecuteNonQuery();
            }
            
        }


        //update clinic details
        public void UpdateAppointment(DbAccess.DbConnection con)
        {
            string tableName = "tbl_appointments";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "schedule_id", Clinic },
                { "status", "scheduled" }
            };

            string condition = $"appointment_id  = {APPOINTID}"; // Update condition based on ID

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);

            string updateQuery = "UPDATE tbl_schedule SET booked_patients = booked_patients + 1 WHERE schedule_id = @scheduleId";

            using (MySqlConnection connection = con.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                cmd.Parameters.AddWithValue("@scheduleId", Clinic);
                int rowsAffected = cmd.ExecuteNonQuery();
            }
        }


        //remove clinic record
        public void CancelAppointment(DbAccess.DbConnection con)
        {
            string tableName = "tbl_appointments";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "status", "cancelled" }
            };

            string condition = $"appointment_id  = {APPOINTID}"; // Update condition based on ID

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }


        //Get all clinic's details to the table
        public static List<Appointment> GetAllAppointmentsFromDatabase(DbAccess.DbConnection con, string conditions)
        {
            con = new DbAccess.DbConnection();
            List<Appointment> appointments = new List<Appointment>();

            try
            {
                using (MySqlConnection connection = con.GetConnection())
                {
                    connection.Open();
                    string query = "";
                    if (conditions != "No")
                    {
                        query = $"SELECT tbl_schedule.*,tbl_appointments.*,tbl_appointments.status AS appStatus FROM `tbl_appointments` INNER JOIN `tbl_schedule` ON tbl_schedule.schedule_id=tbl_appointments.schedule_id WHERE tbl_appointments.status != 'removed' {conditions}";
                    }
                    else
                    {
                        query = "SELECT tbl_schedule.*,tbl_appointments.*,tbl_appointments.status AS appStatus FROM `tbl_appointments` INNER JOIN `tbl_schedule` ON tbl_schedule.schedule_id=tbl_appointments.schedule_id";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //get doctor name from doctor ID
                            int? DoctorId = reader["doctor_id"] as int?;
                            string doctorQry = "SELECT CONCAT(`titles`, ' ', `fullname`) AS `title_and_fullname` FROM tbl_doctor WHERE doctor_id ='" + DoctorId + "'";
                            object doctorNameValue = con.GetColumnValue(doctorQry, "title_and_fullname");
                            string DocName = doctorNameValue.ToString();


                            //get room name from room ID
                            int? RoomId = reader["room_id"] as int?;
                            string roomQry = "SELECT CONCAT(`room_id`, ' ', `location`, ' ', `room_type`) AS `room_name` FROM tbl_rooms WHERE room_id ='" + RoomId + "'";
                            object roomNameValue = con.GetColumnValue(roomQry, "room_name");
                            string RoomName = roomNameValue.ToString();


                            //get clinic name from clinic ID
                            int? ClinicId = reader["clinic_id"] as int?;
                            string ClinicQry = "SELECT * FROM tbl_clinics WHERE clinic_id ='" + ClinicId + "'";
                            object ClinicNameValue = con.GetColumnValue(ClinicQry, "clinic_name");
                            string ClinicNames = ClinicNameValue.ToString();


                            int? PatientId = reader["patient_id"] as int?;
                            string ptQry = "SELECT `fullname` FROM tbl_patient WHERE patient_id = '" + PatientId + "'";
                            object ptNameValue = con.GetColumnValue(ptQry, "fullname");
                            string PatientName = ptNameValue.ToString();

                            // Create an instance of Appointment
                            Appointment appointment = new Appointment
                            {
                                APPOINTID = Convert.ToInt32(reader["appointment_id"]),
                                Clinic = ClinicNames,
                                Doctor = DocName,
                                RoomName = RoomName,
                                CDate = ((DateTime)reader["date"]).ToString("yyyy-MM-dd"),
                                AppointmentNO = Convert.ToInt32(reader["appointment_no"]),
                                Patient = PatientName,
                                Status = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(reader["appStatus"].ToString())
                            };
                            appointments.Add(appointment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return appointments;
        }




    }

}
