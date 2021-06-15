namespace SMS
{
    partial class employeeSalary
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
            this.empSalLbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empSalaryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryFKuserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryGrossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryIntivcene = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryDeduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empSalaryNetPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // empSalLbl
            // 
            this.empSalLbl.AutoSize = true;
            this.empSalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empSalLbl.ForeColor = System.Drawing.Color.Crimson;
            this.empSalLbl.Location = new System.Drawing.Point(315, 39);
            this.empSalLbl.Name = "empSalLbl";
            this.empSalLbl.Size = new System.Drawing.Size(195, 29);
            this.empSalLbl.TabIndex = 0;
            this.empSalLbl.Text = "Employee Salary";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empSalaryId,
            this.empSalaryFKuserType,
            this.empSalaryName,
            this.empSalaryType,
            this.empSalaryGrossPay,
            this.empSalaryIntivcene,
            this.empSalaryBonus,
            this.empSalaryDeduction,
            this.empSalaryNetPay});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 368);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // empSalaryId
            // 
            this.empSalaryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empSalaryId.DataPropertyName = "empSalaryId";
            this.empSalaryId.HeaderText = "id";
            this.empSalaryId.Name = "empSalaryId";
            this.empSalaryId.Visible = false;
            // 
            // empSalaryFKuserType
            // 
            this.empSalaryFKuserType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.empSalaryFKuserType.DataPropertyName = "empSalaryFKuserType";
            this.empSalaryFKuserType.HeaderText = "Emp ID";
            this.empSalaryFKuserType.Name = "empSalaryFKuserType";
            this.empSalaryFKuserType.Width = 84;
            // 
            // empSalaryName
            // 
            this.empSalaryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empSalaryName.DataPropertyName = "empSalaryName";
            this.empSalaryName.HeaderText = "Emp Name";
            this.empSalaryName.Name = "empSalaryName";
            // 
            // empSalaryType
            // 
            this.empSalaryType.DataPropertyName = "empSalaryType";
            this.empSalaryType.HeaderText = "Emp Dept.";
            this.empSalaryType.Name = "empSalaryType";
            // 
            // empSalaryGrossPay
            // 
            this.empSalaryGrossPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empSalaryGrossPay.DataPropertyName = "empSalaryGrossPay";
            this.empSalaryGrossPay.HeaderText = "Gross Pay";
            this.empSalaryGrossPay.Name = "empSalaryGrossPay";
            // 
            // empSalaryIntivcene
            // 
            this.empSalaryIntivcene.DataPropertyName = "empSalaryIntivcene";
            this.empSalaryIntivcene.HeaderText = "Incentive";
            this.empSalaryIntivcene.Name = "empSalaryIntivcene";
            // 
            // empSalaryBonus
            // 
            this.empSalaryBonus.DataPropertyName = "empSalaryBonus";
            this.empSalaryBonus.HeaderText = "Bonus";
            this.empSalaryBonus.Name = "empSalaryBonus";
            // 
            // empSalaryDeduction
            // 
            this.empSalaryDeduction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empSalaryDeduction.DataPropertyName = "empSalaryDeduction";
            this.empSalaryDeduction.HeaderText = "Deduction";
            this.empSalaryDeduction.Name = "empSalaryDeduction";
            // 
            // empSalaryNetPay
            // 
            this.empSalaryNetPay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empSalaryNetPay.DataPropertyName = "empSalaryNetPay";
            this.empSalaryNetPay.HeaderText = "Net Pay";
            this.empSalaryNetPay.Name = "empSalaryNetPay";
            // 
            // employeeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.empSalLbl);
            this.Name = "employeeSalary";
            this.Text = "employeeSalary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label empSalLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryFKuserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryGrossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryIntivcene;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryBonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryDeduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn empSalaryNetPay;
    }
}