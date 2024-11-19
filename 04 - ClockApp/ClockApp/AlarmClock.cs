using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class AlarmClock : UserControl
    {
        public AlarmClock()
        {
            InitializeComponent();
        }

        bool isAlarmTriggered = false;

        private TimeSpan GetDifferenceTime()
        {
            return dtpSetAlarm.Value - DateTime.Now;
        }

        private void AlarmClock_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

            dtpSetAlarm.Value = DateTime.Now.AddMinutes(10);
            lblRemainingTime.Visible = false;

            // Configure NotifyIcon
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipTitle = "Alarm Clock";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            // notifyIcon1.Icon = new Icon("");
            notifyIcon1.Text = "Alarm Clock Running";
            notifyIcon1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update the current time label
            lblTimeNow.Text = DateTime.Now.ToString("hh:mm:ss tt");         

            if(!isAlarmTriggered) // Check if the alarm has not been triggered yet
            {
                TimeSpan timeSpan = GetDifferenceTime();

                if (timeSpan <= TimeSpan.Zero) // If the alarm time has been reached
                {
                    isAlarmTriggered = true;
                    lblRemainingTime.Text = "Time's up!";

                    notifyIcon1.BalloonTipText = "It's time!";
                    notifyIcon1.ShowBalloonTip(3000);
                }
                else
                {
                    lblRemainingTime.Text = $"{timeSpan.Days}d, {timeSpan.Hours}h, {timeSpan.Minutes}m, {timeSpan.Seconds}s.";
                }
            }

           // lblRemainingTime.Visible = !dtpSetAlarm.Focused;

        }

        private void btnSetAlarm_Click(object sender, EventArgs e)
        {
            if (dtpSetAlarm.Value <= DateTime.Now) 
            {
                MessageBox.Show("Error!\nYou entered an invalid time.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isAlarmTriggered = false;
            lblRemainingTime.Visible = true;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            dtpSetAlarm.Value = DateTime.Now.AddMinutes(10);
            lblRemainingTime.Visible = false;
            
        }
    }
}
