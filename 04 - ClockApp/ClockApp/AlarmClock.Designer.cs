namespace ClockApp
{
    partial class AlarmClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimeNow = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.dtpSetAlarm = new System.Windows.Forms.DateTimePicker();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // lblTimeNow
            // 
            this.lblTimeNow.AutoSize = true;
            this.lblTimeNow.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeNow.ForeColor = System.Drawing.Color.White;
            this.lblTimeNow.Location = new System.Drawing.Point(130, 79);
            this.lblTimeNow.Name = "lblTimeNow";
            this.lblTimeNow.Size = new System.Drawing.Size(91, 26);
            this.lblTimeNow.TabIndex = 4;
            this.lblTimeNow.Text = "Time Now";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Freestyle Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Plum;
            this.lblTitle.Location = new System.Drawing.Point(25, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 76);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Alarm Clock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time Now :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set Alarm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Remaining time :";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.Font = new System.Drawing.Font("Tajawal", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingTime.ForeColor = System.Drawing.Color.White;
            this.lblRemainingTime.Location = new System.Drawing.Point(77, 180);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(144, 26);
            this.lblRemainingTime.TabIndex = 8;
            this.lblRemainingTime.Text = "Remaining time :";
            // 
            // dtpSetAlarm
            // 
            this.dtpSetAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpSetAlarm.Location = new System.Drawing.Point(134, 118);
            this.dtpSetAlarm.Name = "dtpSetAlarm";
            this.dtpSetAlarm.Size = new System.Drawing.Size(87, 20);
            this.dtpSetAlarm.TabIndex = 9;
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSetAlarm.FlatAppearance.BorderSize = 0;
            this.btnSetAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAlarm.ForeColor = System.Drawing.Color.White;
            this.btnSetAlarm.Location = new System.Drawing.Point(34, 230);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(101, 26);
            this.btnSetAlarm.TabIndex = 10;
            this.btnSetAlarm.Text = "Set Alarm";
            this.btnSetAlarm.UseVisualStyleBackColor = false;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // btnRest
            // 
            this.btnRest.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRest.FlatAppearance.BorderSize = 0;
            this.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRest.ForeColor = System.Drawing.Color.White;
            this.btnRest.Location = new System.Drawing.Point(150, 230);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(101, 26);
            this.btnRest.TabIndex = 11;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = false;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // AlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnSetAlarm);
            this.Controls.Add(this.dtpSetAlarm);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTimeNow);
            this.Controls.Add(this.lblTitle);
            this.Name = "AlarmClock";
            this.Size = new System.Drawing.Size(291, 287);
            this.Load += new System.EventHandler(this.AlarmClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeNow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.DateTimePicker dtpSetAlarm;
        private System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
