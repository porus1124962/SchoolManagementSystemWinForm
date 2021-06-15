namespace SMS
{
    partial class ExpendituresForm
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
            this.dgvExp = new System.Windows.Forms.DataGridView();
            this.expendituresId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expendituresName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expendituresDescribtion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expendituresChareges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expendituresProfitLose = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.expendituresDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExp
            // 
            this.dgvExp.AllowUserToResizeColumns = false;
            this.dgvExp.AllowUserToResizeRows = false;
            this.dgvExp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.dgvExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(106)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExp.ColumnHeadersHeight = 40;
            this.dgvExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expendituresId,
            this.expendituresName,
            this.expendituresDescribtion,
            this.expendituresChareges,
            this.expendituresProfitLose,
            this.expendituresDate});
            this.dgvExp.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExp.EnableHeadersVisualStyles = false;
            this.dgvExp.Location = new System.Drawing.Point(0, 58);
            this.dgvExp.Name = "dgvExp";
            this.dgvExp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvExp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExp.RowHeadersVisible = false;
            this.dgvExp.Size = new System.Drawing.Size(800, 392);
            this.dgvExp.TabIndex = 0;
            this.dgvExp.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExp_CellValueChanged);
            // 
            // expendituresId
            // 
            this.expendituresId.DataPropertyName = "expendituresId";
            this.expendituresId.HeaderText = "Column1";
            this.expendituresId.Name = "expendituresId";
            this.expendituresId.Visible = false;
            // 
            // expendituresName
            // 
            this.expendituresName.DataPropertyName = "expendituresName";
            this.expendituresName.HeaderText = "Expenditure Name";
            this.expendituresName.Name = "expendituresName";
            // 
            // expendituresDescribtion
            // 
            this.expendituresDescribtion.DataPropertyName = "expendituresDescribtion";
            this.expendituresDescribtion.HeaderText = "Expenditure Describtion";
            this.expendituresDescribtion.Name = "expendituresDescribtion";
            // 
            // expendituresChareges
            // 
            this.expendituresChareges.DataPropertyName = "expendituresChareges";
            this.expendituresChareges.HeaderText = "Expenditure Chareges";
            this.expendituresChareges.Name = "expendituresChareges";
            // 
            // expendituresProfitLose
            // 
            this.expendituresProfitLose.DataPropertyName = "expendituresProfitLose";
            this.expendituresProfitLose.HeaderText = "Profit / Loss";
            this.expendituresProfitLose.Items.AddRange(new object[] {
            "Profit",
            "Loss"});
            this.expendituresProfitLose.Name = "expendituresProfitLose";
            // 
            // expendituresDate
            // 
            this.expendituresDate.DataPropertyName = "expendituresDate";
            this.expendituresDate.HeaderText = "Expenditure Date";
            this.expendituresDate.Name = "expendituresDate";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(762, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(12, 19);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(67, 21);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "Search :";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(85, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 3;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExport.Location = new System.Drawing.Point(210, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 32);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export To Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            this.btnExport.MouseEnter += new System.EventHandler(this.BtnExport_MouseEnter);
            this.btnExport.MouseLeave += new System.EventHandler(this.BtnExport_MouseLeave);
            // 
            // ExpendituresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvExp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ExpendituresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpendituresForm";
            this.Load += new System.EventHandler(this.ExpendituresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn expendituresId;
        private System.Windows.Forms.DataGridViewTextBoxColumn expendituresName;
        private System.Windows.Forms.DataGridViewTextBoxColumn expendituresDescribtion;
        private System.Windows.Forms.DataGridViewTextBoxColumn expendituresChareges;
        private System.Windows.Forms.DataGridViewComboBoxColumn expendituresProfitLose;
        private System.Windows.Forms.DataGridViewTextBoxColumn expendituresDate;
        private System.Windows.Forms.Button btnExport;
    }
}