namespace HCplus.Forms
{
    partial class AddPrescription
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
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            MedName = new Krypton.Toolkit.KryptonTextBox();
            Submit = new Krypton.Toolkit.KryptonButton();
            Directions = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            MedNo = new Krypton.Toolkit.KryptonNumericUpDown();
            finishDate = new Krypton.Toolkit.KryptonDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(747, 70);
            kryptonPanel1.StateCommon.Color1 = Color.RoyalBlue;
            kryptonPanel1.StateCommon.Color2 = Color.DodgerBlue;
            kryptonPanel1.StateCommon.ColorAngle = 25F;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 24);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(158, 21);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Prescribe a Medicine";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(256, 103);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(110, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Medicine Name";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(256, 263);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(83, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "No of Meds";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(256, 320);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(83, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 3;
            kryptonLabel4.Values.Text = "Finish Date";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1221442419_612x612;
            pictureBox1.Location = new Point(9, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // MedName
            // 
            MedName.Cursor = Cursors.IBeam;
            MedName.Location = new Point(378, 100);
            MedName.Name = "MedName";
            MedName.Size = new Size(269, 28);
            MedName.StateCommon.Border.Color1 = Color.RoyalBlue;
            MedName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MedName.StateCommon.Border.Rounding = 10F;
            MedName.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            MedName.StateCommon.Content.Padding = new Padding(2);
            MedName.TabIndex = 24;
            // 
            // Submit
            // 
            Submit.CornerRoundingRadius = 25F;
            Submit.Cursor = Cursors.Hand;
            Submit.Location = new Point(626, 357);
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
            Submit.Values.Text = "Save";
            Submit.Click += Submit_Click;
            // 
            // Directions
            // 
            Directions.Location = new Point(378, 155);
            Directions.Name = "Directions";
            Directions.Size = new Size(329, 72);
            Directions.StateCommon.Border.Color1 = Color.RoyalBlue;
            Directions.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Directions.StateCommon.Border.Rounding = 10F;
            Directions.TabIndex = 41;
            Directions.Text = "";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(256, 155);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(75, 19);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 42;
            kryptonLabel5.Values.Text = "Directions";
            // 
            // MedNo
            // 
            MedNo.Location = new Point(378, 259);
            MedNo.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            MedNo.Name = "MedNo";
            MedNo.Size = new Size(163, 28);
            MedNo.StateCommon.Border.Color1 = Color.RoyalBlue;
            MedNo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MedNo.StateCommon.Border.Rounding = 10F;
            MedNo.TabIndex = 44;
            // 
            // finishDate
            // 
            finishDate.CornerRoundingRadius = 10F;
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(378, 316);
            finishDate.MinDate = new DateTime(2023, 8, 31, 0, 0, 0, 0);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(163, 27);
            finishDate.StateCommon.Border.Color1 = Color.RoyalBlue;
            finishDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            finishDate.StateCommon.Border.Rounding = 10F;
            finishDate.TabIndex = 43;
            // 
            // AddPrescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(746, 409);
            Controls.Add(MedNo);
            Controls.Add(finishDate);
            Controls.Add(kryptonLabel5);
            Controls.Add(Directions);
            Controls.Add(Submit);
            Controls.Add(MedName);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddPrescription";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonTextBox MedName;
        private Krypton.Toolkit.KryptonButton Submit;
        private Krypton.Toolkit.KryptonButton Clear;
        private Krypton.Toolkit.KryptonTextBox Price;
        private Krypton.Toolkit.KryptonRichTextBox Directions;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonNumericUpDown MedNo;
        private Krypton.Toolkit.KryptonDateTimePicker finishDate;
    }
}