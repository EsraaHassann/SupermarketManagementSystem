﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class SplashForm : Form
    {
        private static SplashForm _instance;
        //make the constructor private
        private SplashForm()
        {
            InitializeComponent();
        }

         public static SplashForm Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SplashForm();
            }
            return _instance;
        }
    }
        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            myProgressBar.Value = startPoint;
            if (myProgressBar.Value == 100)
            {
                myProgressBar.Value = 0;
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }
    }
}
