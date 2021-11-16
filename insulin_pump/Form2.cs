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
    public partial class Form2 : Form
    {

        int resevoirRemoval = 0;
        int needleRemoval = 0;
        int batteryLow = 0;
        int sensorFailure = 0;
        int pumpFailure = 0;
        int deliveryFailing = 0;
        Display1 display1 = new Display1();



        Form1 form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private static Form2 inst;



        private void runTestButton_Click(object sender, EventArgs e)
        {

            if (resevoirRemoval == 1)
            {
                display1.resevoirUpdate("Error in Resevoir!");
            }

            if (resevoirRemoval == 0)
            {
                display1.resevoirReset();
            }

            if (needleRemoval == 1)
            {
                display1.needleUpdate("Error in Needle!");
            }

            if (needleRemoval == 0)
            {
                display1.needleReset();
            }

            if (batteryLow == 1)
            {
                display1.batteryUpdate("Warning! Battery Low");
            }

            if (batteryLow == 0)
            {
                display1.batteryReset();
            }

            if(sensorFailure == 1)
            {
                display1.sensorUpdate("Error in Sensor!");
            }

            if (sensorFailure == 0)
            {
                display1.sensorReset(); 
            }

            if(pumpFailure == 1)
            {
                display1.pumpUpdate("Error in Pump!");
            }

            if (pumpFailure == 0)
            {
                display1.pumpReset();
            }

            if(deliveryFailing == 1)
            {
                display1.deliveryUpdate("Error in Insulin Delivery!");
            }

            if (deliveryFailing == 0)
            {
                display1.deliveryReset();
            }


            form1.loadform(display1);
            form1.Show();



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
    }
}
