namespace SMS
{
    partial class StdClassWiseFeesReport
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dgvPaidUnpaidFees = new System.Windows.Forms.DataGridView();
            this.dgvStdRollNoFeesReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStdNameFeesReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStdFeesStuts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStdClsWiseFeeReport = new System.Windows.Forms.Label();
            this.cbSelectClass = new System.Windows.Forms.ComboBox();
            this.cbSelectSec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectFeeStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSeeIndReport = new System.Windows.Forms.Button();
            this.btnSetStatus = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaidUnpaidFees)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "MMM/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(574, 82);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // dgvPaidUnpaidFees
            // 
            this.dgvPaidUnpaidFees.AllowUserToAddRows = false;
            this.dgvPaidUnpaidFees.AllowUserToDeleteRows = false;
            this.dgvPaidUnpaidFees.AllowUserToResizeColumns = false;
            this.dgvPaidUnpaidFees.AllowUserToResizeRows = false;
            this.dgvPaidUnpaidFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaidUnpaidFees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.dgvPaidUnpaidFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPaidUnpaidFees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPaidUnpaidFees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaidUnpaidFees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPaidUnpaidFees.ColumnHeadersHeight = 30;
            this.dgvPaidUnpaidFees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvStdRollNoFeesReport,
            this.dgvStdNameFeesReport,
            this.PaidDate,
            this.dgvStdFeesStuts});
            this.dgvPaidUnpaidFees.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPaidUnpaidFees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPaidUnpaidFees.EnableHeadersVisualStyles = false;
            this.dgvPaidUnpaidFees.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPaidUnpaidFees.Location = new System.Drawing.Point(38, 144);
            this.dgvPaidUnpaidFees.Name = "dgvPaidUnpaidFees";
            this.dgvPaidUnpaidFees.ReadOnly = true;
            this.dgvPaidUnpaidFees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPaidUnpaidFees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPaidUnpaidFees.RowHeadersVisible = false;
            this.dgvPaidUnpaidFees.Size = new System.Drawing.Size(634, 328);
            this.dgvPaidUnpaidFees.TabIndex = 2;
            // 
            // dgvStdRollNoFeesReport
            // 
            this.dgvStdRollNoFeesReport.DataPropertyName = "stuFeesFKstuDetId";
            this.dgvStdRollNoFeesReport.HeaderText = "Std Roll NO";
            this.dgvStdRollNoFeesReport.Name = "dgvStdRollNoFeesReport";
            this.dgvStdRollNoFeesReport.ReadOnly = true;
            // 
            // dgvStdNameFeesReport
            // 
            this.dgvStdNameFeesReport.DataPropertyName = "stuDetName";
            this.dgvStdNameFeesReport.HeaderText = "Std Name";
            this.dgvStdNameFeesReport.Name = "dgvStdNameFeesReport";
            this.dgvStdNameFeesReport.ReadOnly = true;
            // 
            // PaidDate
            // 
            this.PaidDate.DataPropertyName = "stuFeesPaidDate";
            this.PaidDate.HeaderText = "Fees Paid Date";
            this.PaidDate.Name = "PaidDate";
            this.PaidDate.ReadOnly = true;
            // 
            // dgvStdFeesStuts
            // 
            this.dgvStdFeesStuts.DataPropertyName = "feeStatus";
            this.dgvStdFeesStuts.HeaderText = "Fees Stutes";
            this.dgvStdFeesStuts.Name = "dgvStdFeesStuts";
            this.dgvStdFeesStuts.ReadOnly = true;
            // 
            // lblStdClsWiseFeeReport
            // 
            this.lblStdClsWiseFeeReport.AutoSize = true;
            this.lblStdClsWiseFeeReport.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdClsWiseFeeReport.ForeColor = System.Drawing.Color.Coral;
            this.lblStdClsWiseFeeReport.Location = new System.Drawing.Point(222, 0);
            this.lblStdClsWiseFeeReport.Name = "lblStdClsWiseFeeReport";
            this.lblStdClsWiseFeeReport.Size = new System.Drawing.Size(296, 37);
            this.lblStdClsWiseFeeReport.TabIndex = 4;
            this.lblStdClsWiseFeeReport.Text = "Fees Class Wise Report";
            // 
            // cbSelectClass
            // 
            this.cbSelectClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectClass.FormattingEnabled = true;
            this.cbSelectClass.Location = new System.Drawing.Point(166, 53);
            this.cbSelectClass.Name = "cbSelectClass";
            this.cbSelectClass.Size = new System.Drawing.Size(121, 21);
            this.cbSelectClass.TabIndex = 7;
            this.cbSelectClass.SelectedIndexChanged += new System.EventHandler(this.CbSelectClass_SelectedIndexChanged);
            // 
            // cbSelectSec
            // 
            this.cbSelectSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectSec.FormattingEnabled = true;
            this.cbSelectSec.Location = new System.Drawing.Point(166, 81);
            this.cbSelectSec.Name = "cbSelectSec";
            this.cbSelectSec.Size = new System.Drawing.Size(121, 21);
            this.cbSelectSec.TabIndex = 8;
            this.cbSelectSec.SelectedIndexChanged += new System.EventHandler(this.CbSelectSec_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paid / Unpaid Fees:";
            // 
            // cbSelectFeeStatus
            // 
            this.cbSelectFeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectFeeStatus.FormattingEnabled = true;
            this.cbSelectFeeStatus.Items.AddRange(new object[] {
            "Both",
            "Paid",
            "UnPaid"});
            this.cbSelectFeeStatus.Location = new System.Drawing.Point(166, 108);
            this.cbSelectFeeStatus.Name = "cbSelectFeeStatus";
            this.cbSelectFeeStatus.Size = new System.Drawing.Size(121, 21);
            this.cbSelectFeeStatus.TabIndex = 3;
            this.cbSelectFeeStatus.SelectedIndexChanged += new System.EventHandler(this.CbSelectFeeStatus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pick A Month :";
            // 
            // btnSeeIndReport
            // 
            this.btnSeeIndReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(10)))), ((int)(((byte)(130)))));
            this.btnSeeIndReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeIndReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeIndReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeeIndReport.Location = new System.Drawing.Point(546, 109);
            this.btnSeeIndReport.Name = "btnSeeIndReport";
            this.btnSeeIndReport.Size = new System.Drawing.Size(126, 30);
            this.btnSeeIndReport.TabIndex = 12;
            this.btnSeeIndReport.Text = "See Individual Report";
            this.btnSeeIndReport.UseVisualStyleBackColor = false;
            this.btnSeeIndReport.Click += new System.EventHandler(this.BtnSeeIndReport_Click);
            this.btnSeeIndReport.MouseEnter += new System.EventHandler(this.BtnSeeIndReport_MouseEnter);
            this.btnSeeIndReport.MouseLeave += new System.EventHandler(this.BtnSeeIndReport_MouseLeave);
            // 
            // btnSetStatus
            // 
            this.btnSetStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(13)))), ((int)(((byte)(189)))));
            this.btnSetStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetStatus.FlatAppearance.BorderSize = 0;
            this.btnSetStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetStatus.Location = new System.Drawing.Point(413, 111);
            this.btnSetStatus.Name = "btnSetStatus";
            this.btnSetStatus.Size = new System.Drawing.Size(118, 27);
            this.btnSetStatus.TabIndex = 13;
            this.btnSetStatus.Text = "Change Fees Status";
            this.btnSetStatus.UseVisualStyleBackColor = false;
            this.btnSetStatus.Click += new System.EventHandler(this.BtnSetStatus_Click);
            this.btnSetStatus.MouseEnter += new System.EventHandler(this.BtnSetStatus_MouseEnter);
            this.btnSetStatus.MouseLeave += new System.EventHandler(this.BtnSetStatus_MouseLeave);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(546, 45);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 28);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export Excel Report";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            this.btnExport.MouseEnter += new System.EventHandler(this.BtnExport_MouseEnter);
            this.btnExport.MouseLeave += new System.EventHandler(this.BtnExport_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(676, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // StdClassWiseFeesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(713, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSetStatus);
            this.Controls.Add(this.btnSeeIndReport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSelectSec);
            this.Controls.Add(this.cbSelectClass);
            this.Controls.Add(this.lblStdClsWiseFeeReport);
            this.Controls.Add(this.cbSelectFeeStatus);
            this.Controls.Add(this.dgvPaidUnpaidFees);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(713, 477);
            this.MinimumSize = new System.Drawing.Size(713, 477);
            this.Name = "StdClassWiseFeesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StdClassWiseFeesReport";
            this.Load += new System.EventHandler(this.StdClassWiseFeesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaidUnpaidFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblStdClsWiseFeeReport;
        private System.Windows.Forms.DataGridView dgvPaidUnpaidFees;
        private System.Windows.Forms.ComboBox cbSelectClass;
        private System.Windows.Forms.ComboBox cbSelectSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectFeeStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSeeIndReport;
        private System.Windows.Forms.Button btnSetStatus;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStdRollNoFeesReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStdNameFeesReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStdFeesStuts;
    }
}