using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SMS.Common;

namespace SMS
{
    public partial class ProfitLoss : Form
    {
        DatabaseHelper databaseHelper;
        public ProfitLoss()
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfitLoss_Load(object sender, EventArgs e)
        {
            PopulateLabels();
        }

        private void PopulateLabels()
        {
            string monthYear = dateTimePicker1.Value.ToString("MMM/yyyy");
            string year = dateTimePicker1.Value.ToString("yyyy");

            int[] incomeExpMY = databaseHelper.CalculateProfitLoss(monthYear);
            int[] incomeExpY = databaseHelper.CalculateProfitLoss(year);

            lblIncomeMonth.Text = incomeExpMY[0].ToString();
            lblExpenditureMonth.Text = incomeExpMY[1].ToString();

            lblIncomeYear.Text = incomeExpY[0].ToString();
            lblExpenditureYear.Text = incomeExpY[1].ToString();

            int profitLossMonth = incomeExpMY[0] - incomeExpMY[1];
            int profitLossYear = incomeExpY[0] - incomeExpY[1];

            lblProfitLossMonth.Text = profitLossMonth.ToString();
            lblProfitLossYear.Text = profitLossYear.ToString();

            if(profitLossMonth < 0)
            {
                lblProfitLossMonth.BackColor = Color.Red;
            }
            else
            {
                lblProfitLossMonth.BackColor = Color.LightGreen;
            }

            if (profitLossYear < 0)
            {
                lblProfitLossYear.BackColor = Color.Red;
            }
            else
            {
                lblProfitLossYear.BackColor = Color.LightGreen;
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PopulateLabels();
        }
    }
}
