using HCplus.Helper;
using HCplus.Models;
using Krypton.Toolkit;
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
    public partial class DiagnoseModule : Form
    {
        public DbAccess.DbConnection con;
        private UserProfile userProfile; // User session

        public DiagnoseModule(UserProfile userProfile)
        {
            InitializeComponent();
            LoadClinicData();
            this.userProfile = userProfile;
            string userRole = userProfile.UserType;
            UserType.Text = userRole;
            Check_userAccess(userRole);

            con = new DbAccess.DbConnection();
        }

        private void LoadClinicData()
        {
            try
            {
                string today = DateTime.Now.ToString("yyyy-MM-dd");
                List<Clinic> clinics = Clinic.GetAllClinicsFromDatabase(con, " AND `date`='" + today + "'");
                if (clinics == null)
                {
                    MessageBox.Show("No clinics data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Assuming `clinics` is the data source for DataList DataGridView
                DataList.DataSource = clinics;

                foreach (DataGridViewColumn column in DataList.Columns)
                {
                    if (column.Name == "ID")
                    {
                        column.DisplayIndex = 0;
                        column.Width = 30;
                    }

                    else if (column.Name == "CDate")
                    {
                        column.Visible = false;
                    }

                    else if (column.Name == "ClinicName")
                    {
                        column.HeaderText = "Clinic Name";
                        column.DisplayIndex = 2;
                        column.Width = 120;
                    }

                    else if (column.Name == "Doctor")
                    {
                        column.DisplayIndex = 3;
                        column.Width = 120;
                    }

                    else if (column.Name == "RoomID")
                    {
                        column.HeaderText = "Room";
                        column.DisplayIndex = 4;
                    }

                    else if (column.Name == "Start")
                    {
                        column.DisplayIndex = 5;
                        column.Width = 90;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    else if (column.Name == "End")
                    {
                        column.DisplayIndex = 6;
                        column.Width = 90;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }


                    else if (column.Name == "BookedP")
                    {
                        column.HeaderText = "Bookings";
                        column.DisplayIndex = 7;
                        column.Width = 80;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    else if (column.Name == "Status")
                    {
                        column.DisplayIndex = 8;
                        column.Width = 90;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Check_userAccess(string userRole)
        {
            if (userRole == "Reception")
            {
                UserType.Text = "Reception";
                HomeBtn.Hide();
                homeLbl.Hide();
                DiagnoseBtn.Hide();
                AppointmentLbl.Hide();
                PaymentBtn.Hide();
                PaymentLbl.Hide();
                PatientListBtn.Hide();
                PatientListLbl.Hide();

                PatientBtn.Location = new Point(26, 125);
                PatientLbl.Location = new Point(17, 156);

            }

            else if (userRole == "Nurse")
            {
                UserType.Text = "Nurse";
                HomeBtn.Hide();
                homeLbl.Hide();
                PatientBtn.Hide();
                PatientLbl.Hide();
                PaymentBtn.Hide();
                PaymentLbl.Hide();
                PatientListBtn.Hide();
                PatientListLbl.Hide();

                DiagnoseBtn.Location = new Point(26, 125);
                AppointmentLbl.Location = new Point(13, 156);
            }
        }


        private void DataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string userRole = userProfile.UserType;
            
            if (DataList.SelectedRows.Count > 0)
            {
                Clinic selectedClinic = (Clinic)DataList.SelectedRows[0].DataBoundItem;
                int selectedClinicId = selectedClinic.ID;
                object columnValue = DataList.SelectedRows[0].Cells[8].Value;
                string columnValueStr = columnValue.ToString();
                if (columnValueStr == "Completed")
                {
                    MessageBox.Show("The clinic data processing is completed..");
                    return;
                }

                // Open the other form and pass the selectedClinicId
                AddDiagnose view = new AddDiagnose(selectedClinicId, userProfile);
                view.Show();
                this.Hide();
            }
            
        }





        //navigation functions
        private void PatientBtn_Click(object sender, EventArgs e)
        {
            PatientModule view = new PatientModule(userProfile);
            view.Show();
            this.Hide();
        }

        private void DiagnoseBtn_Click(object sender, EventArgs e)
        {
            DiagnoseModule view = new DiagnoseModule(userProfile);
            view.Show();
            this.Hide();
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            PaymentModule view = new PaymentModule(userProfile);
            view.Show();
            this.Hide();
        }

        private void PatientListBtn_Click(object sender, EventArgs e)
        {
            PatientList view = new PatientList(userProfile);
            view.Show();
            this.Hide();
        }


        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home view = new Home(userProfile);
            view.Show();
            this.Hide();
        }




    }

}