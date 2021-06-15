using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SMS
{
    public partial class EmpPaymentMonthlyRep : Form
    {
        DatabaseHelper databaseHelper;
        BindingSource bs;

        public EmpPaymentMonthlyRep()
        {
            InitializeComponent();
            databaseHelper = new DatabaseHelper();
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

        private void EmpPaymentMonthlyRep_Load(object sender, EventArgs e)
        {
            cbSelectDept.SelectedIndex = 0;
            cbSelectSalaryStatus.SelectedIndex = 0;
            PopulateDgv();
        }

        private void PopulateDgv()
        {
            string search = textBoxSearch.Text;
            string month = dateTimePicker.Value.ToString("MMM/yyyy");
            string payStatus = cbSelectSalaryStatus.Text;

            int rowNum;
            DataTable tblEmpList;
            switch (cbSelectDept.Text)
            {
                case "Teacher":
                    rowNum = 3;
                    tblEmpList = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.TEACHER);
                    break;
                case "Admission":
                    rowNum = 2;
                    tblEmpList = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.HR);
                    break;
                case "Accounts":
                    rowNum = 0;
                    tblEmpList = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.ACCOUNTS);
                    break;
                case "Administrator":
                    rowNum = 1;
                    tblEmpList = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.ADMIN);
                    break;
                default:
                    rowNum = 0;
                    tblEmpList = new DataTable();
                    break;
            }

            DataTable tb = new DataTable();
            tb.Columns.Add("empSalaryId");
            tb.Columns.Add("empSalaryFKuserId");
            tb.Columns.Add("empSalaryName");
            tb.Columns.Add("empSalaryBonus");
            tb.Columns.Add("empSalaryIncentive");
            tb.Columns.Add("empSalaryGrossPay");
            tb.Columns.Add("empSalaryDeduction");
            tb.Columns.Add("empSalaryNetPay");
            tb.Columns.Add("empSalaryStatus");
            tb.Columns.Add("empSalaryDate");

            for (var i = 0; i < tblEmpList.Rows.Count; i++)
            {
                DataTable tblForBonus = databaseHelper.GetSaleryBonus(cbSelectDept.Text, tblEmpList.Rows[i][0].ToString());
                DataTable tblSaleryStatus = databaseHelper.GetEmpSalaryMonthly(tblEmpList.Rows[i][0].ToString(), cbSelectDept.Text, month);

                string status,paidDate;
                if(tblSaleryStatus.Rows.Count > 0)
                {
                    status = "Transferred";
                    paidDate = tblSaleryStatus.Rows[0][10].ToString();
                }
                else
                {
                    status = "Pending";
                    paidDate = "";
                }

                if (tblForBonus.Rows.Count > 0)
                {
                    DataRow row = tb.NewRow();
                    row[0] = "";
                    row[1] = tblEmpList.Rows[i][0].ToString();
                    row[2] = tblEmpList.Rows[i][1].ToString();
                    row[3] = tblForBonus.Rows[0][2];
                    row[4] = tblForBonus.Rows[0][5];
                    row[5] = tblForBonus.Rows[0][3];
                    row[6] = tblForBonus.Rows[0][4];
                    row[7] = tblForBonus.Rows[0][6];
                    row[8] = status;
                    row[9] = paidDate;
                    tb.Rows.InsertAt(row, i);

                }
                else
                {
                    DataRow row = tb.NewRow();

                    DataTable tblDefSal = databaseHelper.GetDefaultSalary();
                    if (tblDefSal.Rows.Count > 3)
                    {
                        row[0] = "";
                        row[1] = tblEmpList.Rows[i][0].ToString();
                        row[2] = tblEmpList.Rows[i][1].ToString();
                        row[3] = "0";
                        row[4] = tblDefSal.Rows[rowNum][2];
                        row[5] = tblDefSal.Rows[rowNum][1];
                        row[6] = tblDefSal.Rows[rowNum][3];
                        row[7] = Convert.ToInt32(tblDefSal.Rows[rowNum][1].ToString()) - Convert.ToInt32(tblDefSal.Rows[rowNum][3].ToString()) + Convert.ToInt32(tblDefSal.Rows[rowNum][2].ToString());
                        row[8] = status;
                        row[9] = paidDate;
                        tb.Rows.InsertAt(row, i);
                    }
                    else
                    {
                        row[0] = "";
                        row[1] = tblEmpList.Rows[i][0].ToString();
                        row[2] = tblEmpList.Rows[i][1];
                        row[3] = "0";
                        row[4] = "0";
                        row[5] = "0";
                        row[6] = "0";
                        row[7] = "0";
                        row[8] = status;
                        row[9] = paidDate;
                        tb.Rows.InsertAt(row, i);
                    }
                }
            }

            string filterQuery;
            if(payStatus == "Both")
            {
                if (search.Any(char.IsDigit))
                {
                    int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                    filterQuery = "empSalaryFKuserId = " + searchTermInt + " or empSalaryName like '" + search + "%' or empSalaryBonus like '" + search + "%' or empSalaryIncentive like '" + search + "%' or empSalaryGrossPay like '" + search + "%' or empSalaryDeduction like '" + search + "%' or empSalaryNetPay like '" + search + "%' or empSalaryDate like '%" + search + "%'";
                }
                else
                {
                    filterQuery = "empSalaryName like '" + search + "%' or empSalaryBonus like '" + search + "%' or empSalaryIncentive like '" + search + "%' or empSalaryGrossPay like '" + search + "%' or empSalaryDeduction like '" + search + "%' or empSalaryNetPay like '" + search + "%' or empSalaryDate like '%" + search + "%'";
                }
            }
            else
            {
                if(search == "")
                {
                    filterQuery = "empSalaryStatus = '" + payStatus + "'";
                }
                else if (search.Any(char.IsDigit))
                {
                    int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                    filterQuery = "empSalaryStatus like '%" + payStatus + "%' and empSalaryFKuserId = " + searchTermInt + " or empSalaryName like '" + search + "%' or empSalaryBonus like '" + search + "%' or empSalaryIncentive like '" + search + "%' or empSalaryGrossPay like '" + search + "%' or empSalaryDeduction like '" + search + "%' or empSalaryNetPay like '" + search + "%' or empSalaryDate like '%" + search + "%'";
                }
                else
                {
                    filterQuery = "empSalaryStatus like '%" + payStatus + "%' and empSalaryName like '" + search + "%' or empSalaryBonus like '" + search + "%' or empSalaryIncentive like '" + search + "%' or empSalaryGrossPay like '" + search + "%' or empSalaryDeduction like '" + search + "%' or empSalaryNetPay like '" + search + "%' or empSalaryDate like '%" + search + "%'";
                }
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tb;
            bs.Filter = filterQuery;
            dgvMonthlySalery.DataSource = bs;
        }

        private void CbSelectDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void BtnSetStatus_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvMonthlySalery.CurrentRow;
            if (dgvMonthlySalery.CurrentRow != null)
            {
                string empId = dgvRow.Cells[1].Value.ToString();
                string empName = dgvRow.Cells[2].Value.ToString();
                string empDept = cbSelectDept.Text;
                string bonus = dgvRow.Cells[3].Value.ToString();
                string empIncentive = dgvRow.Cells[4].Value.ToString();
                string empGrossPay = dgvRow.Cells[5].Value.ToString();
                string empDeduction = dgvRow.Cells[6].Value.ToString();
                string empNetPay = dgvRow.Cells[7].Value.ToString();
                string month = dateTimePicker.Value.ToString("MMM/yyyy");
                string date = dateTimePicker.Value.ToString("dd/MMM/yyyy");
                databaseHelper.AddOrDeleteEmpSalary(
                    Convert.ToInt32(empId),
                    empName,empDept,empIncentive,bonus,empGrossPay,empDeduction,
                    empNetPay,month,date
                );
                PopulateDgv();
            }
        }

        private void BtnSeeIndReport_Click(object sender, EventArgs e)
        {
            if(dgvMonthlySalery.CurrentRow != null)
            {


                DataGridViewRow row = dgvMonthlySalery.CurrentRow;
                int empId = Convert.ToInt32(row.Cells[1].Value.ToString());
                string empName = row.Cells[2].Value.ToString();
                string date = row.Cells[9].Value.ToString();
                string bonus = row.Cells[3].Value.ToString();
                string incentive = row.Cells[4].Value.ToString();
                string tax = row.Cells[6].Value.ToString();
                string grossPay = row.Cells[5].Value.ToString();
                string netPay = row.Cells[7].Value.ToString();
                string status = row.Cells[8].Value.ToString();

                if(status == "Transferred")
                {
                    new PaySlip(empId, empName, cbSelectDept.Text, date, bonus, incentive, tax, grossPay, netPay)
                    {
                        Visible = false
                    }.ShowDialog();
                }
                else
                {
                    new Alert("Change Pay Status To Transferred",Alert.AlertType.INFO).Show();
                }
            }
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Empolye Selry Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add("Empolye ID");
                tbl.Columns.Add(" Name ");
                tbl.Columns.Add(" Bonus ");
                tbl.Columns.Add("Incentive");
                tbl.Columns.Add(" Gross Pay ");
                tbl.Columns.Add("Deduction");
                tbl.Columns.Add(" Net Pay ");
                tbl.Columns.Add(" Status ");
                tbl.Columns.Add(" Pay Date ");

                for (var i = 0; i < dgvMonthlySalery.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvMonthlySalery.Rows[i];
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
                    tbl.Rows.InsertAt(newRow, i);
                }

                tbl.ExportToExcel(path);
            }
        }

        private void CbSelectSalaryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExport_MouseEnter(object sender, EventArgs e)
        {
            btnExport.FlatAppearance.BorderSize = 3;
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnExport_MouseLeave(object sender, EventArgs e)
        {
            btnExport.FlatAppearance.BorderSize = 3;
            btnExport.FlatAppearance.BorderColor = Color.DarkGreen;
        }

        private void BtnSeeIndReport_MouseEnter(object sender, EventArgs e)
        {
            btnShowPaySlip.FlatAppearance.BorderSize = 3;
            btnShowPaySlip.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnSeeIndReport_MouseLeave(object sender, EventArgs e)
        {
            btnShowPaySlip.FlatAppearance.BorderSize = 3;
            btnShowPaySlip.FlatAppearance.BorderColor = Color.FromArgb(153, 3, 46);
        }

        private void BtnSetStatus_MouseEnter(object sender, EventArgs e)
        {
            btnSetStatus.FlatAppearance.BorderSize = 3;
            btnSetStatus.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnSetStatus_MouseLeave(object sender, EventArgs e)
        {
            btnSetStatus.FlatAppearance.BorderSize = 3;
            btnSetStatus.FlatAppearance.BorderColor = Color.FromArgb(192, 64, 0);
        }
    }
}