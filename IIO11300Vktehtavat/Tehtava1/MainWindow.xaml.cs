﻿/*
* Copyright (C) JAMK/IT/Esa Salmikangas
* This file is part of the IIO11300 course project.
* Created: 12.1.2016 Modified: 13.1.2016
* Authors: Antti Mäkelä ,Esa Salmikangas
*/
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

namespace Tehtava1
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double width = int.Parse(txtWidth.Text);
                double height = int.Parse(txtHeight.Text);
                double border = int.Parse(txtBorder.Text);

                double perimeter, area, borderArea;
                perimeter = BusinessLogicWindow.CalculatePerimeter(width, height);
                area = BusinessLogicWindow.CalculateWindowArea(width, height, border);
                borderArea = BusinessLogicWindow.CalculateBorderArea(width, height, border);

                tbResult.Text = "";
                tbResult.Text += "Lasin pinta-ala: "+area.ToString()+"\n";
                tbResult.Text += "Karmin pinta-ala: " + borderArea.ToString() + "\n";
                tbResult.Text += "Karmin piiri: " + perimeter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //yield to an user that everything okay
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
