namespace HCplus.Forms
{
    partial class AddOpSchedule
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
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            Submit = new Krypton.Toolkit.KryptonButton();
            opRoom = new Krypton.Toolkit.KryptonComboBox();
            opDate = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            Err = new Krypton.Toolkit.KryptonWrapLabel();
            opDetails = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)opRoom).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(794, 70);
            kryptonPanel1.StateCommon.Color1 = Color.RoyalBlue;
            kryptonPanel1.StateCommon.Color2 = Color.DodgerBlue;
            kryptonPanel1.StateCommon.ColorAngle = 25F;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 24);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(171, 21);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Schedule an Operation";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(241, 111);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(115, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Operation Room";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Free_Vector___Professional_surgeons_surrounding_patient_on_operation_table_flat_illustration;
            pictureBox1.Location = new Point(-2, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Submit
            // 
            Submit.CornerRoundingRadius = 25F;
            Submit.Cursor = Cursors.Hand;
            Submit.Location = new Point(648, 358);
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
            Submit.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Submit.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            Submit.StateTracking.Border.Rounding = 25F;
            Submit.TabIndex = 30;
            Submit.TabStop = false;
            Submit.Values.Text = "Add";
            Submit.Click += Submit_Click;
            // 
            // opRoom
            // 
            opRoom.CornerRoundingRadius = 10F;
            opRoom.DropDownWidth = 259;
            opRoom.IntegralHeight = false;
            opRoom.Items.AddRange(new object[] { "Surgical Equipment", "Laboratory Equipment", "Emergency Equipment", "Monitoring Equipment", "Diagnostic Equipment", "Anesthesia Equipment", "Respiratory Equipmen", "Cardiology Equipment", "Imaging Equipment" });
            opRoom.Location = new Point(381, 107);
            opRoom.Name = "opRoom";
            opRoom.Size = new Size(265, 27);
            opRoom.StateCommon.ComboBox.Border.Color1 = Color.RoyalBlue;
            opRoom.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            opRoom.StateCommon.ComboBox.Border.Rounding = 10F;
            opRoom.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            opRoom.TabIndex = 48;
            opRoom.Text = " - Select a Consultation Room -";
            // 
            // opDate
            // 
            opDate.CornerRoundingRadius = 10F;
            opDate.Format = DateTimePickerFormat.Short;
            opDate.Location = new Point(381, 165);
            opDate.MinDate = new DateTime(2023, 9, 5, 0, 0, 0, 0);
            opDate.Name = "opDate";
            opDate.Size = new Size(156, 27);
            opDate.StateCommon.Border.Color1 = Color.RoyalBlue;
            opDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            opDate.StateCommon.Border.Rounding = 10F;
            opDate.TabIndex = 50;
            opDate.ValueChanged += opDate_ValueChanged;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(241, 170);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(112, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 49;
            kryptonLabel4.Values.Text = "Scheduled Date";
            // 
            // Err
            // 
            Err.AutoSize = false;
            Err.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Err.ForeColor = Color.Red;
            Err.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            Err.Location = new Point(381, 139);
            Err.Name = "Err";
            Err.Size = new Size(321, 22);
            Err.StateCommon.TextColor = Color.Red;
            Err.Text = "This Operation Room is not Available on the selected Date";
            Err.Visible = false;
            // 
            // opDetails
            // 
            opDetails.Location = new Point(381, 219);
            opDetails.Name = "opDetails";
            opDetails.Size = new Size(378, 99);
            opDetails.StateCommon.Border.Color1 = Color.RoyalBlue;
            opDetails.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            opDetails.StateCommon.Border.Rounding = 10F;
            opDetails.TabIndex = 54;
            opDetails.Text = "";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(241, 219);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(121, 19);
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel11.TabIndex = 53;
            kryptonLabel11.Values.Text = "Operation Details";
            // 
            // AddOpSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(793, 407);
            Controls.Add(opDetails);
            Controls.Add(kryptonLabel11);
            Controls.Add(Err);
            Controls.Add(opDate);
            Controls.Add(kryptonLabel4);
            Controls.Add(opRoom);
            Controls.Add(Submit);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddOpSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)opRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton Submit;
        private Krypton.Toolkit.KryptonButton Clear;
        private Krypton.Toolkit.KryptonTextBox Price;
        private Krypton.Toolkit.KryptonComboBox opRoom;
        private Krypton.Toolkit.KryptonDateTimePicker opDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonWrapLabel Err;
        private Krypton.Toolkit.KryptonRichTextBox opDetails;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
    }
}