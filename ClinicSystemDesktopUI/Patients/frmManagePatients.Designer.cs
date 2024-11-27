namespace ClinicSystem.Patients
{
    partial class frmManagePatients
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
            this.dgvManagePatients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmManagePatients = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tcmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tcmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPatient = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagePatients)).BeginInit();
            this.cmManagePatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvManagePatients
            // 
            this.dgvManagePatients.AllowDrop = true;
            this.dgvManagePatients.AllowUserToAddRows = false;
            this.dgvManagePatients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvManagePatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManagePatients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvManagePatients.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvManagePatients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagePatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManagePatients.ColumnHeadersHeight = 30;
            this.dgvManagePatients.ContextMenuStrip = this.cmManagePatients;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManagePatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManagePatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvManagePatients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvManagePatients.Location = new System.Drawing.Point(0, 0);
            this.dgvManagePatients.Name = "dgvManagePatients";
            this.dgvManagePatients.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagePatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvManagePatients.RowHeadersVisible = false;
            this.dgvManagePatients.RowHeadersWidth = 51;
            this.dgvManagePatients.RowTemplate.Height = 24;
            this.dgvManagePatients.Size = new System.Drawing.Size(1459, 415);
            this.dgvManagePatients.TabIndex = 3;
            this.dgvManagePatients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvManagePatients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvManagePatients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvManagePatients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvManagePatients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvManagePatients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvManagePatients.ThemeStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvManagePatients.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvManagePatients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvManagePatients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvManagePatients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManagePatients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvManagePatients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManagePatients.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvManagePatients.ThemeStyle.ReadOnly = true;
            this.dgvManagePatients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvManagePatients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvManagePatients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManagePatients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvManagePatients.ThemeStyle.RowsStyle.Height = 24;
            this.dgvManagePatients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvManagePatients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmManagePatients
            // 
            this.cmManagePatients.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmManagePatients.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmManagePatients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tcmUpdate,
            this.tcmDelete});
            this.cmManagePatients.Name = "cmManagePatients";
            this.cmManagePatients.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmManagePatients.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmManagePatients.RenderStyle.ColorTable = null;
            this.cmManagePatients.RenderStyle.RoundedEdges = true;
            this.cmManagePatients.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmManagePatients.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmManagePatients.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmManagePatients.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmManagePatients.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmManagePatients.Size = new System.Drawing.Size(128, 52);
            // 
            // tcmUpdate
            // 
            this.tcmUpdate.Name = "tcmUpdate";
            this.tcmUpdate.Size = new System.Drawing.Size(127, 24);
            this.tcmUpdate.Text = "Update";
            this.tcmUpdate.Click += new System.EventHandler(this.tcmUpdate_Click);
            // 
            // tcmDelete
            // 
            this.tcmDelete.Name = "tcmDelete";
            this.tcmDelete.Size = new System.Drawing.Size(127, 24);
            this.tcmDelete.Text = "Delete";
            this.tcmDelete.Click += new System.EventHandler(this.tcmDelete_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Animated = true;
            this.btnAddPatient.AutoRoundedCorners = true;
            this.btnAddPatient.BorderRadius = 25;
            this.btnAddPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPatient.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPatient.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddPatient.ForeColor = System.Drawing.Color.Black;
            this.btnAddPatient.Location = new System.Drawing.Point(536, 671);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(225, 52);
            this.btnAddPatient.TabIndex = 117;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // frmManagePatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1459, 749);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.dgvManagePatients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManagePatients";
            this.Text = "frmManagePatients";
            this.Load += new System.EventHandler(this.frmManagePatients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagePatients)).EndInit();
            this.cmManagePatients.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvManagePatients;
        private Guna.UI2.WinForms.Guna2Button btnAddPatient;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmManagePatients;
        private System.Windows.Forms.ToolStripMenuItem tcmUpdate;
        private System.Windows.Forms.ToolStripMenuItem tcmDelete;
    }
}