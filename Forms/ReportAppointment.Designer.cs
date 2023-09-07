using Krypton.Toolkit;

namespace HCplus.Forms
{
    partial class ReportAppointment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportAppointment));
            sidebar = new KryptonPanel();
            label1 = new Label();
            OpRoomsBtn = new PictureBox();
            PatientListLbl = new Label();
            PatientBtn = new PictureBox();
            homeLbl = new Label();
            HomeBtn = new PictureBox();
            AppointmentLbl = new Label();
            PatientLbl = new Label();
            PaymentLbl = new Label();
            IncomeBtn = new PictureBox();
            MedicationBtn = new PictureBox();
            AppointmentBtn = new PictureBox();
            header = new KryptonPanel();
            UserType = new Label();
            lblTitle = new KryptonLabel();
            HomeLogo = new PictureBox();
            kryptonLabel1 = new KryptonLabel();
            DataList = new KryptonDataGridView();
            ClinicType = new KryptonComboBox();
            kryptonLabel3 = new KryptonLabel();
            SearchPatient = new KryptonTextBox();
            kryptonLabel2 = new KryptonLabel();
            SearchFilter = new KryptonButton();
            Refresh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)sidebar).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OpRoomsBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MedicationBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AppointmentBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)header).BeginInit();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomeLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClinicType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Refresh).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebar.Controls.Add(label1);
            sidebar.Controls.Add(OpRoomsBtn);
            sidebar.Controls.Add(PatientListLbl);
            sidebar.Controls.Add(PatientBtn);
            sidebar.Controls.Add(homeLbl);
            sidebar.Controls.Add(HomeBtn);
            sidebar.Controls.Add(AppointmentLbl);
            sidebar.Controls.Add(PatientLbl);
            sidebar.Controls.Add(PaymentLbl);
            sidebar.Controls.Add(IncomeBtn);
            sidebar.Controls.Add(MedicationBtn);
            sidebar.Controls.Add(AppointmentBtn);
            sidebar.Location = new Point(-1, -2);
            sidebar.Name = "sidebar";
            sidebar.PanelBackStyle = PaletteBackStyle.ContextMenuHeading;
            sidebar.Size = new Size(82, 705);
            sidebar.StateCommon.Color1 = Color.DodgerBlue;
            sidebar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(13, 507);
            label1.Name = "label1";
            label1.Size = new Size(55, 13);
            label1.TabIndex = 25;
            label1.Text = "Theaters";
            // 
            // OpRoomsBtn
            // 
            OpRoomsBtn.BackColor = Color.Transparent;
            OpRoomsBtn.Cursor = Cursors.Hand;
            OpRoomsBtn.Image = Properties.Resources.icons8_hospital_64__2_1;
            OpRoomsBtn.Location = new Point(28, 476);
            OpRoomsBtn.Name = "OpRoomsBtn";
            OpRoomsBtn.Size = new Size(28, 28);
            OpRoomsBtn.SizeMode = PictureBoxSizeMode.Zoom;
            OpRoomsBtn.TabIndex = 24;
            OpRoomsBtn.TabStop = false;
            OpRoomsBtn.Click += OpRoomsBtn_Click;
            // 
            // PatientListLbl
            // 
            PatientListLbl.AutoSize = true;
            PatientListLbl.BackColor = Color.Transparent;
            PatientListLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            PatientListLbl.ForeColor = SystemColors.Control;
            PatientListLbl.Location = new Point(3, 319);
            PatientListLbl.Name = "PatientListLbl";
            PatientListLbl.Size = new Size(78, 13);
            PatientListLbl.TabIndex = 23;
            PatientListLbl.Text = "Patient Data";
            // 
            // PatientBtn
            // 
            PatientBtn.BackColor = Color.Transparent;
            PatientBtn.Cursor = Cursors.Hand;
            PatientBtn.Image = Properties.Resources.icons8_users_50;
            PatientBtn.Location = new Point(28, 290);
            PatientBtn.Name = "PatientBtn";
            PatientBtn.Size = new Size(28, 28);
            PatientBtn.SizeMode = PictureBoxSizeMode.Zoom;
            PatientBtn.TabIndex = 22;
            PatientBtn.TabStop = false;
            PatientBtn.Click += PatientListBtn_Click;
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
            AppointmentLbl.Location = new Point(6, 380);
            AppointmentLbl.Name = "AppointmentLbl";
            AppointmentLbl.Size = new Size(74, 13);
            AppointmentLbl.TabIndex = 19;
            AppointmentLbl.Text = "Medications";
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
            PaymentLbl.Location = new Point(13, 444);
            PaymentLbl.Name = "PaymentLbl";
            PaymentLbl.Size = new Size(61, 13);
            PaymentLbl.TabIndex = 17;
            PaymentLbl.Text = "Payments";
            // 
            // IncomeBtn
            // 
            IncomeBtn.BackColor = Color.Transparent;
            IncomeBtn.Cursor = Cursors.Hand;
            IncomeBtn.Image = Properties.Resources.icons8_money_50;
            IncomeBtn.Location = new Point(28, 413);
            IncomeBtn.Name = "IncomeBtn";
            IncomeBtn.Size = new Size(28, 28);
            IncomeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            IncomeBtn.TabIndex = 10;
            IncomeBtn.TabStop = false;
            IncomeBtn.Click += PaymentBtn_Click;
            // 
            // MedicationBtn
            // 
            MedicationBtn.BackColor = Color.Transparent;
            MedicationBtn.Cursor = Cursors.Hand;
            MedicationBtn.Image = Properties.Resources.icons8_moleskine_48;
            MedicationBtn.Location = new Point(28, 350);
            MedicationBtn.Name = "MedicationBtn";
            MedicationBtn.Size = new Size(28, 28);
            MedicationBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MedicationBtn.TabIndex = 9;
            MedicationBtn.TabStop = false;
            MedicationBtn.Click += MedicationBtn_Click;
            // 
            // AppointmentBtn
            // 
            AppointmentBtn.BackColor = Color.Transparent;
            AppointmentBtn.Cursor = Cursors.Hand;
            AppointmentBtn.Image = Properties.Resources.icons8_records_60;
            AppointmentBtn.Location = new Point(28, 228);
            AppointmentBtn.Name = "AppointmentBtn";
            AppointmentBtn.Size = new Size(28, 28);
            AppointmentBtn.SizeMode = PictureBoxSizeMode.Zoom;
            AppointmentBtn.TabIndex = 8;
            AppointmentBtn.TabStop = false;
            AppointmentBtn.Click += AppointmentBtn_Click;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.Controls.Add(UserType);
            header.Controls.Add(lblTitle);
            header.Location = new Point(-1, -2);
            header.Name = "header";
            header.Size = new Size(1367, 44);
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
            UserType.Location = new Point(1217, 11);
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
            lblTitle.Size = new Size(265, 21);
            lblTitle.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "Patient's Appointment Management\r\n";
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
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(594, 76);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(243, 24);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 19;
            kryptonLabel1.Values.Text = "Appointment List of Patients\r\n";
            // 
            // DataList
            // 
            DataList.AllowUserToOrderColumns = true;
            DataList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataList.ColumnHeadersHeight = 28;
            DataList.Cursor = Cursors.Hand;
            DataList.GridStyles.Style = DataGridViewStyle.Mixed;
            DataList.GridStyles.StyleBackground = PaletteBackStyle.GridDataCellSheet;
            DataList.GridStyles.StyleColumn = GridStyle.Sheet;
            DataList.GridStyles.StyleDataCells = GridStyle.Sheet;
            DataList.GridStyles.StyleRow = GridStyle.Sheet;
            DataList.Location = new Point(123, 226);
            DataList.MultiSelect = false;
            DataList.Name = "DataList";
            DataList.PaletteMode = PaletteMode.Office365White;
            DataList.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            DataList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            DataList.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            DataList.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataList.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            DataList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            DataList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gray;
            DataList.RowTemplate.Height = 35;
            DataList.RowTemplate.ReadOnly = true;
            DataList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataList.Size = new Size(1198, 439);
            DataList.StateCommon.Background.Color1 = Color.FromArgb(242, 242, 242);
            DataList.StateCommon.BackStyle = PaletteBackStyle.GridDataCellSheet;
            DataList.StateCommon.DataCell.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            DataList.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            DataList.StateCommon.HeaderRow.Content.Color1 = Color.White;
            DataList.StateCommon.HeaderRow.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DataList.StateSelected.DataCell.Back.Color1 = Color.Silver;
            DataList.StateSelected.DataCell.Back.Color2 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Back.Color1 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Back.Color2 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Border.Color1 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Border.Color2 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            DataList.StateSelected.HeaderColumn.Content.Color1 = Color.FromArgb(224, 224, 224);
            DataList.StateSelected.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            DataList.StateSelected.HeaderRow.Back.Color1 = Color.Silver;
            DataList.StateSelected.HeaderRow.Back.Color2 = Color.Silver;
            DataList.StateSelected.HeaderRow.Content.Color1 = Color.Silver;
            DataList.StateSelected.HeaderRow.Content.Color2 = Color.Silver;
            DataList.TabIndex = 20;
            DataList.TabStop = false;
            DataList.CellClick += DataList_CellClick;
            // 
            // ClinicType
            // 
            ClinicType.CornerRoundingRadius = 10F;
            ClinicType.DropDownWidth = 259;
            ClinicType.IntegralHeight = false;
            ClinicType.Location = new Point(419, 165);
            ClinicType.Name = "ClinicType";
            ClinicType.Size = new Size(265, 27);
            ClinicType.StateCommon.ComboBox.Border.Color1 = Color.RoyalBlue;
            ClinicType.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            ClinicType.StateCommon.ComboBox.Border.Rounding = 10F;
            ClinicType.StateCommon.ComboBox.Content.TextH = PaletteRelativeAlign.Near;
            ClinicType.TabIndex = 40;
            ClinicType.Text = " - Select the Clinic -";
            ClinicType.SelectedIndexChanged += ClinicType_SelectedIndexChanged;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(419, 134);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(85, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 39;
            kryptonLabel3.Values.Text = "Clinic Name";
            // 
            // SearchPatient
            // 
            SearchPatient.Location = new Point(134, 165);
            SearchPatient.Name = "SearchPatient";
            SearchPatient.Size = new Size(254, 26);
            SearchPatient.StateCommon.Border.Color1 = Color.RoyalBlue;
            SearchPatient.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            SearchPatient.StateCommon.Border.Rounding = 15F;
            SearchPatient.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchPatient.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchPatient.StateCommon.Content.Padding = new Padding(0);
            SearchPatient.TabIndex = 43;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(134, 134);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(94, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 44;
            kryptonLabel2.Values.Text = "Patient Name";
            // 
            // SearchFilter
            // 
            SearchFilter.CornerRoundingRadius = 25F;
            SearchFilter.Location = new Point(709, 159);
            SearchFilter.Name = "SearchFilter";
            SearchFilter.OverrideDefault.Back.Color1 = Color.DodgerBlue;
            SearchFilter.OverrideDefault.Back.Color2 = Color.RoyalBlue;
            SearchFilter.Size = new Size(104, 36);
            SearchFilter.StateCommon.Back.Color1 = Color.DodgerBlue;
            SearchFilter.StateCommon.Back.Color2 = Color.RoyalBlue;
            SearchFilter.StateCommon.Border.Color1 = Color.DodgerBlue;
            SearchFilter.StateCommon.Border.Color2 = Color.RoyalBlue;
            SearchFilter.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            SearchFilter.StateCommon.Border.Rounding = 25F;
            SearchFilter.StateCommon.Content.ShortText.Color1 = Color.White;
            SearchFilter.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            SearchFilter.TabIndex = 45;
            SearchFilter.Values.Text = "Search";
            SearchFilter.Click += SearchFilter_Click;
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.Transparent;
            Refresh.Cursor = Cursors.Hand;
            Refresh.Image = Properties.Resources.icons8_refresh_32;
            Refresh.Location = new Point(1306, 201);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(15, 15);
            Refresh.SizeMode = PictureBoxSizeMode.Zoom;
            Refresh.TabIndex = 46;
            Refresh.TabStop = false;
            Refresh.Click += Refresh_Click;
            // 
            // ReportAppointment
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(4, 20);
            BackColor = Color.White;
            ClientSize = new Size(1366, 702);
            Controls.Add(Refresh);
            Controls.Add(SearchFilter);
            Controls.Add(kryptonLabel2);
            Controls.Add(SearchPatient);
            Controls.Add(ClinicType);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel1);
            Controls.Add(DataList);
            Controls.Add(HomeLogo);
            Controls.Add(sidebar);
            Controls.Add(header);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ReportAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Healthcare Plus Dashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)sidebar).EndInit();
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OpRoomsBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)IncomeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MedicationBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)AppointmentBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)header).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomeLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClinicType).EndInit();
            ((System.ComponentModel.ISupportInitialize)Refresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonPanel sidebar;
        private KryptonPanel header;
        private PictureBox IncomeBtn;
        private PictureBox MedicationBtn;
        private PictureBox AppointmentBtn;
        private PictureBox HomeLogo;
        private KryptonLabel lblTitle;
        private Label UserType;
        private Label AppointmentLbl;
        private Label PatientLbl;
        private Label PaymentLbl;
        private Label homeLbl;
        private PictureBox HomeBtn;
        private KryptonLabel kryptonLabel1;
        private KryptonDataGridView DataList;
        private Label PatientListLbl;
        private PictureBox PatientBtn;
        private Label label1;
        private PictureBox OpRoomsBtn;
        private KryptonComboBox ClinicType;
        private KryptonLabel kryptonLabel3;
        private KryptonTextBox SearchPatient;
        private KryptonLabel kryptonLabel2;
        private KryptonButton SearchFilter;
        private PictureBox Refresh;
    }
}