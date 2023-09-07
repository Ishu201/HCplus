using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class AddResource : Form
    {
        public DbAccess.DbConnection con;


        public AddResource()
        {
            InitializeComponent();
            con = new DbAccess.DbConnection();
            this.FormClosing += AddResource_FormClosing;
        }


        private void AddResource_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }



        private void Clear_Click(object sender, EventArgs e)
        {
            ItemName.Text = string.Empty;
            Type.Text = string.Empty;
            Description.Text = string.Empty;
            Email.Text = string.Empty;
            PDate.Text = string.Empty;
            Vendor.Text = string.Empty;
            WDate.Text = string.Empty;
            Cost.Text = string.Empty;
            IvtNo.Text = string.Empty;
            Department.Text = string.Empty;
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
            string department = Department.SelectedItem as string;
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
                MessageBox.Show("All fields are required with Valid Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //check inventory number duplication
                string query_exist = "SELECT *  FROM tbl_resources WHERE inventory_no='" + Ivtno + "'";
                bool chkRow = con.DoesRowExist(query_exist);

                if (chkRow)
                {
                    MessageBox.Show("Inventory Number is Already Regsitered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Check if Already Regsitered
                bool medChk = con.RecordExists("tbl_resources", "item_name", item_name);

                if (medChk)
                {
                    MessageBox.Show("This Resource is already Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Resource resource = new Resource
                {
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
                resource.InsertResource(con);

                MessageBox.Show("Registration is Successful...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

    }
}
