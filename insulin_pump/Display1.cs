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
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        public void LabelTextUpdate(string messageText)
        {

            this.label3.Text = messageText;
            
        }
    }
}
