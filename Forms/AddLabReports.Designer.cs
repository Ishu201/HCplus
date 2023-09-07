namespace HCplus.Forms
{
    partial class AddLabReports
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
            ReportName = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReportName).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(679, 70);
            kryptonPanel1.StateCommon.Color1 = Color.RoyalBlue;
            kryptonPanel1.StateCommon.Color2 = Color.DodgerBlue;
            kryptonPanel1.StateCommon.ColorAngle = 25F;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 24);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(103, 21);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Add a Report";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(242, 119);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(85, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Report type";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.one1;
            pictureBox1.Location = new Point(9, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Submit
            // 
            Submit.CornerRoundingRadius = 25F;
            Submit.Cursor = Cursors.Hand;
            Submit.Location = new Point(522, 200);
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
            // ReportName
            // 
            ReportName.CornerRoundingRadius = 10F;
            ReportName.DropDownWidth = 259;
            ReportName.IntegralHeight = false;
            ReportName.Items.AddRange(new object[] { "Complete Blood Count (CBC)", "Basic Metabolic Panel (BMP)", "Comprehensive Metabolic Panel (CMP)", "Lipid Panel", "Liver Function Tests (LFT)", "Renal Function Panel", "Thyroid Function Tests", "Urine Culture and Sensitivity", "Electrocardiogram (ECG)", "Echocardiogram (Echo)", "Holter Monitor Report", "Chest X-ray", "Abdominal Ultrasound", "MRI Scan", "CT Scan", "Colonoscopy Report" });
            ReportName.Location = new Point(360, 116);
            ReportName.Name = "ReportName";
            ReportName.Size = new Size(265, 27);
            ReportName.StateCommon.ComboBox.Border.Color1 = Color.RoyalBlue;
            ReportName.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ReportName.StateCommon.ComboBox.Border.Rounding = 10F;
            ReportName.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ReportName.TabIndex = 39;
            ReportName.TabStop = false;
            // 
            // AddLabReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(678, 264);
            Controls.Add(ReportName);
            Controls.Add(Submit);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddLabReports";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReportName).EndInit();
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
        private Krypton.Toolkit.KryptonComboBox ReportName;
    }
}