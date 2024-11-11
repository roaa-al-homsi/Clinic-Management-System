namespace ClinicSystem.Employees
{
    partial class frmAddUpdateEmployee
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
            this.TabCtrlAddOrUpdateCustomers = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSelectPerson = new Guna.UI2.WinForms.Guna2Button();
            this.tabUserInfo = new System.Windows.Forms.TabPage();
            this.panelContainerUserInfo = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picPerson = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labEmployeeId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPersonId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPersonte = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labEmployee = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.uc_Persons1 = new ClinicSystem.UserControls.uc_Persons();
            this.TabCtrlAddOrUpdateCustomers.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabUserInfo.SuspendLayout();
            this.panelContainerUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCtrlAddOrUpdateCustomers
            // 
            this.TabCtrlAddOrUpdateCustomers.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.TabCtrlAddOrUpdateCustomers.Controls.Add(this.tabPersonInfo);
            this.TabCtrlAddOrUpdateCustomers.Controls.Add(this.tabUserInfo);
            this.TabCtrlAddOrUpdateCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabCtrlAddOrUpdateCustomers.ItemSize = new System.Drawing.Size(180, 40);
            this.TabCtrlAddOrUpdateCustomers.Location = new System.Drawing.Point(0, 0);
            this.TabCtrlAddOrUpdateCustomers.Name = "TabCtrlAddOrUpdateCustomers";
            this.TabCtrlAddOrUpdateCustomers.SelectedIndex = 0;
            this.TabCtrlAddOrUpdateCustomers.Size = new System.Drawing.Size(1686, 591);
            this.TabCtrlAddOrUpdateCustomers.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabCtrlAddOrUpdateCustomers.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabCtrlAddOrUpdateCustomers.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabCtrlAddOrUpdateCustomers.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabCtrlAddOrUpdateCustomers.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabCtrlAddOrUpdateCustomers.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabCtrlAddOrUpdateCustomers.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabCtrlAddOrUpdateCustomers.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabCtrlAddOrUpdateCustomers.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabCtrlAddOrUpdateCustomers.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabCtrlAddOrUpdateCustomers.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabCtrlAddOrUpdateCustomers.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabCtrlAddOrUpdateCustomers.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabCtrlAddOrUpdateCustomers.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabCtrlAddOrUpdateCustomers.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabCtrlAddOrUpdateCustomers.TabButtonSize = new System.Drawing.Size(180, 40);
            this.TabCtrlAddOrUpdateCustomers.TabIndex = 123;
            this.TabCtrlAddOrUpdateCustomers.TabMenuBackColor = System.Drawing.Color.Silver;
            this.TabCtrlAddOrUpdateCustomers.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.BackColor = System.Drawing.Color.Silver;
            this.tabPersonInfo.Controls.Add(this.uc_Persons1);
            this.tabPersonInfo.Controls.Add(this.guna2HtmlLabel1);
            this.tabPersonInfo.Controls.Add(this.btnSelectPerson);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 4);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(1498, 583);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(48, 150);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(495, 26);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "You must enter the user\'s basic information first.";
            // 
            // btnSelectPerson
            // 
            this.btnSelectPerson.AutoRoundedCorners = true;
            this.btnSelectPerson.BorderRadius = 21;
            this.btnSelectPerson.CheckedState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnSelectPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectPerson.FillColor = System.Drawing.Color.Black;
            this.btnSelectPerson.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPerson.ForeColor = System.Drawing.Color.White;
            this.btnSelectPerson.HoverState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnSelectPerson.Location = new System.Drawing.Point(174, 196);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(180, 45);
            this.btnSelectPerson.TabIndex = 1;
            this.btnSelectPerson.Text = "Select a Person";
            // 
            // tabUserInfo
            // 
            this.tabUserInfo.BackColor = System.Drawing.Color.Silver;
            this.tabUserInfo.Controls.Add(this.panelContainerUserInfo);
            this.tabUserInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabUserInfo.Location = new System.Drawing.Point(4, 4);
            this.tabUserInfo.Name = "tabUserInfo";
            this.tabUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserInfo.Size = new System.Drawing.Size(1498, 583);
            this.tabUserInfo.TabIndex = 1;
            this.tabUserInfo.Text = "User Info";
            // 
            // panelContainerUserInfo
            // 
            this.panelContainerUserInfo.Controls.Add(this.guna2ComboBox1);
            this.panelContainerUserInfo.Controls.Add(this.guna2HtmlLabel2);
            this.panelContainerUserInfo.Controls.Add(this.picPerson);
            this.panelContainerUserInfo.Controls.Add(this.labEmployeeId);
            this.panelContainerUserInfo.Controls.Add(this.labPersonId);
            this.panelContainerUserInfo.Controls.Add(this.labPersonte);
            this.panelContainerUserInfo.Controls.Add(this.txtUserName);
            this.panelContainerUserInfo.Controls.Add(this.guna2HtmlLabel9);
            this.panelContainerUserInfo.Controls.Add(this.labEmployee);
            this.panelContainerUserInfo.Enabled = false;
            this.panelContainerUserInfo.Location = new System.Drawing.Point(6, 8);
            this.panelContainerUserInfo.Name = "panelContainerUserInfo";
            this.panelContainerUserInfo.Size = new System.Drawing.Size(1045, 540);
            this.panelContainerUserInfo.TabIndex = 150;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(312, 437);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2ComboBox1.TabIndex = 159;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(85, 437);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(146, 36);
            this.guna2HtmlLabel2.TabIndex = 158;
            this.guna2HtmlLabel2.Text = "Career :";
            // 
            // picPerson
            // 
            this.picPerson.FillColor = System.Drawing.Color.DimGray;
            this.picPerson.ImageRotate = 0F;
            this.picPerson.Location = new System.Drawing.Point(388, 3);
            this.picPerson.Name = "picPerson";
            this.picPerson.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picPerson.Size = new System.Drawing.Size(217, 200);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerson.TabIndex = 157;
            this.picPerson.TabStop = false;
            // 
            // labEmployeeId
            // 
            this.labEmployeeId.AutoSize = false;
            this.labEmployeeId.BackColor = System.Drawing.Color.Transparent;
            this.labEmployeeId.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployeeId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labEmployeeId.Location = new System.Drawing.Point(551, 209);
            this.labEmployeeId.Name = "labEmployeeId";
            this.labEmployeeId.Size = new System.Drawing.Size(95, 32);
            this.labEmployeeId.TabIndex = 146;
            this.labEmployeeId.Text = "??";
            this.labEmployeeId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.labEmployeeId.Visible = false;
            // 
            // labPersonId
            // 
            this.labPersonId.AutoSize = false;
            this.labPersonId.BackColor = System.Drawing.Color.Transparent;
            this.labPersonId.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPersonId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPersonId.Location = new System.Drawing.Point(312, 304);
            this.labPersonId.Name = "labPersonId";
            this.labPersonId.Size = new System.Drawing.Size(95, 32);
            this.labPersonId.TabIndex = 156;
            this.labPersonId.Text = "??";
            this.labPersonId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labPersonte
            // 
            this.labPersonte.AutoSize = false;
            this.labPersonte.BackColor = System.Drawing.Color.Transparent;
            this.labPersonte.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPersonte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPersonte.Location = new System.Drawing.Point(85, 302);
            this.labPersonte.Name = "labPersonte";
            this.labPersonte.Size = new System.Drawing.Size(111, 34);
            this.labPersonte.TabIndex = 155;
            this.labPersonte.Text = "Person Id:";
            // 
            // txtUserName
            // 
            this.txtUserName.Animated = true;
            this.txtUserName.AutoRoundedCorners = true;
            this.txtUserName.BorderRadius = 17;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FillColor = System.Drawing.Color.Black;
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Location = new System.Drawing.Point(312, 372);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(200, 36);
            this.txtUserName.TabIndex = 152;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(85, 372);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(146, 36);
            this.guna2HtmlLabel9.TabIndex = 151;
            this.guna2HtmlLabel9.Text = "Salary:";
            // 
            // labEmployee
            // 
            this.labEmployee.AutoSize = false;
            this.labEmployee.BackColor = System.Drawing.Color.Transparent;
            this.labEmployee.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labEmployee.Location = new System.Drawing.Point(388, 209);
            this.labEmployee.Name = "labEmployee";
            this.labEmployee.Size = new System.Drawing.Size(157, 32);
            this.labEmployee.TabIndex = 154;
            this.labEmployee.Text = "Employee Id:";
            this.labEmployee.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 26;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(852, 619);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 54);
            this.btnCancel.TabIndex = 125;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 26;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(695, 619);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 54);
            this.btnSave.TabIndex = 124;
            this.btnSave.Text = "Save";
            // 
            // uc_Persons1
            // 
            this.uc_Persons1.Location = new System.Drawing.Point(525, 22);
            this.uc_Persons1.Name = "uc_Persons1";
            this.uc_Persons1.Size = new System.Drawing.Size(774, 555);
            this.uc_Persons1.TabIndex = 3;
            // 
            // frmAddUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1686, 685);
            this.Controls.Add(this.TabCtrlAddOrUpdateCustomers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateEmployee";
            this.Text = "frmAddUpdateEmployee";
            this.TabCtrlAddOrUpdateCustomers.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabUserInfo.ResumeLayout(false);
            this.panelContainerUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl TabCtrlAddOrUpdateCustomers;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSelectPerson;
        private System.Windows.Forms.TabPage tabUserInfo;
        private Guna.UI2.WinForms.Guna2GradientPanel panelContainerUserInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picPerson;
        private Guna.UI2.WinForms.Guna2HtmlLabel labEmployeeId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPersonId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPersonte;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel labEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private UserControls.uc_Persons uc_Persons1;
    }
}