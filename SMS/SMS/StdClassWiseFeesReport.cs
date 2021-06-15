using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

namespace SMS
{
    public partial class StdClassWiseFeesReport : Form
    {
        DatabaseHelper databaseHelper;

        public StdClassWiseFeesReport()
        {
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

        private void StdClassWiseFeesReport_Load(object sender, EventArgs e)
        {
            PopulateCBClasses();
            PopulateCBSec();
            cbSelectFeeStatus.SelectedIndex = 0;
            PopulateDgvFeesList();
        }

        private void PopulateCBSec()
        {
            int cls;
            try
            {
                string selectedClass = cbSelectClass.SelectedValue.ToString();
                if (selectedClass == "--No Class--")
                {
                    cls = 0;
                }
                else
                {
                    cls = Convert.ToInt32(selectedClass);
                }
            }
            catch (Exception)
            {
                return;
            }

            DataTable tbl = databaseHelper.GetSectionsTBL(cls);

            if (tbl.Rows.Count > 0)
            {
                cbSelectSec.DataSource = tbl;
                cbSelectSec.DisplayMember = "secName";
                cbSelectSec.ValueMember = "secId";
            }
            else
            {
                List<string> list = new List<string>();
                list.Add("--No Sec--");
                cbSelectSec.DataSource = list;
                new Alert("Add sections in this class first", Alert.AlertType.WARNING, 3);
            }
        }

        private void PopulateCBClasses()
        {
            DataTable tbl = databaseHelper.GetClassesTBL();

            if (tbl.Rows.Count > 0)
            {
                cbSelectClass.DataSource = tbl;
                cbSelectClass.DisplayMember = "className";
                cbSelectClass.ValueMember = "classId";
            }
            else
            {
                List<string> list = new List<string>();
                list.Add("--No Class--");
                cbSelectClass.DataSource = list;
                new Alert("Add Class first", Alert.AlertType.WARNING, 3);
            }
        }

        private void CbSelectFeeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDgvFeesList();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateDgvFeesList();
        }

        public void PopulateDgvFeesList()
        {
            string month = dateTimePicker.Value.ToString("MMM/yyyy");
            int secId;
            try
            {
                secId = Convert.ToInt32(cbSelectSec.SelectedValue.ToString());
            }
            catch (Exception)
            {
                return;
            }

            DataTable list = new DataTable();
            list.Columns.Add("stuFeesFKstuDetId");
            list.Columns.Add("stuDetName");
            list.Columns.Add("stuFeesPaidDate");
            list.Columns.Add("feeStatus");

            int i = 0;
            DataTable students = databaseHelper.GetTotalStdsOfSec(secId);
            foreach(DataRow row in students.Rows)
            {
                string stdId = row[1].ToString();
                DataTable feeTbl = databaseHelper.GetStdFeesTBL(Convert.ToInt32(stdId), month);
                if(feeTbl.Rows.Count > 0)
                {
                    DataRow rowTemp = list.NewRow();
                    rowTemp[0] = stdId;
                    rowTemp[1] = feeTbl.Rows[0][0];
                    rowTemp[2] = feeTbl.Rows[0][1];
                    rowTemp[3] = "Paid";
                    list.Rows.InsertAt(rowTemp,i);
                }
                else
                {
                    DataRow rowTemp = list.NewRow();
                    rowTemp[0] = stdId;
                    try
                    {
                        rowTemp[1] = databaseHelper.GetTBLDetailsAllDepartments(Common.DepartmentType.STUDENT, Convert.ToInt32(stdId)).Rows[0][1].ToString();
                    }
                    catch (Exception)
                    {
                        rowTemp[1] = "Unknown Name";
                    }
                    rowTemp[2] = "";
                    rowTemp[3] = "UnPaid";
                    list.Rows.InsertAt(rowTemp,i);
                }
                i++;
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            string filterQuery;
            switch (cbSelectFeeStatus.Text)
            {
                case "Both":
                    filterQuery = "";
                    break;
                case "Paid":
                    filterQuery = "feeStatus like 'Paid%'";
                    break;
                case "UnPaid":
                    filterQuery = "feeStatus like 'UnPaid%'";
                    break;
                default:
                    filterQuery = "";
                    break;
            }
            bs.Filter = filterQuery;
            dgvPaidUnpaidFees.DataSource = bs;
        }

        private void CbSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCBSec();
        }

        private void CbSelectSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDgvFeesList();
        }

        private void BtnSetStatus_Click(object sender, EventArgs e)
        {
            if (dgvPaidUnpaidFees.CurrentRow != null)
            {

                string id = dgvPaidUnpaidFees.CurrentRow.Cells[0].Value.ToString();
                string name = dgvPaidUnpaidFees.CurrentRow.Cells[1].Value.ToString();

                if (MessageBox.Show("Are You Sure To Change "+name+"'s Fees Status?","Alert!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    databaseHelper.AddOrDeleteStufees(Convert.ToInt32(id), DateTime.Now.ToString("dd/MMM/yyyy"), dateTimePicker.Value.ToString("MMM/yyyy"));
                    PopulateDgvFeesList();
                }
                else
                {
                    new Alert("No Problem", Alert.AlertType.INFO);
                }
            }
            else
            {
                new Alert("Select A Row To Proceed",Alert.AlertType.INFO);
            }
        }

        private void BtnSeeIndReport_Click(object sender, EventArgs e)
        {
            if(dgvPaidUnpaidFees.CurrentRow != null)
            {
                string id = dgvPaidUnpaidFees.CurrentRow.Cells[0].Value.ToString();
                string name = dgvPaidUnpaidFees.CurrentRow.Cells[1].Value.ToString();
                new StdIdvFee(this,id, name).Show();
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Student Fee Class Wise Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add("Roll No");
                tbl.Columns.Add("Name");
                tbl.Columns.Add("Fee Paid Date");
                tbl.Columns.Add("Fee Status");

                for (var i = 0; i < dgvPaidUnpaidFees.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvPaidUnpaidFees.Rows[i];
                    DataRow newRow = tbl.NewRow();
                    newRow[0] = row.Cells[0].Value;
                    newRow[1] = row.Cells[1].Value;
                    newRow[2] = row.Cells[2].Value;
                    newRow[3] = row.Cells[3].Value;
                    tbl.Rows.InsertAt(newRow, i);
                }

                tbl.ExportToExcel(path);
            }
        }

        private void BtnExport_MouseEnter(object sender, EventArgs e)
        {
            btnExport.FlatAppearance.BorderSize = 3;            
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnExport_MouseLeave(object sender, EventArgs e)
        {
            btnExport.FlatAppearance.BorderSize = 2;
            btnExport.FlatAppearance.BorderColor = Color.DarkGreen;
        }

        private void BtnSetStatus_MouseEnter(object sender, EventArgs e)
        {
            btnSetStatus.FlatAppearance.BorderSize = 3;
            btnSetStatus.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnSetStatus_MouseLeave(object sender, EventArgs e)
        {
            btnSetStatus.FlatAppearance.BorderSize = 2;
            btnSetStatus.FlatAppearance.BorderColor = Color.FromArgb(113, 13, 189);
        }

        private void BtnSeeIndReport_MouseEnter(object sender, EventArgs e)
        {
            btnSeeIndReport.FlatAppearance.BorderSize = 3;
            btnSeeIndReport.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);

        }

        private void BtnSeeIndReport_MouseLeave(object sender, EventArgs e)
        {
            btnSeeIndReport.FlatAppearance.BorderSize = 2;
            btnSeeIndReport.FlatAppearance.BorderColor = Color.FromArgb(113, 13, 189);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
