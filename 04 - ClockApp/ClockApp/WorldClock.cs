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
    public partial class WorldClock : UserControl
    {
        public WorldClock()
        {
            InitializeComponent();
        }

        private void WorldClock_Load(object sender, EventArgs e)
        {
            // Populate the ComboBox with available time zones
            cmbBoxTimeZone.DataSource = TimeZoneInfo.GetSystemTimeZones()
                .Select(tz => tz.Id) // Use the ID for selection
                .ToList();

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cmbBoxTimeZone.SelectedItem != null)
            {
                string selectedTimeZoneId = cmbBoxTimeZone.SelectedItem.ToString();

                try
                {
                    // Retrieve the selected time zone
                    TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(selectedTimeZoneId);

                    // Convert the current time to the selected time zone
                    DateTime currentTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZone);

                    // Display the time
                    lblTimeNow.Text = $"Time in {timeZone.DisplayName}:\n{currentTime:hh:mm:ss tt}";
                }
                catch (TimeZoneNotFoundException)
                {
                    lblTimeNow.Text = "Invalid time zone selected.";
                }
                catch (Exception ex)
                {
                    lblTimeNow.Text = $"Error: {ex.Message}";
                }
            }
            else
            {
                lblTimeNow.Text = "Please select a time zone.";
            }
        }
       
    }
}
