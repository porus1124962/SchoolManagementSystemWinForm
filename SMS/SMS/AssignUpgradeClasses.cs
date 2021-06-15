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
    public partial class AssignUpgradeClasses : Form
    {
        private string stdName, stdDetId, teacherName;
        int teacherId;
        Common.DepartmentType departmentType;
        DatabaseHelper databaseHelper;

        public AssignUpgradeClasses(string stdDetId,string stdName)
        {
            this.stdDetId = stdDetId;
            this.stdName= stdName;
            databaseHelper = new DatabaseHelper();
            InitializeComponent();
            departmentType = Common.DepartmentType.STUDENT;
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

        public AssignUpgradeClasses(int teacherId, string teacherName)
        {
            
            this.teacherId = teacherId;
            this.teacherName = teacherName;
            databaseHelper = new DatabaseHelper();
            InitializeComponent();
            departmentType = Common.DepartmentType.TEACHER;
            Common.RoundBorderForm(this, 10);
        }

        private void BtnAssignClass_Click(object sender, EventArgs e)
        {
            try
            {
                int secId = Convert.ToInt32(comboBoxSelectSection.SelectedValue.ToString());

                DateTime dt = dateTimePickerAssignClass.Value;
                string monthYear = dt.Month.ToString() + " / " + dt.Year.ToString();

                if (departmentType == Common.DepartmentType.STUDENT)
                {
                    bool result = databaseHelper.AddOrUpdatestdAssignClass(Convert.ToInt32(stdDetId), secId, monthYear);
                    if (result) { new Alert("Student Assigned To Class", Alert.AlertType.SUCCESS); }
                    this.Close();
                }
                else if(departmentType == Common.DepartmentType.TEACHER)
                {
                    //working
                    DataTable tbl = databaseHelper.GetTeacherAssignClassTBL(secId.ToString());
                    if(tbl.Rows.Count > 0)
                    {
                        string oldTeacherDetId = tbl.Rows[0]["teacherClsAssignFKteacherDetId"].ToString();
                        string oldTeacherName;
                        try
                        {
                            oldTeacherName = databaseHelper.GetTBLDetailsAllDepartments(Common.DepartmentType.TEACHER, Convert.ToInt32(oldTeacherDetId)).Rows[0]["teacherDetName"].ToString();
                        }
                        catch (Exception)
                        {
                            oldTeacherName = "Retired Teacher";
                        }

                        if (MessageBox.Show("This Class is already assigned to "+ oldTeacherName + ". Do you want to reassign this class to "+teacherName+"?","Alert!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            bool result = databaseHelper.UpdateTeacherAssignClass(teacherId,secId);
                            if (result) { new Alert("New Teacher Assigned To Class", Alert.AlertType.SUCCESS); }
                            this.Close();
                        }
                        else
                        {
                            new Alert("No Problem", Alert.AlertType.INFO);
                            this.Close();
                        }
                    }
                    else
                    {
                        bool result = databaseHelper.AddTeacherAssignClass(teacherId,secId);
                        if (result) { new Alert("Teacher Assigned To Class", Alert.AlertType.SUCCESS); }
                        this.Close();
                    }
                }
            }
            catch (Exception) { new Alert("Select Valid Class / Section", Alert.AlertType.WARNING); }
        }

        private void AssignUpgradeClasses_Load(object sender, EventArgs e)
        {
            if(departmentType == Common.DepartmentType.STUDENT)
            {
                lblStdRNo.Text = stdDetId;
                lblStdName.Text = stdName;
            }
            else if(departmentType == Common.DepartmentType.TEACHER)
            {
                lblStdRNo.Text = teacherId.ToString();
                lblStdName.Text = teacherName;
            }

            PopulateCBClasses();
            int key = Convert.ToInt32(comboBoxSelectClass.SelectedValue.ToString());
            PopulateCBSections(key);
            PopulateLBBooks(key);
            PopulateLblStdLength();
        }

        private void PopulateLBBooks(int clsId)
        {
            listBoxAssignBooks.DataSource = databaseHelper.GetSubjectsTBL(clsId);
            listBoxAssignBooks.DisplayMember = "clsBookName";
        }

        private void PopulateCBSections(int cls)
        {
            DataTable tbl = databaseHelper.GetSectionsTBL(cls);
            if (tbl.Rows.Count > 0) {
                comboBoxSelectSection.DataSource = tbl;
                comboBoxSelectSection.DisplayMember = "secName";
                comboBoxSelectSection.ValueMember = "secId";
            }
            else
            {
                List<string> list = new List<string>();
                list.Add("--No Sec--");
                comboBoxSelectSection.DataSource = list;
                new Alert("Add sections in this class first",Alert.AlertType.WARNING,3);
            }
        }

        private void ComboBoxSelectClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt32(comboBoxSelectClass.SelectedValue.ToString());
                PopulateCBSections(key);
                PopulateLBBooks(key);
            }
            catch (Exception){}
        }

        private void ComboBoxSelectSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //update std length
                PopulateLblStdLength();
            }
            catch (Exception) { }
        }

        private void BtnClass_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAssignClass_MouseEnter(object sender, EventArgs e)
        {
            btnAssignClass.FlatAppearance.BorderSize = 3;
            btnAssignClass.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnAssignClass_MouseLeave(object sender, EventArgs e)
        {
            btnAssignClass.FlatAppearance.BorderSize = 3;
            btnAssignClass.FlatAppearance.BorderColor = Color.FromArgb(47, 54, 64);
        }

        private void PopulateLblStdLength() {
            int secId = Convert.ToInt32(comboBoxSelectSection.SelectedValue.ToString());
            lblStdLength.Text = databaseHelper.GetTotalStdsOfSec(secId).Rows.Count.ToString() + " Students in Section "+comboBoxSelectSection.Text;
        }

        private void PopulateCBClasses()
        {
            comboBoxSelectClass.DataSource = databaseHelper.GetClassesTBL();
            comboBoxSelectClass.DisplayMember = "className";
            comboBoxSelectClass.ValueMember = "classId";
        }
    }
}
