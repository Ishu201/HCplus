using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static HCplus.DbAccess.DbConnection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HCplus.Models
{
    
    internal class Patient
    {

        public int ID { get; set; }
        public string Fullname { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string NIC { get; set; }
        public int Contact { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        //Medical history variables
        [Browsable(false)]
        public int MedID { get; set; }
        [Browsable(false)]
        public string MedicalCondition { get; set; }

        [Browsable(false)]
        public string Allergies { get; set; }

        [Browsable(false)]
        public string PrevSurgeries { get; set; }

        [Browsable(false)]
        public string FamiliHistory { get; set; }

        [Browsable(false)]
        public string HealthcarePreferance { get; set; }


        public Patient()
        {
            // Initialize properties with default values
            ID = 0;
            Fullname = string.Empty;
            DOB = string.Empty;
            Gender = string.Empty;
            NIC = string.Empty;
            Contact = 0;
            Address = string.Empty;
            Email = string.Empty;

            MedID = 0;
            MedicalCondition = null;
            Allergies = null;
            PrevSurgeries = null;
            FamiliHistory = null;
            HealthcarePreferance = null;
        }


        //add Patient to database
        public void InsertPatient(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            // Insert patient personal details
            string tableName = "tbl_patient";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                {"fullname" , Fullname},
                {"dob" , DOB},
                {"gender" , Gender},
                {"nic" , NIC},
                {"contact" , Contact},
                {"address" , Address},
                {"email" , Email}
            };
            con.ExecuteInsertQuery(tableName, columnsAndValues);
        }


        public void InsertPatientMedical(DbAccess.DbConnection con, string patientID)
        {
            con = new DbAccess.DbConnection();
            string tableNamemed = "tbl_medical_history";
            Dictionary<string, object> columnsAndValuesmed = new Dictionary<string, object>
            {
                {"patient_id", patientID },
                {"medical_condition" , MedicalCondition},
                {"allergies" , Allergies},
                {"previous_surgeries" , PrevSurgeries},
                {"family_history" , FamiliHistory},
                {"healthcare_preferance" , HealthcarePreferance} 
            };
            con.ExecuteInsertQuery(tableNamemed, columnsAndValuesmed);
        }



        //update Patient details
        public void UpdatePatient(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            //update personal details
            string tableName = "tbl_patient";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                {"fullname" , Fullname},
                {"dob" , DOB},
                {"gender" , Gender},
                {"nic" , NIC},
                {"contact" , Contact},
                {"address" , Address},
                {"email" , Email}
            };
            string condition = $"`patient_id` = '{ID}'"; // Update condition based on ID or Name
            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);

            //update medical history
            string tableName2 = "tbl_medical_history";
            Dictionary<string, object> columnsAndValues2 = new Dictionary<string, object>
            {
                {"medical_condition" , MedicalCondition},
                {"allergies" , Allergies},
                {"previous_surgeries" , PrevSurgeries},
                {"family_history" , FamiliHistory},
                {"healthcare_preferance" , HealthcarePreferance}
            };
            string condition2 = $"`patient_id` = '{ID}'"; // Update condition based on ID or Name
            con.ExecuteUpdateQuery(tableName2, columnsAndValues2, condition2);
        }



        //remove Patient record
        public void RemovePatient(DbAccess.DbConnection con)
        {
            string tableName = "tbl_patient";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "status", "removed" }
            };

            string condition = $"patient_id = {ID}"; // Update condition based on ID

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }



        //Get all Patient's details to the table
        public static List<Patient> GetAllPatientsFromDatabase(DbAccess.DbConnection con, string conditions)
        {
            con = new DbAccess.DbConnection();
            List<Patient> Patients = new List<Patient>();

            try
            {
                using (MySqlConnection connection = con.GetConnection()) // Call GetConnection to get MySqlConnection
                {
                    connection.Open();
                    string query = "";
                    if (conditions != "No")
                    {
                        query = $"SELECT * FROM `tbl_patient` WHERE status='active' {conditions}";
                    }
                    else
                    {
                        query = "SELECT * FROM `tbl_patient` WHERE status='active'";
                    }

                    MySqlCommand cmd = new MySqlCommand(query, connection); // Pass MySqlConnection instance

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient Patient = new Patient
                            {
                                ID = Convert.ToInt32(reader["patient_id"]),
                                Fullname = reader["fullname"].ToString(),
                                DOB = Convert.ToDateTime(reader["dob"]).ToString("yyyy-MM-dd"),
                                Gender = reader["gender"].ToString(),
                                NIC = reader["nic"].ToString(),
                                Contact = Convert.ToInt32(reader["contact"]),
                                Address = reader["address"].ToString(),
                                Email = reader["email"].ToString(),

                        };
                            Patients.Add(Patient);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Patients;
        }



        //get autocomplete patient list
        public static List<string> GetAllPatientNamesFromDatabase(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            List<string> PatientNames = new List<string>();

            try
            {
                using (MySqlConnection connection = con.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT `fullname` FROM `tbl_patient` WHERE status='active'";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string patientName = reader["fullname"].ToString();
                            PatientNames.Add(patientName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return PatientNames;
        }



        public static Dictionary<string, string> GetAllPatientNamesandIDFromDatabase(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            Dictionary<string, string> PatientNames = new Dictionary<string, string>();

            try
            {
                using (MySqlConnection connection = con.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT `patient_id`,`fullname` FROM `tbl_patient` WHERE status='active'";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string patientName = reader["fullname"].ToString();
                            string patientID = reader["patient_id"].ToString();
                            PatientNames[patientName] = patientID;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return PatientNames;
        }



    }

}
