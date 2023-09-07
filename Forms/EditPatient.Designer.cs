namespace HCplus.Forms
{
    partial class EditPatient
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
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            Contact = new Krypton.Toolkit.KryptonMaskedTextBox();
            Fullname = new Krypton.Toolkit.KryptonTextBox();
            Email = new Krypton.Toolkit.KryptonTextBox();
            GenderF = new Krypton.Toolkit.KryptonRadioButton();
            GenderM = new Krypton.Toolkit.KryptonRadioButton();
            EmailError = new Krypton.Toolkit.KryptonLabel();
            Submit = new Krypton.Toolkit.KryptonButton();
            Address = new Krypton.Toolkit.KryptonTextBox();
            SpConditions = new Krypton.Toolkit.KryptonRichTextBox();
            Allergies = new Krypton.Toolkit.KryptonRichTextBox();
            Nic = new Krypton.Toolkit.KryptonMaskedTextBox();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            PrevSurgeries = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            FamHistory = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            HCpreferance = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            Dob = new Krypton.Toolkit.KryptonDateTimePicker();
            NicErr = new Krypton.Toolkit.KryptonLabel();
            Remove = new Krypton.Toolkit.KryptonButton();
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
            kryptonPanel1.Size = new Size(1080, 70);
            kryptonPanel1.StateCommon.Color1 = Color.RoyalBlue;
            kryptonPanel1.StateCommon.Color2 = Color.DodgerBlue;
            kryptonPanel1.StateCommon.ColorAngle = 25F;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 24);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(144, 21);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Edit Patient Details";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(243, 96);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(76, 19);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Full Name ";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(244, 142);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(58, 19);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Gender";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(244, 195);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(82, 19);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel4.TabIndex = 3;
            kryptonLabel4.Values.Text = "Contact No";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(245, 245);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(103, 19);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel5.TabIndex = 4;
            kryptonLabel5.Values.Text = "Email Address";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(245, 299);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(63, 19);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel6.TabIndex = 5;
            kryptonLabel6.Values.Text = "Address";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(21, 401);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(183, 19);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel8.TabIndex = 7;
            kryptonLabel8.Values.Text = "Special Medical Conditions";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(417, 352);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(194, 21);
            kryptonLabel10.StateCommon.ShortText.Color1 = Color.DimGray;
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabel10.TabIndex = 9;
            kryptonLabel10.Values.Text = "Medical History and Details";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new Point(379, 401);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(66, 19);
            kryptonLabel11.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel11.TabIndex = 10;
            kryptonLabel11.Values.Text = "Allergies";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1028847418_612x6121;
            pictureBox1.Location = new Point(3, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 289);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Contact
            // 
            Contact.Cursor = Cursors.IBeam;
            Contact.Location = new Point(364, 189);
            Contact.Mask = "000 0000000";
            Contact.Name = "Contact";
            Contact.Size = new Size(176, 28);
            Contact.StateCommon.Border.Color1 = Color.RoyalBlue;
            Contact.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Contact.StateCommon.Border.Rounding = 10F;
            Contact.StateCommon.Border.Width = 1;
            Contact.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            Contact.StateCommon.Content.Padding = new Padding(2);
            Contact.TabIndex = 23;
            Contact.Text = "    ";
            // 
            // Fullname
            // 
            Fullname.Cursor = Cursors.IBeam;
            Fullname.Location = new Point(364, 89);
            Fullname.Name = "Fullname";
            Fullname.Size = new Size(509, 28);
            Fullname.StateCommon.Border.Color1 = Color.RoyalBlue;
            Fullname.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Fullname.StateCommon.Border.Rounding = 10F;
            Fullname.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            Fullname.StateCommon.Content.Padding = new Padding(2);
            Fullname.TabIndex = 24;
            // 
            // Email
            // 
            Email.Cursor = Cursors.IBeam;
            Email.Location = new Point(365, 241);
            Email.Name = "Email";
            Email.Size = new Size(303, 28);
            Email.StateCommon.Border.Color1 = Color.RoyalBlue;
            Email.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Email.StateCommon.Border.Rounding = 10F;
            Email.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            Email.StateCommon.Content.Padding = new Padding(2);
            Email.TabIndex = 26;
            Email.TextChanged += Email_TextChanged;
            // 
            // GenderF
            // 
            GenderF.Checked = true;
            GenderF.Cursor = Cursors.Hand;
            GenderF.Location = new Point(365, 141);
            GenderF.Name = "GenderF";
            GenderF.Size = new Size(61, 20);
            GenderF.TabIndex = 27;
            GenderF.Values.Text = "Female";
            // 
            // GenderM
            // 
            GenderM.Cursor = Cursors.Hand;
            GenderM.Location = new Point(458, 142);
            GenderM.Name = "GenderM";
            GenderM.Size = new Size(49, 20);
            GenderM.TabIndex = 28;
            GenderM.Values.Text = "Male";
            // 
            // EmailError
            // 
            EmailError.Location = new Point(685, 244);
            EmailError.Name = "EmailError";
            EmailError.Size = new Size(150, 20);
            EmailError.StateCommon.ShortText.Color1 = Color.FromArgb(192, 0, 0);
            EmailError.TabIndex = 29;
            EmailError.Values.Text = "Email Address is Incorrect";
            EmailError.Visible = false;
            // 
            // Submit
            // 
            Submit.CornerRoundingRadius = 25F;
            Submit.Cursor = Cursors.Hand;
            Submit.Location = new Point(956, 612);
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
            // Address
            // 
            Address.Cursor = Cursors.IBeam;
            Address.Location = new Point(365, 290);
            Address.Name = "Address";
            Address.Size = new Size(420, 28);
            Address.StateCommon.Border.Color1 = Color.RoyalBlue;
            Address.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Address.StateCommon.Border.Rounding = 10F;
            Address.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            Address.StateCommon.Content.Padding = new Padding(2);
            Address.TabIndex = 31;
            // 
            // SpConditions
            // 
            SpConditions.Location = new Point(21, 426);
            SpConditions.Name = "SpConditions";
            SpConditions.Size = new Size(318, 82);
            SpConditions.StateCommon.Border.Color1 = Color.RoyalBlue;
            SpConditions.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SpConditions.StateCommon.Border.Rounding = 10F;
            SpConditions.TabIndex = 35;
            SpConditions.Text = "";
            // 
            // Allergies
            // 
            Allergies.Location = new Point(379, 426);
            Allergies.Name = "Allergies";
            Allergies.Size = new Size(305, 82);
            Allergies.StateCommon.Border.Color1 = Color.RoyalBlue;
            Allergies.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Allergies.StateCommon.Border.Rounding = 10F;
            Allergies.TabIndex = 36;
            Allergies.Text = "";
            // 
            // Nic
            // 
            Nic.Cursor = Cursors.IBeam;
            Nic.Location = new Point(708, 189);
            Nic.Name = "Nic";
            Nic.Size = new Size(165, 28);
            Nic.StateCommon.Border.Color1 = Color.RoyalBlue;
            Nic.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Nic.StateCommon.Border.Rounding = 10F;
            Nic.StateCommon.Border.Width = 1;
            Nic.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            Nic.StateCommon.Content.Padding = new Padding(2);
            Nic.TabIndex = 41;
            Nic.TextChanged += Nic_TextChanged;
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Location = new Point(594, 195);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(57, 19);
            kryptonLabel13.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel13.TabIndex = 40;
            kryptonLabel13.Values.Text = "NIC No";
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Location = new Point(21, 379);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(1019, 1);
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // PrevSurgeries
            // 
            PrevSurgeries.Location = new Point(725, 427);
            PrevSurgeries.Name = "PrevSurgeries";
            PrevSurgeries.Size = new Size(334, 82);
            PrevSurgeries.StateCommon.Border.Color1 = Color.RoyalBlue;
            PrevSurgeries.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PrevSurgeries.StateCommon.Border.Rounding = 10F;
            PrevSurgeries.TabIndex = 44;
            PrevSurgeries.Text = "";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(726, 401);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(132, 19);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel7.TabIndex = 43;
            kryptonLabel7.Values.Text = "Previous Surgeries";
            // 
            // FamHistory
            // 
            FamHistory.Location = new Point(21, 556);
            FamHistory.Name = "FamHistory";
            FamHistory.Size = new Size(318, 82);
            FamHistory.StateCommon.Border.Color1 = Color.RoyalBlue;
            FamHistory.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FamHistory.StateCommon.Border.Rounding = 10F;
            FamHistory.TabIndex = 46;
            FamHistory.Text = "";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(21, 531);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(102, 19);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel9.TabIndex = 45;
            kryptonLabel9.Values.Text = "Family History";
            // 
            // HCpreferance
            // 
            HCpreferance.Location = new Point(379, 556);
            HCpreferance.Name = "HCpreferance";
            HCpreferance.Size = new Size(365, 82);
            HCpreferance.StateCommon.Border.Color1 = Color.RoyalBlue;
            HCpreferance.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            HCpreferance.StateCommon.Border.Rounding = 10F;
            HCpreferance.TabIndex = 48;
            HCpreferance.Text = "";
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Location = new Point(379, 531);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new Size(161, 19);
            kryptonLabel12.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel12.TabIndex = 47;
            kryptonLabel12.Values.Text = "Healthcare Preferances";
            // 
            // kryptonLabel14
            // 
            kryptonLabel14.Location = new Point(594, 142);
            kryptonLabel14.Name = "kryptonLabel14";
            kryptonLabel14.Size = new Size(90, 19);
            kryptonLabel14.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel14.TabIndex = 50;
            kryptonLabel14.Values.Text = "Date of Birth";
            // 
            // Dob
            // 
            Dob.CornerRoundingRadius = 10F;
            Dob.Format = DateTimePickerFormat.Short;
            Dob.Location = new Point(708, 141);
            Dob.MinDate = new DateTime(1900, 8, 31, 0, 0, 0, 0);
            Dob.Name = "Dob";
            Dob.Size = new Size(165, 27);
            Dob.StateCommon.Border.Color1 = Color.RoyalBlue;
            Dob.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Dob.StateCommon.Border.Rounding = 10F;
            Dob.TabIndex = 51;
            // 
            // NicErr
            // 
            NicErr.Location = new Point(879, 195);
            NicErr.Name = "NicErr";
            NicErr.Size = new Size(133, 20);
            NicErr.StateCommon.ShortText.Color1 = Color.FromArgb(192, 0, 0);
            NicErr.TabIndex = 53;
            NicErr.Values.Text = " Incorrect NIC Format..\r\n";
            NicErr.Visible = false;
            // 
            // Remove
            // 
            Remove.CornerRoundingRadius = 25F;
            Remove.Cursor = Cursors.Hand;
            Remove.Location = new Point(846, 612);
            Remove.Name = "Remove";
            Remove.OverrideDefault.Back.Color1 = Color.Brown;
            Remove.OverrideDefault.Back.Color2 = Color.Firebrick;
            Remove.Size = new Size(95, 37);
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
            Remove.TabIndex = 53;
            Remove.TabStop = false;
            Remove.Values.Text = "Remove";
            Remove.Click += Remove_Click;
            // 
            // EditPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1079, 661);
            Controls.Add(Remove);
            Controls.Add(NicErr);
            Controls.Add(Dob);
            Controls.Add(kryptonLabel14);
            Controls.Add(HCpreferance);
            Controls.Add(kryptonLabel12);
            Controls.Add(FamHistory);
            Controls.Add(kryptonLabel9);
            Controls.Add(PrevSurgeries);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonBorderEdge1);
            Controls.Add(Nic);
            Controls.Add(kryptonLabel13);
            Controls.Add(Allergies);
            Controls.Add(SpConditions);
            Controls.Add(Address);
            Controls.Add(Submit);
            Controls.Add(EmailError);
            Controls.Add(GenderM);
            Controls.Add(GenderF);
            Controls.Add(Email);
            Controls.Add(Fullname);
            Controls.Add(Contact);
            Controls.Add(kryptonLabel11);
            Controls.Add(kryptonLabel10);
            Controls.Add(kryptonLabel8);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonPanel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditPatient";
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
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonMaskedTextBox Contact;
        private Krypton.Toolkit.KryptonTextBox Fullname;
        private Krypton.Toolkit.KryptonTextBox Email;
        private Krypton.Toolkit.KryptonRadioButton GenderF;
        private Krypton.Toolkit.KryptonRadioButton GenderM;
        private Krypton.Toolkit.KryptonLabel EmailError;
        private Krypton.Toolkit.KryptonButton Submit;
        private Krypton.Toolkit.KryptonTextBox Address;
        private Krypton.Toolkit.KryptonRichTextBox SpConditions;
        private Krypton.Toolkit.KryptonRichTextBox Allergies;
        private Krypton.Toolkit.KryptonMaskedTextBox Nic;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonRichTextBox PrevSurgeries;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonRichTextBox FamHistory;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonRichTextBox HCpreferance;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonDateTimePicker Dob;
        private Krypton.Toolkit.KryptonLabel NicErr;
        private Krypton.Toolkit.KryptonButton Remove;
    }
}