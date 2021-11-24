using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace insulin_pump
{
    public partial class Clock : Form
    {

        public Clock(string time)
        {//test
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
          
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#11258C"); // set background of form to AAA safe contrast color
            label1.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set header color to AAA safe color
            Clock1.InnerColor = ColorTranslator.FromHtml("#304CD9"); // set inside of clock to AA safe color
            Clock1.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set inside of clock Text to AA safe color
            Clock1.ProgressColor = ColorTranslator.FromHtml("#71D91A"); // set clock progreess color to AA safe color
            Clock1.Text = time;
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 1000; //1000 ms == 1second
            timer1.Elapsed += Time_changed;
            timer1.Start();
        }

        private void Time_changed(object sender, ElapsedEventArgs e)
        {
            Clock1.Invoke((MethodInvoker)delegate
            {
                String time = Clock1.Text;//get unedited time
                Int32 count = 3;//amount to break apart the string
                String[] timeParts = time.Split(':', (char)count, (char)StringSplitOptions.RemoveEmptyEntries);//broken apart string

                Int32 seconds = int.Parse(timeParts[2]) + 1;
                Int32 minutes = int.Parse(timeParts[1]);
                Int32 hours = int.Parse(timeParts[0]);
                Int32 totalSeconds = (hours * 3600) + (minutes * 60) + seconds; // find percentage of time passed

                int percentage = (int)Math.Round((double)(100 * totalSeconds) / 86400);
                if (percentage <= 1)
                {
                    percentage = 1;
                }

                if (seconds == 60)
                {
                    seconds = 0;
                    minutes += 1;
                }
                if (minutes == 60)
                {
                    minutes = 0;
                    hours += 1;
                }
                if (hours == 24)
                {
                    hours = 0;
                }


                String newTime = $"{hours}:{minutes}:{seconds}";
                Clock1.Value = percentage;
                Clock1.Update();
                Clock1.Text = newTime;
            });
        }

        private void timeLbl_textChanged(object sender, EventArgs e)
        {

            throw new NotImplementedException();
        }

        private void Clock_Load(object sender, EventArgs e)
        {


        }
    }
}