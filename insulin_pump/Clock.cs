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
        //This code creates a clock object and changes the clock time as well as increments a progress bar
        public Clock(string time)
        {//Clock has 1 parameter which is the incomming time from form 1
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
          
            InitializeComponent();
            //Below sets background colors of diffent objects
            this.BackColor = ColorTranslator.FromHtml("#11258C"); // set background of form to AAA safe contrast color
            label1.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set header color to AAA safe color
            Clock1.InnerColor = ColorTranslator.FromHtml("#304CD9"); // set inside of clock to AA safe color
            Clock1.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set inside of clock Text to AA safe color
            Clock1.ProgressColor = ColorTranslator.FromHtml("#71D91A"); // set clock progreess color to AA safe color
         
            Clock1.Text = time;//Set the anolog time on the clock based on the form 1 clock
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 1000; //1000 ms == 1second
            timer1.Elapsed += Time_changed;//Everytime 1 seconds time_changed() will be called
            timer1.Start();
        }

        private void Time_changed(object sender, ElapsedEventArgs e)
        {
            Clock1.Invoke((MethodInvoker)delegate
            {
                String time = Clock1.Text;//get unedited time
                Int32 count = 3;//amount of segments to break the clock time apart by
                String[] timeParts = time.Split(':', (char)count, (char)StringSplitOptions.RemoveEmptyEntries);//Split the time string based on colons
                String minutesString = "";
                String secondsString = "";
                String hoursString = "";

                //Get int version of seconds, minutes, hours and increment seconds
                Int32 seconds = int.Parse(timeParts[2]) + 1;
                Int32 minutes = int.Parse(timeParts[1]);
                Int32 hours = int.Parse(timeParts[0]);

                //Find total amount of seconds passed
                Int32 totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

                //Get the percent of the day passed for the clock progression bar
                int percentage = (int)Math.Round((double)(100 * totalSeconds) / 86400);
                if (percentage <= 1)
                {//This allows a little bit of progression to be shown on the clock if less than a percent of the day has passed
                    percentage = 1;
                }
                if (seconds == 60)
                {//if seconds is 60 set seconds to zero and increment minutes
                    seconds = 0;
                    minutes += 1;
                }
                if (minutes == 60)
                {//if minutes is 60 set minutes to zero and increment hours
                    minutes = 0;
                    hours += 1;
                }
                if (hours == 24)
                {//if 24 hours has past set hours to zero
                    hours = 0;
                }

                //The below lines check if seconds,minutes,hours is less then 10, if it is add a leading zero so 1 = 01 
                minutesString = minutes.ToString();
                secondsString = seconds.ToString();
                hoursString = hours.ToString();
                if(hours < 10)
                {
                    hoursString = "0"+ hoursString;
                }
                if (seconds < 10) {
                    secondsString = "0" + secondsString;
                }
                if (minutes < 10) {
                    minutesString = "0" + minutesString;
                }
        
                String newTime = $"{hoursString}:{minutesString}:{secondsString}";//Properly format clock time
                Clock1.Value = percentage; //Update progression bar
                Clock1.Update();
                Clock1.Text = newTime;//Enter in new anolog time
            });
        }


        private void timeLbl_textChanged(object sender, EventArgs e)
        {

            throw new NotImplementedException();
        }
        public void timeUpdateTestS2(String messageText)
        {
            Clock1.Text = messageText;
            
        }
        private void Clock_Load(object sender, EventArgs e)
        {
        }
    }
}