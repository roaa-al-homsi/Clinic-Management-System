namespace ClinicSystem.Persons
{
    partial class frmAddUpdatePersons
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
            this.cbGendre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.picPerson = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.TimePicBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPersonId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labPerson = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.linkSet = new System.Windows.Forms.LinkLabel();
            this.linkRemove = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGendre
            // 
            this.cbGendre.AutoRoundedCorners = true;
            this.cbGendre.BackColor = System.Drawing.Color.Transparent;
            this.cbGendre.BorderRadius = 17;
            this.cbGendre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGendre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGendre.FillColor = System.Drawing.Color.Black;
            this.cbGendre.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGendre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGendre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGendre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGendre.ItemHeight = 30;
            this.cbGendre.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGendre.Location = new System.Drawing.Point(147, 347);
            this.cbGendre.Name = "cbGendre";
            this.cbGendre.Size = new System.Drawing.Size(200, 36);
            this.cbGendre.TabIndex = 175;
            this.cbGendre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbGendre.SelectedIndexChanged += new System.EventHandler(this.cbGendre_SelectedIndexChanged);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 347);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(90, 36);
            this.guna2HtmlLabel5.TabIndex = 174;
            this.guna2HtmlLabel5.Text = "Gendre:";
            // 
            // cbCountries
            // 
            this.cbCountries.AutoRoundedCorners = true;
            this.cbCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbCountries.BorderRadius = 17;
            this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FillColor = System.Drawing.Color.Black;
            this.cbCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCountries.ItemHeight = 30;
            this.cbCountries.Location = new System.Drawing.Point(147, 282);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(200, 36);
            this.cbCountries.TabIndex = 169;
            // 
            // picPerson
            // 
            this.picPerson.FillColor = System.Drawing.Color.DimGray;
            this.picPerson.ImageRotate = 0F;
            this.picPerson.Location = new System.Drawing.Point(147, -2);
            this.picPerson.Name = "picPerson";
            this.picPerson.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picPerson.Size = new System.Drawing.Size(197, 186);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerson.TabIndex = 166;
            this.picPerson.TabStop = false;
            // 
            // TimePicBirthDate
            // 
            this.TimePicBirthDate.AutoRoundedCorners = true;
            this.TimePicBirthDate.BorderRadius = 17;
            this.TimePicBirthDate.Checked = true;
            this.TimePicBirthDate.FillColor = System.Drawing.Color.Black;
            this.TimePicBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TimePicBirthDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimePicBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TimePicBirthDate.Location = new System.Drawing.Point(147, 412);
            this.TimePicBirthDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TimePicBirthDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TimePicBirthDate.Name = "TimePicBirthDate";
            this.TimePicBirthDate.Size = new System.Drawing.Size(200, 36);
            this.TimePicBirthDate.TabIndex = 165;
            this.TimePicBirthDate.Value = new System.DateTime(2024, 10, 19, 22, 56, 7, 337);
            // 
            // txtFullName
            // 
            this.txtFullName.Animated = true;
            this.txtFullName.AutoRoundedCorners = true;
            this.txtFullName.BorderRadius = 17;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FillColor = System.Drawing.Color.Black;
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.ForeColor = System.Drawing.Color.White;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.Location = new System.Drawing.Point(147, 217);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(200, 36);
            this.txtFullName.TabIndex = 163;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.AutoSize = false;
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(12, 402);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(122, 46);
            this.guna2HtmlLabel10.TabIndex = 162;
            this.guna2HtmlLabel10.Text = "Birth Date:";
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.AutoSize = false;
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(12, 217);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(122, 46);
            this.guna2HtmlLabel9.TabIndex = 161;
            this.guna2HtmlLabel9.Text = "Full Name:";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 282);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(122, 46);
            this.guna2HtmlLabel4.TabIndex = 159;
            this.guna2HtmlLabel4.Text = "CountryId:";
            // 
            // labPersonId
            // 
            this.labPersonId.AutoSize = false;
            this.labPersonId.BackColor = System.Drawing.Color.Transparent;
            this.labPersonId.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold);
            this.labPersonId.Location = new System.Drawing.Point(496, 28);
            this.labPersonId.Name = "labPersonId";
            this.labPersonId.Size = new System.Drawing.Size(95, 32);
            this.labPersonId.TabIndex = 168;
            this.labPersonId.Text = "??";
            this.labPersonId.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.labPersonId.Visible = false;
            // 
            // labPerson
            // 
            this.labPerson.AutoSize = false;
            this.labPerson.BackColor = System.Drawing.Color.Transparent;
            this.labPerson.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold);
            this.labPerson.Location = new System.Drawing.Point(376, 28);
            this.labPerson.Name = "labPerson";
            this.labPerson.Size = new System.Drawing.Size(111, 34);
            this.labPerson.TabIndex = 167;
            this.labPerson.Text = "Person Id:";
            this.labPerson.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.AutoRoundedCorners = true;
            this.txtEmail.BorderRadius = 17;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.Black;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(488, 283);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(200, 36);
            this.txtEmail.TabIndex = 181;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(391, 282);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(113, 37);
            this.guna2HtmlLabel3.TabIndex = 180;
            this.guna2HtmlLabel3.Text = "Email:";
            // 
            // txtAddress
            // 
            this.txtAddress.Animated = true;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FillColor = System.Drawing.Color.Black;
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.White;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(488, 347);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(229, 135);
            this.txtAddress.TabIndex = 179;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(391, 347);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(113, 37);
            this.guna2HtmlLabel2.TabIndex = 178;
            this.guna2HtmlLabel2.Text = "Address:";
            // 
            // txtPhone
            // 
            this.txtPhone.Animated = true;
            this.txtPhone.AutoRoundedCorners = true;
            this.txtPhone.BorderRadius = 17;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FillColor = System.Drawing.Color.Black;
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(488, 218);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(200, 36);
            this.txtPhone.TabIndex = 177;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Andalus", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(391, 217);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(113, 37);
            this.guna2HtmlLabel6.TabIndex = 176;
            this.guna2HtmlLabel6.Text = "Phone:";
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 33;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(215, 522);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 68);
            this.btnSave.TabIndex = 182;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 33;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(376, 522);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 68);
            this.btnCancel.TabIndex = 183;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // linkSet
            // 
            this.linkSet.AutoSize = true;
            this.linkSet.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSet.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkSet.Location = new System.Drawing.Point(361, 87);
            this.linkSet.Name = "linkSet";
            this.linkSet.Size = new System.Drawing.Size(32, 27);
            this.linkSet.TabIndex = 185;
            this.linkSet.TabStop = true;
            this.linkSet.Text = "Set";
            this.linkSet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSet_LinkClicked);
            // 
            // linkRemove
            // 
            this.linkRemove.AutoSize = true;
            this.linkRemove.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRemove.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkRemove.Location = new System.Drawing.Point(422, 87);
            this.linkRemove.Name = "linkRemove";
            this.linkRemove.Size = new System.Drawing.Size(65, 27);
            this.linkRemove.TabIndex = 184;
            this.linkRemove.TabStop = true;
            this.linkRemove.Text = "Remove";
            this.linkRemove.Visible = false;
            this.linkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRemove_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddUpdatePersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 602);
            this.Controls.Add(this.linkSet);
            this.Controls.Add(this.linkRemove);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.cbGendre);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.picPerson);
            this.Controls.Add(this.TimePicBirthDate);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.labPersonId);
            this.Controls.Add(this.labPerson);
            this.Name = "frmAddUpdatePersons";
            this.Text = "AddUpdatePersons";
            this.Load += new System.EventHandler(this.frmAddUpdatePersons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbGendre;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picPerson;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimePicBirthDate;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPersonId;
        private Guna.UI2.WinForms.Guna2HtmlLabel labPerson;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.LinkLabel linkSet;
        private System.Windows.Forms.LinkLabel linkRemove;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}