namespace SMS
{
    partial class leftStds
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
            this.leftStdCat = new System.Windows.Forms.ComboBox();
            this.leftStdLbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.leftStdLbl2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdLeaveRecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdLeaveRecFKstdDetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdLeaveRecLeaveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdLeaveRecAcademicResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdLeaveRecPercenage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leftStdCat
            // 
            this.leftStdCat.FormattingEnabled = true;
            this.leftStdCat.Location = new System.Drawing.Point(118, 28);
            this.leftStdCat.Name = "leftStdCat";
            this.leftStdCat.Size = new System.Drawing.Size(123, 21);
            this.leftStdCat.TabIndex = 0;
            // 
            // leftStdLbl1
            // 
            this.leftStdLbl1.AutoSize = true;
            this.leftStdLbl1.Location = new System.Drawing.Point(12, 31);
            this.leftStdLbl1.Name = "leftStdLbl1";
            this.leftStdLbl1.Size = new System.Drawing.Size(57, 13);
            this.leftStdLbl1.TabIndex = 1;
            this.leftStdLbl1.Text = "Categories";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(572, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(649, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 3;
            // 
            // leftStdLbl2
            // 
            this.leftStdLbl2.AutoSize = true;
            this.leftStdLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftStdLbl2.Location = new System.Drawing.Point(568, 100);
            this.leftStdLbl2.Name = "leftStdLbl2";
            this.leftStdLbl2.Size = new System.Drawing.Size(60, 20);
            this.leftStdLbl2.TabIndex = 4;
            this.leftStdLbl2.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdLeaveRecId,
            this.stdLeaveRecFKstdDetId,
            this.stdLeaveRecLeaveStatus,
            this.stdLeaveRecAcademicResult,
            this.stdLeaveRecPercenage});
            this.dataGridView1.Location = new System.Drawing.Point(1, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 304);
            this.dataGridView1.TabIndex = 5;
            // 
            // stdLeaveRecId
            // 
            this.stdLeaveRecId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stdLeaveRecId.DataPropertyName = "stdLeaveRecId";
            this.stdLeaveRecId.HeaderText = "stdLeaveRecId";
            this.stdLeaveRecId.Name = "stdLeaveRecId";
            this.stdLeaveRecId.Visible = false;
            // 
            // stdLeaveRecFKstdDetId
            // 
            this.stdLeaveRecFKstdDetId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stdLeaveRecFKstdDetId.DataPropertyName = "stdLeaveRecFKstdDetId";
            this.stdLeaveRecFKstdDetId.HeaderText = "Roll No#";
            this.stdLeaveRecFKstdDetId.Name = "stdLeaveRecFKstdDetId";
            // 
            // stdLeaveRecLeaveStatus
            // 
            this.stdLeaveRecLeaveStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stdLeaveRecLeaveStatus.DataPropertyName = "stdLeaveRecLeaveStatus";
            this.stdLeaveRecLeaveStatus.HeaderText = "Leave Status";
            this.stdLeaveRecLeaveStatus.Name = "stdLeaveRecLeaveStatus";
            // 
            // stdLeaveRecAcademicResult
            // 
            this.stdLeaveRecAcademicResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stdLeaveRecAcademicResult.DataPropertyName = "stdLeaveRecAcademicResult";
            this.stdLeaveRecAcademicResult.HeaderText = "Academic Result";
            this.stdLeaveRecAcademicResult.Name = "stdLeaveRecAcademicResult";
            // 
            // stdLeaveRecPercenage
            // 
            this.stdLeaveRecPercenage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stdLeaveRecPercenage.DataPropertyName = "stdLeaveRecPercenage";
            this.stdLeaveRecPercenage.HeaderText = "Percentage ";
            this.stdLeaveRecPercenage.Name = "stdLeaveRecPercenage";
            // 
            // leftStds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.leftStdLbl2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftStdLbl1);
            this.Controls.Add(this.leftStdCat);
            this.Name = "leftStds";
            this.Text = "leftStds";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox leftStdCat;
        private System.Windows.Forms.Label leftStdLbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label leftStdLbl2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLeaveRecId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLeaveRecFKstdDetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLeaveRecLeaveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLeaveRecAcademicResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdLeaveRecPercenage;
    }
}