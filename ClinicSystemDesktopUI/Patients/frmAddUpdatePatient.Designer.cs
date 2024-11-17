namespace ClinicSystem.Patients
{
    partial class frmAddUpdatePatient
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabPersonInfo = new System.Windows.Forms.TabPage();
            this.btnSelectPerson = new Guna.UI2.WinForms.Guna2Button();
            this.TabCtrlAddOrUpdateCustomers = new Guna.UI2.WinForms.Guna2TabControl();
            this.uc_personInfo1 = new ClinicSystem.UserControls.uc_personInfo();
            this.labPatientId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPersonId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPerson = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPatient = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabPersonInfo.SuspendLayout();
            this.TabCtrlAddOrUpdateCustomers.SuspendLayout();
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
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(821, 596);
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
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(664, 596);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 54);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(48, 138);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(488, 30);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "You must enter the employee\'s basic information first.";
            // 
            // tabPersonInfo
            // 
            this.tabPersonInfo.BackColor = System.Drawing.Color.Silver;
            this.tabPersonInfo.Controls.Add(this.labPatientId);
            this.tabPersonInfo.Controls.Add(this.labPersonId);
            this.tabPersonInfo.Controls.Add(this.labPerson);
            this.tabPersonInfo.Controls.Add(this.labPatient);
            this.tabPersonInfo.Controls.Add(this.uc_personInfo1);
            this.tabPersonInfo.Controls.Add(this.guna2HtmlLabel1);
            this.tabPersonInfo.Controls.Add(this.btnSelectPerson);
            this.tabPersonInfo.Location = new System.Drawing.Point(4, 4);
            this.tabPersonInfo.Name = "tabPersonInfo";
            this.tabPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonInfo.Size = new System.Drawing.Size(1480, 581);
            this.tabPersonInfo.TabIndex = 0;
            this.tabPersonInfo.Text = "Patient Info";
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
            this.btnSelectPerson.Location = new System.Drawing.Point(215, 189);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(180, 45);
            this.btnSelectPerson.TabIndex = 1;
            this.btnSelectPerson.Text = "Select a Person";
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click_1);
            // 
            // TabCtrlAddOrUpdateCustomers
            // 
            this.TabCtrlAddOrUpdateCustomers.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.TabCtrlAddOrUpdateCustomers.Controls.Add(this.tabPersonInfo);
            this.TabCtrlAddOrUpdateCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabCtrlAddOrUpdateCustomers.ItemSize = new System.Drawing.Size(180, 40);
            this.TabCtrlAddOrUpdateCustomers.Location = new System.Drawing.Point(0, 0);
            this.TabCtrlAddOrUpdateCustomers.Name = "TabCtrlAddOrUpdateCustomers";
            this.TabCtrlAddOrUpdateCustomers.SelectedIndex = 0;
            this.TabCtrlAddOrUpdateCustomers.Size = new System.Drawing.Size(1668, 589);
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
            this.TabCtrlAddOrUpdateCustomers.TabIndex = 126;
            this.TabCtrlAddOrUpdateCustomers.TabMenuBackColor = System.Drawing.Color.Silver;
            this.TabCtrlAddOrUpdateCustomers.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            // 
            // uc_personInfo1
            // 
            this.uc_personInfo1.Location = new System.Drawing.Point(717, 20);
            this.uc_personInfo1.Name = "uc_personInfo1";
            this.uc_personInfo1.Size = new System.Drawing.Size(748, 500);
            this.uc_personInfo1.TabIndex = 3;
            // 
            // labPatientId
            // 
            this.labPatientId.AutoSize = false;
            this.labPatientId.BackColor = System.Drawing.Color.Transparent;
            this.labPatientId.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatientId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPatientId.Location = new System.Drawing.Point(378, 330);
            this.labPatientId.Name = "labPatientId";
            this.labPatientId.Size = new System.Drawing.Size(95, 32);
            this.labPatientId.TabIndex = 157;
            this.labPatientId.Text = "??";
            this.labPatientId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labPersonId
            // 
            this.labPersonId.AutoSize = false;
            this.labPersonId.BackColor = System.Drawing.Color.Transparent;
            this.labPersonId.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPersonId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPersonId.Location = new System.Drawing.Point(372, 411);
            this.labPersonId.Name = "labPersonId";
            this.labPersonId.Size = new System.Drawing.Size(95, 32);
            this.labPersonId.TabIndex = 160;
            this.labPersonId.Text = "??";
            this.labPersonId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labPerson
            // 
            this.labPerson.AutoSize = false;
            this.labPerson.BackColor = System.Drawing.Color.Transparent;
            this.labPerson.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPerson.Location = new System.Drawing.Point(215, 411);
            this.labPerson.Name = "labPerson";
            this.labPerson.Size = new System.Drawing.Size(111, 34);
            this.labPerson.TabIndex = 159;
            this.labPerson.Text = "Person Id:";
            // 
            // labPatient
            // 
            this.labPatient.AutoSize = false;
            this.labPatient.BackColor = System.Drawing.Color.Transparent;
            this.labPatient.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labPatient.Location = new System.Drawing.Point(215, 330);
            this.labPatient.Name = "labPatient";
            this.labPatient.Size = new System.Drawing.Size(157, 32);
            this.labPatient.TabIndex = 158;
            this.labPatient.Text = "Patient Id:";
            // 
            // frmAddUpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 638);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TabCtrlAddOrUpdateCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdatePatient";
            this.Text = "frmAddUpdatePatient";
            this.Load += new System.EventHandler(this.frmAddUpdatePatient_Load);
            this.tabPersonInfo.ResumeLayout(false);
            this.TabCtrlAddOrUpdateCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private UserControls.uc_personInfo uc_personInfo1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.TabPage tabPersonInfo;
        private Guna.UI2.WinForms.Guna2Button btnSelectPerson;
        private Guna.UI2.WinForms.Guna2TabControl TabCtrlAddOrUpdateCustomers;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPatientId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPersonId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPerson;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPatient;
    }
}