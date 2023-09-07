using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCplus.DbAccess
{
    public class DbConnection
    {
        private string connectionString = "server=localhost;user=root;password=;database=db_healthcare;";

        // database connection function
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        //connection testing function
        public bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }



        // Executes an Centrelized INSERT query to insert data into the specified table with given columns and values.
        public int ExecuteInsertQuery(string tableName, Dictionary<string, object> columnsAndValues)
        {
            int lastInsertedId = -1; // Default value if the insert fails

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string columnNames = string.Join(", ", columnsAndValues.Keys);
                string valuePlaceholders = string.Join(", ", columnsAndValues.Keys.Select(key => "@" + key));
                string query = $"INSERT INTO {tableName} ({columnNames}) VALUES ({valuePlaceholders})";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    foreach (var kvp in columnsAndValues)
                    {
                        cmd.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // If the insert was successful, retrieve the last inserted ID
                        cmd.CommandText = "SELECT LAST_INSERT_ID()";
                        lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }

            return lastInsertedId;
        }



        //Executes an centrelized UPDATE query data to edit data rows
        public void ExecuteUpdateQuery(string tableName, Dictionary<string, object> columnsAndValues, string condition)
        {
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string updateValues = string.Join(", ", columnsAndValues.Keys.Select(key => $"{key} = @{key}"));
                string query = $"UPDATE {tableName} SET {updateValues} WHERE {condition}";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    foreach (var kvp in columnsAndValues)
                    {
                        cmd.Parameters.AddWithValue("@" + kvp.Key, kvp.Value);
                    }

                    cmd.ExecuteNonQuery();
                }
            }
        }


        //Execute an centrelized function to remove record
        public void ExecuteDeleteQuery(string tableName, string condition)
        {
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = $"DELETE FROM {tableName} WHERE {condition}";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }



        //record exist checking function for single condition
        public bool RecordExists(string tableName, string columnName, object columnValue)
        {
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @{columnName}";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@" + columnName, columnValue);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }


        //record exists with multiple conditions
        public bool DoesRowExist(string query)
        {
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }


        //get single record  data
        public object GetColumnValue(string query, string columnName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                return dataTable.Rows[0][columnName];
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return null;
        }



        //get the number of rows function
        public int GetRowCount(string tableName, string conditions)
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "";
                    if (conditions != "No")
                    {
                        query = $"SELECT COUNT(*) FROM {tableName} WHERE {conditions}";
                    }
                    else
                    {
                        query = $"SELECT COUNT(*) FROM {tableName}";
                    }
                    
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return 0;
        }



        //centrelized function to generate list data for combobox values
        public DataTable GetComboList(string query)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }

        internal T ExecuteScalar<T>(string getLastInsertedIdQuery)
        {
            throw new NotImplementedException();
        }
    }
}
