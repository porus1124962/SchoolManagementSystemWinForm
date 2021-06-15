namespace SMS
{
    partial class IndividualSalary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSalary = new System.Windows.Forms.DataGridView();
            this.salBonusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salBonusEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Incentive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStdClsWiseFeeReport = new System.Windows.Forms.Label();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnExcelReport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSalary
            // 
            this.dgvSalary.AllowUserToResizeColumns = false;
            this.dgvSalary.AllowUserToResizeRows = false;
            this.dgvSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.dgvSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSalary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSalary.ColumnHeadersHeight = 30;
            this.dgvSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salBonusId,
            this.salBonusEmpId,
            this.EmpName,
            this.salBonus,
            this.GrossPay,
            this.Deduction,
            this.Incentive,
            this.NetPay});
            this.dgvSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalary.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalary.EnableHeadersVisualStyles = false;
            this.dgvSalary.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSalary.Location = new System.Drawing.Point(1, 112);
            this.dgvSalary.Name = "dgvSalary";
            this.dgvSalary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalary.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalary.RowHeadersVisible = false;
            this.dgvSalary.Size = new System.Drawing.Size(781, 346);
            this.dgvSalary.TabIndex = 2;
            this.dgvSalary.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPaidUnpaidFees_CellValueChanged);
            // 
            // salBonusId
            // 
            this.salBonusId.DataPropertyName = "salBonusId";
            this.salBonusId.HeaderText = "salBonusId";
            this.salBonusId.Name = "salBonusId";
            this.salBonusId.Visible = false;
            // 
            // salBonusEmpId
            // 
            this.salBonusEmpId.DataPropertyName = "salBonusEmpId";
            this.salBonusEmpId.HeaderText = "Emp Id";
            this.salBonusEmpId.Name = "salBonusEmpId";
            this.salBonusEmpId.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "EmpName";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // salBonus
            // 
            this.salBonus.DataPropertyName = "salBonus";
            this.salBonus.HeaderText = "Bonus";
            this.salBonus.Name = "salBonus";
            // 
            // GrossPay
            // 
            this.GrossPay.DataPropertyName = "GrossPay";
            this.GrossPay.HeaderText = "Gross Pay";
            this.GrossPay.Name = "GrossPay";
            this.GrossPay.ReadOnly = true;
            // 
            // Deduction
            // 
            this.Deduction.DataPropertyName = "Deduction";
            this.Deduction.HeaderText = "Deduction";
            this.Deduction.Name = "Deduction";
            this.Deduction.ReadOnly = true;
            // 
            // Incentive
            // 
            this.Incentive.DataPropertyName = "Incentive";
            this.Incentive.HeaderText = "Incentive";
            this.Incentive.Name = "Incentive";
            // 
            // NetPay
            // 
            this.NetPay.DataPropertyName = "NetPay";
            this.NetPay.HeaderText = "Net Pay";
            this.NetPay.Name = "NetPay";
            this.NetPay.ReadOnly = true;
            // 
            // lblStdClsWiseFeeReport
            // 
            this.lblStdClsWiseFeeReport.AutoSize = true;
            this.lblStdClsWiseFeeReport.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdClsWiseFeeReport.ForeColor = System.Drawing.Color.Coral;
            this.lblStdClsWiseFeeReport.Location = new System.Drawing.Point(282, -1);
            this.lblStdClsWiseFeeReport.Name = "lblStdClsWiseFeeReport";
            this.lblStdClsWiseFeeReport.Size = new System.Drawing.Size(234, 37);
            this.lblStdClsWiseFeeReport.TabIndex = 4;
            this.lblStdClsWiseFeeReport.Text = "Employes Saleries";
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Items.AddRange(new object[] {
            "Teacher",
            "Admission",
            "Accounts",
            "Administrator"});
            this.comboBoxDep.Location = new System.Drawing.Point(145, 85);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDep.TabIndex = 7;
            this.comboBoxDep.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDep_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Department :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search :";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(145, 51);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(121, 20);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // btnExcelReport
            // 
            this.btnExcelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExcelReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelReport.ForeColor = System.Drawing.Color.White;
            this.btnExcelReport.Location = new System.Drawing.Point(639, 57);
            this.btnExcelReport.Name = "btnExcelReport";
            this.btnExcelReport.Size = new System.Drawing.Size(129, 32);
            this.btnExcelReport.TabIndex = 13;
            this.btnExcelReport.Text = "Export To Excel";
            this.btnExcelReport.UseVisualStyleBackColor = false;
            this.btnExcelReport.Click += new System.EventHandler(this.BtnExcelReport_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(741, 4);
            this.btnClose.MaximumSize = new System.Drawing.Size(31, 23);
            this.btnClose.MinimumSize = new System.Drawing.Size(31, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // IndividualSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExcelReport);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxDep);
            this.Controls.Add(this.lblStdClsWiseFeeReport);
            this.Controls.Add(this.dgvSalary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(780, 460);
            this.MinimumSize = new System.Drawing.Size(780, 460);
            this.Name = "IndividualSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StdClassWiseFeesReport";
            this.Load += new System.EventHandler(this.IndividualSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStdClsWiseFeeReport;
        private System.Windows.Forms.DataGridView dgvSalary;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnExcelReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn salBonusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn salBonusEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn salBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Incentive;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPay;
        private System.Windows.Forms.Button btnClose;
    }
}