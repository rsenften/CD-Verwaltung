﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        public MainWindow()
        {
            InitializeComponent();
            // Wichtig!
            Data.Global.context = new Data.Context();
            mainWindowDataGrid.ItemsSource = Data.CD.LesenAlle().Select(c => new { c.CDName, c.ArtDesInhalts, c.Erstellung });
            // Aufruf diverse APIDemo Methoden
            //APIDemo.DemoACreate();
            //APIDemo.DemoACreateKurz();
            //APIDemo.DemoARead();
            //APIDemo.DemoAUpdate();
            //APIDemo.DemoARead();
            //APIDemo.DemoADelete();
        }

        /*
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }*/

        private void btnErstellen_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow objCreateWindow = new CreateWindow();
            objCreateWindow.ShowDialog();
        }

        private void btnBearbeiten_Click(object sender, RoutedEventArgs e)
        {
            EditWindow objEditWindow = new EditWindow();
            objEditWindow.ShowDialog();
        }
    }
}
