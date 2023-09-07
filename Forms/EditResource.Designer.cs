namespace HCplus.Forms
{
    partial class EditResource
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
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            ItemName = new Krypton.Toolkit.KryptonTextBox();
            Submit = new Krypton.Toolkit.KryptonButton();
            Vendor = new Krypton.Toolkit.KryptonTextBox();
            IvtNo = new Krypton.Toolkit.KryptonMaskedTextBox();
            Description = new Krypton.Toolkit.KryptonRichTextBox();
            Type = new Krypton.Toolkit.KryptonComboBox();
            PDate = new Krypton.Toolkit.KryptonDateTimePicker();
            Cost = new Krypton.Toolkit.KryptonNumericUpDown();
            WDate = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            DepartmentS = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Type).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DepartmentS).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(848, 70);
            kryptonPanel1.StateCommon.Color1 = Color.RoyalBlue;
            kryptonPanel1.StateCommon.Color2 = Color.DodgerBlue;
            kryptonPanel1.StateCommon.ColorAngle = 25F;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 24);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(170, 21);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Update Resource Data";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(219, 94);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(80, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Item Name";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(220, 139);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(107, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Resource Type";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(222, 294);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(94, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 3;
            kryptonLabel4.Values.Text = "Purchase On";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(222, 329);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(57, 19);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 5;
            kryptonLabel6.Values.Text = "Vendor";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(222, 374);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(75, 19);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel7.TabIndex = 6;
            kryptonLabel7.Values.Text = "Cost (Rs.)";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(153, 461);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(85, 19);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel9.TabIndex = 8;
            kryptonLabel9.Values.Text = "Department";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(566, 460);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(92, 19);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel10.TabIndex = 9;
            kryptonLabel10.Values.Text = "Inventory No";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(220, 184);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(83, 19);
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel11.TabIndex = 10;
            kryptonLabel11.Values.Text = "Description";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._46557881;
            pictureBox1.Location = new Point(0, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ItemName
            // 
            ItemName.Cursor = Cursors.IBeam;
            ItemName.Location = new Point(340, 87);
            ItemName.Name = "ItemName";
            ItemName.Size = new Size(269, 28);
            ItemName.StateCommon.Border.Color1 = Color.RoyalBlue;
            ItemName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ItemName.StateCommon.Border.Rounding = 10F;
            ItemName.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            ItemName.StateCommon.Content.Padding = new Padding(2);
            ItemName.TabIndex = 24;
            // 
            // Submit
            // 
            Submit.CornerRoundingRadius = 25F;
            Submit.Cursor = Cursors.Hand;
            Submit.Location = new Point(730, 535);
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
            Submit.Values.Text = "Update";
            Submit.Click += Submit_Click;
            // 
            // Vendor
            // 
            Vendor.Cursor = Cursors.IBeam;
            Vendor.Location = new Point(340, 329);
            Vendor.Name = "Vendor";
            Vendor.Size = new Size(436, 28);
            Vendor.StateCommon.Border.Color1 = Color.RoyalBlue;
            Vendor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Vendor.StateCommon.Border.Rounding = 10F;
            Vendor.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            Vendor.StateCommon.Content.Padding = new Padding(2);
            Vendor.TabIndex = 31;
            // 
            // IvtNo
            // 
            IvtNo.Cursor = Cursors.IBeam;
            IvtNo.Location = new Point(664, 455);
            IvtNo.Mask = "IVT0000";
            IvtNo.Name = "IvtNo";
            IvtNo.Size = new Size(144, 28);
            IvtNo.StateCommon.Border.Color1 = Color.RoyalBlue;
            IvtNo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            IvtNo.StateCommon.Border.Rounding = 10F;
            IvtNo.StateCommon.Border.Width = 1;
            IvtNo.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            IvtNo.StateCommon.Content.Padding = new Padding(2);
            IvtNo.TabIndex = 32;
            IvtNo.Text = "IVT";
            // 
            // Description
            // 
            Description.Location = new Point(340, 175);
            Description.Name = "Description";
            Description.Size = new Size(466, 69);
            Description.StateCommon.Border.Color1 = Color.RoyalBlue;
            Description.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Description.StateCommon.Border.Rounding = 10F;
            Description.TabIndex = 36;
            Description.Text = "";
            // 
            // Type
            // 
            Type.CornerRoundingRadius = 10F;
            Type.DropDownWidth = 259;
            Type.IntegralHeight = false;
            Type.Items.AddRange(new object[] { "Surgical Equipment", "Laboratory Equipment", "Emergency Equipment", "Monitoring Equipment", "Diagnostic Equipment", "Anesthesia Equipment", "Respiratory Equipmen", "Cardiology Equipment", "Imaging Equipment" });
            Type.Location = new Point(340, 131);
            Type.Name = "Type";
            Type.Size = new Size(265, 27);
            Type.StateCommon.ComboBox.Border.Color1 = Color.RoyalBlue;
            Type.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Type.StateCommon.ComboBox.Border.Rounding = 10F;
            Type.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            Type.TabIndex = 38;
            // 
            // PDate
            // 
            PDate.CornerRoundingRadius = 10F;
            PDate.Format = DateTimePickerFormat.Short;
            PDate.Location = new Point(340, 286);
            PDate.Name = "PDate";
            PDate.Size = new Size(156, 27);
            PDate.StateCommon.Border.Color1 = Color.RoyalBlue;
            PDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PDate.StateCommon.Border.Rounding = 10F;
            PDate.TabIndex = 39;
            // 
            // Cost
            // 
            Cost.Location = new Point(340, 372);
            Cost.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            Cost.Name = "Cost";
            Cost.Size = new Size(151, 28);
            Cost.StateCommon.Border.Color1 = Color.RoyalBlue;
            Cost.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Cost.StateCommon.Border.Rounding = 10F;
            Cost.TabIndex = 40;
            // 
            // WDate
            // 
            WDate.CornerRoundingRadius = 10F;
            WDate.Format = DateTimePickerFormat.Short;
            WDate.Location = new Point(631, 372);
            WDate.Name = "WDate";
            WDate.Size = new Size(145, 27);
            WDate.StateCommon.Border.Color1 = Color.RoyalBlue;
            WDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            WDate.StateCommon.Border.Rounding = 10F;
            WDate.TabIndex = 42;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(520, 375);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(105, 19);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 41;
            kryptonLabel5.Values.Text = "Warranty Ends";
            // 
            // DepartmentS
            // 
            DepartmentS.CornerRoundingRadius = 10F;
            DepartmentS.DropDownWidth = 259;
            DepartmentS.IntegralHeight = false;
            DepartmentS.Items.AddRange(new object[] { "Surgery Department", "Laboratory Department", "Emergency Department", "Intensive Care Unit", "Gastroenterology Department", "Operating Theater", "Cardiology Department", "Respiratory Care Unit", "General Ward" });
            DepartmentS.Location = new Point(255, 456);
            DepartmentS.Name = "DepartmentS";
            DepartmentS.Size = new Size(283, 27);
            DepartmentS.StateCommon.ComboBox.Border.Color1 = Color.RoyalBlue;
            DepartmentS.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DepartmentS.StateCommon.ComboBox.Border.Rounding = 10F;
            DepartmentS.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            DepartmentS.TabIndex = 43;
            // 
            // EditResource
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(847, 593);
            Controls.Add(DepartmentS);
            Controls.Add(WDate);
            Controls.Add(kryptonLabel5);
            Controls.Add(Cost);
            Controls.Add(PDate);
            Controls.Add(Type);
            Controls.Add(Description);
            Controls.Add(IvtNo);
            Controls.Add(Vendor);
            Controls.Add(Submit);
            Controls.Add(ItemName);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonLabel11);
            Controls.Add(kryptonLabel10);
            Controls.Add(kryptonLabel9);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditResource";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Type).EndInit();
            ((System.ComponentModel.ISupportInitialize)DepartmentS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonMaskedTextBox Contact;
        private Krypton.Toolkit.KryptonTextBox ItemName;
        private Krypton.Toolkit.KryptonTextBox Email;
        private Krypton.Toolkit.KryptonLabel EmailError;
        private Krypton.Toolkit.KryptonButton Submit;
        private Krypton.Toolkit.KryptonTextBox Vendor;
        private Krypton.Toolkit.KryptonMaskedTextBox IvtNo;
        private Krypton.Toolkit.KryptonRichTextBox Speciality;
        private Krypton.Toolkit.KryptonRichTextBox Description;
        private Krypton.Toolkit.KryptonComboBox Type;
        private Krypton.Toolkit.KryptonDateTimePicker PDate;
        private Krypton.Toolkit.KryptonNumericUpDown Cost;
        private Krypton.Toolkit.KryptonDateTimePicker WDate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonComboBox DepartmentS;
    }
}