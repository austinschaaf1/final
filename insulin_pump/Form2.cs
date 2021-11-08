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



        Form1 form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private static Form2 inst;
        public static Form2 GetForm
        {
            get
            {
                if (inst == null || inst.IsDisposed)
                    inst = new Form2();
                return inst;
            }
        }

        private void removeNeedle_Click(object sender, EventArgs e)
        {

            Display1 display1 = new Display1();
            display1.LabelTextUpdate("Needle Has Been Removed!!");
        }


        private void removeInsulinResevoir_Click(object sender, EventArgs e)
        {
            Display1 display1 = new Display1();
            display1.LabelTextUpdate("Needle Has Been Removed!!");
            form1.loadform(display1);
            form1.Show();
        }
    }
}
