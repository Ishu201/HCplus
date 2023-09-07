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
    public partial class RoomModule : Form
    {
        public DbAccess.DbConnection con;
        private UserProfile userProfile; // User session

        public RoomModule(UserProfile userProfile)
        {
            InitializeComponent();
            LoadRoomData();
            // Assign the passed UserProfile to the local userProfile
            this.userProfile = userProfile;

            con = new DbAccess.DbConnection();
            int rowCountF = con.GetRowCount("tbl_rooms", "No");
            FilterResult.Text = rowCountF.ToString();
        }

        private void LoadRoomData()
        {
            List<Room> room = Room.GetAllRoomsFromDatabase(con);
            Datalist.DataSource = room;

            foreach (DataGridViewColumn column in Datalist.Columns)
            {
                if (column.Name == "ID")
                {
                    column.Width = 50; // Set the desired width
                }
                if (column.Name == "Type")
                {
                    column.HeaderText = "Room Type"; // Set the custom header text
                }
                if (column.Name == "Stat")
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align cell values to the center
                    column.HeaderText = "Current Status";
                }
                if (column.Name == "Doctor")
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align cell values to the center
                }
                if (column.Name == "Availability")
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Align cell values to the center
                }
            }
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