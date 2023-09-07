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
    
    internal class Prescription
    {
        [Browsable(false)]
        public int PrescriptionID { get; set; }

        [Browsable(false)]
        public int AppID { get; set; }
        public string medicineID { get; set; }
        public string directions { get; set; }
        public int NoOfItems { get; set; }
        public string finishDate { get; set; }
        public string medAvailable { get; set; }

        

        public Prescription()
        {
            // Initialize properties with default values
            PrescriptionID = 0;
            AppID = 0;
            medicineID = string.Empty;
            directions = string.Empty;
            NoOfItems = 0;
            finishDate = string.Empty;
            medAvailable = string.Empty;
        }



        //add Prescription to database
        public void InsertPrescription(DbAccess.DbConnection con)
        {
            string chkQrystarted = "SELECT * FROM tbl_medicines WHERE medicine_id ='" + medicineID + "' AND qty >" + NoOfItems + " ";
            bool chkstat = con.DoesRowExist(chkQrystarted);
            
            if (!chkstat)
            {
                medAvailable = "no";
            }
            else
            {
                medAvailable = "yes";
                string updateQuery = "UPDATE tbl_medicines SET qty = qty-" + NoOfItems + " WHERE medicine_id = @medicineID";

                using (MySqlConnection connection = con.GetConnection())
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@medicineID", medicineID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            string tableName = "tbl_prescriptions";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "appointment_id", AppID },
                { "medicine_id", medicineID },
                { "directions", directions },
                { "no_of_items", NoOfItems },
                { "finish_date", finishDate },
                { "med_availability", medAvailable },
            };

            con.ExecuteInsertQuery(tableName, columnsAndValues);

        }


        public static List<Prescription> GetAllPrescriptionsFromDatabase(DbAccess.DbConnection con, string appid)
        {
            con = new DbAccess.DbConnection();
            List<Prescription> prescriptions = new List<Prescription>();

            try
            {
                using (MySqlConnection connection = con.GetConnection()) // Call GetConnection to get MySqlConnection
                {
                    connection.Open();
                    string query = $"SELECT * FROM `tbl_prescriptions` WHERE appointment_id='{appid}' ";
                    
                    MySqlCommand cmd = new MySqlCommand(query, connection); // Pass MySqlConnection instance

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //get clinic name from clinic ID
                            int? medicineId = reader["medicine_id"] as int?;
                            string PrescriptionQry = "SELECT * FROM tbl_medicines WHERE medicine_id ='" + medicineId + "'";
                            object PrescriptionNameValue = con.GetColumnValue(PrescriptionQry, "med_name");
                            string PrescriptionNames = PrescriptionNameValue.ToString();


                            Prescription presc = new Prescription
                            {
                                AppID = Convert.ToInt32(reader["appointment_id"]),
                                medicineID = PrescriptionNames,
                                directions = reader["directions"].ToString(),
                                NoOfItems = Convert.ToInt32(reader["no_of_items"]),
                                finishDate = ((DateTime)reader["finish_date"]).ToString("yyyy-MM-dd")
                            };
                            prescriptions.Add(presc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return prescriptions;
        }



    }

}
