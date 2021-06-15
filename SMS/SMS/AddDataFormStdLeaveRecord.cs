using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class AddDataFormStdLeaveRecord : Form
    {
        DatabaseHelper databaseHelper;
        private string stdDetId, stdName;
        Dashboard DashboardRef;
        public AddDataFormStdLeaveRecord(string stdDetId, string stdName, Dashboard DashboardRef)
        {
            this.stdDetId = stdDetId;
            this.stdName = stdName;
            this.DashboardRef = DashboardRef;
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

        private void AddDataFormStdLeaveRecord_Load(object sender, EventArgs e)
        {
            lblStdLeaveReportRollNo.Text = stdDetId;
            lblStdLeaveReportStdName.Text = stdName;
            comboBoxStdLeaveRecordLeaveClass.SelectedIndex = 0;
            txtBoxStdLeaveRecordLastClsStudied.Text = databaseHelper.GetSingleStdClass(stdDetId);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnAddDataStdLeaveRecord_MouseEnter(object sender, EventArgs e)
        {
            btnAddDataStdLeaveRecord.FlatAppearance.BorderSize = 3;
            btnAddDataStdLeaveRecord.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnAddDataStdLeaveRecord_MouseLeave(object sender, EventArgs e)
        {
            btnAddDataStdLeaveRecord.FlatAppearance.BorderSize = 2;
            btnAddDataStdLeaveRecord.FlatAppearance.BorderColor = Color.FromArgb(140, 12, 3);
        }

        private void BtnAddDataStdLeaveRecord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to move this student to Pass Out/Left list? That Process can't be reverse!","Alert!",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string lastClassStudied = txtBoxStdLeaveRecordLastClsStudied.Text;
                string classProformance = txtBoxStdLeaveRecordClassProformance.Text;
                string leaveStatus = comboBoxStdLeaveRecordLeaveClass.Text;
                string passLeftyear = dateTimePicker1.Value.ToString("yyyy");
                if (lastClassStudied == "" || classProformance == "")
                {
                    new Alert("Fill All The Fields");
                }
                else
                {
                    bool res = databaseHelper.AddLeaveStd(stdDetId, leaveStatus, lastClassStudied, passLeftyear, classProformance);
                    databaseHelper.DeleteAuth(Common.DepartmentType.STUDENT,stdDetId);
                    databaseHelper.UnsignStdClass(stdDetId);
                    if (res)
                    {
                        new Alert("Succesfull Transfer Student");
                        DashboardRef.DgvStdDetLoadHelper();
                        this.Close();
                    }
                }
            }
            else
            {
                new Alert("Ok", Alert.AlertType.INFO);
              
            }
        }

    }
}
