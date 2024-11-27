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
            this.uc_personInfo1 = new ClinicSystem.UserControls.uc_personInfo();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSelectPerson = new Guna.UI2.WinForms.Guna2Button();
            this.tabEmployeeInfo = new System.Windows.Forms.TabPage();
            this.panelContainerEmployeeInfo = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.cbCareer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.picPerson = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.labEmployeeId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPersonId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPerson = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labEmployee = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.TabCtrlAddOrUpdateCustomers.SuspendLayout();
            this.tabPersonInfo.SuspendLayout();
            this.tabEmployeeInfo.SuspendLayout();
            this.panelContainerEmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // TabCtrlAddOrUpdateCustomers
            // 
            this.TabCtrlAddOrUpdateCustomers.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.TabCtrlAddOrUpdateCustomers.Controls.Add(this.tabPersonInfo);
            this.TabCtrlAddOrUpdateCustomers.Controls.Add(this.tabEmployeeInfo);
            this.TabCtrlAddOrUpdateCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabCtrlAddOrUpdateCustomers.ItemSize = new System.Drawing.Size(180, 40);
            this.TabCtrlAddOrUpdateCustomers.Location = new System.Drawing.Point(0, 0);
            this.TabCtrlAddOrUpdateCustomers.Name = "TabCtrlAddOrUpdateCustomers";
            this.TabCtrlAddOrUpdateCustomers.SelectedIndex = 0;
            this.TabCtrlAddOrUpdateCustomers.Size = new System.Drawing.Size(1459, 589);
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
            this.TabCtrlAddOrUpdateCustomers.TabMenuBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TabCtrlAddOrUpdateCustomers.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPersonInfo.Controls.Add(this.uc_personInfo1);
            this.tabPersonInfo.Controls.Add(this.guna2HtmlLabel1);
            this.tabPersonInfo.Controls.Add(this.btnSelectPerson);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 4);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(1271, 581);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Person Info";
            // 
            // uc_personInfo1
            // 
            this.uc_personInfo1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.uc_personInfo1.Location = new System.Drawing.Point(312, 97);
            this.uc_personInfo1.Name = "uc_personInfo1";
            this.uc_personInfo1.Size = new System.Drawing.Size(808, 481);
            this.uc_personInfo1.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(312, 50);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(488, 30);
            this.guna2HtmlLabel1.TabIndex = 2;
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
            this.btnSelectPerson.FillColor = System.Drawing.Color.Black;
            this.btnSelectPerson.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPerson.ForeColor = System.Drawing.Color.White;
            this.btnSelectPerson.HoverState.CustomBorderColor = System.Drawing.Color.HotPink;
            this.btnSelectPerson.Location = new System.Drawing.Point(873, 45);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(180, 45);
            this.btnSelectPerson.TabIndex = 1;
            this.btnSelectPerson.Text = "Select a Person";
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
            // 
            // tabEmployeeInfo
            // 
            this.tabEmployeeInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabEmployeeInfo.Controls.Add(this.panelContainerEmployeeInfo);
            this.tabEmployeeInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabEmployeeInfo.Location = new System.Drawing.Point(4, 4);
            this.tabEmployeeInfo.Name = "tabEmployeeInfo";
            this.tabEmployeeInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployeeInfo.Size = new System.Drawing.Size(1271, 581);
            this.tabEmployeeInfo.TabIndex = 1;
            this.tabEmployeeInfo.Text = "Employee Info";
            // 
            // panelContainerEmployeeInfo
            // 
            this.panelContainerEmployeeInfo.Controls.Add(this.cbCareer);
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
            this.panelContainerEmployeeInfo.FillColor3 = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainerEmployeeInfo.Location = new System.Drawing.Point(3, 3);
            this.panelContainerEmployeeInfo.Name = "panelContainerEmployeeInfo";
            this.panelContainerEmployeeInfo.Size = new System.Drawing.Size(1265, 575);
            this.panelContainerEmployeeInfo.TabIndex = 151;
            // 
            // cbCareer
            // 
            this.cbCareer.AutoRoundedCorners = true;
            this.cbCareer.BackColor = System.Drawing.Color.Transparent;
            this.cbCareer.BorderRadius = 17;
            this.cbCareer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCareer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCareer.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbCareer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCareer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCareer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCareer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbCareer.ItemHeight = 30;
            this.cbCareer.Location = new System.Drawing.Point(719, 471);
            this.cbCareer.Name = "cbCareer";
            this.cbCareer.Size = new System.Drawing.Size(200, 36);
            this.cbCareer.TabIndex = 168;
            this.cbCareer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(492, 471);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(146, 36);
            this.guna2HtmlLabel2.TabIndex = 167;
            this.guna2HtmlLabel2.Text = "Career :";
            // 
            // picPerson
            // 
            this.picPerson.BackColor = System.Drawing.Color.Transparent;
            this.picPerson.FillColor = System.Drawing.Color.DimGray;
            this.picPerson.ImageRotate = 0F;
            this.picPerson.Location = new System.Drawing.Point(492, 49);
            this.picPerson.Name = "picPerson";
            this.picPerson.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picPerson.Size = new System.Drawing.Size(217, 200);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerson.TabIndex = 166;
            this.picPerson.TabStop = false;
            // 
            // labEmployeeId
            // 
            this.labEmployeeId.AutoSize = false;
            this.labEmployeeId.BackColor = System.Drawing.Color.Transparent;
            this.labEmployeeId.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployeeId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labEmployeeId.Location = new System.Drawing.Point(655, 255);
            this.labEmployeeId.Name = "labEmployeeId";
            this.labEmployeeId.Size = new System.Drawing.Size(95, 32);
            this.labEmployeeId.TabIndex = 160;
            this.labEmployeeId.Text = "??";
            this.labEmployeeId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labPersonId
            // 
            this.labPersonId.AutoSize = false;
            this.labPersonId.BackColor = System.Drawing.Color.Transparent;
            this.labPersonId.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPersonId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPersonId.Location = new System.Drawing.Point(719, 338);
            this.labPersonId.Name = "labPersonId";
            this.labPersonId.Size = new System.Drawing.Size(95, 32);
            this.labPersonId.TabIndex = 165;
            this.labPersonId.Text = "??";
            this.labPersonId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labPerson
            // 
            this.labPerson.AutoSize = false;
            this.labPerson.BackColor = System.Drawing.Color.Transparent;
            this.labPerson.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPerson.Location = new System.Drawing.Point(492, 336);
            this.labPerson.Name = "labPerson";
            this.labPerson.Size = new System.Drawing.Size(111, 34);
            this.labPerson.TabIndex = 164;
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
            this.txtSalary.Location = new System.Drawing.Point(719, 406);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderText = "";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(200, 36);
            this.txtSalary.TabIndex = 162;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(492, 406);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(146, 36);
            this.guna2HtmlLabel9.TabIndex = 161;
            this.guna2HtmlLabel9.Text = "Salary:";
            // 
            // labEmployee
            // 
            this.labEmployee.AutoSize = false;
            this.labEmployee.BackColor = System.Drawing.Color.Transparent;
            this.labEmployee.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEmployee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labEmployee.Location = new System.Drawing.Point(492, 255);
            this.labEmployee.Name = "labEmployee";
            this.labEmployee.Size = new System.Drawing.Size(157, 32);
            this.labEmployee.TabIndex = 163;
            this.labEmployee.Text = "Employee Id:";
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
            this.btnCancel.Location = new System.Drawing.Point(706, 683);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 54);
            this.btnCancel.TabIndex = 125;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(549, 683);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 54);
            this.btnSave.TabIndex = 124;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1459, 749);
            this.Controls.Add(this.TabCtrlAddOrUpdateCustomers);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateEmployee";
            this.Text = "frmAddUpdateEmployee";
            this.Load += new System.EventHandler(this.frmAddUpdateEmployee_Load);
            this.TabCtrlAddOrUpdateCustomers.ResumeLayout(false);
            this.tabPersonInfo.ResumeLayout(false);
            this.tabEmployeeInfo.ResumeLayout(false);
            this.panelContainerEmployeeInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl TabCtrlAddOrUpdateCustomers;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSelectPerson;
        private System.Windows.Forms.TabPage tabEmployeeInfo;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private UserControls.uc_personInfo uc_personInfo1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelContainerEmployeeInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cbCareer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picPerson;
        private Guna.UI2.WinForms.Guna2HtmlLabel labEmployeeId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPersonId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPerson;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel labEmployee;
    }
}