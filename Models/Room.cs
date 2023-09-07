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
    
    internal class Room
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Doctor { get; set; }
        public string Stat { get; set; }
        public string Availability { get; set; }


        public Room()
        {
            // Initialize properties with default values
            ID = 0;
            Location = string.Empty;
            Type = string.Empty;
            Doctor = string.Empty;
            Stat = string.Empty;
            Availability = string.Empty;
        }


        


        //update Room details
        public void UpdateRoom(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            string tableName = "tbl_rooms";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "current_doctor", Doctor },
                { "current_usage", Stat },
                { "availability", Availability },
            };

            string condition = $"`room_id` = '{ID}'"; // Update condition based on ID or Name

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }



        //Get all Room's details to the table
        public static List<Room> GetAllRoomsFromDatabase(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            List<Room> Rooms = new List<Room>();

            try
            {
                using (MySqlConnection connection = con.GetConnection())
                {
                    connection.Open();
                    string query = $"SELECT * FROM `tbl_rooms`";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int? valDoctor = reader["current_doctor"] as int?;
                            string DocName = "-";

                            if (valDoctor.HasValue && valDoctor.Value > 0)
                            {
                                string doctorQry = "SELECT * FROM tbl_doctor WHERE doctor_id ='" + valDoctor + "'";
                                object doctorNameValue = con.GetColumnValue(doctorQry, "fullname");

                                if (doctorNameValue != DBNull.Value)
                                {
                                    DocName = doctorNameValue.ToString();
                                }
                            }

                            Room room = new Room
                            {
                                ID = Convert.ToInt32(reader["room_id"]),
                                Location = reader["location"].ToString(),
                                Type = reader["room_type"].ToString(),
                                Doctor = DocName,
                                Stat = reader["current_usage"].ToString(),
                                Availability = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(reader["availability"].ToString()),
                            };

                            Rooms.Add(room);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Rooms;
        }





    }

}
