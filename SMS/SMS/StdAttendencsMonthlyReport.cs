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
    public partial class StdAttendencsMonthlyReport : Form
    {
        private string stdDetId,name;
        private List<Label> DateLabels;
        DatabaseHelper databaseHelper;
        DepartmentType departmentType;


        public StdAttendencsMonthlyReport(DepartmentType departmentType, string stdDetId, string name)
        {
            this.stdDetId = stdDetId;
            this.name= name;
            this.departmentType = departmentType;
           // this.stdAttDate = stdAttDate;
            databaseHelper = new DatabaseHelper();

            InitializeComponent();
            
            DateLabels = new List<Label>();
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


        private void StdAttendencsMonthlyReport_Load(object sender, EventArgs e)
        {
            stdAttdRno.Text = stdDetId;
            stdAttdName.Text = name;
            AssignLabelsToList();
            SetAllLabels();

        }

        private void DtpIndvlAttd_ValueChanged(object sender, EventArgs e)
        {
            SetAllLabels();
        }

        private void SetAllLabels()
        {
            for (int j = 0; j < 30; j++)
            {
                DateLabels[j].Transparent();
            }

            string date = dtpIndvlAttd.Value.ToString("MMM/yyyy");

            DataTable tbl = databaseHelper.GetAttendenceTBL(departmentType, Convert.ToInt32(stdDetId), date);
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DataRow row = tbl.Rows[i];
                int dt = Convert.ToInt32(row[2].ToString().Split('/')[0]);
                bool isPresent = row[3].ToString() == "P" ? true : false;
                if (isPresent)
                {
                    DateLabels[dt - 1].Green();
                }
                else
                {
                    DateLabels[dt - 1].Red();
                }
            }

            PopulatePieChart();
        }

        private void PopulatePieChart()
        {
            //pie
            int red = 0,white = 0,green = 0;

            for(var i = 0; i < DateLabels.Count; i++)
            {
                if(DateLabels[i].BackColor == Color.Red)
                {
                    red++;
                }
                else if(DateLabels[i].BackColor == Color.Green)
                {
                    green++;
                }
                else
                {
                    white++;
                }
            }

            chartMonthlyAtt.Series["Attendence"].Points.Clear();

            chartMonthlyAtt.Series["Attendence"].Points.Add(green);
            chartMonthlyAtt.Series["Attendence"].Points[0].Color = Color.Green;
            chartMonthlyAtt.Series["Attendence"].Points[0].AxisLabel = "Present #PERCENT";
            chartMonthlyAtt.Series["Attendence"].Points[0].LegendText = "Present #PERCENT";
            chartMonthlyAtt.Series["Attendence"].Points[0].Label = " ";

            chartMonthlyAtt.Series["Attendence"].Points.Add(red);
            chartMonthlyAtt.Series["Attendence"].Points[1].Color = Color.Red;
            chartMonthlyAtt.Series["Attendence"].Points[1].AxisLabel = "Absent #PERCENT";
            chartMonthlyAtt.Series["Attendence"].Points[1].LegendText = "Absent #PERCENT";
            chartMonthlyAtt.Series["Attendence"].Points[1].Label = " ";

            chartMonthlyAtt.Series["Attendence"].Points.Add(white);
            chartMonthlyAtt.Series["Attendence"].Points[2].Color = Color.Gray;
            chartMonthlyAtt.Series["Attendence"].Points[2].AxisLabel = "Not Marked #PERCENT";
            chartMonthlyAtt.Series["Attendence"].Points[2].LegendText = "Not Marked #PERCENT";
            chartMonthlyAtt.Series["Attendence"].Points[2].Label = " ";

            chartMonthlyAtt.ChartAreas["ChartArea1"].BackColor = Color.Transparent;
            chartMonthlyAtt.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AssignLabelsToList()
        {
            DateLabels.Add(lblDate1);
            DateLabels.Add(lblDate2);
            DateLabels.Add(lblDate3);
            DateLabels.Add(lblDate4);
            DateLabels.Add(lblDate5);
            DateLabels.Add(lblDate6);
            DateLabels.Add(lblDate7);
            DateLabels.Add(lblDate8);
            DateLabels.Add(lblDate9);
            DateLabels.Add(lblDate10);
            DateLabels.Add(lblDate11);
            DateLabels.Add(lblDate12);
            DateLabels.Add(lblDate13);
            DateLabels.Add(lblDate14);
            DateLabels.Add(lblDate15);
            DateLabels.Add(lblDate16);
            DateLabels.Add(lblDate17);
            DateLabels.Add(lblDate18);
            DateLabels.Add(lblDate19);
            DateLabels.Add(lblDate20);
            DateLabels.Add(lblDate21);
            DateLabels.Add(lblDate22);
            DateLabels.Add(lblDate23);
            DateLabels.Add(lblDate24);
            DateLabels.Add(lblDate25);
            DateLabels.Add(lblDate26);
            DateLabels.Add(lblDate27);
            DateLabels.Add(lblDate28);
            DateLabels.Add(lblDate29);
            DateLabels.Add(lblDate30);
            DateLabels.Add(lblDate31);
        }
    }
}
