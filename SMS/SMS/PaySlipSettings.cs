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
    public partial class PaySlipSettings : Form
    {
        DatabaseHelper databaseHelper;
        public PaySlipSettings()
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

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            string schName = textBoxSchName.Text;
            string bankName = textBoxBankName.Text;
            string accNo = textBoxAccNo.Text;
            if(schName != "" && bankName != "" && accNo != "")
            {
                databaseHelper.AddOrUpdatePref("SName", schName);
                databaseHelper.AddOrUpdatePref("BName", bankName);
                databaseHelper.AddOrUpdatePref("BankAccNo", accNo);
                new Alert("Saved Successfully", Alert.AlertType.SUCCESS);
                this.Close();
            }
            else
            {
                new Alert("Fill All Fields!", Alert.AlertType.WARNING);
            }
        }

        private void PaySlipSettings_Load(object sender, EventArgs e)
        {
            textBoxSchName.Text = databaseHelper.GetPref("SName");
            textBoxBankName.Text = databaseHelper.GetPref("BName");
            textBoxAccNo.Text = databaseHelper.GetPref("BankAccNo");
        }
    }
}
