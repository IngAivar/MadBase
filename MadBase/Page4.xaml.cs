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

namespace MadBase
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void ButtonToP2(object sender, MouseButtonEventArgs e)
        {
            AppData.NavigateClass.globalFrame.Navigate(new Page2());
        }

        private void ButtonToP4_1(object sender, RoutedEventArgs e)
        {
            AppData.NavigateClass.globalFrame.Navigate(new Page4_1());
        }

        private void ButtonToP4_2(object sender, RoutedEventArgs e)
        {
            AppData.NavigateClass.globalFrame.Navigate(new Page4_2());
        }

        private void ButtonToP4_3(object sender, RoutedEventArgs e)
        {
            AppData.NavigateClass.globalFrame.Navigate(new Page4_3());
        }
    }
}
