﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Do_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int WhileValue = 0;
            do
            {
                MessageBox.Show(WhileValue.ToString());
                WhileValue = WhileValue + 1;
            }
            while (WhileValue < 5);

        }
    }
}