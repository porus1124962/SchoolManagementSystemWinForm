namespace SMS
{
    partial class EmpPaymentMonthlyRep
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dgvMonthlySalery = new System.Windows.Forms.DataGridView();
            this.empSalaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryFKuserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryIncentive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryGrossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryNetPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStdClsWiseFeeReport = new System.Windows.Forms.Label();
            this.cbSelectDept = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectSalaryStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowPaySlip = new System.Windows.Forms.Button();
            this.btnSetStatus = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySalery)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MMM/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(777, 73);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // dgvMonthlySalery
            // 
            this.dgvMonthlySalery.AllowUserToResizeColumns = false;
            this.dgvMonthlySalery.AllowUserToResizeRows = false;
            this.dgvMonthlySalery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonthlySalery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.dgvMonthlySalery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonthlySalery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlySalery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMonthlySalery.ColumnHeadersHeight = 30;
            this.dgvMonthlySalery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empSalaryId,
            this.empSalaryFKuserId,
            this.empSalaryName,
            this.empSalaryBonus,
            this.empSalaryIncentive,
            this.empSalaryGrossPay,
            this.empSalaryDeduction,
            this.empSalaryNetPay,
            this.Status,
            this.empSalaryDate});
            this.dgvMonthlySalery.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonthlySalery.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMonthlySalery.EnableHeadersVisualStyles = false;
            this.dgvMonthlySalery.GridColor = System.Drawing.Color.AntiqueWhite;
            this.dgvMonthlySalery.Location = new System.Drawing.Point(1, 144);
            this.dgvMonthlySalery.Name = "dgvMonthlySalery";
            this.dgvMonthlySalery.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonthlySalery.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMonthlySalery.RowHeadersVisible = false;
            this.dgvMonthlySalery.Size = new System.Drawing.Size(886, 353);
            this.dgvMonthlySalery.TabIndex = 2;
            // 
            // empSalaryId
            // 
            this.empSalaryId.DataPropertyName = "empSalaryId";
            this.empSalaryId.HeaderText = "empSalaryId";
            this.empSalaryId.Name = "empSalaryId";
            this.empSalaryId.Visible = false;
            // 
            // empSalaryFKuserId
            // 
            this.empSalaryFKuserId.DataPropertyName = "empSalaryFKuserId";
            this.empSalaryFKuserId.HeaderText = "Emp ID";
            this.empSalaryFKuserId.Name = "empSalaryFKuserId";
            this.empSalaryFKuserId.ReadOnly = true;
            // 
            // empSalaryName
            // 
            this.empSalaryName.DataPropertyName = "empSalaryName";
            this.empSalaryName.HeaderText = "Name";
            this.empSalaryName.Name = "empSalaryName";
            this.empSalaryName.ReadOnly = true;
            // 
            // empSalaryBonus
            // 
            this.empSalaryBonus.DataPropertyName = "empSalaryBonus";
            this.empSalaryBonus.HeaderText = "Bonus";
            this.empSalaryBonus.Name = "empSalaryBonus";
            // 
            // empSalaryIncentive
            // 
            this.empSalaryIncentive.DataPropertyName = "empSalaryIncentive";
            this.empSalaryIncentive.HeaderText = "Incentive";
            this.empSalaryIncentive.Name = "empSalaryIncentive";
            // 
            // empSalaryGrossPay
            // 
            this.empSalaryGrossPay.DataPropertyName = "empSalaryGrossPay";
            this.empSalaryGrossPay.HeaderText = "Gross Pay";
            this.empSalaryGrossPay.Name = "empSalaryGrossPay";
            this.empSalaryGrossPay.ReadOnly = true;
            // 
            // empSalaryDeduction
            // 
            this.empSalaryDeduction.DataPropertyName = "empSalaryDeduction";
            this.empSalaryDeduction.HeaderText = "Deduction";
            this.empSalaryDeduction.Name = "empSalaryDeduction";
            this.empSalaryDeduction.ReadOnly = true;
            // 
            // empSalaryNetPay
            // 
            this.empSalaryNetPay.DataPropertyName = "empSalaryNetPay";
            this.empSalaryNetPay.HeaderText = "Net Pay";
            this.empSalaryNetPay.Name = "empSalaryNetPay";
            this.empSalaryNetPay.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "empSalaryStatus";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // empSalaryDate
            // 
            this.empSalaryDate.DataPropertyName = "empSalaryDate";
            this.empSalaryDate.HeaderText = "Pay Date";
            this.empSalaryDate.Name = "empSalaryDate";
            // 
            // lblStdClsWiseFeeReport
            // 
            this.lblStdClsWiseFeeReport.AutoSize = true;
            this.lblStdClsWiseFeeReport.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdClsWiseFeeReport.ForeColor = System.Drawing.Color.Coral;
            this.lblStdClsWiseFeeReport.Location = new System.Drawing.Point(337, 0);
            this.lblStdClsWiseFeeReport.Name = "lblStdClsWiseFeeReport";
            this.lblStdClsWiseFeeReport.Size = new System.Drawing.Size(218, 37);
            this.lblStdClsWiseFeeReport.TabIndex = 4;
            this.lblStdClsWiseFeeReport.Text = "Employee Salary";
            // 
            // cbSelectDept
            // 
            this.cbSelectDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectDept.FormattingEnabled = true;
            this.cbSelectDept.Items.AddRange(new object[] {
            "Teacher",
            "Admission",
            "Accounts",
            "Administrator"});
            this.cbSelectDept.Location = new System.Drawing.Point(169, 43);
            this.cbSelectDept.Name = "cbSelectDept";
            this.cbSelectDept.Size = new System.Drawing.Size(126, 21);
            this.cbSelectDept.TabIndex = 7;
            this.cbSelectDept.SelectedIndexChanged += new System.EventHandler(this.CbSelectDept_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Department :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paid / Unpaid Salary :";
            // 
            // cbSelectSalaryStatus
            // 
            this.cbSelectSalaryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectSalaryStatus.FormattingEnabled = true;
            this.cbSelectSalaryStatus.Items.AddRange(new object[] {
            "Both",
            "Transferred",
            "Pending"});
            this.cbSelectSalaryStatus.Location = new System.Drawing.Point(169, 76);
            this.cbSelectSalaryStatus.Name = "cbSelectSalaryStatus";
            this.cbSelectSalaryStatus.Size = new System.Drawing.Size(126, 21);
            this.cbSelectSalaryStatus.TabIndex = 3;
            this.cbSelectSalaryStatus.SelectedIndexChanged += new System.EventHandler(this.CbSelectSalaryStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(659, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pick A Month :";
            // 
            // btnShowPaySlip
            // 
            this.btnShowPaySlip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(3)))), ((int)(((byte)(46)))));
            this.btnShowPaySlip.FlatAppearance.BorderSize = 0;
            this.btnShowPaySlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPaySlip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPaySlip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowPaySlip.Location = new System.Drawing.Point(169, 105);
            this.btnShowPaySlip.Name = "btnShowPaySlip";
            this.btnShowPaySlip.Size = new System.Drawing.Size(145, 33);
            this.btnShowPaySlip.TabIndex = 12;
            this.btnShowPaySlip.Text = "Print Pay Slip";
            this.btnShowPaySlip.UseVisualStyleBackColor = false;
            this.btnShowPaySlip.Click += new System.EventHandler(this.BtnSeeIndReport_Click);
            this.btnShowPaySlip.MouseEnter += new System.EventHandler(this.BtnSeeIndReport_MouseEnter);
            this.btnShowPaySlip.MouseLeave += new System.EventHandler(this.BtnSeeIndReport_MouseLeave);
            // 
            // btnSetStatus
            // 
            this.btnSetStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSetStatus.FlatAppearance.BorderSize = 0;
            this.btnSetStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetStatus.ForeColor = System.Drawing.Color.White;
            this.btnSetStatus.Location = new System.Drawing.Point(12, 105);
            this.btnSetStatus.Name = "btnSetStatus";
            this.btnSetStatus.Size = new System.Drawing.Size(151, 33);
            this.btnSetStatus.TabIndex = 13;
            this.btnSetStatus.Text = "Change Payment Status";
            this.btnSetStatus.UseVisualStyleBackColor = false;
            this.btnSetStatus.Click += new System.EventHandler(this.BtnSetStatus_Click);
            this.btnSetStatus.MouseEnter += new System.EventHandler(this.BtnSetStatus_MouseEnter);
            this.btnSetStatus.MouseLeave += new System.EventHandler(this.BtnSetStatus_MouseLeave);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(775, 40);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(749, 105);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 33);
            this.btnExport.TabIndex = 16;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            this.btnExport.MouseEnter += new System.EventHandler(this.BtnExport_MouseEnter);
            this.btnExport.MouseLeave += new System.EventHandler(this.BtnExport_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(683, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search All :";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(851, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // EmpPaymentMonthlyRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(889, 495);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnSetStatus);
            this.Controls.Add(this.btnShowPaySlip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSelectDept);
            this.Controls.Add(this.lblStdClsWiseFeeReport);
            this.Controls.Add(this.cbSelectSalaryStatus);
            this.Controls.Add(this.dgvMonthlySalery);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpPaymentMonthlyRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StdClassWiseFeesReport";
            this.Load += new System.EventHandler(this.EmpPaymentMonthlyRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlySalery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblStdClsWiseFeeReport;
        private System.Windows.Forms.DataGridView dgvMonthlySalery;
        private System.Windows.Forms.ComboBox cbSelectDept;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectSalaryStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowPaySlip;
        private System.Windows.Forms.Button btnSetStatus;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryFKuserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryIncentive;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryGrossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryNetPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryDate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
    }

       
    
}