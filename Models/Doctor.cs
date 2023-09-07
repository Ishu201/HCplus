using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HCplus.DbAccess.DbConnection;

namespace HCplus.Models
{
    
    internal class Doctor
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int Contact { get; set; }

        [Browsable(false)]
        public string Title { get; set; }
        public string Email { get; set; }
        public string Specialty { get; set; }
        public string Hospital { get; set; }
        public string Availability { get; set; }
        public string License { get; set; }
        public string Qualifications { get; set; }

        [Browsable(false)]
        public string Address { get; set; }
        [Browsable(false)]
        public string Experiance{ get; set; }


        public Doctor()
        {
            // Initialize properties with default values
            ID = 0;
            FullName = string.Empty;
            Gender = string.Empty;
            Contact = 0;
            Email = string.Empty;
            Specialty = string.Empty;
            Hospital = string.Empty;
            Availability = string.Empty;
            License = string.Empty;
            Qualifications = string.Empty;

            // Hide these properties by setting them to null
            Address = null;
            Experiance = null;
            Title = null;
        }


        //add doctor to database
        public void InsertDoctor(DbAccess.DbConnection con)
        {
            string tableName = "tbl_doctor";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "fullname", FullName },
                { "email", Email },
                { "gender", Gender },
                { "contact", Contact },
                { "titles", Title },
                { "address", Address },
                { "medical_license", License },
                { "qualification", Qualifications },
                { "hospital", Hospital },
                { "specialty", Specialty },
                { "work_experiance", Experiance }
            };

            con.ExecuteInsertQuery(tableName, columnsAndValues);
        }


        //update doctor details
        public void UpdateDoctor(DbAccess.DbConnection con)
        {
            string tableName = "tbl_doctor";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "fullname", FullName },
                { "email", Email },
                { "gender", Gender },
                { "contact", Contact },
                { "titles", Title },
                { "address", Address },
                { "medical_license", License },
                { "qualification", Qualifications },
                { "hospital", Hospital },
                { "specialty", Specialty },
                { "work_experiance", Experiance }
            };

            string condition = $"doctor_id = {ID}"; // Update condition based on ID

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }


        //remove doctor record
        public void RemoveDoctor(DbAccess.DbConnection con)
        {
            string tableName = "tbl_doctor";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "status", "deactive" }
            };

            string condition = $"doctor_id = {ID}"; // Update condition based on ID

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }


        //Get all doctor's details to the table
        public static List<Doctor> GetAllDoctorsFromDatabase(DbAccess.DbConnection con, string conditions)
        {
            con = new DbAccess.DbConnection();
            List<Doctor> doctors = new List<Doctor>();

            try
            {
                using (MySqlConnection connection = con.GetConnection()) // Call GetConnection to get MySqlConnection
                {
                    connection.Open();
                    string query = "";
                    if (conditions != "No")
                    {
                        query = $"SELECT `doctor_id`, CONCAT(`titles`, ' ', `fullname`) AS `title_and_fullname`, `gender`, `contact`,  `email`, `specialty`, `hospital`, `medical_license` ,`qualification` ,`availability` FROM `tbl_doctor` WHERE status='active' {conditions}";
                    }
                    else
                    {
                        query = "SELECT `doctor_id`, CONCAT(`titles`, ' ', `fullname`) AS `title_and_fullname`, `gender`, `contact`,  `email`, `specialty`, `hospital`, `medical_license` ,`qualification` ,`availability` FROM `tbl_doctor` WHERE status='active'";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, connection); // Pass MySqlConnection instance

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Doctor doctor = new Doctor
                            {
                                ID = Convert.ToInt32(reader["doctor_id"]),
                                FullName = reader["title_and_fullname"].ToString(),
                                Gender = reader["gender"].ToString(),
                                Contact = Convert.ToInt32(reader["contact"]),
                                Email = reader["email"].ToString(),
                                Specialty = reader["specialty"].ToString(),
                                Hospital = reader["hospital"].ToString(),
                                License = reader["medical_license"].ToString(),
                                Qualifications = reader["qualification"].ToString(),
                                Availability = reader["availability"].ToString()
                            };
                            doctors.Add(doctor);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return doctors;
        }



        //Hospital list of the doctors registered for the location filter
        public static List<string> GetHospitalsFromDoctorData(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            List<string> Hospitals = new List<string>();

            // Add "All" to the Hospitals list
            Hospitals.Add("All");
            try
            {
                using (MySqlConnection connection = con.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT `hospital` FROM `tbl_doctor`";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string hospital = reader["hospital"].ToString();
                            Hospitals.Add(hospital);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Hospitals;
        }



    }

}
