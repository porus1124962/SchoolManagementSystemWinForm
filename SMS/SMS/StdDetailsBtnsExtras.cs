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
    public partial class StdDetailsBtnsExtras : Form
    {
        public StdDetailsBtnsExtras()
        {
            InitializeComponent();
            Common.RoundBorderForm(this,10);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
