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
    
    internal class Reports
    {
        [Browsable(false)]
        public int ReportsID { get; set; }

        [Browsable(false)]
        public int AppID { get; set; }
        public string Report { get; set; }

        

        public Reports()
        {
            // Initialize properties with default values
            ReportsID = 0;
            AppID = 0;
            Report = string.Empty;
        }



        //add Reports to database
        public void InsertReports(DbAccess.DbConnection con)
        {
            string tableName = "tbl_lab_reports";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "appointment_id", AppID },
                { "report_name", Report },
            };

            con.ExecuteInsertQuery(tableName, columnsAndValues);

        }


        public static List<Reports> GetAllReportsFromDatabase(DbAccess.DbConnection con, string appid)
        {
            con = new DbAccess.DbConnection();
            List<Reports> labreports = new List<Reports>();

            try
            {
                using (MySqlConnection connection = con.GetConnection()) // Call GetConnection to get MySqlConnection
                {
                    connection.Open();
                    string query = $"SELECT * FROM `tbl_lab_reports` WHERE appointment_id='{appid}' ";
                    
                    MySqlCommand cmd = new MySqlCommand(query, connection); // Pass MySqlConnection instance

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reports report = new Reports
                            {
                                Report = reader["report_name"].ToString(),
                            };
                            labreports.Add(report);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return labreports;
        }



    }

}
