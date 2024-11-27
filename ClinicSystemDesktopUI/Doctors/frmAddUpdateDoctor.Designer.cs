namespace ClinicSystem.Doctors
{
    partial class frmAddUpdateDoctor
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
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainerEmployeeInfo = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtCareer = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSaveEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picPerson = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labEmployeeId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPersonId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPerson = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labEmployee = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabEmployeeInfo = new System.Windows.Forms.TabPage();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.uc_personInfo1 = new ClinicSystem.UserControls.uc_personInfo();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSelectPerson = new Guna.UI2.WinForms.Guna2Button();
            this.TabCtrlAddOrUpdateCustomers = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabDoctorInfo = new System.Windows.Forms.TabPage();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cbSpecialization = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picDoctor = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labDoctorId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labEmployeeDocId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labDoctor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelContainerEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            this.tabEmployeeInfo.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.TabCtrlAddOrUpdateCustomers.SuspendLayout();
            this.tabDoctorInfo.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoctor)).BeginInit();
            this.SuspendLayout();
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
            this.btnCancel.FillColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(619, 671);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 54);
            this.btnCancel.TabIndex = 128;
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
            this.btnSave.FillColor = System.Drawing.Color.DarkGray;
            this.btnSave.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(462, 671);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 54);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelContainerEmployeeInfo
            // 
            this.panelContainerEmployeeInfo.Controls.Add(this.txtCareer);
            this.panelContainerEmployeeInfo.Controls.Add(this.btnSaveEmployee);
            this.panelContainerEmployeeInfo.Controls.Add(this.guna2HtmlLabel2);
            this.panelContainerEmployeeInfo.Controls.Add(this.picPerson);
            this.panelContainerEmployeeInfo.Controls.Add(this.labEmployeeId);
            this.panelContainerEmployeeInfo.Controls.Add(this.labPersonId);
            this.panelContainerEmployeeInfo.Controls.Add(this.labPerson);
            this.panelContainerEmployeeInfo.Controls.Add(this.txtSalary);
            this.panelContainerEmployeeInfo.Controls.Add(this.guna2HtmlLabel9);
            this.panelContainerEmployeeInfo.Controls.Add(this.labEmployee);
            this.panelContainerEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainerEmployeeInfo.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainerEmployeeInfo.FillColor2 = System.Drawing.Color.Silver;
            this.panelContainerEmployeeInfo.Location = new System.Drawing.Point(3, 3);
            this.panelContainerEmployeeInfo.Name = "panelContainerEmployeeInfo";
            this.panelContainerEmployeeInfo.Size = new System.Drawing.Size(1265, 578);
            this.panelContainerEmployeeInfo.TabIndex = 150;
            // 
            // txtCareer
            // 
            this.txtCareer.Animated = true;
            this.txtCareer.AutoRoundedCorners = true;
            this.txtCareer.BackColor = System.Drawing.Color.Transparent;
            this.txtCareer.BorderRadius = 17;
            this.txtCareer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCareer.DefaultText = "Doctor";
            this.txtCareer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCareer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCareer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCareer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCareer.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCareer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCareer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCareer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCareer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCareer.Location = new System.Drawing.Point(312, 437);
            this.txtCareer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCareer.Name = "txtCareer";
            this.txtCareer.PasswordChar = '\0';
            this.txtCareer.PlaceholderText = "";
            this.txtCareer.ReadOnly = true;
            this.txtCareer.SelectedText = "";
            this.txtCareer.Size = new System.Drawing.Size(200, 36);
            this.txtCareer.TabIndex = 159;
            this.txtCareer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Animated = true;
            this.btnSaveEmployee.AutoRoundedCorners = true;
            this.btnSaveEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveEmployee.BorderRadius = 26;
            this.btnSaveEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveEmployee.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveEmployee.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnSaveEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveEmployee.Location = new System.Drawing.Point(630, 451);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(182, 54);
            this.btnSaveEmployee.TabIndex = 130;
            this.btnSaveEmployee.Text = "Save Employee";
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
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
            this.picPerson.BackColor = System.Drawing.Color.Transparent;
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
            // labPerson
            // 
            this.labPerson.AutoSize = false;
            this.labPerson.BackColor = System.Drawing.Color.Transparent;
            this.labPerson.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPerson.Location = new System.Drawing.Point(85, 302);
            this.labPerson.Name = "labPerson";
            this.labPerson.Size = new System.Drawing.Size(111, 34);
            this.labPerson.TabIndex = 155;
            this.labPerson.Text = "Person Id:";
            // 
            // txtSalary
            // 
            this.txtSalary.Animated = true;
            this.txtSalary.AutoRoundedCorners = true;
            this.txtSalary.BackColor = System.Drawing.Color.Transparent;
            this.txtSalary.BorderRadius = 17;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Location = new System.Drawing.Point(312, 372);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderText = "";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(200, 36);
            this.txtSalary.TabIndex = 152;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // 
            // tabEmployeeInfo
            // 
            this.tabEmployeeInfo.BackColor = System.Drawing.Color.Silver;
            this.tabEmployeeInfo.Controls.Add(this.panelContainerEmployeeInfo);
            this.tabEmployeeInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabEmployeeInfo.Location = new System.Drawing.Point(4, 4);
            this.tabEmployeeInfo.Name = "tabEmployeeInfo";
            this.tabEmployeeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployeeInfo.Size = new System.Drawing.Size(1271, 584);
            this.tabEmployeeInfo.TabIndex = 1;
            this.tabEmployeeInfo.Text = "Employee Info";
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tabPersonInfo.Controls.Add(this.uc_personInfo1);
            this.tabPersonInfo.Controls.Add(this.guna2HtmlLabel1);
            this.tabPersonInfo.Controls.Add(this.btnSelectPerson);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 4);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(1271, 584);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            // 
            // uc_personInfo1
            // 
            this.uc_personInfo1.BackColor = System.Drawing.Color.Transparent;
            this.uc_personInfo1.Location = new System.Drawing.Point(177, 81);
            this.uc_personInfo1.Name = "uc_personInfo1";
            this.uc_personInfo1.Size = new System.Drawing.Size(743, 500);
            this.uc_personInfo1.TabIndex = 8;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(177, 11);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(459, 28);
            this.guna2HtmlLabel1.TabIndex = 7;
            this.guna2HtmlLabel1.Text = "You must enter the employee\'s basic information first.";
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
            this.btnSelectPerson.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSelectPerson.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPerson.ForeColor = System.Drawing.Color.Black;
            this.btnSelectPerson.HoverState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnSelectPerson.Location = new System.Drawing.Point(689, 8);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(180, 45);
            this.btnSelectPerson.TabIndex = 6;
            this.btnSelectPerson.Text = "Select a Person";
            // 
            // TabCtrlAddOrUpdateCustomers
            // 
            this.TabCtrlAddOrUpdateCustomers.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.TabCtrlAddOrUpdateCustomers.Controls.Add(this.tabPersonInfo);
            this.TabCtrlAddOrUpdateCustomers.Controls.Add(this.tabEmployeeInfo);
            this.TabCtrlAddOrUpdateCustomers.Controls.Add(this.tabDoctorInfo);
            this.TabCtrlAddOrUpdateCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabCtrlAddOrUpdateCustomers.ItemSize = new System.Drawing.Size(180, 40);
            this.TabCtrlAddOrUpdateCustomers.Location = new System.Drawing.Point(0, 0);
            this.TabCtrlAddOrUpdateCustomers.Name = "TabCtrlAddOrUpdateCustomers";
            this.TabCtrlAddOrUpdateCustomers.SelectedIndex = 0;
            this.TabCtrlAddOrUpdateCustomers.Size = new System.Drawing.Size(1459, 592);
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
            this.TabCtrlAddOrUpdateCustomers.TabIndex = 129;
            this.TabCtrlAddOrUpdateCustomers.TabMenuBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TabCtrlAddOrUpdateCustomers.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            // 
            // tabDoctorInfo
            // 
            this.tabDoctorInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabDoctorInfo.Controls.Add(this.guna2GradientPanel1);
            this.tabDoctorInfo.Location = new System.Drawing.Point(4, 4);
            this.tabDoctorInfo.Name = "tabDoctorInfo";
            this.tabDoctorInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoctorInfo.Size = new System.Drawing.Size(1271, 584);
            this.tabDoctorInfo.TabIndex = 2;
            this.tabDoctorInfo.Text = "Doctor Info";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.cbSpecialization);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GradientPanel1.Controls.Add(this.picDoctor);
            this.guna2GradientPanel1.Controls.Add(this.labDoctorId);
            this.guna2GradientPanel1.Controls.Add(this.labEmployeeDocId);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GradientPanel1.Controls.Add(this.labDoctor);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Silver;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1265, 578);
            this.guna2GradientPanel1.TabIndex = 151;
            // 
            // cbSpecialization
            // 
            this.cbSpecialization.AutoRoundedCorners = true;
            this.cbSpecialization.BackColor = System.Drawing.Color.Transparent;
            this.cbSpecialization.BorderRadius = 17;
            this.cbSpecialization.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSpecialization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecialization.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbSpecialization.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSpecialization.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSpecialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSpecialization.ItemHeight = 30;
            this.cbSpecialization.Location = new System.Drawing.Point(272, 362);
            this.cbSpecialization.Name = "cbSpecialization";
            this.cbSpecialization.Size = new System.Drawing.Size(200, 36);
            this.cbSpecialization.TabIndex = 159;
            this.cbSpecialization.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(85, 362);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(146, 36);
            this.guna2HtmlLabel3.TabIndex = 158;
            this.guna2HtmlLabel3.Text = "Specialization:";
            // 
            // picDoctor
            // 
            this.picDoctor.BackColor = System.Drawing.Color.Transparent;
            this.picDoctor.FillColor = System.Drawing.Color.DimGray;
            this.picDoctor.ImageRotate = 0F;
            this.picDoctor.Location = new System.Drawing.Point(388, 0);
            this.picDoctor.Name = "picDoctor";
            this.picDoctor.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picDoctor.Size = new System.Drawing.Size(217, 200);
            this.picDoctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDoctor.TabIndex = 157;
            this.picDoctor.TabStop = false;
            // 
            // labDoctorId
            // 
            this.labDoctorId.AutoSize = false;
            this.labDoctorId.BackColor = System.Drawing.Color.Transparent;
            this.labDoctorId.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDoctorId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labDoctorId.Location = new System.Drawing.Point(551, 209);
            this.labDoctorId.Name = "labDoctorId";
            this.labDoctorId.Size = new System.Drawing.Size(95, 32);
            this.labDoctorId.TabIndex = 146;
            this.labDoctorId.Text = "??";
            this.labDoctorId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labEmployeeDocId
            // 
            this.labEmployeeDocId.AutoSize = false;
            this.labEmployeeDocId.BackColor = System.Drawing.Color.Transparent;
            this.labEmployeeDocId.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployeeDocId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labEmployeeDocId.Location = new System.Drawing.Point(312, 304);
            this.labEmployeeDocId.Name = "labEmployeeDocId";
            this.labEmployeeDocId.Size = new System.Drawing.Size(95, 32);
            this.labEmployeeDocId.TabIndex = 156;
            this.labEmployeeDocId.Text = "??";
            this.labEmployeeDocId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(85, 302);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(134, 34);
            this.guna2HtmlLabel6.TabIndex = 155;
            this.guna2HtmlLabel6.Text = "Employee Id:";
            // 
            // labDoctor
            // 
            this.labDoctor.AutoSize = false;
            this.labDoctor.BackColor = System.Drawing.Color.Transparent;
            this.labDoctor.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDoctor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labDoctor.Location = new System.Drawing.Point(388, 209);
            this.labDoctor.Name = "labDoctor";
            this.labDoctor.Size = new System.Drawing.Size(157, 32);
            this.labDoctor.TabIndex = 154;
            this.labDoctor.Text = "Doctor Id:";
            // 
            // frmAddUpdateDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1459, 749);
            this.Controls.Add(this.TabCtrlAddOrUpdateCustomers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateDoctor";
            this.Text = "frmAddUpdateDoctor";
            this.Load += new System.EventHandler(this.frmAddUpdateDoctor_Load);
            this.panelContainerEmployeeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            this.tabEmployeeInfo.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.TabCtrlAddOrUpdateCustomers.ResumeLayout(false);
            this.tabDoctorInfo.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDoctor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2GradientPanel panelContainerEmployeeInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picPerson;
        private Guna.UI2.WinForms.Guna2HtmlLabel labEmployeeId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPersonId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPerson;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel labEmployee;
        private System.Windows.Forms.TabPage tabEmployeeInfo;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private Guna.UI2.WinForms.Guna2TabControl TabCtrlAddOrUpdateCustomers;
        private System.Windows.Forms.TabPage tabDoctorInfo;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbSpecialization;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picDoctor;
        private Guna.UI2.WinForms.Guna2HtmlLabel labDoctorId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labEmployeeDocId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel labDoctor;
        private Guna.UI2.WinForms.Guna2Button btnSaveEmployee;
        private Guna.UI2.WinForms.Guna2TextBox txtCareer;
        private UserControls.uc_personInfo uc_personInfo1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSelectPerson;
    }
}