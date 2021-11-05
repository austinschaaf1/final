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
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 1000; //1000 ms == 1second
            timer1.Elapsed += Time_changed;
            timer1.Start();
            InitializeComponent();
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
            timeLbl.Invoke((MethodInvoker)delegate
            {
               
                TimeSpan FormatedTime = TimeSpan.FromSeconds(1);
                
                string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                FormatedTime.Hours,
                FormatedTime.Minutes,
                FormatedTime.Seconds,
                FormatedTime.Milliseconds);
                timeLbl.Text = (answer).ToString();
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            loadform(new Clock());
        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }


        ///Creating test push
    }
}
