namespace SMS
{
    partial class ProfitLoss
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpenditureMonth = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblIncomeMonth = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblExpenditureYear = new System.Windows.Forms.Label();
            this.lblIncomeYear = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblProfitLossYear = new System.Windows.Forms.Label();
            this.lblProfitLossMonth = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(211)))), ((int)(((byte)(221)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(38)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(401, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pick A Date :";
            // 
            // lblExpenditureMonth
            // 
            this.lblExpenditureMonth.BackColor = System.Drawing.Color.Orange;
            this.lblExpenditureMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenditureMonth.Location = new System.Drawing.Point(240, 147);
            this.lblExpenditureMonth.Name = "lblExpenditureMonth";
            this.lblExpenditureMonth.Padding = new System.Windows.Forms.Padding(12);
            this.lblExpenditureMonth.Size = new System.Drawing.Size(180, 70);
            this.lblExpenditureMonth.TabIndex = 24;
            this.lblExpenditureMonth.Text = "99999";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(236, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(172, 31);
            this.label18.TabIndex = 22;
            this.label18.Text = "Expenditures";
            // 
            // lblIncomeMonth
            // 
            this.lblIncomeMonth.BackColor = System.Drawing.Color.LightGreen;
            this.lblIncomeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeMonth.Location = new System.Drawing.Point(28, 147);
            this.lblIncomeMonth.Name = "lblIncomeMonth";
            this.lblIncomeMonth.Padding = new System.Windows.Forms.Padding(12);
            this.lblIncomeMonth.Size = new System.Drawing.Size(180, 70);
            this.lblIncomeMonth.TabIndex = 21;
            this.lblIncomeMonth.Text = "99999";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(62, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 22);
            this.label12.TabIndex = 20;
            this.label12.Text = "This Month";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 31);
            this.label11.TabIndex = 19;
            this.label11.Text = "Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(272, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "This Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 29;
            this.label3.Text = "This Year";
            // 
            // lblExpenditureYear
            // 
            this.lblExpenditureYear.BackColor = System.Drawing.Color.Orange;
            this.lblExpenditureYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenditureYear.Location = new System.Drawing.Point(240, 270);
            this.lblExpenditureYear.Name = "lblExpenditureYear";
            this.lblExpenditureYear.Padding = new System.Windows.Forms.Padding(12);
            this.lblExpenditureYear.Size = new System.Drawing.Size(180, 70);
            this.lblExpenditureYear.TabIndex = 28;
            this.lblExpenditureYear.Text = "99999";
            // 
            // lblIncomeYear
            // 
            this.lblIncomeYear.BackColor = System.Drawing.Color.LightGreen;
            this.lblIncomeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeYear.Location = new System.Drawing.Point(28, 270);
            this.lblIncomeYear.Name = "lblIncomeYear";
            this.lblIncomeYear.Padding = new System.Windows.Forms.Padding(12);
            this.lblIncomeYear.Size = new System.Drawing.Size(180, 70);
            this.lblIncomeYear.TabIndex = 27;
            this.lblIncomeYear.Text = "99999";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "This Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 31);
            this.label7.TabIndex = 30;
            this.label7.Text = "Profit / Loss";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "This Year";
            // 
            // lblProfitLossYear
            // 
            this.lblProfitLossYear.BackColor = System.Drawing.Color.LightGreen;
            this.lblProfitLossYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitLossYear.Location = new System.Drawing.Point(235, 441);
            this.lblProfitLossYear.Name = "lblProfitLossYear";
            this.lblProfitLossYear.Padding = new System.Windows.Forms.Padding(12);
            this.lblProfitLossYear.Size = new System.Drawing.Size(180, 70);
            this.lblProfitLossYear.TabIndex = 33;
            this.lblProfitLossYear.Text = "99999";
            // 
            // lblProfitLossMonth
            // 
            this.lblProfitLossMonth.BackColor = System.Drawing.Color.LightGreen;
            this.lblProfitLossMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitLossMonth.Location = new System.Drawing.Point(24, 441);
            this.lblProfitLossMonth.Name = "lblProfitLossMonth";
            this.lblProfitLossMonth.Padding = new System.Windows.Forms.Padding(12);
            this.lblProfitLossMonth.Size = new System.Drawing.Size(180, 70);
            this.lblProfitLossMonth.TabIndex = 32;
            this.lblProfitLossMonth.Text = "99999";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(62, 406);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 22);
            this.label13.TabIndex = 31;
            this.label13.Text = "This Month";
            // 
            // ProfitLoss
            // 
            this.ClientSize = new System.Drawing.Size(441, 534);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblProfitLossYear);
            this.Controls.Add(this.lblProfitLossMonth);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblExpenditureYear);
            this.Controls.Add(this.lblIncomeYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblExpenditureMonth);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblIncomeMonth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfitLoss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProfitLoss_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExpenditureMonth;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblIncomeMonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblExpenditureYear;
        private System.Windows.Forms.Label lblIncomeYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblProfitLossYear;
        private System.Windows.Forms.Label lblProfitLossMonth;
        private System.Windows.Forms.Label label13;
    }
}