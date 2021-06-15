using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace SMS
{
    public partial class FormLogin : Form
    {
        DatabaseHelper databaseHelper;

        public FormLogin()
        {
            InitializeComponent();
            databaseHelper = new DatabaseHelper();
            Common.RoundBorderForm(this, 12);
        }

        public void LoadDashboard(string userType,int userFk,bool saveLoginState) {
            if (saveLoginState)
            {
                databaseHelper.saveLoginState(userType, userFk);
            }
            Common.LOGINTYPE = userType;
            Common.LOGINFK = userFk;

            switch (userType) {
                case "Student":
                    Common.LOGINNAME = databaseHelper.GetTBLDetailsAllDepartments(Common.DepartmentType.STUDENT,userFk).Rows[0][1].ToString();
                    break;
                case "Teacher":
                    Common.LOGINNAME = databaseHelper.GetTBLDetailsAllDepartments(Common.DepartmentType.TEACHER, userFk).Rows[0][1].ToString();
                    break;
                case "Administrator":
                    Common.LOGINNAME = databaseHelper.GetTBLDetailsAllDepartments(Common.DepartmentType.ADMIN, userFk).Rows[0][1].ToString();
                    break;
                case "Accounts":
                    Common.LOGINNAME = databaseHelper.GetTBLDetailsAllDepartments(Common.DepartmentType.ACCOUNTS, userFk).Rows[0][1].ToString();
                    break;
                case "Admission":
                    Common.LOGINNAME = databaseHelper.GetTBLDetailsAllDepartments(Common.DepartmentType.HR, userFk).Rows[0][1].ToString();
                    break;
            }
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            comboLogType.SelectedIndex = 0;
            txtLogUserName.SetHint("UserName or Email");
            txtLogPswd.SetHint("Password");
            string isLogin = databaseHelper.CheckLogin();
            if(isLogin != "NeedLogin") {
                int fk = databaseHelper.GetFKOfAlreadySignedInUser("FKOFAlreadySignedIn" + isLogin);
                LoadDashboard(isLogin, fk, false);
            }
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {
            string usernameEmail = txtLogUserName.Text;
            string pass = txtLogPswd.Text;
            string logType = comboLogType.Text;
            if (usernameEmail.Equals("") || pass.Equals("") || logType.Equals(""))
            {
                new Alert("Fill All Fields!", Alert.AlertType.WARNING).Show();
                return;
            }
            string isLogin = databaseHelper.Login(usernameEmail, pass, logType);

            if (isLogin == "NotValid")
            {
                new Alert("Wrong Id Password!", Alert.AlertType.ERROR).Show();
            }
            else
            {
                MessageBox.Show("Welcome!");
                LoadDashboard(logType, Convert.ToInt32(isLogin), true);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
