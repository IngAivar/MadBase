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
    /// Логика взаимодействия для Page5_1.xaml
    /// </summary>
    public partial class Page5_1 : Page
    {
        public Page5_1()
        {
            InitializeComponent();
        }

        private void ButtonToP5(object sender, MouseButtonEventArgs e)
        {
            AppData.NavigateClass.globalFrame.Navigate(new Page5());
        }

        private void ButtonToP5Create(object sender, RoutedEventArgs e)
        {
            //Также должен добавлять запись клиента в записи
            AppData.NavigateClass.globalFrame.Navigate(new Page5());
        }
    }
}
