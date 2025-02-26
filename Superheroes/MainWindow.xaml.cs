﻿using Superheroes.Modelo;
using Superheroes.VistaModelo;
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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVM vm = new MainWindowVM();
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void Event_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Image flecha = (Image)sender;
            if(flecha.Tag.ToString() == "Izquierda")
            {
                vm.Retroceder();
            } 
            else
            {
                vm.Avanzar();
            }
        }

        
    }
}
