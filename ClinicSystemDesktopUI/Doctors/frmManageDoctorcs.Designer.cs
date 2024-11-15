namespace ClinicSystem.Doctors
{
    partial class frmManageDoctorcs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvManageDoctors = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddDoctor = new Guna.UI2.WinForms.Guna2Button();
            this.cmsManageDoctors = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageDoctors)).BeginInit();
            this.cmsManageDoctors.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvManageDoctors
            // 
            this.dgvManageDoctors.AllowDrop = true;
            this.dgvManageDoctors.AllowUserToAddRows = false;
            this.dgvManageDoctors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvManageDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageDoctors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvManageDoctors.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvManageDoctors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageDoctors.ColumnHeadersHeight = 30;
            this.dgvManageDoctors.ContextMenuStrip = this.cmsManageDoctors;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManageDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvManageDoctors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvManageDoctors.Location = new System.Drawing.Point(0, 0);
            this.dgvManageDoctors.Name = "dgvManageDoctors";
            this.dgvManageDoctors.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageDoctors.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvManageDoctors.RowHeadersVisible = false;
            this.dgvManageDoctors.RowHeadersWidth = 51;
            this.dgvManageDoctors.RowTemplate.Height = 24;
            this.dgvManageDoctors.Size = new System.Drawing.Size(1686, 415);
            this.dgvManageDoctors.TabIndex = 2;
            this.dgvManageDoctors.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dgvManageDoctors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvManageDoctors.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvManageDoctors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvManageDoctors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvManageDoctors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvManageDoctors.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvManageDoctors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvManageDoctors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvManageDoctors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvManageDoctors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManageDoctors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvManageDoctors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManageDoctors.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvManageDoctors.ThemeStyle.ReadOnly = true;
            this.dgvManageDoctors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvManageDoctors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvManageDoctors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManageDoctors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvManageDoctors.ThemeStyle.RowsStyle.Height = 24;
            this.dgvManageDoctors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvManageDoctors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Animated = true;
            this.btnAddDoctor.AutoRoundedCorners = true;
            this.btnAddDoctor.BorderRadius = 25;
            this.btnAddDoctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDoctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDoctor.FillColor = System.Drawing.Color.Black;
            this.btnAddDoctor.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddDoctor.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctor.Location = new System.Drawing.Point(749, 587);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(149, 52);
            this.btnAddDoctor.TabIndex = 116;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // cmsManageDoctors
            // 
            this.cmsManageDoctors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageDoctors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUpdate,
            this.tsDelete});
            this.cmsManageDoctors.Name = "cmsManageEmployees";
            this.cmsManageDoctors.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsManageDoctors.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsManageDoctors.RenderStyle.ColorTable = null;
            this.cmsManageDoctors.RenderStyle.RoundedEdges = true;
            this.cmsManageDoctors.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsManageDoctors.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsManageDoctors.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsManageDoctors.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsManageDoctors.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsManageDoctors.Size = new System.Drawing.Size(211, 80);
            // 
            // tsUpdate
            // 
            this.tsUpdate.Name = "tsUpdate";
            this.tsUpdate.Size = new System.Drawing.Size(210, 24);
            this.tsUpdate.Text = "Update";
            this.tsUpdate.Click += new System.EventHandler(this.tsUpdate_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(210, 24);
            this.tsDelete.Text = "Delete";
            // 
            // frmManageDoctorcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 685);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.dgvManageDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageDoctorcs";
            this.Tag = "Manage Doctors";
            this.Text = "frmManageDoctorcs";
            this.Load += new System.EventHandler(this.frmManageDoctorcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageDoctors)).EndInit();
            this.cmsManageDoctors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvManageDoctors;
        private Guna.UI2.WinForms.Guna2Button btnAddDoctor;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsManageDoctors;
        private System.Windows.Forms.ToolStripMenuItem tsUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsDelete;
    }
}