namespace SMS
{
    partial class StdIdvFee
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
            this.lblName = new System.Windows.Forms.Label();
            this.StdIndvFeeRNum = new System.Windows.Forms.Label();
            this.dgvStdIndFee = new System.Windows.Forms.DataGridView();
            this.stuFeesMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuFeesPaidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuFeesStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUnPaid = new System.Windows.Forms.CheckBox();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.btnChangeFeeStatus = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdIndFee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(119, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(3, 20, 0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 32);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Shafqat";
            // 
            // StdIndvFeeRNum
            // 
            this.StdIndvFeeRNum.AutoSize = true;
            this.StdIndvFeeRNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StdIndvFeeRNum.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdIndvFeeRNum.ForeColor = System.Drawing.Color.Black;
            this.StdIndvFeeRNum.Location = new System.Drawing.Point(12, 69);
            this.StdIndvFeeRNum.Margin = new System.Windows.Forms.Padding(3, 23, 3, 0);
            this.StdIndvFeeRNum.Name = "StdIndvFeeRNum";
            this.StdIndvFeeRNum.Size = new System.Drawing.Size(102, 30);
            this.StdIndvFeeRNum.TabIndex = 3;
            this.StdIndvFeeRNum.Text = "Roll no# :";
            // 
            // dgvStdIndFee
            // 
            this.dgvStdIndFee.AllowUserToAddRows = false;
            this.dgvStdIndFee.AllowUserToDeleteRows = false;
            this.dgvStdIndFee.AllowUserToResizeColumns = false;
            this.dgvStdIndFee.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvStdIndFee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStdIndFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStdIndFee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(202)))));
            this.dgvStdIndFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStdIndFee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvStdIndFee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStdIndFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStdIndFee.ColumnHeadersHeight = 25;
            this.dgvStdIndFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuFeesMonth,
            this.stuFeesPaidDate,
            this.stuFeesStatus});
            this.dgvStdIndFee.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStdIndFee.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStdIndFee.EnableHeadersVisualStyles = false;
            this.dgvStdIndFee.Location = new System.Drawing.Point(2, 112);
            this.dgvStdIndFee.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.dgvStdIndFee.MultiSelect = false;
            this.dgvStdIndFee.Name = "dgvStdIndFee";
            this.dgvStdIndFee.ReadOnly = true;
            this.dgvStdIndFee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStdIndFee.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvStdIndFee.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStdIndFee.Size = new System.Drawing.Size(600, 341);
            this.dgvStdIndFee.TabIndex = 4;
            // 
            // stuFeesMonth
            // 
            this.stuFeesMonth.DataPropertyName = "stuFeesMonth";
            this.stuFeesMonth.HeaderText = "stuFeesMonth";
            this.stuFeesMonth.Name = "stuFeesMonth";
            this.stuFeesMonth.ReadOnly = true;
            // 
            // stuFeesPaidDate
            // 
            this.stuFeesPaidDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stuFeesPaidDate.DataPropertyName = "stuFeesPaidDate";
            this.stuFeesPaidDate.HeaderText = "Payment Date";
            this.stuFeesPaidDate.Name = "stuFeesPaidDate";
            this.stuFeesPaidDate.ReadOnly = true;
            // 
            // stuFeesStatus
            // 
            this.stuFeesStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stuFeesStatus.DataPropertyName = "stuFeesStatus";
            this.stuFeesStatus.HeaderText = "Fees Status";
            this.stuFeesStatus.Name = "stuFeesStatus";
            this.stuFeesStatus.ReadOnly = true;
            // 
            // lblRNo
            // 
            this.lblRNo.AutoSize = true;
            this.lblRNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRNo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNo.ForeColor = System.Drawing.Color.Black;
            this.lblRNo.Location = new System.Drawing.Point(120, 70);
            this.lblRNo.Margin = new System.Windows.Forms.Padding(3, 23, 30, 0);
            this.lblRNo.Name = "lblRNo";
            this.lblRNo.Size = new System.Drawing.Size(89, 30);
            this.lblRNo.TabIndex = 1;
            this.lblRNo.Text = "1221569";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(506, 29);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(82, 20);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Year";
            // 
            // cbUnPaid
            // 
            this.cbUnPaid.AutoSize = true;
            this.cbUnPaid.Location = new System.Drawing.Point(512, 54);
            this.cbUnPaid.Name = "cbUnPaid";
            this.cbUnPaid.Size = new System.Drawing.Size(61, 17);
            this.cbUnPaid.TabIndex = 8;
            this.cbUnPaid.Text = "UnPaid";
            this.cbUnPaid.UseVisualStyleBackColor = true;
            this.cbUnPaid.CheckedChanged += new System.EventHandler(this.CbUnPaid_CheckedChanged);
            // 
            // cbPaid
            // 
            this.cbPaid.AutoSize = true;
            this.cbPaid.Location = new System.Drawing.Point(442, 54);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(47, 17);
            this.cbPaid.TabIndex = 9;
            this.cbPaid.Text = "Paid";
            this.cbPaid.UseVisualStyleBackColor = true;
            this.cbPaid.CheckedChanged += new System.EventHandler(this.CbPaid_CheckedChanged);
            // 
            // btnChangeFeeStatus
            // 
            this.btnChangeFeeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(10)))), ((int)(((byte)(67)))));
            this.btnChangeFeeStatus.FlatAppearance.BorderSize = 0;
            this.btnChangeFeeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeFeeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFeeStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeFeeStatus.Location = new System.Drawing.Point(439, 76);
            this.btnChangeFeeStatus.Name = "btnChangeFeeStatus";
            this.btnChangeFeeStatus.Size = new System.Drawing.Size(149, 31);
            this.btnChangeFeeStatus.TabIndex = 10;
            this.btnChangeFeeStatus.Text = "Change Fees Status";
            this.btnChangeFeeStatus.UseVisualStyleBackColor = false;
            this.btnChangeFeeStatus.Click += new System.EventHandler(this.BtnChangeFeeStatus_Click);
            this.btnChangeFeeStatus.MouseEnter += new System.EventHandler(this.BtnChangeFeeStatus_MouseEnter);
            this.btnChangeFeeStatus.MouseLeave += new System.EventHandler(this.BtnChangeFeeStatus_MouseLeave);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(277, 76);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(145, 30);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export Excel Report";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            this.btnExport.MouseEnter += new System.EventHandler(this.BtnExport_MouseEnter);
            this.btnExport.MouseLeave += new System.EventHandler(this.BtnExport_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(570, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // StdIdvFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(187)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(601, 454);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnChangeFeeStatus);
            this.Controls.Add(this.cbPaid);
            this.Controls.Add(this.cbUnPaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dgvStdIndFee);
            this.Controls.Add(this.StdIndvFeeRNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StdIdvFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StdIndvFee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StdIdvFee_FormClosed);
            this.Load += new System.EventHandler(this.StdIdvFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdIndFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label StdIndvFeeRNum;
        private System.Windows.Forms.DataGridView dgvStdIndFee;
        private System.Windows.Forms.Label lblRNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbUnPaid;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuFeesMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuFeesPaidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuFeesStatus;
        private System.Windows.Forms.Button btnChangeFeeStatus;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
    }
}