namespace SMS
{
    partial class StdLeavePassRecord
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
            this.dgvStdLeaveReport = new System.Windows.Forms.DataGridView();
            this.stdLeaveRecFKstdDetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuDetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuDetFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuDetGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuDetStuPh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.className = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdLeaveRecLeaveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdLeaveRecAcademicResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdLeaveRecPercenage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxStdLeaveReportSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdLeaveReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "search :";
            // 
            // dgvStdLeaveReport
            // 
            this.dgvStdLeaveReport.AllowUserToResizeColumns = false;
            this.dgvStdLeaveReport.AllowUserToResizeRows = false;
            this.dgvStdLeaveReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStdLeaveReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.dgvStdLeaveReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStdLeaveReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(122)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStdLeaveReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStdLeaveReport.ColumnHeadersHeight = 40;
            this.dgvStdLeaveReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdLeaveRecFKstdDetId,
            this.stuDetName,
            this.stuDetFname,
            this.stuDetGender,
            this.stuDetStuPh,
            this.className,
            this.stdLeaveRecLeaveStatus,
            this.stdLeaveRecAcademicResult,
            this.stdLeaveRecPercenage});
            this.dgvStdLeaveReport.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStdLeaveReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStdLeaveReport.EnableHeadersVisualStyles = false;
            this.dgvStdLeaveReport.Location = new System.Drawing.Point(0, 65);
            this.dgvStdLeaveReport.Name = "dgvStdLeaveReport";
            this.dgvStdLeaveReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStdLeaveReport.RowHeadersVisible = false;
            this.dgvStdLeaveReport.Size = new System.Drawing.Size(694, 329);
            this.dgvStdLeaveReport.TabIndex = 2;
            // 
            // stdLeaveRecFKstdDetId
            // 
            this.stdLeaveRecFKstdDetId.DataPropertyName = "stdLeaveRecFKstdDetId";
            this.stdLeaveRecFKstdDetId.HeaderText = "Roll No";
            this.stdLeaveRecFKstdDetId.Name = "stdLeaveRecFKstdDetId";
            // 
            // stuDetName
            // 
            this.stuDetName.DataPropertyName = "stuDetName";
            this.stuDetName.HeaderText = "Name";
            this.stuDetName.Name = "stuDetName";
            // 
            // stuDetFname
            // 
            this.stuDetFname.DataPropertyName = "stuDetFname";
            this.stuDetFname.HeaderText = "FName";
            this.stuDetFname.Name = "stuDetFname";
            // 
            // stuDetGender
            // 
            this.stuDetGender.DataPropertyName = "stuDetGender";
            this.stuDetGender.HeaderText = "Sex";
            this.stuDetGender.Name = "stuDetGender";
            // 
            // stuDetStuPh
            // 
            this.stuDetStuPh.DataPropertyName = "stuDetStuPh";
            this.stuDetStuPh.HeaderText = "Phone No";
            this.stuDetStuPh.Name = "stuDetStuPh";
            // 
            // className
            // 
            this.className.DataPropertyName = "stdLeaveRecLastClassStudied";
            this.className.HeaderText = "Last Class Studied";
            this.className.Name = "className";
            // 
            // stdLeaveRecLeaveStatus
            // 
            this.stdLeaveRecLeaveStatus.DataPropertyName = "stdLeaveRecLeaveStatus";
            this.stdLeaveRecLeaveStatus.HeaderText = "LeaveStatus";
            this.stdLeaveRecLeaveStatus.Name = "stdLeaveRecLeaveStatus";
            // 
            // stdLeaveRecAcademicResult
            // 
            this.stdLeaveRecAcademicResult.DataPropertyName = "stdLeaveRecAcademicResult";
            this.stdLeaveRecAcademicResult.HeaderText = "Academic Year";
            this.stdLeaveRecAcademicResult.Name = "stdLeaveRecAcademicResult";
            // 
            // stdLeaveRecPercenage
            // 
            this.stdLeaveRecPercenage.DataPropertyName = "stdLeaveRecPercenage";
            this.stdLeaveRecPercenage.HeaderText = "Class Proformance";
            this.stdLeaveRecPercenage.Name = "stdLeaveRecPercenage";
            // 
            // txtBoxStdLeaveReportSearch
            // 
            this.txtBoxStdLeaveReportSearch.Location = new System.Drawing.Point(580, 39);
            this.txtBoxStdLeaveReportSearch.Name = "txtBoxStdLeaveReportSearch";
            this.txtBoxStdLeaveReportSearch.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStdLeaveReportSearch.TabIndex = 3;
            this.txtBoxStdLeaveReportSearch.TextChanged += new System.EventHandler(this.TxtBoxStdLeaveReportSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(157, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Pass Out or Left Record";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(8, 27);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(126, 32);
            this.btnExport.TabIndex = 5;
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
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(658, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click_1);
            // 
            // StdLeavePassRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(696, 394);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxStdLeaveReportSearch);
            this.Controls.Add(this.dgvStdLeaveReport);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StdLeavePassRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StdLeavePassRecord";
            this.Load += new System.EventHandler(this.StdLeavePassRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStdLeaveReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStdLeaveReport;
        private System.Windows.Forms.TextBox txtBoxStdLeaveReportSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLeaveRecFKstdDetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuDetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuDetFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuDetGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuDetStuPh;
        private System.Windows.Forms.DataGridViewTextBoxColumn className;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLeaveRecLeaveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLeaveRecAcademicResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLeaveRecPercenage;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
    }
}