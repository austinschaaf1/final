using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insulin_pump
{
    public partial class Display2 : Form
    {
        //Form1 mainForm;
        int counter;
        Int32 autoM = 0;
        public Display2()
        {
            InitializeComponent();
            //this.mainForm = passedForm;
            this.BackColor = ColorTranslator.FromHtml("#11258C"); // set background of form to AAA safe contrast color
            lastDoseTimeLabel.Text = DateTime.Now.ToLocalTime().ToString();
            administerInsulinButton.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            administerInsulinButton.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            runAutoButton.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            runAutoButton.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            runAutoButton.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            runManualButton.BackColor = ColorTranslator.FromHtml("#71D91A"); // set test senarios color to AA safe color
            runManualButton.ForeColor = ColorTranslator.FromHtml("#000000"); // Test start out white color
            runManualButton.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            offBtn.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            offBtn.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            offBtn.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            


        }

        public void generateChartPoints(string text)
        {
            insulinDosingChart.Series[0].Points.Clear();

            String time = text;//get unedited time
            Int32 count = 3;//amount to break apart the string
            String[] timeParts = time.Split(':', (char)count, (char)StringSplitOptions.RemoveEmptyEntries);
            Int32 hours = int.Parse(timeParts[0]);

            Random rand = new Random();
            counter = 0;
            int insert = 0;
            int holder;
            int resevoir = 100;
            int lastDose = 0;
            int dailyIntake = 0;

            for (int i = 0; i < hours; i++)
            {
           
                if(insert == 0)
                {
                    
                    holder = rand.Next(20, 300);
                    insulinDosingChart.Series[0].Points.AddXY(i,holder);
                    if (holder >= 160)
                    {
                        lastDose = 0;
                    }
                    while (holder >= 160)
                    {
                        holder -= 50;
                        resevoir--;
                        lastDose++;
                        dailyIntake++;
                    }
                    insert = holder;
                    counter++;
                    continue;
                }
                insulinDosingChart.Series[0].Points.AddXY(i, insert);
                insert = 0;
                counter++;
            }
            remainingDosesAmountLabel.Text = (24 - dailyIntake).ToString();
            lastDoseAmountLabel.Text = lastDose.ToString();
            resevoirRemainingAmountLabel.Text = resevoir.ToString();
            insulinDosingChart.Series[0].Points.AddXY(counter,double.Parse(insulinLevelAmountLabel.Text));
            insulinDosingChart.Refresh();
        }

        public string getRemainingDosesQN()
        {
            string text = remainingDosesAmountLabel.Text;
            return text;
        }

        public string getRemaningResevoirQN()
        {
            string text = resevoirRemainingAmountLabel.Text;
            return text;
        }

        public string getInsulinDosesAmount()
        {
            string text = remainingDosesAmountLabel.Text;
            return text;
        }

        public string getInsulinLevelAmount()
        {
            string val = insulinLevelAmountLabel.Text;
            return val;
        }

        public string getResevoirRemainingAmount()
        {
            string val = resevoirRemainingAmountLabel.Text;
            return val;
        }

        public void setInsulinLevelAmount(Decimal val)
        {
            String text = val.ToString();
            insulinLevelAmountLabel.Text = text;
        }

        public void setRemainingDosesMax()
        {
            remainingDosesAmountLabel.Text = 24.ToString();
        }


        public void setLastChartPoint(Decimal val)
        {
            insulinDosingChart.Series[0].Points[counter].YValues[0] = (double)val;
            insulinDosingChart.Refresh();
        }

        public void setErrorInvisible()
        {
            administerErrorLabel.Visible = false;
        }

        public void autoModeCheck() {
            if (float.Parse(insulinLevelAmountLabel.Text) >= 160 && int.Parse(remainingDosesAmountLabel.Text) > 0 && autoM == 1)
            {
                insulinLevelAmountLabel.Text = (float.Parse(insulinLevelAmountLabel.Text) - 50).ToString();
                remainingDosesAmountLabel.Text = (int.Parse(remainingDosesAmountLabel.Text) - 1).ToString();
                resevoirRemainingAmountLabel.Text = (int.Parse(resevoirRemainingAmountLabel.Text) - 1).ToString();
                insulinDosingChart.Series[0].Points[counter].YValues[0] = int.Parse(insulinLevelAmountLabel.Text);
                insulinDosingChart.Refresh();
                return;

            }
        }

        private void Display2_Load(object sender, EventArgs e)
        {
            

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lastDoseTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void administerInsulinButton_Click(object sender, EventArgs e)
        {

            var t = new Timer();
            t.Interval = 5000;
            

            administerErrorLabel.Visible = false;
            if (float.Parse(insulinLevelAmountLabel.Text) >= 160 && int.Parse(remainingDosesAmountLabel.Text) >0)
            {
                insulinLevelAmountLabel.Text = (float .Parse(insulinLevelAmountLabel.Text) - 50).ToString();
                remainingDosesAmountLabel.Text = (int.Parse(remainingDosesAmountLabel.Text)-1).ToString();
                resevoirRemainingAmountLabel.Text = (int.Parse(resevoirRemainingAmountLabel.Text)-1).ToString();
                insulinDosingChart.Series[0].Points[counter].YValues[0] = int.Parse(insulinLevelAmountLabel.Text);
                insulinDosingChart.Refresh();
                return;

            }
            administerErrorLabel.Text = "Cannot Administer Insulin: Levels are acceptable";
            administerErrorLabel.Visible = true;
            t.Tick += (s, c) =>
            {
                administerErrorLabel.Visible = false;
            };
            t.Start();

            

        }

        private void offBtn_Click(object sender, EventArgs e)
        {
            administerInsulinButton.Enabled = false;

            runAutoButton.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            runAutoButton.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            runAutoButton.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            runManualButton.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            runManualButton.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            runManualButton.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            offBtn.BackColor = ColorTranslator.FromHtml("#71D91A"); // set test senarios color to AA safe color
            offBtn.ForeColor = ColorTranslator.FromHtml("#000000"); // Test start out white color
            offBtn.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            autoM = 0;
        }

        private void runManualButton_Click(object sender, EventArgs e)
        {
            administerInsulinButton.Enabled = true;

            runAutoButton.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            runAutoButton.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            runAutoButton.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            runManualButton.BackColor = ColorTranslator.FromHtml("#71D91A"); // set test senarios color to AA safe color
            runManualButton.ForeColor = ColorTranslator.FromHtml("#000000"); // Test start out white color
            runManualButton.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            offBtn.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            offBtn.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            offBtn.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            autoM = 0;
        }

        private void runAutoButton_Click(object sender, EventArgs e)
        {
            administerInsulinButton.Enabled = false;

            runAutoButton.BackColor = ColorTranslator.FromHtml("#71D91A"); // set test senarios color to AA safe color
            runAutoButton.ForeColor = ColorTranslator.FromHtml("#000000"); // Test start out white color
            runAutoButton.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            runManualButton.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            runManualButton.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            runManualButton.Font = new Font("Century Gothic", 12, FontStyle.Bold);

            offBtn.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            offBtn.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            offBtn.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            autoM = 1;
        }

        public void resevoirRefill()
        {
            resevoirRemainingAmountLabel.Text = 100.ToString();
        }
    }
}
