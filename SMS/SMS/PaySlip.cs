using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace SMS
{
    public partial class PaySlip : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        Bitmap memoryImage;
        DatabaseHelper databaseHelper;
        int empId ;
        string nameEmp;
        string deptEmp;
        string dateEmp;
        string bonusEmp;
        string IncentiveEmp;
        string taxEmp;
        string grossEmp;
        string netPayEmp;


        public PaySlip(int ID , string name, string dept ,string date , string bonus, string incentive , string tax,string grossPay, string netPay )
        {
            this.empId = ID;
            this.nameEmp = name;
            this.deptEmp = dept;
            this.dateEmp = date;
            this.bonusEmp = bonus;
            this.IncentiveEmp = incentive;
            this.taxEmp = tax;
            this.grossEmp = grossPay;
            this.netPayEmp = netPay;

            databaseHelper = new DatabaseHelper();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            InitializeComponent();
        }

        private void PaySlip_Load(object sender, EventArgs e)
        {
            empID.Text = empId.ToString();
            empName.Text = nameEmp;
            datePay.Text = dateEmp;
            deptPay.Text = deptEmp;
            bonusPay.Text = bonusEmp;
            IncentivePay.Text = IncentiveEmp;
            grossPay.Text = grossEmp;
            taxPay.Text = taxEmp;
            netPay.Text = netPayEmp;
            lblSchoolName.Text = databaseHelper.GetPref("SName");
            lblBankName.Text = databaseHelper.GetPref("BName");
            lblAccNo.Text = databaseHelper.GetPref("BankAccNo");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            //print it

            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            memoryImage = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(memoryImage);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

            //CaptureScreen();
            //printDocument.Print();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument_PrintPage(object sender,PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
