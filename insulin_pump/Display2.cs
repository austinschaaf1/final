﻿using System;
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
        public Display2()
        {
            InitializeComponent();
            lastDoseTimeLabel.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void Display2_Load(object sender, EventArgs e)
        {
            

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
