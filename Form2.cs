﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viktorina
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 jautājumi = new Form3();
            jautājumi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 jautājumi = new Form4();
            jautājumi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 jautājumi = new Form4();
            jautājumi.Show();
        }
    }
}
