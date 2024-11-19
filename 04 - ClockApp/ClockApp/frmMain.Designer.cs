namespace ClockApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTimeNow = new System.Windows.Forms.Button();
            this.btnAlarmClock = new System.Windows.Forms.Button();
            this.btnWorldClock = new System.Windows.Forms.Button();
            this.btnStopWatch = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.timerControl = new ClockApp.Timer();
            this.stopWatchControl = new ClockApp.StopWatch();
            this.worldClockControl = new ClockApp.WorldClock();
            this.alarmClockControl = new ClockApp.AlarmClock();
            this.timeNowControl = new ClockApp.TimeNow();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimeNow
            // 
            this.btnTimeNow.BackColor = System.Drawing.Color.Plum;
            this.btnTimeNow.FlatAppearance.BorderSize = 0;
            this.btnTimeNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeNow.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeNow.ForeColor = System.Drawing.Color.Black;
            this.btnTimeNow.Location = new System.Drawing.Point(29, 76);
            this.btnTimeNow.Name = "btnTimeNow";
            this.btnTimeNow.Size = new System.Drawing.Size(169, 41);
            this.btnTimeNow.TabIndex = 0;
            this.btnTimeNow.Text = "Time now";
            this.btnTimeNow.UseVisualStyleBackColor = false;
            this.btnTimeNow.Click += new System.EventHandler(this.btnTimeNow_Click);
            // 
            // btnAlarmClock
            // 
            this.btnAlarmClock.BackColor = System.Drawing.Color.Plum;
            this.btnAlarmClock.FlatAppearance.BorderSize = 0;
            this.btnAlarmClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmClock.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmClock.ForeColor = System.Drawing.Color.Black;
            this.btnAlarmClock.Location = new System.Drawing.Point(29, 138);
            this.btnAlarmClock.Name = "btnAlarmClock";
            this.btnAlarmClock.Size = new System.Drawing.Size(169, 41);
            this.btnAlarmClock.TabIndex = 2;
            this.btnAlarmClock.Text = "Alarm Clock";
            this.btnAlarmClock.UseVisualStyleBackColor = false;
            this.btnAlarmClock.Click += new System.EventHandler(this.btnAlarmClock_Click);
            // 
            // btnWorldClock
            // 
            this.btnWorldClock.BackColor = System.Drawing.Color.Plum;
            this.btnWorldClock.FlatAppearance.BorderSize = 0;
            this.btnWorldClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorldClock.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorldClock.ForeColor = System.Drawing.Color.Black;
            this.btnWorldClock.Location = new System.Drawing.Point(29, 200);
            this.btnWorldClock.Name = "btnWorldClock";
            this.btnWorldClock.Size = new System.Drawing.Size(169, 41);
            this.btnWorldClock.TabIndex = 3;
            this.btnWorldClock.Text = "World Clock";
            this.btnWorldClock.UseVisualStyleBackColor = false;
            this.btnWorldClock.Click += new System.EventHandler(this.btnWorldClock_Click);
            // 
            // btnStopWatch
            // 
            this.btnStopWatch.BackColor = System.Drawing.Color.Plum;
            this.btnStopWatch.FlatAppearance.BorderSize = 0;
            this.btnStopWatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopWatch.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopWatch.ForeColor = System.Drawing.Color.Black;
            this.btnStopWatch.Location = new System.Drawing.Point(29, 262);
            this.btnStopWatch.Name = "btnStopWatch";
            this.btnStopWatch.Size = new System.Drawing.Size(169, 41);
            this.btnStopWatch.TabIndex = 4;
            this.btnStopWatch.Text = "StopWatch";
            this.btnStopWatch.UseVisualStyleBackColor = false;
            this.btnStopWatch.Click += new System.EventHandler(this.btnStopWatch_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.Plum;
            this.btnTimer.FlatAppearance.BorderSize = 0;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.Color.Black;
            this.btnTimer.Location = new System.Drawing.Point(29, 324);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(169, 41);
            this.btnTimer.TabIndex = 5;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timerControl);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.stopWatchControl);
            this.panel1.Controls.Add(this.worldClockControl);
            this.panel1.Controls.Add(this.alarmClockControl);
            this.panel1.Controls.Add(this.timeNowControl);
            this.panel1.Location = new System.Drawing.Point(226, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 288);
            this.panel1.TabIndex = 6;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tajawal Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(98, 124);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(228, 29);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome to ClockApp";
            // 
            // timerControl
            // 
            this.timerControl.Location = new System.Drawing.Point(38, 3);
            this.timerControl.Name = "timerControl";
            this.timerControl.Size = new System.Drawing.Size(334, 290);
            this.timerControl.TabIndex = 8;
            // 
            // stopWatchControl
            // 
            this.stopWatchControl.Location = new System.Drawing.Point(56, 3);
            this.stopWatchControl.Name = "stopWatchControl";
            this.stopWatchControl.Size = new System.Drawing.Size(305, 301);
            this.stopWatchControl.TabIndex = 3;
            // 
            // worldClockControl
            // 
            this.worldClockControl.Location = new System.Drawing.Point(3, 3);
            this.worldClockControl.Name = "worldClockControl";
            this.worldClockControl.Size = new System.Drawing.Size(408, 285);
            this.worldClockControl.TabIndex = 2;
            // 
            // alarmClockControl
            // 
            this.alarmClockControl.Location = new System.Drawing.Point(70, 3);
            this.alarmClockControl.Name = "alarmClockControl";
            this.alarmClockControl.Size = new System.Drawing.Size(291, 287);
            this.alarmClockControl.TabIndex = 1;
            // 
            // timeNowControl
            // 
            this.timeNowControl.Location = new System.Drawing.Point(57, 3);
            this.timeNowControl.Name = "timeNowControl";
            this.timeNowControl.Size = new System.Drawing.Size(291, 287);
            this.timeNowControl.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(675, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnStopWatch);
            this.Controls.Add(this.btnWorldClock);
            this.Controls.Add(this.btnAlarmClock);
            this.Controls.Add(this.btnTimeNow);
            this.Name = "frmMain";
            this.Text = "ClockApp";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimeNow;
        private System.Windows.Forms.Button btnAlarmClock;
        private System.Windows.Forms.Button btnWorldClock;
        private System.Windows.Forms.Button btnStopWatch;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Panel panel1;
        private TimeNow timeNowControl;
        private AlarmClock alarmClockControl;
        private WorldClock worldClockControl;
        private StopWatch stopWatchControl;
        private System.Windows.Forms.Label lblWelcome;
        private Timer timerControl;
    }
}

