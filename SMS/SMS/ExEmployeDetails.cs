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
using System.Globalization;
using System.IO;

namespace SMS
{
    public partial class ExEmployeDetails : Form
    {
        DatabaseHelper databaseHelper;
        DataTable tbl;
        BindingSource bs;
        public ExEmployeDetails()
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

        private void ExEmployeDetails_Load(object sender, EventArgs e)
        {
            tbl = databaseHelper.GetExEmpDetTBL();
            PopulateDgvExEmployeDet();
        }

        private void PopulateDgvExEmployeDet()
        {
            string filterQuery;
            string search = textBoxSearchEmploye.Text;
            if (search == null || search == "")
            {
                filterQuery = "";
            }
            else if (search.Any(char.IsDigit))
            {
                int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                filterQuery = "exEmpFKUserTypeId = " + searchTermInt + " or exEmptName like '" + search + "%' or exEmpGender like '" + search + "%' or exEmpDeptName like '" + search + "%' or exEmpLeaveDate like '%"+ search + "%'";
            }
            else
            {
                filterQuery = "exEmptName like '" + search + "%' or exEmpGender like '" + search + "%' or exEmpDeptName like '" + search + "%'  or exEmpLeaveDate like '%" + search + "%'";
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = tbl;
            bs.Filter = filterQuery;
            dgvExEmployeDetails.DataSource = bs;
        }

        private void TextBoxSearchEmploye_TextChanged(object sender, EventArgs e)
        {
            PopulateDgvExEmployeDet();
        }

        private void DateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            PopulateDgvExEmployeDet();
        }

        private void DateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            PopulateDgvExEmployeDet();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Ex Empolye Details Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add("Empolye ID");
                tbl.Columns.Add("Empolye Name");
                tbl.Columns.Add("Empolye Gender");
                tbl.Columns.Add("Empolye Dept");
                tbl.Columns.Add("Empolye Leave Date");

                for (var i = 0; i < dgvExEmployeDetails.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvExEmployeDetails.Rows[i];
                    DataRow newRow = tbl.NewRow();
                    newRow[0] = row.Cells[1].Value;
                    newRow[1] = row.Cells[2].Value;
                    newRow[2] = row.Cells[3].Value;
                    newRow[3] = row.Cells[4].Value;
                    newRow[4] = row.Cells[5].Value;
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExport_MouseEnter_1(object sender, EventArgs e)
        {
            btnExport.FlatAppearance.BorderSize = 3;
            btnExport.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnExport_MouseLeave_1(object sender, EventArgs e)
        {
            btnExport.FlatAppearance.BorderSize = 2;
            btnExport.FlatAppearance.BorderColor = Color.DarkGreen;
        }
    }
}
