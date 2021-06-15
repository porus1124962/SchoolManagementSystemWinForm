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
using static SMS.Common;

using System.IO;

namespace SMS
{
    public partial class AttendenceClassWiseReport : Form
    {

        DatabaseHelper databaseHelper;
        BindingSource bs;
        public AttendenceClassWiseReport()
        {
            InitializeComponent();
           
            databaseHelper = new DatabaseHelper();
            RoundBorderForm(this, 10);
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


        private void AttendenceClassWiseReport_Load(object sender, EventArgs e)
        {
            PopulateCBClasses();
            PopulateCBSec();
            PopulateDgv();
        }

        public void PopulateDgv() {

            string clsName = comboBoxAttClsWiseReportStdClass.Text;
            string secName = comboBoxAttClsWiseReportStdSec.Text;
            string date = dateTimePicker1.Value.ToString("dd/MMM/yyyy");

            DataTable tbl = databaseHelper.GetAttClassWiseReportTBL(date, clsName, secName);
            BindingSource bs = new BindingSource();
            bs.DataSource = tbl;

            string filterQuery;

            if (checkBoxAttClsWiseReportStdAbsent.Checked && checkBoxAttClsWiseReportStdPresent.Checked)
            {
                filterQuery = null;
            }
            else if (checkBoxAttClsWiseReportStdPresent.Checked)
            {
                filterQuery = "stuAttenStatus = 'P'";
            }else if (checkBoxAttClsWiseReportStdAbsent.Checked)
            {
                filterQuery = "stuAttenStatus = 'A'";
            }
            else
            {
                filterQuery = null;
            }
            bs.Filter = filterQuery;
            dgvAttClsWiseReportStdList.DataSource = bs;
        }

        private void PopulateCBSec()
        {
            int cls;
            try
            {
                string selectedClass = comboBoxAttClsWiseReportStdClass.SelectedValue.ToString();
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
                comboBoxAttClsWiseReportStdSec.DataSource = tbl;
                comboBoxAttClsWiseReportStdSec.DisplayMember = "secName";
                comboBoxAttClsWiseReportStdSec.ValueMember = "secId";
            }
            else
            {
                List<string> list = new List<string>();
                list.Add("--No Sec--");
                comboBoxAttClsWiseReportStdSec.DataSource = list;
                new Alert("Add sections in this class first", Alert.AlertType.WARNING, 3);
            }
        }

        private void PopulateCBClasses()
        {
            DataTable tbl = databaseHelper.GetClassesTBL();

            if (tbl.Rows.Count > 0)
            {
                comboBoxAttClsWiseReportStdClass.DataSource = tbl;
                comboBoxAttClsWiseReportStdClass.DisplayMember = "className";
                comboBoxAttClsWiseReportStdClass.ValueMember = "classId";
            }
            else
            {
                List<string> list = new List<string>();
                list.Add("--No Class--");
                comboBoxAttClsWiseReportStdClass.DataSource = list;
                new Alert("Add Class first", Alert.AlertType.WARNING, 3);
            }
        }

        private void ComboBoxAttClsWiseReportStdClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCBSec();
        }

        private void ComboBoxAttClsWiseReportStdSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void CheckBoxAttClsWiseReportStdPresent_CheckedChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void CheckBoxAttClsWiseReportStdAbsent_CheckedChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Attendence Class Wise Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add("Roll No");
                tbl.Columns.Add("Name");
                tbl.Columns.Add("Attendence Stetus");

                for (var i = 0; i < dgvAttClsWiseReportStdList.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvAttClsWiseReportStdList.Rows[i];
                    DataRow newRow = tbl.NewRow();
                    newRow[0] = row.Cells[0].Value;
                    newRow[1] = row.Cells[1].Value;
                    newRow[2] = row.Cells[2].Value;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
