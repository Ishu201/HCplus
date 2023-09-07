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
    public partial class AddMedicine : Form
    {
        public DbAccess.DbConnection con;


        public AddMedicine()
        {
            InitializeComponent();
            con = new DbAccess.DbConnection();
            this.FormClosing += AddMedicine_FormClosing;
        }


        private void AddMedicine_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }



        private void Price_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Price.Text, out _))
            {
                PriceErr.Show();
            }
            else
            {
                PriceErr.Hide();
            }
        }


        private void Qty_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Qty.Text, out _))
            {
                QtyErr.Show();
            }
            else
            {
                QtyErr.Hide();
            }
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            MedName.Text = string.Empty;
            Price.Text = string.Empty;
            Qty.Text = string.Empty;
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
            else
            {
                bool medChk = con.RecordExists("tbl_medicines", "med_name", med_name);

                if (medChk)
                {
                    MessageBox.Show("This Medicine is already Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Medicine med = new Medicine
                {
                    Name = med_name,
                    Price = price,
                    Qty = qty
                };

                // Assuming you have a DbAccess.DbConnection instance named 'con' available
                med.InsertMedicine(con);

                MessageBox.Show("Registration is Successful...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

    }
}
