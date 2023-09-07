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
    public partial class ResourcesModule : Form
    {
        public DbAccess.DbConnection con;
        private UserProfile userProfile; // User session

        public ResourcesModule(UserProfile userProfile)
        {
            InitializeComponent();
            LoadResData();
            // Assign the passed UserProfile to the local userProfile
            this.userProfile = userProfile;

            con = new DbAccess.DbConnection();
            int rowCount = con.GetRowCount("tbl_resources", "No");
            DocCount.Text = rowCount.ToString();
            int rowCountF = con.GetRowCount("tbl_resources", "`status` = 'Working'");
            FilterResult.Text = rowCountF.ToString();
        }

        private void LoadResData()
        {
            List<Resource> resource = Resource.GetAllResourcesFromDatabase(con);
            Datalist.DataSource = resource;

            foreach (DataGridViewColumn column in Datalist.Columns)
            {
                if (column.Name == "ID")
                {
                    column.Width = 50; // Set the desired width
                }
                if (column.Name == "Inventory_no")
                {
                    column.Width = 200; // Set the desired width
                }
            }
        }



        private void Doctorlist_CellClick(object sender, EventArgs e)
        {
            if (Datalist.SelectedRows.Count > 0)
            {
                Resource selectedResource = (Resource)Datalist.SelectedRows[0].DataBoundItem;
                int selectedResourceId = selectedResource.ID;

                // Open the other form and pass the selectedDoctorId
                ResourceView view = new ResourceView(selectedResourceId);
                view.Show();
            }
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Open the add doctor form
            AddResource view = new AddResource();
            view.Show();
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
            LoadResData();
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