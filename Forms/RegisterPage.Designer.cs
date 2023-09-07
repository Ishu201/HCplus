namespace HCplus.Forms
{
    partial class RegisterPage
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
            title = new Krypton.Toolkit.KryptonLabel();
            pictureBox1 = new PictureBox();
            NurseUser = new Krypton.Toolkit.KryptonRadioButton();
            ReceptUser = new Krypton.Toolkit.KryptonRadioButton();
            Username = new Krypton.Toolkit.KryptonTextBox();
            Password = new Krypton.Toolkit.KryptonTextBox();
            RegisterButton = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            pictureBox2 = new PictureBox();
            PasswordConfirm = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.Location = new Point(111, 31);
            title.Name = "title";
            title.Size = new Size(159, 49);
            title.StateCommon.ShortText.Color1 = Color.FromArgb(41, 82, 163);
            title.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 27F, FontStyle.Bold, GraphicsUnit.Point);
            title.TabIndex = 0;
            title.Values.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.doctors_and_nurses_illustration_free_vector;
            pictureBox1.Location = new Point(404, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(408, 431);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // NurseUser
            // 
            NurseUser.Location = new Point(232, 150);
            NurseUser.Name = "NurseUser";
            NurseUser.Size = new Size(65, 21);
            NurseUser.StateCommon.ShortText.Color1 = Color.DimGray;
            NurseUser.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            NurseUser.TabIndex = 4;
            NurseUser.Values.Text = "Nurse";
            // 
            // ReceptUser
            // 
            ReceptUser.Checked = true;
            ReceptUser.Location = new Point(107, 150);
            ReceptUser.Name = "ReceptUser";
            ReceptUser.Size = new Size(109, 21);
            ReceptUser.StateCommon.ShortText.Color1 = Color.DimGray;
            ReceptUser.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReceptUser.TabIndex = 5;
            ReceptUser.Values.Text = "Receptionist";
            // 
            // Username
            // 
            Username.Location = new Point(78, 198);
            Username.Name = "Username";
            Username.Size = new Size(269, 38);
            Username.StateCommon.Border.Color1 = Color.DarkCyan;
            Username.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Username.StateCommon.Border.Rounding = 25F;
            Username.StateCommon.Content.Color1 = Color.Teal;
            Username.StateCommon.Content.Padding = new Padding(4, 2, 4, 2);
            Username.TabIndex = 9;
            Username.TabStop = false;
            Username.Text = "Username";
            Username.Enter += Username_Enter;
            Username.Leave += Username_Leave_1;
            // 
            // Password
            // 
            Password.Location = new Point(78, 263);
            Password.Name = "Password";
            Password.Size = new Size(269, 38);
            Password.StateCommon.Border.Color1 = Color.DarkCyan;
            Password.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Password.StateCommon.Border.Rounding = 25F;
            Password.StateCommon.Content.Color1 = Color.Teal;
            Password.StateCommon.Content.Padding = new Padding(4, 2, 4, 2);
            Password.TabIndex = 11;
            Password.TabStop = false;
            Password.Text = "Password";
            Password.Enter += Password_Enter;
            Password.Leave += Password_Leave;
            // 
            // RegisterButton
            // 
            RegisterButton.CornerRoundingRadius = 25F;
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.Location = new Point(126, 387);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.OverrideDefault.Back.Color1 = Color.DodgerBlue;
            RegisterButton.OverrideDefault.Back.Color2 = Color.RoyalBlue;
            RegisterButton.OverrideDefault.Content.ShortText.Color1 = Color.White;
            RegisterButton.Size = new Size(161, 42);
            RegisterButton.StateCommon.Back.Color1 = Color.DodgerBlue;
            RegisterButton.StateCommon.Back.Color2 = Color.RoyalBlue;
            RegisterButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            RegisterButton.StateCommon.Border.Rounding = 25F;
            RegisterButton.StateCommon.Content.ShortText.Color1 = Color.White;
            RegisterButton.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.StateTracking.Back.Color1 = Color.DodgerBlue;
            RegisterButton.StateTracking.Back.Color2 = Color.RoyalBlue;
            RegisterButton.TabIndex = 12;
            RegisterButton.TabStop = false;
            RegisterButton.Values.Text = "Sign Up";
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(11, 491);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 14;
            label1.Text = "Already Have an Account..? Log In ";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_user_100__1_;
            pictureBox3.Location = new Point(38, 202);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_password_26;
            pictureBox4.Location = new Point(40, 270);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(47, 74);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(300, 33);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(64, 64, 64);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            kryptonLabel1.TabIndex = 18;
            kryptonLabel1.Values.Text = "Healthcare Plus System";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_password_26;
            pictureBox2.Location = new Point(40, 330);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // PasswordConfirm
            // 
            PasswordConfirm.Location = new Point(78, 323);
            PasswordConfirm.Name = "PasswordConfirm";
            PasswordConfirm.Size = new Size(269, 38);
            PasswordConfirm.StateCommon.Border.Color1 = Color.DarkCyan;
            PasswordConfirm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PasswordConfirm.StateCommon.Border.Rounding = 25F;
            PasswordConfirm.StateCommon.Content.Color1 = Color.Teal;
            PasswordConfirm.StateCommon.Content.Padding = new Padding(4, 2, 4, 2);
            PasswordConfirm.TabIndex = 19;
            PasswordConfirm.TabStop = false;
            PasswordConfirm.Text = "Re-type Password";
            PasswordConfirm.Enter += PasswordConfirm_Enter;
            PasswordConfirm.Leave += PasswordConfirm_Leave;
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(813, 516);
            Controls.Add(pictureBox2);
            Controls.Add(PasswordConfirm);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(RegisterButton);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(ReceptUser);
            Controls.Add(NurseUser);
            Controls.Add(title);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonLabel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel title;
        private Krypton.Toolkit.KryptonLabel subtext;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonRadioButton NurseUser;
        private Krypton.Toolkit.KryptonRadioButton ReceptUser;
        private Krypton.Toolkit.KryptonTextBox Username;
        private Krypton.Toolkit.KryptonTextBox Password;
        private Krypton.Toolkit.KryptonButton RegisterButton;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonTextBox PasswordConfirm;
    }
}