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
    public partial class Alert : Form
    {
        public Alert(string msg,AlertType alertType, int intervalSeconds)
        {
            constructerHelper(msg,alertType);
            timeout.Interval = intervalSeconds * 1000;
            timeout.Start();
        }

        public Alert(string msg, AlertType alertType)
        {
            constructerHelper(msg,alertType);
            timeout.Interval = 5 * 1000;
            timeout.Start();
        }

        public Alert(string msg)
        {
            constructerHelper(msg, AlertType.INFO);
            timeout.Interval = 5 * 1000;
            timeout.Start();
        }

        public Alert(int msg, AlertType alertType, int intervalSeconds)
        {
            constructerHelper(msg.ToString(), alertType);
            timeout.Interval = intervalSeconds * 1000;
            timeout.Start();
        }

        public Alert(int msg, AlertType alertType)
        {
            constructerHelper(msg.ToString(), alertType);
            timeout.Interval = 5 * 1000;
            timeout.Start();
        }

        public Alert(int msg)
        {
            constructerHelper(msg.ToString(), AlertType.INFO);
            timeout.Interval = 5 * 1000;
            timeout.Start();
        }

        private void constructerHelper(string msg, AlertType alertType) {
            InitializeComponent();
            if (msg.ToCharArray().Length > 21)
            {
                lblMsg.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            else if(msg.ToCharArray().Length > 25) {
                lblMsg.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            }
            switch (alertType)
            {
                case AlertType.SUCCESS:
                    this.BackColor = Color.SeaGreen;
                    break;
                case AlertType.INFO:
                    this.BackColor = Color.Gray;
                    break;
                case AlertType.WARNING:
                    this.BackColor = Color.FromArgb(255, 128, 0);
                    break;
                case AlertType.ERROR:
                    this.BackColor = Color.Crimson;
                    break;
            }
            Common.RoundBorderForm(this, 8);
            lblMsg.Text = msg;
        }

        public enum AlertType
        {
            SUCCESS,INFO,WARNING,ERROR
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            //Set position
            this.Top = 0;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
            timerShow.Start();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            timerClose.Start();
        }

        private void Timeout_Tick(object sender, EventArgs e)
        {
            timerClose.Start();
        }

        int interval = 0;
        private void TimerShow_Tick(object sender, EventArgs e)
        {
            if(this.Top < 60)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                timerShow.Stop();
            }
        }

        private void TimerClose_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                this.Close();
            }
        }
    }
}
