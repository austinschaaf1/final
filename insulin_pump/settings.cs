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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#11258C"); // set background of form to AAA safe contrast color
            hdrLbl.ForeColor = ColorTranslator.FromHtml("#F0EBE6"); // set header color to AAA safe color
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            popup.Text = "This is a beta feature and settings will not be applied at this time";
        }
    }
}
