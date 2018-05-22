﻿using System;
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

namespace Settings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddLotButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void SettingButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void SingOutButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //очистити вікно логіна і зробити поточним F1

        }

        private void ThemesButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GridThemes.Visibility = Visibility.Visible;
        }

        private void ThemesButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GridThemes.Visibility = Visibility.Hidden;
        }
    }
}
