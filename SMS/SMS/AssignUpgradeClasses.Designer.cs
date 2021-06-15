namespace SMS
{
    partial class AssignUpgradeClasses
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.dateTimePickerAssignClass = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSelectClass = new System.Windows.Forms.ComboBox();
            this.lblAssignUpgradeCls = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblSelectClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectSection = new System.Windows.Forms.ComboBox();
            this.lblStdLength = new System.Windows.Forms.Label();
            this.btnAssignClass = new System.Windows.Forms.Button();
            this.listBoxAssignBooks = new System.Windows.Forms.ListBox();
            this.lblAssignBooks = new System.Windows.Forms.Label();
            this.lblStdRNo = new System.Windows.Forms.Label();
            this.lblStdName = new System.Windows.Forms.Label();
            this.btnClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(34, 56);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(79, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Std RollNo:";
            // 
            // dateTimePickerAssignClass
            // 
            this.dateTimePickerAssignClass.CustomFormat = "MMM/yyyy";
            this.dateTimePickerAssignClass.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAssignClass.Location = new System.Drawing.Point(329, 53);
            this.dateTimePickerAssignClass.Name = "dateTimePickerAssignClass";
            this.dateTimePickerAssignClass.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAssignClass.TabIndex = 2;
            // 
            // comboBoxSelectClass
            // 
            this.comboBoxSelectClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectClass.FormattingEnabled = true;
            this.comboBoxSelectClass.Location = new System.Drawing.Point(142, 126);
            this.comboBoxSelectClass.Name = "comboBoxSelectClass";
            this.comboBoxSelectClass.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectClass.TabIndex = 3;
            this.comboBoxSelectClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectClass_SelectedIndexChanged);
            // 
            // lblAssignUpgradeCls
            // 
            this.lblAssignUpgradeCls.AutoSize = true;
            this.lblAssignUpgradeCls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAssignUpgradeCls.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignUpgradeCls.ForeColor = System.Drawing.Color.Coral;
            this.lblAssignUpgradeCls.Location = new System.Drawing.Point(158, 3);
            this.lblAssignUpgradeCls.Name = "lblAssignUpgradeCls";
            this.lblAssignUpgradeCls.Size = new System.Drawing.Size(264, 29);
            this.lblAssignUpgradeCls.TabIndex = 5;
            this.lblAssignUpgradeCls.Text = "Assign / Upgrade Class";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(34, 88);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(74, 17);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Std Name:";
            // 
            // lblSelectClass
            // 
            this.lblSelectClass.AutoSize = true;
            this.lblSelectClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSelectClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectClass.Location = new System.Drawing.Point(34, 126);
            this.lblSelectClass.Name = "lblSelectClass";
            this.lblSelectClass.Size = new System.Drawing.Size(89, 17);
            this.lblSelectClass.TabIndex = 9;
            this.lblSelectClass.Text = "Select Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select Section:";
            // 
            // comboBoxSelectSection
            // 
            this.comboBoxSelectSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectSection.FormattingEnabled = true;
            this.comboBoxSelectSection.Location = new System.Drawing.Point(142, 157);
            this.comboBoxSelectSection.Name = "comboBoxSelectSection";
            this.comboBoxSelectSection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectSection.TabIndex = 10;
            this.comboBoxSelectSection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectSection_SelectedIndexChanged);
            // 
            // lblStdLength
            // 
            this.lblStdLength.AutoSize = true;
            this.lblStdLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStdLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdLength.Location = new System.Drawing.Point(184, 196);
            this.lblStdLength.Name = "lblStdLength";
            this.lblStdLength.Size = new System.Drawing.Size(229, 24);
            this.lblStdLength.TabIndex = 12;
            this.lblStdLength.Text = "45 Students in this Section";
            // 
            // btnAssignClass
            // 
            this.btnAssignClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btnAssignClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.btnAssignClass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnAssignClass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnAssignClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignClass.ForeColor = System.Drawing.Color.White;
            this.btnAssignClass.Location = new System.Drawing.Point(229, 262);
            this.btnAssignClass.Name = "btnAssignClass";
            this.btnAssignClass.Size = new System.Drawing.Size(133, 36);
            this.btnAssignClass.TabIndex = 14;
            this.btnAssignClass.Text = "Assign Class";
            this.btnAssignClass.UseVisualStyleBackColor = false;
            this.btnAssignClass.Click += new System.EventHandler(this.BtnAssignClass_Click);
            this.btnAssignClass.MouseEnter += new System.EventHandler(this.BtnAssignClass_MouseEnter);
            this.btnAssignClass.MouseLeave += new System.EventHandler(this.BtnAssignClass_MouseLeave);
            // 
            // listBoxAssignBooks
            // 
            this.listBoxAssignBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.listBoxAssignBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAssignBooks.ForeColor = System.Drawing.Color.Black;
            this.listBoxAssignBooks.FormattingEnabled = true;
            this.listBoxAssignBooks.Location = new System.Drawing.Point(329, 109);
            this.listBoxAssignBooks.Name = "listBoxAssignBooks";
            this.listBoxAssignBooks.Size = new System.Drawing.Size(200, 69);
            this.listBoxAssignBooks.TabIndex = 15;
            // 
            // lblAssignBooks
            // 
            this.lblAssignBooks.AutoSize = true;
            this.lblAssignBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAssignBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignBooks.Location = new System.Drawing.Point(375, 88);
            this.lblAssignBooks.Name = "lblAssignBooks";
            this.lblAssignBooks.Size = new System.Drawing.Size(93, 17);
            this.lblAssignBooks.TabIndex = 16;
            this.lblAssignBooks.Text = "Assign Books";
            // 
            // lblStdRNo
            // 
            this.lblStdRNo.AutoSize = true;
            this.lblStdRNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStdRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdRNo.Location = new System.Drawing.Point(114, 57);
            this.lblStdRNo.Name = "lblStdRNo";
            this.lblStdRNo.Size = new System.Drawing.Size(75, 17);
            this.lblStdRNo.TabIndex = 17;
            this.lblStdRNo.Text = "Std RollNo";
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdName.Location = new System.Drawing.Point(114, 88);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(70, 17);
            this.lblStdName.TabIndex = 18;
            this.lblStdName.Text = "Std Name";
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClass.Location = new System.Drawing.Point(550, 3);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(31, 23);
            this.btnClass.TabIndex = 19;
            this.btnClass.Text = "X";
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.BtnClass_Click);
            // 
            // AssignUpgradeClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(202)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(587, 343);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.lblStdName);
            this.Controls.Add(this.lblStdRNo);
            this.Controls.Add(this.lblAssignBooks);
            this.Controls.Add(this.listBoxAssignBooks);
            this.Controls.Add(this.btnAssignClass);
            this.Controls.Add(this.lblStdLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectSection);
            this.Controls.Add(this.lblSelectClass);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblAssignUpgradeCls);
            this.Controls.Add(this.comboBoxSelectClass);
            this.Controls.Add(this.dateTimePickerAssignClass);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(587, 343);
            this.MinimumSize = new System.Drawing.Size(587, 343);
            this.Name = "AssignUpgradeClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Class To Student";
            this.Load += new System.EventHandler(this.AssignUpgradeClasses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DateTimePicker dateTimePickerAssignClass;
        private System.Windows.Forms.ComboBox comboBoxSelectClass;
        private System.Windows.Forms.Label lblAssignUpgradeCls;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblSelectClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectSection;
        private System.Windows.Forms.Label lblStdLength;
        private System.Windows.Forms.Button btnAssignClass;
        private System.Windows.Forms.ListBox listBoxAssignBooks;
        private System.Windows.Forms.Label lblAssignBooks;
        private System.Windows.Forms.Label lblStdRNo;
        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.Button btnClass;
    }
}