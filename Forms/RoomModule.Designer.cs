namespace HCplus.Forms
{
    partial class RoomModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomModule));
            sidebar = new Krypton.Toolkit.KryptonPanel();
            label2 = new Label();
            HomeBtn = new PictureBox();
            ClinicLbl = new Label();
            RoomLbl = new Label();
            MedLbl = new Label();
            ResourcesLbl = new Label();
            DoctorLbl = new Label();
            ClinicBtn = new PictureBox();
            RoomBtn = new PictureBox();
            MedBtn = new PictureBox();
            ResourcesBtn = new PictureBox();
            DoctorBtn = new PictureBox();
            header = new Krypton.Toolkit.KryptonPanel();
            UserType = new Label();
            lblTitle = new Krypton.Toolkit.KryptonLabel();
            HomeLogo = new PictureBox();
            Datalist = new Krypton.Toolkit.KryptonDataGridView();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            FilterResult = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)sidebar).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClinicBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RoomBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MedBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResourcesBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DoctorBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)header).BeginInit();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomeLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Datalist).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebar.Controls.Add(label2);
            sidebar.Controls.Add(HomeBtn);
            sidebar.Controls.Add(ClinicLbl);
            sidebar.Controls.Add(RoomLbl);
            sidebar.Controls.Add(MedLbl);
            sidebar.Controls.Add(ResourcesLbl);
            sidebar.Controls.Add(DoctorLbl);
            sidebar.Controls.Add(ClinicBtn);
            sidebar.Controls.Add(RoomBtn);
            sidebar.Controls.Add(MedBtn);
            sidebar.Controls.Add(ResourcesBtn);
            sidebar.Controls.Add(DoctorBtn);
            sidebar.Location = new Point(-1, -2);
            sidebar.Name = "sidebar";
            sidebar.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.ContextMenuHeading;
            sidebar.Size = new Size(82, 705);
            sidebar.StateCommon.Color1 = Color.DodgerBlue;
            sidebar.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 156);
            label2.Name = "label2";
            label2.Size = new Size(71, 13);
            label2.TabIndex = 23;
            label2.Text = "Home Page";
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.Transparent;
            HomeBtn.Cursor = Cursors.Hand;
            HomeBtn.Image = Properties.Resources.icons8_users_50;
            HomeBtn.Location = new Point(26, 125);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(30, 30);
            HomeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            HomeBtn.TabIndex = 22;
            HomeBtn.TabStop = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // ClinicLbl
            // 
            ClinicLbl.AutoSize = true;
            ClinicLbl.BackColor = Color.Transparent;
            ClinicLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            ClinicLbl.ForeColor = SystemColors.Control;
            ClinicLbl.Location = new Point(20, 500);
            ClinicLbl.Name = "ClinicLbl";
            ClinicLbl.Size = new Size(43, 13);
            ClinicLbl.TabIndex = 16;
            ClinicLbl.Text = "Clinics";
            // 
            // RoomLbl
            // 
            RoomLbl.AutoSize = true;
            RoomLbl.BackColor = Color.Transparent;
            RoomLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            RoomLbl.ForeColor = SystemColors.Control;
            RoomLbl.Location = new Point(20, 436);
            RoomLbl.Name = "RoomLbl";
            RoomLbl.Size = new Size(44, 13);
            RoomLbl.TabIndex = 15;
            RoomLbl.Text = "Rooms";
            // 
            // MedLbl
            // 
            MedLbl.AutoSize = true;
            MedLbl.BackColor = Color.Transparent;
            MedLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            MedLbl.ForeColor = SystemColors.Control;
            MedLbl.Location = new Point(10, 374);
            MedLbl.Name = "MedLbl";
            MedLbl.Size = new Size(63, 13);
            MedLbl.TabIndex = 14;
            MedLbl.Text = "Medicines";
            // 
            // ResourcesLbl
            // 
            ResourcesLbl.AutoSize = true;
            ResourcesLbl.BackColor = Color.Transparent;
            ResourcesLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            ResourcesLbl.ForeColor = SystemColors.Control;
            ResourcesLbl.Location = new Point(9, 308);
            ResourcesLbl.Name = "ResourcesLbl";
            ResourcesLbl.Size = new Size(65, 13);
            ResourcesLbl.TabIndex = 13;
            ResourcesLbl.Text = "Resources";
            // 
            // DoctorLbl
            // 
            DoctorLbl.AutoSize = true;
            DoctorLbl.BackColor = Color.Transparent;
            DoctorLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            DoctorLbl.ForeColor = SystemColors.Control;
            DoctorLbl.Location = new Point(20, 251);
            DoctorLbl.Name = "DoctorLbl";
            DoctorLbl.Size = new Size(44, 13);
            DoctorLbl.TabIndex = 12;
            DoctorLbl.Text = "Doctor";
            // 
            // ClinicBtn
            // 
            ClinicBtn.BackColor = Color.Transparent;
            ClinicBtn.Cursor = Cursors.Hand;
            ClinicBtn.Image = Properties.Resources.icons8_schedule_50;
            ClinicBtn.Location = new Point(28, 470);
            ClinicBtn.Name = "ClinicBtn";
            ClinicBtn.Size = new Size(28, 28);
            ClinicBtn.SizeMode = PictureBoxSizeMode.Zoom;
            ClinicBtn.TabIndex = 7;
            ClinicBtn.TabStop = false;
            ClinicBtn.Click += ClinicBtn_Click;
            // 
            // RoomBtn
            // 
            RoomBtn.BackColor = Color.Transparent;
            RoomBtn.Cursor = Cursors.Hand;
            RoomBtn.Image = Properties.Resources.icons8_hospital_64__2_;
            RoomBtn.Location = new Point(28, 408);
            RoomBtn.Name = "RoomBtn";
            RoomBtn.Size = new Size(28, 28);
            RoomBtn.SizeMode = PictureBoxSizeMode.Zoom;
            RoomBtn.TabIndex = 6;
            RoomBtn.TabStop = false;
            RoomBtn.Click += RoomBtn_Click;
            // 
            // MedBtn
            // 
            MedBtn.BackColor = Color.Transparent;
            MedBtn.Cursor = Cursors.Hand;
            MedBtn.Image = Properties.Resources.icons8_blister_pack_50;
            MedBtn.Location = new Point(28, 345);
            MedBtn.Name = "MedBtn";
            MedBtn.Size = new Size(28, 28);
            MedBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MedBtn.TabIndex = 5;
            MedBtn.TabStop = false;
            MedBtn.Click += MedBtn_Click;
            // 
            // ResourcesBtn
            // 
            ResourcesBtn.BackColor = Color.Transparent;
            ResourcesBtn.Cursor = Cursors.Hand;
            ResourcesBtn.Image = Properties.Resources.icons8_item_48;
            ResourcesBtn.Location = new Point(28, 280);
            ResourcesBtn.Name = "ResourcesBtn";
            ResourcesBtn.Size = new Size(28, 28);
            ResourcesBtn.SizeMode = PictureBoxSizeMode.Zoom;
            ResourcesBtn.TabIndex = 4;
            ResourcesBtn.TabStop = false;
            // 
            // DoctorBtn
            // 
            DoctorBtn.BackColor = Color.Transparent;
            DoctorBtn.Cursor = Cursors.Hand;
            DoctorBtn.Image = Properties.Resources.icons8_doctor_50;
            DoctorBtn.Location = new Point(28, 222);
            DoctorBtn.Name = "DoctorBtn";
            DoctorBtn.Size = new Size(28, 28);
            DoctorBtn.SizeMode = PictureBoxSizeMode.Zoom;
            DoctorBtn.TabIndex = 3;
            DoctorBtn.TabStop = false;
            DoctorBtn.Click += DoctorBtn_Click;
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
            UserType.Location = new Point(1296, 11);
            UserType.Name = "UserType";
            UserType.Size = new Size(59, 18);
            UserType.TabIndex = 1;
            UserType.Text = "Admin";
            UserType.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(124, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(218, 21);
            lblTitle.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "Hospital Room  Management";
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
            // Datalist
            // 
            Datalist.AllowUserToOrderColumns = true;
            Datalist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Datalist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Datalist.ColumnHeadersHeight = 28;
            Datalist.Cursor = Cursors.Hand;
            Datalist.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            Datalist.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridDataCellSheet;
            Datalist.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            Datalist.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            Datalist.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            Datalist.Location = new Point(123, 167);
            Datalist.MultiSelect = false;
            Datalist.Name = "Datalist";
            Datalist.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            Datalist.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            Datalist.RowsDefaultCellStyle = dataGridViewCellStyle1;
            Datalist.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            Datalist.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Datalist.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            Datalist.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            Datalist.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gray;
            Datalist.RowTemplate.Height = 35;
            Datalist.RowTemplate.ReadOnly = true;
            Datalist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Datalist.Size = new Size(1186, 506);
            Datalist.StateCommon.Background.Color1 = Color.FromArgb(242, 242, 242);
            Datalist.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridDataCellSheet;
            Datalist.StateCommon.DataCell.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            Datalist.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Datalist.StateCommon.HeaderRow.Content.Color1 = Color.White;
            Datalist.StateCommon.HeaderRow.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Datalist.StateSelected.DataCell.Back.Color1 = Color.Silver;
            Datalist.StateSelected.DataCell.Back.Color2 = Color.Silver;
            Datalist.StateSelected.HeaderColumn.Back.Color1 = Color.Silver;
            Datalist.StateSelected.HeaderColumn.Back.Color2 = Color.Silver;
            Datalist.StateSelected.HeaderColumn.Border.Color1 = Color.Silver;
            Datalist.StateSelected.HeaderColumn.Border.Color2 = Color.Silver;
            Datalist.StateSelected.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Datalist.StateSelected.HeaderColumn.Content.Color1 = Color.FromArgb(224, 224, 224);
            Datalist.StateSelected.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            Datalist.StateSelected.HeaderRow.Back.Color1 = Color.Silver;
            Datalist.StateSelected.HeaderRow.Back.Color2 = Color.Silver;
            Datalist.StateSelected.HeaderRow.Content.Color1 = Color.Silver;
            Datalist.StateSelected.HeaderRow.Content.Color2 = Color.Silver;
            Datalist.TabIndex = 9;
            Datalist.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(592, 95);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(239, 24);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Hospitals Room List Details";
            // 
            // FilterResult
            // 
            FilterResult.AutoSize = true;
            FilterResult.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FilterResult.ForeColor = Color.MidnightBlue;
            FilterResult.Location = new Point(228, 138);
            FilterResult.Name = "FilterResult";
            FilterResult.Size = new Size(23, 16);
            FilterResult.TabIndex = 21;
            FilterResult.Text = "10";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(125, 137);
            label3.Name = "label3";
            label3.Size = new Size(104, 16);
            label3.TabIndex = 17;
            label3.Text = "Total Rooms :";
            // 
            // RoomModule
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(4, 20);
            BackColor = Color.White;
            ClientSize = new Size(1366, 702);
            Controls.Add(kryptonLabel1);
            Controls.Add(FilterResult);
            Controls.Add(label3);
            Controls.Add(Datalist);
            Controls.Add(HomeLogo);
            Controls.Add(sidebar);
            Controls.Add(header);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "RoomModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Healthcare Plus Dashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)sidebar).EndInit();
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClinicBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)RoomBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)MedBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResourcesBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)DoctorBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)header).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomeLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)Datalist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel sidebar;
        private Krypton.Toolkit.KryptonPanel header;
        private PictureBox MedBtn;
        private PictureBox ResourcesBtn;
        private PictureBox DoctorBtn;
        private PictureBox ClinicBtn;
        private PictureBox RoomBtn;
        private PictureBox HomeLogo;
        private Krypton.Toolkit.KryptonDataGridView Datalist;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Label UserType;
        private Label DoctorLbl;
        private Label ClinicLbl;
        private Label RoomLbl;
        private Label MedLbl;
        private Label ResourcesLbl;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Label FilterResult;
        private Label label3;
        private Label label2;
        private PictureBox HomeBtn;
    }
}