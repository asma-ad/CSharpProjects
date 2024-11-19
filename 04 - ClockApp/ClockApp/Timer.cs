using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ClockApp
{
    public partial class Timer : UserControl
    {
        int seconds, minutes, hours;

        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;

            // Configure NotifyIcon
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipTitle = "Time's Up";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Text = "Time's up!";
            notifyIcon1.Visible = true;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
           // timer1.Stop();

            seconds = 0;
            minutes = 0;
            hours = 0;
            txtBoxPeriod.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Decrement seconds
            if (seconds > 0)
             {
                seconds--;
             }
            else
            {
               // Reset seconds and decrement minutes
               seconds = 59;
               if (minutes > 0)
               {
                  minutes--;
                }
               else
               {
                  // Reset minutes and decrement hours
                  minutes = 59;
                  if (hours > 0)
                  {
                    hours--;
                  }
                  else
                  {
                     // Timer complete
                     timer1.Stop();
                     seconds = 0;
                     minutes = 0;
                     hours = 0;
                     btnStart.Text = "Start";
                     notifyIcon1.BalloonTipText = "Time's up!";
                     notifyIcon1.ShowBalloonTip(3000);
                  }
               }
                
            }

            txtBoxPeriod.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnStart.Text = "Start";
            }
            else
            {
                if (seconds == 0 && minutes == 0 && hours == 0)
                {
                    hours = (int)nudHours.Value;
                    minutes = (int)nudMinutes.Value;
                    seconds = (int)nudSeconds.Value;

                    if (hours == 0 && minutes == 0 && seconds == 0)
                    {
                        MessageBox.Show("Please set a valid time!", "Error");
                        return;
                    }

                }

                timer1.Start();
                btnStart.Text = "Pause";
            }
        }

    }
}
