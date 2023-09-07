namespace HCplus.Forms
{
    partial class EditClinic
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            Submit = new Krypton.Toolkit.KryptonButton();
            ClinicType = new Krypton.Toolkit.KryptonComboBox();
            ClinicDate = new Krypton.Toolkit.KryptonDateTimePicker();
            PatientsNo = new Krypton.Toolkit.KryptonNumericUpDown();
            End = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            Doctor = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            Location = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            Start = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            ScheduleErr = new Label();
            DocErr = new Krypton.Toolkit.KryptonWrapLabel();
            CancelBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClinicType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Doctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Location).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(875, 70);
            kryptonPanel1.StateCommon.Color1 = Color.RoyalBlue;
            kryptonPanel1.StateCommon.Color2 = Color.DodgerBlue;
            kryptonPanel1.StateCommon.ColorAngle = 25F;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 24);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(151, 21);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Edit Clinic Schedule";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(322, 154);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(88, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Clinic Name";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(322, 108);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(80, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 3;
            kryptonLabel4.Values.Text = "Clinic Date";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(322, 387);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(98, 19);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel7.TabIndex = 6;
            kryptonLabel7.Values.Text = "Total Patients";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.doctor_with_stethoscope_sitting_at_the_desk_with_monitor_medcine_pandemic_lockdown_therapy_health_care_hospital_workspace_concept_stock_illustration_in_flat_style_isolated_on_white_vector;
            pictureBox1.Location = new Point(0, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Submit
            // 
            Submit.CornerRoundingRadius = 25F;
            Submit.Cursor = Cursors.Hand;
            Submit.Location = new Point(753, 462);
            Submit.Name = "Submit";
            Submit.OverrideDefault.Back.Color1 = Color.FromArgb(0, 179, 89);
            Submit.OverrideDefault.Back.Color2 = Color.MediumSeaGreen;
            Submit.Size = new Size(103, 37);
            Submit.StateCommon.Back.Color1 = Color.FromArgb(0, 204, 102);
            Submit.StateCommon.Back.Color2 = Color.FromArgb(0, 179, 89);
            Submit.StateCommon.Back.ColorAngle = 25F;
            Submit.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Submit.StateCommon.Border.Rounding = 25F;
            Submit.StateCommon.Content.ShortText.Color1 = Color.White;
            Submit.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Submit.StateTracking.Back.Color1 = Color.FromArgb(0, 179, 89);
            Submit.StateTracking.Back.Color2 = Color.MediumSeaGreen;
            Submit.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Submit.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            Submit.StateTracking.Border.Rounding = 25F;
            Submit.TabIndex = 30;
            Submit.Values.Text = "Update";
            Submit.Click += Submit_Click;
            // 
            // ClinicType
            // 
            ClinicType.CornerRoundingRadius = 10F;
            ClinicType.DropDownWidth = 259;
            ClinicType.IntegralHeight = false;
            ClinicType.Items.AddRange(new object[] { "Surgical Equipment", "Laboratory Equipment", "Emergency Equipment", "Monitoring Equipment", "Diagnostic Equipment", "Anesthesia Equipment", "Respiratory Equipmen", "Cardiology Equipment", "Imaging Equipment" });
            ClinicType.Location = new Point(450, 151);
            ClinicType.Name = "ClinicType";
            ClinicType.Size = new Size(265, 27);
            ClinicType.StateCommon.ComboBox.Border.Color1 = Color.RoyalBlue;
            ClinicType.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ClinicType.StateCommon.ComboBox.Border.Rounding = 10F;
            ClinicType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ClinicType.TabIndex = 38;
            ClinicType.Text = " - Select the Clinic -";
            // 
            // ClinicDate
            // 
            ClinicDate.CornerRoundingRadius = 10F;
            ClinicDate.Format = DateTimePickerFormat.Short;
            ClinicDate.Location = new Point(450, 105);
            ClinicDate.MinDate = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            ClinicDate.Name = "ClinicDate";
            ClinicDate.Size = new Size(156, 27);
            ClinicDate.StateCommon.Border.Color1 = Color.RoyalBlue;
            ClinicDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ClinicDate.StateCommon.Border.Rounding = 10F;
            ClinicDate.TabIndex = 39;
            // 
            // PatientsNo
            // 
            PatientsNo.Location = new Point(450, 380);
            PatientsNo.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            PatientsNo.Name = "PatientsNo";
            PatientsNo.Size = new Size(233, 28);
            PatientsNo.StateCommon.Border.Color1 = Color.RoyalBlue;
            PatientsNo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PatientsNo.StateCommon.Border.Rounding = 10F;
            PatientsNo.TabIndex = 40;
            // 
            // End
            // 
            End.CornerRoundingRadius = 10F;
            End.CustomFormat = "hh:mm tt";
            End.Format = DateTimePickerFormat.Custom;
            End.Location = new Point(698, 334);
            End.Name = "End";
            End.Size = new Size(145, 27);
            End.StateCommon.Border.Color1 = Color.RoyalBlue;
            End.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            End.StateCommon.Border.Rounding = 10F;
            End.TabIndex = 42;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(618, 339);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(72, 19);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 41;
            kryptonLabel5.Values.Text = "End Time";
            // 
            // Doctor
            // 
            Doctor.CornerRoundingRadius = 10F;
            Doctor.DropDownWidth = 259;
            Doctor.IntegralHeight = false;
            Doctor.Items.AddRange(new object[] { "Surgical Equipment", "Laboratory Equipment", "Emergency Equipment", "Monitoring Equipment", "Diagnostic Equipment", "Anesthesia Equipment", "Respiratory Equipmen", "Cardiology Equipment", "Imaging Equipment" });
            Doctor.Location = new Point(450, 199);
            Doctor.Name = "Doctor";
            Doctor.Size = new Size(265, 27);
            Doctor.StateCommon.ComboBox.Border.Color1 = Color.RoyalBlue;
            Doctor.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Doctor.StateCommon.ComboBox.Border.Rounding = 10F;
            Doctor.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Doctor.TabIndex = 45;
            Doctor.Text = " - Select a Doctor -";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(322, 202);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(115, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 44;
            kryptonLabel2.Values.Text = "Assigned Doctor";
            // 
            // Location
            // 
            Location.CornerRoundingRadius = 10F;
            Location.DropDownWidth = 259;
            Location.IntegralHeight = false;
            Location.Items.AddRange(new object[] { "Surgical Equipment", "Laboratory Equipment", "Emergency Equipment", "Monitoring Equipment", "Diagnostic Equipment", "Anesthesia Equipment", "Respiratory Equipmen", "Cardiology Equipment", "Imaging Equipment" });
            Location.Location = new Point(450, 248);
            Location.Name = "Location";
            Location.Size = new Size(265, 27);
            Location.StateCommon.ComboBox.Border.Color1 = Color.RoyalBlue;
            Location.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Location.StateCommon.ComboBox.Border.Rounding = 10F;
            Location.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Location.TabIndex = 47;
            Location.Text = " - Select a Consultation Room -";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(322, 251);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(114, 19);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel8.TabIndex = 46;
            kryptonLabel8.Values.Text = "Location / Room";
            // 
            // Start
            // 
            Start.CornerRoundingRadius = 10F;
            Start.CustomFormat = "hh:mm tt";
            Start.Format = DateTimePickerFormat.Custom;
            Start.Location = new Point(450, 335);
            Start.Name = "Start";
            Start.Size = new Size(145, 27);
            Start.StateCommon.Border.Color1 = Color.RoyalBlue;
            Start.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Start.StateCommon.Border.Rounding = 10F;
            Start.TabIndex = 49;
            Start.ValueChanged += Start_ValueChanged;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(322, 339);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(96, 19);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 48;
            kryptonLabel6.Values.Text = "Starting Time";
            // 
            // ScheduleErr
            // 
            ScheduleErr.AutoSize = true;
            ScheduleErr.ForeColor = Color.Red;
            ScheduleErr.Location = new Point(412, 309);
            ScheduleErr.Name = "ScheduleErr";
            ScheduleErr.Size = new Size(0, 15);
            ScheduleErr.TabIndex = 50;
            // 
            // DocErr
            // 
            DocErr.AutoSize = false;
            DocErr.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DocErr.ForeColor = Color.Red;
            DocErr.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            DocErr.Location = new Point(721, 194);
            DocErr.Name = "DocErr";
            DocErr.Size = new Size(154, 43);
            DocErr.StateCommon.TextColor = Color.Red;
            // 
            // CancelBtn
            // 
            CancelBtn.CornerRoundingRadius = 25F;
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.Location = new Point(592, 462);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.OverrideDefault.Back.Color1 = Color.DarkTurquoise;
            CancelBtn.OverrideDefault.Back.Color2 = Color.SteelBlue;
            CancelBtn.Size = new Size(143, 37);
            CancelBtn.StateCommon.Back.Color1 = Color.DarkTurquoise;
            CancelBtn.StateCommon.Back.Color2 = Color.SteelBlue;
            CancelBtn.StateCommon.Back.ColorAngle = 1F;
            CancelBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelBtn.StateCommon.Border.Rounding = 25F;
            CancelBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            CancelBtn.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            CancelBtn.StateTracking.Back.Color1 = Color.SteelBlue;
            CancelBtn.StateTracking.Back.Color2 = Color.DarkTurquoise;
            CancelBtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelBtn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            CancelBtn.StateTracking.Border.Rounding = 25F;
            CancelBtn.TabIndex = 51;
            CancelBtn.Values.Text = "Cancel Schedule";
            CancelBtn.Click += CancelBtn_Click;
            // 
            // EditClinic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(874, 527);
            Controls.Add(CancelBtn);
            Controls.Add(DocErr);
            Controls.Add(ScheduleErr);
            Controls.Add(Start);
            Controls.Add(kryptonLabel6);
            Controls.Add(Location);
            Controls.Add(kryptonLabel8);
            Controls.Add(Doctor);
            Controls.Add(kryptonLabel2);
            Controls.Add(End);
            Controls.Add(kryptonLabel5);
            Controls.Add(PatientsNo);
            Controls.Add(ClinicDate);
            Controls.Add(ClinicType);
            Controls.Add(Submit);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditClinic";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClinicType).EndInit();
            ((System.ComponentModel.ISupportInitialize)Doctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)Location).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonMaskedTextBox Contact;
        private Krypton.Toolkit.KryptonTextBox ItemName;
        private Krypton.Toolkit.KryptonTextBox Email;
        private Krypton.Toolkit.KryptonLabel EmailError;
        private Krypton.Toolkit.KryptonButton Submit;
        private Krypton.Toolkit.KryptonRichTextBox Speciality;
        private Krypton.Toolkit.KryptonComboBox ClinicType;
        private Krypton.Toolkit.KryptonDateTimePicker ClinicDate;
        private Krypton.Toolkit.KryptonNumericUpDown PatientsNo;
        private Krypton.Toolkit.KryptonDateTimePicker End;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonComboBox Doctor;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonComboBox Location;
        private Krypton.Toolkit.KryptonDateTimePicker Start;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Label ScheduleErr;
        private Krypton.Toolkit.KryptonWrapLabel DocErr;
        private Krypton.Toolkit.KryptonButton CancelBtn;
    }
}