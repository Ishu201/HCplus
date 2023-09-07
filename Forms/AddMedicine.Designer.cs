namespace HCplus.Forms
{
    partial class AddMedicine
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
            Qty = new Krypton.Toolkit.KryptonTextBox();
            Clear = new Krypton.Toolkit.KryptonButton();
            Price = new Krypton.Toolkit.KryptonTextBox();
            PriceErr = new Label();
            QtyErr = new Label();
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
            kryptonLabel1.Size = new Size(185, 21);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Register a New Medicine";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(246, 116);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(110, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Medicine Name";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(247, 175);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(84, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Retail Price";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(247, 236);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(64, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 3;
            kryptonLabel4.Values.Text = "Quantity";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uguy;
            pictureBox1.Location = new Point(0, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // MedName
            // 
            MedName.Cursor = Cursors.IBeam;
            MedName.Location = new Point(368, 113);
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
            Submit.Location = new Point(614, 335);
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
            // Qty
            // 
            Qty.Cursor = Cursors.IBeam;
            Qty.Location = new Point(368, 231);
            Qty.Name = "Qty";
            Qty.Size = new Size(162, 28);
            Qty.StateCommon.Border.Color1 = Color.RoyalBlue;
            Qty.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Qty.StateCommon.Border.Rounding = 10F;
            Qty.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            Qty.StateCommon.Content.Padding = new Padding(2);
            Qty.TabIndex = 33;
            Qty.TextChanged += Qty_TextChanged;
            // 
            // Clear
            // 
            Clear.CornerRoundingRadius = 25F;
            Clear.Cursor = Cursors.Hand;
            Clear.Location = new Point(496, 335);
            Clear.Name = "Clear";
            Clear.OverrideDefault.Back.Color1 = Color.FromArgb(166, 166, 166);
            Clear.OverrideDefault.Back.Color2 = Color.Gray;
            Clear.Size = new Size(103, 37);
            Clear.StateCommon.Back.Color1 = Color.FromArgb(179, 179, 179);
            Clear.StateCommon.Back.Color2 = Color.FromArgb(166, 166, 166);
            Clear.StateCommon.Back.ColorAngle = 25F;
            Clear.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Clear.StateCommon.Border.Rounding = 25F;
            Clear.StateCommon.Content.ShortText.Color1 = Color.White;
            Clear.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.StateTracking.Back.Color1 = Color.FromArgb(179, 179, 179);
            Clear.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Clear.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            Clear.StateTracking.Border.Rounding = 25F;
            Clear.TabIndex = 37;
            Clear.TabStop = false;
            Clear.Values.Text = "Clear";
            Clear.Click += Clear_Click;
            // 
            // Price
            // 
            Price.Cursor = Cursors.IBeam;
            Price.Location = new Point(368, 173);
            Price.Name = "Price";
            Price.Size = new Size(162, 28);
            Price.StateCommon.Border.Color1 = Color.RoyalBlue;
            Price.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Price.StateCommon.Border.Rounding = 10F;
            Price.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            Price.StateCommon.Content.Padding = new Padding(2);
            Price.TabIndex = 38;
            Price.TextChanged += Price_TextChanged;
            // 
            // PriceErr
            // 
            PriceErr.AutoSize = true;
            PriceErr.ForeColor = Color.Firebrick;
            PriceErr.Location = new Point(539, 179);
            PriceErr.Name = "PriceErr";
            PriceErr.Size = new Size(138, 15);
            PriceErr.TabIndex = 39;
            PriceErr.Text = "Please Enter a Valid Value";
            PriceErr.Visible = false;
            // 
            // QtyErr
            // 
            QtyErr.AutoSize = true;
            QtyErr.ForeColor = Color.Firebrick;
            QtyErr.Location = new Point(539, 238);
            QtyErr.Name = "QtyErr";
            QtyErr.Size = new Size(138, 15);
            QtyErr.TabIndex = 40;
            QtyErr.Text = "Please Enter a Valid Value";
            QtyErr.Visible = false;
            // 
            // AddMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(746, 400);
            Controls.Add(QtyErr);
            Controls.Add(PriceErr);
            Controls.Add(Price);
            Controls.Add(Clear);
            Controls.Add(Qty);
            Controls.Add(Submit);
            Controls.Add(MedName);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddMedicine";
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
        private Krypton.Toolkit.KryptonTextBox Qty;
        private Krypton.Toolkit.KryptonButton Clear;
        private Krypton.Toolkit.KryptonTextBox Price;
        private Label PriceErr;
        private Label QtyErr;
    }
}