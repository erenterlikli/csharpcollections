﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();
        Form3 frm2 = new Form3();
        Form1 frm3 = new Form1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frm3.Close();
        }
    }
}
