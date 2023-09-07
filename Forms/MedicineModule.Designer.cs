namespace HCplus.Forms
{
    partial class MedicineModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineModule));
            sidebar = new Krypton.Toolkit.KryptonPanel();
            label6 = new Label();
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
            DataList = new Krypton.Toolkit.KryptonDataGridView();
            DocCount = new Label();
            label2 = new Label();
            SearchFilter = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            Qty = new Krypton.Toolkit.KryptonNumericUpDown();
            label5 = new Label();
            label4 = new Label();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            Price = new Krypton.Toolkit.KryptonNumericUpDown();
            label3 = new Label();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            MedName = new Krypton.Toolkit.KryptonTextBox();
            Refresh = new PictureBox();
            AddBtn = new Krypton.Toolkit.KryptonButton();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)DataList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebar.Controls.Add(label6);
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
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(7, 156);
            label6.Name = "label6";
            label6.Size = new Size(71, 13);
            label6.TabIndex = 37;
            label6.Text = "Home Page";
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
            ClinicLbl.Location = new Point(19, 500);
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
            lblTitle.Size = new Size(173, 21);
            lblTitle.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "Medicine Management";
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
            DataList.Location = new Point(143, 180);
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
            DataList.Size = new Size(450, 500);
            DataList.StateCommon.Background.Color1 = Color.White;
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
            DataList.TabIndex = 9;
            DataList.TabStop = false;
            DataList.CellClick += DataList_CellClick;
            // 
            // DocCount
            // 
            DocCount.AutoSize = true;
            DocCount.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DocCount.ForeColor = Color.DimGray;
            DocCount.Location = new Point(306, 149);
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
            label2.Location = new Point(140, 149);
            label2.Name = "label2";
            label2.Size = new Size(166, 16);
            label2.TabIndex = 19;
            label2.Text = "Total Medicine Types :";
            // 
            // SearchFilter
            // 
            SearchFilter.CornerRoundingRadius = 25F;
            SearchFilter.Location = new Point(187, 220);
            SearchFilter.Name = "SearchFilter";
            SearchFilter.OverrideDefault.Back.Color1 = Color.DodgerBlue;
            SearchFilter.OverrideDefault.Back.Color2 = Color.RoyalBlue;
            SearchFilter.Size = new Size(147, 36);
            SearchFilter.StateCommon.Back.Color1 = Color.DodgerBlue;
            SearchFilter.StateCommon.Back.Color2 = Color.RoyalBlue;
            SearchFilter.StateCommon.Border.Color1 = Color.DodgerBlue;
            SearchFilter.StateCommon.Border.Color2 = Color.RoyalBlue;
            SearchFilter.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchFilter.StateCommon.Border.Rounding = 25F;
            SearchFilter.StateCommon.Content.ShortText.Color1 = Color.White;
            SearchFilter.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            SearchFilter.TabIndex = 3;
            SearchFilter.Values.Text = "Update Medicine";
            SearchFilter.Click += SearchFilter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(147, 12);
            label1.Name = "label1";
            label1.Size = new Size(255, 16);
            label1.TabIndex = 20;
            label1.Text = "Update Medicine Price and Quantity";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel4);
            kryptonPanel1.Controls.Add(label5);
            kryptonPanel1.Controls.Add(label4);
            kryptonPanel1.Controls.Add(kryptonPanel3);
            kryptonPanel1.Controls.Add(label3);
            kryptonPanel1.Controls.Add(kryptonPanel2);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(SearchFilter);
            kryptonPanel1.Location = new Point(682, 173);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(504, 275);
            kryptonPanel1.StateCommon.Color1 = Color.Gainsboro;
            kryptonPanel1.TabIndex = 18;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(Qty);
            kryptonPanel4.Location = new Point(261, 156);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(195, 35);
            kryptonPanel4.StateCommon.Color1 = Color.White;
            kryptonPanel4.TabIndex = 25;
            // 
            // Qty
            // 
            Qty.Location = new Point(0, 5);
            Qty.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            Qty.Name = "Qty";
            Qty.Size = new Size(195, 26);
            Qty.StateCommon.Border.Color1 = Color.White;
            Qty.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Qty.StateCommon.Border.Rounding = 10F;
            Qty.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Qty.StateCommon.Content.Padding = new Padding(1);
            Qty.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(262, 130);
            label5.Name = "label5";
            label5.Size = new Size(55, 16);
            label5.TabIndex = 24;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(20, 52);
            label4.Name = "label4";
            label4.Size = new Size(114, 16);
            label4.TabIndex = 24;
            label4.Text = "Select a Medicine";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(Price);
            kryptonPanel3.Location = new Point(19, 156);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(201, 35);
            kryptonPanel3.StateCommon.Color1 = Color.White;
            kryptonPanel3.TabIndex = 23;
            // 
            // Price
            // 
            Price.Location = new Point(2, 5);
            Price.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Price.Name = "Price";
            Price.Size = new Size(199, 26);
            Price.StateCommon.Border.Color1 = Color.White;
            Price.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Price.StateCommon.Border.Rounding = 10F;
            Price.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Price.StateCommon.Content.Padding = new Padding(1);
            Price.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(20, 130);
            label3.Name = "label3";
            label3.Size = new Size(99, 16);
            label3.TabIndex = 22;
            label3.Text = "New Price (Rs.)";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(MedName);
            kryptonPanel2.Location = new Point(20, 78);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(260, 35);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.TabIndex = 21;
            // 
            // MedName
            // 
            MedName.AutoCompleteMode = AutoCompleteMode.Suggest;
            MedName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            MedName.Location = new Point(3, 0);
            MedName.Name = "MedName";
            MedName.Size = new Size(254, 34);
            MedName.StateCommon.Border.Color1 = Color.White;
            MedName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            MedName.StateCommon.Border.Rounding = 15F;
            MedName.TabIndex = 0;
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.Transparent;
            Refresh.Image = Properties.Resources.icons8_refresh_32;
            Refresh.Location = new Point(578, 149);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(15, 15);
            Refresh.SizeMode = PictureBoxSizeMode.Zoom;
            Refresh.TabIndex = 22;
            Refresh.TabStop = false;
            Refresh.Click += Refresh_Click;
            // 
            // AddBtn
            // 
            AddBtn.CornerRoundingRadius = 25F;
            AddBtn.Location = new Point(1197, 63);
            AddBtn.Name = "AddBtn";
            AddBtn.OverrideDefault.Back.Color1 = Color.FromArgb(0, 91, 150);
            AddBtn.OverrideDefault.Back.Color2 = Color.FromArgb(0, 91, 150);
            AddBtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AddBtn.OverrideDefault.Border.Rounding = 25F;
            AddBtn.OverrideDefault.Content.ShortText.Color1 = Color.White;
            AddBtn.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.Size = new Size(144, 33);
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
            AddBtn.Values.Text = "Add a Medicine";
            AddBtn.Click += AddBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Free_Vector___Medicine_concept_illustration2;
            pictureBox1.Location = new Point(1038, 427);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(230, 107);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(183, 24);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 24;
            kryptonLabel1.Values.Text = "Medicine List Details";
            // 
            // MedicineModule
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(4, 20);
            BackColor = Color.White;
            ClientSize = new Size(1366, 702);
            Controls.Add(kryptonLabel1);
            Controls.Add(Refresh);
            Controls.Add(DocCount);
            Controls.Add(label2);
            Controls.Add(kryptonPanel1);
            Controls.Add(AddBtn);
            Controls.Add(DataList);
            Controls.Add(HomeLogo);
            Controls.Add(sidebar);
            Controls.Add(header);
            Controls.Add(pictureBox1);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MedicineModule";
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
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Krypton.Toolkit.KryptonDataGridView DataList;
        private Krypton.Toolkit.KryptonLabel lblTitle;
        private Label UserType;
        private Label DoctorLbl;
        private Label ClinicLbl;
        private Label RoomLbl;
        private Label MedLbl;
        private Label ResourcesLbl;
        private Label DocCount;
        private Label label2;
        private Krypton.Toolkit.KryptonButton SearchFilter;
        private Label label1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private PictureBox Refresh;
        private Krypton.Toolkit.KryptonButton AddBtn;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonTextBox MedName;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Label label5;
        private Label label4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Label label3;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonNumericUpDown Qty;
        private Krypton.Toolkit.KryptonNumericUpDown Price;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Label label6;
        private PictureBox HomeBtn;
    }
}