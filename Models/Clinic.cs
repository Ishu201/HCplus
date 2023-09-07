using MySqlConnector;
using System;
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
    
    internal class Clinic
    {
        public int ID { get; set; }
        public string Doctor { get; set; }
        public string RoomID { get; set; }
        public string CDate { get; set; }

        public string Start { get; set; }
        public string End { get; set; }
        public string ClinicName { get; set; }

        [Browsable(false)]
        public int TotalP { get; set; }
        public int BookedP { get; set; }
        public string Status { get; set; }


        public Clinic()
        {
            // Initialize properties with default values
            ID = 0;
            Doctor = string.Empty;
            RoomID = string.Empty;
            CDate = string.Empty;
            Start = string.Empty;
            End = string.Empty;
            ClinicName = string.Empty;
            TotalP = 0;
            BookedP = 0;
            Status = string.Empty;
        }


        //add clinic to database
        public void InsertClinic(DbAccess.DbConnection con)
        {
            string tableName = "tbl_schedule";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "doctor_id", Doctor },
                { "room_id", RoomID },
                { "date", CDate },
                { "start_time", Start },
                { "clinic_id", ClinicName },
                { "end_time", End },
                { "total_patients", TotalP },
                { "booked_patients", BookedP }
            };

            con.ExecuteInsertQuery(tableName, columnsAndValues);
        }


        //update clinic details
        public void UpdateClinic(DbAccess.DbConnection con)
        {
            string tableName = "tbl_schedule";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "doctor_id", Doctor },
                { "room_id", RoomID },
                { "date", CDate },
                { "start_time", Start },
                { "clinic_id", ClinicName },
                { "end_time", End },
                { "total_patients", TotalP },
                { "booked_patients", BookedP }
            };

            string condition = $"schedule_id = {ID}"; // Update condition based on ID

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }


        //change the status of the clinic schedule
        public void changeStatusOfSchedule(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            string tableName = "tbl_schedule";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                {"status" , Status}
            };
            string condition = $"`schedule_id` = '{ID}'"; // Update condition based on ID or Name

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);

            string doctorQry = "SELECT * FROM tbl_schedule WHERE schedule_id ='" + ID + "'";
            object doctorID = con.GetColumnValue(doctorQry, "doctor_id");
            string DocID = doctorID.ToString();

            //room id
            object roomID = con.GetColumnValue(doctorQry, "room_id");
            string RoomID = roomID.ToString();

            //clinic id
            object clinicID = con.GetColumnValue(doctorQry, "clinic_id");
            string ClinicID = doctorID.ToString();
            string clinicQry = "SELECT * FROM tbl_clinics WHERE clinic_id ='" + ClinicID + "'";
            object clinicName = con.GetColumnValue(clinicQry, "clinic_name");
            string ClinicName = clinicName.ToString();

            if (Status == "Started")
            {
                //update room status
                Dictionary<string, object> columnsAndValues2 = new Dictionary<string, object>
                {
                    {"current_doctor" , DocID},
                    {"current_usage" , ClinicName},
                    {"availability" , "Not Available"}
                };
                string condition2 = $"`room_id` = '{RoomID}'"; 
                con.ExecuteUpdateQuery("tbl_rooms", columnsAndValues2, condition2);


                //update doctor status
                Dictionary<string, object> columnsAndValues3 = new Dictionary<string, object>
                {
                    {"availability" , "On Clinic"}
                };
                string condition3 = $"`doctor_id` = '{DocID}'"; 
                con.ExecuteUpdateQuery("tbl_doctor", columnsAndValues3, condition3);
            }

            else if (Status == "Completed")
            {
                //reset room status
                Dictionary<string, object> columnsAndValues2 = new Dictionary<string, object>
                {
                    {"current_doctor" , ""},
                    {"current_usage" , ""},
                    {"availability" , "free"}
                };
                string condition2 = $"`room_id` = '{RoomID}'"; 
                con.ExecuteUpdateQuery("tbl_rooms", columnsAndValues2, condition2);


                //reset doctor status
                Dictionary<string, object> columnsAndValues3 = new Dictionary<string, object>
                {
                    {"availability" , "Off Clinic"}
                };
                string condition3 = $"`doctor_id` = '{DocID}'"; 
                con.ExecuteUpdateQuery("tbl_doctor", columnsAndValues3, condition3);


                //update status
                Dictionary<string, object> columnsAndValues4 = new Dictionary<string, object>
                {
                    {"status" , "Missed"}
                };
                string condition4 = $"`schedule_id` = '{ID}' AND status='scheduled'";
                con.ExecuteUpdateQuery("tbl_appointments", columnsAndValues4, condition4);
            }
        }



        //remove clinic record
        public void RemoveClinic(DbAccess.DbConnection con)
        {
            string tableName = "tbl_schedule";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "status", "removed" }
            };

            string condition = $"schedule_id = {ID}"; // Update condition based on ID

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);

           // string appcondition = "AND tbl_appointments.schedule_id ='" + ID + "'";
            //List<Appointment> appointments = Appointment.GetAllAppointmentsFromDatabase(con, appcondition);
        }


        //Get all clinic's details to the table
        public static List<Clinic> GetAllClinicsFromDatabase(DbAccess.DbConnection con, string conditions)
        {
            con = new DbAccess.DbConnection();
            List<Clinic> clinics = new List<Clinic>();

            try
            {
                using (MySqlConnection connection = con.GetConnection()) // Call GetConnection to get MySqlConnection
                {
                    connection.Open();
                    string query = "";
                    if (conditions != "No")
                    {
                        query = $"SELECT * FROM `tbl_schedule` WHERE status!='removed' {conditions}";
                    }
                    else
                    {
                        query = "SELECT * FROM `tbl_schedule` WHERE status!='removed'";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, connection); // Pass MySqlConnection instance

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


                            Clinic clinic = new Clinic
                            {
                                ID = Convert.ToInt32(reader["schedule_id"]),
                                CDate = ((DateTime)reader["date"]).ToString("yyyy-MM-dd"),
                                ClinicName = ClinicNames,
                                Doctor = DocName,
                                RoomID = RoomName,
                                Start = DateTime.Parse(reader["start_time"].ToString()).ToString("hh:mm tt"),
                                End = DateTime.Parse(reader["end_time"].ToString()).ToString("hh:mm tt"),
                                BookedP = Convert.ToInt32(reader["booked_patients"]),
                                Status = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(reader["status"].ToString())

                            };
                            clinics.Add(clinic);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return clinics;
        }



        public static Clinic GetClinicByIdFromDatabase(DbAccess.DbConnection con, int scheduleId)
        {
            Clinic clinic = null;

            try
            {
                using (MySqlConnection connection = con.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM `tbl_schedule` WHERE schedule_id = @scheduleId AND status != 'removed'";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@scheduleId", scheduleId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve doctor name from doctor ID
                            int? DoctorId = reader["doctor_id"] as int?;
                            string doctorQry = "SELECT CONCAT(`titles`, ' ', `fullname`) AS `title_and_fullname` FROM tbl_doctor WHERE doctor_id ='" + DoctorId + "'";
                            object doctorNameValue = con.GetColumnValue(doctorQry, "title_and_fullname");
                            string DocName = doctorNameValue?.ToString() ?? "Unknown Doctor";

                            // Retrieve room name from room ID
                            int? RoomId = reader["room_id"] as int?;
                            string roomQry = "SELECT CONCAT(`room_id`, ' ', `location`, ' ', `room_type`) AS `room_name` FROM tbl_rooms WHERE room_id ='" + RoomId + "'";
                            object roomNameValue = con.GetColumnValue(roomQry, "room_name");
                            string RoomName = roomNameValue?.ToString() ?? "Unknown Room";

                            // Retrieve clinic name from clinic ID
                            int? ClinicId = reader["clinic_id"] as int?;
                            string ClinicQry = "SELECT * FROM tbl_clinics WHERE clinic_id ='" + ClinicId + "'";
                            object ClinicNameValue = con.GetColumnValue(ClinicQry, "clinic_name");
                            string ClinicNames = ClinicNameValue?.ToString() ?? "Unknown Clinic";

                            // Create the Clinic object
                            clinic = new Clinic
                            {
                                ID = Convert.ToInt32(reader["schedule_id"]),
                                CDate = ((DateTime)reader["date"]).ToString("yyyy-MM-dd"),
                                ClinicName = ClinicNames,
                                Doctor = DocName,
                                RoomID = RoomName,
                                Start = DateTime.Parse(reader["start_time"].ToString()).ToString("hh:mm tt"),
                                End = DateTime.Parse(reader["end_time"].ToString()).ToString("hh:mm tt"),
                                TotalP = Convert.ToInt32(reader["total_patients"]),
                                BookedP = Convert.ToInt32(reader["booked_patients"]),
                                Status = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(reader["status"].ToString())
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return clinic;
        }


    }

}
