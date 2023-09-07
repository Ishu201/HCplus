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

namespace HCplus.Forms
{
    public partial class Home : Form
    {
        private UserProfile userProfile; // User session

        public Home(UserProfile userProfile)
        {
            InitializeComponent();
            // Assign the passed UserProfile to the local userProfile
            this.userProfile = userProfile;

            // Access and store the userType directly in the constructor
            UserType.Text = userProfile.UserType;

        }

        private void DoctorBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            DoctorModule view = new DoctorModule(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }

        private void PatientBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            PatientModule view = new PatientModule(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }

        private void DiagnoseBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            DiagnoseModule view = new DiagnoseModule(userProfile);
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

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            PaymentModule view = new PaymentModule(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }

        private void RoomsBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            RoomModule view = new RoomModule(userProfile);
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

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            // Open the new form
            ReportAppointment view = new ReportAppointment(userProfile);
            view.Show();

            // Close the current form
            this.Hide();
        }
    }

}