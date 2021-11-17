using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace insulin_pump


   
{

  

    public partial class Form1 : Form
    {


        public int setDisplayFlagOne()
        {
            return 1;
        }

        int displayFlag = 0;


        public Form1()
        {//test
            InitializeComponent();
            System.Timers.Timer timer1 = new System.Timers.Timer();
            //TimeSpan start = DateTime.Now;
            timer1.Interval = 1000; //1000 ms == 1second
            timer1.Elapsed += Time_changed;
            timer1.Start();
        }
        public void loadform(object Form) {
            if (this.mainpanel.Controls.Count > 0) {
                this.mainpanel.Controls.RemoveAt(0);   
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Time_changed(object sender, ElapsedEventArgs e)
        {
            try
            {
                timeLbl.Invoke((MethodInvoker)delegate
                {
                    String time = timeLbl.Text;//get unedited time
                    Int32 count = 3;//amount to break apart the string
                    String[] timeParts = time.Split(':', (char)count, (char)StringSplitOptions.RemoveEmptyEntries);//broken apart string

                    Int32 seconds = int.Parse(timeParts[2]) + 1;
                    Int32 minutes = int.Parse(timeParts[1]);
                    Int32 hours = int.Parse(timeParts[0]);
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
                    timeLbl.Text = newTime;
                });
            }
            catch { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string TimeLlbText
        {
            get
            {
                return this.timeLbl.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Display1());

        }

        private void btn_display_2_Click(object sender, EventArgs e)
        {
            loadform(new Display2());
        }

        private void btn_clock_Click(object sender, EventArgs e)
        {
            loadform(new Clock(timeLbl.Text));
        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void testScenarioButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.FormClosed += (s,args) => this.Close();
            form2.Show();



        }

   

        ///Creating test push
    }
}
