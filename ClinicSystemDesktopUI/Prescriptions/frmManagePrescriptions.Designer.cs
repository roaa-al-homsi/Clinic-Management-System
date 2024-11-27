namespace ClinicSystem.Prescriptions
{
    partial class frmManagePrescriptions
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
            this.dgvManagePrescriptions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsMangePrescriptions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagePrescriptions)).BeginInit();
            this.cmsMangePrescriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvManagePrescriptions
            // 
            this.dgvManagePrescriptions.AllowDrop = true;
            this.dgvManagePrescriptions.AllowUserToAddRows = false;
            this.dgvManagePrescriptions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvManagePrescriptions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManagePrescriptions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvManagePrescriptions.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvManagePrescriptions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NULL";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagePrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvManagePrescriptions.ColumnHeadersHeight = 30;
            this.dgvManagePrescriptions.ContextMenuStrip = this.cmsMangePrescriptions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManagePrescriptions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvManagePrescriptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvManagePrescriptions.Location = new System.Drawing.Point(5, 12);
            this.dgvManagePrescriptions.Name = "dgvManagePrescriptions";
            this.dgvManagePrescriptions.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManagePrescriptions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvManagePrescriptions.RowHeadersVisible = false;
            this.dgvManagePrescriptions.RowHeadersWidth = 51;
            this.dgvManagePrescriptions.RowTemplate.Height = 24;
            this.dgvManagePrescriptions.Size = new System.Drawing.Size(1031, 343);
            this.dgvManagePrescriptions.TabIndex = 3;
            this.dgvManagePrescriptions.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.dgvManagePrescriptions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvManagePrescriptions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvManagePrescriptions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvManagePrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvManagePrescriptions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvManagePrescriptions.ThemeStyle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvManagePrescriptions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvManagePrescriptions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvManagePrescriptions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvManagePrescriptions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManagePrescriptions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvManagePrescriptions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvManagePrescriptions.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvManagePrescriptions.ThemeStyle.ReadOnly = true;
            this.dgvManagePrescriptions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvManagePrescriptions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvManagePrescriptions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Andalus", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvManagePrescriptions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvManagePrescriptions.ThemeStyle.RowsStyle.Height = 24;
            this.dgvManagePrescriptions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvManagePrescriptions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsMangePrescriptions
            // 
            this.cmsMangePrescriptions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmsMangePrescriptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMangePrescriptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.cmsMangePrescriptions.Name = "cmsMangePrescriptions";
            this.cmsMangePrescriptions.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsMangePrescriptions.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsMangePrescriptions.RenderStyle.ColorTable = null;
            this.cmsMangePrescriptions.RenderStyle.RoundedEdges = true;
            this.cmsMangePrescriptions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsMangePrescriptions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsMangePrescriptions.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsMangePrescriptions.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsMangePrescriptions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsMangePrescriptions.Size = new System.Drawing.Size(128, 28);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // frmManagePrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1048, 370);
            this.Controls.Add(this.dgvManagePrescriptions);
            this.Name = "frmManagePrescriptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Prescriptions";
            this.Load += new System.EventHandler(this.frmManagePrescriptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagePrescriptions)).EndInit();
            this.cmsMangePrescriptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvManagePrescriptions;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsMangePrescriptions;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}