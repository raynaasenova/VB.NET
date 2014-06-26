using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3if_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool isBilled = true;
            bool isLate = false;
            bool isDone;
            isDone = isBilled && !isLate;
            MessageBox.Show(isDone.ToString());
        } 
    }
}
