using Krypton.Toolkit;

namespace HCplus.Forms
{
    partial class DiagnoseModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnoseModule));
            sidebar = new KryptonPanel();
            PatientListLbl = new Label();
            PatientListBtn = new PictureBox();
            homeLbl = new Label();
            HomeBtn = new PictureBox();
            AppointmentLbl = new Label();
            PatientLbl = new Label();
            PaymentLbl = new Label();
            PaymentBtn = new PictureBox();
            DiagnoseBtn = new PictureBox();
            PatientBtn = new PictureBox();
            header = new KryptonPanel();
            UserType = new Label();
            lblTitle = new KryptonLabel();
            HomeLogo = new PictureBox();
            kryptonLabel1 = new KryptonLabel();
            DataList = new KryptonDataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)sidebar).BeginInit();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientListBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaymentBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DiagnoseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PatientBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)header).BeginInit();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomeLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sidebar.Controls.Add(PatientListLbl);
            sidebar.Controls.Add(PatientListBtn);
            sidebar.Controls.Add(homeLbl);
            sidebar.Controls.Add(HomeBtn);
            sidebar.Controls.Add(AppointmentLbl);
            sidebar.Controls.Add(PatientLbl);
            sidebar.Controls.Add(PaymentLbl);
            sidebar.Controls.Add(PaymentBtn);
            sidebar.Controls.Add(DiagnoseBtn);
            sidebar.Controls.Add(PatientBtn);
            sidebar.Location = new Point(-1, -2);
            sidebar.Name = "sidebar";
            sidebar.PanelBackStyle = PaletteBackStyle.ContextMenuHeading;
            sidebar.Size = new Size(82, 705);
            sidebar.StateCommon.Color1 = Color.DodgerBlue;
            sidebar.TabIndex = 0;
            // 
            // PatientListLbl
            // 
            PatientListLbl.AutoSize = true;
            PatientListLbl.BackColor = Color.Transparent;
            PatientListLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            PatientListLbl.ForeColor = SystemColors.Control;
            PatientListLbl.Location = new Point(15, 313);
            PatientListLbl.Name = "PatientListLbl";
            PatientListLbl.Size = new Size(53, 13);
            PatientListLbl.TabIndex = 23;
            PatientListLbl.Text = "Patients";
            // 
            // PatientListBtn
            // 
            PatientListBtn.BackColor = Color.Transparent;
            PatientListBtn.Cursor = Cursors.Hand;
            PatientListBtn.Image = Properties.Resources.icons8_users_50;
            PatientListBtn.Location = new Point(28, 286);
            PatientListBtn.Name = "PatientListBtn";
            PatientListBtn.Size = new Size(28, 28);
            PatientListBtn.SizeMode = PictureBoxSizeMode.Zoom;
            PatientListBtn.TabIndex = 22;
            PatientListBtn.TabStop = false;
            PatientListBtn.Click += PatientListBtn_Click;
            // 
            // homeLbl
            // 
            homeLbl.AutoSize = true;
            homeLbl.BackColor = Color.Transparent;
            homeLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            homeLbl.ForeColor = SystemColors.Control;
            homeLbl.Location = new Point(7, 156);
            homeLbl.Name = "homeLbl";
            homeLbl.Size = new Size(71, 13);
            homeLbl.TabIndex = 21;
            homeLbl.Text = "Home Page";
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
            HomeBtn.TabIndex = 20;
            HomeBtn.TabStop = false;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // AppointmentLbl
            // 
            AppointmentLbl.AutoSize = true;
            AppointmentLbl.BackColor = Color.Transparent;
            AppointmentLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            AppointmentLbl.ForeColor = SystemColors.Control;
            AppointmentLbl.Location = new Point(11, 375);
            AppointmentLbl.Name = "AppointmentLbl";
            AppointmentLbl.Size = new Size(60, 13);
            AppointmentLbl.TabIndex = 19;
            AppointmentLbl.Text = "Diagnose";
            // 
            // PatientLbl
            // 
            PatientLbl.AutoSize = true;
            PatientLbl.BackColor = Color.Transparent;
            PatientLbl.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Bold, GraphicsUnit.Point);
            PatientLbl.ForeColor = SystemColors.Control;
            PatientLbl.Location = new Point(5, 259);
            PatientLbl.Name = "PatientLbl";
            PatientLbl.Size = new Size(75, 12);
            PatientLbl.TabIndex = 18;
            PatientLbl.Text = "Appointments";
            // 
            // PaymentLbl
            // 
            PaymentLbl.AutoSize = true;
            PaymentLbl.BackColor = Color.Transparent;
            PaymentLbl.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            PaymentLbl.ForeColor = SystemColors.Control;
            PaymentLbl.Location = new Point(10, 438);
            PaymentLbl.Name = "PaymentLbl";
            PaymentLbl.Size = new Size(61, 13);
            PaymentLbl.TabIndex = 17;
            PaymentLbl.Text = "Payments";
            // 
            // PaymentBtn
            // 
            PaymentBtn.BackColor = Color.Transparent;
            PaymentBtn.Cursor = Cursors.Hand;
            PaymentBtn.Image = Properties.Resources.icons8_money_50;
            PaymentBtn.Location = new Point(28, 410);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Size = new Size(28, 28);
            PaymentBtn.SizeMode = PictureBoxSizeMode.Zoom;
            PaymentBtn.TabIndex = 10;
            PaymentBtn.TabStop = false;
            PaymentBtn.Click += PaymentBtn_Click;
            // 
            // DiagnoseBtn
            // 
            DiagnoseBtn.BackColor = Color.Transparent;
            DiagnoseBtn.Cursor = Cursors.Hand;
            DiagnoseBtn.Image = Properties.Resources.icons8_moleskine_48;
            DiagnoseBtn.Location = new Point(28, 347);
            DiagnoseBtn.Name = "DiagnoseBtn";
            DiagnoseBtn.Size = new Size(28, 28);
            DiagnoseBtn.SizeMode = PictureBoxSizeMode.Zoom;
            DiagnoseBtn.TabIndex = 9;
            DiagnoseBtn.TabStop = false;
            DiagnoseBtn.Click += DiagnoseBtn_Click;
            // 
            // PatientBtn
            // 
            PatientBtn.BackColor = Color.Transparent;
            PatientBtn.Cursor = Cursors.Hand;
            PatientBtn.Image = Properties.Resources.icons8_plus_64;
            PatientBtn.Location = new Point(28, 228);
            PatientBtn.Name = "PatientBtn";
            PatientBtn.Size = new Size(28, 28);
            PatientBtn.SizeMode = PictureBoxSizeMode.Zoom;
            PatientBtn.TabIndex = 8;
            PatientBtn.TabStop = false;
            PatientBtn.Click += PatientBtn_Click;
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
            UserType.Location = new Point(1217, 11);
            UserType.Name = "UserType";
            UserType.Size = new Size(138, 18);
            UserType.TabIndex = 1;
            UserType.Text = "Admin";
            UserType.TextAlign = ContentAlignment.TopRight;
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(124, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(291, 21);
            lblTitle.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "Patient Medical Diagnose Management\r\n";
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
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(594, 76);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(241, 24);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 19;
            kryptonLabel1.Values.Text = "Scheduled Clinic List Today";
            // 
            // DataList
            // 
            DataList.AllowUserToOrderColumns = true;
            DataList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataList.ColumnHeadersHeight = 28;
            DataList.Cursor = Cursors.Hand;
            DataList.GridStyles.Style = DataGridViewStyle.Mixed;
            DataList.GridStyles.StyleBackground = PaletteBackStyle.GridDataCellSheet;
            DataList.GridStyles.StyleColumn = GridStyle.Sheet;
            DataList.GridStyles.StyleDataCells = GridStyle.Sheet;
            DataList.GridStyles.StyleRow = GridStyle.Sheet;
            DataList.Location = new Point(123, 123);
            DataList.MultiSelect = false;
            DataList.Name = "DataList";
            DataList.PaletteMode = PaletteMode.Office365White;
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
            DataList.Size = new Size(1198, 398);
            DataList.StateCommon.Background.Color1 = Color.FromArgb(242, 242, 242);
            DataList.StateCommon.BackStyle = PaletteBackStyle.GridDataCellSheet;
            DataList.StateCommon.DataCell.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            DataList.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            DataList.StateCommon.HeaderRow.Content.Color1 = Color.White;
            DataList.StateCommon.HeaderRow.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DataList.StateSelected.DataCell.Back.Color1 = Color.Silver;
            DataList.StateSelected.DataCell.Back.Color2 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Back.Color1 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Back.Color2 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Border.Color1 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Border.Color2 = Color.Silver;
            DataList.StateSelected.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            DataList.StateSelected.HeaderColumn.Content.Color1 = Color.FromArgb(224, 224, 224);
            DataList.StateSelected.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            DataList.StateSelected.HeaderRow.Back.Color1 = Color.Silver;
            DataList.StateSelected.HeaderRow.Back.Color2 = Color.Silver;
            DataList.StateSelected.HeaderRow.Content.Color1 = Color.Silver;
            DataList.StateSelected.HeaderRow.Content.Color2 = Color.Silver;
            DataList.TabIndex = 20;
            DataList.TabStop = false;
            DataList.CellClick += DataList_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.four;
            pictureBox1.Location = new Point(361, 550);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.one;
            pictureBox2.Location = new Point(749, 550);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 153);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.three;
            pictureBox3.Location = new Point(524, 550);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(206, 153);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.two;
            pictureBox4.Location = new Point(915, 550);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(186, 153);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._111;
            pictureBox5.Location = new Point(147, 550);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(201, 153);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources._333;
            pictureBox7.Location = new Point(1117, 550);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(186, 153);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 27;
            pictureBox7.TabStop = false;
            // 
            // DiagnoseModule
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(4, 20);
            BackColor = Color.White;
            ClientSize = new Size(1366, 702);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonLabel1);
            Controls.Add(DataList);
            Controls.Add(HomeLogo);
            Controls.Add(sidebar);
            Controls.Add(header);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "DiagnoseModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Healthcare Plus Dashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)sidebar).EndInit();
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientListBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaymentBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)DiagnoseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)PatientBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)header).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomeLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KryptonPanel sidebar;
        private KryptonPanel header;
        private PictureBox PaymentBtn;
        private PictureBox DiagnoseBtn;
        private PictureBox PatientBtn;
        private PictureBox HomeLogo;
        private KryptonLabel lblTitle;
        private Label UserType;
        private Label AppointmentLbl;
        private Label PatientLbl;
        private Label PaymentLbl;
        private Label homeLbl;
        private PictureBox HomeBtn;
        private KryptonLabel kryptonLabel1;
        private KryptonDataGridView DataList;
        private Label PatientListLbl;
        private PictureBox PatientListBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
    }
}