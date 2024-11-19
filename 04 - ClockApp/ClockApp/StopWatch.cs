using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Threading;

namespace ClockApp
{
    public partial class StopWatch : UserControl
    {
        int milliseconds = 0, seconds = 0, minutes = 0, hours = 0;

        public StopWatch()
        {
            InitializeComponent();
        }

        private void btnRest_Click(object sender, EventArgs e)
        { 
             timer1.Stop();

             milliseconds = 0;
             seconds = 0;
             minutes = 0;
             hours = 0;
             lblStopWatch.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}:{milliseconds:D2}";    
        }

        private void StopWatch_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Toggle between Start and Stop functionality
            if (timer1.Enabled)
            {
                timer1.Stop();  
                btnStart.Text = "Start";  
            }
            else
            {
                timer1.Start();  
                btnStart.Text = "Stop";  
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            milliseconds += 10;  // Increment by 10 since the interval is 10ms

            if (milliseconds == 1000)
            {
                seconds++;
                milliseconds = 0;
            }
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes == 60)
            {
                hours++;
                minutes = 0;
            }

            lblStopWatch.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}:{milliseconds:D2}";
        }
    }
}
