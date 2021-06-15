using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using static SMS.Common;
using static SMS.Alert;

namespace SMS
{
    public partial class Dashboard : Form
    {
        DatabaseHelper databaseHelper;
        DepartmentType departmentType;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Dashboard()
        {
            InitializeComponent();
            databaseHelper = new DatabaseHelper();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblName.Text = "Name: " + Common.LOGINNAME;
            lblLoginType.Text = Common.LOGINTYPE;

            switch (lblLoginType.Text)
            {
                case "Student":
                    departmentType = DepartmentType.STUDENT;
                    btnDptDetails.Visible = false;
                    btnMarkMyAttendence.Visible = false;
                    btnLeftStd.Visible = false;
                    btnExEmployeDet.Visible = false;
                    btnShowFeesReport.Visible = false;
                    btnShowAttenClassReport.Visible = false;
                    btnShowEmployeSalary.Visible = false;
                    btnExpenditure.Visible = false;
                    btnShowIndFeesForStdOnly.Visible = true;
                    btnShowChangePass2.Visible = true;
                    btnChangePass.Visible = false;
                    showPanel(flpDashboardForStdOnly);
                    LoadStdData();
                    break;
                case "Accounts":
                    btnCreateUsers.Visible = false;
                    departmentType = DepartmentType.ACCOUNTS;
                    btnAccDetails.Visible = true;
                    btnLeftStd.Visible = false;
                    btnExEmployeDet.Visible = false;
                    btnShowAttenClassReport.Visible = false;
                    btnShowChangePass2.Visible = true;
                    btnChangePass.Visible = false;
                    btnMarkMyAttendence.Visible = false;
                    btnMarkMyAttendence2.Visible = true;
                    btnDeepDetails.Visible = false;
                    btnDeepDetails2.Visible = true;
                    LoadDashboardCharts();
                    break;
                case "Teacher":
                    btnCreateUsers.Visible = false;
                    departmentType = DepartmentType.TEACHER;
                    btnShowClsSecSub.Visible = true;
                    btnLeftStd.Visible = false;
                    btnExEmployeDet.Visible = false;
                    btnShowFeesReport.Visible = false;
                    btnShowEmployeSalary.Visible = false;
                    btnExpenditure.Visible = false;
                    btnShowChangePass2.Visible = true;
                    btnChangePass.Visible = false;
                    btnMarkMyAttendence.Visible = false;
                    btnMarkMyAttendence2.Visible = true;
                    showPanel(flpDashboardForStdOnly);
                    LoadStdData();
                    break;
                case "Admission":
                    btnCreateUserAdmin.Visible = false;
                    departmentType = DepartmentType.HR;
                    btnAccDetails.Visible = true;
                    btnShowFeesReport.Visible = false;
                    btnShowEmployeSalary.Visible = false;
                    btnExpenditure.Visible = false;
                    btnShowAttenClassReport.Visible = false;
                    btnShowChangePass2.Visible = true;
                    btnChangePass.Visible = false;
                    btnMarkMyAttendence.Visible = false;
                    btnMarkMyAttendence2.Visible = true;
                    showPanel(flpDashboardForHrOnly);
                    LoadHrDashboard();
                    break;
                case "Administrator":
                    departmentType = DepartmentType.ADMIN;
                    btnAccDetails.Visible = true;
                    btnShowClsSecSub.Visible = true;
                    LoadDashboardCharts();
                    break;
            }
            SetBtnMarkMyAttendence();
        }

        private void LoadHrDashboard()
        {

            int students = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.STUDENT).Rows.Count;
            int teachers = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.TEACHER).Rows.Count;
            int accounts = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.ACCOUNTS).Rows.Count;
            int hrs = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.HR).Rows.Count;
            int admins = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.ADMIN).Rows.Count;

            chartPieHr.Series[0].Points.Clear();
            chartPieHr.BackColor = Color.Transparent;
            chartPieHr.ChartAreas[0].BackColor = Color.Transparent;
            chartPieHr.Legends[0].BackColor = Color.Transparent;

            chartPieHr.Series[0].Points.Add(students);
            chartPieHr.Series[0].Points[0].Color = Color.Green;
            chartPieHr.Series[0].Points[0].AxisLabel = "Students";
            chartPieHr.Series[0].Points[0].LegendText = "Students";
            chartPieHr.Series[0].Points[0].Label = ""+students;

            chartPieHr.Series[0].Points.Add(teachers);
            chartPieHr.Series[0].Points[1].Color = Color.Blue;
            chartPieHr.Series[0].Points[1].AxisLabel = "Teacher";
            chartPieHr.Series[0].Points[1].LegendText = "Teacher";
            chartPieHr.Series[0].Points[1].Label = ""+teachers;

            chartPieHr.Series[0].Points.Add(hrs);
            chartPieHr.Series[0].Points[2].Color = Color.Yellow;
            chartPieHr.Series[0].Points[2].AxisLabel = "Admission";
            chartPieHr.Series[0].Points[2].LegendText = "Admission";
            chartPieHr.Series[0].Points[2].Label = ""+hrs;

            chartPieHr.Series[0].Points.Add(accounts);
            chartPieHr.Series[0].Points[3].Color = Color.Orange;
            chartPieHr.Series[0].Points[3].AxisLabel = "Accountant";
            chartPieHr.Series[0].Points[3].LegendText = "Accountant";
            chartPieHr.Series[0].Points[3].Label = ""+accounts;

            chartPieHr.Series[0].Points.Add(admins);
            chartPieHr.Series[0].Points[4].Color = Color.Red;
            chartPieHr.Series[0].Points[4].AxisLabel = "Admin";
            chartPieHr.Series[0].Points[4].LegendText = "Admin";
            chartPieHr.Series[0].Points[4].Label = ""+admins;
        }

        private void LoadStdData()
        {
            DataRow row = databaseHelper.GetTBLDetailsAllDepartments(departmentType, LOGINFK).Rows[0];
            lblNameForStd.Text = row[1].ToString();
            lblFNameForStd.Text = row[2].ToString();
            lblAgeForStd.Text = row[3].ToString();
            lblGenderForStd.Text = row[4].ToString();
            lblAddressForStd.Text = row[5].ToString();
            lblStdPhForStd.Text = row[6].ToString();
            lblFPhForStd.Text = row[7].ToString();
            if(departmentType == DepartmentType.TEACHER)
            {
                lbl7Welcome.Text = "Email";

                lbl8Value.Visible = true;
                lbl8Welcome.Visible = true;
                lbl9Value.Visible = true;
                lbl9Welcome.Visible = true;

                lbl8Value.Text = row[8].ToString();
                lbl9Value.Text = row[9].ToString();
            }
        }

        private void SetBtnMarkMyAttendence()
        {
            DataTable tbl = databaseHelper.GetAttendenceTBL(departmentType, Common.LOGINFK, DateTime.Now.ToString("dd/MMM/yyyy"));
            if(tbl.Rows.Count > 0 && tbl.Rows[0][3].ToString() == "P")
            {
                btnMarkMyAttendence.Text = "Delete My Attendence";
                btnMarkMyAttendence2.Text = "Delete My Attendence";
            }
        }

        public void showPanel(FlowLayoutPanel pnl)
        {
            tlpForPanel.Controls.Clear();
            //add top header in 0,0 in tlpForPanel
            tlpForPanel.Controls.Add(flowLayoutPanel3, 0, 0);
            //add current panel in 0,1 in tlpForPanel
            tlpForPanel.Controls.Add(pnl, 0, 1);
        }

        public void showPanel(Panel pnl)
        {
            tlpForPanel.Controls.Clear();
            //add top header in 0,0 in tlpForPanel
            tlpForPanel.Controls.Add(flowLayoutPanel3, 0, 0);
            //add current panel in 0,1 in tlpForPanel
            tlpForPanel.Controls.Add(pnl, 0, 1);
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            databaseHelper.Logout();
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Visible = false;
            formLogin.ShowDialog();
            this.Close();
        }

        private void BtnCreateUsers_Click(object sender, EventArgs e)
        {
            showPanel(flpCreateUser);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            switch (departmentType)
            {
                case DepartmentType.STUDENT:
                    showPanel(flpDashboardForStdOnly);
                    break;
                case DepartmentType.TEACHER:
                    showPanel(flpDashboardForStdOnly);
                    break;
                case DepartmentType.HR:
                    showPanel(flpDashboardForHrOnly);
                    break;
                default:
                    showPanel(flpShowDashboard);
                    break;
            }
        }

        private void LoadFLPStdDetails(){
            textBoxSearchStdDetail.SetHint("Search Any Column");

            PopulateCBClasses();
            string selectedClass = ComboBoxSelectClassForTeacher.SelectedValue.ToString();
            if (selectedClass == "--No Class--")
            {
                PopulateCBSections(0);
            }
            else
            {
                int key = Convert.ToInt32(selectedClass);
                PopulateCBSections(key);
            }
            PopulateStdDGV();

            switch (departmentType)
            {
                case DepartmentType.TEACHER:
                    btnAssignClassToStd.Visible = false;
                    btnStdFeeReport.Visible = false;
                    btnShiftStdToPass.Visible = false;
                    btnExcelStd.Margin = new Padding(260, 0, 8, 3);
                    lblSearchInStdDet.Margin = new Padding(345, 12, 3, 3);
                    checkBoxStdDetail.Checked = true;
                    checkBoxStdDetail.Hide();
                    dgvStdDetails.ReadOnly = true;
                    dgvStdDetails.AllowUserToAddRows = false;
                    dgvStdDetails.AllowUserToDeleteRows = false;
                    break;
                case DepartmentType.ADMIN:
                    btnMarkAttendenceForTeacher.Visible = false;
                    lblSearchInStdDet.Margin = new Padding(135, 12, 3, 3);
                    break;
                case DepartmentType.HR:
                    btnStdFeeReport.Visible = false;
                    btnMarkAttendenceForTeacher.Visible = false;
                    lblSearchInStdDet.Margin = new Padding(230, 12, 3, 3);
                    break;
                case DepartmentType.ACCOUNTS:
                    btnAssignClassToStd.Visible = false;
                    btnShiftStdToPass.Visible = false;
                    btnMarkAttendenceForTeacher.Visible = false;
                    btnStdAttenMonthlyReport.Visible = false;
                    lblSearchInStdDet.Margin = new Padding(545, 12, 3, 3);
                    break;
            }
        }

        private void LoadFLPTeacherDetails()
        {
            if (departmentType == Common.DepartmentType.ADMIN || departmentType == Common.DepartmentType.HR)
            {
                btnAssignSecToTeacher.Visible = true;
            }
            else
            {
                btnAssignSecToTeacher.Visible = false;
            }
            PopulateTeacherDGV();
        }

        private void LoadFLPAccDetails()
        {
            PopulateAccDGV();
        }

        private void LoadFLPHrDetails()
        {
            PopulateHrDGV();
        }

        private void LoadFLPAdminDetails()
        {
            PopulateAdminDGV();
        }

        private void LoadFLPSubClassSec()
        {
            try
            {
                PopulateDataGridViewComboBoxColumnClsSecSub(secFkclassId);
                PopulateDataGridViewComboBoxColumnClsSecSub(clsBookClsLevel);
                PopulateClassDGV();
                string value = dgvClass.Rows[0].Cells["classId"].Value.ToString();
                PopulateSecDGV(Convert.ToInt32(value));
                PopulateSubDGV(Convert.ToInt32(value));
                if (departmentType == DepartmentType.TEACHER || departmentType == DepartmentType.HR)
                {
                    lblFees.Visible = false;
                    btnSaveFeesClsSec.Visible = false;
                    textBoxFeesClsSec.Visible = false;

                    dgvClass.AllowUserToAddRows = false;
                    dgvClass.AllowUserToDeleteRows = false;
                    dgvClass.ReadOnly = true;

                    dgvSection.AllowUserToAddRows = false;
                    dgvSection.AllowUserToDeleteRows = false;
                    dgvSection.ReadOnly = true;

                    dgvSubject.AllowUserToAddRows = false;
                    dgvSubject.AllowUserToDeleteRows = false;
                    dgvSubject.ReadOnly = true;
                }
                else
                {
                    PopulateTextBoxFees();
                }
            }
            catch (Exception)
            {

            }
        }

        private void PopulateTextBoxFees()
        {
            if(dgvClass.CurrentRow != null)
            {
                int fees = databaseHelper.GetFeesAccToClass(dgvClass.CurrentRow.Cells[0].Value.ToString());
                textBoxFeesClsSec.Text = fees.ToString();
            }
        }

        private void PopulateDataGridViewComboBoxColumnClsSecSub(DataGridViewComboBoxColumn dataGridViewComboBoxColumn)
        {
            dataGridViewComboBoxColumn.DataSource = databaseHelper.GetClassesTBL();
            dataGridViewComboBoxColumn.DisplayMember = "className";
            dataGridViewComboBoxColumn.ValueMember = "classId";
        }

        private void PopulateClassDGV() {
            if(departmentType == Common.DepartmentType.TEACHER) {
                dgvClass.DataSource = Common.RemoveDuplicateRows(databaseHelper.GetClassesListAssignedAgainstTeacherTBL(Common.LOGINFK.ToString()), "className");
            }
            else
            {
                dgvClass.DataSource = databaseHelper.GetClassesTBL();
            }
            
        }

        private void PopulateSecDGV(int classId)
        {
            try
            {
                if (departmentType == Common.DepartmentType.TEACHER)
                {
                    dgvSection.DataSource = databaseHelper.GetSectionsTBL(Common.LOGINFK, classId);
                }
                else
                {
                    dgvSection.DataSource = databaseHelper.GetSectionsTBL(classId);
                }
            }
            catch (Exception){}
            
        }

        private void PopulateSubDGV(int classId)
        {
            dgvSubject.DataSource = databaseHelper.GetSubjectsTBL(classId);
        }

        private void PopulateStdDGV() {
            if (departmentType != Common.DepartmentType.TEACHER)
            {
                string search;
                string text = textBoxSearchStdDetail.Text;
                if (text == "Search Any Column")
                {
                    search = null;
                }
                else
                {
                    search = text;
                }

                DataTable tbl = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.STUDENT);
                if (search == null || search == "")
                {
                    dgvStdDetails.DataSource = tbl;
                }
                else
                {
                    string filterQuery;
                    if (search.Any(char.IsDigit))
                    {
                        int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                        filterQuery = "stuDetId = " + searchTermInt + " or stuDetName like '" + search + "%' or stuDetAge like '" + search + "%' or stuDetGender like '" + search + "%' or stuDetAddress like '" + search + "%' or stuDetLastClass like '" + search + "%' or stuAuthUsername like '" + search + "%'";
                    }
                    else
                    {
                        filterQuery = "stuDetName like '" + search + "%' or stuDetAge like '" + search + "%' or stuDetGender like '" + search + "%' or stuDetAddress like '" + search + "%' or stuDetLastClass like '" + search + "%' or stuAuthUsername like '" + search + "%'";
                    }
                    BindingSource bs = new BindingSource();
                    bs.DataSource = tbl;
                    bs.Filter = filterQuery;
                    dgvStdDetails.DataSource = bs;
                }
            }
        }

        private void PopulateStdDGV(DataTable tbl)
        {
            string search;
            string text = textBoxSearchStdDetail.Text;
            if (text == "Search Any Column")
            {
                search = null;
            }
            else
            {
                search = text;
            }

            if (search == null || search == "")
            {
                dgvStdDetails.DataSource = tbl;
            }
            else
            {
                string filterQuery;
                if (search.Any(char.IsDigit))
                {
                    int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                    filterQuery = "stuDetId = " + searchTermInt + " or stuDetName like '" + search + "%' or stuDetAge like '" + search + "%' or stuDetGender like '" + search + "%' or stuDetAddress like '" + search + "%' or stuDetLastClass like '" + search + "%' or stuAuthUsername like '" + search + "%'";
                }
                else
                {
                    filterQuery = "stuDetName like '" + search + "%' or stuDetAge like '" + search + "%' or stuDetGender like '" + search + "%' or stuDetAddress like '" + search + "%' or stuDetLastClass like '" + search + "%' or stuAuthUsername like '" + search + "%'";
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = tbl;
                bs.Filter = filterQuery;
                dgvStdDetails.DataSource = bs;
            }
        }

        private void PopulateTeacherDGV()
        {
            string search = teachSearchTB.Text;

            DataTable tbl = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.TEACHER);

            if (search == null || search == "")
            {
                dgvTeacherDetails.DataSource = tbl;
            }
            else
            {
                string filterQuery;
                if (search.Any(char.IsDigit))
                {
                    int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                    filterQuery = "teacherDetId = "+searchTermInt+" or teacherDetName like '"+search+"%' or teacherDetAge like '"+search+ "%' or teacherDetGender like '" + search + "%' or teacherDetAddress like '" + search + "%' or teacherDetQualification like '" + search + "%' or teacherDetSubject like '" + search + "%' or teacherAuthUsername like '" + search + "%'";
                }
                else
                {
                    filterQuery = "teacherDetName like '" + search + "%' or teacherDetAge like '" + search + "%' or teacherDetGender like '" + search + "%' or teacherDetAddress like '" + search + "%' or teacherDetEmail like '" + search + "%' or teacherDetQualification like '" + search + "%' or teacherDetSubject like '" + search + "%' or teacherAuthUsername like '" + search + "%'";
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = tbl;
                bs.Filter = filterQuery;
                dgvTeacherDetails.DataSource = bs;
            }
        }

        private void PopulateAccDGV()
        {
            string search = accSearchTB.Text;

            DataTable tbl = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.ACCOUNTS);

            if (search == null || search == "")
            {
                dgvAccDetails.DataSource = tbl;
            }
            else
            {
                string filterQuery;
                if (search.Any(char.IsDigit))
                {
                    int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                    filterQuery = "accDetId = " + searchTermInt + " or accDetName like '" + search + "%' or accDetGender like '" + search + "%' or accDetAddress like '" + search + "%' or accAuthUsername like '" + search + "%' or accDetStuPh like '" + search + "%'";
                }
                else
                {
                    filterQuery = " accDetName like '" + search + "%' or accDetGender like '" + search + "%' or accDetAddress like '" + search + "%' or accAuthUsername like '" + search + "%' or accDetStuPh like '" + search + "%'";
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = tbl;
                bs.Filter = filterQuery;
                dgvAccDetails.DataSource = bs;
            }


        }

        private void PopulateHrDGV()
        {
            string search = hrSearchTB.Text;

            DataTable tbl = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.HR);

            if (search == null || search == "")
            {
                dgvHrDetails.DataSource = tbl;
            }
            else
            {
                string filterQuery;
                if (search.Any(char.IsDigit))
                {
                    int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                    filterQuery = "hrDetId = " + searchTermInt + " or hrDetName like '" + search + "%' or hrDetGender like '" + search + "%' or hrDetAddress like '" + search + "%' or hrAuthUsername like '" + search + "%' or hrDetStuPh like '" + search + "%'";
                }
                else
                {
                    filterQuery = "hrDetName like '" + search + "%' or hrDetGender like '" + search + "%' or hrDetAddress like '" + search + "%' or hrAuthUsername like '" + search + "%' or hrDetStuPh like '" + search + "%'";
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = tbl;
                bs.Filter = filterQuery;
                dgvHrDetails.DataSource = bs;
            }

          
        }

        private void PopulateAdminDGV()
        {
            string search = adminSearchTB.Text;

            DataTable tbl = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.ADMIN);

            if (search == null || search == "")
            {
                dgvAdminsDetails.DataSource = tbl;
            }
            else
            {
                string filterQuery;
                if (search.Any(char.IsDigit))
                {
                    int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                    filterQuery = "adminDetId = " + searchTermInt + " or adminDetName like '" + search + "%' or adminDetGender like '" + search + "%' or adminDetAddress like '" + search + "%' or adminDetStuPh like '" + search + "%' or adminAuthUsername like '" + search + "%'";
                }
                else
                {
                    filterQuery = "adminDetName like '" + search + "%' or adminDetGender like '" + search + "%' or adminDetAddress like '" + search + "%' or adminDetStuPh like '" + search + "%' or adminAuthUsername like '" + search + "%'";
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = tbl;
                bs.Filter = filterQuery;
                dgvAdminsDetails.DataSource = bs;
            }


          
        }

        private void BtnCreateUserStd_Click(object sender, EventArgs e)
        {
            lblCreateUserHeading.Text = "Student";
            btnCreateUserCreate.Text = "Create Student Account";
            lbl2ndG1.Text = "Father Ph";
            lbl2ndG2.Text = "Last Class";
            lbl2ndG3.Text = "Last School";
            lbl1stG5.Text = "Student Ph";
            lbl1stG2.Visible = true;
            textBox1stG1.Visible = true;
            lbl1stG3.Visible = true;
            textBox1stG3.Visible = true;
            lbl2ndG1.Visible = true;
            textBox2ndG1.Visible = true;
            lbl2ndG2.Visible = true;
            textBox2ndG2.Visible = true;
            lbl2ndG3.Visible = true;
            textBox2ndG3.Visible = true;
        }

        private void BtnCreateUserTeacher_Click(object sender, EventArgs e)
        {
            lblCreateUserHeading.Text = "Teacher";
            btnCreateUserCreate.Text = "Create Teacher Account";
            lbl2ndG1.Text = "Email";
            lbl2ndG2.Text = "Qualification";
            lbl2ndG3.Text = "Subject";
            lbl1stG2.Visible = true;
            textBox1stG1.Visible = true;
            lbl1stG3.Visible = true;
            textBox1stG3.Visible = true;
            lbl1stG5.Text = "Phone #";
            lbl2ndG1.Visible = true;
            textBox2ndG1.Visible = true;
            lbl2ndG2.Visible = true;
            textBox2ndG2.Visible = true;
            lbl2ndG3.Visible = true;
            textBox2ndG3.Visible = true;
        }

        private void BtnCreateUserAcc_Click(object sender, EventArgs e)
        {
            lblCreateUserHeading.Text = "Accountants";
            btnCreateUserCreate.Text = "Create Accountants Account";
            lbl1stG2.Visible = false;
            textBox1stG1.Visible = false;
            lbl1stG3.Visible = false;
            textBox1stG3.Visible = false;
            lbl1stG5.Text = "Phone #";
            lbl2ndG1.Visible = false;
            textBox2ndG1.Visible = false;
            lbl2ndG2.Visible = false;
            textBox2ndG2.Visible = false;
            lbl2ndG3.Visible = false;
            textBox2ndG3.Visible = false;
        }

        private void BtnCreateUserAdmission_Click(object sender, EventArgs e)
        {
            lblCreateUserHeading.Text = "Admission";
            btnCreateUserCreate.Text = "Create Admission Account";
            lbl1stG2.Visible = false;
            textBox1stG1.Visible = false;
            lbl1stG3.Visible = false;
            textBox1stG3.Visible = false;
            lbl1stG5.Text = "Phone #";
            lbl2ndG1.Visible = false;
            textBox2ndG1.Visible = false;
            lbl2ndG2.Visible = false;
            textBox2ndG2.Visible = false;
            lbl2ndG3.Visible = false;
            textBox2ndG3.Visible = false;
        }

        private void BtnCreateUserAdmin_Click(object sender, EventArgs e)
        {
            lblCreateUserHeading.Text = "Administrator";
            btnCreateUserCreate.Text = "Create Admin Account";
            lbl1stG2.Visible = false;
            textBox1stG1.Visible = false;
            lbl1stG3.Visible = false;
            textBox1stG3.Visible = false;
            lbl1stG5.Text = "Phone #";
            lbl2ndG1.Visible = false;
            textBox2ndG1.Visible = false;
            lbl2ndG2.Visible = false;
            textBox2ndG2.Visible = false;
            lbl2ndG3.Visible = false;
            textBox2ndG3.Visible = false;
        }

        private void BtnCreateUserCreate_Click(object sender, EventArgs e)
        {
            string g1v1 = textBox1stG1.Text;
            string g1v2 = textBox1stG2.Text;
            string g1v3 = textBox1stG3.Text;
            string g1v4 = textBox1stG4.Text;
            string g1v5 = textBox1stG5.Text;
            string g1v6 = "";

            if (rbMale.Checked)
            {
                g1v6 = "Male";
            }else if (rbFemale.Checked)
            {
                g1v6 = "Female";
            }else if (rbOther.Checked)
            {
                g1v6 = "Other";
            }

            string g2v1 = textBox2ndG1.Text;
            string g2v2 = textBox2ndG2.Text;
            string g2v3 = textBox2ndG3.Text;
            string username = textBox2ndG4.Text;
            string pass = textBox2ndG5.Text;
            bool result = false;

            switch (btnCreateUserCreate.Text)
            {
                case "Create Student Account":
                    result = databaseHelper.RegisterUser(Common.DepartmentType.STUDENT, g1v1, g1v2, g1v3, g1v6, g1v4, g1v5, g2v1, g2v2, g2v3, username, pass);
                    break;
                case "Create Teacher Account":
                    result = databaseHelper.RegisterUser(Common.DepartmentType.TEACHER, g1v1, g1v2, g1v3, g1v6, g1v4, g1v5, g2v1, g2v2, g2v3, username, pass);
                    break;
                case "Create Accountants Account":
                    result = databaseHelper.RegisterUser(Common.DepartmentType.ACCOUNTS, g1v2, g1v6, g1v4, g1v5, null, null, null, null, null, username, pass);
                    break;
                case "Create Admission Account":
                    result = databaseHelper.RegisterUser(Common.DepartmentType.HR, g1v2, g1v6, g1v4, g1v5, null, null, null, null, null, username, pass);
                    break;
                case "Create Admin Account":
                    result = databaseHelper.RegisterUser(Common.DepartmentType.ADMIN, g1v2, g1v6, g1v4, g1v5, null, null, null, null, null, username, pass);
                    break;
            }

            if(result == true)
            {
                textBox1stG1.Text = "";
                textBox1stG2.Text = "";
                textBox1stG3.Text = "";
                textBox1stG4.Text = "";
                textBox1stG5.Text = "";
                textBox2ndG1.Text = "";
                textBox2ndG2.Text = "";
                textBox2ndG3.Text = "";
                textBox2ndG4.Text = "";
                textBox2ndG5.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                rbOther.Checked = false;
            }
        }

        private void dgvHrDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvHrDetails.CurrentRow;
            if (dgvHrDetails.CurrentRow != null)
            {
                if (dgvRow.Cells["hrDetId"].Value == DBNull.Value)
                {
                    //insert code
                    if (dgvRow.Cells["hrDetName"].Value != DBNull.Value &&
                        dgvRow.Cells["hrDetGender"].Value != DBNull.Value &&
                        dgvRow.Cells["hrDetAddress"].Value != DBNull.Value &&
                        dgvRow.Cells["hrDetStuPh"].Value != DBNull.Value &&
                        dgvRow.Cells["hrAuthUsername"].Value != DBNull.Value &&
                        dgvRow.Cells["hrAuthPass"].Value != DBNull.Value)
                    {
                        bool result = databaseHelper.RegisterUser(Common.DepartmentType.HR,
                        dgvRow.Cells["hrDetName"].Value.ToString(),
                        dgvRow.Cells["hrDetGender"].Value.ToString(),
                        dgvRow.Cells["hrDetAddress"].Value.ToString(),
                        dgvRow.Cells["hrDetStuPh"].Value.ToString(),
                        null,
                        null,
                        null,
                        null,
                        null,
                        dgvRow.Cells["hrAuthUsername"].Value.ToString(),
                        dgvRow.Cells["hrAuthPass"].Value.ToString()
                        );
                        if (result) { new Alert("Admission Account Added", Alert.AlertType.SUCCESS); }
                    }
                }
                else
                {
                    //update code
                    new Alert("Updated", Alert.AlertType.INFO, 2);
                    databaseHelper.UpdateUser(Common.DepartmentType.HR,
                        Convert.ToInt32(dgvRow.Cells["hrDetId"].Value.ToString()),
                        dgvRow.Cells["hrDetName"].Value == DBNull.Value ? "" : dgvRow.Cells["hrDetName"].Value.ToString(),
                        dgvRow.Cells["hrDetGender"].Value == DBNull.Value ? "" : dgvRow.Cells["hrDetGender"].Value.ToString(),
                        dgvRow.Cells["hrDetAddress"].Value == DBNull.Value ? "" : dgvRow.Cells["hrDetAddress"].Value.ToString(),
                        dgvRow.Cells["hrDetStuPh"].Value == DBNull.Value ? "" : dgvRow.Cells["hrDetStuPh"].Value.ToString(),
                        null,
                        null,
                        null,
                        null,
                        null,
                        dgvRow.Cells["hrAuthUsername"].Value == DBNull.Value ? "" : dgvRow.Cells["hrAuthUsername"].Value.ToString(),
                        dgvRow.Cells["hrAuthPass"].Value == DBNull.Value ? "" : dgvRow.Cells["hrAuthPass"].Value.ToString(),
                        false
                        );
                }
            }
        }

        private void dgvAdminsDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvAdminsDetails.CurrentRow;
            if (dgvAdminsDetails.CurrentRow != null)
            {
                if (dgvRow.Cells["adminDetId"].Value == DBNull.Value)
                {
                    //insert code
                    if (dgvRow.Cells["adminDetName"].Value != DBNull.Value &&
                        dgvRow.Cells["adminDetGender"].Value != DBNull.Value &&
                        dgvRow.Cells["adminDetAddress"].Value != DBNull.Value &&
                        dgvRow.Cells["adminDetStuPh"].Value != DBNull.Value &&
                        dgvRow.Cells["adminsAuthUsername"].Value != DBNull.Value &&
                        dgvRow.Cells["adminAuthPass"].Value != DBNull.Value)
                    {
                        bool result = databaseHelper.RegisterUser(Common.DepartmentType.ADMIN,
                        dgvRow.Cells["adminDetName"].Value.ToString(),
                        dgvRow.Cells["adminDetGender"].Value.ToString(),
                        dgvRow.Cells["adminDetAddress"].Value.ToString(),
                        dgvRow.Cells["adminDetStuPh"].Value.ToString(),
                        null,
                        null,
                        null,
                        null,
                        null,
                        dgvRow.Cells["adminsAuthUsername"].Value.ToString(),
                        dgvRow.Cells["adminAuthPass"].Value.ToString()
                        );
                        if (result) { new Alert("Admin Account Added", Alert.AlertType.SUCCESS); }
                    }
                }
                else
                {
                    //update code
                    new Alert("Updated", Alert.AlertType.INFO, 2);
                    databaseHelper.UpdateUser(Common.DepartmentType.ADMIN,
                        Convert.ToInt32(dgvRow.Cells["adminDetId"].Value.ToString()),
                        dgvRow.Cells["adminDetName"].Value == DBNull.Value ? "" : dgvRow.Cells["adminDetName"].Value.ToString(),
                        dgvRow.Cells["adminDetGender"].Value == DBNull.Value ? "" : dgvRow.Cells["adminDetGender"].Value.ToString(),
                        dgvRow.Cells["adminDetAddress"].Value == DBNull.Value ? "" : dgvRow.Cells["adminDetAddress"].Value.ToString(),
                        dgvRow.Cells["adminDetStuPh"].Value == DBNull.Value ? "" : dgvRow.Cells["adminDetStuPh"].Value.ToString(),
                        null,
                        null,
                        null,
                        null,
                        null,
                        dgvRow.Cells["adminsAuthUsername"].Value == DBNull.Value ? "" : dgvRow.Cells["adminsAuthUsername"].Value.ToString(),
                        dgvRow.Cells["adminAuthPass"].Value == DBNull.Value ? "" : dgvRow.Cells["adminAuthPass"].Value.ToString(),
                        false
                        );
                }
            }
        }

        private void dgvTeacherDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvTeacherDetails.CurrentRow;
            if (dgvTeacherDetails.CurrentRow != null)
            {
                if (dgvRow.Cells["teacherDetId"].Value == DBNull.Value)
                {
                    //insert code
                    if (dgvRow.Cells["teacherDetName"].Value != DBNull.Value &&
                        dgvRow.Cells["teacherDetFname"].Value != DBNull.Value &&
                        dgvRow.Cells["teacherDetAge"].Value != DBNull.Value &&
                        dgvRow.Cells["teacherDetGender"].Value != DBNull.Value &&
                        dgvRow.Cells["teacherDetAddress"].Value != DBNull.Value &&
                        dgvRow.Cells["teacherDetPh"].Value != DBNull.Value &&
                        dgvRow.Cells["teacherDetEmail"].Value != DBNull.Value &&
                        dgvRow.Cells["teacherDetQualification"].Value != DBNull.Value &&
                        dgvRow.Cells["teacherDetSubject"].Value != DBNull.Value &&
                        dgvRow.Cells["teacherAuthUsername"].Value != DBNull.Value &&
                        dgvRow.Cells["teacherAuthPass"].Value != DBNull.Value)
                    {
                        bool result = databaseHelper.RegisterUser(Common.DepartmentType.TEACHER,
                        dgvRow.Cells["teacherDetName"].Value.ToString(),
                        dgvRow.Cells["teacherDetFname"].Value.ToString(),
                        dgvRow.Cells["teacherDetAge"].Value.ToString(),
                        dgvRow.Cells["teacherDetGender"].Value.ToString(),
                        dgvRow.Cells["teacherDetAddress"].Value.ToString(),
                        dgvRow.Cells["teacherDetPh"].Value.ToString(),
                        dgvRow.Cells["teacherDetEmail"].Value.ToString(),
                        dgvRow.Cells["teacherDetQualification"].Value.ToString(),
                        dgvRow.Cells["teacherDetSubject"].Value.ToString(),
                        dgvRow.Cells["teacherAuthUsername"].Value.ToString(),
                        dgvRow.Cells["teacherAuthPass"].Value.ToString()
                        );
                        if (result) { new Alert("Teacher Added", Alert.AlertType.SUCCESS); }
                        PopulateTeacherDGV();
                    }
                }
                else
                {
                    //update code
                    new Alert("Updated", Alert.AlertType.INFO, 2);
                    databaseHelper.UpdateUser(Common.DepartmentType.TEACHER,
                        Convert.ToInt32(dgvRow.Cells["teacherDetId"].Value.ToString()),
                        dgvRow.Cells["teacherDetName"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherDetName"].Value.ToString(),
                        dgvRow.Cells["teacherDetFname"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherDetFname"].Value.ToString(),
                        dgvRow.Cells["teacherDetAge"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherDetAge"].Value.ToString(),
                        dgvRow.Cells["teacherDetGender"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherDetGender"].Value.ToString(),
                        dgvRow.Cells["teacherDetAddress"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherDetAddress"].Value.ToString(),
                        dgvRow.Cells["teacherDetPh"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherDetPh"].Value.ToString(),
                        dgvRow.Cells["teacherDetEmail"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherDetEmail"].Value.ToString(),
                        dgvRow.Cells["teacherDetQualification"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherDetQualification"].Value.ToString(),
                        dgvRow.Cells["teacherDetSubject"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherDetSubject"].Value.ToString(),
                        dgvRow.Cells["teacherAuthUsername"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherAuthUsername"].Value.ToString(),
                        dgvRow.Cells["teacherAuthPass"].Value == DBNull.Value ? "" : dgvRow.Cells["teacherAuthPass"].Value.ToString(),
                        false
                        );
                }
            }
        }

        private void dgvAccDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvAccDetails.CurrentRow;
            if (dgvAccDetails.CurrentRow != null)
            {
                if (dgvRow.Cells["accDetId"].Value == DBNull.Value)
                {
                    //insert code
                    if (dgvRow.Cells["accDetName"].Value != DBNull.Value &&
                        dgvRow.Cells["accDetGender"].Value != DBNull.Value &&
                        dgvRow.Cells["accDetAddress"].Value != DBNull.Value &&
                        dgvRow.Cells["accDetStuPh"].Value != DBNull.Value &&
                        dgvRow.Cells["accAuthUsername"].Value != DBNull.Value &&
                        dgvRow.Cells["accAuthPass"].Value != DBNull.Value)
                    {
                        bool result = databaseHelper.RegisterUser(Common.DepartmentType.ACCOUNTS,
                        dgvRow.Cells["accDetName"].Value.ToString(),
                        dgvRow.Cells["accDetGender"].Value.ToString(),
                        dgvRow.Cells["accDetAddress"].Value.ToString(),
                        dgvRow.Cells["accDetStuPh"].Value.ToString(),
                        null,
                        null,
                        null,
                        null,
                        null,
                        dgvRow.Cells["accAuthUsername"].Value.ToString(),
                        dgvRow.Cells["accAuthPass"].Value.ToString()
                        );
                        if (result) { new Alert("Accountant Added", Alert.AlertType.SUCCESS); }
                    }
                }
                else
                {
                    //update code
                    new Alert("Updated", Alert.AlertType.INFO, 2);
                    databaseHelper.UpdateUser(Common.DepartmentType.ACCOUNTS,
                        Convert.ToInt32(dgvRow.Cells["accDetId"].Value.ToString()),
                        dgvRow.Cells["accDetName"].Value == DBNull.Value ? "" : dgvRow.Cells["accDetName"].Value.ToString(),
                        dgvRow.Cells["accDetGender"].Value == DBNull.Value ? "" : dgvRow.Cells["accDetGender"].Value.ToString(),
                        dgvRow.Cells["accDetAddress"].Value == DBNull.Value ? "" : dgvRow.Cells["accDetAddress"].Value.ToString(),
                        dgvRow.Cells["accDetStuPh"].Value == DBNull.Value ? "" : dgvRow.Cells["accDetStuPh"].Value.ToString(),
                        null,
                        null,
                        null,
                        null,
                        null,
                        dgvRow.Cells["accAuthUsername"].Value == DBNull.Value ? "" : dgvRow.Cells["accAuthUsername"].Value.ToString(),
                        dgvRow.Cells["accAuthPass"].Value == DBNull.Value ? "" : dgvRow.Cells["accAuthPass"].Value.ToString(),
                        false
                        );
                }
            }
        }

        private void DgvStdDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvStdDetails.CurrentRow;
            if (dgvStdDetails.CurrentRow != null) {
                if (dgvRow.Cells["stuDetId"].Value == DBNull.Value)
                {
                    //insert code
                    if(dgvRow.Cells["stuDetName"].Value != DBNull.Value &&
                        dgvRow.Cells["stuDetFname"].Value != DBNull.Value &&
                        dgvRow.Cells["stuDetAge"].Value != DBNull.Value &&
                        dgvRow.Cells["stuDetGender"].Value != DBNull.Value &&
                        dgvRow.Cells["stuDetAddress"].Value != DBNull.Value &&
                        dgvRow.Cells["stuDetStuPh"].Value != DBNull.Value &&
                        dgvRow.Cells["stuDetFatherPh"].Value != DBNull.Value &&
                        dgvRow.Cells["stuDetLastClass"].Value != DBNull.Value &&
                        dgvRow.Cells["stuDetLastSchool"].Value != DBNull.Value &&
                        dgvRow.Cells["stuAuthUsername"].Value != DBNull.Value &&
                        dgvRow.Cells["stuAuthPass"].Value != DBNull.Value)
                    {
                        bool result = databaseHelper.RegisterUser(Common.DepartmentType.STUDENT,
                        dgvRow.Cells["stuDetName"].Value.ToString(),
                        dgvRow.Cells["stuDetFname"].Value.ToString(),
                        dgvRow.Cells["stuDetAge"].Value.ToString(),
                        dgvRow.Cells["stuDetGender"].Value.ToString(),
                        dgvRow.Cells["stuDetAddress"].Value.ToString(),
                        dgvRow.Cells["stuDetStuPh"].Value.ToString(),
                        dgvRow.Cells["stuDetFatherPh"].Value.ToString(),
                        dgvRow.Cells["stuDetLastClass"].Value.ToString(),
                        dgvRow.Cells["stuDetLastSchool"].Value.ToString(),
                        dgvRow.Cells["stuAuthUsername"].Value.ToString(),
                        dgvRow.Cells["stuAuthPass"].Value.ToString()
                        );

                        if (result) {
                            new Alert("Student Added", Alert.AlertType.SUCCESS);
                            DgvStdDetLoadHelper();
                        }
                    }
                }
                else
                {
                    //update code
                    new Alert("Updated", Alert.AlertType.INFO,2);
                    databaseHelper.UpdateUser(Common.DepartmentType.STUDENT,
                        Convert.ToInt32(dgvRow.Cells["stuDetId"].Value.ToString()),
                        dgvRow.Cells["stuDetName"].Value == DBNull.Value ? "" : dgvRow.Cells["stuDetName"].Value.ToString(),
                        dgvRow.Cells["stuDetFname"].Value == DBNull.Value ? "" : dgvRow.Cells["stuDetFname"].Value.ToString(),
                        dgvRow.Cells["stuDetAge"].Value == DBNull.Value ? "" : dgvRow.Cells["stuDetAge"].Value.ToString(),
                        dgvRow.Cells["stuDetGender"].Value == DBNull.Value ? "" : dgvRow.Cells["stuDetGender"].Value.ToString(),
                        dgvRow.Cells["stuDetAddress"].Value == DBNull.Value ? "" : dgvRow.Cells["stuDetAddress"].Value.ToString(),
                        dgvRow.Cells["stuDetStuPh"].Value == DBNull.Value ? "" : dgvRow.Cells["stuDetStuPh"].Value.ToString(),
                        dgvRow.Cells["stuDetFatherPh"].Value == DBNull.Value ? "" : dgvRow.Cells["stuDetFatherPh"].Value.ToString(),
                        dgvRow.Cells["stuDetLastClass"].Value == DBNull.Value ? "" : dgvRow.Cells["stuDetLastClass"].Value.ToString(),
                        dgvRow.Cells["stuDetLastSchool"].Value == DBNull.Value ? "" : dgvRow.Cells["stuDetLastSchool"].Value.ToString(),
                        dgvRow.Cells["stuAuthUsername"].Value == DBNull.Value ? "" : dgvRow.Cells["stuAuthUsername"].Value.ToString(),
                        dgvRow.Cells["stuAuthPass"].Value == DBNull.Value ? "" : dgvRow.Cells["stuAuthPass"].Value.ToString(),
                        false
                        );
                }
            }
        }

        private void dgvHrDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvHrDetails.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress -= AllowNumbersOnly;
                e.Control.KeyPress += AllowNumbersOnly;
            }
            else
            {
                e.Control.KeyPress -= AllowNumbersOnly;
            }
        }

        private void dgvAccDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvAccDetails.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress -= AllowNumbersOnly;
                e.Control.KeyPress += AllowNumbersOnly;
            }
            else
            {
                e.Control.KeyPress -= AllowNumbersOnly;
            }
        }

        private void dgvAdminsDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvAdminsDetails.CurrentCell.ColumnIndex == 4)
            {
                e.Control.KeyPress -= AllowNumbersOnly;
                e.Control.KeyPress += AllowNumbersOnly;
            }
            else
            {
                e.Control.KeyPress -= AllowNumbersOnly;
            }
        }

        private void DgvStdDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvStdDetails.CurrentCell.ColumnIndex == 3 ||
                dgvStdDetails.CurrentCell.ColumnIndex == 6 ||
                dgvStdDetails.CurrentCell.ColumnIndex == 7 ||
                dgvStdDetails.CurrentCell.ColumnIndex == 8)
            {
                e.Control.KeyPress -= AllowNumbersOnly;
                e.Control.KeyPress += AllowNumbersOnly;
            }
            else
            {
                e.Control.KeyPress -= AllowNumbersOnly;
            }
        }

        private void dgvTeacherDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvTeacherDetails.CurrentCell.ColumnIndex == 3 ||
                dgvTeacherDetails.CurrentCell.ColumnIndex == 6)
            {
                e.Control.KeyPress -= AllowNumbersOnly;
                e.Control.KeyPress += AllowNumbersOnly;
            }
            else
            {
                e.Control.KeyPress -= AllowNumbersOnly;
            }
        }

        private void AllowNumbersOnly(object sender, KeyPressEventArgs e) {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvHrDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvHrDetails.CurrentRow.Cells["hrDetId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are You Sure To Delete This Row?", "Data Grid View", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete the row
                    databaseHelper.DeleteUser(Common.DepartmentType.HR, Convert.ToInt32(dgvHrDetails.CurrentRow.Cells["hrDetId"].Value.ToString()), true);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgvAccDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvAccDetails.CurrentRow.Cells["accDetId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are You Sure To Delete This Row?", "Data Grid View", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete the row
                    databaseHelper.DeleteUser(Common.DepartmentType.ACCOUNTS, Convert.ToInt32(dgvAccDetails.CurrentRow.Cells["accDetId"].Value.ToString()), true);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgvAdminsDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvAdminsDetails.CurrentRow.Cells["adminDetId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are You Sure To Delete This Row?", "Data Grid View", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete the row
                    databaseHelper.DeleteUser(Common.DepartmentType.ADMIN, Convert.ToInt32(dgvAdminsDetails.CurrentRow.Cells["adminDetId"].Value.ToString()), true);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgvTeacherDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvTeacherDetails.CurrentRow.Cells["teacherDetId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are You Sure To Delete This Row?", "Data Grid View", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete the row
                    databaseHelper.DeleteUser(Common.DepartmentType.TEACHER, Convert.ToInt32(dgvTeacherDetails.CurrentRow.Cells["teacherDetId"].Value.ToString()), true);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DgvStdDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if(dgvStdDetails.CurrentRow.Cells["stuDetId"].Value != DBNull.Value)
            {
                if(MessageBox.Show("Are You Sure To Delete This Row?","Data Grid View",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete the row
                    databaseHelper.DeleteUser(Common.DepartmentType.STUDENT, Convert.ToInt32(dgvStdDetails.CurrentRow.Cells["stuDetId"].Value.ToString()), true);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnShowStdDetail_Click(object sender, EventArgs e)
        {
            showPanel(flpStdDetails);
            LoadFLPStdDetails();
        }

        private void BtnShowTeacherDetail_Click(object sender, EventArgs e)
        {
            showPanel(flpTeacherDetail);
            LoadFLPTeacherDetails();
        }

        private void BtnAccDetails_Click(object sender, EventArgs e)
        {
            showPanel(flpAccDetails);
            LoadFLPAccDetails();
        }

        private void BtnHrDetails_Click(object sender, EventArgs e)
        {
            showPanel(flpHrDetails);
            LoadFLPHrDetails();
        }

        private void BtnAdminDetails_Click(object sender, EventArgs e)
        {
            showPanel(flpAdminsDetails);
            LoadFLPAdminDetails();
        }

        private void BtnAssignClassToStd_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvStdDetails.CurrentRow;
            if (dgvStdDetails.CurrentRow != null)
            {
                string id = dgvRow.Cells["stuDetId"].Value.ToString();
                string name = dgvRow.Cells["stuDetName"].Value.ToString();
                new AssignUpgradeClasses(id, name)
                {
                    Visible = false
                }.ShowDialog();
            }
            else {
                new Alert("Select a student to assign class", Alert.AlertType.WARNING);
            }
        }

        private void BtnAssignStdToTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvTeacherDetails.CurrentRow.Cells["teacherDetId"].Value.ToString());
                string name = dgvTeacherDetails.CurrentRow.Cells["teacherDetName"].Value.ToString();
                new AssignUpgradeClasses(id, name)
                {
                    Visible = false
                }.ShowDialog();
            }
            catch (Exception)
            {
                new Alert("Select a row first", Alert.AlertType.WARNING);
            }
            
        }

        private void BtnShowClsSecSub_Click(object sender, EventArgs e)
        {
            showPanel(flpSubClassSec);
            LoadFLPSubClassSec();
        }

        private void DgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClass.CurrentRow != null)
            {
                if (dgvClass.CurrentRow.Cells["classId"].Value != DBNull.Value) {
                    string value = dgvClass.CurrentRow.Cells["classId"].Value.ToString();
                    PopulateSecDGV(Convert.ToInt32(value));
                    PopulateSubDGV(Convert.ToInt32(value));
                    dgvSection.Visible = true;
                    dgvSubject.Visible = true;
                    PopulateTextBoxFees();
                    //change headings
                    string className = dgvClass.CurrentRow.Cells["className"].Value.ToString();
                    lblSubDgv.Text = "Subject (" + className + ")";
                    lblSecDgv.Text = "Section (" + className + ")";
                }
                else
                {
                    lblSubDgv.Text = "Subject";
                    lblSecDgv.Text = "Section";
                    dgvSection.Visible = false;
                    dgvSubject.Visible = false;
                }
            }
        }

        private void DgvClass_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvClass.CurrentRow;
            if (dgvClass.CurrentRow != null)
            {
                if (dgvRow.Cells["classId"].Value == DBNull.Value)
                {
                    //insert code
                    if (dgvRow.Cells["className"].Value != DBNull.Value) {
                        bool result = databaseHelper.AddClassName(dgvRow.Cells["className"].Value.ToString());
                        if (result) { new Alert("Class Added", Alert.AlertType.SUCCESS); }
                    }
                    PopulateClassDGV();
                }
                else
                {
                    //update code
                    if (dgvRow.Cells["className"].Value != DBNull.Value)
                    {
                        databaseHelper.UpdateClassName(
                            Convert.ToInt32(dgvRow.Cells["classId"].Value.ToString()),
                            dgvRow.Cells["className"].Value.ToString());
                        
                        //change headings
                        string className = dgvClass.CurrentRow.Cells["className"].Value.ToString();
                        lblSubDgv.Text = "Subject (" + className + ")";
                        lblSecDgv.Text = "Section (" + className + ")";

                        new Alert("Updated", Alert.AlertType.INFO, 2);
                    }
                }
            }
        }

        private void DgvClass_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvClass.CurrentRow.Cells["classId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are You Sure To Delete This Row?", "Data Grid View", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete the row
                    databaseHelper.DeleteClassName(Convert.ToInt32(dgvClass.CurrentRow.Cells["classId"].Value.ToString()));
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DgvSection_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvSection.CurrentRow;
            DataGridViewRow dgvRowCls = dgvClass.CurrentRow;
            if (dgvRow != null && dgvRowCls != null)
            {
                if (dgvRow.Cells["secId"].Value == DBNull.Value)
                {
                    //insert code
                    if (dgvRow.Cells["secName"].Value != DBNull.Value && dgvRowCls.Cells["classId"].Value != DBNull.Value)
                    {
                        bool result = databaseHelper.AddSectionName(Convert.ToInt32(dgvRowCls.Cells["classId"].Value.ToString()), dgvRow.Cells["secName"].Value.ToString());
                        if (result) { new Alert("Section Added", Alert.AlertType.SUCCESS); }
                    }
                    PopulateSecDGV(Convert.ToInt32(dgvRowCls.Cells["classId"].Value.ToString()));
                }
                else
                {
                    //update code
                    if (dgvRow.Cells["secName"].Value != DBNull.Value && dgvRowCls.Cells["classId"].Value != DBNull.Value)
                    {
                        databaseHelper.UpdateSectionName(
                            Convert.ToInt32(dgvRow.Cells["secId"].Value.ToString()),
                            dgvRow.Cells["secName"].Value.ToString());

                        new Alert("Updated", Alert.AlertType.INFO, 2);
                    }
                }
            }
        }

        private void DgvSection_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvSection.CurrentRow.Cells["secId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are You Sure To Delete This Row?", "Data Grid View", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete the row
                    databaseHelper.DeleteSectionName(Convert.ToInt32(dgvSection.CurrentRow.Cells["secId"].Value.ToString()));
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void DgvSubject_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvSubject.CurrentRow;
            DataGridViewRow dgvRowSub = dgvClass.CurrentRow;
            if (dgvRow != null && dgvRowSub != null)
            {
                if (dgvRow.Cells["clsBookId"].Value == DBNull.Value)
                {
                    //insert code
                    if (dgvRow.Cells["clsBookName"].Value != DBNull.Value && dgvRowSub.Cells["classId"].Value != DBNull.Value)
                    {
                        bool result = databaseHelper.AddSubjectName(Convert.ToInt32(dgvRowSub.Cells["classId"].Value.ToString()), dgvRow.Cells["clsBookName"].Value.ToString());
                        if (result) { new Alert("Book Added", Alert.AlertType.SUCCESS); }
                    }
                    PopulateSubDGV(Convert.ToInt32(dgvRowSub.Cells["classId"].Value.ToString()));
                }
                else
                {
                    //update code
                    if (dgvRow.Cells["clsBookName"].Value != DBNull.Value && dgvRowSub.Cells["classId"].Value != DBNull.Value)
                    {
                        databaseHelper.UpdateSubjectName(
                            Convert.ToInt32(dgvRow.Cells["clsBookId"].Value.ToString()),
                            dgvRow.Cells["clsBookName"].Value.ToString());

                        new Alert("Updated", Alert.AlertType.INFO, 2);
                    }
                }
            }
        }

        private void DgvSubject_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (dgvSubject.CurrentRow.Cells["clsBookId"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are You Sure To Delete This Row?", "Data Grid View", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //delete the row
                    databaseHelper.DeleteSubjectName(Convert.ToInt32(dgvSubject.CurrentRow.Cells["clsBookId"].Value.ToString()));
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ComboBoxSelectClassForTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt32(ComboBoxSelectClassForTeacher.SelectedValue.ToString());
                PopulateCBSections(key);
                DgvStdDetLoadHelper();
            }
            catch (Exception) { }
        }

        private void ComboBoxSelectSectionForTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            DgvStdDetLoadHelper();
        }

        private void PopulateCBSections(int cls)
        {
            DataTable tbl;
            if(departmentType == Common.DepartmentType.TEACHER)
            {
                string teacherId = Common.LOGINFK.ToString();
                tbl = databaseHelper.GetSectionsTBL(Convert.ToInt32(teacherId), cls);
            }
            else
            {
                tbl = databaseHelper.GetSectionsTBL(cls);
            }

            if (tbl.Rows.Count > 0)
            {
                ComboBoxSelectSectionForTeacher.DataSource = tbl;
                ComboBoxSelectSectionForTeacher.DisplayMember = "secName";
                ComboBoxSelectSectionForTeacher.ValueMember = "secId";
            }
            else
            {
                List<string> list = new List<string>();
                list.Add("--No Sec--");
                ComboBoxSelectSectionForTeacher.DataSource = list;
                new Alert("Add sections in this class first", Alert.AlertType.WARNING, 3);
            }
        }

        private void PopulateCBClasses()
        {
            DataTable tbl;
            if(departmentType == Common.DepartmentType.TEACHER)
            {
                string teacherId = Common.LOGINFK.ToString();
                tbl = Common.RemoveDuplicateRows(databaseHelper.GetClassesListAssignedAgainstTeacherTBL(teacherId), "className");
            }
            else
            {
                tbl = databaseHelper.GetClassesTBL();
            }
            
            if (tbl.Rows.Count > 0)
            {
                ComboBoxSelectClassForTeacher.DataSource = tbl;
                ComboBoxSelectClassForTeacher.DisplayMember = "className";
                ComboBoxSelectClassForTeacher.ValueMember = "classId";
            }
            else
            {
                List<string> list = new List<string>();
                list.Add("--No Class--");
                ComboBoxSelectClassForTeacher.DataSource = list;
                new Alert("Add Class first", Alert.AlertType.WARNING, 3);
            }

        }

        private void BtnMarkAttendenceForTeacher_Click(object sender, EventArgs e)
        {
            string secId;
            string secName;
            string className;

            try
            {
                secId = ComboBoxSelectSectionForTeacher.SelectedValue.ToString();
                secName = ComboBoxSelectSectionForTeacher.SelectedText.ToString();
                className = ComboBoxSelectClassForTeacher.Text.ToString();
            }
            catch (Exception)
            {
                new Alert("Select Valid Class & Section First", Alert.AlertType.WARNING);
                return;
            }

            if (secId == "--No Sec--" || secId == "" || className == "--No Class--")
            {
                new Alert("Select Valid Class & Section First", Alert.AlertType.WARNING);
            }
            else
            {
                new MarkAttendence(Convert.ToInt32(secId), className, secName)
                {
                    Visible = false
                }.ShowDialog();
            }
        }

        private void TextBoxSearchStdDetail_TextChanged(object sender, EventArgs e)
        {
            DgvStdDetLoadHelper();
        }

        private void CheckBoxStdDetail_CheckedChanged(object sender, EventArgs e)
        {
            DgvStdDetLoadHelper();
        }

        public void DgvStdDetLoadHelper()
        {
            if (checkBoxStdDetail.Checked)
            {
                try
                {
                    int secId = Convert.ToInt32(ComboBoxSelectSectionForTeacher.SelectedValue.ToString());
                    DataTable tblStdDetIds = databaseHelper.GetTotalStdsOfSec(secId);
                    DataTable tblStd = new DataTable();
                    tblStd.Columns.Add("stuDetId");
                    tblStd.Columns.Add("stuDetName");
                    tblStd.Columns.Add("stuDetFname");
                    tblStd.Columns.Add("stuDetAge");
                    tblStd.Columns.Add("stuDetGender");
                    tblStd.Columns.Add("stuDetAddress");
                    tblStd.Columns.Add("stuDetStuPh");
                    tblStd.Columns.Add("stuDetFatherPh");
                    tblStd.Columns.Add("stuDetLastClass");
                    tblStd.Columns.Add("stuDetLastSchool");
                    tblStd.Columns.Add("stuAuthUsername");
                    tblStd.Columns.Add("stuAuthPass");
                    foreach (DataRow row in tblStdDetIds.Rows)
                    {
                        string stdDetId = row[1].ToString();
                        DataTable tblTemp = databaseHelper.GetSingleStdDetailsAndAuth(stdDetId);
                        DataRow dataRow = tblTemp.Rows[0];
                        tblStd.ImportRow(dataRow);
                    }
                    PopulateStdDGV(tblStd);
                }
                catch (Exception)
                {
                    new Alert("Select a valid section / class", Alert.AlertType.WARNING);
                    DataTable tblStd = new DataTable();
                    tblStd.Columns.Add("stuDetId");
                    tblStd.Columns.Add("stuDetName");
                    tblStd.Columns.Add("stuDetFname");
                    tblStd.Columns.Add("stuDetAge");
                    tblStd.Columns.Add("stuDetGender");
                    tblStd.Columns.Add("stuDetAddress");
                    tblStd.Columns.Add("stuDetStuPh");
                    tblStd.Columns.Add("stuDetFatherPh");
                    tblStd.Columns.Add("stuDetLastClass");
                    tblStd.Columns.Add("stuDetLastSchool");
                    tblStd.Columns.Add("stuAuthUsername");
                    tblStd.Columns.Add("stuAuthPass");
                    PopulateStdDGV(tblStd);
                }
            }
            else
            {
                PopulateStdDGV();
            }
        }

        private void BtnStdAttenMonthlyReport_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvStdDetails.CurrentRow;
            if (dgvStdDetails.CurrentRow != null)
            {
                string id = dgvRow.Cells["stuDetId"].Value.ToString();
                string name = dgvRow.Cells["stuDetName"].Value.ToString();
                new StdAttendencsMonthlyReport(Common.DepartmentType.STUDENT, id, name)
                {
                    Visible = false
                }.ShowDialog();
            }
            else
            {
                new Alert("Select a student to assign class", Alert.AlertType.WARNING);
            }
        }

        private void BtnMarkMyAttendence_Click(object sender, EventArgs e)
        {
            MarMykAttendence();
        }

        private void MarMykAttendence()
        {
            string date = DateTime.Now.ToString("dd/MMM/yyyy");
            if (btnMarkMyAttendence.Text == "Mark My Attendence")
            {
                databaseHelper.AddORUpdateAttendence(departmentType, Common.LOGINFK, date, "P");
                new Alert("Attendence Marked", Alert.AlertType.INFO);
                btnMarkMyAttendence.Text = "Delete My Attendence";
                btnMarkMyAttendence2.Text = "Delete My Attendence";
            }
            else
            {
                databaseHelper.AddORUpdateAttendence(departmentType, Common.LOGINFK, date, "A");
                new Alert("Attendence Deleted", Alert.AlertType.WARNING);
                btnMarkMyAttendence.Text = "Mark My Attendence";
                btnMarkMyAttendence2.Text = "Mark My Attendence";
            }
        }

        private void BtnAttenMonthlyReportForStd_Click(object sender, EventArgs e)
        {
            new StdAttendencsMonthlyReport(departmentType, Common.LOGINFK.ToString(), Common.LOGINNAME) {
                Visible = false
            }.ShowDialog();
        }

        private void BtnDptDetails_Click(object sender, EventArgs e)
        {
            showPanel(flpDepDet);
            PopulateDptDetailsCount();
            if (departmentType == DepartmentType.TEACHER || departmentType == DepartmentType.ACCOUNTS) {
                btnShowTeacherDetail.Visible = false;
                btnAdminDetails.Visible = false;
                btnHrDetails.Visible = false;
                btnAccDetails.Visible = false;
            }
        }

        private void PopulateDptDetailsCount()
        {
            int students = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.STUDENT).Rows.Count;
            int teachers = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.TEACHER).Rows.Count;
            int accounts = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.ACCOUNTS).Rows.Count;
            int hrs = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.HR).Rows.Count;
            int admins = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.ADMIN).Rows.Count;
            btnShowStdDetail.Text = students.ToString();
            btnShowTeacherDetail.Text = teachers.ToString();
            btnAccDetails.Text = accounts.ToString();
            btnHrDetails.Text = hrs.ToString();
            btnAdminDetails.Text = admins.ToString();
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            new newPswd(departmentType)
            {
                Visible = false
            }.ShowDialog();
        }

        private void TeachSearchTB_TextChanged(object sender, EventArgs e)
        {
            PopulateTeacherDGV();
        }

        private void BtnLeftStd_Click(object sender, EventArgs e)
        {
            new StdLeavePassRecord()
            {
                Visible = false
            }.ShowDialog();
        }

        private void BtnExEmployeDet_Click(object sender, EventArgs e)
        {
            new ExEmployeDetails
            {
                Visible = false
            }.ShowDialog();
        }

        private void AccSearchTB_TextChanged(object sender, EventArgs e)
        {
            PopulateAccDGV();
        }

        private void AdminSearchTB_TextChanged(object sender, EventArgs e)
        {
            PopulateAdminDGV();
        }

        private void HrSearchTB_TextChanged(object sender, EventArgs e)
        {
            PopulateHrDGV();
        }

        private void BtnShiftStdToPass_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvStdDetails.CurrentRow;
            if (dgvStdDetails.CurrentRow != null)
            {
                string id = dgvRow.Cells["stuDetId"].Value.ToString();
                string name = dgvRow.Cells["stuDetName"].Value.ToString();
                new AddDataFormStdLeaveRecord(id, name, this)
                {
                    Visible = false
                }.ShowDialog();
            }
            else
            {
                new Alert("Select a student to Proceed", Alert.AlertType.INFO);
            }
        }

        private void BtnTeachAttMonthlyRep_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvTeacherDetails.CurrentRow;
            if (dgvTeacherDetails.CurrentRow != null)
            {
                string id = dgvRow.Cells["teacherDetId"].Value.ToString();
                string name = dgvRow.Cells["teacherDetName"].Value.ToString();
                new StdAttendencsMonthlyReport(Common.DepartmentType.TEACHER, id, name)
                {
                    Visible = false
                }.ShowDialog();
            }
            else
            {
                new Alert("Select a Teacher", Alert.AlertType.WARNING);
            }
        }

        private void BtnAccAttMonthyRep_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvAccDetails.CurrentRow;
            if (dgvAccDetails.CurrentRow != null)
            {
                string id = dgvRow.Cells["accDetId"].Value.ToString();
                string name = dgvRow.Cells["accDetName"].Value.ToString();
                new StdAttendencsMonthlyReport(Common.DepartmentType.ACCOUNTS, id, name)
                {
                    Visible = false
                }.ShowDialog();
            }
            else
            {
                new Alert("Select an Accountant", Alert.AlertType.WARNING);
            }
        }

        private void BtnAdminAttMonthlyRep_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvAdminsDetails.CurrentRow;
            if (dgvAdminsDetails.CurrentRow != null)
            {
                string id = dgvRow.Cells["adminDetId"].Value.ToString();
                string name = dgvRow.Cells["adminDetName"].Value.ToString();
                new StdAttendencsMonthlyReport(Common.DepartmentType.ADMIN, id, name)
                {
                    Visible = false
                }.ShowDialog();
            }
            else
            {
                new Alert("Select an Admin", Alert.AlertType.WARNING);
            }
        }

        private void BtnHrAttMonthlyRep_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvHrDetails.CurrentRow;
            if (dgvHrDetails.CurrentRow != null)
            {
                string id = dgvRow.Cells["hrDetId"].Value.ToString();
                string name = dgvRow.Cells["hrDetName"].Value.ToString();
                new StdAttendencsMonthlyReport(Common.DepartmentType.ADMIN, id, name)
                {
                    Visible = false
                }.ShowDialog();
            }
            else
            {
                new Alert("Select an Admin", Alert.AlertType.WARNING);
            }
        }

        private void BtnExEmpHR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Retire This Employe? This process can't be reverse.", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewRow dgvRow = dgvHrDetails.CurrentRow;
                if (dgvHrDetails.CurrentRow != null)
                {
                    string id = dgvRow.Cells["hrDetId"].Value.ToString();
                    string name = dgvRow.Cells["hrDetName"].Value.ToString();
                    string gender = dgvRow.Cells["hrDetGender"].Value.ToString();
                    bool res = databaseHelper.AddExEmpDetTBL(id, name, gender, "Admission", DateTime.Now.ToString("dd/MMM/yyyy"));
                    if (res)
                    {
                        new Alert("Employee shifted to Retired List", Alert.AlertType.SUCCESS);
                    }
                    databaseHelper.DeleteAuth(Common.DepartmentType.HR,id);
                    PopulateHrDGV();
                }
                else
                {
                    new Alert("Select a HR", Alert.AlertType.WARNING);
                }
            }
            else {
                 new Alert("Ok No Problem", Alert.AlertType.INFO);
            }

           
        }

        private void BtnExEmpAdmin_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are You Sure To Retire This Employe? This process can't be reverse.", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewRow dgvRow = dgvAdminsDetails.CurrentRow;
                if (dgvAdminsDetails.CurrentRow != null)
                {
                    string id = dgvRow.Cells["adminDetId"].Value.ToString();
                    string name = dgvRow.Cells["adminDetName"].Value.ToString();
                    string gender = dgvRow.Cells["adminDetGender"].Value.ToString();
                    bool res = databaseHelper.AddExEmpDetTBL(id, name, gender, "Admin", DateTime.Now.ToString("dd/MMM/yyyy"));
                    if (res)
                    {
                        new Alert("Employee shifted to Retired List", Alert.AlertType.SUCCESS);
                    }
                    databaseHelper.DeleteAuth(Common.DepartmentType.ADMIN, id);
                    PopulateAdminDGV();
                }
                else
                {
                    new Alert("Select an Admin", Alert.AlertType.WARNING);
                }
            }
            else
            {
                new Alert("Ok No Problem", Alert.AlertType.INFO);
            }


        }

        private void BtnExEmpAcc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Retire This Employe? This process can't be reverse.", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataGridViewRow dgvRow = dgvAccDetails.CurrentRow;
                if (dgvAccDetails.CurrentRow != null)
                {
                    string id = dgvRow.Cells["accDetId"].Value.ToString();
                    string name = dgvRow.Cells["accDetName"].Value.ToString();
                    string gender = dgvRow.Cells["accDetGender"].Value.ToString();
                    bool res = databaseHelper.AddExEmpDetTBL(id, name, gender, "Accountant", DateTime.Now.ToString("dd/MMM/yyyy"));
                    if (res)
                    {
                        new Alert("Employee shifted to Retired List",Alert.AlertType.SUCCESS);
                    }
                    databaseHelper.DeleteAuth(Common.DepartmentType.ACCOUNTS, id);
                    PopulateAccDGV();
                }
                else
                {
                    new Alert("Select an Accountant", Alert.AlertType.WARNING);
                }
            }
            else
            {
                new Alert("Ok No Problem", Alert.AlertType.INFO);
            }

        }

        private void BtnExEmp_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure To Retire This Employe? This process can't be reverse.", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                DataGridViewRow dgvRow = dgvTeacherDetails.CurrentRow;
                if (dgvTeacherDetails.CurrentRow != null)
                {
                    string id = dgvRow.Cells["teacherDetId"].Value.ToString();
                    string name = dgvRow.Cells["teacherDetName"].Value.ToString();
                    string gender = dgvRow.Cells["teacherDetGender"].Value.ToString();
                    bool res = databaseHelper.AddExEmpDetTBL(id, name, gender, "Teacher", DateTime.Now.ToString("dd/MMM/yyyy"));
                    if (res)
                    {
                        new Alert("Employee shifted to Retired List", Alert.AlertType.SUCCESS);
                    }
                    databaseHelper.DeleteAuth(Common.DepartmentType.TEACHER, id);
                    PopulateTeacherDGV();
                }
                else
                {
                    new Alert("Select a Teacher", Alert.AlertType.WARNING);
                }
            }
            else
            {
                new Alert("Ok No Problem", Alert.AlertType.INFO);
            }
        }

        private void BtnStdFeeReport_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvStdDetails.CurrentRow;
            if (dgvStdDetails.CurrentRow != null)
            {
                string id = dgvRow.Cells["stuDetId"].Value.ToString();
                string name = dgvRow.Cells["stuDetName"].Value.ToString();
                new StdIdvFee(id, name)
                {
                    Visible = false
                }.ShowDialog();
            }
            else
            {
                new Alert("Select a student to Proceed", Alert.AlertType.INFO);
            }
        }

        private void BtnShowFeesReport_Click(object sender, EventArgs e)
        {
            new StdClassWiseFeesReport()
            {
                Visible = false
            }.ShowDialog();
        }

        private void BtnShowAttenClassReport_Click(object sender, EventArgs e)
        {
            new AttendenceClassWiseReport()
            {
                Visible = false
            }.ShowDialog();
        }
        private void BtnExpenditure_Click(object sender, EventArgs e)
        {
            new ExpendituresForm()
            {
                Visible = false
            }.ShowDialog();
        }

        private void BtnAssignClassToStd_MouseEnter(object sender, EventArgs e)
        {
            btnAssignClassToStd.FlatAppearance.BorderSize = 3;
            btnAssignClassToStd.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnAssignClassToStd_MouseLeave(object sender, EventArgs e)
        {
            btnAssignClassToStd.FlatAppearance.BorderSize = 3;
            btnAssignClassToStd.FlatAppearance.BorderColor = Color.FromArgb(204, 61, 0);
        }

        private void BtnMarkAttendenceForTeacher_MouseEnter(object sender, EventArgs e)
        {
            btnMarkAttendenceForTeacher.FlatAppearance.BorderSize = 3;
            btnMarkAttendenceForTeacher.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnMarkAttendenceForTeacher_MouseLeave(object sender, EventArgs e)
        {
            btnMarkAttendenceForTeacher.FlatAppearance.BorderSize = 3;
            btnMarkAttendenceForTeacher.FlatAppearance.BorderColor = Color.FromArgb(76, 9, 130);
        }

        private void BtnStdAttenMonthlyReport_MouseEnter(object sender, EventArgs e)
        {

            btnStdAttenMonthlyReport.FlatAppearance.BorderSize = 3;
            btnStdAttenMonthlyReport.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnStdAttenMonthlyReport_MouseLeave(object sender, EventArgs e)
        {
            btnStdAttenMonthlyReport.FlatAppearance.BorderSize = 3;
            btnStdAttenMonthlyReport.FlatAppearance.BorderColor = Color.FromArgb(105, 3, 76);
        }

        private void BtnStdFeeReport_MouseEnter(object sender, EventArgs e)
        {
            btnStdFeeReport.FlatAppearance.BorderSize = 3;
            btnStdFeeReport.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnStdFeeReport_MouseLeave(object sender, EventArgs e)
        {
            btnStdFeeReport.FlatAppearance.BorderSize = 3;
            btnStdFeeReport.FlatAppearance.BorderColor = Color.FromArgb(5, 150, 19);
        }

        private void BtnShiftStdToPass_MouseEnter(object sender, EventArgs e)
        {
            btnShiftStdToPass.FlatAppearance.BorderSize = 3;
            btnShiftStdToPass.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnShiftStdToPass_MouseLeave(object sender, EventArgs e)
        {
            btnShiftStdToPass.FlatAppearance.BorderSize = 3;
            btnShiftStdToPass.FlatAppearance.BorderColor = Color.FromArgb(161, 8, 16);
        }

        private void BtnTeachAttMonthlyRep_MouseEnter(object sender, EventArgs e)
        {
            btnTeachAttMonthlyRep.FlatAppearance.BorderSize = 3;
            btnTeachAttMonthlyRep.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnTeachAttMonthlyRep_MouseLeave(object sender, EventArgs e)
        {
            btnTeachAttMonthlyRep.FlatAppearance.BorderSize = 3;
            btnTeachAttMonthlyRep.FlatAppearance.BorderColor = Color.FromArgb(5, 87, 30);
        }

        private void BtnAssignSecToTeacher_MouseEnter(object sender, EventArgs e)
        {
            btnAssignSecToTeacher.FlatAppearance.BorderSize = 3;
            btnAssignSecToTeacher.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnAssignSecToTeacher_MouseLeave(object sender, EventArgs e)
        {
            btnAssignSecToTeacher.FlatAppearance.BorderSize = 3;
            btnAssignSecToTeacher.FlatAppearance.BorderColor = Color.FromArgb(89, 9, 158);
        }

        private void BtnExEmp_MouseEnter(object sender, EventArgs e)
        {
            btnExEmp.FlatAppearance.BorderSize = 3;
            btnExEmp.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnExEmp_MouseLeave(object sender, EventArgs e)
        {
            btnExEmp.FlatAppearance.BorderSize = 3;
            btnExEmp.FlatAppearance.BorderColor = Color.FromArgb(181, 4, 10);
        }

        private void BtnExEmpHR_MouseEnter(object sender, EventArgs e)
        {
            btnExEmpHR.FlatAppearance.BorderSize = 3;
            btnExEmpHR.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }
        private void BtnExEmpHR_MouseLeave(object sender, EventArgs e)
        {
            btnExEmpHR.FlatAppearance.BorderSize = 3;
            btnExEmpHR.FlatAppearance.BorderColor = Color.FromArgb(181, 4, 10);
        }

        private void BtnHrAttMonthlyRep_MouseEnter(object sender, EventArgs e)
        {
            btnHrAttMonthlyRep.FlatAppearance.BorderSize = 3;
            btnHrAttMonthlyRep.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnHrAttMonthlyRep_MouseLeave(object sender, EventArgs e)
        {
            btnHrAttMonthlyRep.FlatAppearance.BorderSize = 3;
            btnHrAttMonthlyRep.FlatAppearance.BorderColor = Color.FromArgb(76, 6, 161);
        }

        private void BtnAccAttMonthyRep_MouseEnter(object sender, EventArgs e)
        {
            btnAccAttMonthyRep.FlatAppearance.BorderSize = 3;
            btnAccAttMonthyRep.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnAccAttMonthyRep_MouseLeave(object sender, EventArgs e)
        {
            btnAccAttMonthyRep.FlatAppearance.BorderSize = 3;
            btnAccAttMonthyRep.FlatAppearance.BorderColor = Color.FromArgb(76, 6, 161);
        }

        private void BtnExEmpAcc_MouseEnter(object sender, EventArgs e)
        {
            btnExEmpAcc.FlatAppearance.BorderSize = 3;
            btnExEmpAcc.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnExEmpAcc_MouseLeave(object sender, EventArgs e)
        {
            btnExEmpAcc.FlatAppearance.BorderSize = 3;
            btnExEmpAcc.FlatAppearance.BorderColor = Color.FromArgb(176, 5, 20);
        }

        private void BtnExEmpAdmin_MouseEnter(object sender, EventArgs e)
        {
            btnExEmpAdmin.FlatAppearance.BorderSize = 3;
            btnExEmpAdmin.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnExEmpAdmin_MouseLeave(object sender, EventArgs e)
        {
            btnExEmpAdmin.FlatAppearance.BorderSize = 3;
            btnExEmpAdmin.FlatAppearance.BorderColor = Color.FromArgb(176, 5, 20);
        }

        private void BtnAdminAttMonthlyRep_MouseEnter(object sender, EventArgs e)
        {
            btnAdminAttMonthlyRep.FlatAppearance.BorderSize = 3;
            btnAdminAttMonthlyRep.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnAdminAttMonthlyRep_MouseLeave(object sender, EventArgs e)
        {
            btnAdminAttMonthlyRep.FlatAppearance.BorderSize = 3;
            btnAdminAttMonthlyRep.FlatAppearance.BorderColor = Color.FromArgb(77, 7, 163);
        }

        private void BtnExcelRecordAdmin_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Admins Details Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add("Name");
                tbl.Columns.Add("Sex");
                tbl.Columns.Add("Address");
                tbl.Columns.Add("Admin Ph #");
                tbl.Columns.Add("UserName");
                tbl.Columns.Add("Password");

                for (var i = 0; i < dgvAdminsDetails.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvAdminsDetails.Rows[i];
                    DataRow newRow = tbl.NewRow();
                    newRow[0] = row.Cells[1].Value;
                    newRow[1] = row.Cells[2].Value;
                    newRow[2] = row.Cells[3].Value;
                    newRow[3] = row.Cells[4].Value;
                    newRow[4] = row.Cells[5].Value;
                    newRow[5] = row.Cells[6].Value;
                    tbl.Rows.InsertAt(newRow, i);
                }

                tbl.ExportToExcel(path);
            }
        }

        private void BtnExcelHr_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Addmisions Details Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add("Name");
                tbl.Columns.Add("Sex");
                tbl.Columns.Add("Address");
                tbl.Columns.Add(" Ph #");
                tbl.Columns.Add("UserName");
                tbl.Columns.Add("Password");

                for (var i = 0; i < dgvHrDetails.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvHrDetails.Rows[i];
                    DataRow newRow = tbl.NewRow();
                    newRow[0] = row.Cells[1].Value;
                    newRow[1] = row.Cells[2].Value;
                    newRow[2] = row.Cells[3].Value;
                    newRow[3] = row.Cells[4].Value;
                    newRow[4] = row.Cells[5].Value;
                    newRow[5] = row.Cells[6].Value;
                    tbl.Rows.InsertAt(newRow, i);
                }

                tbl.ExportToExcel(path);
            }
        }

        private void BtnExcelAcc_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Accountants Details Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add("Name");
                tbl.Columns.Add("Sex");
                tbl.Columns.Add("Address");
                tbl.Columns.Add(" Ph #");
                tbl.Columns.Add("UserName");
                tbl.Columns.Add("Password");

                for (var i = 0; i < dgvAccDetails.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvAccDetails.Rows[i];
                    DataRow newRow = tbl.NewRow();
                    newRow[0] = row.Cells[1].Value;
                    newRow[1] = row.Cells[2].Value;
                    newRow[2] = row.Cells[3].Value;
                    newRow[3] = row.Cells[4].Value;
                    newRow[4] = row.Cells[5].Value;
                    newRow[5] = row.Cells[6].Value;
                    tbl.Rows.InsertAt(newRow, i);
                }

                tbl.ExportToExcel(path);
            }
        }

        private void BtnExcelTeacher_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Teacher Details Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add(" Name ");
                tbl.Columns.Add(" FName ");
                tbl.Columns.Add(" Age ");
                tbl.Columns.Add(" Sex ");
                tbl.Columns.Add("Address");
                tbl.Columns.Add(" Ph #");
                tbl.Columns.Add(" Email ");
                tbl.Columns.Add("Qualification");
                tbl.Columns.Add(" Subject ");
                tbl.Columns.Add("UserName");
                tbl.Columns.Add("Password");

                for (var i = 0; i < dgvTeacherDetails.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvTeacherDetails.Rows[i];
                    DataRow newRow = tbl.NewRow();
                    newRow[0] = row.Cells[1].Value;
                    newRow[1] = row.Cells[2].Value;
                    newRow[2] = row.Cells[3].Value;
                    newRow[3] = row.Cells[4].Value;
                    newRow[4] = row.Cells[5].Value;
                    newRow[5] = row.Cells[6].Value;
                    newRow[6] = row.Cells[7].Value;
                    newRow[7] = row.Cells[8].Value;
                    newRow[8] = row.Cells[9].Value;
                    newRow[9] = row.Cells[10].Value;
                    newRow[10] = row.Cells[11].Value;
                    tbl.Rows.InsertAt(newRow, i);
                }

                tbl.ExportToExcel(path);
            }
        }

        private void BtnExcelStd_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Student Details Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add(" Roll No ");
                tbl.Columns.Add(" Name ");
                tbl.Columns.Add(" FName ");
                tbl.Columns.Add(" Age ");
                tbl.Columns.Add(" Sex ");
                tbl.Columns.Add("Address");
                tbl.Columns.Add("Std Ph #");
                tbl.Columns.Add(" F.Ph # ");
                tbl.Columns.Add("Last Class");
                tbl.Columns.Add("Last School");
                tbl.Columns.Add("UserName");
                tbl.Columns.Add("Password");

                for (var i = 0; i < dgvStdDetails.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvStdDetails.Rows[i];
                    DataRow newRow = tbl.NewRow();
                    newRow[0] = row.Cells[0].Value;
                    newRow[1] = row.Cells[1].Value;
                    newRow[2] = row.Cells[2].Value;
                    newRow[3] = row.Cells[3].Value;
                    newRow[4] = row.Cells[4].Value;
                    newRow[5] = row.Cells[5].Value;
                    newRow[6] = row.Cells[6].Value;
                    newRow[7] = row.Cells[7].Value;
                    newRow[8] = row.Cells[8].Value;
                    newRow[9] = row.Cells[9].Value;
                    newRow[10] = row.Cells[10].Value;
                    newRow[11] = row.Cells[11].Value;
                    tbl.Rows.InsertAt(newRow, i);
                }

                tbl.ExportToExcel(path);
            }
        }

        private void BtnSaveFeesClsSec_Click(object sender, EventArgs e)
        {
            if(dgvClass.CurrentRow != null)
            {
                string clsId = dgvClass.CurrentRow.Cells[0].Value.ToString();
                string fees = textBoxFeesClsSec.Text;
                if (fees.IsNumberAndNotNull())
                {
                    bool res = databaseHelper.AddOrUpdateFeesAccToStdCls(clsId, Convert.ToInt32(fees));
                    if (res) { new Alert("Successfullay Saved",AlertType.SUCCESS); };
                }
                else
                {
                    new Alert("Fees Empty / Not A Number", AlertType.WARNING);
                }
            }
        }

        private void BtnBasicEmpSalary_Click(object sender, EventArgs e)
        {
            new SetBasicSalary() {
                Visible = false
            }.ShowDialog();
        }

        private void BtnEmpBonusPerEmp_Click(object sender, EventArgs e)
        {
            new IndividualSalary()
            {
                Visible = false
            }.ShowDialog();
        }

        private void BtnEmpMonthlySalary_Click(object sender, EventArgs e)
        {
            new EmpPaymentMonthlyRep()
            {
                Visible = false
            }.ShowDialog();
        }

        private void BtnShowEmployeSalary_Click(object sender, EventArgs e)
        {
            showPanel(flpEmpSalary);
        }

        private void LoadDashboardCharts()
        {
            //for current month/year
            string month = DateTime.Now.ToString("MMM/yyyy");
            string preMonth1 = DateTime.Now.AddMonths(-1).ToString("MMM/yyyy");
            string preMonth2 = DateTime.Now.AddMonths(-2).ToString("MMM/yyyy");
            string preMonth3 = DateTime.Now.AddMonths(-3).ToString("MMM/yyyy");
            string preMonth4 = DateTime.Now.AddMonths(-4).ToString("MMM/yyyy");
            string preMonth5 = DateTime.Now.AddMonths(-5).ToString("MMM/yyyy");
            string preMonth6 = DateTime.Now.AddMonths(-6).ToString("MMM/yyyy");
            string preMonth7 = DateTime.Now.AddMonths(-7).ToString("MMM/yyyy");
            string preMonth8 = DateTime.Now.AddMonths(-8).ToString("MMM/yyyy");
            string preMonth9 = DateTime.Now.AddMonths(-9).ToString("MMM/yyyy");
            string preMonth10 = DateTime.Now.AddMonths(-10).ToString("MMM/yyyy");
            string preMonth11 = DateTime.Now.AddMonths(-11).ToString("MMM/yyyy");

            //for pre year
            string monthPreY = DateTime.Now.AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY1 = DateTime.Now.AddMonths(-1).AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY2 = DateTime.Now.AddMonths(-2).AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY3 = DateTime.Now.AddMonths(-3).AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY4 = DateTime.Now.AddMonths(-4).AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY5 = DateTime.Now.AddMonths(-5).AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY6 = DateTime.Now.AddMonths(-6).AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY7 = DateTime.Now.AddMonths(-7).AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY8 = DateTime.Now.AddMonths(-8).AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY9 = DateTime.Now.AddMonths(-9).AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY10 = DateTime.Now.AddMonths(-10).AddYears(-1).ToString("MMM/yyyy");
            string preMonthPreY11 = DateTime.Now.AddMonths(-11).AddYears(-1).ToString("MMM/yyyy");

            //this year
            int[] profitLossThisMonth =  databaseHelper.CalculateProfitLoss(month);
            int[] profitLossPreMonth1 = databaseHelper.CalculateProfitLoss(preMonth1);
            int[] profitLossPreMonth2 = databaseHelper.CalculateProfitLoss(preMonth2);
            int[] profitLossPreMonth3 = databaseHelper.CalculateProfitLoss(preMonth3);
            int[] profitLossPreMonth4 = databaseHelper.CalculateProfitLoss(preMonth4);
            int[] profitLossPreMonth5 = databaseHelper.CalculateProfitLoss(preMonth5);
            int[] profitLossPreMonth6 = databaseHelper.CalculateProfitLoss(preMonth6);
            int[] profitLossPreMonth7 = databaseHelper.CalculateProfitLoss(preMonth7);
            int[] profitLossPreMonth8 = databaseHelper.CalculateProfitLoss(preMonth8);
            int[] profitLossPreMonth9 = databaseHelper.CalculateProfitLoss(preMonth9);
            int[] profitLossPreMonth10 = databaseHelper.CalculateProfitLoss(preMonth10);
            int[] profitLossPreMonth11 = databaseHelper.CalculateProfitLoss(preMonth11);


            //pre year
            int[] profitLossThisMonthPreY = databaseHelper.CalculateProfitLoss(monthPreY);
            int[] profitLossPreMonth1PreY = databaseHelper.CalculateProfitLoss(preMonthPreY1);
            int[] profitLossPreMonth2PreY = databaseHelper.CalculateProfitLoss(preMonthPreY2);
            int[] profitLossPreMonth3PreY = databaseHelper.CalculateProfitLoss(preMonthPreY3);
            int[] profitLossPreMonth4PreY = databaseHelper.CalculateProfitLoss(preMonthPreY4);
            int[] profitLossPreMonth5PreY = databaseHelper.CalculateProfitLoss(preMonthPreY5);
            int[] profitLossPreMonth6PreY = databaseHelper.CalculateProfitLoss(preMonthPreY6);
            int[] profitLossPreMonth7PreY = databaseHelper.CalculateProfitLoss(preMonthPreY7);
            int[] profitLossPreMonth8PreY = databaseHelper.CalculateProfitLoss(preMonthPreY8);
            int[] profitLossPreMonth9PreY = databaseHelper.CalculateProfitLoss(preMonthPreY9);
            int[] profitLossPreMonth10PreY = databaseHelper.CalculateProfitLoss(preMonthPreY10);
            int[] profitLossPreMonth11PreY = databaseHelper.CalculateProfitLoss(preMonthPreY11);

            lblProfit.Text = profitLossThisMonth[0] + " vs " + profitLossPreMonth1[0];
            lblLoss.Text = profitLossThisMonth[1] + " vs " + profitLossPreMonth1[1];

            //chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            //chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            //profit

            //this year
            chartProfit.Series[0].Points.Clear();

            chartProfit.Series[0].Points.Add(profitLossPreMonth11[0]);
            chartProfit.Series[0].Points[0].Color = Color.Green;
            chartProfit.Series[0].Points[0].AxisLabel = preMonth11;
            chartProfit.Series[0].Points[0].LegendText = preMonth11;
            chartProfit.Series[0].Points[0].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossPreMonth10[0]);
            chartProfit.Series[0].Points[1].Color = Color.Green;
            chartProfit.Series[0].Points[1].AxisLabel = preMonth10;
            chartProfit.Series[0].Points[1].LegendText = preMonth10;
            chartProfit.Series[0].Points[1].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossPreMonth9[0]);
            chartProfit.Series[0].Points[2].Color = Color.Green;
            chartProfit.Series[0].Points[2].AxisLabel = preMonth9;
            chartProfit.Series[0].Points[2].LegendText = preMonth9;
            chartProfit.Series[0].Points[2].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossPreMonth8[0]);
            chartProfit.Series[0].Points[3].Color = Color.Green;
            chartProfit.Series[0].Points[3].AxisLabel = preMonth8;
            chartProfit.Series[0].Points[3].LegendText = preMonth8;
            chartProfit.Series[0].Points[3].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossPreMonth7[0]);
            chartProfit.Series[0].Points[4].Color = Color.Green;
            chartProfit.Series[0].Points[4].AxisLabel = preMonth7;
            chartProfit.Series[0].Points[4].LegendText = preMonth7;
            chartProfit.Series[0].Points[4].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossPreMonth6[0]);
            chartProfit.Series[0].Points[5].Color = Color.Green;
            chartProfit.Series[0].Points[5].AxisLabel = preMonth6;
            chartProfit.Series[0].Points[5].LegendText = preMonth6;
            chartProfit.Series[0].Points[5].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossPreMonth5[0]);
            chartProfit.Series[0].Points[6].Color = Color.Green;
            chartProfit.Series[0].Points[6].AxisLabel = preMonth5;
            chartProfit.Series[0].Points[6].LegendText = preMonth5;
            chartProfit.Series[0].Points[6].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossPreMonth4[0]);
            chartProfit.Series[0].Points[7].Color = Color.Green;
            chartProfit.Series[0].Points[7].AxisLabel = preMonth4;
            chartProfit.Series[0].Points[7].LegendText = preMonth4;
            chartProfit.Series[0].Points[7].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossPreMonth3[0]);
            chartProfit.Series[0].Points[8].Color = Color.Green;
            chartProfit.Series[0].Points[8].AxisLabel = preMonth3;
            chartProfit.Series[0].Points[8].LegendText = preMonth3;
            chartProfit.Series[0].Points[8].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossPreMonth2[0]);
            chartProfit.Series[0].Points[9].Color = Color.Green;
            chartProfit.Series[0].Points[9].AxisLabel = preMonth2;
            chartProfit.Series[0].Points[9].LegendText = preMonth2;
            chartProfit.Series[0].Points[9].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossPreMonth1[0]);
            chartProfit.Series[0].Points[10].Color = Color.Green;
            chartProfit.Series[0].Points[10].AxisLabel = preMonth1;
            chartProfit.Series[0].Points[10].LegendText = preMonth1;
            chartProfit.Series[0].Points[10].Label = " ";

            chartProfit.Series[0].Points.Add(profitLossThisMonth[0]);
            chartProfit.Series[0].Points[11].Color = Color.Green;
            chartProfit.Series[0].Points[11].AxisLabel = month;
            chartProfit.Series[0].Points[11].LegendText = month;
            chartProfit.Series[0].Points[11].Label = " ";



            //pre year
            chartProfit.Series[1].Points.Clear();

            chartProfit.Series[1].Points.Add(profitLossPreMonth11PreY[0]);
            chartProfit.Series[1].Points[0].Color = Color.Red;
            chartProfit.Series[1].Points[0].AxisLabel = preMonthPreY11;
            chartProfit.Series[1].Points[0].LegendText = preMonthPreY11;
            chartProfit.Series[1].Points[0].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossPreMonth10PreY[0]);
            chartProfit.Series[1].Points[1].Color = Color.Red;
            chartProfit.Series[1].Points[1].AxisLabel = preMonthPreY10;
            chartProfit.Series[1].Points[1].LegendText = preMonthPreY10;
            chartProfit.Series[1].Points[1].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossPreMonth9PreY[0]);
            chartProfit.Series[1].Points[2].Color = Color.Red;
            chartProfit.Series[1].Points[2].AxisLabel = preMonthPreY9;
            chartProfit.Series[1].Points[2].LegendText = preMonthPreY9;
            chartProfit.Series[1].Points[2].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossPreMonth8PreY[0]);
            chartProfit.Series[1].Points[3].Color = Color.Red;
            chartProfit.Series[1].Points[3].AxisLabel = preMonthPreY8;
            chartProfit.Series[1].Points[3].LegendText = preMonthPreY8;
            chartProfit.Series[1].Points[3].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossPreMonth7PreY[0]);
            chartProfit.Series[1].Points[4].Color = Color.Red;
            chartProfit.Series[1].Points[4].AxisLabel = preMonthPreY7;
            chartProfit.Series[1].Points[4].LegendText = preMonthPreY7;
            chartProfit.Series[1].Points[4].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossPreMonth6PreY[0]);
            chartProfit.Series[1].Points[5].Color = Color.Red;
            chartProfit.Series[1].Points[5].AxisLabel = preMonthPreY6;
            chartProfit.Series[1].Points[5].LegendText = preMonthPreY6;
            chartProfit.Series[1].Points[5].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossPreMonth5PreY[0]);
            chartProfit.Series[1].Points[6].Color = Color.Red;
            chartProfit.Series[1].Points[6].AxisLabel = preMonthPreY5;
            chartProfit.Series[1].Points[6].LegendText = preMonthPreY5;
            chartProfit.Series[1].Points[6].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossPreMonth4PreY[0]);
            chartProfit.Series[1].Points[7].Color = Color.Red;
            chartProfit.Series[1].Points[7].AxisLabel = preMonthPreY4;
            chartProfit.Series[1].Points[7].LegendText = preMonthPreY4;
            chartProfit.Series[1].Points[7].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossPreMonth3PreY[0]);
            chartProfit.Series[1].Points[8].Color = Color.Red;
            chartProfit.Series[1].Points[8].AxisLabel = preMonthPreY3;
            chartProfit.Series[1].Points[8].LegendText = preMonthPreY3;
            chartProfit.Series[1].Points[8].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossPreMonth2PreY[0]);
            chartProfit.Series[1].Points[9].Color = Color.Red;
            chartProfit.Series[1].Points[9].AxisLabel = preMonthPreY2;
            chartProfit.Series[1].Points[9].LegendText = preMonthPreY2;
            chartProfit.Series[1].Points[9].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossPreMonth1PreY[0]);
            chartProfit.Series[1].Points[10].Color = Color.Red;
            chartProfit.Series[1].Points[10].AxisLabel = preMonthPreY1;
            chartProfit.Series[1].Points[10].LegendText = preMonthPreY1;
            chartProfit.Series[1].Points[10].Label = " ";

            chartProfit.Series[1].Points.Add(profitLossThisMonthPreY[0]);
            chartProfit.Series[1].Points[11].Color = Color.Red;
            chartProfit.Series[1].Points[11].AxisLabel = monthPreY;
            chartProfit.Series[1].Points[11].LegendText = monthPreY;
            chartProfit.Series[1].Points[11].Label = " ";


            //Loss

            //this year
            chartLoss.Series[0].Points.Clear();

            chartLoss.Series[0].Points.Add(profitLossPreMonth11[1]);
            chartLoss.Series[0].Points[0].Color = Color.Green;
            chartLoss.Series[0].Points[0].AxisLabel = preMonth11;
            chartLoss.Series[0].Points[0].LegendText = preMonth11;
            chartLoss.Series[0].Points[0].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossPreMonth10[1]);
            chartLoss.Series[0].Points[1].Color = Color.Green;
            chartLoss.Series[0].Points[1].AxisLabel = preMonth10;
            chartLoss.Series[0].Points[1].LegendText = preMonth10;
            chartLoss.Series[0].Points[1].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossPreMonth9[1]);
            chartLoss.Series[0].Points[2].Color = Color.Green;
            chartLoss.Series[0].Points[2].AxisLabel = preMonth9;
            chartLoss.Series[0].Points[2].LegendText = preMonth9;
            chartLoss.Series[0].Points[2].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossPreMonth8[1]);
            chartLoss.Series[0].Points[3].Color = Color.Green;
            chartLoss.Series[0].Points[3].AxisLabel = preMonth8;
            chartLoss.Series[0].Points[3].LegendText = preMonth8;
            chartLoss.Series[0].Points[3].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossPreMonth7[1]);
            chartLoss.Series[0].Points[4].Color = Color.Green;
            chartLoss.Series[0].Points[4].AxisLabel = preMonth7;
            chartLoss.Series[0].Points[4].LegendText = preMonth7;
            chartLoss.Series[0].Points[4].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossPreMonth6[1]);
            chartLoss.Series[0].Points[5].Color = Color.Green;
            chartLoss.Series[0].Points[5].AxisLabel = preMonth6;
            chartLoss.Series[0].Points[5].LegendText = preMonth6;
            chartLoss.Series[0].Points[5].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossPreMonth5[1]);
            chartLoss.Series[0].Points[6].Color = Color.Green;
            chartLoss.Series[0].Points[6].AxisLabel = preMonth5;
            chartLoss.Series[0].Points[6].LegendText = preMonth5;
            chartLoss.Series[0].Points[6].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossPreMonth4[1]);
            chartLoss.Series[0].Points[7].Color = Color.Green;
            chartLoss.Series[0].Points[7].AxisLabel = preMonth4;
            chartLoss.Series[0].Points[7].LegendText = preMonth4;
            chartLoss.Series[0].Points[7].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossPreMonth3[1]);
            chartLoss.Series[0].Points[8].Color = Color.Green;
            chartLoss.Series[0].Points[8].AxisLabel = preMonth3;
            chartLoss.Series[0].Points[8].LegendText = preMonth3;
            chartLoss.Series[0].Points[8].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossPreMonth2[1]);
            chartLoss.Series[0].Points[9].Color = Color.Green;
            chartLoss.Series[0].Points[9].AxisLabel = preMonth2;
            chartLoss.Series[0].Points[9].LegendText = preMonth2;
            chartLoss.Series[0].Points[9].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossPreMonth1[1]);
            chartLoss.Series[0].Points[10].Color = Color.Green;
            chartLoss.Series[0].Points[10].AxisLabel = preMonth1;
            chartLoss.Series[0].Points[10].LegendText = preMonth1;
            chartLoss.Series[0].Points[10].Label = " ";

            chartLoss.Series[0].Points.Add(profitLossThisMonth[1]);
            chartLoss.Series[0].Points[11].Color = Color.Green;
            chartLoss.Series[0].Points[11].AxisLabel = month;
            chartLoss.Series[0].Points[11].LegendText = month;
            chartLoss.Series[0].Points[11].Label = " ";



            //pre year
            chartLoss.Series[1].Points.Clear();

            chartLoss.Series[1].Points.Add(profitLossPreMonth11PreY[1]);
            chartLoss.Series[1].Points[0].Color = Color.Red;
            chartLoss.Series[1].Points[0].AxisLabel = preMonthPreY11;
            chartLoss.Series[1].Points[0].LegendText = preMonthPreY11;
            chartLoss.Series[1].Points[0].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossPreMonth10PreY[1]);
            chartLoss.Series[1].Points[1].Color = Color.Red;
            chartLoss.Series[1].Points[1].AxisLabel = preMonthPreY10;
            chartLoss.Series[1].Points[1].LegendText = preMonthPreY10;
            chartLoss.Series[1].Points[1].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossPreMonth9PreY[1]);
            chartLoss.Series[1].Points[2].Color = Color.Red;
            chartLoss.Series[1].Points[2].AxisLabel = preMonthPreY9;
            chartLoss.Series[1].Points[2].LegendText = preMonthPreY9;
            chartLoss.Series[1].Points[2].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossPreMonth8PreY[1]);
            chartLoss.Series[1].Points[3].Color = Color.Red;
            chartLoss.Series[1].Points[3].AxisLabel = preMonthPreY8;
            chartLoss.Series[1].Points[3].LegendText = preMonthPreY8;
            chartLoss.Series[1].Points[3].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossPreMonth7PreY[1]);
            chartLoss.Series[1].Points[4].Color = Color.Red;
            chartLoss.Series[1].Points[4].AxisLabel = preMonthPreY7;
            chartLoss.Series[1].Points[4].LegendText = preMonthPreY7;
            chartLoss.Series[1].Points[4].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossPreMonth6PreY[1]);
            chartLoss.Series[1].Points[5].Color = Color.Red;
            chartLoss.Series[1].Points[5].AxisLabel = preMonthPreY6;
            chartLoss.Series[1].Points[5].LegendText = preMonthPreY6;
            chartLoss.Series[1].Points[5].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossPreMonth5PreY[1]);
            chartLoss.Series[1].Points[6].Color = Color.Red;
            chartLoss.Series[1].Points[6].AxisLabel = preMonthPreY5;
            chartLoss.Series[1].Points[6].LegendText = preMonthPreY5;
            chartLoss.Series[1].Points[6].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossPreMonth4PreY[1]);
            chartLoss.Series[1].Points[7].Color = Color.Red;
            chartLoss.Series[1].Points[7].AxisLabel = preMonthPreY4;
            chartLoss.Series[1].Points[7].LegendText = preMonthPreY4;
            chartLoss.Series[1].Points[7].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossPreMonth3PreY[1]);
            chartLoss.Series[1].Points[8].Color = Color.Red;
            chartLoss.Series[1].Points[8].AxisLabel = preMonthPreY3;
            chartLoss.Series[1].Points[8].LegendText = preMonthPreY3;
            chartLoss.Series[1].Points[8].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossPreMonth2PreY[1]);
            chartLoss.Series[1].Points[9].Color = Color.Red;
            chartLoss.Series[1].Points[9].AxisLabel = preMonthPreY2;
            chartLoss.Series[1].Points[9].LegendText = preMonthPreY2;
            chartLoss.Series[1].Points[9].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossPreMonth1PreY[1]);
            chartLoss.Series[1].Points[10].Color = Color.Red;
            chartLoss.Series[1].Points[10].AxisLabel = preMonthPreY1;
            chartLoss.Series[1].Points[10].LegendText = preMonthPreY1;
            chartLoss.Series[1].Points[10].Label = " ";

            chartLoss.Series[1].Points.Add(profitLossThisMonthPreY[1]);
            chartLoss.Series[1].Points[11].Color = Color.Red;
            chartLoss.Series[1].Points[11].AxisLabel = monthPreY;
            chartLoss.Series[1].Points[11].LegendText = monthPreY;
            chartLoss.Series[1].Points[11].Label = " ";
        }

        private void BtnDeepDetails_Click(object sender, EventArgs e)
        {
            new ProfitLoss()
            {
                Visible = false
            }.ShowDialog();
        }

        private void BtnPaySlipSettings_Click(object sender, EventArgs e)
        {
            new PaySlipSettings()
            {
                Visible = false
            }.ShowDialog();
        }

        private void BtnShowIndFeesForStdOnly_Click(object sender, EventArgs e)
        {
            new StdIdvFee(LOGINFK.ToString(), LOGINNAME,false)
            {
                Visible = false
            }.ShowDialog();
        }

        private void BtnShowChangePass2_Click(object sender, EventArgs e)
        {
            new newPswd(departmentType)
            {
                Visible = false
            }.ShowDialog();
        }

        private void BtnMarkMyAttendence2_Click(object sender, EventArgs e)
        {
            MarMykAttendence();
        }

        private void BtnRefreshData_Click(object sender, EventArgs e)
        {
            LoadDashboardCharts();
        }

        private void BtnDeepDetails2_Click(object sender, EventArgs e)
        {
            new ProfitLoss()
            {
                Visible = false
            }.ShowDialog();
        }
    }
}