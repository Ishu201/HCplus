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
    
    internal class Payment
    {
        public int PaymentID { get; set; }

        public string Patient { get; set; }
        public string PaymentType { get; set; }
        public string Date { get; set; }
        public int ClinicalCharge { get; set; }
        public int MedCharge { get; set; }
        public int RepCharge { get; set; }
        public int OpCharge { get; set; }
        public int Total { get; set; }
        public string Method { get; set; }



        public Payment()
        {
            // Initialize properties with default values
            PaymentID = 0;
            Patient = string.Empty;
            PaymentType = string.Empty;
            Date = string.Empty;
            ClinicalCharge = 0;
            MedCharge = 0;
            RepCharge = 0;
            OpCharge = 0;
            Total = 0;
            Method = string.Empty;
        }



        //add Payment to database
        public int InsertPayment(DbAccess.DbConnection con)
        {
            string tableName = "tbl_payment";
            Dictionary<string, object> columnsAndValues = new Dictionary<string, object>
            {
                { "patient_id", Patient },
                { "payment_type", PaymentType },
                { "date", Date },
                { "clinical_charge", ClinicalCharge },
                { "medicine_charge", MedCharge },
                { "report_charge", RepCharge },
                { "operation_charge", OpCharge },
                { "total_amount", Total },
                { "payment_method", Method },
            };

            int paymentID = con.ExecuteInsertQuery(tableName, columnsAndValues);

            if (PaymentType == "Clinic & Treatment Payment")
            {
                // Build the UPDATE SQL query
                string updateQuery = "UPDATE tbl_appointments SET payment = 'Paid' WHERE patient_id = @Patient";

                using (MySqlConnection connection = con.GetConnection())
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@Patient", Patient);
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return paymentID;
        }


        public static List<Payment> GetAllPaymentsFromDatabase(DbAccess.DbConnection con, string appid)
        {
            con = new DbAccess.DbConnection();
            List<Payment> payments = new List<Payment>();

            try
            {
                using (MySqlConnection connection = con.GetConnection()) // Call GetConnection to get MySqlConnection
                {
                    connection.Open();
                    string query = $"SELECT * FROM `tbl_payment` ";
                    
                    MySqlCommand cmd = new MySqlCommand(query, connection); // Pass MySqlConnection instance

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //get clinic name from clinic ID
                            int? patientId = reader["patient_id"] as int?;
                            string PaymentQry = "SELECT * FROM tbl_patient WHERE patient_id ='" + patientId + "'";
                            object PaymentNameValue = con.GetColumnValue(PaymentQry, "fullname");
                            string PaymentNames = PaymentNameValue.ToString();


                            Payment pay = new Payment
                            {
                                PaymentID = Convert.ToInt32(reader["payment_id"]),
                                Patient = PaymentNames,
                                PaymentType = reader["payment_type"].ToString(),
                                Date = ((DateTime)reader["date"]).ToString("yyyy-MM-dd"),
                                ClinicalCharge = Convert.ToInt32(reader["clinical_charge"]),
                                MedCharge = Convert.ToInt32(reader["medicine_charge"]),
                                RepCharge = Convert.ToInt32(reader["report_charge"]),
                                OpCharge = Convert.ToInt32(reader["operation_charge"]),
                                Total = Convert.ToInt32(reader["total_amount"]),
                                Method = reader["payment_method"].ToString()
                            };
                        payments.Add(pay);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return payments;
        }



    }

}
