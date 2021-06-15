namespace SMS
{
    partial class MarkAttendence
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.flpStdCBLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSetStdAtten = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShowCls = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShowSec = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Coral;
            this.lblHeading.Location = new System.Drawing.Point(314, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(320, 31);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Mark Student Attendence";
            // 
            // flpStdCBLayout
            // 
            this.flpStdCBLayout.Location = new System.Drawing.Point(39, 58);
            this.flpStdCBLayout.Name = "flpStdCBLayout";
            this.flpStdCBLayout.Size = new System.Drawing.Size(903, 399);
            this.flpStdCBLayout.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(179)))), ((int)(((byte)(187)))));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.dateTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(742, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // btnSetStdAtten
            // 
            this.btnSetStdAtten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.btnSetStdAtten.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(174)))), ((int)(((byte)(189)))));
            this.btnSetStdAtten.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.btnSetStdAtten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnSetStdAtten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetStdAtten.ForeColor = System.Drawing.Color.Black;
            this.btnSetStdAtten.Location = new System.Drawing.Point(814, 476);
            this.btnSetStdAtten.Name = "btnSetStdAtten";
            this.btnSetStdAtten.Size = new System.Drawing.Size(128, 23);
            this.btnSetStdAtten.TabIndex = 3;
            this.btnSetStdAtten.Text = "Set Attendence";
            this.btnSetStdAtten.UseVisualStyleBackColor = false;
            this.btnSetStdAtten.Click += new System.EventHandler(this.BtnSetStdAtten_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class :";
            // 
            // lblShowCls
            // 
            this.lblShowCls.AutoSize = true;
            this.lblShowCls.Location = new System.Drawing.Point(72, 24);
            this.lblShowCls.Name = "lblShowCls";
            this.lblShowCls.Size = new System.Drawing.Size(36, 13);
            this.lblShowCls.TabIndex = 5;
            this.lblShowCls.Text = "Matric";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sec :";
            // 
            // lblShowSec
            // 
            this.lblShowSec.AutoSize = true;
            this.lblShowSec.Location = new System.Drawing.Point(162, 24);
            this.lblShowSec.Name = "lblShowSec";
            this.lblShowSec.Size = new System.Drawing.Size(14, 13);
            this.lblShowSec.TabIndex = 7;
            this.lblShowSec.Text = "A";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(963, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MarkAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblShowSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblShowCls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetStdAtten);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.flpStdCBLayout);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 550);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "MarkAttendence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkAttendence";
            this.Load += new System.EventHandler(this.MarkAttendence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.FlowLayoutPanel flpStdCBLayout;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnSetStdAtten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShowCls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblShowSec;
        private System.Windows.Forms.Button btnClose;
    }
}