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

namespace MadBase
{
    /// <summary>
    /// Логика взаимодействия для Page7_2.xaml
    /// </summary>
    public partial class Page7_2 : Page
    {
        public Page7_2()
        {
            InitializeComponent();
        }

        private void ButtonToP7(object sender, MouseButtonEventArgs e)
        {
            AppData.NavigateClass.globalFrame.Navigate(new Page7());
        }

        private void ButtonToP7Delete(object sender, RoutedEventArgs e)
        {
            //Также должен удалять запись
            AppData.NavigateClass.globalFrame.Navigate(new Page7());
        }
    }
}