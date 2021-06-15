namespace SMS
{
    partial class AttendenceClassWiseReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAttClsWiseReportStdClass = new System.Windows.Forms.ComboBox();
            this.dgvAttClsWiseReportStdList = new System.Windows.Forms.DataGridView();
            this.stuAttenFKstuDetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuDetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuAttenStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxAttClsWiseReportStdPresent = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAttClsWiseReportStdSec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAttClsWiseReportStdAbsent = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttClsWiseReportStdList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class :";
            // 
            // comboBoxAttClsWiseReportStdClass
            // 
            this.comboBoxAttClsWiseReportStdClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttClsWiseReportStdClass.FormattingEnabled = true;
            this.comboBoxAttClsWiseReportStdClass.Location = new System.Drawing.Point(75, 67);
            this.comboBoxAttClsWiseReportStdClass.Name = "comboBoxAttClsWiseReportStdClass";
            this.comboBoxAttClsWiseReportStdClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAttClsWiseReportStdClass.TabIndex = 2;
            this.comboBoxAttClsWiseReportStdClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAttClsWiseReportStdClass_SelectedIndexChanged);
            // 
            // dgvAttClsWiseReportStdList
            // 
            this.dgvAttClsWiseReportStdList.AllowUserToAddRows = false;
            this.dgvAttClsWiseReportStdList.AllowUserToDeleteRows = false;
            this.dgvAttClsWiseReportStdList.AllowUserToResizeColumns = false;
            this.dgvAttClsWiseReportStdList.AllowUserToResizeRows = false;
            this.dgvAttClsWiseReportStdList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttClsWiseReportStdList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.dgvAttClsWiseReportStdList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttClsWiseReportStdList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttClsWiseReportStdList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttClsWiseReportStdList.ColumnHeadersHeight = 30;
            this.dgvAttClsWiseReportStdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuAttenFKstuDetId,
            this.stuDetName,
            this.stuAttenStatus});
            this.dgvAttClsWiseReportStdList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttClsWiseReportStdList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttClsWiseReportStdList.EnableHeadersVisualStyles = false;
            this.dgvAttClsWiseReportStdList.Location = new System.Drawing.Point(19, 142);
            this.dgvAttClsWiseReportStdList.Name = "dgvAttClsWiseReportStdList";
            this.dgvAttClsWiseReportStdList.ReadOnly = true;
            this.dgvAttClsWiseReportStdList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAttClsWiseReportStdList.RowHeadersVisible = false;
            this.dgvAttClsWiseReportStdList.Size = new System.Drawing.Size(514, 189);
            this.dgvAttClsWiseReportStdList.TabIndex = 3;
            // 
            // stuAttenFKstuDetId
            // 
            this.stuAttenFKstuDetId.DataPropertyName = "stuAttenFKstuDetId";
            this.stuAttenFKstuDetId.HeaderText = "Roll No";
            this.stuAttenFKstuDetId.Name = "stuAttenFKstuDetId";
            this.stuAttenFKstuDetId.ReadOnly = true;
            // 
            // stuDetName
            // 
            this.stuDetName.DataPropertyName = "stuDetName";
            this.stuDetName.HeaderText = "Name";
            this.stuDetName.Name = "stuDetName";
            this.stuDetName.ReadOnly = true;
            // 
            // stuAttenStatus
            // 
            this.stuAttenStatus.DataPropertyName = "stuAttenStatus";
            this.stuAttenStatus.HeaderText = "Attendence Status";
            this.stuAttenStatus.Name = "stuAttenStatus";
            this.stuAttenStatus.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 105);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // checkBoxAttClsWiseReportStdPresent
            // 
            this.checkBoxAttClsWiseReportStdPresent.AutoSize = true;
            this.checkBoxAttClsWiseReportStdPresent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAttClsWiseReportStdPresent.Location = new System.Drawing.Point(241, 71);
            this.checkBoxAttClsWiseReportStdPresent.Name = "checkBoxAttClsWiseReportStdPresent";
            this.checkBoxAttClsWiseReportStdPresent.Size = new System.Drawing.Size(73, 21);
            this.checkBoxAttClsWiseReportStdPresent.TabIndex = 5;
            this.checkBoxAttClsWiseReportStdPresent.Text = "Present";
            this.checkBoxAttClsWiseReportStdPresent.UseVisualStyleBackColor = true;
            this.checkBoxAttClsWiseReportStdPresent.CheckedChanged += new System.EventHandler(this.CheckBoxAttClsWiseReportStdPresent_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(81, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attendence Class Wise Report";
            // 
            // comboBoxAttClsWiseReportStdSec
            // 
            this.comboBoxAttClsWiseReportStdSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAttClsWiseReportStdSec.FormattingEnabled = true;
            this.comboBoxAttClsWiseReportStdSec.Location = new System.Drawing.Point(75, 105);
            this.comboBoxAttClsWiseReportStdSec.Name = "comboBoxAttClsWiseReportStdSec";
            this.comboBoxAttClsWiseReportStdSec.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAttClsWiseReportStdSec.TabIndex = 7;
            this.comboBoxAttClsWiseReportStdSec.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAttClsWiseReportStdSec_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sec :";
            // 
            // checkBoxAttClsWiseReportStdAbsent
            // 
            this.checkBoxAttClsWiseReportStdAbsent.AutoSize = true;
            this.checkBoxAttClsWiseReportStdAbsent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAttClsWiseReportStdAbsent.Location = new System.Drawing.Point(241, 105);
            this.checkBoxAttClsWiseReportStdAbsent.Name = "checkBoxAttClsWiseReportStdAbsent";
            this.checkBoxAttClsWiseReportStdAbsent.Size = new System.Drawing.Size(70, 21);
            this.checkBoxAttClsWiseReportStdAbsent.TabIndex = 9;
            this.checkBoxAttClsWiseReportStdAbsent.Text = "Absent";
            this.checkBoxAttClsWiseReportStdAbsent.UseVisualStyleBackColor = true;
            this.checkBoxAttClsWiseReportStdAbsent.CheckedChanged += new System.EventHandler(this.CheckBoxAttClsWiseReportStdAbsent_CheckedChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(389, 60);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(135, 28);
            this.btnExport.TabIndex = 10;
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
            this.button1.Location = new System.Drawing.Point(515, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AttendenceClassWiseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(552, 339);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.checkBoxAttClsWiseReportStdAbsent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAttClsWiseReportStdSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxAttClsWiseReportStdPresent);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvAttClsWiseReportStdList);
            this.Controls.Add(this.comboBoxAttClsWiseReportStdClass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendenceClassWiseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendenceClassWiseReport";
            this.Load += new System.EventHandler(this.AttendenceClassWiseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttClsWiseReportStdList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAttClsWiseReportStdClass;
        private System.Windows.Forms.DataGridView dgvAttClsWiseReportStdList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxAttClsWiseReportStdPresent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAttClsWiseReportStdSec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuAttenFKstuDetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuDetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuAttenStatus;
        private System.Windows.Forms.CheckBox checkBoxAttClsWiseReportStdAbsent;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button1;
    }
}