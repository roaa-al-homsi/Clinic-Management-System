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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.labUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picCurrentUser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnTitle = new Guna.UI2.WinForms.Guna2Button();
            this.labCurrentUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMainMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.labLoginDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDoctors = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPatients = new Guna.UI2.WinForms.Guna2Button();
            this.btnAppointements = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayments = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentUser)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Black;
            this.guna2Panel2.Controls.Add(this.labUserName);
            this.guna2Panel2.Controls.Add(this.picCurrentUser);
            this.guna2Panel2.Controls.Add(this.btnTitle);
            this.guna2Panel2.Controls.Add(this.labCurrentUser);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FloralWhite;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1707, 70);
            this.guna2Panel2.TabIndex = 8;
            // 
            // labUserName
            // 
            this.labUserName.BackColor = System.Drawing.Color.Transparent;
            this.labUserName.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(73)))), ((int)(((byte)(225)))));
            this.labUserName.Location = new System.Drawing.Point(827, 38);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(3, 2);
            this.labUserName.TabIndex = 1;
            this.labUserName.Text = null;
            this.labUserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picCurrentUser
            // 
            this.picCurrentUser.Image = ((System.Drawing.Image)(resources.GetObject("picCurrentUser.Image")));
            this.picCurrentUser.ImageRotate = 0F;
            this.picCurrentUser.Location = new System.Drawing.Point(1639, 12);
            this.picCurrentUser.Name = "picCurrentUser";
            this.picCurrentUser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picCurrentUser.Size = new System.Drawing.Size(59, 53);
            this.picCurrentUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCurrentUser.TabIndex = 3;
            this.picCurrentUser.TabStop = false;
            // 
            // btnTitle
            // 
            this.btnTitle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTitle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTitle.FillColor = System.Drawing.Color.Silver;
            this.btnTitle.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTitle.Image = ((System.Drawing.Image)(resources.GetObject("btnTitle.Image")));
            this.btnTitle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTitle.ImageSize = new System.Drawing.Size(40, 40);
            this.btnTitle.Location = new System.Drawing.Point(3, 3);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(196, 50);
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
            this.labCurrentUser.Location = new System.Drawing.Point(1521, 22);
            this.labCurrentUser.Name = "labCurrentUser";
            this.labCurrentUser.Size = new System.Drawing.Size(100, 43);
            this.labCurrentUser.TabIndex = 0;
            this.labCurrentUser.Text = "user";
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMainMenu.FillColor = System.Drawing.Color.Lavender;
            this.panelMainMenu.Location = new System.Drawing.Point(12, 164);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1686, 685);
            this.panelMainMenu.TabIndex = 8;
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
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.guna2Panel1.Controls.Add(this.btnDoctors);
            this.guna2Panel1.Controls.Add(this.btnLogout);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.btnPatients);
            this.guna2Panel1.Controls.Add(this.btnAppointements);
            this.guna2Panel1.Controls.Add(this.btnPayments);
            this.guna2Panel1.Controls.Add(this.btnUsers);
            this.guna2Panel1.Controls.Add(this.btnEmployees);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 70);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1707, 73);
            this.guna2Panel1.TabIndex = 17;
            // 
            // btnDoctors
            // 
            this.btnDoctors.BackColor = System.Drawing.Color.Black;
            this.btnDoctors.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctors.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoctors.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDoctors.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoctors.FillColor = System.Drawing.SystemColors.MenuBar;
            this.btnDoctors.Font = new System.Drawing.Font("Andalus", 10.8F);
            this.btnDoctors.ForeColor = System.Drawing.Color.Black;
            this.btnDoctors.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctors.Image")));
            this.btnDoctors.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoctors.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDoctors.Location = new System.Drawing.Point(12, 16);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(157, 54);
            this.btnDoctors.TabIndex = 2;
            this.btnDoctors.Tag = "Doctors";
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(1453, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 65);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Tag = "Logout";
            this.btnLogout.Text = "Logout";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.SkyBlue;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.MenuBar;
            this.guna2Button1.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(1269, 15);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(158, 55);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Tag = "Logins";
            this.guna2Button1.Text = "Logins";
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.Color.Black;
            this.btnPatients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPatients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPatients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPatients.FillColor = System.Drawing.SystemColors.MenuBar;
            this.btnPatients.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.Black;
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
            this.btnAppointements.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAppointements.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAppointements.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAppointements.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppointements.FillColor = System.Drawing.SystemColors.MenuBar;
            this.btnAppointements.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointements.ForeColor = System.Drawing.Color.Black;
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
            this.btnPayments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayments.FillColor = System.Drawing.SystemColors.MenuBar;
            this.btnPayments.Font = new System.Drawing.Font("Andalus", 10.8F);
            this.btnPayments.ForeColor = System.Drawing.Color.Black;
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
            this.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsers.FillColor = System.Drawing.SystemColors.MenuBar;
            this.btnUsers.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUsers.Location = new System.Drawing.Point(1049, 13);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(213, 57);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Tag = "Users";
            this.btnUsers.Text = "Users";
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEmployees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployees.FillColor = System.Drawing.SystemColors.MenuBar;
            this.btnEmployees.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.Black;
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
            // frmMainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1707, 850);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainMenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenuScreen";
            this.Load += new System.EventHandler(this.frmMainMenuScreen_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrentUser)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel labUserName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picCurrentUser;
        private Guna.UI2.WinForms.Guna2Button btnTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel labCurrentUser;
        private Guna.UI2.WinForms.Guna2Panel panelMainMenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel labLoginDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDoctors;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnPatients;
        private Guna.UI2.WinForms.Guna2Button btnAppointements;
        private Guna.UI2.WinForms.Guna2Button btnPayments;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnEmployees;
    }
}