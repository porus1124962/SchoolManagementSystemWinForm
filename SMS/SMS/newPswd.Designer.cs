namespace SMS
{
    partial class newPswd
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
            this.newPswdLbl1 = new System.Windows.Forms.Label();
            this.newPswdLbl2 = new System.Windows.Forms.Label();
            this.newPswdLbl3 = new System.Windows.Forms.Label();
            this.newPswdBtn = new System.Windows.Forms.Button();
            this.newPswdTB1 = new System.Windows.Forms.TextBox();
            this.newPswdTB2 = new System.Windows.Forms.TextBox();
            this.newPswdTB3 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPswdLbl1
            // 
            this.newPswdLbl1.AutoSize = true;
            this.newPswdLbl1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newPswdLbl1.Location = new System.Drawing.Point(11, 50);
            this.newPswdLbl1.Name = "newPswdLbl1";
            this.newPswdLbl1.Size = new System.Drawing.Size(72, 13);
            this.newPswdLbl1.TabIndex = 0;
            this.newPswdLbl1.Text = "Old Password";
            // 
            // newPswdLbl2
            // 
            this.newPswdLbl2.AutoSize = true;
            this.newPswdLbl2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newPswdLbl2.Location = new System.Drawing.Point(12, 95);
            this.newPswdLbl2.Name = "newPswdLbl2";
            this.newPswdLbl2.Size = new System.Drawing.Size(78, 13);
            this.newPswdLbl2.TabIndex = 1;
            this.newPswdLbl2.Text = "New Password";
            // 
            // newPswdLbl3
            // 
            this.newPswdLbl3.AutoSize = true;
            this.newPswdLbl3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newPswdLbl3.Location = new System.Drawing.Point(11, 145);
            this.newPswdLbl3.Name = "newPswdLbl3";
            this.newPswdLbl3.Size = new System.Drawing.Size(91, 13);
            this.newPswdLbl3.TabIndex = 2;
            this.newPswdLbl3.Text = "Confirm Password";
            // 
            // newPswdBtn
            // 
            this.newPswdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPswdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPswdBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(210)))), ((int)(((byte)(219)))));
            this.newPswdBtn.Location = new System.Drawing.Point(78, 193);
            this.newPswdBtn.Name = "newPswdBtn";
            this.newPswdBtn.Size = new System.Drawing.Size(112, 38);
            this.newPswdBtn.TabIndex = 3;
            this.newPswdBtn.Text = "Change Password";
            this.newPswdBtn.UseVisualStyleBackColor = true;
            this.newPswdBtn.Click += new System.EventHandler(this.NewPswdBtn_Click);
            this.newPswdBtn.MouseEnter += new System.EventHandler(this.NewPswdBtn_MouseEnter);
            this.newPswdBtn.MouseLeave += new System.EventHandler(this.NewPswdBtn_MouseLeave);
            // 
            // newPswdTB1
            // 
            this.newPswdTB1.BackColor = System.Drawing.SystemColors.WindowText;
            this.newPswdTB1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.newPswdTB1.Location = new System.Drawing.Point(108, 43);
            this.newPswdTB1.Name = "newPswdTB1";
            this.newPswdTB1.Size = new System.Drawing.Size(127, 20);
            this.newPswdTB1.TabIndex = 4;
            this.newPswdTB1.UseSystemPasswordChar = true;
            // 
            // newPswdTB2
            // 
            this.newPswdTB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.newPswdTB2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newPswdTB2.Location = new System.Drawing.Point(108, 92);
            this.newPswdTB2.Name = "newPswdTB2";
            this.newPswdTB2.Size = new System.Drawing.Size(127, 20);
            this.newPswdTB2.TabIndex = 5;
            this.newPswdTB2.UseSystemPasswordChar = true;
            // 
            // newPswdTB3
            // 
            this.newPswdTB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.newPswdTB3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.newPswdTB3.Location = new System.Drawing.Point(108, 138);
            this.newPswdTB3.MaximumSize = new System.Drawing.Size(127, 20);
            this.newPswdTB3.MinimumSize = new System.Drawing.Size(127, 20);
            this.newPswdTB3.Name = "newPswdTB3";
            this.newPswdTB3.Size = new System.Drawing.Size(127, 20);
            this.newPswdTB3.TabIndex = 6;
            this.newPswdTB3.UseSystemPasswordChar = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(243, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // newPswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(1)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(279, 295);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.newPswdTB3);
            this.Controls.Add(this.newPswdTB2);
            this.Controls.Add(this.newPswdTB1);
            this.Controls.Add(this.newPswdBtn);
            this.Controls.Add(this.newPswdLbl3);
            this.Controls.Add(this.newPswdLbl2);
            this.Controls.Add(this.newPswdLbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(279, 295);
            this.MinimumSize = new System.Drawing.Size(279, 295);
            this.Name = "newPswd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newPswdLbl1;
        private System.Windows.Forms.Label newPswdLbl2;
        private System.Windows.Forms.Label newPswdLbl3;
        private System.Windows.Forms.Button newPswdBtn;
        private System.Windows.Forms.TextBox newPswdTB1;
        private System.Windows.Forms.TextBox newPswdTB2;
        private System.Windows.Forms.TextBox newPswdTB3;
        private System.Windows.Forms.Button btnClose;
    }
}