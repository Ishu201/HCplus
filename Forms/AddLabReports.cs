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
    public partial class AddLabReports : Form
    {
        public DbAccess.DbConnection con;
        private int selectedAppointmentId;

        public AddLabReports(int AppointmentId)
        {
            InitializeComponent();
            selectedAppointmentId = AppointmentId;
            con = new DbAccess.DbConnection();
            this.FormClosing += AddLabReports_FormClosing;
        }


        private void AddLabReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }



        private void Submit_Click(object sender, EventArgs e)
        {
            string reportname = ReportName.SelectedItem as string;

            // Validate non-empty variables
            if (string.IsNullOrEmpty(reportname))
            {
                MessageBox.Show("Please select the report Type First.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string chkQrystarted = "SELECT * FROM tbl_lab_reports WHERE report_name ='" + reportname + "' AND appointment_id ='" + selectedAppointmentId + "' ";
                bool chkstat = con.DoesRowExist(chkQrystarted);

                if (chkstat)
                {
                    MessageBox.Show($"This Report is Already Added to the Diagnose Record..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Reports rep = new Reports
                {
                    AppID = selectedAppointmentId,
                    Report = reportname,
                };

                // Assuming you have a DbAccess.DbConnection instance named 'con' available
                rep.InsertReports(con);

                MessageBox.Show("Report is Added to the Diagnose Record...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }



    }
}
