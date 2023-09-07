namespace HCplus.Forms
{
    partial class DoctorModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorModule));
            sidebar = new Krypton.Toolkit.KryptonPanel();
            label4 = new Label();
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
            Doctorlist = new Krypton.Toolkit.KryptonDataGridView();
            AddBtn = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            FilterAvailability = new ComboBox();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            FilterLocation = new ComboBox();
            FilterSpecial = new ComboBox();
            label1 = new Label();
            SearchFilter = new Krypton.Toolkit.KryptonButton();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            Refresh = new PictureBox();
            DocCount = new Label();
            label2 = new Label();
            FilterResult = new Label();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
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
            ((System.ComponentModel.ISupportInitialize)Doctorlist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Refresh).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebar.Controls.Add(label4);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(7, 156);
            label4.Name = "label4";
            label4.Size = new Size(71, 13);
            label4.TabIndex = 37;
            label4.Text = "Home Page";
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
            HomeBtn.TabIndex = 36;
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
            ClinicBtn.Location = new Point(26, 470);
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
            RoomBtn.Location = new Point(26, 408);
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
            MedBtn.Location = new Point(26, 345);
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
            ResourcesBtn.Location = new Point(26, 280);
            ResourcesBtn.Name = "ResourcesBtn";
            ResourcesBtn.Size = new Size(28, 28);
            ResourcesBtn.SizeMode = PictureBoxSizeMode.Zoom;
            ResourcesBtn.TabIndex = 4;
            ResourcesBtn.TabStop = false;
            ResourcesBtn.Click += ResourcesBtn_Click;
            // 
            // DoctorBtn
            // 
            DoctorBtn.BackColor = Color.Transparent;
            DoctorBtn.Cursor = Cursors.Hand;
            DoctorBtn.Image = Properties.Resources.icons8_doctor_50;
            DoctorBtn.Location = new Point(26, 222);
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
            lblTitle.Size = new Size(156, 21);
            lblTitle.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "Doctor Management";
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
            // Doctorlist
            // 
            Doctorlist.AllowUserToOrderColumns = true;
            Doctorlist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Doctorlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Doctorlist.ColumnHeadersHeight = 28;
            Doctorlist.Cursor = Cursors.Hand;
            Doctorlist.GridStyles.Style = Krypton.Toolkit.DataGridViewStyle.Mixed;
            Doctorlist.GridStyles.StyleBackground = Krypton.Toolkit.PaletteBackStyle.GridDataCellSheet;
            Doctorlist.GridStyles.StyleColumn = Krypton.Toolkit.GridStyle.Sheet;
            Doctorlist.GridStyles.StyleDataCells = Krypton.Toolkit.GridStyle.Sheet;
            Doctorlist.GridStyles.StyleRow = Krypton.Toolkit.GridStyle.Sheet;
            Doctorlist.Location = new Point(133, 335);
            Doctorlist.MultiSelect = false;
            Doctorlist.Name = "Doctorlist";
            Doctorlist.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            Doctorlist.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            Doctorlist.RowsDefaultCellStyle = dataGridViewCellStyle1;
            Doctorlist.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            Doctorlist.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Doctorlist.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            Doctorlist.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            Doctorlist.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gray;
            Doctorlist.RowTemplate.Height = 35;
            Doctorlist.RowTemplate.ReadOnly = true;
            Doctorlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Doctorlist.Size = new Size(1186, 350);
            Doctorlist.StateCommon.Background.Color1 = Color.FromArgb(242, 242, 242);
            Doctorlist.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridDataCellSheet;
            Doctorlist.StateCommon.DataCell.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            Doctorlist.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Doctorlist.StateCommon.HeaderRow.Content.Color1 = Color.White;
            Doctorlist.StateCommon.HeaderRow.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Doctorlist.StateSelected.DataCell.Back.Color1 = Color.Silver;
            Doctorlist.StateSelected.DataCell.Back.Color2 = Color.Silver;
            Doctorlist.StateSelected.HeaderColumn.Back.Color1 = Color.Silver;
            Doctorlist.StateSelected.HeaderColumn.Back.Color2 = Color.Silver;
            Doctorlist.StateSelected.HeaderColumn.Border.Color1 = Color.Silver;
            Doctorlist.StateSelected.HeaderColumn.Border.Color2 = Color.Silver;
            Doctorlist.StateSelected.HeaderColumn.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Doctorlist.StateSelected.HeaderColumn.Content.Color1 = Color.FromArgb(224, 224, 224);
            Doctorlist.StateSelected.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            Doctorlist.StateSelected.HeaderRow.Back.Color1 = Color.Silver;
            Doctorlist.StateSelected.HeaderRow.Back.Color2 = Color.Silver;
            Doctorlist.StateSelected.HeaderRow.Content.Color1 = Color.Silver;
            Doctorlist.StateSelected.HeaderRow.Content.Color2 = Color.Silver;
            Doctorlist.TabIndex = 9;
            Doctorlist.TabStop = false;
            Doctorlist.CellClick += Doctorlist_CellClick;
            // 
            // AddBtn
            // 
            AddBtn.CornerRoundingRadius = 25F;
            AddBtn.Location = new Point(1225, 63);
            AddBtn.Name = "AddBtn";
            AddBtn.OverrideDefault.Back.Color1 = Color.FromArgb(0, 91, 150);
            AddBtn.OverrideDefault.Back.Color2 = Color.FromArgb(0, 91, 150);
            AddBtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AddBtn.OverrideDefault.Border.Rounding = 25F;
            AddBtn.OverrideDefault.Content.ShortText.Color1 = Color.White;
            AddBtn.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.Size = new Size(116, 33);
            AddBtn.StateCommon.Back.Color1 = Color.FromArgb(0, 91, 150);
            AddBtn.StateCommon.Back.Color2 = Color.FromArgb(0, 91, 150);
            AddBtn.StateCommon.Back.ColorAngle = 25F;
            AddBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AddBtn.StateCommon.Border.Rounding = 25F;
            AddBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            AddBtn.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.StateTracking.Back.Color1 = Color.MidnightBlue;
            AddBtn.StateTracking.Back.Color2 = Color.RoyalBlue;
            AddBtn.StateTracking.Back.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            AddBtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AddBtn.StateTracking.Border.Rounding = 25F;
            AddBtn.StateTracking.Content.ShortText.Color1 = Color.White;
            AddBtn.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.TabIndex = 10;
            AddBtn.Values.Text = "Add Doctor";
            AddBtn.Click += AddBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(135, 307);
            label3.Name = "label3";
            label3.Size = new Size(128, 16);
            label3.TabIndex = 17;
            label3.Text = "Filter Results By  ";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel4);
            kryptonPanel1.Controls.Add(kryptonPanel2);
            kryptonPanel1.Controls.Add(FilterSpecial);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(SearchFilter);
            kryptonPanel1.Controls.Add(kryptonPanel3);
            kryptonPanel1.Location = new Point(135, 123);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1164, 104);
            kryptonPanel1.StateCommon.Color1 = Color.Gainsboro;
            kryptonPanel1.TabIndex = 18;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(FilterAvailability);
            kryptonPanel4.Cursor = Cursors.Hand;
            kryptonPanel4.Location = new Point(244, 53);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(180, 36);
            kryptonPanel4.StateCommon.Color1 = Color.White;
            kryptonPanel4.TabIndex = 25;
            // 
            // FilterAvailability
            // 
            FilterAvailability.DropDownHeight = 150;
            FilterAvailability.FlatStyle = FlatStyle.Flat;
            FilterAvailability.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FilterAvailability.FormattingEnabled = true;
            FilterAvailability.IntegralHeight = false;
            FilterAvailability.ItemHeight = 16;
            FilterAvailability.Items.AddRange(new object[] { "All", "On Clinic", "Off Clinic" });
            FilterAvailability.Location = new Point(3, 6);
            FilterAvailability.Name = "FilterAvailability";
            FilterAvailability.Size = new Size(174, 24);
            FilterAvailability.TabIndex = 25;
            FilterAvailability.TabStop = false;
            FilterAvailability.Text = "Availability";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(FilterLocation);
            kryptonPanel2.Cursor = Cursors.Hand;
            kryptonPanel2.Location = new Point(458, 53);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(249, 36);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.TabIndex = 23;
            // 
            // FilterLocation
            // 
            FilterLocation.DropDownHeight = 150;
            FilterLocation.FlatStyle = FlatStyle.Flat;
            FilterLocation.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FilterLocation.FormattingEnabled = true;
            FilterLocation.IntegralHeight = false;
            FilterLocation.ItemHeight = 16;
            FilterLocation.Items.AddRange(new object[] { "All", "On Clinic", "Off Clinic" });
            FilterLocation.Location = new Point(3, 6);
            FilterLocation.Name = "FilterLocation";
            FilterLocation.Size = new Size(243, 24);
            FilterLocation.TabIndex = 26;
            FilterLocation.TabStop = false;
            FilterLocation.Text = "Location2";
            // 
            // FilterSpecial
            // 
            FilterSpecial.DropDownHeight = 150;
            FilterSpecial.FlatStyle = FlatStyle.Flat;
            FilterSpecial.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FilterSpecial.FormattingEnabled = true;
            FilterSpecial.IntegralHeight = false;
            FilterSpecial.ItemHeight = 16;
            FilterSpecial.Items.AddRange(new object[] { "All", "Internal Medicine", "Cardiology", "Pediatrics", "Surgery", "Gynecology", "Dermatology", "Neurology", "Ophthalmology", "Psychiatry" });
            FilterSpecial.Location = new Point(20, 59);
            FilterSpecial.Name = "FilterSpecial";
            FilterSpecial.Size = new Size(190, 24);
            FilterSpecial.TabIndex = 22;
            FilterSpecial.TabStop = false;
            FilterSpecial.Text = "Speciality";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(135, 16);
            label1.TabIndex = 20;
            label1.Text = "Search Doctors   -:";
            // 
            // SearchFilter
            // 
            SearchFilter.CornerRoundingRadius = 25F;
            SearchFilter.Location = new Point(727, 53);
            SearchFilter.Name = "SearchFilter";
            SearchFilter.OverrideDefault.Back.Color1 = Color.DodgerBlue;
            SearchFilter.OverrideDefault.Back.Color2 = Color.RoyalBlue;
            SearchFilter.Size = new Size(104, 36);
            SearchFilter.StateCommon.Back.Color1 = Color.DodgerBlue;
            SearchFilter.StateCommon.Back.Color2 = Color.RoyalBlue;
            SearchFilter.StateCommon.Border.Color1 = Color.DodgerBlue;
            SearchFilter.StateCommon.Border.Color2 = Color.RoyalBlue;
            SearchFilter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchFilter.StateCommon.Border.Rounding = 25F;
            SearchFilter.StateCommon.Content.ShortText.Color1 = Color.White;
            SearchFilter.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            SearchFilter.TabIndex = 3;
            SearchFilter.Values.Text = "Search";
            SearchFilter.Click += SearchFilter_Click;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Cursor = Cursors.Hand;
            kryptonPanel3.Location = new Point(17, 53);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(196, 36);
            kryptonPanel3.StateCommon.Color1 = Color.White;
            kryptonPanel3.TabIndex = 24;
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.Transparent;
            Refresh.Image = Properties.Resources.icons8_refresh_32;
            Refresh.Location = new Point(1304, 314);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(15, 15);
            Refresh.SizeMode = PictureBoxSizeMode.Zoom;
            Refresh.TabIndex = 22;
            Refresh.TabStop = false;
            Refresh.Click += Refresh_Click;
            // 
            // DocCount
            // 
            DocCount.AutoSize = true;
            DocCount.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DocCount.ForeColor = Color.DimGray;
            DocCount.Location = new Point(249, 283);
            DocCount.Name = "DocCount";
            DocCount.Size = new Size(23, 16);
            DocCount.TabIndex = 20;
            DocCount.Text = "10";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(133, 283);
            label2.Name = "label2";
            label2.Size = new Size(109, 16);
            label2.TabIndex = 19;
            label2.Text = "Total Doctors :";
            // 
            // FilterResult
            // 
            FilterResult.AutoSize = true;
            FilterResult.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FilterResult.ForeColor = Color.MidnightBlue;
            FilterResult.Location = new Point(260, 307);
            FilterResult.Name = "FilterResult";
            FilterResult.Size = new Size(44, 16);
            FilterResult.TabIndex = 21;
            FilterResult.Text = "None";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(593, 257);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(266, 24);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 2;
            kryptonLabel1.Values.Text = "Registered Doctor's Detals List";
            // 
            // DoctorModule
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(4, 20);
            BackColor = Color.White;
            ClientSize = new Size(1366, 702);
            Controls.Add(kryptonLabel1);
            Controls.Add(Refresh);
            Controls.Add(FilterResult);
            Controls.Add(DocCount);
            Controls.Add(label2);
            Controls.Add(kryptonPanel1);
            Controls.Add(label3);
            Controls.Add(AddBtn);
            Controls.Add(Doctorlist);
            Controls.Add(HomeLogo);
            Controls.Add(sidebar);
            Controls.Add(header);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "DoctorModule";
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
            ((System.ComponentModel.ISupportInitialize)Doctorlist).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Refresh).EndInit();
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
        private Krypton.Toolkit.KryptonDataGridView Doctorlist;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Label UserType;
        private Label DoctorLbl;
        private Label ClinicLbl;
        private Label RoomLbl;
        private Label MedLbl;
        private Label ResourcesLbl;
        private Krypton.Toolkit.KryptonButton AddBtn;
        private Label label3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Label DocCount;
        private Label label2;
        private Label FilterResult;
        private Label label1;
        private Krypton.Toolkit.KryptonButton SearchFilter;
        private ComboBox FilterSpecial;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComboBox FilterAvailability;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComboBox FilterLocation;
        private PictureBox Refresh;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Label label4;
        private PictureBox HomeBtn;
    }
}