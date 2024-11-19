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
    public partial class TimeNow : UserControl
    {
        public TimeNow()
        {
            InitializeComponent();
        }

        private void TimeNow_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDateNow.Text = DateTime.Now.ToLongDateString();
        }
    }
}
