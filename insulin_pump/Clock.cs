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
    public partial class Clock : Form
    {
        Form1 timefm1;
        public Clock(Form1 timefm3) 
        {//test
            
            InitializeComponent();
            timefm1 = timefm3;
            Clock1.Text = timefm1.timeLbl.Text;
            timefm1.timeLbl.TextChanged += new EventHandler(timeLbl_textChanged);
            //timeLbl.TextChanged += new EventHandler(timeLbl_textChanged);
        }

        private void timeLbl_textChanged(object sender, EventArgs e)
        {
            
            throw new NotImplementedException();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            //
           // Clock1.Invoke((MethodInvoker)delegate
          ///  {
                
               // Clock1.Text = clockfrm.timeLbl.Text;
           // }
           // );
           
        }
    }
}
