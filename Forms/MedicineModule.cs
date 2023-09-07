using HCplus.Helper;
using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class MedicineModule : Form
    {
        public DbAccess.DbConnection con;
        private UserProfile userProfile; // User session

        public MedicineModule(UserProfile userProfile)
        {
            InitializeComponent();
            LoadMedData();
            LoadNames();
            // Assign the passed UserProfile to the local userProfile
            this.userProfile = userProfile;

            con = new DbAccess.DbConnection();
            int rowCount = con.GetRowCount("tbl_medicines", "No");
            DocCount.Text = rowCount.ToString();
        }

        private void LoadMedData()
        {
            List<Medicine> Medicines = Medicine.GetAllMedicinesFromDatabase(con);
            DataList.DataSource = Medicines;

            foreach (DataGridViewColumn column in DataList.Columns)
            {
                if (column.Name == "ID")
                {
                    column.Width = 50; // Set the desired width
                }
                if (column.Name == "Price")
                {
                    column.Width = 100; // Set the desired width
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Align cell values to the right
                    column.DefaultCellStyle.Format = "N2"; // Format the cell values with two decimal places
                    column.DefaultCellStyle.Padding = new Padding(0, 0, 10, 0); // Add padding for better appearance
                    column.HeaderText = "Price (Rs.)"; // Set the custom header text
                }
                if (column.Name == "Qty")
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align cell values to the center
                }
            }
        }

        private void LoadNames()
        {
            List<string> medicineNames = Medicine.GetAllMedicineNamesFromDatabase(con);
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(medicineNames.ToArray());

            MedName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            MedName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            MedName.AutoCompleteCustomSource = autoCompleteCollection;
        }


        private void SearchFilter_Click(object sender, EventArgs e)
        {
            string med_name = MedName.Text;
            int price = (int)Price.Value;
            int qty = (int)Qty.Value;

            if (!string.IsNullOrEmpty(med_name) && price > 0 && qty > 0)
            {
                Medicine med = new Medicine();
                med.Name = med_name;
                med.Price = price;
                med.Qty = qty;
                string column = "med_name";
                med.UpdateMedicine(con, column); // Call the update function

                MessageBox.Show("Medicine data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MedName.Text = "";
                Price.Value = 0;
                Qty.Value = 0;
            }
            else
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void DataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataList.SelectedRows.Count > 0)
            {
                Medicine selectedMedicine = (Medicine)DataList.SelectedRows[0].DataBoundItem;
                int selectedMedicineId = selectedMedicine.ID;


                // Open the other form and pass the selectedDoctorId
                EditMedicine view = new EditMedicine(selectedMedicineId);
                view.Show();
            }
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Open the add medicine form
            AddMedicine view = new AddMedicine();
            view.Show();
        }





        //navigation functions
        private void DoctorBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            DoctorModule DoctorPage = new DoctorModule(userProfile);
            DoctorPage.Show();

            // Close the current form
            this.Hide();
        }


        private void ResourcesBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            ResourcesModule view = new ResourcesModule(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }

        private void MedBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            MedicineModule view = new MedicineModule(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            RoomModule view = new RoomModule(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }

        private void ClinicBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            ClinicModule view = new ClinicModule(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }



        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadMedData();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            Home view = new Home(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }
    }

}