using Krypton.Toolkit;

namespace HCplus.Forms
{
    partial class PaymentModule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentModule));
            sidebar = new KryptonPanel();
            PatientListLbl = new Label();
            PatientListBtn = new PictureBox();
            homeLbl = new Label();
            HomeBtn = new PictureBox();
            AppointmentLbl = new Label();
            PatientLbl = new Label();
            PaymentLbl = new Label();
            PaymentBtn = new PictureBox();
            DiagnoseBtn = new PictureBox();
            PatientBtn = new PictureBox();
            header = new KryptonPanel();
            UserType = new Label();
            lblTitle = new KryptonLabel();
            HomeLogo = new PictureBox();
            SearchPatient = new KryptonTextBox();
            label1 = new Label();
            kryptonPanel1 = new KryptonPanel();
            payTypeTxt = new KryptonLabel();
            repTxt = new KryptonWrapLabel();
            TotalCharge = new Label();
            MedicineCharge = new Label();
            ClinicCharge = new Label();
            Generate = new KryptonButton();
            kryptonLabel8 = new KryptonLabel();
            kryptonBorderEdge2 = new KryptonBorderEdge();
            Type = new KryptonComboBox();
            kryptonLabel9 = new KryptonLabel();
            OperationCharge = new KryptonNumericUpDown();
            kryptonLabel7 = new KryptonLabel();
            ReportCharge = new KryptonNumericUpDown();
            kryptonLabel6 = new KryptonLabel();
            kryptonLabel5 = new KryptonLabel();
            kryptonLabel2 = new KryptonLabel();
            Date = new KryptonDateTimePicker();
            kryptonLabel4 = new KryptonLabel();
            kryptonLabel1 = new KryptonLabel();
            kryptonLabel3 = new KryptonLabel();
            InvoiceBill = new KryptonPanel();
            kryptonBorderEdge7 = new KryptonBorderEdge();
            kryptonBorderEdge6 = new KryptonBorderEdge();
            TotalChargeBill = new Label();
            OpChargeBill = new Label();
            ReportChargeBill = new Label();
            MedChargeBill = new Label();
            ClinicChargeBill = new Label();
            kryptonLabel17 = new KryptonLabel();
            OpChargeBillLbl = new KryptonLabel();
            kryptonLabel15 = new KryptonLabel();
            kryptonLabel14 = new KryptonLabel();
            kryptonLabel13 = new KryptonLabel();
            kryptonLabel12 = new KryptonLabel();
            BillDate = new Label();
            BillNo = new Label();
            label9 = new Label();
            label8 = new Label();
            kryptonLabel11 = new KryptonLabel();
            kryptonBorderEdge5 = new KryptonBorderEdge();
            patientContact = new Label();
            patientName = new Label();
            kryptonBorderEdge4 = new KryptonBorderEdge();
            label6 = new Label();
            kryptonBorderEdge3 = new KryptonBorderEdge();
            kryptonLabel10 = new KryptonLabel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            kryptonBorderEdge1 = new KryptonBorderEdge();
            CancelBtn = new KryptonButton();
            PrintBill = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)sidebar).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientListBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiagnoseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)header).BeginInit();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomeLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Type).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceBill).BeginInit();
            InvoiceBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebar.Controls.Add(PatientListLbl);
            sidebar.Controls.Add(PatientListBtn);
            sidebar.Controls.Add(homeLbl);
            sidebar.Controls.Add(HomeBtn);
            sidebar.Controls.Add(AppointmentLbl);
            sidebar.Controls.Add(PatientLbl);
            sidebar.Controls.Add(PaymentLbl);
            sidebar.Controls.Add(PaymentBtn);
            sidebar.Controls.Add(DiagnoseBtn);
            sidebar.Controls.Add(PatientBtn);
            sidebar.Location = new Point(-1, -2);
            sidebar.Name = "sidebar";
            sidebar.PanelBackStyle = PaletteBackStyle.ContextMenuHeading;
            sidebar.Size = new Size(82, 713);
            sidebar.StateCommon.Color1 = Color.DodgerBlue;
            sidebar.TabIndex = 0;
            // 
            // PatientListLbl
            // 
            PatientListLbl.AutoSize = true;
            PatientListLbl.BackColor = Color.Transparent;
            PatientListLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            PatientListLbl.ForeColor = SystemColors.Control;
            PatientListLbl.Location = new Point(15, 313);
            PatientListLbl.Name = "PatientListLbl";
            PatientListLbl.Size = new Size(53, 13);
            PatientListLbl.TabIndex = 23;
            PatientListLbl.Text = "Patients";
            // 
            // PatientListBtn
            // 
            PatientListBtn.BackColor = Color.Transparent;
            PatientListBtn.Cursor = Cursors.Hand;
            PatientListBtn.Image = Properties.Resources.icons8_users_50;
            PatientListBtn.Location = new Point(28, 286);
            PatientListBtn.Name = "PatientListBtn";
            PatientListBtn.Size = new Size(28, 28);
            PatientListBtn.SizeMode = PictureBoxSizeMode.Zoom;
            PatientListBtn.TabIndex = 22;
            PatientListBtn.TabStop = false;
            PatientListBtn.Click += PatientListBtn_Click;
            // 
            // homeLbl
            // 
            homeLbl.AutoSize = true;
            homeLbl.BackColor = Color.Transparent;
            homeLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            homeLbl.ForeColor = SystemColors.Control;
            homeLbl.Location = new Point(7, 156);
            homeLbl.Name = "homeLbl";
            homeLbl.Size = new Size(71, 13);
            homeLbl.TabIndex = 21;
            homeLbl.Text = "Home Page";
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.Transparent;
            HomeBtn.Cursor = Cursors.Hand;
            HomeBtn.Image = Properties.Resources.icons8_home_64;
            HomeBtn.Location = new Point(26, 125);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(30, 30);
            HomeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            HomeBtn.TabIndex = 20;
            HomeBtn.TabStop = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // AppointmentLbl
            // 
            AppointmentLbl.AutoSize = true;
            AppointmentLbl.BackColor = Color.Transparent;
            AppointmentLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            AppointmentLbl.ForeColor = SystemColors.Control;
            AppointmentLbl.Location = new Point(11, 375);
            AppointmentLbl.Name = "AppointmentLbl";
            AppointmentLbl.Size = new Size(60, 13);
            AppointmentLbl.TabIndex = 19;
            AppointmentLbl.Text = "Diagnose";
            // 
            // PatientLbl
            // 
            PatientLbl.AutoSize = true;
            PatientLbl.BackColor = Color.Transparent;
            PatientLbl.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Bold, GraphicsUnit.Point);
            PatientLbl.ForeColor = SystemColors.Control;
            PatientLbl.Location = new Point(5, 259);
            PatientLbl.Name = "PatientLbl";
            PatientLbl.Size = new Size(75, 12);
            PatientLbl.TabIndex = 18;
            PatientLbl.Text = "Appointments";
            // 
            // PaymentLbl
            // 
            PaymentLbl.AutoSize = true;
            PaymentLbl.BackColor = Color.Transparent;
            PaymentLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentLbl.ForeColor = SystemColors.Control;
            PaymentLbl.Location = new Point(10, 438);
            PaymentLbl.Name = "PaymentLbl";
            PaymentLbl.Size = new Size(61, 13);
            PaymentLbl.TabIndex = 17;
            PaymentLbl.Text = "Payments";
            // 
            // PaymentBtn
            // 
            PaymentBtn.BackColor = Color.Transparent;
            PaymentBtn.Cursor = Cursors.Hand;
            PaymentBtn.Image = Properties.Resources.icons8_money_50;
            PaymentBtn.Location = new Point(28, 410);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Size = new Size(28, 28);
            PaymentBtn.SizeMode = PictureBoxSizeMode.Zoom;
            PaymentBtn.TabIndex = 10;
            PaymentBtn.TabStop = false;
            PaymentBtn.Click += PaymentBtn_Click;
            // 
            // DiagnoseBtn
            // 
            DiagnoseBtn.BackColor = Color.Transparent;
            DiagnoseBtn.Cursor = Cursors.Hand;
            DiagnoseBtn.Image = Properties.Resources.icons8_moleskine_48;
            DiagnoseBtn.Location = new Point(28, 347);
            DiagnoseBtn.Name = "DiagnoseBtn";
            DiagnoseBtn.Size = new Size(28, 28);
            DiagnoseBtn.SizeMode = PictureBoxSizeMode.Zoom;
            DiagnoseBtn.TabIndex = 9;
            DiagnoseBtn.TabStop = false;
            DiagnoseBtn.Click += DiagnoseBtn_Click;
            // 
            // PatientBtn
            // 
            PatientBtn.BackColor = Color.Transparent;
            PatientBtn.Cursor = Cursors.Hand;
            PatientBtn.Image = Properties.Resources.icons8_plus_64;
            PatientBtn.Location = new Point(28, 228);
            PatientBtn.Name = "PatientBtn";
            PatientBtn.Size = new Size(28, 28);
            PatientBtn.SizeMode = PictureBoxSizeMode.Zoom;
            PatientBtn.TabIndex = 8;
            PatientBtn.TabStop = false;
            PatientBtn.Click += PatientBtn_Click;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.Controls.Add(UserType);
            header.Controls.Add(lblTitle);
            header.Location = new Point(-1, -2);
            header.Name = "header";
            header.Size = new Size(1342, 44);
            header.StateCommon.Color1 = Color.FromArgb(242, 242, 242);
            header.StateCommon.Color2 = Color.FromArgb(242, 242, 242);
            header.StateCommon.ColorAngle = 25F;
            header.TabIndex = 1;
            // 
            // UserType
            // 
            UserType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserType.BackColor = Color.Transparent;
            UserType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserType.Location = new Point(1406, 11);
            UserType.Name = "UserType";
            UserType.Size = new Size(138, 18);
            UserType.TabIndex = 1;
            UserType.Text = "Admin";
            UserType.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(124, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(238, 21);
            lblTitle.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "Patient's Payment Management";
            // 
            // HomeLogo
            // 
            HomeLogo.Cursor = Cursors.Hand;
            HomeLogo.Image = Properties.Resources.logo;
            HomeLogo.Location = new Point(-1, -2);
            HomeLogo.Name = "HomeLogo";
            HomeLogo.Size = new Size(118, 98);
            HomeLogo.SizeMode = PictureBoxSizeMode.Zoom;
            HomeLogo.TabIndex = 6;
            HomeLogo.TabStop = false;
            // 
            // SearchPatient
            // 
            SearchPatient.Location = new Point(149, 111);
            SearchPatient.Name = "SearchPatient";
            SearchPatient.Size = new Size(326, 30);
            SearchPatient.StateCommon.Border.Color1 = Color.SlateGray;
            SearchPatient.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            SearchPatient.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchPatient.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchPatient.StateCommon.Content.Padding = new Padding(7);
            SearchPatient.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(152, 89);
            label1.Name = "label1";
            label1.Size = new Size(98, 13);
            label1.TabIndex = 22;
            label1.Text = "Select a Patient";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(payTypeTxt);
            kryptonPanel1.Controls.Add(repTxt);
            kryptonPanel1.Controls.Add(TotalCharge);
            kryptonPanel1.Controls.Add(MedicineCharge);
            kryptonPanel1.Controls.Add(ClinicCharge);
            kryptonPanel1.Controls.Add(Generate);
            kryptonPanel1.Controls.Add(kryptonLabel8);
            kryptonPanel1.Controls.Add(kryptonBorderEdge2);
            kryptonPanel1.Controls.Add(Type);
            kryptonPanel1.Controls.Add(kryptonLabel9);
            kryptonPanel1.Controls.Add(OperationCharge);
            kryptonPanel1.Controls.Add(kryptonLabel7);
            kryptonPanel1.Controls.Add(ReportCharge);
            kryptonPanel1.Controls.Add(kryptonLabel6);
            kryptonPanel1.Controls.Add(kryptonLabel5);
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(Date);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Location = new Point(123, 158);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(567, 476);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(242, 242, 242);
            kryptonPanel1.TabIndex = 23;
            // 
            // payTypeTxt
            // 
            payTypeTxt.Location = new Point(29, 111);
            payTypeTxt.Name = "payTypeTxt";
            payTypeTxt.Size = new Size(6, 2);
            payTypeTxt.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            payTypeTxt.TabIndex = 71;
            payTypeTxt.Values.Text = "";
            // 
            // repTxt
            // 
            repTxt.AutoSize = false;
            repTxt.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            repTxt.ForeColor = Color.FromArgb(30, 57, 91);
            repTxt.LabelStyle = LabelStyle.NormalControl;
            repTxt.Location = new Point(31, 250);
            repTxt.Name = "repTxt";
            repTxt.Size = new Size(260, 41);
            repTxt.StateCommon.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // TotalCharge
            // 
            TotalCharge.BackColor = Color.Transparent;
            TotalCharge.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalCharge.ForeColor = Color.FromArgb(64, 64, 64);
            TotalCharge.Location = new Point(176, 320);
            TotalCharge.Name = "TotalCharge";
            TotalCharge.Size = new Size(95, 19);
            TotalCharge.TabIndex = 69;
            TotalCharge.Text = "0000.00";
            TotalCharge.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MedicineCharge
            // 
            MedicineCharge.BackColor = Color.Transparent;
            MedicineCharge.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MedicineCharge.ForeColor = Color.FromArgb(64, 64, 64);
            MedicineCharge.Location = new Point(160, 189);
            MedicineCharge.Name = "MedicineCharge";
            MedicineCharge.Size = new Size(95, 16);
            MedicineCharge.TabIndex = 68;
            MedicineCharge.Text = "0000.00";
            MedicineCharge.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ClinicCharge
            // 
            ClinicCharge.BackColor = Color.Transparent;
            ClinicCharge.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ClinicCharge.ForeColor = Color.FromArgb(64, 64, 64);
            ClinicCharge.Location = new Point(160, 162);
            ClinicCharge.Name = "ClinicCharge";
            ClinicCharge.Size = new Size(95, 16);
            ClinicCharge.TabIndex = 67;
            ClinicCharge.Text = "0000.00";
            ClinicCharge.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Generate
            // 
            Generate.CornerRoundingRadius = 25F;
            Generate.Cursor = Cursors.Hand;
            Generate.Location = new Point(211, 418);
            Generate.Name = "Generate";
            Generate.OverrideDefault.Back.Color1 = Color.FromArgb(0, 179, 89);
            Generate.OverrideDefault.Back.Color2 = Color.MediumSeaGreen;
            Generate.Size = new Size(118, 37);
            Generate.StateCommon.Back.Color1 = Color.FromArgb(0, 204, 102);
            Generate.StateCommon.Back.Color2 = Color.FromArgb(0, 179, 89);
            Generate.StateCommon.Back.ColorAngle = 25F;
            Generate.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            Generate.StateCommon.Border.Rounding = 25F;
            Generate.StateCommon.Content.ShortText.Color1 = Color.White;
            Generate.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Generate.StateTracking.Back.Color1 = Color.FromArgb(0, 179, 89);
            Generate.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            Generate.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            Generate.StateTracking.Border.Rounding = 25F;
            Generate.TabIndex = 65;
            Generate.Values.Text = "Generate Bill";
            Generate.Click += Generate_Click;
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(29, 365);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(118, 19);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel8.TabIndex = 64;
            kryptonLabel8.Values.Text = "Payment Method";
            // 
            // kryptonBorderEdge2
            // 
            kryptonBorderEdge2.Location = new Point(26, 50);
            kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            kryptonBorderEdge2.Size = new Size(511, 1);
            kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // Type
            // 
            Type.CornerRoundingRadius = 10F;
            Type.DropDownWidth = 259;
            Type.IntegralHeight = false;
            Type.Items.AddRange(new object[] { "Cash Payment", "Card Payment", "Gift Card Payment" });
            Type.Location = new Point(185, 360);
            Type.Name = "Type";
            Type.Size = new Size(242, 27);
            Type.StateCommon.ComboBox.Border.Color1 = Color.Gray;
            Type.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            Type.StateCommon.ComboBox.Border.Rounding = 10F;
            Type.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            Type.TabIndex = 39;
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(32, 321);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(102, 21);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel9.TabIndex = 61;
            kryptonLabel9.Values.Text = "Total Charge";
            // 
            // OperationCharge
            // 
            OperationCharge.Location = new Point(432, 224);
            OperationCharge.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            OperationCharge.Name = "OperationCharge";
            OperationCharge.Size = new Size(105, 23);
            OperationCharge.StateCommon.Border.Color1 = Color.RoyalBlue;
            OperationCharge.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            OperationCharge.StateCommon.Border.Rounding = 0F;
            OperationCharge.StateCommon.Border.Width = 0;
            OperationCharge.TabIndex = 60;
            OperationCharge.ValueChanged += OperationCharge_ValueChanged;
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(289, 224);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(124, 19);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel7.TabIndex = 59;
            kryptonLabel7.Values.Text = "Operation Charge";
            // 
            // ReportCharge
            // 
            ReportCharge.Location = new Point(164, 220);
            ReportCharge.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            ReportCharge.Name = "ReportCharge";
            ReportCharge.Size = new Size(105, 23);
            ReportCharge.StateCommon.Border.Color1 = Color.RoyalBlue;
            ReportCharge.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            ReportCharge.StateCommon.Border.Rounding = 0F;
            ReportCharge.StateCommon.Border.Width = 0;
            ReportCharge.TabIndex = 58;
            ReportCharge.ValueChanged += ReportCharge_ValueChanged;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(30, 224);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(104, 19);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 57;
            kryptonLabel6.Values.Text = "Report Charge";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(30, 190);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(119, 19);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 54;
            kryptonLabel5.Values.Text = "Medicine Charge";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(30, 161);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(108, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 53;
            kryptonLabel2.Values.Text = "Clinical Charge";
            // 
            // Date
            // 
            Date.CornerRoundingRadius = 5F;
            Date.Format = DateTimePickerFormat.Short;
            Date.Location = new Point(303, 111);
            Date.MinDate = new DateTime(2023, 9, 5, 0, 0, 0, 0);
            Date.Name = "Date";
            Date.Size = new Size(134, 23);
            Date.StateCommon.Border.Color1 = Color.RoyalBlue;
            Date.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            Date.StateCommon.Border.Rounding = 5F;
            Date.StateCommon.Border.Width = 0;
            Date.StateCommon.Content.Padding = new Padding(5);
            Date.TabIndex = 52;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(303, 82);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(101, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 51;
            kryptonLabel4.Values.Text = "Payment Date";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(185, 18);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(169, 21);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Generate Invoice / Bill";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(43, 82);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(102, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 29;
            kryptonLabel3.Values.Text = "Payment Type";
            // 
            // InvoiceBill
            // 
            InvoiceBill.Controls.Add(kryptonBorderEdge7);
            InvoiceBill.Controls.Add(kryptonBorderEdge6);
            InvoiceBill.Controls.Add(TotalChargeBill);
            InvoiceBill.Controls.Add(OpChargeBill);
            InvoiceBill.Controls.Add(ReportChargeBill);
            InvoiceBill.Controls.Add(MedChargeBill);
            InvoiceBill.Controls.Add(ClinicChargeBill);
            InvoiceBill.Controls.Add(kryptonLabel17);
            InvoiceBill.Controls.Add(OpChargeBillLbl);
            InvoiceBill.Controls.Add(kryptonLabel15);
            InvoiceBill.Controls.Add(kryptonLabel14);
            InvoiceBill.Controls.Add(kryptonLabel13);
            InvoiceBill.Controls.Add(kryptonLabel12);
            InvoiceBill.Controls.Add(BillDate);
            InvoiceBill.Controls.Add(BillNo);
            InvoiceBill.Controls.Add(label9);
            InvoiceBill.Controls.Add(label8);
            InvoiceBill.Controls.Add(kryptonLabel11);
            InvoiceBill.Controls.Add(kryptonBorderEdge5);
            InvoiceBill.Controls.Add(patientContact);
            InvoiceBill.Controls.Add(patientName);
            InvoiceBill.Controls.Add(kryptonBorderEdge4);
            InvoiceBill.Controls.Add(label6);
            InvoiceBill.Controls.Add(kryptonBorderEdge3);
            InvoiceBill.Controls.Add(kryptonLabel10);
            InvoiceBill.Controls.Add(pictureBox1);
            InvoiceBill.Controls.Add(label5);
            InvoiceBill.Controls.Add(label4);
            InvoiceBill.Controls.Add(label3);
            InvoiceBill.Controls.Add(label2);
            InvoiceBill.Controls.Add(kryptonBorderEdge1);
            InvoiceBill.Location = new Point(727, 154);
            InvoiceBill.Name = "InvoiceBill";
            InvoiceBill.Size = new Size(554, 527);
            InvoiceBill.StateCommon.Color1 = Color.FromArgb(250, 250, 250);
            InvoiceBill.TabIndex = 24;
            // 
            // kryptonBorderEdge7
            // 
            kryptonBorderEdge7.Location = new Point(31, 507);
            kryptonBorderEdge7.Name = "kryptonBorderEdge7";
            kryptonBorderEdge7.Size = new Size(500, 1);
            kryptonBorderEdge7.Text = "kryptonBorderEdge7";
            // 
            // kryptonBorderEdge6
            // 
            kryptonBorderEdge6.Location = new Point(388, 441);
            kryptonBorderEdge6.Name = "kryptonBorderEdge6";
            kryptonBorderEdge6.Size = new Size(120, 1);
            kryptonBorderEdge6.Text = "kryptonBorderEdge6";
            // 
            // TotalChargeBill
            // 
            TotalChargeBill.BackColor = Color.Transparent;
            TotalChargeBill.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            TotalChargeBill.ForeColor = Color.FromArgb(64, 64, 64);
            TotalChargeBill.Location = new Point(364, 453);
            TotalChargeBill.Name = "TotalChargeBill";
            TotalChargeBill.Size = new Size(134, 16);
            TotalChargeBill.TabIndex = 45;
            TotalChargeBill.Text = "0000.00";
            TotalChargeBill.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OpChargeBill
            // 
            OpChargeBill.BackColor = Color.Transparent;
            OpChargeBill.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            OpChargeBill.ForeColor = Color.FromArgb(64, 64, 64);
            OpChargeBill.Location = new Point(364, 400);
            OpChargeBill.Name = "OpChargeBill";
            OpChargeBill.Size = new Size(134, 16);
            OpChargeBill.TabIndex = 44;
            OpChargeBill.Text = "0000.00";
            OpChargeBill.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ReportChargeBill
            // 
            ReportChargeBill.BackColor = Color.Transparent;
            ReportChargeBill.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ReportChargeBill.ForeColor = Color.FromArgb(64, 64, 64);
            ReportChargeBill.Location = new Point(364, 375);
            ReportChargeBill.Name = "ReportChargeBill";
            ReportChargeBill.Size = new Size(134, 16);
            ReportChargeBill.TabIndex = 43;
            ReportChargeBill.Text = "0000.00";
            ReportChargeBill.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MedChargeBill
            // 
            MedChargeBill.BackColor = Color.Transparent;
            MedChargeBill.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            MedChargeBill.ForeColor = Color.FromArgb(64, 64, 64);
            MedChargeBill.Location = new Point(364, 350);
            MedChargeBill.Name = "MedChargeBill";
            MedChargeBill.Size = new Size(134, 16);
            MedChargeBill.TabIndex = 42;
            MedChargeBill.Text = "0000.00";
            MedChargeBill.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ClinicChargeBill
            // 
            ClinicChargeBill.BackColor = Color.Transparent;
            ClinicChargeBill.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ClinicChargeBill.ForeColor = Color.FromArgb(64, 64, 64);
            ClinicChargeBill.Location = new Point(364, 325);
            ClinicChargeBill.Name = "ClinicChargeBill";
            ClinicChargeBill.Size = new Size(134, 16);
            ClinicChargeBill.TabIndex = 41;
            ClinicChargeBill.Text = "0000.00";
            ClinicChargeBill.TextAlign = ContentAlignment.MiddleRight;
            // 
            // kryptonLabel17
            // 
            kryptonLabel17.Location = new Point(251, 453);
            kryptonLabel17.Name = "kryptonLabel17";
            kryptonLabel17.Size = new Size(96, 19);
            kryptonLabel17.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel17.TabIndex = 40;
            kryptonLabel17.Values.Text = "Total Amount";
            // 
            // OpChargeBillLbl
            // 
            OpChargeBillLbl.Location = new Point(54, 397);
            OpChargeBillLbl.Name = "OpChargeBillLbl";
            OpChargeBillLbl.Size = new Size(120, 19);
            OpChargeBillLbl.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OpChargeBillLbl.TabIndex = 39;
            OpChargeBillLbl.Values.Text = "Operation Charge";
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Location = new Point(54, 372);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(101, 19);
            kryptonLabel15.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel15.TabIndex = 38;
            kryptonLabel15.Values.Text = "Report Charge";
            // 
            // kryptonLabel14
            // 
            kryptonLabel14.Location = new Point(54, 347);
            kryptonLabel14.Name = "kryptonLabel14";
            kryptonLabel14.Size = new Size(115, 19);
            kryptonLabel14.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel14.TabIndex = 37;
            kryptonLabel14.Values.Text = "Medicine Charge";
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Location = new Point(54, 322);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(101, 19);
            kryptonLabel13.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel13.TabIndex = 36;
            kryptonLabel13.Values.Text = "Cinical Charge";
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Location = new Point(407, 294);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new Size(91, 19);
            kryptonLabel12.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel12.TabIndex = 35;
            kryptonLabel12.Values.Text = "Amount (Rs)";
            // 
            // BillDate
            // 
            BillDate.BackColor = Color.Transparent;
            BillDate.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BillDate.ForeColor = Color.FromArgb(64, 64, 64);
            BillDate.Location = new Point(432, 196);
            BillDate.Name = "BillDate";
            BillDate.Size = new Size(94, 16);
            BillDate.TabIndex = 34;
            BillDate.Text = "0000-00-00";
            BillDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BillNo
            // 
            BillNo.BackColor = Color.Transparent;
            BillNo.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            BillNo.ForeColor = Color.FromArgb(64, 64, 64);
            BillNo.Location = new Point(305, 196);
            BillNo.Name = "BillNo";
            BillNo.Size = new Size(94, 16);
            BillNo.TabIndex = 33;
            BillNo.Text = "00000";
            BillNo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(432, 171);
            label9.Name = "label9";
            label9.Size = new Size(66, 16);
            label9.TabIndex = 32;
            label9.Text = "Bill Date";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(305, 171);
            label8.Name = "label8";
            label8.Size = new Size(53, 16);
            label8.TabIndex = 31;
            label8.Text = "Bill No";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(54, 294);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(114, 19);
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel11.TabIndex = 22;
            kryptonLabel11.Values.Text = "Item Description";
            // 
            // kryptonBorderEdge5
            // 
            kryptonBorderEdge5.Location = new Point(21, 277);
            kryptonBorderEdge5.Name = "kryptonBorderEdge5";
            kryptonBorderEdge5.Size = new Size(500, 1);
            kryptonBorderEdge5.Text = "kryptonBorderEdge5";
            // 
            // patientContact
            // 
            patientContact.AutoSize = true;
            patientContact.BackColor = Color.Transparent;
            patientContact.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            patientContact.ForeColor = Color.FromArgb(64, 64, 64);
            patientContact.Location = new Point(39, 199);
            patientContact.Name = "patientContact";
            patientContact.Size = new Size(83, 15);
            patientContact.TabIndex = 14;
            patientContact.Text = "000 00 00000";
            patientContact.TextAlign = ContentAlignment.TopRight;
            // 
            // patientName
            // 
            patientName.AutoSize = true;
            patientName.BackColor = Color.Transparent;
            patientName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            patientName.ForeColor = Color.FromArgb(64, 64, 64);
            patientName.Location = new Point(39, 179);
            patientName.Name = "patientName";
            patientName.Size = new Size(82, 15);
            patientName.TabIndex = 13;
            patientName.Text = "Patient Name";
            patientName.TextAlign = ContentAlignment.TopRight;
            // 
            // kryptonBorderEdge4
            // 
            kryptonBorderEdge4.AutoSize = false;
            kryptonBorderEdge4.Location = new Point(297, 165);
            kryptonBorderEdge4.Name = "kryptonBorderEdge4";
            kryptonBorderEdge4.Orientation = Orientation.Vertical;
            kryptonBorderEdge4.Size = new Size(2, 78);
            kryptonBorderEdge4.StateCommon.Color1 = Color.SteelBlue;
            kryptonBorderEdge4.Text = "kryptonBorderEdge4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(39, 162);
            label6.Name = "label6";
            label6.Size = new Size(150, 13);
            label6.TabIndex = 9;
            label6.Text = "PATIENT INFORMATION\r\n";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // kryptonBorderEdge3
            // 
            kryptonBorderEdge3.AutoSize = false;
            kryptonBorderEdge3.Location = new Point(31, 162);
            kryptonBorderEdge3.Name = "kryptonBorderEdge3";
            kryptonBorderEdge3.Orientation = Orientation.Vertical;
            kryptonBorderEdge3.Size = new Size(2, 78);
            kryptonBorderEdge3.StateCommon.Color1 = Color.SteelBlue;
            kryptonBorderEdge3.Text = "kryptonBorderEdge3";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(21, 127);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(181, 23);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel10.TabIndex = 7;
            kryptonLabel10.Values.Text = "Medical Billing Invoice";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(21, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(406, 78);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 4;
            label5.Text = "healthcareplus@info.lk";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(420, 60);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 3;
            label4.Text = "Gampaha, Colombo";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(428, 41);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 2;
            label3.Text = "No 01, Hospital Rd,";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(353, 22);
            label2.Name = "label2";
            label2.Size = new Size(187, 16);
            label2.TabIndex = 1;
            label2.Text = "Healthcare Plus Hospitals";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(3, 119);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(661, 1);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // CancelBtn
            // 
            CancelBtn.CornerRoundingRadius = 25F;
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.Location = new Point(1182, 86);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.OverrideDefault.Back.Color1 = Color.DarkTurquoise;
            CancelBtn.OverrideDefault.Back.Color2 = Color.SteelBlue;
            CancelBtn.Size = new Size(127, 37);
            CancelBtn.StateCommon.Back.Color1 = Color.DarkTurquoise;
            CancelBtn.StateCommon.Back.Color2 = Color.SteelBlue;
            CancelBtn.StateCommon.Back.ColorAngle = 1F;
            CancelBtn.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            CancelBtn.StateCommon.Border.Rounding = 25F;
            CancelBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            CancelBtn.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CancelBtn.StateTracking.Back.Color1 = Color.SteelBlue;
            CancelBtn.StateTracking.Back.Color2 = Color.DarkTurquoise;
            CancelBtn.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            CancelBtn.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            CancelBtn.StateTracking.Border.Rounding = 25F;
            CancelBtn.TabIndex = 52;
            CancelBtn.Values.Text = "Print Bill";
            CancelBtn.Click += CancelBtn_Click;
            // 
            // PaymentModule
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(4, 20);
            BackColor = Color.White;
            ClientSize = new Size(1339, 709);
            Controls.Add(CancelBtn);
            Controls.Add(InvoiceBill);
            Controls.Add(kryptonPanel1);
            Controls.Add(label1);
            Controls.Add(SearchPatient);
            Controls.Add(HomeLogo);
            Controls.Add(sidebar);
            Controls.Add(header);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "PaymentModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Healthcare Plus Dashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)sidebar).EndInit();
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientListBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiagnoseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)header).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomeLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Type).EndInit();
            ((System.ComponentModel.ISupportInitialize)InvoiceBill).EndInit();
            InvoiceBill.ResumeLayout(false);
            InvoiceBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonPanel sidebar;
        private KryptonPanel header;
        private PictureBox PaymentBtn;
        private PictureBox DiagnoseBtn;
        private PictureBox PatientBtn;
        private PictureBox HomeLogo;
        private KryptonLabel lblTitle;
        private Label UserType;
        private Label AppointmentLbl;
        private Label PatientLbl;
        private Label PaymentLbl;
        private Label homeLbl;
        private PictureBox HomeBtn;
        private KryptonTextBox SearchPatient;
        private Label label1;
        private Label PatientListLbl;
        private PictureBox PatientListBtn;
        private KryptonPanel kryptonPanel1;
        private KryptonPanel InvoiceBill;
        private Label label4;
        private Label label3;
        private Label label2;
        private KryptonBorderEdge kryptonBorderEdge1;
        private PictureBox pictureBox1;
        private Label label5;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel1;
        private KryptonLabel kryptonLabel2;
        private KryptonDateTimePicker Date;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel5;
        private KryptonLabel kryptonLabel6;
        private KryptonNumericUpDown OperationCharge;
        private KryptonLabel kryptonLabel7;
        private KryptonNumericUpDown ReportCharge;
        private KryptonLabel kryptonLabel9;
        private KryptonBorderEdge kryptonBorderEdge2;
        private KryptonComboBox Type;
        private KryptonLabel kryptonLabel8;
        private KryptonButton Generate;
        private Label label6;
        private KryptonBorderEdge kryptonBorderEdge3;
        private KryptonLabel kryptonLabel10;
        private Label patientContact;
        private Label patientName;
        private KryptonBorderEdge kryptonBorderEdge4;
        private KryptonLabel kryptonLabel11;
        private KryptonBorderEdge kryptonBorderEdge5;
        private Label BillNo;
        private Label label9;
        private Label label8;
        private Label BillDate;
        private KryptonLabel kryptonLabel12;
        private KryptonLabel OpChargeBillLbl;
        private KryptonLabel kryptonLabel15;
        private KryptonLabel kryptonLabel14;
        private KryptonLabel kryptonLabel13;
        private Label OpChargeBill;
        private Label ReportChargeBill;
        private Label MedChargeBill;
        private Label ClinicChargeBill;
        private KryptonLabel kryptonLabel17;
        private KryptonBorderEdge kryptonBorderEdge6;
        private Label TotalChargeBill;
        private KryptonButton CancelBtn;
        private Label TotalCharge;
        private Label MedicineCharge;
        private Label ClinicCharge;
        private KryptonWrapLabel repTxt;
        private KryptonLabel payTypeTxt;
        private KryptonBorderEdge kryptonBorderEdge7;
        private System.Drawing.Printing.PrintDocument PrintBill;
    }
}