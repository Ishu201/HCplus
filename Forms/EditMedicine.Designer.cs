namespace HCplus.Forms
{
    partial class EditMedicine
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
            Update = new Krypton.Toolkit.KryptonButton();
            MedName = new Krypton.Toolkit.KryptonTextBox();
            pictureBox1 = new PictureBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            Remove = new Krypton.Toolkit.KryptonButton();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            Price = new Krypton.Toolkit.KryptonLabel();
            Qty = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
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
            kryptonPanel1.Size = new Size(684, 70);
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
            kryptonLabel1.Values.Text = "Edit Medicine Name";
            // 
            // Update
            // 
            Update.CornerRoundingRadius = 25F;
            Update.Cursor = Cursors.Hand;
            Update.Location = new Point(563, 284);
            Update.Name = "Update";
            Update.OverrideDefault.Back.Color1 = Color.FromArgb(0, 179, 89);
            Update.OverrideDefault.Back.Color2 = Color.MediumSeaGreen;
            Update.Size = new Size(95, 33);
            Update.StateCommon.Back.Color1 = Color.FromArgb(0, 204, 102);
            Update.StateCommon.Back.Color2 = Color.FromArgb(0, 179, 89);
            Update.StateCommon.Back.ColorAngle = 25F;
            Update.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Update.StateCommon.Border.Rounding = 25F;
            Update.StateCommon.Content.ShortText.Color1 = Color.White;
            Update.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Update.StateTracking.Back.Color1 = Color.FromArgb(0, 179, 89);
            Update.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Update.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            Update.StateTracking.Border.Rounding = 25F;
            Update.TabIndex = 30;
            Update.TabStop = false;
            Update.Values.Text = "Update";
            Update.Click += Submit_Click;
            // 
            // MedName
            // 
            MedName.Cursor = Cursors.IBeam;
            MedName.Location = new Point(343, 114);
            MedName.Name = "MedName";
            MedName.Size = new Size(269, 28);
            MedName.StateCommon.Border.Color1 = Color.RoyalBlue;
            MedName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MedName.StateCommon.Border.Rounding = 10F;
            MedName.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            MedName.StateCommon.Content.Padding = new Padding(2);
            MedName.TabIndex = 45;
            MedName.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uguy;
            pictureBox1.Location = new Point(5, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 253);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(222, 202);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(64, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 43;
            kryptonLabel4.Values.Text = "Quantity";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(222, 172);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(84, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 42;
            kryptonLabel3.Values.Text = "Retail Price";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(221, 117);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(110, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 41;
            kryptonLabel2.Values.Text = "Medicine Name";
            // 
            // Remove
            // 
            Remove.CornerRoundingRadius = 25F;
            Remove.Cursor = Cursors.Hand;
            Remove.Location = new Point(459, 284);
            Remove.Name = "Remove";
            Remove.OverrideDefault.Back.Color1 = Color.Brown;
            Remove.OverrideDefault.Back.Color2 = Color.Firebrick;
            Remove.Size = new Size(95, 33);
            Remove.StateCommon.Back.Color1 = Color.Brown;
            Remove.StateCommon.Back.Color2 = Color.Firebrick;
            Remove.StateCommon.Back.ColorAngle = 5F;
            Remove.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Remove.StateCommon.Border.Rounding = 25F;
            Remove.StateCommon.Content.ShortText.Color1 = Color.White;
            Remove.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Remove.StateTracking.Back.Color1 = Color.Brown;
            Remove.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Remove.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            Remove.StateTracking.Border.Rounding = 25F;
            Remove.TabIndex = 52;
            Remove.TabStop = false;
            Remove.Values.Text = "Remove";
            Remove.Click += Remove_Click;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(348, 172);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(32, 19);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 53;
            kryptonLabel5.Values.Text = "Rs.";
            // 
            // Price
            // 
            Price.Location = new Point(373, 172);
            Price.Name = "Price";
            Price.Size = new Size(19, 19);
            Price.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Price.TabIndex = 54;
            Price.Values.Text = "2";
            // 
            // Qty
            // 
            Qty.Location = new Point(348, 202);
            Qty.Name = "Qty";
            Qty.Size = new Size(41, 19);
            Qty.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Qty.TabIndex = 55;
            Qty.Values.Text = "1250";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(381, 202);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(42, 19);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 56;
            kryptonLabel6.Values.Text = "Units";
            // 
            // EditMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(683, 341);
            Controls.Add(kryptonLabel6);
            Controls.Add(Qty);
            Controls.Add(Price);
            Controls.Add(kryptonLabel5);
            Controls.Add(Remove);
            Controls.Add(MedName);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(Update);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditMedicine";
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
        private Krypton.Toolkit.KryptonButton Update;
        private Krypton.Toolkit.KryptonTextBox MedName;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton Remove;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel Price;
        private Krypton.Toolkit.KryptonLabel Qty;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
    }
}