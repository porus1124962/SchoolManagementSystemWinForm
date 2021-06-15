using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SMS.Common;

namespace SMS
{
    public partial class newPswd : Form
    {
        DepartmentType departmentType;
        DatabaseHelper databaseHelper;
        public newPswd(DepartmentType departmentType)
        {
            this.departmentType = departmentType;
            databaseHelper = new DatabaseHelper();
           
            InitializeComponent();
            Common.RoundBorderForm(this, 10);
        }
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        private void NewPswdBtn_Click(object sender, EventArgs e)
        {
            DataTable savedPass = databaseHelper.GetAllUserPswd(departmentType, Common.LOGINFK.ToString());
            string oldPass = newPswdTB1.Text;
            string newPass = newPswdTB2.Text;
            string confirmPass = newPswdTB3.Text;

            if (oldPass=="" || newPass=="" || confirmPass == "") {
                new Alert("Enter Values First", Alert.AlertType.INFO);
            }
            else if (oldPass==newPass) {
                new Alert("Password Already Saved", Alert.AlertType.INFO);
            }
            else if (savedPass.Rows[0][0].ToString() != oldPass)
            {
                new Alert("Wrong Old Password", Alert.AlertType.WARNING);
            }
            else if (newPass != confirmPass)
            {
                new Alert("Password Mismatch", Alert.AlertType.WARNING);
            }
            else
            {
                databaseHelper.UpdatePassword(departmentType, Common.LOGINFK.ToString(), newPass);
                new Alert("Password Changed Succecfully", Alert.AlertType.SUCCESS);
                this.Close();
            }
        }

        private void NewPswdBtn_MouseEnter(object sender, EventArgs e)
        {
            newPswdBtn.FlatAppearance.BorderSize = 2;
            newPswdBtn.BackColor= Color.FromArgb(57, 210, 219);
            newPswdBtn.ForeColor = Color.White;

        }

        private void NewPswdBtn_MouseLeave(object sender, EventArgs e)
        {
            newPswdBtn.FlatAppearance.BorderSize = 3;
            newPswdBtn.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
            newPswdBtn.BackColor = Color.Transparent;
            newPswdBtn.ForeColor = Color.FromArgb(57, 210, 219);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
