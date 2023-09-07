using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class EditMedicine : Form
    {
        public DbAccess.DbConnection con;
        private int selectedMedicineId;


        public EditMedicine(int medicineId)
        {
            InitializeComponent();
            selectedMedicineId = medicineId;
            con = new DbAccess.DbConnection();
            LoadMedData();
            this.FormClosing += EditMedicine_FormClosing;
        }


        //load selected doctor data
        private void LoadMedData()
        {
            string query_exist = "SELECT `med_name`, `price`, `qty`  FROM tbl_medicines WHERE medicine_id ='" + selectedMedicineId + "'";
            bool chkRow = con.DoesRowExist(query_exist);

            if (chkRow)
            {
                MedName.Text = con.GetColumnValue(query_exist, "med_name").ToString();
                Price.Text = Convert.ToDecimal(con.GetColumnValue(query_exist, "price")).ToString("0.00");
                Qty.Text = con.GetColumnValue(query_exist, "qty").ToString();
            }
            else
            {
                MessageBox.Show("Medicine not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void EditMedicine_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }



        private void Submit_Click(object sender, EventArgs e)
        {
            string med_name = MedName.Text;
            string priceText = Price.Text;
            int price = int.TryParse(priceText, out int parsedPrice) ? parsedPrice : 0;
            string qtyText = Qty.Text;
            int qty = int.TryParse(qtyText, out int parsedQty) ? parsedQty : 0;

            // Validate non-empty variables
            if (string.IsNullOrEmpty(med_name) || price <= 0 && qty <= 0)
            {
                MessageBox.Show("All fields are required with Valid Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Medicine medicine = new Medicine();
            medicine.ID = selectedMedicineId;
            medicine.Name = med_name;
            medicine.Price = price;
            medicine.Qty = qty;

            medicine.UpdateMedicine(con, "medicine_id"); // Call the update function

            MessageBox.Show("Medicine information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }



        private void Remove_Click(object sender, EventArgs e)
        {
            int medicineIDToRemove = selectedMedicineId;

            DialogResult result = MessageBox.Show("Are you sure you want to remove this Medicine's record?", "Confirm Removal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Medicine medicine = new Medicine();
                medicine.ID = medicineIDToRemove;

                medicine.RemoveMedicine(con); // Call the remove function

                MessageBox.Show("Medicine record removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Medicine record removal canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
