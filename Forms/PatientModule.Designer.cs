using Krypton.Toolkit;

namespace HCplus.Forms
{
    partial class PatientModule
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientModule));
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
            SearchPatient = new KryptonTextBox();
            label1 = new Label();
            Refresh = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)Refresh).BeginInit();
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
            lblTitle.Size = new Size(199, 21);
            lblTitle.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.TabIndex = 0;
            lblTitle.Values.Text = "Appointment Management\r\n";
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
            kryptonLabel1.Size = new Size(236, 24);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 19;
            kryptonLabel1.Values.Text = "Registered Patients Details";
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
            DataList.Location = new Point(123, 209);
            DataList.MultiSelect = false;
            DataList.Name = "DataList";
            DataList.PaletteMode = PaletteMode.Office365White;
            DataList.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            DataList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DataList.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            DataList.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DataList.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            DataList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            DataList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gray;
            DataList.RowTemplate.Height = 35;
            DataList.RowTemplate.ReadOnly = true;
            DataList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataList.Size = new Size(1198, 465);
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
            // SearchPatient
            // 
            SearchPatient.Location = new Point(123, 137);
            SearchPatient.Name = "SearchPatient";
            SearchPatient.Size = new Size(326, 30);
            SearchPatient.StateCommon.Border.Color1 = Color.SlateGray;
            SearchPatient.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            SearchPatient.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchPatient.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SearchPatient.StateCommon.Content.Padding = new Padding(7);
            SearchPatient.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(123, 116);
            label1.Name = "label1";
            label1.Size = new Size(100, 13);
            label1.TabIndex = 22;
            label1.Text = "Search by Name";
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.Transparent;
            Refresh.Image = Properties.Resources.icons8_refresh_32;
            Refresh.Location = new Point(1307, 182);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(15, 15);
            Refresh.SizeMode = PictureBoxSizeMode.Zoom;
            Refresh.TabIndex = 23;
            Refresh.TabStop = false;
            Refresh.Click += Refresh_Click;
            // 
            // PatientModule
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(4, 20);
            BackColor = Color.White;
            ClientSize = new Size(1366, 702);
            Controls.Add(Refresh);
            Controls.Add(label1);
            Controls.Add(SearchPatient);
            Controls.Add(kryptonLabel1);
            Controls.Add(DataList);
            Controls.Add(HomeLogo);
            Controls.Add(sidebar);
            Controls.Add(header);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "PatientModule";
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
            ((System.ComponentModel.ISupportInitialize)Refresh).EndInit();
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
        private KryptonTextBox SearchPatient;
        private Label label1;
        private PictureBox Refresh;
        private Label PatientListLbl;
        private PictureBox PatientListBtn;
    }
}