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
    
    internal class Medicine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }


        public Medicine()
        {
            // Initialize properties with default values
            ID = 0;
            Name = string.Empty;
            Price = 0;
            Qty = 0;
        }


        //add Medicine to database
        public void InsertMedicine(DbAccess.DbConnection con)
        {
            string tableName = "tbl_medicines";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "med_name", Name },
                { "price", Price },
                { "qty", Qty }
            };

            con.ExecuteInsertQuery(tableName, columnsAndValues);

        }


        //update Medicine details
        public void UpdateMedicine(DbAccess.DbConnection con,string column)
        {
            con = new DbAccess.DbConnection();
            string tableName = "tbl_medicines";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "med_name", Name },
                { "price", Price },
                { "qty", Qty }
            };
            if (column == "med_name")
            {
                Name = Name;
            }
            else
            {
                Name = ID.ToString();
            }
            string condition = $"`{column}` = '{Name}'"; // Update condition based on ID or Name

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }


        //remove Medicine record
        public void RemoveMedicine(DbAccess.DbConnection con)
        {
            string tableName = "tbl_medicines";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "status", "deactive" }
            };

            string condition = $"medicine_id = {ID}"; // Update condition based on ID
            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }


        //Get all Medicine's details to the table
        public static List<Medicine> GetAllMedicinesFromDatabase(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            List<Medicine> Medicines = new List<Medicine>();

            try
            {
                using (MySqlConnection connection = con.GetConnection()) // Call GetConnection to get MySqlConnection
                {
                    connection.Open();
                    string query = "";
                    query = $"SELECT `medicine_id`, `med_name` ,`price` ,`qty` FROM `tbl_medicines` WHERE status='active'";
                    
                    MySqlCommand cmd = new MySqlCommand(query, connection); // Pass MySqlConnection instance

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Medicine Medicine = new Medicine
                            {
                                ID = Convert.ToInt32(reader["medicine_id"]),
                                Name = reader["med_name"].ToString(),
                                Price = Convert.ToInt32(reader["price"]),
                                Qty = Convert.ToInt32(reader["qty"])
                            };
                            Medicines.Add(Medicine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Medicines;
        }


        //get autocomplete medicine list
        public static List<string> GetAllMedicineNamesFromDatabase(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            List<string> MedicineNames = new List<string>();

            try
            {
                using (MySqlConnection connection = con.GetConnection())
                {
                    connection.Open();
                    string query = "SELECT `med_name` FROM `tbl_medicines` WHERE status='active'";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string medicineName = reader["med_name"].ToString();
                            MedicineNames.Add(medicineName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return MedicineNames;
        }


    }

}
