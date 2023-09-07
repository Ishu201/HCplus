using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class ResourceView : Form
    {
        public DbAccess.DbConnection con;

        private int selectedResourceId;
        public ResourceView(int ResourceId)
        {
            InitializeComponent();
            selectedResourceId = ResourceId;
            con = new DbAccess.DbConnection();

            LoadResData();
            this.FormClosing += ResourceView_FormClosing;
        }


        private void LoadResData()
        {
            string query_exist = "SELECT * FROM tbl_resources WHERE resource_id ='" + selectedResourceId + "'";
            bool chkDoc = con.DoesRowExist(query_exist);

            if (chkDoc)
            {
                itemName.Text = con.GetColumnValue(query_exist, "item_name").ToString();
                resourceType.Text = con.GetColumnValue(query_exist, "resource_type").ToString();
                ivtNo.Text = con.GetColumnValue(query_exist, "inventory_no").ToString();
                departmentItem.Text = con.GetColumnValue(query_exist, "department").ToString();
                cost.Text = con.GetColumnValue(query_exist, "cost").ToString();
                VendorName.Text = con.GetColumnValue(query_exist, "vendor").ToString();
                description.Text = con.GetColumnValue(query_exist, "description").ToString();
                PurchaseDate.Text = Convert.ToDateTime(con.GetColumnValue(query_exist, "purchase_date")).ToString("yyyy-MM-dd");
                wDate.Text = Convert.ToDateTime(con.GetColumnValue(query_exist, "warranty_end")).ToString("yyyy-MM-dd");
                status.Text = con.GetColumnValue(query_exist, "status").ToString();

            }
            else
            {
                MessageBox.Show("Resource not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void ResourceView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditResource view = new EditResource(selectedResourceId);
            view.Show();

            this.Hide();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int resourceIDToRemove = selectedResourceId;

            DialogResult result = MessageBox.Show("Are you sure you want to remove this resource's record?", "Confirm Removal", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Resource resource = new Resource();
                resource.ID = resourceIDToRemove;

                resource.RemoveResource(con); // Call the remove function

                MessageBox.Show("Resource record removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Resource record removal canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deactive_Click(object sender, EventArgs e)
        {
            string StatusVal = status.Text;
            string Status = "";

            // Validate non-empty variables
            if (StatusVal == "Working")
            {
                Status = "Not Working";
            }
            else
            {
                Status = "Working";
            }

            Resource resource = new Resource();
            resource.ID = selectedResourceId;
            resource.RStatus = Status;


            resource.DeactiveResource(con); // Call the update function

            MessageBox.Show("Resource information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
