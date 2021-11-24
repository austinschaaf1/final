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
        public Display1 display1 = new Display1();
        public Form1()
        {
            InitializeComponent();
            //Handling colors
            // Primary deep blue color 60% #11258C
            // AA friendly text color deep blue 60% #F0EBE6
            // Secondary light blue color 30% #304CD9
            // AA friendly text color light blue 30% #F0EBE6
            // seldom use action color green 10% #71D91A
            //Safe color for action green 10% black

            panelSide.BackColor = ColorTranslator.FromHtml("#304CD9"); // set background of left pannel to AA safe contrast color
            panelheader.BackColor = ColorTranslator.FromHtml("#304CD9"); // set background of top pannel to AA safe contrast color
            QuickNotificationlbl.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set quickNotificationlbl color to AA safe color
            Line.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set line color to AA safe color
            RemainingDoseslbl.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set remaining color to AA safe color
            BatterylvlLbl.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set battery level color to AA safe color
            testScenariosButton.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            testScenariosButton.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color

            btn_display_1.BackColor = ColorTranslator.FromHtml("#71D91A"); // set display 1 color to AA safe color
            btn_display_1.ForeColor = ColorTranslator.FromHtml("#000000");
            btn_display_1.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            btn_display_2.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set display 2 color to AA safe color
            btn_display_2.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Set text to safe color
            btn_display_2.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            btn_clock.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set Clock color to AA safe color
            btn_clock.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Set text to safe color
            btn_clock.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 1000; //1000 ms == 1second
            timer1.Elapsed += Time_changed;
            timer1.Start();
            loadform(display1);
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

        public void button1_Click(object sender, EventArgs e)
        {
            //The messages button has been clicked change the buttons
            btn_display_1.BackColor = ColorTranslator.FromHtml("#71D91A"); // set display 1 color to AA safe color
            btn_display_1.ForeColor = ColorTranslator.FromHtml("#000000");
            btn_display_1.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            btn_display_2.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set display 2 color to AA safe color
            btn_display_2.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Set text to safe color
            btn_display_2.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            btn_clock.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set Clock color to AA safe color
            btn_clock.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Set text to safe color
            btn_clock.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            loadform(display1);

        }

        private void btn_display_2_Click(object sender, EventArgs e)
        {
            //insilin diliver has been clicked change buttons
            btn_display_1.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set display 1 color to AA safe color
            btn_display_1.ForeColor = ColorTranslator.FromHtml("#F0EBE6");
            btn_display_1.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            btn_display_2.BackColor = ColorTranslator.FromHtml("#71D91A"); // set display 2 color to AA safe color
            btn_display_2.ForeColor = ColorTranslator.FromHtml("#000000"); // Set text to safe color
            btn_display_2.Font = new Font("Century Gothic", 14, FontStyle.Bold );

            btn_clock.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set Clock color to AA safe color
            btn_clock.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Set text to safe color
            btn_clock.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            loadform(new Display2());
        }

        private void btn_clock_Click(object sender, EventArgs e)
        {
            //Clock btn has been clicked change buttons
            btn_display_1.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set display 1 color to AA safe color
            btn_display_1.ForeColor = ColorTranslator.FromHtml("#F0EBE6");
            btn_display_1.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            btn_display_2.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set display 2 color to AA safe color
            btn_display_2.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Set text to safe color
            btn_display_2.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            btn_clock.BackColor = ColorTranslator.FromHtml("#71D91A"); // set Clock color to AA safe color
            btn_clock.ForeColor = ColorTranslator.FromHtml("#000000"); // Set text to safe color
            btn_clock.Font = new Font("Century Gothic", 14, FontStyle.Bold);
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






        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<TestScenarios>().Any())
            {
                TestScenarios form2 = new TestScenarios(this);
                form2.Show(this);
            }
        }

        ///Creating test push
    }
}
