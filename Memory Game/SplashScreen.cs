﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class SplashScreen : Form
    {
        int x = 0;
        public SplashScreen()
        {
            InitializeComponent();
            timer1.Start();
            x = 1;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmMemory f = new FrmMemory();
            f.Show();
            this.Hide();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 8800;
            progressBar1.Step = 300;
            lblPhanTram.Text = x.ToString();
            progressBar1.PerformStep();
            if (x == 100)
            {
                timer1.Stop();
                FrmMemory f = new FrmMemory();
                btnOk.Enabled = true;
                btnOk.BackColor = Color.Red;
            }
            x = x + 3;
        }
    }
}