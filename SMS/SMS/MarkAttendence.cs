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

namespace SMS
{
    
    public partial class MarkAttendence : Form
    {
        DatabaseHelper databaseHelper;
        List<CheckBox> allCheckBoxesRef;
        private int secId;
        public MarkAttendence(int secId,string className,string secName)
        {
            databaseHelper = new DatabaseHelper();
            this.secId = secId;
            InitializeComponent();
            lblShowCls.Text = className;
            lblShowSec.Text = secName;
            allCheckBoxesRef = new List<CheckBox>();
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


        private void LoadCheckBoxes(int secId)
        {
            flpStdCBLayout.Controls.Clear();
            DataTable tbl =  databaseHelper.GetTotalStdsOfSec(secId);
            foreach (DataRow row in tbl.Rows)
            {
                string stdDetId = row["stdAssignClsStdDetId"].ToString();
                string name = databaseHelper.GetTBLDetailsAllDepartments(DepartmentType.STUDENT, Convert.ToInt32(stdDetId)).Rows[0][1].ToString();
                string dateTime = dateTimePicker.Value.ToString("dd/MMM/yyyy");

                DataTable tblTemp =  databaseHelper.GetAttendenceTBL(DepartmentType.STUDENT,Convert.ToInt32(stdDetId),dateTime);
                if(tblTemp.Rows.Count > 0)
                {
                    bool isPresent = tblTemp.Rows[0]["stuAttenStatus"].ToString() == "P" ? true : false;
                    CreateCheckBox(stdDetId, name, isPresent);
                }
                else
                {
                    CreateCheckBox(stdDetId, name, false);
                }
            }
        }

        private void BtnSetStdAtten_Click(object sender, EventArgs e)
        {
            foreach(CheckBox checkBox in allCheckBoxesRef)
            {
                int stdDetId = Convert.ToInt32(checkBox.Text.Split('/')[0].Trim());
                string attStatus = checkBox.Checked ? "P" : "A";
                string dateTime = dateTimePicker.Value.ToString("dd/MMM/yyyy");

                databaseHelper.AddORUpdateAttendence(DepartmentType.STUDENT,stdDetId,dateTime,attStatus);
            }
            new Alert("Attendence Updated", Alert.AlertType.SUCCESS);
            this.Close();
        }

        private void MarkAttendence_Load(object sender, EventArgs e)
        {
            LoadCheckBoxes(secId);
        }

        public void CreateCheckBox(string id, string name, bool isCheck)
        {
            CheckBox checkBox = new CheckBox();

            checkBox.AutoSize = true;
            checkBox.FlatAppearance.BorderColor = Color.FromArgb(74, 83, 100);
            checkBox.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 35, 40);
            checkBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 46, 54);
            checkBox.FlatStyle = FlatStyle.Flat;
            checkBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox.ForeColor = Color.DarkGoldenrod;
            checkBox.Location = new Point(8, 8);
            checkBox.Margin = new Padding(8);
            checkBox.Name = "checkBox" + id;
            checkBox.Size = new Size(135, 30);
            checkBox.TabIndex = 0;
            checkBox.Text = id + " / " + name;
            checkBox.UseVisualStyleBackColor = true;
            checkBox.Checked = isCheck;

            allCheckBoxesRef.Add(checkBox);
            flpStdCBLayout.Controls.Add(checkBox);
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadCheckBoxes(secId);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
