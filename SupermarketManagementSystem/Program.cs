﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SellingForm());
            //Application.Run( SplashForm.Instance);
            //Application.Run(new LoginForm());
            //Application.Run(new CategoryForm());
            Application.Run(new SellerForm());
            //Application.Run(new ProductForm());
        }
    }
}
