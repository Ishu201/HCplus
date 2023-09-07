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
    public partial class AddOpSchedule : Form
    {
        public DbAccess.DbConnection con;
        private int selectedpatientid;

        public AddOpSchedule(int patientid)
        {
            InitializeComponent();
            selectedpatientid = patientid;
            con = new DbAccess.DbConnection();
            Room_Load();
            this.FormClosing += AddOpSchedule_FormClosing;
        }


        private void AddOpSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }



        private void Submit_Click(object sender, EventArgs e)
        {
            string roomID = opRoom.SelectedValue?.ToString();
            string OpDate = opDate.Text;
            string Details = opDetails.Text;

            // Validate non-empty variables
            if (string.IsNullOrEmpty(roomID) || roomID == "0" || string.IsNullOrEmpty(Details))
            {
                MessageBox.Show("Please Fill All Feilds..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string roomquery_exist = "SELECT * FROM tbl_operation_schedule WHERE date='" + OpDate + "' AND op_room_id='" + roomID + "' ";
                bool chkRoomRow = con.DoesRowExist(roomquery_exist);

                if (chkRoomRow)
                {
                    MessageBox.Show($"This Operation Room is not Available on the selected Date..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Diagnose rec = new Diagnose
                {
                    opRoom = roomID,
                    opDate = OpDate,
                    opDetails = Details,
                    opPatients = selectedpatientid,
                };


                rec.ScheduleOperation(con);

                MessageBox.Show("Operation is scheduled to this Patient...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }


        private void Room_Load()
        {
            string query = "SELECT `room_id`, CONCAT(`room_id`, ' - ', `location`, ' ', `room_type`) AS `room_name` FROM `tbl_rooms` WHERE room_type='Operating Theater'";
            DataTable dataLists = con.GetComboList(query);

            // Add an empty row to the DataTable to be used as a placeholder
            DataRow emptyRow = dataLists.NewRow();
            emptyRow["room_id"] = "0";
            emptyRow["room_name"] = "Select an Operation Room...";
            dataLists.Rows.InsertAt(emptyRow, 0);

            opRoom.DataSource = dataLists;
            opRoom.DisplayMember = "room_name";
            opRoom.ValueMember = "room_id";
        }

        private void opDate_ValueChanged(object sender, EventArgs e)
        {
            string roomID = opRoom.SelectedValue?.ToString();
            string OpDate = opDate.Text;

            string roomquery_exist = "SELECT * FROM tbl_operation_schedule WHERE date='" + OpDate + "' AND op_room_id='" + roomID + "' ";
            bool chkRoomRow = con.DoesRowExist(roomquery_exist);

            if (chkRoomRow)
            {
                Err.Show();
            }
            else
            {
                Err.Hide();
            }
        }
    }
}
