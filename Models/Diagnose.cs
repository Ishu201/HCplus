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
    
    internal class Diagnose
    {
        public int DiagnoseID { get; set; }
        public string AppDate { get; set; }
        public int AppID { get; set; }
        public string DiagnoseDesc { get; set; }
        public string LabReportStat { get; set; }
        public string OpStat { get; set; }


        //op schedule variables
        [Browsable(false)]
        public string opRoom { get; set; }

        [Browsable(false)]
        public string opDate { get; set; }

        [Browsable(false)]
        public string opDetails { get; set; }

        [Browsable(false)]
        public int opPatients { get; set; }


        public Diagnose()
        {
            // Initialize properties with default values
            DiagnoseID = 0;
            AppDate = string.Empty;
            AppID = 0;
            DiagnoseDesc = string.Empty;
            LabReportStat = string.Empty;
            OpStat = string.Empty;
            opRoom = string.Empty;
            opDate = string.Empty;
            opDetails = string.Empty;
            opPatients = 0;
        }



        //add diagnose to database
        public void InsertDiagnose(DbAccess.DbConnection con)
        {
            string tableName = "tbl_diagnoses";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "date", AppDate },
                { "appointment_id", AppID },
                { "diagnose", DiagnoseDesc },
            };

            con.ExecuteInsertQuery(tableName, columnsAndValues);

            // Build the UPDATE SQL query
            string updateQuery = "UPDATE tbl_appointments SET status = 'Completed' WHERE appointment_id = @AppID";

            using (MySqlConnection connection = con.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                cmd.Parameters.AddWithValue("@AppID", AppID);
                int rowsAffected = cmd.ExecuteNonQuery();
            }

        }



        //update diagnose details
        public void UpdateDiagnose(DbAccess.DbConnection con)
        {
            string tableName = "tbl_diagnoses";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "diagnose", DiagnoseDesc }
            };

            string condition = $"appointment_id  = {AppID}"; // Update condition based on ID

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }




        //operation schedule insert
        public void ScheduleOperation(DbAccess.DbConnection con)
        {
            string tableName = "tbl_operation_schedule";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "op_room_id", opRoom },
                { "patient_id", opPatients },
                { "date", opDate },
                { "op_details", opDetails },
            };

            con.ExecuteInsertQuery(tableName, columnsAndValues);

        }



    }

}
