﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using PlantRWPF;
using PlantRProxy;
using PlantRWPF.ViewModels;

namespace PlantRWPF.Views
{

    /// <summary>
    /// Interaction logic for MyPlants.xaml
    /// </summary>
    public partial class Plants : UserControl
    {
        public PlantRClient service = null;

        public Plants()
        {
            InitializeComponent();
            ListPlants();

        }

        private void ListPlants()
        {
            service = new PlantRClient();
            //service.Open();
            //plantListGrid.ItemsSource = service.GetAccountPersonalPlants(1);//HACK: change account id
            //TODO return a dataset and bind it to the datagrid
        }

        

        private void PlusBut_Click(object sender, RoutedEventArgs e)
        {

            ((PlantsModel)DataContext).PlantCreateSwitch();
            
        }

        private void UpdatePlantBut_Click(object sender, RoutedEventArgs e)
        {
            /*PersonalPlant pp = (PersonalPlant)plantListGrid.SelectedItem;
            service.UpdatePersonalPlant(pp.id, pp.wduration, pp.nname);
            //refresh
            plantListGrid.ItemsSource = service.GetAccountPersonalPlants(1);*/
        }

        private void DeletePlantBut_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {

                /*PersonalPlant pp = (PersonalPlant)plantListGrid.SelectedItem;
                bool check = service.RemovePersonalPlant(pp.id);
                if (check)
                {
                    MessageBox.Show("Plant Removed", "Delete Confirmed", MessageBoxButton.OK);
                }*/
            }
        }

        

    }
}