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
    
    internal class Resource
    {

        public int ID { get; set; }
        public string Resource_type { get; set; }
        public string Item_name { get; set; }

        public string Description { get; set; }

        [Browsable(false)]
        public string Purchase_date { get; set; }

        [Browsable(false)]
        public string Vendor { get; set; }

        [Browsable(false)]
        public int Cost { get; set; }
        public string Department { get; set; }
        public string Inventory_no { get; set; }

        [Browsable(false)]
        public string Warranty_end { get; set; }
        public string RStatus { get; set; }


        public Resource()
        {
            // Initialize properties with default values
            ID = 0;
            Resource_type = string.Empty;
            Item_name = string.Empty;
            Description = null;
            Purchase_date = null;
            Vendor = null;
            Cost = 0;
            Department = string.Empty;
            Inventory_no = string.Empty;
            Warranty_end = string.Empty;
            RStatus = string.Empty;
        }


        //add Resource to database
        public void InsertResource(DbAccess.DbConnection con)
        {
            string tableName = "tbl_resources";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                {"resource_type" , Resource_type},
                {"item_name" , Item_name},
                {"description" , Description},
                {"purchase_date" , Purchase_date},
                {"vendor" , Vendor},
                {"cost" , Cost},
                {"department" , Department},
                {"inventory_no" , Inventory_no},
                {"warranty_end" , Warranty_end}
            };

            con.ExecuteInsertQuery(tableName, columnsAndValues);
        }


        //update Resource details
        public void UpdateResource(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            string tableName = "tbl_resources";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                {"resource_type" , Resource_type},
                {"item_name" , Item_name},
                {"description" , Description},
                {"purchase_date" , Purchase_date},
                {"vendor" , Vendor},
                {"cost" , Cost},
                {"department" , Department},
                {"inventory_no" , Inventory_no},
                {"warranty_end" , Warranty_end}
            };
            string condition = $"`resource_id` = '{ID}'"; // Update condition based on ID or Name

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }


        //remove Resource record
        public void RemoveResource(DbAccess.DbConnection con)
        {
            string tableName = "tbl_resources";
            string condition = $"resource_id = {ID}"; // Specify the condition based on the Resource's ID

            con.ExecuteDeleteQuery(tableName, condition);
        }


        //Get all Resource's details to the table
        public static List<Resource> GetAllResourcesFromDatabase(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            List<Resource> Resources = new List<Resource>();

            try
            {
                using (MySqlConnection connection = con.GetConnection()) // Call GetConnection to get MySqlConnection
                {
                    connection.Open();
                    string query = "";
                    query = $"SELECT `resource_id`, `resource_type`, `item_name`, `description`, `department`, `inventory_no`, `warranty_end`,`status` FROM `tbl_resources`";
                    
                    MySqlCommand cmd = new MySqlCommand(query, connection); // Pass MySqlConnection instance

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Resource Resource = new Resource
                            {
                                ID = Convert.ToInt32(reader["resource_id"]),
                                Resource_type = reader["resource_type"].ToString(),
                                Item_name = reader["item_name"].ToString(),
                                Department = reader["department"].ToString(),
                                Description = reader["description"].ToString(),
                                Inventory_no = reader["inventory_no"].ToString(),
                                RStatus = reader["status"].ToString()
                            };
                            Resources.Add(Resource);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Resources;
        }



        //deactivate the item
        public void DeactiveResource(DbAccess.DbConnection con)
        {
            con = new DbAccess.DbConnection();
            string tableName = "tbl_resources";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                {"status" , RStatus}
            };
            string condition = $"`resource_id` = '{ID}'"; // Update condition based on ID or Name

            con.ExecuteUpdateQuery(tableName, columnsAndValues, condition);
        }


    }

}
