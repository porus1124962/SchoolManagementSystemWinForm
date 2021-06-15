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
using static SMS.Common;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

namespace SMS
{
    public partial class ExpendituresForm : Form
    {
        DatabaseHelper databaseHelper;
        BindingSource bs;

        public ExpendituresForm()
        {
            InitializeComponent();
            databaseHelper = new DatabaseHelper();
            Common.RoundBorderForm(this,10);
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


        private void DgvExp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvExp.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvExp.CurrentRow;

                if (dgvRow.Cells[0].Value == DBNull.Value)
                {
                    // insert code
                    if (dgvRow.Cells["expendituresName"].Value != DBNull.Value &&
                        dgvRow.Cells["expendituresDescribtion"].Value != DBNull.Value &&
                        dgvRow.Cells["expendituresChareges"].Value != DBNull.Value &&
                        dgvRow.Cells["expendituresProfitLose"].Value != DBNull.Value &&
                        dgvRow.Cells["expendituresDate"].Value != DBNull.Value)
                    {
                        DateTime Test;
                        if (DateTime.TryParseExact(dgvRow.Cells["expendituresDate"].Value.ToString(), "dd/MMM/yyyy", null, DateTimeStyles.None, out Test) == false)
                        {
                            new Alert("Wrong Date Format 01/Jan/2019",Alert.AlertType.WARNING);
                            return;
                        }

                        bool result = databaseHelper.AddExp(
                            dgvRow.Cells["expendituresName"].Value.ToString(),
                            dgvRow.Cells["expendituresDescribtion"].Value.ToString(),
                            dgvRow.Cells["expendituresChareges"].Value.ToString(),
                            dgvRow.Cells["expendituresProfitLose"].Value.ToString(),
                            dgvRow.Cells["expendituresDate"].Value.ToString());
                        PopulateDgv();
                        if (result) { new Alert("Expenditures Added", Alert.AlertType.SUCCESS); }
                    }
                }
                else
                {
                    //update code
                    
                    if (dgvRow.Cells["expendituresName"].Value == DBNull.Value ||
                        dgvRow.Cells["expendituresDescribtion"].Value == DBNull.Value ||
                        dgvRow.Cells["expendituresChareges"].Value == DBNull.Value ||
                        dgvRow.Cells["expendituresProfitLose"].Value == DBNull.Value ||
                        dgvRow.Cells["expendituresDate"].Value == DBNull.Value)
                    {
                        new Alert("First Fill All The Columns", Alert.AlertType.INFO);
                        return;
                    }

                    DateTime Test;
                    if (DateTime.TryParseExact(dgvRow.Cells["expendituresDate"].Value.ToString(), "dd/MMM/yyyy", null, DateTimeStyles.None, out Test) == false)
                    {
                        new Alert("Wrong Date Format 01/Jan/2019", Alert.AlertType.WARNING);
                        return;
                    }

                    databaseHelper.UpdateExp(
                    dgvRow.Cells["expendituresName"].Value == null ? "" : dgvRow.Cells["expendituresName"].Value.ToString(),
                    dgvRow.Cells["expendituresDescribtion"].Value == null ? "" : dgvRow.Cells["expendituresDescribtion"].Value.ToString(),
                    dgvRow.Cells["expendituresChareges"].Value == null ? "" : dgvRow.Cells["expendituresChareges"].Value.ToString(),
                    dgvRow.Cells["expendituresProfitLose"].Value == null ? "" : dgvRow.Cells["expendituresProfitLose"].Value.ToString(),
                    dgvRow.Cells["expendituresDate"].Value == null ? "" : dgvRow.Cells["expendituresDate"].Value.ToString(),
                    dgvRow.Cells["expendituresId"].Value.ToString()
                    );

                    new Alert("Updated", Alert.AlertType.INFO, 2);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExpendituresForm_Load(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void PopulateDgv()
        {

            string search = textBoxSearch.Text;


            DataTable tbl = databaseHelper.GetExp();
            if (search == null || search == "")
            {
                dgvExp.DataSource = tbl;
            }
            else
            {
                string filterQuery;
                if (search.Any(char.IsDigit))
                {
                    int searchTermInt = Convert.ToInt32(Regex.Match(search, @"\d+").Value);
                    filterQuery = "expendituresName like '" + search + "%' or expendituresDescribtion like '" + search + "%' or expendituresChareges = " + searchTermInt + " or expendituresProfitLose like'" + search + "%' or expendituresDate like '%" + search + "%'";
                }
                else
                {
                    filterQuery = "expendituresName like '" + search + "%' or expendituresDescribtion like '" + search + "%' or expendituresProfitLose like'" + search + "%' or expendituresDate like '%" + search + "%'";
                }
                bs = new BindingSource();
                bs.DataSource = tbl;
                bs.Filter = filterQuery;
                dgvExp.DataSource = bs;
            }

            //dgvExp.DataSource = databaseHelper.GetExp();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Expenditure Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);
                
                DataTable tbl = new DataTable();
                tbl.Columns.Add("Exp Name");
                tbl.Columns.Add("Discription");
                tbl.Columns.Add("Exp Charges");
                tbl.Columns.Add("Profit / Loss");
                tbl.Columns.Add("Expen. Date");

                for(var i = 0; i < dgvExp.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvExp.Rows[i];
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
            btnExport.FlatAppearance.BorderSize = 3;
            btnExport.FlatAppearance.BorderColor = Color.DarkGreen;
        }
    }
}
