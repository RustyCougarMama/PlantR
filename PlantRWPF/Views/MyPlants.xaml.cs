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

using PlantRWPF;
using PlantRWPF.ViewModels;

namespace PlantRWPF.Views
{

    /// <summary>
    /// Interaction logic for MyPlants.xaml
    /// </summary>
    public partial class MyPlants : UserControl
    {
        public MyPlants()
        {
            InitializeComponent();
         

        }


        

        private void PlusBut_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new PlantCreateModel();

        }
    }
}