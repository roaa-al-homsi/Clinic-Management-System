namespace ClinicSystem.MainMenu
{
    partial class frmMainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenuScreen));
            this.btnTitle = new Guna.UI2.WinForms.Guna2Button();
            this.labCurrentUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labLoginDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDoctors = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.btnAppointements = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayments = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.picUserMain = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelMainMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.Transparent;
            this.btnTitle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTitle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTitle.FillColor = System.Drawing.Color.Transparent;
            this.btnTitle.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTitle.Image = ((System.Drawing.Image)(resources.GetObject("btnTitle.Image")));
            this.btnTitle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTitle.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTitle.Location = new System.Drawing.Point(12, 4);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(426, 47);
            this.btnTitle.TabIndex = 2;
            this.btnTitle.Text = "Home";
            this.btnTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labCurrentUser
            // 
            this.labCurrentUser.AutoSize = false;
            this.labCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.labCurrentUser.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCurrentUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labCurrentUser.Location = new System.Drawing.Point(1243, 10);
            this.labCurrentUser.Name = "labCurrentUser";
            this.labCurrentUser.Size = new System.Drawing.Size(108, 38);
            this.labCurrentUser.TabIndex = 0;
            this.labCurrentUser.Text = "user";
            // 
            // labLoginDate
            // 
            this.labLoginDate.AutoSize = false;
            this.labLoginDate.BackColor = System.Drawing.Color.Transparent;
            this.labLoginDate.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLoginDate.ForeColor = System.Drawing.Color.FloralWhite;
            this.labLoginDate.Location = new System.Drawing.Point(494, 248);
            this.labLoginDate.Name = "labLoginDate";
            this.labLoginDate.Size = new System.Drawing.Size(259, 65);
            this.labLoginDate.TabIndex = 0;
            this.labLoginDate.Text = null;
            this.labLoginDate.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.guna2Panel1.Controls.Add(this.btnDoctors);
            this.guna2Panel1.Controls.Add(this.btnLogout);
            this.guna2Panel1.Controls.Add(this.btnPatients);
            this.guna2Panel1.Controls.Add(this.btnAppointements);
            this.guna2Panel1.Controls.Add(this.btnPayments);
            this.guna2Panel1.Controls.Add(this.btnUsers);
            this.guna2Panel1.Controls.Add(this.btnEmployees);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 54);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1459, 70);
            this.guna2Panel1.TabIndex = 17;
            // 
            // btnDoctors
            // 
            this.btnDoctors.BackColor = System.Drawing.Color.Black;
            this.btnDoctors.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDoctors.CheckedState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnDoctors.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDoctors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoctors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoctors.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDoctors.Font = new System.Drawing.Font("Andalus", 10.8F);
            this.btnDoctors.ForeColor = System.Drawing.Color.Black;
            this.btnDoctors.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnDoctors.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctors.Image")));
            this.btnDoctors.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoctors.ImageSize = new System.Drawing.Size(70, 70);
            this.btnDoctors.Location = new System.Drawing.Point(12, 16);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(157, 54);
            this.btnDoctors.TabIndex = 2;
            this.btnDoctors.Tag = "Doctors";
            this.btnDoctors.Text = "  Doctors";
            this.btnDoctors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(1255, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(147, 64);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Tag = "Logout";
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.Color.Black;
            this.btnPatients.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPatients.CheckedState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnPatients.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnPatients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatients.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPatients.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.Black;
            this.btnPatients.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnPatients.Image = ((System.Drawing.Image)(resources.GetObject("btnPatients.Image")));
            this.btnPatients.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPatients.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPatients.Location = new System.Drawing.Point(172, 16);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(172, 54);
            this.btnPatients.TabIndex = 3;
            this.btnPatients.Tag = "Patients";
            this.btnPatients.Text = "Patients";
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnAppointements
            // 
            this.btnAppointements.BackColor = System.Drawing.Color.Black;
            this.btnAppointements.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAppointements.CheckedState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnAppointements.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnAppointements.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAppointements.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAppointements.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppointements.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppointements.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnAppointements.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointements.ForeColor = System.Drawing.Color.Black;
            this.btnAppointements.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnAppointements.Image = ((System.Drawing.Image)(resources.GetObject("btnAppointements.Image")));
            this.btnAppointements.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAppointements.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAppointements.Location = new System.Drawing.Point(360, 13);
            this.btnAppointements.Name = "btnAppointements";
            this.btnAppointements.Size = new System.Drawing.Size(213, 57);
            this.btnAppointements.TabIndex = 4;
            this.btnAppointements.Tag = "Appointements";
            this.btnAppointements.Text = "Appointements";
            this.btnAppointements.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.Black;
            this.btnPayments.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPayments.CheckedState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnPayments.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnPayments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayments.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPayments.Font = new System.Drawing.Font("Andalus", 10.8F);
            this.btnPayments.ForeColor = System.Drawing.Color.Black;
            this.btnPayments.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPayments.Image")));
            this.btnPayments.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPayments.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPayments.Location = new System.Drawing.Point(576, 13);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(213, 57);
            this.btnPayments.TabIndex = 8;
            this.btnPayments.Tag = "Payments";
            this.btnPayments.Text = "Payments";
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Black;
            this.btnUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUsers.CheckedState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUsers.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUsers.Location = new System.Drawing.Point(1049, 13);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(213, 57);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Tag = "Users";
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmployees.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployees.CheckedState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployees.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnEmployees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployees.FillColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEmployees.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.Black;
            this.btnEmployees.HoverState.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployees.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployees.Location = new System.Drawing.Point(815, 13);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(213, 57);
            this.btnEmployees.TabIndex = 12;
            this.btnEmployees.Tag = "Employee";
            this.btnEmployees.Text = "Employee";
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click_1);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.labCurrentUser);
            this.guna2CustomGradientPanel1.Controls.Add(this.picUserMain);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnTitle);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.ActiveCaption;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.DarkGray;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1459, 54);
            this.guna2CustomGradientPanel1.TabIndex = 4;
            // 
            // picUserMain
            // 
            this.picUserMain.BackColor = System.Drawing.Color.Transparent;
            this.picUserMain.Image = ((System.Drawing.Image)(resources.GetObject("picUserMain.Image")));
            this.picUserMain.ImageRotate = 0F;
            this.picUserMain.Location = new System.Drawing.Point(1387, 3);
            this.picUserMain.Name = "picUserMain";
            this.picUserMain.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picUserMain.Size = new System.Drawing.Size(60, 48);
            this.picUserMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserMain.TabIndex = 4;
            this.picUserMain.TabStop = false;
            this.picUserMain.UseTransparentBackground = true;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelMainMenu.FillColor = System.Drawing.Color.White;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 130);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1433, 749);
            this.panelMainMenu.TabIndex = 8;
            // 
            // frmMainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1459, 881);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenuScreen";
            this.Load += new System.EventHandler(this.frmMainMenuScreen_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel labCurrentUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel labLoginDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDoctors;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnPatients;
        private Guna.UI2.WinForms.Guna2Button btnAppointements;
        private Guna.UI2.WinForms.Guna2Button btnPayments;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnEmployees;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picUserMain;
        private Guna.UI2.WinForms.Guna2Panel panelMainMenu;
    }
}