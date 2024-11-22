namespace ClinicSystem.Appointments
{
    partial class frmAddUpdateAppointment
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnSelectMedicalRecord = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nDoctors = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nPatients = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPatientId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labDoctorId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPaymentId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labRecordId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.uc_doctor = new ClinicSystem.UserControls.uc_personInfo();
            this.uc_patient = new ClinicSystem.UserControls.uc_personInfo();
            this.txtSpecialization = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.btnPay);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSelectMedicalRecord);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2CustomGradientPanel1.Controls.Add(this.cbStatus);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtDate);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.DarkGray;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(417, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(756, 135);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.AutoRoundedCorners = true;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.BorderRadius = 16;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.DarkGray;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(206, 90);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(108, 34);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay";
            this.btnPay.UseTransparentBackground = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSelectMedicalRecord
            // 
            this.btnSelectMedicalRecord.AutoRoundedCorners = true;
            this.btnSelectMedicalRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectMedicalRecord.BorderRadius = 15;
            this.btnSelectMedicalRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectMedicalRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectMedicalRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectMedicalRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectMedicalRecord.FillColor = System.Drawing.Color.DarkGray;
            this.btnSelectMedicalRecord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectMedicalRecord.ForeColor = System.Drawing.Color.White;
            this.btnSelectMedicalRecord.Location = new System.Drawing.Point(206, 48);
            this.btnSelectMedicalRecord.Name = "btnSelectMedicalRecord";
            this.btnSelectMedicalRecord.Size = new System.Drawing.Size(96, 33);
            this.btnSelectMedicalRecord.TabIndex = 6;
            this.btnSelectMedicalRecord.Text = "Select ";
            this.btnSelectMedicalRecord.UseTransparentBackground = true;
            this.btnSelectMedicalRecord.Click += new System.EventHandler(this.btnSelectMedicalRecord_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(33, 90);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(108, 37);
            this.guna2HtmlLabel4.TabIndex = 5;
            this.guna2HtmlLabel4.Text = "Payment :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(33, 48);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(167, 33);
            this.guna2HtmlLabel3.TabIndex = 4;
            this.guna2HtmlLabel3.Text = "Medical Record :";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoRoundedCorners = true;
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderRadius = 17;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FillColor = System.Drawing.Color.DarkGray;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Location = new System.Drawing.Point(538, 88);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(177, 36);
            this.cbStatus.TabIndex = 3;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(327, 86);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(215, 38);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Status Appointment:";
            // 
            // dtDate
            // 
            this.dtDate.AutoRoundedCorners = true;
            this.dtDate.BackColor = System.Drawing.Color.Transparent;
            this.dtDate.BorderRadius = 17;
            this.dtDate.Checked = true;
            this.dtDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dtDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDate.Location = new System.Drawing.Point(500, 44);
            this.dtDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(177, 36);
            this.dtDate.TabIndex = 1;
            this.dtDate.UseTransparentBackground = true;
            this.dtDate.Value = new System.DateTime(2024, 11, 18, 12, 0, 4, 210);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(327, 48);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(55, 29);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Date:";
            // 
            // nDoctors
            // 
            this.nDoctors.AutoRoundedCorners = true;
            this.nDoctors.BackColor = System.Drawing.Color.Transparent;
            this.nDoctors.BorderRadius = 23;
            this.nDoctors.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nDoctors.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nDoctors.Location = new System.Drawing.Point(1220, 118);
            this.nDoctors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nDoctors.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nDoctors.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDoctors.Name = "nDoctors";
            this.nDoctors.Size = new System.Drawing.Size(114, 48);
            this.nDoctors.TabIndex = 1;
            this.nDoctors.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nDoctors.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDoctors.ValueChanged += new System.EventHandler(this.nDoctors_ValueChanged);
            // 
            // nPatients
            // 
            this.nPatients.AutoRoundedCorners = true;
            this.nPatients.BackColor = System.Drawing.Color.Transparent;
            this.nPatients.BorderRadius = 23;
            this.nPatients.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nPatients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nPatients.Location = new System.Drawing.Point(37, 118);
            this.nPatients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nPatients.Name = "nPatients";
            this.nPatients.Size = new System.Drawing.Size(114, 48);
            this.nPatients.TabIndex = 2;
            this.nPatients.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nPatients.ValueChanged += new System.EventHandler(this.nPatients_ValueChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(37, 341);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(108, 37);
            this.guna2HtmlLabel5.TabIndex = 8;
            this.guna2HtmlLabel5.Text = "Patient Id :";
            // 
            // labPatientId
            // 
            this.labPatientId.AutoSize = false;
            this.labPatientId.BackColor = System.Drawing.Color.Transparent;
            this.labPatientId.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPatientId.Location = new System.Drawing.Point(190, 341);
            this.labPatientId.Name = "labPatientId";
            this.labPatientId.Size = new System.Drawing.Size(108, 37);
            this.labPatientId.TabIndex = 9;
            this.labPatientId.Text = "??";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.AutoSize = false;
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(888, 357);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(108, 37);
            this.guna2HtmlLabel7.TabIndex = 10;
            this.guna2HtmlLabel7.Text = "Doctor Id :";
            // 
            // labDoctorId
            // 
            this.labDoctorId.AutoSize = false;
            this.labDoctorId.BackColor = System.Drawing.Color.Transparent;
            this.labDoctorId.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDoctorId.Location = new System.Drawing.Point(1036, 357);
            this.labDoctorId.Name = "labDoctorId";
            this.labDoctorId.Size = new System.Drawing.Size(108, 37);
            this.labDoctorId.TabIndex = 11;
            this.labDoctorId.Text = "??";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(1261, 628);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(137, 37);
            this.guna2HtmlLabel6.TabIndex = 12;
            this.guna2HtmlLabel6.Text = "Specialization:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.AutoSize = false;
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(37, 22);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(140, 38);
            this.guna2HtmlLabel8.TabIndex = 8;
            this.guna2HtmlLabel8.Text = "Payment Id  :";
            // 
            // labPaymentId
            // 
            this.labPaymentId.AutoSize = false;
            this.labPaymentId.BackColor = System.Drawing.Color.Transparent;
            this.labPaymentId.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPaymentId.Location = new System.Drawing.Point(209, 22);
            this.labPaymentId.Name = "labPaymentId";
            this.labPaymentId.Size = new System.Drawing.Size(140, 38);
            this.labPaymentId.TabIndex = 13;
            this.labPaymentId.Text = "??";
            // 
            // labRecordId
            // 
            this.labRecordId.AutoSize = false;
            this.labRecordId.BackColor = System.Drawing.Color.Transparent;
            this.labRecordId.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRecordId.Location = new System.Drawing.Point(249, 66);
            this.labRecordId.Name = "labRecordId";
            this.labRecordId.Size = new System.Drawing.Size(78, 27);
            this.labRecordId.TabIndex = 15;
            this.labRecordId.Text = "??";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.AutoSize = false;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(37, 66);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(187, 38);
            this.guna2HtmlLabel10.TabIndex = 14;
            this.guna2HtmlLabel10.Text = "Medical Record Id:";
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 16;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.DarkGray;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(757, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 16;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.DarkGray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(757, 525);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseTransparentBackground = true;
            // 
            // uc_doctor
            // 
            this.uc_doctor.Location = new System.Drawing.Point(864, 190);
            this.uc_doctor.Name = "uc_doctor";
            this.uc_doctor.Size = new System.Drawing.Size(739, 483);
            this.uc_doctor.TabIndex = 4;
            // 
            // uc_patient
            // 
            this.uc_patient.Location = new System.Drawing.Point(12, 193);
            this.uc_patient.Name = "uc_patient";
            this.uc_patient.Size = new System.Drawing.Size(739, 472);
            this.uc_patient.TabIndex = 3;
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.AutoRoundedCorners = true;
            this.txtSpecialization.BorderColor = System.Drawing.Color.Transparent;
            this.txtSpecialization.BorderRadius = 23;
            this.txtSpecialization.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSpecialization.DefaultText = "";
            this.txtSpecialization.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSpecialization.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSpecialization.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSpecialization.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSpecialization.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSpecialization.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSpecialization.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSpecialization.Location = new System.Drawing.Point(1404, 617);
            this.txtSpecialization.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.PasswordChar = '\0';
            this.txtSpecialization.PlaceholderText = "";
            this.txtSpecialization.ReadOnly = true;
            this.txtSpecialization.SelectedText = "";
            this.txtSpecialization.Size = new System.Drawing.Size(176, 48);
            this.txtSpecialization.TabIndex = 16;
            // 
            // frmAddUpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 685);
            this.Controls.Add(this.txtSpecialization);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labRecordId);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.labPaymentId);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.labDoctorId);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.labPatientId);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.uc_doctor);
            this.Controls.Add(this.uc_patient);
            this.Controls.Add(this.nPatients);
            this.Controls.Add(this.nDoctors);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateAppointment";
            this.Text = "frmAddUpdateAppointment";
            this.Load += new System.EventHandler(this.frmAddUpdateAppointment_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDate;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnSelectMedicalRecord;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2NumericUpDown nDoctors;
        private Guna.UI2.WinForms.Guna2NumericUpDown nPatients;
        private UserControls.uc_personInfo uc_patient;
        private UserControls.uc_personInfo uc_doctor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPatientId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel labDoctorId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPaymentId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labRecordId;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtSpecialization;
    }
}