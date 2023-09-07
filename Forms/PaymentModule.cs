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
using System.Drawing.Printing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HCplus.Forms
{
    public partial class PaymentModule : Form
    {
        public DbAccess.DbConnection con;
        private UserProfile userProfile; // User session
        private double genBillTotal = 0.00;

        public PaymentModule(UserProfile userProfile)
        {
            InitializeComponent();
            this.userProfile = userProfile;
            string userRole = userProfile.UserType;
            UserType.Text = userRole;

            con = new DbAccess.DbConnection();
            LoadNames();
        }

        private Dictionary<string, string> patientNamesAndIds;

        private void LoadNames()
        {
            // Initialize the class-level dictionary
            patientNamesAndIds = Patient.GetAllPatientNamesandIDFromDatabase(con);

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(patientNamesAndIds.Keys.ToArray());

            SearchPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SearchPatient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            SearchPatient.AutoCompleteCustomSource = autoCompleteCollection;

            // Attach the event handler for the KeyUp event
            SearchPatient.KeyUp += SearchPatient_KeyUp;
        }

        private void SearchPatient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string patientName = SearchPatient.Text;
                string patientID = patientNamesAndIds.TryGetValue(patientName, out string id) ? id : null;

                string chkQry = "SELECT * FROM `tbl_appointments` WHERE patient_id='" + patientID + "' AND payment='pending'";
                bool chkDoc = con.DoesRowExist(chkQry);

                if (!chkDoc)
                {
                    MessageBox.Show("No Pending Clinical Payment for " + patientName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    payTypeTxt.Text = "Surgical & Operation Payment";
                }
                else
                {
                    payTypeTxt.Text = "Clinic & Treatment Payment";
                }

                string AppointmentID = con.GetColumnValue(chkQry, "appointment_id")?.ToString() ?? "0";

                //clinical charge
                string diagnoseQry = "SELECT * FROM `tbl_charges` WHERE charge_name='Clinical'";
                ClinicCharge.Text = con.GetColumnValue(diagnoseQry, "cost").ToString() + ".00";

                //medicine charge
                string medQry = "SELECT a.appointment_id, SUM(m.price * p.no_of_items) AS total_cost FROM tbl_appointments AS a JOIN tbl_prescriptions AS p ON a.appointment_id = p.appointment_id JOIN tbl_medicines AS m ON p.medicine_id = m.medicine_id WHERE a.payment = 'pending' AND a.patient_id = '" + patientID + "' AND p.med_availability='yes' GROUP BY a.appointment_id";
                string medcharge1 = con.GetColumnValue(medQry, "total_cost")?.ToString() ?? "0.00";
                double result = Convert.ToDouble(medcharge1);
                MedicineCharge.Text = result.ToString("0.00");

                //reports section load
                string reportQry = "SELECT GROUP_CONCAT(report_name SEPARATOR ', ') AS concatenated_reports FROM `tbl_lab_reports` WHERE appointment_id = '" + AppointmentID + "'";
                repTxt.Text = con.GetColumnValue(reportQry, "concatenated_reports")?.ToString() ?? "";

                //total amount
                double clinical = double.TryParse(ClinicCharge.Text, out double clinicalResult) ? clinicalResult : 0.0;
                double medical = double.TryParse(MedicineCharge.Text, out double medicalResult) ? medicalResult : 0.0;
                genBillTotal = genBillTotal + clinical + medical;
                TotalCharge.Text = genBillTotal.ToString();

            }
        }


        private void ReportCharge_ValueChanged(object sender, EventArgs e)
        {
            double newval = double.TryParse(ReportCharge.Text, out double clinicalResult) ? clinicalResult : 0.0;
            genBillTotal = genBillTotal + newval;
            TotalCharge.Text = genBillTotal.ToString();
        }

        private void OperationCharge_ValueChanged(object sender, EventArgs e)
        {
            double newval = double.TryParse(OperationCharge.Text, out double clinicalResult) ? clinicalResult : 0.0;
            genBillTotal = genBillTotal + newval;
            TotalCharge.Text = genBillTotal.ToString();
        }


        private void Generate_Click(object sender, EventArgs e)
        {
            string patientName = SearchPatient.Text;
            string patientID = patientNamesAndIds.TryGetValue(patientName, out string id) ? id : null;
            string paymenttype = payTypeTxt.Text;
            string date = Date.Text;
            int clinical = (int)double.Parse(ClinicCharge.Text);
            int medical = (int)double.Parse(MedicineCharge.Text);
            int reports = int.Parse(ReportCharge.Text);
            int op = int.Parse(OperationCharge.Text);
            int total = (int)double.Parse(TotalCharge.Text);
            string method = Type.SelectedItem as string;

            if (patientID != null && method != null)
            {
                Payment pay = new Payment
                {
                    Patient = patientID,
                    PaymentType = paymenttype,
                    Date = date,
                    ClinicalCharge = clinical,
                    MedCharge = medical,
                    RepCharge = reports,
                    OpCharge = op,
                    Total = total,
                    Method = method
                };

                int PaymentID = pay.InsertPayment(con);
                MessageBox.Show("Payment Accepted Successfully..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadInvoice(PaymentID);
                genBillTotal = 0.00;
            }
            else
            {
                MessageBox.Show("Select Patient and Payment Method....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }



        private void LoadInvoice(int payID)
        {
            
            string mainQry = "SELECT * FROM `tbl_payment` WHERE payment_id='" + payID + "'";

            //Patient Details
            string patient = con.GetColumnValue(mainQry, "patient_id").ToString();
            string patientQry = "SELECT * FROM `tbl_patient` WHERE patient_id='" + patient + "'";
            patientName.Text = con.GetColumnValue(patientQry, "fullname").ToString();
            patientContact.Text = con.GetColumnValue(patientQry, "contact").ToString();

            //Bill details
            BillNo.Text = con.GetColumnValue(mainQry, "payment_id").ToString();
            BillDate.Text = ((DateTime)con.GetColumnValue(mainQry, "date")).ToString("yyyy-mm-dd");
            ClinicChargeBill.Text = con.GetColumnValue(mainQry, "clinical_charge").ToString() + ".00";
            MedChargeBill.Text = con.GetColumnValue(mainQry, "medicine_charge").ToString() + ".00";
            ReportChargeBill.Text = con.GetColumnValue(mainQry, "report_charge").ToString() + ".00";
            OpChargeBill.Text = con.GetColumnValue(mainQry, "operation_charge").ToString() + ".00";
            TotalChargeBill.Text = con.GetColumnValue(mainQry, "total_amount").ToString() + ".00";
        }


        private void HandlePrinting(System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (Bitmap panelBitmap = new Bitmap(InvoiceBill.Width, InvoiceBill.Height))
            {
                // Draw the PrintPanel onto the bitmap.
                InvoiceBill.DrawToBitmap(panelBitmap, new Rectangle(0, 0, InvoiceBill.Width, InvoiceBill.Height));

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

                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPageHandler);
            pd.Print();
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // Get the panel to print
            Panel panelToPrint = InvoiceBill;

            // Create a Bitmap to capture the panel contents
            Bitmap bitmap = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bitmap, new Rectangle(0, 0, panelToPrint.Width, panelToPrint.Height));

            e.Graphics.DrawImage(bitmap, e.PageBounds);
            e.HasMorePages = false;
            bitmap.Dispose();
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