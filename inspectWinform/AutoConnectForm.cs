﻿using System;
using System.Windows.Forms;

namespace inspectWinform
{
    public partial class AutoConnectForm : Form
    {
        private int sed = 10;
        public bool autoConn = true;

        public AutoConnectForm()
        {
            InitializeComponent();
            timer.Interval = 10000;
            timer1.Interval = 1000;
            timer.Enabled = true;
            timer1.Enabled = true;
            timer.Start();
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            autoConn = false;
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sed--;
            this.label1.Text = "将在" + sed + "秒后自动连接";
        }
    }
}