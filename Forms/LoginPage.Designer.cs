namespace HCplus
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            welcome = new Krypton.Toolkit.KryptonLabel();
            title = new Krypton.Toolkit.KryptonLabel();
            subtext = new Krypton.Toolkit.KryptonWrapLabel();
            LoginBtn = new Krypton.Toolkit.KryptonButton();
            RegisterBtn = new Krypton.Toolkit.KryptonButton();
            Username = new Krypton.Toolkit.KryptonTextBox();
            Password = new Krypton.Toolkit.KryptonTextBox();
            mainImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mainImage).BeginInit();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.Location = new Point(29, 48);
            welcome.Name = "welcome";
            welcome.Size = new Size(215, 54);
            welcome.StateCommon.ShortText.Color1 = Color.DodgerBlue;
            welcome.StateCommon.ShortText.Color2 = Color.RoyalBlue;
            welcome.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 30.75F, FontStyle.Bold, GraphicsUnit.Point);
            welcome.TabIndex = 1;
            welcome.Values.Text = "Welcome,";
            // 
            // title
            // 
            title.AutoSize = false;
            title.Location = new Point(29, 97);
            title.Name = "title";
            title.Size = new Size(399, 43);
            title.StateCommon.ShortText.Color1 = Color.DodgerBlue;
            title.StateCommon.ShortText.Color2 = Color.RoyalBlue;
            title.StateCommon.ShortText.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            title.TabIndex = 2;
            title.Values.Text = "Healthcare Plus System";
            // 
            // subtext
            // 
            subtext.AutoSize = false;
            subtext.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            subtext.ForeColor = Color.MidnightBlue;
            subtext.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            subtext.Location = new Point(35, 143);
            subtext.Name = "subtext";
            subtext.Size = new Size(342, 61);
            subtext.StateCommon.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            subtext.StateCommon.TextColor = Color.MidnightBlue;
            subtext.Text = "Experience streamlined hospital management at its best – our system simplifies healthcare operations for improved efficiency";
            // 
            // LoginBtn
            // 
            LoginBtn.CornerRoundingRadius = 25F;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Location = new Point(45, 395);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.OverrideDefault.Back.Color1 = Color.DodgerBlue;
            LoginBtn.OverrideDefault.Back.Color2 = Color.RoyalBlue;
            LoginBtn.OverrideDefault.Border.Color1 = Color.DodgerBlue;
            LoginBtn.OverrideDefault.Border.Color2 = Color.RoyalBlue;
            LoginBtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginBtn.OverrideDefault.Border.Rounding = 25F;
            LoginBtn.OverrideDefault.Content.ShortText.Color1 = Color.White;
            LoginBtn.OverrideDefault.Content.ShortText.Color2 = Color.White;
            LoginBtn.Size = new Size(141, 38);
            LoginBtn.StateCommon.Back.Color1 = Color.DodgerBlue;
            LoginBtn.StateCommon.Back.Color2 = Color.RoyalBlue;
            LoginBtn.StateCommon.Border.Color1 = Color.DodgerBlue;
            LoginBtn.StateCommon.Border.Color2 = Color.RoyalBlue;
            LoginBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginBtn.StateCommon.Border.Rounding = 25F;
            LoginBtn.StateCommon.Content.ShortText.Color1 = Color.White;
            LoginBtn.StateCommon.Content.ShortText.Color2 = Color.White;
            LoginBtn.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.StateTracking.Back.Color1 = Color.RoyalBlue;
            LoginBtn.StateTracking.Back.Color2 = Color.DodgerBlue;
            LoginBtn.StateTracking.Content.ShortText.Color1 = Color.White;
            LoginBtn.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.TabIndex = 4;
            LoginBtn.TabStop = false;
            LoginBtn.Values.Text = "Get Started";
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.CornerRoundingRadius = 25F;
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.Location = new Point(209, 395);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.OverrideDefault.Back.Color1 = Color.White;
            RegisterBtn.OverrideDefault.Back.Color2 = Color.White;
            RegisterBtn.OverrideDefault.Border.Color1 = Color.DodgerBlue;
            RegisterBtn.OverrideDefault.Border.Color2 = Color.RoyalBlue;
            RegisterBtn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            RegisterBtn.OverrideDefault.Border.Rounding = 25F;
            RegisterBtn.OverrideDefault.Content.ShortText.Color1 = Color.DodgerBlue;
            RegisterBtn.OverrideDefault.Content.ShortText.Color2 = Color.White;
            RegisterBtn.Size = new Size(141, 38);
            RegisterBtn.StateCommon.Back.Color1 = Color.White;
            RegisterBtn.StateCommon.Back.Color2 = Color.White;
            RegisterBtn.StateCommon.Border.Color1 = Color.DodgerBlue;
            RegisterBtn.StateCommon.Border.Color2 = Color.RoyalBlue;
            RegisterBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            RegisterBtn.StateCommon.Border.Rounding = 25F;
            RegisterBtn.StateCommon.Border.Width = 2;
            RegisterBtn.StateCommon.Content.ShortText.Color1 = Color.DodgerBlue;
            RegisterBtn.StateCommon.Content.ShortText.Color2 = Color.White;
            RegisterBtn.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBtn.StateTracking.Back.Color1 = Color.FromArgb(235, 240, 250);
            RegisterBtn.StateTracking.Back.Color2 = Color.FromArgb(235, 250, 250);
            RegisterBtn.StateTracking.Border.Color1 = Color.DodgerBlue;
            RegisterBtn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            RegisterBtn.StateTracking.Content.ShortText.Color1 = Color.DodgerBlue;
            RegisterBtn.StateTracking.Content.ShortText.Color2 = Color.RoyalBlue;
            RegisterBtn.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterBtn.TabIndex = 5;
            RegisterBtn.TabStop = false;
            RegisterBtn.Values.Text = "Sign Up";
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // Username
            // 
            Username.Location = new Point(45, 253);
            Username.Name = "Username";
            Username.Size = new Size(263, 37);
            Username.StateCommon.Back.Color1 = Color.White;
            Username.StateCommon.Border.Color1 = Color.DodgerBlue;
            Username.StateCommon.Border.Color2 = Color.FromArgb(0, 192, 192);
            Username.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Username.StateCommon.Border.Rounding = 20F;
            Username.StateCommon.Border.Width = 1;
            Username.StateCommon.Content.Color1 = Color.FromArgb(1, 76, 97);
            Username.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Username.StateCommon.Content.Padding = new Padding(4);
            Username.TabIndex = 6;
            Username.TabStop = false;
            Username.Text = "Username";
            Username.Enter += Username_Enter;
            Username.Leave += Username_Leave;
            // 
            // Password
            // 
            Password.Location = new Point(45, 314);
            Password.Name = "Password";
            Password.Size = new Size(263, 37);
            Password.StateCommon.Back.Color1 = Color.White;
            Password.StateCommon.Border.Color1 = Color.DodgerBlue;
            Password.StateCommon.Border.Color2 = Color.FromArgb(0, 192, 192);
            Password.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Password.StateCommon.Border.Rounding = 20F;
            Password.StateCommon.Border.Width = 1;
            Password.StateCommon.Content.Color1 = Color.FromArgb(1, 76, 97);
            Password.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Password.StateCommon.Content.Padding = new Padding(4);
            Password.TabIndex = 7;
            Password.TabStop = false;
            Password.Text = "Password";
            Password.Enter += Password_Enter;
            Password.Leave += Password_Leave;
            // 
            // mainImage
            // 
            mainImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            mainImage.Image = Properties.Resources.doctors_and_nurses_illustration_free_vector;
            mainImage.Location = new Point(487, 12);
            mainImage.Name = "mainImage";
            mainImage.Size = new Size(385, 475);
            mainImage.SizeMode = PictureBoxSizeMode.Zoom;
            mainImage.TabIndex = 8;
            mainImage.TabStop = false;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 516);
            Controls.Add(mainImage);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(RegisterBtn);
            Controls.Add(LoginBtn);
            Controls.Add(subtext);
            Controls.Add(title);
            Controls.Add(welcome);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Healthcare Plus";
            ((System.ComponentModel.ISupportInitialize)mainImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel welcome;
        private Krypton.Toolkit.KryptonLabel title;
        private Krypton.Toolkit.KryptonWrapLabel subtext;
        private Krypton.Toolkit.KryptonButton LoginBtn;
        private Krypton.Toolkit.KryptonButton RegisterBtn;
        private Krypton.Toolkit.KryptonTextBox Username;
        private Krypton.Toolkit.KryptonTextBox Password;
        private PictureBox mainImage;
    }
}