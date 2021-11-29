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
using System.IO;

namespace insulin_pump
{
    public partial class Form1 : Form
    {
        
        public Display1 display1 = new Display1();
        public Display2 display2 = new Display2();
        public Int32 isClockOpen = 0;
        public Int32 whatIsOpen = 0;//0=display1 1= display2  2 = clock 3= help 4 = settings
        public Int32 isHelpOpen = 0;
        public Int32 isSettingsOpen = 0;
        public Int32 insulinAlarm = 0; // 0== normal 1 == low 2 == high
        
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
            
            DateTime dt = DateTime.Now;
            dt.ToString("HH:mm:ss");
            timeLbl.Text = dt.ToString("HH:mm:ss");


            panelSide.BackColor = ColorTranslator.FromHtml("#304CD9"); // set background of left pannel to AA safe contrast color
            panelheader.BackColor = ColorTranslator.FromHtml("#304CD9"); // set background of top pannel to AA safe contrast color
            QuickNotificationlbl.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set quickNotificationlbl color to AA safe color
            Line.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set line color to AA safe color
            RemainingDoseslbl.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set remaining color to AA safe color
            BatterylvlLbl.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set battery level color to AA safe color
            InsilunWarning.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set battery level color to AA safe color

            testScenariosButton.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            testScenariosButton.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            battryLbl.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set battry color to AA safe color

            btn_display_1.BackColor = ColorTranslator.FromHtml("#71D91A"); // set display 1 color to AA safe color
            btn_display_1.ForeColor = ColorTranslator.FromHtml("#000000");
            btn_display_1.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            btn_display_2.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set display 2 color to AA safe color
            btn_display_2.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Set text to safe color
            btn_display_2.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            btn_clock.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set Clock color to AA safe color
            btn_clock.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Set text to safe color
            btn_clock.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            Helpbtn.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set help color to AA safe color
            Helpbtn.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Set text to safe color

            settingbtn.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set help color to AA safe color
            settingbtn.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Set text to safe color

            display2.generateChartPoints(timeLbl.Text);
            remainingDosesQNLabel.Text = display2.getInsulinDosesAmount();
            resevoirDosesRemainingQNLabel.Text = display2.getResevoirRemainingAmount();



            whatIsOpen = 0;//display 1 is open
            isSettingsOpen = 0;
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 1000; //1000 ms == 1second
            timer1.Elapsed += Time_changed;
            timer1.Start();
            loadform(display1);
        }

        public void setQNLabels()
        {
            remainingDosesQNLabel.Text = display2.getRemainingDosesQN();
            resevoirDosesRemainingQNLabel.Text = display2.getRemaningResevoirQN();
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
                    remainingDosesQNLabel.Text = display2.getRemainingDosesQN();
                    resevoirDosesRemainingQNLabel.Text = display2.getRemaningResevoirQN();
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

                    string insulin_level = display2.getInsulinLevelAmount();
                    if (float.Parse(insulin_level) < 70 && insulinAlarm != 1)
                    {
                        InsilunWarning.Text = "Insulin Level Low Alarm!";
                        InsilunWarning.ForeColor = ColorTranslator.FromHtml("#71D91A"); // set insulin warning level color to AA safe color
                        string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\insulin_pump\Resorses\levelLow.wav");
                        string sFilePath = Path.GetFullPath(sFile);
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(sFilePath);
                        player.Play();
                        insulinAlarm = 1;
                    }
                    else if (float.Parse(insulin_level) > 160 && insulinAlarm != 2)
                    {
                        InsilunWarning.Text = "Insulin Level high Alarm!";
                        InsilunWarning.ForeColor = ColorTranslator.FromHtml("#71D91A"); // set insulin warning level color to AA safe color
                        string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                        string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\insulin_pump\Resorses\LevelHigh.wav");
                        string sFilePath = Path.GetFullPath(sFile);
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(sFilePath);
                        player.Play();
                        insulinAlarm = 2;
                    }
                    else if (float.Parse(insulin_level) <= 160 && float.Parse(insulin_level) >= 70 && insulinAlarm != 0) {
                        InsilunWarning.Text = "Insulin Level Acceptable";
                        insulinAlarm = 0;
                        InsilunWarning.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set insulin warning level color to AA safe color
                    }
                    

                        if (timeLbl.Text == "23:59:59")
                    {
                        display2.setRemainingDosesMax();
                    }
                    if ((minutes == 00 && seconds == 00) || (minutes == 10 && seconds == 00) || (minutes == 20 && seconds == 00) || (minutes == 30 && seconds == 00) || (minutes == 40 && seconds == 00) || (minutes == 50 && seconds == 00)) {
                        display2.autoModeCheck();


                    }

                });
            }
            catch { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void timeUpdateTestS(String messageText)
        {
            timeLbl.Text = messageText;
            display2.generateChartPoints(messageText);
            if (isClockOpen == 1)
            {
                loadform(new Clock(messageText));
            }
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
            isClockOpen = 0;
            whatIsOpen = 0; // display 1 is open
            isHelpOpen = 0;//clicking this will close help page
            isSettingsOpen = 0;
            Helpbtn.Text = "Help";
            settingbtn.Text = "Settings";

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
            loadform(display2);
            isClockOpen = 0;
            whatIsOpen = 1; //display2 is open
            isHelpOpen = 0;//clicking this will close help page
            isSettingsOpen = 0;
            Helpbtn.Text = "Help";
            settingbtn.Text = "Settings";
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
            isClockOpen = 1;
            whatIsOpen = 2;// clock is open
            isHelpOpen = 0;//clicking this will close help page
            isSettingsOpen = 0;
            Helpbtn.Text = "Help";
            settingbtn.Text = "Settings";
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

        private void Helpbtn_Click(object sender, EventArgs e)
        {
            if (whatIsOpen == 0 && isHelpOpen == 0)
            {
                loadform(new messageHelp());
                Helpbtn.Text = "Close help page";
                isHelpOpen = 1;
            }
            else if (whatIsOpen == 1 && isHelpOpen == 0)
            {
                loadform(new insilinHelp());
                Helpbtn.Text = "Close help page";
                isHelpOpen = 1;
            }
            else if (whatIsOpen == 2 && isHelpOpen == 0) {
                loadform(new clockHelp());
                Helpbtn.Text = "Close help page";
                isHelpOpen = 1;
            }
            else if (whatIsOpen == 4 && isHelpOpen == 0)
            {
                loadform(new messageHelp());
                Helpbtn.Text = "Close help page";
                isHelpOpen = 1;
            }

            else if (whatIsOpen == 0 && isHelpOpen == 1)
            {
                loadform(display1);
                Helpbtn.Text = "Help";
                isHelpOpen = 0;
            }
            else if (whatIsOpen == 1 && isHelpOpen == 1)
            {
                loadform(new Display2());
                Helpbtn.Text = "Help";
                isHelpOpen = 0;
            }
            else if (whatIsOpen == 2 && isHelpOpen == 1)
            {
                loadform(new Clock(timeLbl.Text));
                Helpbtn.Text = "Help";
                isHelpOpen = 0;
            }
            else if (whatIsOpen == 4 && isHelpOpen == 1)
            {
                loadform(new settings());
                Helpbtn.Text = "Help";
                isHelpOpen = 0;
            }
        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
         
                loadform(new settings());
                whatIsOpen = 4;
   
     
            Helpbtn.Text = "Help";




        }

        ///Creating test push
    }
}
