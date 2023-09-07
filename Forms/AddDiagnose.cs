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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class AddDiagnose : Form
    {
        public DbAccess.DbConnection con;
        private int selectedClinicId;
        private UserProfile userProfile; // User session
        string checkedPatient = "no";

        public AddDiagnose(int clinicId, UserProfile userProfile)
        {
            InitializeComponent();
            selectedClinicId = clinicId;
            LoadPatientData(selectedClinicId);
            con = new DbAccess.DbConnection();
            this.userProfile = userProfile;

            this.FormClosing += MainForm_FormClosing;

            string chkQry = "SELECT * FROM tbl_schedule WHERE schedule_id ='" + selectedClinicId + "' AND status='Started'";
            bool chkDoc = con.DoesRowExist(chkQry);

            if (chkDoc)
            {
                AddBtn.Hide();
                CompleteClinic.Show();
            }
        }

        //Loading patient details
        private void LoadPatientData(int selectedCId)
        {
            string condition = "AND tbl_appointments.schedule_id ='" + selectedCId + "'";
            List<Appointment> appointments = Appointment.GetAllAppointmentsFromDatabase(con, condition);
            DataList.DataSource = appointments;

            foreach (DataGridViewColumn column in DataList.Columns)
            {
                if ((column.Name == "Clinic") || (column.Name == "Doctor") || (column.Name == "RoomName") || (column.Name == "CDate"))
                {
                    column.Visible = false;
                }
                if (column.Name == "APPOINTID")
                {
                    column.Visible = false;
                }
                if (column.Name == "AppointmentNO")
                {
                    column.HeaderText = "No";
                    column.Width = 50;
                }
                if (column.Name == "Status")
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

            }

        }

        //loading prescribed medicine details
        public void LoadPrescribeMedData(int appointmentID)
        {
            string condition = appointmentID.ToString();
            List<Prescription> prescription = Prescription.GetAllPrescriptionsFromDatabase(con, condition);

            string chkQrystarted = "SELECT * FROM tbl_prescriptions WHERE appointment_id ='" + appointmentID + "' ";
            bool chkstat = con.DoesRowExist(chkQrystarted);

            if (chkstat)
            {
                PrescriptionTable.DataSource = prescription;
            }
            else
            {
                PrescriptionTable.DataSource = null;
            }


            foreach (DataGridViewColumn column in PrescriptionTable.Columns)
            {
                if (column.Name == "medicineID")
                {
                    column.HeaderText = "Medicine";
                    column.Width = 100;
                }
                if (column.Name == "directions")
                {
                    column.HeaderText = "Directions";
                }
                if (column.Name == "NoOfItems")
                {
                    column.HeaderText = "Qty";
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.Width = 100;
                }
                if (column.Name == "finishDate")
                {
                    column.HeaderText = "Finish Date";
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    column.Width = 150;
                }

            }

        }

        //loading lab reports scheduled
        public void LoadLabRepData(int appointmentID)
        {
            string condition = appointmentID.ToString();
            List<Reports> labreports = Reports.GetAllReportsFromDatabase(con, condition);

            string chkQrystarted = "SELECT * FROM tbl_lab_reports WHERE appointment_id ='" + appointmentID + "' ";
            bool chkstat = con.DoesRowExist(chkQrystarted);

            if (chkstat)
            {
                LabReportTbl.DataSource = labreports;
            }
            else
            {
                LabReportTbl.DataSource = null;
            }


        }

        //operation data relaod
        public void LoadOpDetails(int patientID)
        {
            string diagnoseQry = "SELECT CONCAT(tbl_rooms.room_id, ' - ', tbl_rooms.location, ' ', tbl_rooms.room_type) AS `room_name`, tbl_operation_schedule.* FROM tbl_operation_schedule INNER JOIN tbl_rooms ON tbl_rooms.room_id = tbl_operation_schedule.op_room_id WHERE tbl_operation_schedule.patient_id ='" + patientID + "'";
            OpDate.Text = DateTime.TryParse(con.GetColumnValue(diagnoseQry, "date")?.ToString(), out var date) ? date.ToString("yyyy-MM-dd") : "";
            OpRoom.Text = con.GetColumnValue(diagnoseQry, "room_name")?.ToString() ?? "";
            OpDetails.Text = con.GetColumnValue(diagnoseQry, "op_details")?.ToString() ?? "";
        }



        private void DataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string chkQrystarted = "SELECT * FROM tbl_schedule WHERE schedule_id ='" + selectedClinicId + "' AND status='Started'";
            bool chkstat = con.DoesRowExist(chkQrystarted);

            if (!chkstat)
            {
                MessageBox.Show($"Start the Clinic First..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Open the new form
            if (DataList.SelectedRows.Count > 0)
            {
                checkedPatient = "yes";
                int appointId = (int)DataList.SelectedRows[0].Cells["APPOINTID"].Value;
                Appointment selectedAppointment = (Appointment)DataList.SelectedRows[0].DataBoundItem;
                string selectedPatientName = selectedAppointment.Patient.ToString();


                string patientQry = "SELECT * FROM tbl_appointments WHERE appointment_id ='" + appointId + "'";
                int selectedPatientId = (int)con.GetColumnValue(patientQry, "patient_id");

                string scheduleID = con.GetColumnValue(patientQry, "schedule_id").ToString();
                string dateQry = "SELECT * FROM tbl_schedule WHERE schedule_id ='" + scheduleID + "'";
                string cdate = con.GetColumnValue(dateQry, "date").ToString();

                bool chkDoc = con.DoesRowExist(patientQry);

                if (chkDoc)
                {
                    PatientIdLbl.Text = selectedPatientId.ToString();
                    PatientNameLbl.Text = selectedPatientName;
                    AppID.Text = appointId.ToString();

                    string diagnoseQry = "SELECT * FROM tbl_diagnoses WHERE appointment_id ='" + appointId + "'";
                    Diagnosetxt.Text = con.GetColumnValue(diagnoseQry, "diagnose")?.ToString() ?? "";

                    LoadPrescribeMedData(appointId);
                    LoadLabRepData(appointId);
                    LoadOpDetails(selectedPatientId);
                }

                Diagnose diagnose = new Diagnose
                {
                    AppDate = cdate,
                    AppID = appointId,
                    DiagnoseDesc = "",
                };

                string chkDiagnose = "SELECT * FROM tbl_diagnoses WHERE appointment_id='" + appointId + "'";
                bool chkDiagnoseRow = con.DoesRowExist(chkDiagnose);
                if (!chkDiagnoseRow)
                {
                    diagnose.InsertDiagnose(con);
                    LoadPatientData(selectedClinicId);
                    MessageBox.Show("Diagnose Started for " + selectedPatientName + ".. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            string Status = "Started";

            Clinic clinic = new Clinic();
            clinic.ID = selectedClinicId;
            clinic.Status = Status;


            clinic.changeStatusOfSchedule(con); // Call the update function

            MessageBox.Show("Clinic Startted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DiagnoseModule view = new DiagnoseModule(userProfile);
            view.Show();
        }



        private void Diagnosetxt_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (checkedPatient == "no")
            {
                MessageBox.Show($"Select a Patient First..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                string desc = Diagnosetxt.Text;

                Diagnose diagnose = new Diagnose();
                diagnose.AppID = int.Parse(AppID.Text);
                diagnose.DiagnoseDesc = desc;


                diagnose.UpdateDiagnose(con); // Call the update function
                MessageBox.Show("Diagnose is Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                e.Handled = true;
            }
        }



        private void AddPrescriptions_Click(object sender, EventArgs e)
        {
            if (checkedPatient == "no")
            {
                MessageBox.Show($"Select a Patient First..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int appointmentid = int.Parse(AppID.Text);
            AddPrescription view = new AddPrescription(appointmentid);
            view.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (checkedPatient == "no")
            {
                MessageBox.Show($"Select a Patient First..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int appointmentid = int.Parse(AppID.Text);
            LoadPrescribeMedData(appointmentid);
        }

        private void AddLabReports_Click(object sender, EventArgs e)
        {
            if (checkedPatient == "no")
            {
                MessageBox.Show($"Select a Patient First..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int appointmentid = int.Parse(AppID.Text);
            AddLabReports view = new AddLabReports(appointmentid);
            view.Show();
        }

        private void OpSchedule_Click(object sender, EventArgs e)
        {
            if (checkedPatient == "no")
            {
                MessageBox.Show($"Select a Patient First..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int patientid = int.Parse(PatientIdLbl.Text);

            string roomquery_exist = "SELECT * FROM tbl_operation_schedule WHERE patient_id='" + patientid + "' AND status='pending' ";
            bool chkRoomRow = con.DoesRowExist(roomquery_exist);

            if (chkRoomRow)
            {
                MessageBox.Show($"An Operation is Already Scheduled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddOpSchedule view = new AddOpSchedule(patientid);
            view.Show();
        }

        private void refreshRep_Click(object sender, EventArgs e)
        {
            if (checkedPatient == "no")
            {
                MessageBox.Show($"Select a Patient First..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int appointmentid = int.Parse(AppID.Text);
            LoadLabRepData(appointmentid);
        }

        private void RefreshOp_Click(object sender, EventArgs e)
        {
            if (checkedPatient == "no")
            {
                MessageBox.Show($"Select a Patient First..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int patientid = int.Parse(PatientIdLbl.Text);
            LoadOpDetails(patientid);
        }

        private void CompleteClinic_Click(object sender, EventArgs e)
        {
            string Status = "Completed";

            Clinic clinic = new Clinic();
            clinic.ID = selectedClinicId;
            clinic.Status = Status;


            clinic.changeStatusOfSchedule(con); // Call the update function

            MessageBox.Show("Clinic Has Ended Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }

}