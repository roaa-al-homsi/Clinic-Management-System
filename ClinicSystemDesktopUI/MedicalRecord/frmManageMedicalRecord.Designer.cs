namespace ClinicSystem.MedicalRecords
{
    partial class frmManageMedicalRecord
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
            this.dgvManageMedicalRecords = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsManageMedicalRecords = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageMedicalRecords)).BeginInit();
            this.cmsManageMedicalRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvManageMedicalRecords
            // 
            this.dgvManageMedicalRecords.AllowDrop = true;
            this.dgvManageMedicalRecords.AllowUserToAddRows = false;
            this.dgvManageMedicalRecords.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvManageMedicalRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageMedicalRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvManageMedicalRecords.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvManageMedicalRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageMedicalRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManageMedicalRecords.ColumnHeadersHeight = 30;
            this.dgvManageMedicalRecords.ContextMenuStrip = this.cmsManageMedicalRecords;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageMedicalRecords.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManageMedicalRecords.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvManageMedicalRecords.Location = new System.Drawing.Point(1, 2);
            this.dgvManageMedicalRecords.Name = "dgvManageMedicalRecords";
            this.dgvManageMedicalRecords.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageMedicalRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvManageMedicalRecords.RowHeadersVisible = false;
            this.dgvManageMedicalRecords.RowHeadersWidth = 51;
            this.dgvManageMedicalRecords.RowTemplate.Height = 24;
            this.dgvManageMedicalRecords.Size = new System.Drawing.Size(864, 381);
            this.dgvManageMedicalRecords.TabIndex = 2;
            this.dgvManageMedicalRecords.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvManageMedicalRecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvManageMedicalRecords.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvManageMedicalRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvManageMedicalRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvManageMedicalRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvManageMedicalRecords.ThemeStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvManageMedicalRecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvManageMedicalRecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvManageMedicalRecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvManageMedicalRecords.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManageMedicalRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvManageMedicalRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManageMedicalRecords.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvManageMedicalRecords.ThemeStyle.ReadOnly = true;
            this.dgvManageMedicalRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvManageMedicalRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvManageMedicalRecords.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManageMedicalRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvManageMedicalRecords.ThemeStyle.RowsStyle.Height = 24;
            this.dgvManageMedicalRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvManageMedicalRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsManageMedicalRecords
            // 
            this.cmsManageMedicalRecords.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmsManageMedicalRecords.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsManageMedicalRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cmsManageMedicalRecords.Name = "cmsManageMedicalRecords";
            this.cmsManageMedicalRecords.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsManageMedicalRecords.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsManageMedicalRecords.RenderStyle.ColorTable = null;
            this.cmsManageMedicalRecords.RenderStyle.RoundedEdges = true;
            this.cmsManageMedicalRecords.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsManageMedicalRecords.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsManageMedicalRecords.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsManageMedicalRecords.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsManageMedicalRecords.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsManageMedicalRecords.Size = new System.Drawing.Size(128, 28);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // frmManageMedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 400);
            this.Controls.Add(this.dgvManageMedicalRecords);
            this.Name = "frmManageMedicalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Medical Record";
            this.Load += new System.EventHandler(this.frmManageMedicalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageMedicalRecords)).EndInit();
            this.cmsManageMedicalRecords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvManageMedicalRecords;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsManageMedicalRecords;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}