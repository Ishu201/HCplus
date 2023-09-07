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
    public partial class AddPrescription : Form
    {
        public DbAccess.DbConnection con;
        private int selectedAppointmentId;

        public AddPrescription(int AppointmentId)
        {
            InitializeComponent();
            selectedAppointmentId = AppointmentId;
            con = new DbAccess.DbConnection();
            LoadNames();
            this.FormClosing += AddPrescription_FormClosing;
        }


        private void AddPrescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }



        private void Submit_Click(object sender, EventArgs e)
        {
            string med_name = MedName.Text;
            string directions = Directions.Text;
            string medno = MedNo.Text;
            int qty = int.TryParse(medno, out int parsedQty) ? parsedQty : 0;
            string finishdate = finishDate.Text;

            // Validate non-empty variables
            if (!string.IsNullOrEmpty(finishdate) &&
                !string.IsNullOrEmpty(med_name) &&
                !string.IsNullOrEmpty(directions) &&
                qty <= 0)
            {
                MessageBox.Show("All fields are required with Valid Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool medChk = con.RecordExists("tbl_medicines", "med_name", med_name);

                if (medChk)
                {
                    string medQry = "SELECT * FROM tbl_medicines WHERE med_name='" + med_name + "' AND status!='removed'";
                    string medID = con.GetColumnValue(medQry, "medicine_id").ToString();

                    //check whether the medicine is prescribed
                    string chkQrystarted = "SELECT * FROM tbl_prescriptions WHERE medicine_id ='" + medID + "' AND appointment_id ='" + selectedAppointmentId + "' ";
                    bool chkstat = con.DoesRowExist(chkQrystarted);

                    if (chkstat)
                    {
                        MessageBox.Show($"This Medicine is Prescribed Already..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Prescription med = new Prescription
                    {
                        AppID = selectedAppointmentId,
                        medicineID = medID,
                        directions = directions,
                        NoOfItems = qty,
                        finishDate = finishdate,
                    };

                    // Assuming you have a DbAccess.DbConnection instance named 'con' available
                    med.InsertPrescription(con);

                    MessageBox.Show("Medicine is Added to Prescription...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MedName.Text = "";
                    Directions.Text = "";
                    MedNo.Text = "";
                    finishDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                }
                else
                {
                    MessageBox.Show($"This Medicine is not Registered..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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

    }
}
