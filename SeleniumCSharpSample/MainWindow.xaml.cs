﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SeleniumCSharpSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string strURL = "https://tiki.vn/";

        public MainWindow()
        {
            InitializeComponent();

            tbxURL.Text = strURL;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Mở 1 đường link web bằng ChromeDriver
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(tbxURL.Text);
            }
        }
    }
}
