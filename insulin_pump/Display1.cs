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
    public partial class Display1 : Form
    {
        public Display1()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#11258C"); // set background of form to AAA safe contrast color
        }

        public void resevoirUpdate(String messageText)
        {
            resevoirSystemLabel.Text = messageText;
            resevoirLight.Image = insulin_pump.Properties.Resources.red;
        }
        public void needleUpdate(String messageText)
        {
            needleSystemLabel.Text = messageText;
            needleLight.Image = insulin_pump.Properties.Resources.red;
        }
        public void batteryUpdate(String messageText)
        {
            batterySystemLabel.Text = messageText;
            batteryLight.Image = insulin_pump.Properties.Resources.red;
        }
        public void sensorUpdate(String messageText)
        {
            sensorSystemLabel.Text = messageText;
            sensorLight.Image = insulin_pump.Properties.Resources.red;
        }

        public void pumpUpdate(String messageText)
        {
            pumpSystemLabel.Text = messageText;
            pumpLight.Image = insulin_pump.Properties.Resources.red;
        }

        public void deliveryUpdate(String messageText)
        {
            deliverySystemLabel.Text = messageText;
            deliveryLight.Image = insulin_pump.Properties.Resources.red;
        }

        public void resevoirReset()
        {
            resevoirSystemLabel.Text = "Status OK!";
            resevoirLight.Image = insulin_pump.Properties.Resources.green;
        }
        public void needleReset()
        {
            needleSystemLabel.Text = "Status OK!";
            needleLight.Image = insulin_pump.Properties.Resources.green;
        }
        public void batteryReset()
        {
            batterySystemLabel.Text = "Status OK!";
            batteryLight.Image = insulin_pump.Properties.Resources.green;
        }
        public void sensorReset()
        {
            sensorSystemLabel.Text = "Status OK!";
            sensorLight.Image = insulin_pump.Properties.Resources.green;
        }

        public void pumpReset()
        {
            pumpSystemLabel.Text = "Status OK!";
            pumpLight.Image = insulin_pump.Properties.Resources.green;
        }

        public void deliveryReset()
        {
            deliverySystemLabel.Text = "Status OK!";
            deliveryLight.Image = insulin_pump.Properties.Resources.green;
        }

    






        private void roundPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void resevoirLight_Click(object sender, EventArgs e)
        {

        }
    }
}
