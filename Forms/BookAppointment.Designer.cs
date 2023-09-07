namespace HCplus.Forms
{
    partial class BookAppointment
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            ConfirmBooking = new Krypton.Toolkit.KryptonButton();
            ClinicType = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            Doctor = new Krypton.Toolkit.KryptonComboBox();
            PrintPanel = new Krypton.Toolkit.KryptonPanel();
            Room = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel17 = new Krypton.Toolkit.KryptonLabel();
            PatientNo = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            Ctime = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            PatientName = new Krypton.Toolkit.KryptonLabel();
            Cdate = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            DocName = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            ClinicName = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            DataList = new Krypton.Toolkit.KryptonDataGridView();
            PrintBill = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClinicType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Doctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrintPanel).BeginInit();
            PrintPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataList).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1083, 70);
            kryptonPanel1.StateCommon.Color1 = Color.RoyalBlue;
            kryptonPanel1.StateCommon.Color2 = Color.DodgerBlue;
            kryptonPanel1.StateCommon.ColorAngle = 25F;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 24);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(139, 21);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Book Appointment";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(33, 103);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(94, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Doctor Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.illustration;
            pictureBox1.Location = new Point(-13, 412);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ConfirmBooking
            // 
            ConfirmBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ConfirmBooking.CornerRoundingRadius = 25F;
            ConfirmBooking.Cursor = Cursors.Hand;
            ConfirmBooking.Location = new Point(920, 681);
            ConfirmBooking.Name = "ConfirmBooking";
            ConfirmBooking.OverrideDefault.Back.Color1 = Color.DodgerBlue;
            ConfirmBooking.OverrideDefault.Back.Color2 = Color.SteelBlue;
            ConfirmBooking.Size = new Size(147, 37);
            ConfirmBooking.StateCommon.Back.Color1 = Color.SteelBlue;
            ConfirmBooking.StateCommon.Back.Color2 = Color.DodgerBlue;
            ConfirmBooking.StateCommon.Back.ColorAngle = 25F;
            ConfirmBooking.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ConfirmBooking.StateCommon.Border.Rounding = 25F;
            ConfirmBooking.StateCommon.Content.ShortText.Color1 = Color.White;
            ConfirmBooking.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmBooking.StateDisabled.Back.Color1 = Color.Gray;
            ConfirmBooking.StateDisabled.Back.Color2 = Color.FromArgb(64, 64, 64);
            ConfirmBooking.StateTracking.Back.Color1 = Color.MediumTurquoise;
            ConfirmBooking.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ConfirmBooking.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            ConfirmBooking.StateTracking.Border.Rounding = 25F;
            ConfirmBooking.TabIndex = 30;
            ConfirmBooking.Values.Text = "Confirm Booking";
            ConfirmBooking.Click += Submit_Click;
            // 
            // ClinicType
            // 
            ClinicType.CornerRoundingRadius = 10F;
            ClinicType.DropDownWidth = 259;
            ClinicType.IntegralHeight = false;
            ClinicType.Items.AddRange(new object[] { "Surgical Equipment", "Laboratory Equipment", "Emergency Equipment", "Monitoring Equipment", "Diagnostic Equipment", "Anesthesia Equipment", "Respiratory Equipmen", "Cardiology Equipment", "Imaging Equipment" });
            ClinicType.Location = new Point(570, 100);
            ClinicType.Name = "ClinicType";
            ClinicType.Size = new Size(265, 27);
            ClinicType.StateCommon.ComboBox.Border.Color1 = Color.RoyalBlue;
            ClinicType.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ClinicType.StateCommon.ComboBox.Border.Rounding = 10F;
            ClinicType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ClinicType.TabIndex = 56;
            ClinicType.Text = " - Select the Clinic -";
            ClinicType.SelectedIndexChanged += ClinicType_SelectedIndexChanged;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(442, 103);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(88, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 55;
            kryptonLabel3.Values.Text = "Clinic Name";
            // 
            // Doctor
            // 
            Doctor.CornerRoundingRadius = 10F;
            Doctor.DropDownWidth = 259;
            Doctor.IntegralHeight = false;
            Doctor.Items.AddRange(new object[] { "Surgical Equipment", "Laboratory Equipment", "Emergency Equipment", "Monitoring Equipment", "Diagnostic Equipment", "Anesthesia Equipment", "Respiratory Equipmen", "Cardiology Equipment", "Imaging Equipment" });
            Doctor.Location = new Point(145, 100);
            Doctor.Name = "Doctor";
            Doctor.Size = new Size(265, 27);
            Doctor.StateCommon.ComboBox.Border.Color1 = Color.RoyalBlue;
            Doctor.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Doctor.StateCommon.ComboBox.Border.Rounding = 10F;
            Doctor.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Doctor.TabIndex = 57;
            Doctor.Text = " - Select a Doctor -";
            Doctor.SelectedIndexChanged += Doctor_SelectedIndexChanged;
            // 
            // PrintPanel
            // 
            PrintPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PrintPanel.Controls.Add(Room);
            PrintPanel.Controls.Add(kryptonLabel17);
            PrintPanel.Controls.Add(PatientNo);
            PrintPanel.Controls.Add(kryptonLabel15);
            PrintPanel.Controls.Add(Ctime);
            PrintPanel.Controls.Add(kryptonLabel13);
            PrintPanel.Controls.Add(PatientName);
            PrintPanel.Controls.Add(Cdate);
            PrintPanel.Controls.Add(kryptonLabel9);
            PrintPanel.Controls.Add(DocName);
            PrintPanel.Controls.Add(kryptonLabel7);
            PrintPanel.Controls.Add(ClinicName);
            PrintPanel.Controls.Add(kryptonLabel4);
            PrintPanel.Location = new Point(510, 430);
            PrintPanel.Name = "PrintPanel";
            PrintPanel.Size = new Size(377, 288);
            PrintPanel.StateCommon.Color1 = SystemColors.ControlLight;
            PrintPanel.StateCommon.Color2 = Color.Silver;
            PrintPanel.TabIndex = 71;
            // 
            // Room
            // 
            Room.AutoSize = false;
            Room.Location = new Point(134, 145);
            Room.Name = "Room";
            Room.Size = new Size(227, 19);
            Room.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Room.TabIndex = 84;
            Room.Values.Text = "Consultation Room";
            // 
            // kryptonLabel17
            // 
            kryptonLabel17.Location = new Point(16, 145);
            kryptonLabel17.Name = "kryptonLabel17";
            kryptonLabel17.Size = new Size(107, 19);
            kryptonLabel17.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel17.TabIndex = 83;
            kryptonLabel17.Values.Text = "Location/Room";
            // 
            // PatientNo
            // 
            PatientNo.Location = new Point(158, 221);
            PatientNo.Name = "PatientNo";
            PatientNo.Size = new Size(57, 44);
            PatientNo.StateCommon.ShortText.Color1 = Color.FromArgb(0, 0, 64);
            PatientNo.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            PatientNo.TabIndex = 82;
            PatientNo.Values.Text = "00";
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Location = new Point(16, 232);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(113, 19);
            kryptonLabel15.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel15.TabIndex = 81;
            kryptonLabel15.Values.Text = "Appointment No";
            // 
            // Ctime
            // 
            Ctime.Location = new Point(134, 116);
            Ctime.Name = "Ctime";
            Ctime.Size = new Size(42, 19);
            Ctime.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Ctime.TabIndex = 80;
            Ctime.Values.Text = "Time";
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Location = new Point(16, 116);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(82, 19);
            kryptonLabel13.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel13.TabIndex = 79;
            kryptonLabel13.Values.Text = "Clinic Time";
            // 
            // PatientName
            // 
            PatientName.AutoSize = false;
            PatientName.Location = new Point(134, 182);
            PatientName.Name = "PatientName";
            PatientName.Size = new Size(227, 19);
            PatientName.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PatientName.TabIndex = 78;
            PatientName.Values.Text = "Patient Name";
            // 
            // Cdate
            // 
            Cdate.Location = new Point(134, 86);
            Cdate.Name = "Cdate";
            Cdate.Size = new Size(40, 19);
            Cdate.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Cdate.TabIndex = 77;
            Cdate.Values.Text = "Date";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(16, 86);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(80, 19);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel9.TabIndex = 76;
            kryptonLabel9.Values.Text = "Clinic Date";
            // 
            // DocName
            // 
            DocName.AutoSize = false;
            DocName.Location = new Point(134, 58);
            DocName.Name = "DocName";
            DocName.Size = new Size(216, 19);
            DocName.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DocName.TabIndex = 75;
            DocName.Values.Text = "Doctor name";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(16, 58);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(94, 19);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel7.TabIndex = 74;
            kryptonLabel7.Values.Text = "Doctor Name";
            // 
            // ClinicName
            // 
            ClinicName.AutoSize = false;
            ClinicName.Location = new Point(16, 14);
            ClinicName.Name = "ClinicName";
            ClinicName.Size = new Size(345, 19);
            ClinicName.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            ClinicName.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            ClinicName.TabIndex = 72;
            ClinicName.Values.Text = "Clinic Name";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(16, 182);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(97, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 71;
            kryptonLabel4.Values.Text = "Patient Name";
            // 
            // DataList
            // 
            DataList.AllowUserToOrderColumns = true;
            DataList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataList.ColumnHeadersHeight = 28;
            DataList.Cursor = Cursors.Hand;
            DataList.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            DataList.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridDataCellSheet;
            DataList.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            DataList.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            DataList.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            DataList.Location = new Point(31, 150);
            DataList.MultiSelect = false;
            DataList.Name = "DataList";
            DataList.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
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
            DataList.Size = new Size(1019, 256);
            DataList.StateCommon.Background.Color1 = Color.FromArgb(242, 242, 242);
            DataList.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridDataCellSheet;
            DataList.StateCommon.DataCell.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            DataList.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DataList.StateCommon.HeaderRow.Content.Color1 = Color.White;
            DataList.StateCommon.HeaderRow.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DataList.StateSelected.DataCell.Back.Color1 = Color.Silver;
            DataList.StateSelected.DataCell.Back.Color2 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Back.Color1 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Back.Color2 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Border.Color1 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Border.Color2 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DataList.StateSelected.HeaderColumn.Content.Color1 = Color.FromArgb(224, 224, 224);
            DataList.StateSelected.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            DataList.StateSelected.HeaderRow.Back.Color1 = Color.Silver;
            DataList.StateSelected.HeaderRow.Back.Color2 = Color.Silver;
            DataList.StateSelected.HeaderRow.Content.Color1 = Color.Silver;
            DataList.StateSelected.HeaderRow.Content.Color2 = Color.Silver;
            DataList.TabIndex = 72;
            DataList.TabStop = false;
            DataList.CellClick += DataList_CellClick;
            // 
            // PrintBill
            // 
            PrintBill.PrintPage += PrintBill_PrintPage;
            // 
            // BookAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1079, 749);
            Controls.Add(DataList);
            Controls.Add(Doctor);
            Controls.Add(ClinicType);
            Controls.Add(kryptonLabel3);
            Controls.Add(ConfirmBooking);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(PrintPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BookAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClinicType).EndInit();
            ((System.ComponentModel.ISupportInitialize)Doctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrintPanel).EndInit();
            PrintPanel.ResumeLayout(false);
            PrintPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton ConfirmBooking;
        private Krypton.Toolkit.KryptonComboBox ClinicType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox Doctor;
        private Krypton.Toolkit.KryptonPanel PrintPanel;
        private Krypton.Toolkit.KryptonLabel Room;
        private Krypton.Toolkit.KryptonLabel kryptonLabel17;
        private Krypton.Toolkit.KryptonLabel PatientNo;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonLabel Ctime;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonLabel PatientName;
        private Krypton.Toolkit.KryptonLabel Cdate;
        private Krypton.Toolkit.KryptonLabel DocName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel clinicName;
        private Krypton.Toolkit.KryptonLabel ClinicName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonDataGridView DataList;
        private System.Drawing.Printing.PrintDocument PrintBill;
    }
}