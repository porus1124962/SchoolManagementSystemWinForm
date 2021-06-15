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
    public partial class StdIdvFee : Form
    {
        string detId, name;
        DatabaseHelper databaseHelper;
        StdClassWiseFeesReport formRef;

        public StdIdvFee(string stdDetId, string name,bool canChangeFeesStatus)
        {
            this.detId = stdDetId;
            this.name = name;
            databaseHelper = new DatabaseHelper();

            InitializeComponent();
            Common.RoundBorderForm(this, 10);
            btnChangeFeeStatus.Visible = canChangeFeesStatus;
        }

        public StdIdvFee(string stdDetId, string name)
        {
            this.detId = stdDetId;
            this.name = name;
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
        public StdIdvFee(StdClassWiseFeesReport formRef,string stdDetId, string name)
        {
            this.detId = stdDetId;
            this.name = name;
            this.formRef = formRef;
            databaseHelper = new DatabaseHelper();
            InitializeComponent();
        }

        private void StdIdvFee_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            lblRNo.Text = detId;
            PopulateDgv();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void CbPaid_CheckedChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void CbUnPaid_CheckedChanged(object sender, EventArgs e)
        {
            PopulateDgv();
        }

        private void BtnChangeFeeStatus_Click(object sender, EventArgs e)
        {
            if (dgvStdIndFee.CurrentRow != null)
            {

                string month = dgvStdIndFee.CurrentRow.Cells[0].Value.ToString();

                if (MessageBox.Show("Are You Sure To Change " + name + "'s Fees Status?", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    databaseHelper.AddOrDeleteStufees(Convert.ToInt32(detId), DateTime.Now.ToString("dd/MMM/yyyy"), month + "/" + dateTimePicker.Value.ToString("yyyy"));
                    PopulateDgv();
                }
                else
                {
                    new Alert("No Problem", Alert.AlertType.INFO);
                }
            }
            else
            {
                new Alert("Select A Row To Proceed", Alert.AlertType.INFO);
            }
        }

        private void StdIdvFee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(formRef != null)
            {
                formRef.PopulateDgvFeesList();
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Sheet|*.xlsx";
            sfd.FileName = "Student Indivsual Fee Record";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = Path.GetFullPath(sfd.FileName);

                DataTable tbl = new DataTable();
                tbl.Columns.Add("FeesMonth");
                tbl.Columns.Add("FeesPaidDate");
                tbl.Columns.Add("FeesStatus");

                for (var i = 0; i < dgvStdIndFee.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvStdIndFee.Rows[i];
                    DataRow newRow = tbl.NewRow();
                    newRow[0] = row.Cells[0].Value;
                    newRow[1] = row.Cells[1].Value;
                    newRow[2] = row.Cells[2].Value;
                    tbl.Rows.InsertAt(newRow, i);
                }

                tbl.ExportToExcel(path);
            }
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
            btnExport.FlatAppearance.BorderSize = 2;
            btnExport.FlatAppearance.BorderColor = Color.DarkGreen;
        }

        private void BtnChangeFeeStatus_MouseEnter(object sender, EventArgs e)
        {
            btnChangeFeeStatus.FlatAppearance.BorderSize = 3;
            btnChangeFeeStatus.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnChangeFeeStatus_MouseLeave(object sender, EventArgs e)
        {
            btnChangeFeeStatus.FlatAppearance.BorderSize = 2;
            btnChangeFeeStatus.FlatAppearance.BorderColor = Color.FromArgb(173, 10, 67);
        }

        private void PopulateDgv()
        {
            string year = dateTimePicker.Value.ToString("yyyy");

            DataTable list = new DataTable();
            list.Columns.Add("stuFeesMonth");
            list.Columns.Add("stuFeesPaidDate");
            list.Columns.Add("stuFeesStatus");

            string[] months = {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};

            for(var i = 0; i < months.Length; i++)
            {
                string monthYear = months[i] + "/" + year;
                DataTable feeTbl = databaseHelper.GetStdFeesTBL(Convert.ToInt32(detId), monthYear);
                if(feeTbl.Rows.Count > 0)
                {
                    DataRow row = list.NewRow();
                    row[0] = months[i];
                    row[1] = feeTbl.Rows[0][1];
                    row[2] = "Paid";
                    list.Rows.InsertAt(row, i);
                }
                else
                {
                    DataRow row = list.NewRow();
                    row[0] = months[i];
                    row[1] = "";
                    row[2] = "UnPaid";
                    list.Rows.InsertAt(row, i);
                }
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = list;
            string filterQuery;

            if(cbPaid.Checked && cbUnPaid.Checked)
            {
                filterQuery = "";
            }else if (cbPaid.Checked)
            {
                filterQuery = "stuFeesStatus like 'Paid%'";
            }else if (cbUnPaid.Checked)
            {
                filterQuery = "stuFeesStatus like 'UnPaid%'";
            }
            else
            {
                filterQuery = "";
            }

            bs.Filter = filterQuery;
            dgvStdIndFee.DataSource = bs;

        }
    }
}
