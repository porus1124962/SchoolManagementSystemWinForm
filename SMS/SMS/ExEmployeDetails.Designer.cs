namespace SMS
{
    partial class ExEmployeDetails
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
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearchEmploye = new System.Windows.Forms.TextBox();
            this.dgvExEmployeDetails = new System.Windows.Forms.DataGridView();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColexEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmployeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmployeGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmpDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColEmpLeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblExEmpDetailsHeading = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExEmployeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(13, 42);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(111, 19);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search Employe:";
            // 
            // textBoxSearchEmploye
            // 
            this.textBoxSearchEmploye.Location = new System.Drawing.Point(130, 42);
            this.textBoxSearchEmploye.Name = "textBoxSearchEmploye";
            this.textBoxSearchEmploye.Size = new System.Drawing.Size(143, 20);
            this.textBoxSearchEmploye.TabIndex = 1;
            this.textBoxSearchEmploye.TextChanged += new System.EventHandler(this.TextBoxSearchEmploye_TextChanged);
            // 
            // dgvExEmployeDetails
            // 
            this.dgvExEmployeDetails.AllowUserToAddRows = false;
            this.dgvExEmployeDetails.AllowUserToDeleteRows = false;
            this.dgvExEmployeDetails.AllowUserToResizeColumns = false;
            this.dgvExEmployeDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvExEmployeDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExEmployeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExEmployeDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.dgvExEmployeDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExEmployeDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvExEmployeDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExEmployeDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExEmployeDetails.ColumnHeadersHeight = 30;
            this.dgvExEmployeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.dgvColexEmpId,
            this.dgvColEmployeName,
            this.dgvColEmployeGender,
            this.dgvColEmpDepartment,
            this.dgvColEmpLeaveDate});
            this.dgvExEmployeDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExEmployeDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExEmployeDetails.EnableHeadersVisualStyles = false;
            this.dgvExEmployeDetails.Location = new System.Drawing.Point(3, 77);
            this.dgvExEmployeDetails.Name = "dgvExEmployeDetails";
            this.dgvExEmployeDetails.ReadOnly = true;
            this.dgvExEmployeDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExEmployeDetails.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvExEmployeDetails.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExEmployeDetails.Size = new System.Drawing.Size(736, 387);
            this.dgvExEmployeDetails.TabIndex = 2;
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "exEmpId";
            this.EmpId.HeaderText = "Emp Id";
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            this.EmpId.Visible = false;
            // 
            // dgvColexEmpId
            // 
            this.dgvColexEmpId.DataPropertyName = "exEmpFKUserTypeId";
            this.dgvColexEmpId.HeaderText = "Employe ID";
            this.dgvColexEmpId.Name = "dgvColexEmpId";
            this.dgvColexEmpId.ReadOnly = true;
            // 
            // dgvColEmployeName
            // 
            this.dgvColEmployeName.DataPropertyName = "exEmptName";
            this.dgvColEmployeName.HeaderText = "Employe Name";
            this.dgvColEmployeName.Name = "dgvColEmployeName";
            this.dgvColEmployeName.ReadOnly = true;
            // 
            // dgvColEmployeGender
            // 
            this.dgvColEmployeGender.DataPropertyName = "exEmpGender";
            this.dgvColEmployeGender.HeaderText = "Employe Gender";
            this.dgvColEmployeGender.Name = "dgvColEmployeGender";
            this.dgvColEmployeGender.ReadOnly = true;
            // 
            // dgvColEmpDepartment
            // 
            this.dgvColEmpDepartment.DataPropertyName = "exEmpDeptName";
            this.dgvColEmpDepartment.HeaderText = "Employe Department";
            this.dgvColEmpDepartment.Name = "dgvColEmpDepartment";
            this.dgvColEmpDepartment.ReadOnly = true;
            // 
            // dgvColEmpLeaveDate
            // 
            this.dgvColEmpLeaveDate.DataPropertyName = "exEmpLeaveDate";
            this.dgvColEmpLeaveDate.HeaderText = "Employe Leave Date";
            this.dgvColEmpLeaveDate.Name = "dgvColEmpLeaveDate";
            this.dgvColEmpLeaveDate.ReadOnly = true;
            // 
            // lblExEmpDetailsHeading
            // 
            this.lblExEmpDetailsHeading.AutoSize = true;
            this.lblExEmpDetailsHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExEmpDetailsHeading.ForeColor = System.Drawing.Color.Coral;
            this.lblExEmpDetailsHeading.Location = new System.Drawing.Point(194, 2);
            this.lblExEmpDetailsHeading.Name = "lblExEmpDetailsHeading";
            this.lblExEmpDetailsHeading.Size = new System.Drawing.Size(350, 37);
            this.lblExEmpDetailsHeading.TabIndex = 3;
            this.lblExEmpDetailsHeading.Text = "List of all the Ex-Employees";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(582, 42);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(143, 29);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export Excel Report";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            this.btnExport.MouseEnter += new System.EventHandler(this.BtnExport_MouseEnter_1);
            this.btnExport.MouseLeave += new System.EventHandler(this.BtnExport_MouseLeave_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(694, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ExEmployeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(740, 461);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblExEmpDetailsHeading);
            this.Controls.Add(this.dgvExEmployeDetails);
            this.Controls.Add(this.textBoxSearchEmploye);
            this.Controls.Add(this.labelSearch);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(740, 461);
            this.MinimumSize = new System.Drawing.Size(740, 461);
            this.Name = "ExEmployeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExEmployeDetails";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ExEmployeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExEmployeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearchEmploye;
        private System.Windows.Forms.Label lblExEmpDetailsHeading;
        private System.Windows.Forms.DataGridView dgvExEmployeDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColexEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmployeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmployeGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmpDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColEmpLeaveDate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
    }
}