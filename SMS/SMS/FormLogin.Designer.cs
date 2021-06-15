namespace SMS
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtLogUserName = new System.Windows.Forms.TextBox();
            this.txtLogPswd = new System.Windows.Forms.TextBox();
            this.comboLogType = new System.Windows.Forms.ComboBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogUserName
            // 
            this.txtLogUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.txtLogUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogUserName.Location = new System.Drawing.Point(208, 218);
            this.txtLogUserName.Name = "txtLogUserName";
            this.txtLogUserName.Size = new System.Drawing.Size(129, 13);
            this.txtLogUserName.TabIndex = 2;
            // 
            // txtLogPswd
            // 
            this.txtLogPswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.txtLogPswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogPswd.Location = new System.Drawing.Point(208, 273);
            this.txtLogPswd.Name = "txtLogPswd";
            this.txtLogPswd.Size = new System.Drawing.Size(131, 13);
            this.txtLogPswd.TabIndex = 4;
            // 
            // comboLogType
            // 
            this.comboLogType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.comboLogType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLogType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboLogType.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLogType.ForeColor = System.Drawing.Color.White;
            this.comboLogType.FormattingEnabled = true;
            this.comboLogType.Items.AddRange(new object[] {
            "Student",
            "Teacher",
            "Administrator",
            "Accounts",
            "Admission"});
            this.comboLogType.Location = new System.Drawing.Point(177, 305);
            this.comboLogType.Name = "comboLogType";
            this.comboLogType.Size = new System.Drawing.Size(145, 21);
            this.comboLogType.TabIndex = 6;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Location = new System.Drawing.Point(202, 349);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(98, 36);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Click += new System.EventHandler(this.LblLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(186)))), ((int)(((byte)(191)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(83)))), ((int)(((byte)(100)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(47)))), ((int)(((byte)(38)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(459, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 478);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.comboLogType);
            this.Controls.Add(this.txtLogPswd);
            this.Controls.Add(this.txtLogUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(501, 478);
            this.MinimumSize = new System.Drawing.Size(501, 478);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogUserName;
        private System.Windows.Forms.TextBox txtLogPswd;
        private System.Windows.Forms.ComboBox comboLogType;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnClose;
    }
}