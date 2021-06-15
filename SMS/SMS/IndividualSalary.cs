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
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

namespace SMS
{
    public partial class IndividualSalary : Form
    {
        DatabaseHelper databaseHelper = new DatabaseHelper();
        BindingSource bs;
        public IndividualSalary()
        {
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

        private void IndividualSalary_Load(object sender, EventArgs e)
        {
            comboBoxDep.SelectedIndex = 0;
            PopulateDgv();
        }

        private void PopulateDgv()
        {
            string search = textBoxSearch.Text;
            int rowNum;
            DataTable tbl;
            switch (comboBoxDep.Text) {
                case "Teacher":
                    rowNum = 3;
                    tbl = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.TEACHER);
                    break;
                case "Admission":
                    rowNum = 2;
                    tbl = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.HR);
                    break;
                case "Accounts":
                    rowNum = 0;
                    tbl = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.ACCOUNTS);
                    break;
                case "Administrator":
                    rowNum = 1;
                    tbl = databaseHelper.GetAllDepartmentDetailsAndAuth(Common.DepartmentType.ADMIN);
                    break;
                default:
                    rowNum = 0;
                    tbl = new DataTable();
                    break;
            }
           
            DataTable tb = new DataTable();
            tb.Columns.Add("salBonusId");
            tb.Columns.Add("salBonusEmpId");
            tb.Columns.Add("EmpName");
            tb.Columns.Add("salBonus");
            tb.Columns.Add("GrossPay");
            tb.Columns.Add("Deduction");
            tb.Columns.Add("Incentive");
            tb.Columns.Add("NetPay");


            for (var i= 0;  i < tbl.Rows.Count; i++  ) {
                DataTable tblTemp = databaseHelper.GetSaleryBonus(comboBoxDep.Text,tbl.Rows[i][0].ToString());
                if (tblTemp.Rows.Count > 0)
                {
                    DataRow row = tb.NewRow();
                    row[0] = tblTemp.Rows[0][0];
                    row[1] = tblTemp.Rows[0][1];
                    row[2] = tbl.Rows[i][1];
                    row[3] = tblTemp.Rows[0][2];
                    row[4] = tblTemp.Rows[0][3];
                    row[5] = tblTemp.Rows[0][4];
                    row[6] = tblTemp.Rows[0][5];
                    row[7] = tblTemp.Rows[0][6];
                    tb.Rows.InsertAt(row,i);

                }
                else {
                    DataRow row = tb.NewRow();

                    DataTable tblDefSal = databaseHelper.GetDefaultSalary();
                    if(tblDefSal.Rows.Count > 3)
                    {
                        row[0] = "";
                        row[1] = tbl.Rows[i][0].ToString();
                        row[2] = tbl.Rows[i][1];
                        row[3] = "0";
                        row[4] = tblDefSal.Rows[rowNum][1];
                        row[5] = tblDefSal.Rows[rowNum][3];
                        row[6] = tblDefSal.Rows[rowNum][2];
                        row[7] = Convert.ToInt32(tblDefSal.Rows[rowNum][1].ToString()) - Convert.ToInt32(tblDefSal.Rows[rowNum][3].ToString()) + Convert.ToInt32(tblDefSal.Rows[rowNum][2].ToString());
                        tb.Rows.InsertAt(row, i);
                    }
                    else
                    {
                        row[0] = "";
                        row[1] = tbl.Rows[i][0].ToString();
                        row[2] = tbl.Rows[i][1];
                        row[3] = "0";
                        row[4] = "0";
                        row[5] = "0";
                        row[6] = "0";
                        row[7] = "0";
                        tb.Rows.InsertAt(row, i);
                    }
                }
            }

            string filterQuery;
            if (search.Any(char.IsDigit))
            {
                int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                filterQuery = "salBonusEmpId = " + searchTermInt + " or EmpName like '" + search + "%' or salBonus like '" + search + "%' or GrossPay like '" + search + "%' or Deduction like '" + search + "%' or Incentive like '" + search + "%' or NetPay like '" + search + "%'";
            }
            else
            {
                filterQuery = "EmpName like '" + search + "%' or salBonus like '" + search + "%' or GrossPay like '" + search + "%' or Deduction like '" + search + "%' or Incentive like '" + search + "%' or NetPay like '" + search + "%'";
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = tb;
            bs.Filter = filterQuery;
            dgvSalary.DataSource = bs;
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void DgvPaidUnpaidFees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvRow = dgvSalary.CurrentRow;
            if (dgvSalary.CurrentRow != null)
            {
                string empId = dgvRow.Cells[1].Value.ToString();
                string empDept = comboBoxDep.Text;
                string bonus = dgvRow.Cells[3].Value.ToString();
                bool res = databaseHelper.AddOrUpdateBonusOfEmp(empId, empDept, bonus);
                if (res) { new Alert("Bonus Saved", Alert.AlertType.SUCCESS); };
                PopulateDgv();
            }
        }

        private void ComboBoxDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExcelReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Individual Emp Selery Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add("Emp Id");
                tbl.Columns.Add("Emp Name");
                tbl.Columns.Add("Emp Bonus");
                tbl.Columns.Add("GrossPay");
                tbl.Columns.Add("Deduction");
                tbl.Columns.Add("Incentive");
                tbl.Columns.Add("Net Pay");

                for (var i = 0; i < dgvSalary.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvSalary.Rows[i];
                    DataRow newRow = tbl.NewRow();
                    newRow[0] = row.Cells[1].Value;
                    newRow[1] = row.Cells[2].Value;
                    newRow[2] = row.Cells[3].Value;
                    newRow[3] = row.Cells[4].Value;
                    newRow[4] = row.Cells[5].Value;
                    newRow[5] = row.Cells[6].Value;
                    newRow[6] = row.Cells[7].Value;
                    tbl.Rows.InsertAt(newRow, i);
                }

                tbl.ExportToExcel(path);
            }
        }
    }
}
