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
    public partial class StdLeavePassRecord : Form
    {
        DatabaseHelper databaseHelper;
        BindingSource bs;
        public StdLeavePassRecord()
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

        private void StdLeavePassRecord_Load(object sender, EventArgs e)
        {
            dgvStdLeaveReport.DataSource =  databaseHelper.GetLeaveStdTBL();
        }

        private void PopulateStdDGV()
        {
            string search = txtBoxStdLeaveReportSearch.Text;
            

            DataTable tbl = databaseHelper.GetLeaveStdTBL();
            if (search == null || search == "")
            {
                dgvStdLeaveReport.DataSource = tbl;
            }
            else
            {
                string filterQuery;
                if (search.Any(char.IsDigit))
                {
                    int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                    filterQuery = "stdLeaveRecFKstdDetId = " + searchTermInt + " or stuDetName like '" + search + "%' or stuDetFname like '" + search + "%' or stuDetGender like '" + search + "%' or stuDetStuPh like'"+ search + "%' or stdLeaveRecLastClassStudied like '" + search + "%' or stdLeaveRecLeaveStatus like '" + search + "%' or stdLeaveRecAcademicResult like '" + search + "%' or stdLeaveRecPercenage like '" + search + "%'";
                }
                else
                {
                    filterQuery = "stuDetName like '" + search + "%' or stuDetFname like '" + search + "%' or stuDetGender like '" + search + "%' or stuDetStuPh like'" + search + "%' or stdLeaveRecLastClassStudied like '" + search + "%' or stdLeaveRecLeaveStatus like '" + search + "%' or stdLeaveRecAcademicResult like '" + search + "%' or stdLeaveRecPercenage like '" + search + "%'";
                }
                BindingSource bs = new BindingSource();
                bs.DataSource = tbl;
                bs.Filter = filterQuery;
                dgvStdLeaveReport.DataSource = bs;
            }
            
        }

        private void TxtBoxStdLeaveReportSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateStdDGV();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Student Pass Out/Left Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add("Roll No");
                tbl.Columns.Add("Name");
                tbl.Columns.Add("F.Name");
                tbl.Columns.Add("Sex");
                tbl.Columns.Add("Phone No");
                tbl.Columns.Add("Last Class Studied");
                tbl.Columns.Add("Leave Status");
                tbl.Columns.Add("Academic Year");
                tbl.Columns.Add("Class Proformance");

                for (var i = 0; i < dgvStdLeaveReport.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvStdLeaveReport.Rows[i];
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

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
