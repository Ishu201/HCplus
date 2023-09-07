using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class EditResource : Form
    {
        public DbAccess.DbConnection con;
        private int selectedResourceId;


        public EditResource(int resourceId)
        {
            InitializeComponent();
            selectedResourceId = resourceId;
            con = new DbAccess.DbConnection();
            LoadResData();
            this.FormClosing += EditResource_FormClosing;
        }


        private void EditResource_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }


        //load selected doctor data
        private void LoadResData()
        {
            string query_exist = "SELECT *  FROM tbl_resources WHERE resource_id ='" + selectedResourceId + "'";
            bool chkRow = con.DoesRowExist(query_exist);

            if (chkRow)
            {
                ItemName.Text = con.GetColumnValue(query_exist, "item_name").ToString();
                Type.Text = con.GetColumnValue(query_exist, "resource_type").ToString();
                Description.Text = con.GetColumnValue(query_exist, "description").ToString();
                DateTime purchaseDate = (DateTime)con.GetColumnValue(query_exist, "purchase_date");
                PDate.Value = purchaseDate;
                DateTime warrantyDate = (DateTime)con.GetColumnValue(query_exist, "warranty_end");
                WDate.Value = warrantyDate;
                Vendor.Text = con.GetColumnValue(query_exist, "vendor").ToString();
                Cost.Text = con.GetColumnValue(query_exist, "cost").ToString();
                IvtNo.Text = con.GetColumnValue(query_exist, "inventory_no").ToString();
                DepartmentS.Text = con.GetColumnValue(query_exist, "department").ToString();
            }
            else
            {
                MessageBox.Show("Resource not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Submit_Click(object sender, EventArgs e)
        {
            string resourse_type = Type.SelectedItem as string;
            string item_name = ItemName.Text;
            string description = Description.Text;
            string purchase_date = PDate.Text;
            string vendor = Vendor.Text;
            string warranty_date = WDate.Text;
            string costText = Cost.Text;
            int cost = int.TryParse(costText, out int parsedCost) ? parsedCost : 0;
            string department = DepartmentS.SelectedItem as string;
            string Ivtno = IvtNo.Text;

            // Validate non-empty variables
            bool allInputsValid = !string.IsNullOrEmpty(resourse_type) &&
                      !string.IsNullOrEmpty(item_name) &&
                      !string.IsNullOrEmpty(description) &&
                      !string.IsNullOrEmpty(purchase_date) &&
                      !string.IsNullOrEmpty(vendor) &&
                      !string.IsNullOrEmpty(warranty_date) &&
                      !string.IsNullOrEmpty(costText) &&
                      cost >= 0 && // Make sure cost is a non-negative value
                      !string.IsNullOrEmpty(department) &&
                      !string.IsNullOrEmpty(Ivtno);

            if (!allInputsValid)
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string query_exist = "SELECT *  FROM tbl_resources WHERE inventory_no='" + Ivtno + "' AND  resource_id !='" + selectedResourceId + "'";
                bool chkRow = con.DoesRowExist(query_exist);

                if (chkRow)
                {
                    MessageBox.Show("Inventory Number is Already Regsitered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Resource resource = new Resource
                {
                    ID = selectedResourceId,
                    Resource_type = resourse_type,
                    Item_name = item_name,
                    Description = description,
                    Purchase_date = purchase_date,
                    Vendor = vendor,
                    Cost = cost,
                    Department = department,
                    Inventory_no = Ivtno,
                    Warranty_end = warranty_date
                };

                // Assuming you have a DbAccess.DbConnection instance named 'con' available
                resource.UpdateResource(con);

                MessageBox.Show("Resource Data Updating is Successful...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

    }
}
