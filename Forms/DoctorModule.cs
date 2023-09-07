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
    public partial class DoctorModule : Form
    {
        public DbAccess.DbConnection con;
        private UserProfile userProfile; // User session

        public DoctorModule(UserProfile userProfile)
        {
            InitializeComponent();
            LoadDoctorData();
            LoadHospitals();
            // Assign the passed UserProfile to the local userProfile
            this.userProfile = userProfile;

            con = new DbAccess.DbConnection();
            int rowCount = con.GetRowCount("tbl_doctor", "No");
            DocCount.Text = rowCount.ToString();
        }

        private void LoadDoctorData()
        {
            Doctorlist.Show();
            List<Doctor> doctors = Doctor.GetAllDoctorsFromDatabase(con, "No");
            Doctorlist.DataSource = doctors;

            foreach (DataGridViewColumn column in Doctorlist.Columns)
            {
                if (column.Name == "ID")
                {
                    column.Width = 50; // Set the desired width
                }
            }
        }

        private void LoadHospitals()
        {
            List<string> Hospitals = Doctor.GetHospitalsFromDoctorData(con);
            FilterLocation.DataSource = Hospitals;
            FilterLocation.SelectedIndex = -1;
            FilterLocation.Text = "Location";
        }


        private void SearchFilter_Click(object sender, EventArgs e)
        {
            string speciality = FilterSpecial.SelectedItem as string;
            string availability = FilterAvailability.SelectedItem as string;
            string location = FilterLocation.SelectedItem as string;

            if (!string.IsNullOrEmpty(speciality) && !string.IsNullOrEmpty(availability) && !string.IsNullOrEmpty(location))
            {
                string specialityVal = FilterSpecial.SelectedItem?.ToString();
                string availabilityVal = FilterAvailability.SelectedItem?.ToString();
                string locationVal = FilterLocation.SelectedValue as string;
                string ConditionString = " ";
                string FilterResultst = " ";

                if (specialityVal != "All")
                {
                    ConditionString += "AND `specialty`='" + specialityVal + "' ";
                    FilterResultst += " Speciality - " + specialityVal;
                }

                if (availabilityVal != "All")
                {
                    ConditionString += "AND `availability`='" + availabilityVal + "' ";
                    FilterResultst += " Availability - " + availabilityVal;
                }

                if (locationVal != "All")
                {
                    ConditionString += "AND `hospital`='" + locationVal + "' ";
                    FilterResultst += " Location - " + locationVal;
                }

                List<Doctor> doctors = Doctor.GetAllDoctorsFromDatabase(con, ConditionString);

                string countString = "`status` = 'active' " + ConditionString;
                int rowCount = con.GetRowCount("tbl_doctor", countString);
                DocCount.Text = rowCount.ToString();
                FilterResult.Text = FilterResultst;
                if (rowCount > 0)
                {
                    Doctorlist.DataSource = doctors;
                }
                else
                {
                    Doctorlist.Hide();
                }


            }
            else
            {
                MessageBox.Show("Select All Filters for Your Search..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void Doctorlist_CellClick(object sender, EventArgs e)
        {
            if (Doctorlist.SelectedRows.Count > 0)
            {
                Doctor selectedDoctor = (Doctor)Doctorlist.SelectedRows[0].DataBoundItem;
                int selectedDoctorId = selectedDoctor.ID;

                // Open the other form and pass the selectedDoctorId
                DoctorView doctorView = new DoctorView(selectedDoctorId);
                doctorView.Show();
            }
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Open the add doctor form
            AddDoctor doctorView = new AddDoctor();
            doctorView.Show();
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
            LoadDoctorData();
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