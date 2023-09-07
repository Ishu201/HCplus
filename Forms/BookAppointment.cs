using HCplus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Http;

namespace HCplus.Forms
{
    public partial class BookAppointment : Form
    {
        public DbAccess.DbConnection con;
        private int selectedPatientId;
        private int ScheduleIDSelected;
        private int AppointmentNumber;

        public BookAppointment(int patientId)
        {
            InitializeComponent();
            selectedPatientId = patientId;
            con = new DbAccess.DbConnection();
            LoadClinicData();
            Doctor_Load();
            Clinic_Load();
            this.FormClosing += BookAppointment_FormClosing;

            string Qry = "SELECT * FROM tbl_patient WHERE patient_id ='" + selectedPatientId + "'";
            object NameValue = con.GetColumnValue(Qry, "fullname");
            string Names = NameValue?.ToString() ?? "Unknown Name";
            PatientName.Text = Names;
        }


        private void LoadClinicData()
        {
            try
            {
                List<Clinic> clinics = Clinic.GetAllClinicsFromDatabase(con, "AND status!='Completed'");
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
                        column.HeaderText = "Date";
                        column.DisplayIndex = 1;
                        column.Width = 80;
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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


        private void Doctor_Load()
        {
            string query = "SELECT `doctor_id`, CONCAT(`titles`, ' ', `fullname`,' - ', `specialty`) AS `title_and_fullname` FROM `tbl_doctor` WHERE status='active'";
            DataTable dataLists = con.GetComboList(query);

            // Add an empty row to the DataTable to be used as a placeholder
            DataRow emptyRow = dataLists.NewRow();
            emptyRow["doctor_id"] = "0"; // Use a value that doesn't exist in your actual data (assuming 0 is not a valid ID)
            emptyRow["title_and_fullname"] = "All Doctors";
            dataLists.Rows.InsertAt(emptyRow, 0);

            Doctor.DataSource = dataLists;
            Doctor.DisplayMember = "title_and_fullname";
            Doctor.ValueMember = "doctor_id";

        }


        private void Clinic_Load()
        {
            string query = "SELECT `clinic_id`, `clinic_name` FROM `tbl_clinics`";
            DataTable dataLists = con.GetComboList(query);

            // Add an empty row to the DataTable to be used as a placeholder
            DataRow emptyRow = dataLists.NewRow();
            emptyRow["clinic_id"] = "0";
            emptyRow["clinic_name"] = "All Clinics"; // Text to display in the placeholder
            dataLists.Rows.InsertAt(emptyRow, 0);

            ClinicType.DataSource = dataLists;
            ClinicType.DisplayMember = "clinic_name";
            ClinicType.ValueMember = "clinic_id";
        }



        private void BookAppointment_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Cancel the form closing
            this.Hide(); // Hide the form instead of closing it
        }


        private void PrintBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Call the common method to handle printing
            HandlePrinting(e);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            ConfirmBooking.Enabled = false;
            Appointment app = new Appointment
            {
                Clinic = ScheduleIDSelected.ToString(),
                Patient = selectedPatientId.ToString(),
                AppointmentNO = AppointmentNumber
            };

            app.InsertAppointment(con);

            // Call the common method to handle printing
            HandlePrinting(null); // Pass null or any necessary data if needed for printing
            MessageBox.Show("Appointment Booked Successfully... Booking Ticket has mailed...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void HandlePrinting(System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Bitmap panelBitmap = new Bitmap(PrintPanel.Width, PrintPanel.Height))
            {
                // Draw the PrintPanel onto the bitmap.
                PrintPanel.DrawToBitmap(panelBitmap, new Rectangle(0, 0, PrintPanel.Width, PrintPanel.Height));

                // Draw the bitmap on the print page if e is not null
                if (e != null)
                {
                    e.Graphics.DrawImage(panelBitmap, e.PageBounds.Left, e.PageBounds.Top);
                }

                // Create a MemoryStream to hold the image data
                using (MemoryStream imageStream = new MemoryStream())
                {
                    // Save the bitmap to the MemoryStream
                    panelBitmap.Save(imageStream, System.Drawing.Imaging.ImageFormat.Png);

                    // Call SendEmailWithAttachmentAsync to send the email with the image data as an attachment
                    SendEmailWithAttachmentAsync(imageStream.ToArray());
                }
            }
        }

        private async Task SendEmailWithAttachmentAsync(byte[] imageData)
        {

            string Qry = "SELECT * FROM tbl_patient WHERE patient_id ='" + selectedPatientId + "'";
            object NameValue = con.GetColumnValue(Qry, "email");
            string NameMail = NameValue?.ToString() ?? "ishunawodya201@gmail.com";

            // Email configuration
            string fromAddress = "HCPlust@support.com";
            string toAddress = NameMail;
            string subject = "Bill Invoice";
            string body = "Please find the attached Appointment Receipt.";

            // SMTP server settings (for Gmail)
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUsername = "ishutest201@gmail.com";
            string smtpPassword = "fccfsuedwfcogoqf";

            // Initialize and configure the SmtpClient
            SmtpClient smtpClient = new SmtpClient(smtpServer)
            {
                Port = smtpPort,
                Credentials = new NetworkCredential(smtpUsername, smtpPassword),
                EnableSsl = true,
            };

            // Create a new MailMessage
            MailMessage mailMessage = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            };

            try
            {
                // Attach the image data as an attachment
                mailMessage.Attachments.Add(new Attachment(new MemoryStream(imageData), "printed_bill.png"));

                // Send the email asynchronously
                await smtpClient.SendMailAsync(mailMessage);
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                MessageBox.Show($"An error occurred while sending the email: {ex.Message}");
            }
            finally
            {
                // Clean up resources
                smtpClient.Dispose();
                mailMessage.Dispose();
            }


        }




        private void ClinicType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clinicType = int.TryParse(ClinicType.SelectedValue?.ToString(), out int parsedValue) ? parsedValue : 0;
            string clinicName = ClinicType.SelectedItem?.ToString();
            string condition = " AND clinic_id='" + clinicType + "'";

            if (clinicType > 0)
            {
                try
                {
                    string clinic_exist = "SELECT * FROM tbl_schedule WHERE clinic_id='" + clinicType + "' AND status!='removed' AND status!='Completed' ";
                    bool chkDocRow = con.DoesRowExist(clinic_exist);

                    if (!chkDocRow)
                    {
                        MessageBox.Show("No Clinics Available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DataList.Hide();
                        return;
                    }
                    else
                    {
                        DataList.Show();
                        List<Clinic> clinics = Clinic.GetAllClinicsFromDatabase(con, condition);
                        DataList.DataSource = clinics;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DataList.Show();
                LoadClinicData();
                clearBill();
            }
        }

        private void Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int doctorType = int.TryParse(Doctor.SelectedValue?.ToString(), out int parsedValue) ? parsedValue : 0;
            string doctorName = Doctor.SelectedItem?.ToString();
            string condition = " AND doctor_id='" + doctorType + "'";

            if (doctorType > 0)
            {
                try
                {
                    string doctor_exist = "SELECT * FROM tbl_schedule WHERE doctor_id='" + doctorType + "' AND status!='removed' AND status!='Completed' ";
                    bool chkDocRow = con.DoesRowExist(doctor_exist);

                    if (!chkDocRow)
                    {
                        MessageBox.Show("No Clinics Available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DataList.Hide();
                        return;
                    }
                    else
                    {
                        DataList.Show();
                        List<Clinic> clinics = Clinic.GetAllClinicsFromDatabase(con, condition);
                        DataList.DataSource = clinics;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DataList.Show();
                LoadClinicData();
                clearBill();
            }
        }



        private void DataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataList.SelectedRows.Count > 0)
            {
                Clinic selectedClinic = (Clinic)DataList.SelectedRows[0].DataBoundItem;
                int selectedClinicId = selectedClinic.ID;
                ScheduleIDSelected = selectedClinicId;

                Clinic clinic = Clinic.GetClinicByIdFromDatabase(con, selectedClinicId);

                if (clinic == null)
                {
                    MessageBox.Show("No clinic data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ClinicName.Text = clinic.ClinicName.ToString();
                DocName.Text = clinic.Doctor.ToString();
                Cdate.Text = clinic.CDate.ToString();
                Ctime.Text = clinic.Start.ToString();
                Room.Text = clinic.RoomID.ToString();

                int total = clinic.TotalP;
                int booked = clinic.BookedP;

                if (booked < total)
                {
                    PatientNo.StateCommon.ShortText.Color1 = Color.FromArgb(0, 0, 64); // Set the color
                    PatientNo.Text = (booked + 1).ToString("D2");
                    AppointmentNumber = booked + 1;
                    ConfirmBooking.Enabled = true;
                }
                else
                {
                    PatientNo.StateCommon.ShortText.Color1 = Color.DarkRed; // Set the color
                    PatientNo.Text = "All Booked";
                    AppointmentNumber = 0;
                    ConfirmBooking.Enabled = false;
                }


            }
        }


        private void clearBill()
        {
            ClinicName.Text = "Clinic Name";
            DocName.Text = "Doctor Name";
            Cdate.Text = "Date";
            Ctime.Text = "Time";
            Room.Text = "Location";
            PatientNo.Text = "00";
        }







    }
}
