// ClockApp: TimeNow, WorldClock, AlarmClock, StopWatch, Timer.
// V1: 18/11/2024

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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            timeNowControl.Visible = false;
            alarmClockControl.Visible = false;
            worldClockControl.Visible = false;
            stopWatchControl.Visible = false;
            timerControl.Visible = false;
        }

        private void btnTimeNow_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            alarmClockControl.Visible = false;
            worldClockControl.Visible = false;
            stopWatchControl.Visible = false;
            timerControl.Visible = false;

            timeNowControl.Visible = true;
        }

        private void btnAlarmClock_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            worldClockControl.Visible = false;
            timeNowControl.Visible = false;
            stopWatchControl.Visible = false;
            timerControl.Visible = false;

            alarmClockControl.Visible = true;
        }

        private void btnWorldClock_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            timeNowControl.Visible = false;
            alarmClockControl.Visible = false;
            stopWatchControl.Visible = false;
            timerControl.Visible = false;

            worldClockControl.Visible = true;
        }

        private void btnStopWatch_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            timeNowControl.Visible = false;
            alarmClockControl.Visible = false;
            worldClockControl.Visible = false;
            timerControl.Visible = false;

            stopWatchControl.Visible = true;
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;
            timeNowControl.Visible = false;
            worldClockControl.Visible = false;
            alarmClockControl.Visible = false;
            stopWatchControl.Visible = false;

            timerControl.Visible = true;
        }
    }
}
