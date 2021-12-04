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
    public partial class TestScenarios : Form
    {

        int resevoirRemoval = 0;
        int needleRemoval = 0;
        int batteryLow = 0;
        int sensorFailure = 0;
        int pumpFailure = 0;
        int deliveryFailing = 0;


        Form1 mainForm;


        public TestScenarios(Form1 passedForm)
        {
            InitializeComponent();
            this.mainForm = passedForm;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "HH':'mm':'ss";
            dateTimePicker1.ShowUpDown = true;
            this.BackColor = ColorTranslator.FromHtml("#304CD9");
            resetButton.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            resetButton.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color
            runTestButton.BackColor = ColorTranslator.FromHtml("#4D8C18"); // set test senarios color to AA safe color
            runTestButton.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // Test start out white color

            insulinLevelsNumBox.Controls.RemoveAt(0);
            insulinLevelsNumBox.Value = decimal.Parse(mainForm.display2.getInsulinLevelAmount());


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        

        private void runTestButton_Click(object sender, EventArgs e)
        {


            if (setTimeCheckBox.Checked == true)
            {
                mainForm.timeUpdateTestS(dateTimePicker1.Text);
                mainForm.display2.setInsulinLevelAmount(insulinLevelsNumBox.Value);
                mainForm.setQNLabels();
            }

            if (insulinLevelsToggle.Checked == true)
            {
                mainForm.display2.setInsulinLevelAmount(insulinLevelsNumBox.Value);
                mainForm.display2.setLastChartPoint(insulinLevelsNumBox.Value);
                mainForm.setQNLabels();
            }

            if(resevoirRefillToggle.Checked == true)
            {
                mainForm.display2.resevoirRefill();
            }

            if (resevoirRemoval == 1)
            {
                
                mainForm.display1.resevoirUpdate("The user has removed the insulin resevoir");
                
            }

            if (resevoirRemoval == 0)
            {
                mainForm.display1.resevoirReset();
            }

            if (needleRemoval == 1)
            {
                mainForm.display1.needleUpdate("The user has removed the needle assembly");
            }

            if (needleRemoval == 0)
            {
                mainForm.display1.needleReset();
            }

            if (batteryLow == 1)
            {
                mainForm.display1.batteryUpdate("The voltage of the battery has fallen to less than 0.5V");
            }

            if (batteryLow == 0)
            {
                mainForm.display1.batteryReset();
            }

            if (sensorFailure == 1)
            {
                mainForm.display1.sensorUpdate("The self-test of the sugar sensor has resulted in an error");
            }

            if (sensorFailure == 0)
            {
                mainForm.display1.sensorReset();
            }

            if (pumpFailure == 1)
            {
                mainForm.display1.pumpUpdate("The self-test of the pump has resulted in an error");
            }

            if (pumpFailure == 0)
            {
                mainForm.display1.pumpReset();
            }

            if (deliveryFailing == 1)
            {
                mainForm.display1.deliveryUpdate("It has not been possible to deliver the specified amount of insulin");
            }

            if (deliveryFailing == 0)
            {
                mainForm.display1.deliveryReset();
            }

            if (lowInsulinLevelToggle.Checked == true)
            {
                mainForm.display1.insulinLevelUpdate("The level of insulin is low. Change resevoir");
            }

            if (lowInsulinLevelToggle.Checked == false)
            {
                mainForm.display1.insulinLevelsReset();
            }



        

    }

        private void resevoirToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (resevoirRemoval == 0)
            {
                resevoirRemoval = 1;
                return;
            }

            if (resevoirRemoval == 1)
            {
                resevoirRemoval = 0;
                return;
            }
        }

        private void needleToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (needleRemoval == 0)
            {
                needleRemoval = 1;
                return;
            }

            if (needleRemoval == 1)
            {
                needleRemoval = 0;
                return;
            }
        }

        private void batteryToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (batteryLow == 0)
            {
                batteryLow = 1;
                return;
            }

            if (batteryLow == 1)
            {
                batteryLow = 0;
                return;
            }
        }

        private void sensorToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (sensorFailure == 0)
            {
                sensorFailure = 1;
                return;
            }

            if (sensorFailure == 1)
            {
                sensorFailure = 0;
                return;
            }
        }

        private void pumpToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (pumpFailure == 0)
            {
                pumpFailure = 1;
                return;
            }

            if (pumpFailure == 1)
            {
                pumpFailure = 0;
                return;
            }
        }

        private void deliveryToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (deliveryFailing == 0)
            {
                deliveryFailing = 1;
                return;
            }

            if (deliveryFailing == 1)
            {
                deliveryFailing = 0;
                return;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

            resevoirToggle.Checked = false;
            needleToggle.Checked = false;
            batteryToggle.Checked = false;
            sensorToggle.Checked = false;
            pumpToggle.Checked = false;
            deliveryToggle.Checked = false;
            setTimeCheckBox.Checked = false;
            insulinLevelsToggle.Checked = false;
            lowInsulinLevelToggle.Checked = false;
            resevoirRefillToggle.Checked = false;
            mainForm.display1.resevoirReset();
            mainForm.display1.needleReset();
            mainForm.display1.batteryReset();
            mainForm.display1.sensorReset();
            mainForm.display1.pumpReset();
            mainForm.display1.deliveryReset();
            mainForm.display1.resevoirRefillReset();
               
        }

        private void setTimeCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (setTimeCheckBox.Checked == true)
            {
                dateTimePicker1.Enabled = true;
            }

            if (setTimeCheckBox.Checked == false)
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void insulinLevelsToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(insulinLevelsToggle.Checked == true)
            {
                insulinLevelsNumBox.Enabled = true;
            }

            if(insulinLevelsToggle.Checked == false)
            {
                insulinLevelsNumBox.Enabled = false;
            }


        }

        private void lowInsulinLevelToggle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void resevoirRefillToggle_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
