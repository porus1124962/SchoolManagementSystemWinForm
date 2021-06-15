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
    public partial class SetBasicSalary : Form
    {
        DatabaseHelper databaseHelper;
        public SetBasicSalary()
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

        private void BtnSetBasic_Click(object sender, EventArgs e)
        {
            SaveDefaultSalary();
            this.Close();
        }


        private void SaveDefaultSalary() {

            if (TBteach1.Text.IsNumberAndNotNull()
                && TBteach2.Text.IsNumberAndNotNull()
                && TBteach3.Text.IsNumberAndNotNull()
                && TBhr1.Text.IsNumberAndNotNull()
                && TBhr2.Text.IsNumberAndNotNull() 
                && TBhr3.Text.IsNumberAndNotNull()
                && TBadmin1.Text.IsNumberAndNotNull() 
                && TBadmin2.Text.IsNumberAndNotNull() 
                && TBadmin3.Text.IsNumberAndNotNull()
                && TBacc1.Text.IsNumberAndNotNull()
                && TBacc2.Text.IsNumberAndNotNull() 
                && TBacc3.Text.IsNumberAndNotNull()
                )
            {
                bool teachRes = databaseHelper.AddOrUpdateDefaultSalary(TBteach1.Text, TBteach2.Text, TBteach3.Text, "Teacher");
                bool hrRes = databaseHelper.AddOrUpdateDefaultSalary(TBhr1.Text, TBhr2.Text, TBhr3.Text, "Admission");
                bool adminRes = databaseHelper.AddOrUpdateDefaultSalary(TBadmin1.Text, TBadmin2.Text, TBadmin3.Text, "Administrator");
                bool accRes = databaseHelper.AddOrUpdateDefaultSalary(TBacc1.Text, TBacc2.Text, TBacc3.Text, "Accounts");

                  if (teachRes && hrRes && adminRes && accRes)
                  {
                    new Alert("Default Salary Successfully Saved", Alert.AlertType.SUCCESS, 3);
                  }
                  else
                  {
                    new Alert("Error in Saving", Alert.AlertType.ERROR);
                  }
            }
            else {
                new Alert("Fill All The Fields In Digits", Alert.AlertType.ERROR);
            }
        }

        private void SetBasicSalary_Load(object sender, EventArgs e)
        {
            DataTable tbl = databaseHelper.GetDefaultSalary();

            if(tbl.Rows.Count > 3)
            {
                TBacc1.Text = tbl.Rows[0][1].ToString();
                TBacc2.Text = tbl.Rows[0][2].ToString();
                TBacc3.Text = tbl.Rows[0][3].ToString();

                TBadmin1.Text = tbl.Rows[1][1].ToString();
                TBadmin2.Text = tbl.Rows[1][2].ToString();
                TBadmin3.Text = tbl.Rows[1][3].ToString();

                TBhr1.Text = tbl.Rows[2][1].ToString();
                TBhr2.Text = tbl.Rows[2][2].ToString();
                TBhr3.Text = tbl.Rows[2][3].ToString();

                TBteach1.Text = tbl.Rows[3][1].ToString();
                TBteach2.Text = tbl.Rows[3][2].ToString();
                TBteach3.Text = tbl.Rows[3][3].ToString();
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSetBasic_MouseEnter(object sender, EventArgs e)
        {
            btnSetBasic.FlatAppearance.BorderSize = 3;
            btnSetBasic.FlatAppearance.BorderColor = Color.FromArgb(57, 210, 219);
        }

        private void BtnSetBasic_MouseLeave(object sender, EventArgs e)
        {
            btnSetBasic.FlatAppearance.BorderSize = 3;
            btnSetBasic.FlatAppearance.BorderColor = Color.FromArgb(3, 54, 9);
        }
    }
}
