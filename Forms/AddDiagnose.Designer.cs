using Krypton.Toolkit;

namespace HCplus.Forms
{
    partial class AddDiagnose
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDiagnose));
            header = new KryptonPanel();
            CompleteClinic = new KryptonButton();
            kryptonLabel2 = new KryptonLabel();
            kryptonLabel1 = new KryptonLabel();
            DataList = new KryptonDataGridView();
            kryptonPanel1 = new KryptonPanel();
            RefreshOp = new PictureBox();
            refreshRep = new PictureBox();
            Refresh = new PictureBox();
            AddPrescriptions = new KryptonButton();
            PrescriptionTable = new KryptonDataGridView();
            SaveDiagnose = new KryptonButton();
            OpPanel = new KryptonPanel();
            OpDetails = new KryptonWrapLabel();
            OpRoom = new KryptonLabel();
            kryptonLabel9 = new KryptonLabel();
            OpDate = new KryptonLabel();
            kryptonLabel13 = new KryptonLabel();
            kryptonLabel14 = new KryptonLabel();
            OpSchedule = new KryptonButton();
            AddLabReports = new KryptonButton();
            LabReportTbl = new KryptonDataGridView();
            AppID = new KryptonLabel();
            kryptonLabel7 = new KryptonLabel();
            Diagnosetxt = new KryptonRichTextBox();
            kryptonLabel11 = new KryptonLabel();
            PatientNameLbl = new KryptonLabel();
            PatientIdLbl = new KryptonLabel();
            kryptonLabel5 = new KryptonLabel();
            kryptonLabel4 = new KryptonLabel();
            kryptonLabel3 = new KryptonLabel();
            AddBtn = new KryptonButton();
            ((System.ComponentModel.ISupportInitialize)header).BeginInit();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RefreshOp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)refreshRep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrescriptionTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OpPanel).BeginInit();
            OpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LabReportTbl).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.Controls.Add(CompleteClinic);
            header.Controls.Add(kryptonLabel2);
            header.Location = new Point(-1, -2);
            header.Name = "header";
            header.Size = new Size(1367, 70);
            header.StateCommon.Color1 = Color.DodgerBlue;
            header.StateCommon.Color2 = Color.RoyalBlue;
            header.StateCommon.ColorAngle = 25F;
            header.TabIndex = 1;
            // 
            // CompleteClinic
            // 
            CompleteClinic.CornerRoundingRadius = 25F;
            CompleteClinic.Location = new Point(1213, 26);
            CompleteClinic.Name = "CompleteClinic";
            CompleteClinic.OverrideDefault.Back.Color1 = Color.Brown;
            CompleteClinic.OverrideDefault.Back.Color2 = Color.Firebrick;
            CompleteClinic.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            CompleteClinic.OverrideDefault.Border.Rounding = 25F;
            CompleteClinic.OverrideDefault.Content.ShortText.Color1 = Color.White;
            CompleteClinic.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CompleteClinic.Size = new Size(127, 33);
            CompleteClinic.StateCommon.Back.Color1 = Color.Brown;
            CompleteClinic.StateCommon.Back.Color2 = Color.Firebrick;
            CompleteClinic.StateCommon.Back.ColorAngle = 25F;
            CompleteClinic.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            CompleteClinic.StateCommon.Border.Rounding = 25F;
            CompleteClinic.StateCommon.Content.ShortText.Color1 = Color.White;
            CompleteClinic.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CompleteClinic.StateTracking.Back.Color1 = Color.Firebrick;
            CompleteClinic.StateTracking.Back.Color2 = Color.Tomato;
            CompleteClinic.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            CompleteClinic.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            CompleteClinic.StateTracking.Border.Rounding = 25F;
            CompleteClinic.StateTracking.Content.ShortText.Color1 = Color.White;
            CompleteClinic.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            CompleteClinic.TabIndex = 23;
            CompleteClinic.Values.Text = "Finish Clinic";
            CompleteClinic.Visible = false;
            CompleteClinic.Click += CompleteClinic_Click;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(36, 26);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(238, 24);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 21;
            kryptonLabel2.Values.Text = "Manage Clinic and Patients";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(159, 123);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(114, 24);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 19;
            kryptonLabel1.Values.Text = "Patients List";
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
            DataList.Location = new Point(35, 153);
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
            DataList.Size = new Size(394, 539);
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
            // kryptonPanel1
            // 
            kryptonPanel1.AutoScroll = true;
            kryptonPanel1.AutoScrollMinSize = new Size(0, 450);
            kryptonPanel1.Controls.Add(RefreshOp);
            kryptonPanel1.Controls.Add(refreshRep);
            kryptonPanel1.Controls.Add(Refresh);
            kryptonPanel1.Controls.Add(AddPrescriptions);
            kryptonPanel1.Controls.Add(PrescriptionTable);
            kryptonPanel1.Controls.Add(SaveDiagnose);
            kryptonPanel1.Controls.Add(OpPanel);
            kryptonPanel1.Controls.Add(OpSchedule);
            kryptonPanel1.Controls.Add(AddLabReports);
            kryptonPanel1.Controls.Add(LabReportTbl);
            kryptonPanel1.Controls.Add(AppID);
            kryptonPanel1.Controls.Add(kryptonLabel7);
            kryptonPanel1.Controls.Add(Diagnosetxt);
            kryptonPanel1.Controls.Add(kryptonLabel11);
            kryptonPanel1.Controls.Add(PatientNameLbl);
            kryptonPanel1.Controls.Add(PatientIdLbl);
            kryptonPanel1.Controls.Add(kryptonLabel5);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Location = new Point(462, 153);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(877, 572);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(224, 224, 224);
            kryptonPanel1.TabIndex = 21;
            // 
            // RefreshOp
            // 
            RefreshOp.BackColor = Color.Transparent;
            RefreshOp.Image = Properties.Resources.icons8_refresh_32;
            RefreshOp.Location = new Point(831, 393);
            RefreshOp.Name = "RefreshOp";
            RefreshOp.Size = new Size(15, 15);
            RefreshOp.SizeMode = PictureBoxSizeMode.Zoom;
            RefreshOp.TabIndex = 56;
            RefreshOp.TabStop = false;
            RefreshOp.Click += RefreshOp_Click;
            // 
            // refreshRep
            // 
            refreshRep.BackColor = Color.Transparent;
            refreshRep.Image = Properties.Resources.icons8_refresh_32;
            refreshRep.Location = new Point(378, 393);
            refreshRep.Name = "refreshRep";
            refreshRep.Size = new Size(15, 15);
            refreshRep.SizeMode = PictureBoxSizeMode.Zoom;
            refreshRep.TabIndex = 55;
            refreshRep.TabStop = false;
            refreshRep.Click += refreshRep_Click;
            // 
            // Refresh
            // 
            Refresh.BackColor = Color.Transparent;
            Refresh.Image = Properties.Resources.icons8_refresh_32;
            Refresh.Location = new Point(818, 199);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(15, 15);
            Refresh.SizeMode = PictureBoxSizeMode.Zoom;
            Refresh.TabIndex = 23;
            Refresh.TabStop = false;
            Refresh.Click += Refresh_Click;
            // 
            // AddPrescriptions
            // 
            AddPrescriptions.CornerRoundingRadius = 25F;
            AddPrescriptions.Cursor = Cursors.Hand;
            AddPrescriptions.Location = new Point(21, 182);
            AddPrescriptions.Name = "AddPrescriptions";
            AddPrescriptions.OverrideDefault.Back.Color1 = Color.FromArgb(0, 179, 89);
            AddPrescriptions.OverrideDefault.Back.Color2 = Color.MediumSeaGreen;
            AddPrescriptions.Size = new Size(134, 28);
            AddPrescriptions.StateCommon.Back.Color1 = Color.FromArgb(0, 204, 102);
            AddPrescriptions.StateCommon.Back.Color2 = Color.FromArgb(0, 179, 89);
            AddPrescriptions.StateCommon.Back.ColorAngle = 25F;
            AddPrescriptions.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            AddPrescriptions.StateCommon.Border.Rounding = 25F;
            AddPrescriptions.StateCommon.Content.ShortText.Color1 = Color.White;
            AddPrescriptions.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            AddPrescriptions.StateTracking.Back.Color1 = Color.FromArgb(0, 179, 89);
            AddPrescriptions.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            AddPrescriptions.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            AddPrescriptions.StateTracking.Border.Rounding = 25F;
            AddPrescriptions.TabIndex = 54;
            AddPrescriptions.Values.Text = "Add Prescriptions";
            AddPrescriptions.Click += AddPrescriptions_Click;
            // 
            // PrescriptionTable
            // 
            PrescriptionTable.AllowUserToOrderColumns = true;
            PrescriptionTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PrescriptionTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PrescriptionTable.ColumnHeadersHeight = 28;
            PrescriptionTable.Cursor = Cursors.Hand;
            PrescriptionTable.GridStyles.Style = DataGridViewStyle.Mixed;
            PrescriptionTable.GridStyles.StyleBackground = PaletteBackStyle.GridDataCellSheet;
            PrescriptionTable.GridStyles.StyleColumn = GridStyle.Sheet;
            PrescriptionTable.GridStyles.StyleDataCells = GridStyle.Sheet;
            PrescriptionTable.GridStyles.StyleRow = GridStyle.Sheet;
            PrescriptionTable.Location = new Point(15, 220);
            PrescriptionTable.MultiSelect = false;
            PrescriptionTable.Name = "PrescriptionTable";
            PrescriptionTable.PaletteMode = PaletteMode.Office365White;
            PrescriptionTable.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            PrescriptionTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            PrescriptionTable.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            PrescriptionTable.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PrescriptionTable.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            PrescriptionTable.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            PrescriptionTable.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gray;
            PrescriptionTable.RowTemplate.Height = 35;
            PrescriptionTable.RowTemplate.ReadOnly = true;
            PrescriptionTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PrescriptionTable.Size = new Size(818, 127);
            PrescriptionTable.StateCommon.Background.Color1 = Color.FromArgb(242, 242, 242);
            PrescriptionTable.StateCommon.BackStyle = PaletteBackStyle.GridDataCellSheet;
            PrescriptionTable.StateCommon.DataCell.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            PrescriptionTable.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            PrescriptionTable.StateCommon.HeaderRow.Content.Color1 = Color.White;
            PrescriptionTable.StateCommon.HeaderRow.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PrescriptionTable.StateSelected.DataCell.Back.Color1 = Color.Silver;
            PrescriptionTable.StateSelected.DataCell.Back.Color2 = Color.Silver;
            PrescriptionTable.StateSelected.HeaderColumn.Back.Color1 = Color.Silver;
            PrescriptionTable.StateSelected.HeaderColumn.Back.Color2 = Color.Silver;
            PrescriptionTable.StateSelected.HeaderColumn.Border.Color1 = Color.Silver;
            PrescriptionTable.StateSelected.HeaderColumn.Border.Color2 = Color.Silver;
            PrescriptionTable.StateSelected.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            PrescriptionTable.StateSelected.HeaderColumn.Content.Color1 = Color.FromArgb(224, 224, 224);
            PrescriptionTable.StateSelected.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            PrescriptionTable.StateSelected.HeaderRow.Back.Color1 = Color.Silver;
            PrescriptionTable.StateSelected.HeaderRow.Back.Color2 = Color.Silver;
            PrescriptionTable.StateSelected.HeaderRow.Content.Color1 = Color.Silver;
            PrescriptionTable.StateSelected.HeaderRow.Content.Color2 = Color.Silver;
            PrescriptionTable.TabIndex = 53;
            PrescriptionTable.TabStop = false;
            // 
            // SaveDiagnose
            // 
            SaveDiagnose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SaveDiagnose.CornerRoundingRadius = 25F;
            SaveDiagnose.Cursor = Cursors.Hand;
            SaveDiagnose.Location = new Point(666, 646);
            SaveDiagnose.Name = "SaveDiagnose";
            SaveDiagnose.OverrideDefault.Back.Color1 = Color.DarkTurquoise;
            SaveDiagnose.OverrideDefault.Back.Color2 = Color.SteelBlue;
            SaveDiagnose.Size = new Size(143, 33);
            SaveDiagnose.StateCommon.Back.Color1 = Color.DarkTurquoise;
            SaveDiagnose.StateCommon.Back.Color2 = Color.SteelBlue;
            SaveDiagnose.StateCommon.Back.ColorAngle = 1F;
            SaveDiagnose.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            SaveDiagnose.StateCommon.Border.Rounding = 25F;
            SaveDiagnose.StateCommon.Content.ShortText.Color1 = Color.White;
            SaveDiagnose.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SaveDiagnose.StateTracking.Back.Color1 = Color.SteelBlue;
            SaveDiagnose.StateTracking.Back.Color2 = Color.DarkTurquoise;
            SaveDiagnose.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            SaveDiagnose.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            SaveDiagnose.StateTracking.Border.Rounding = 25F;
            SaveDiagnose.TabIndex = 52;
            SaveDiagnose.Values.Text = "Save Diagnose";
            // 
            // OpPanel
            // 
            OpPanel.Controls.Add(OpDetails);
            OpPanel.Controls.Add(OpRoom);
            OpPanel.Controls.Add(kryptonLabel9);
            OpPanel.Controls.Add(OpDate);
            OpPanel.Controls.Add(kryptonLabel13);
            OpPanel.Controls.Add(kryptonLabel14);
            OpPanel.Location = new Point(415, 411);
            OpPanel.Name = "OpPanel";
            OpPanel.Size = new Size(431, 142);
            OpPanel.TabIndex = 48;
            // 
            // OpDetails
            // 
            OpDetails.AutoSize = false;
            OpDetails.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OpDetails.ForeColor = Color.FromArgb(30, 57, 91);
            OpDetails.LabelStyle = LabelStyle.NormalControl;
            OpDetails.Location = new Point(138, 54);
            OpDetails.Name = "OpDetails";
            OpDetails.Size = new Size(289, 80);
            // 
            // OpRoom
            // 
            OpRoom.Location = new Point(128, 31);
            OpRoom.Name = "OpRoom";
            OpRoom.Size = new Size(6, 2);
            OpRoom.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OpRoom.TabIndex = 59;
            OpRoom.Values.Text = "";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(7, 31);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(115, 18);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel9.TabIndex = 58;
            kryptonLabel9.Values.Text = "Operation Room  :";
            // 
            // OpDate
            // 
            OpDate.Location = new Point(128, 7);
            OpDate.Name = "OpDate";
            OpDate.Size = new Size(6, 2);
            OpDate.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OpDate.TabIndex = 57;
            OpDate.Values.Text = "";
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Location = new Point(7, 7);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(108, 18);
            kryptonLabel13.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel13.TabIndex = 56;
            kryptonLabel13.Values.Text = "Operation Date  :";
            // 
            // kryptonLabel14
            // 
            kryptonLabel14.Location = new Point(7, 54);
            kryptonLabel14.Name = "kryptonLabel14";
            kryptonLabel14.Size = new Size(120, 18);
            kryptonLabel14.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel14.TabIndex = 55;
            kryptonLabel14.Values.Text = "Operation Details  :";
            // 
            // OpSchedule
            // 
            OpSchedule.CornerRoundingRadius = 25F;
            OpSchedule.Cursor = Cursors.Hand;
            OpSchedule.Location = new Point(449, 370);
            OpSchedule.Name = "OpSchedule";
            OpSchedule.OverrideDefault.Back.Color1 = Color.FromArgb(0, 179, 89);
            OpSchedule.OverrideDefault.Back.Color2 = Color.MediumSeaGreen;
            OpSchedule.Size = new Size(168, 28);
            OpSchedule.StateCommon.Back.Color1 = Color.FromArgb(0, 204, 102);
            OpSchedule.StateCommon.Back.Color2 = Color.FromArgb(0, 179, 89);
            OpSchedule.StateCommon.Back.ColorAngle = 25F;
            OpSchedule.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            OpSchedule.StateCommon.Border.Rounding = 25F;
            OpSchedule.StateCommon.Content.ShortText.Color1 = Color.White;
            OpSchedule.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            OpSchedule.StateTracking.Back.Color1 = Color.FromArgb(0, 179, 89);
            OpSchedule.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            OpSchedule.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            OpSchedule.StateTracking.Border.Rounding = 25F;
            OpSchedule.TabIndex = 47;
            OpSchedule.Values.Text = "Schedule an Operation";
            OpSchedule.Click += OpSchedule_Click;
            // 
            // AddLabReports
            // 
            AddLabReports.CornerRoundingRadius = 25F;
            AddLabReports.Cursor = Cursors.Hand;
            AddLabReports.Location = new Point(21, 370);
            AddLabReports.Name = "AddLabReports";
            AddLabReports.OverrideDefault.Back.Color1 = Color.FromArgb(0, 179, 89);
            AddLabReports.OverrideDefault.Back.Color2 = Color.MediumSeaGreen;
            AddLabReports.Size = new Size(110, 28);
            AddLabReports.StateCommon.Back.Color1 = Color.FromArgb(0, 204, 102);
            AddLabReports.StateCommon.Back.Color2 = Color.FromArgb(0, 179, 89);
            AddLabReports.StateCommon.Back.ColorAngle = 25F;
            AddLabReports.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            AddLabReports.StateCommon.Border.Rounding = 25F;
            AddLabReports.StateCommon.Content.ShortText.Color1 = Color.White;
            AddLabReports.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            AddLabReports.StateTracking.Back.Color1 = Color.FromArgb(0, 179, 89);
            AddLabReports.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            AddLabReports.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            AddLabReports.StateTracking.Border.Rounding = 25F;
            AddLabReports.TabIndex = 44;
            AddLabReports.Values.Text = "Add a Report";
            AddLabReports.Click += AddLabReports_Click;
            // 
            // LabReportTbl
            // 
            LabReportTbl.AllowUserToOrderColumns = true;
            LabReportTbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabReportTbl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LabReportTbl.ColumnHeadersHeight = 28;
            LabReportTbl.Cursor = Cursors.Hand;
            LabReportTbl.GridStyles.Style = DataGridViewStyle.Mixed;
            LabReportTbl.GridStyles.StyleBackground = PaletteBackStyle.GridDataCellSheet;
            LabReportTbl.GridStyles.StyleColumn = GridStyle.Sheet;
            LabReportTbl.GridStyles.StyleDataCells = GridStyle.Sheet;
            LabReportTbl.GridStyles.StyleRow = GridStyle.Sheet;
            LabReportTbl.Location = new Point(15, 411);
            LabReportTbl.MultiSelect = false;
            LabReportTbl.Name = "LabReportTbl";
            LabReportTbl.PaletteMode = PaletteMode.Office365White;
            LabReportTbl.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGray;
            LabReportTbl.RowsDefaultCellStyle = dataGridViewCellStyle3;
            LabReportTbl.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            LabReportTbl.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabReportTbl.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            LabReportTbl.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            LabReportTbl.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Gray;
            LabReportTbl.RowTemplate.Height = 35;
            LabReportTbl.RowTemplate.ReadOnly = true;
            LabReportTbl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LabReportTbl.Size = new Size(379, 142);
            LabReportTbl.StateCommon.Background.Color1 = Color.FromArgb(242, 242, 242);
            LabReportTbl.StateCommon.BackStyle = PaletteBackStyle.GridDataCellSheet;
            LabReportTbl.StateCommon.DataCell.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            LabReportTbl.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            LabReportTbl.StateCommon.HeaderRow.Content.Color1 = Color.White;
            LabReportTbl.StateCommon.HeaderRow.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabReportTbl.StateSelected.DataCell.Back.Color1 = Color.Silver;
            LabReportTbl.StateSelected.DataCell.Back.Color2 = Color.Silver;
            LabReportTbl.StateSelected.HeaderColumn.Back.Color1 = Color.Silver;
            LabReportTbl.StateSelected.HeaderColumn.Back.Color2 = Color.Silver;
            LabReportTbl.StateSelected.HeaderColumn.Border.Color1 = Color.Silver;
            LabReportTbl.StateSelected.HeaderColumn.Border.Color2 = Color.Silver;
            LabReportTbl.StateSelected.HeaderColumn.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            LabReportTbl.StateSelected.HeaderColumn.Content.Color1 = Color.FromArgb(224, 224, 224);
            LabReportTbl.StateSelected.HeaderColumn.Content.Color2 = Color.FromArgb(224, 224, 224);
            LabReportTbl.StateSelected.HeaderRow.Back.Color1 = Color.Silver;
            LabReportTbl.StateSelected.HeaderRow.Back.Color2 = Color.Silver;
            LabReportTbl.StateSelected.HeaderRow.Content.Color1 = Color.Silver;
            LabReportTbl.StateSelected.HeaderRow.Content.Color2 = Color.Silver;
            LabReportTbl.TabIndex = 43;
            LabReportTbl.TabStop = false;
            // 
            // AppID
            // 
            AppID.Location = new Point(768, 57);
            AppID.Name = "AppID";
            AppID.Size = new Size(24, 18);
            AppID.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AppID.TabIndex = 40;
            AppID.Values.Text = "00";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(653, 57);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(109, 18);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel7.TabIndex = 39;
            kryptonLabel7.Values.Text = "Appointment ID  :";
            // 
            // Diagnosetxt
            // 
            Diagnosetxt.Location = new Point(168, 103);
            Diagnosetxt.Name = "Diagnosetxt";
            Diagnosetxt.Size = new Size(665, 65);
            Diagnosetxt.StateCommon.Back.Color1 = Color.FromArgb(242, 242, 242);
            Diagnosetxt.StateCommon.Border.Color1 = Color.Gray;
            Diagnosetxt.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            Diagnosetxt.StateCommon.Border.Rounding = 10F;
            Diagnosetxt.TabIndex = 38;
            Diagnosetxt.TabStop = false;
            Diagnosetxt.Text = "";
            Diagnosetxt.KeyPress += Diagnosetxt_TextChanged;
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(21, 103);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(130, 19);
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel11.TabIndex = 37;
            kryptonLabel11.Values.Text = "Diagnose Details  :";
            // 
            // PatientNameLbl
            // 
            PatientNameLbl.Location = new Point(331, 57);
            PatientNameLbl.Name = "PatientNameLbl";
            PatientNameLbl.Size = new Size(85, 18);
            PatientNameLbl.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PatientNameLbl.TabIndex = 27;
            PatientNameLbl.Values.Text = "Patient Name";
            // 
            // PatientIdLbl
            // 
            PatientIdLbl.Location = new Point(103, 57);
            PatientIdLbl.Name = "PatientIdLbl";
            PatientIdLbl.Size = new Size(38, 18);
            PatientIdLbl.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PatientIdLbl.TabIndex = 26;
            PatientIdLbl.Values.Text = "0000";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(217, 57);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(98, 18);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 25;
            kryptonLabel5.Values.Text = "Patient Name  :";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(21, 57);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(77, 18);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 24;
            kryptonLabel4.Values.Text = "Patient ID  :";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(357, 17);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(154, 24);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 23;
            kryptonLabel3.Values.Text = "Patient Diagnose";
            // 
            // AddBtn
            // 
            AddBtn.CornerRoundingRadius = 25F;
            AddBtn.Location = new Point(1223, 98);
            AddBtn.Name = "AddBtn";
            AddBtn.OverrideDefault.Back.Color1 = Color.FromArgb(0, 91, 150);
            AddBtn.OverrideDefault.Back.Color2 = Color.FromArgb(0, 91, 150);
            AddBtn.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            AddBtn.OverrideDefault.Border.Rounding = 25F;
            AddBtn.OverrideDefault.Content.ShortText.Color1 = Color.White;
            AddBtn.OverrideDefault.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.Size = new Size(116, 33);
            AddBtn.StateCommon.Back.Color1 = Color.FromArgb(0, 91, 150);
            AddBtn.StateCommon.Back.Color2 = Color.FromArgb(0, 91, 150);
            AddBtn.StateCommon.Back.ColorAngle = 25F;
            AddBtn.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            AddBtn.StateCommon.Border.Rounding = 25F;
            AddBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            AddBtn.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.StateTracking.Back.Color1 = Color.MidnightBlue;
            AddBtn.StateTracking.Back.Color2 = Color.RoyalBlue;
            AddBtn.StateTracking.Back.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            AddBtn.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            AddBtn.StateTracking.Border.Rounding = 25F;
            AddBtn.StateTracking.Content.ShortText.Color1 = Color.White;
            AddBtn.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.TabIndex = 22;
            AddBtn.Values.Text = "Start Clinic";
            AddBtn.Click += AddBtn_Click;
            // 
            // AddDiagnose
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(4, 20);
            BackColor = Color.White;
            ClientSize = new Size(1366, 749);
            Controls.Add(AddBtn);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonLabel1);
            Controls.Add(DataList);
            Controls.Add(header);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimumSize = new Size(0, 726);
            Name = "AddDiagnose";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Healthcare Plus Dashboard";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)header).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RefreshOp).EndInit();
            ((System.ComponentModel.ISupportInitialize)refreshRep).EndInit();
            ((System.ComponentModel.ISupportInitialize)Refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrescriptionTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)OpPanel).EndInit();
            OpPanel.ResumeLayout(false);
            OpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LabReportTbl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private KryptonPanel header;
        private KryptonLabel kryptonLabel1;
        private KryptonDataGridView DataList;
        private KryptonLabel kryptonLabel2;
        private KryptonPanel kryptonPanel1;
        private KryptonButton AddBtn;
        private KryptonLabel kryptonLabel3;
        private KryptonLabel kryptonLabel4;
        private KryptonLabel kryptonLabel5;
        private KryptonLabel PatientNameLbl;
        private KryptonLabel PatientIdLbl;
        private KryptonLabel AppID;
        private KryptonLabel kryptonLabel7;
        private KryptonRichTextBox Diagnosetxt;
        private KryptonLabel kryptonLabel11;
        private KryptonDataGridView LabReportTbl;
        private KryptonButton AddLabReports;
        private KryptonButton OpSchedule;
        private KryptonPanel OpPanel;
        private KryptonWrapLabel OpDetails;
        private KryptonLabel OpRoom;
        private KryptonLabel kryptonLabel9;
        private KryptonLabel OpDate;
        private KryptonLabel kryptonLabel13;
        private KryptonLabel kryptonLabel14;
        private KryptonButton SaveDiagnose;
        private KryptonDataGridView PrescriptionTable;
        private KryptonButton AddPrescriptions;
        private PictureBox Refresh;
        private PictureBox RefreshOp;
        private PictureBox refreshRep;
        private KryptonButton CompleteClinic;
    }
}