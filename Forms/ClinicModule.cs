using HCplus.Helper;
using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class ClinicModule : Form
    {
        public DbAccess.DbConnection con;
        private UserProfile userProfile; // User session

        public ClinicModule(UserProfile userProfile)
        {
            InitializeComponent();
            LoadClinicData();
            // Assign the passed UserProfile to the local userProfile
            this.userProfile = userProfile;

            con = new DbAccess.DbConnection();
        }

        private void LoadClinicData()
        {
            DataList.Show();
            try
            {
                List<Clinic> clinics = Clinic.GetAllClinicsFromDatabase(con, "No");
                if (clinics == null)
                {
                    MessageBox.Show("No clinics data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Assuming `clinics` is the data source for DataList DataGridView
                DataList.DataSource = clinics;

                // Reset column properties
                DataList.Columns["ID"].Width = 30;
                DataList.Columns["CDate"].HeaderText = "Date";
                DataList.Columns["CDate"].Width = 80;
                DataList.Columns["CDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataList.Columns["ClinicName"].HeaderText = "Clinic Name";
                DataList.Columns["ClinicName"].Width = 120;
                DataList.Columns["Doctor"].Width = 120;
                DataList.Columns["RoomID"].HeaderText = "Room";
                DataList.Columns["Start"].Width = 90;
                DataList.Columns["Start"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataList.Columns["End"].Width = 90;
                DataList.Columns["End"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataList.Columns["BookedP"].HeaderText = "Bookings";
                DataList.Columns["BookedP"].Width = 80;
                DataList.Columns["BookedP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataList.Columns["Status"].Width = 90;

                // Auto-resize columns to fit content
                DataList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SearchFilter_Click(object sender, EventArgs e)
        {
            string date = DatePick.Text;

            if (!string.IsNullOrEmpty(date))
            {
                string ConditionString = "AND `date` = '" + date + "' ";

                List<Clinic> clinics = Clinic.GetAllClinicsFromDatabase(con, ConditionString);

                string countString = "`status` != 'removed' " + ConditionString;
                int rowCount = con.GetRowCount("tbl_schedule", countString);

                if (rowCount > 0)
                {
                    DataList.Show();
                    DataList.DataSource = clinics;
                }
                else
                {
                    DataList.Hide();
                    MessageBox.Show("No clinics data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }


        private void Cliniclist_CellClick(object sender, EventArgs e)
        {
            if (DataList.SelectedRows.Count > 0)
            {
                Clinic selectedClinic = (Clinic)DataList.SelectedRows[0].DataBoundItem;
                int selectedClinicId = selectedClinic.ID;

                // Open the other form and pass the selectedClinicId
                EditClinic view = new EditClinic(selectedClinicId);
                view.Show();
            }
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Open the add clinic form
            AddClinic clinicView = new AddClinic();
            clinicView.Show();
        }






        //navigation functions
        private void DoctorBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            DoctorModule view = new DoctorModule(userProfile);
            view.Show();

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
            LoadClinicData();
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