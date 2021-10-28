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
    /// Логика взаимодействия для Page6_1.xaml
    /// </summary>
    public partial class Page6_1 : Page
    {
        public Page6_1()
        {
            InitializeComponent();
        }

        private void ButtonToP6(object sender, MouseButtonEventArgs e)
        {
            AppData.NavigateClass.globalFrame.Navigate(new Page6());
        }

        private void ButtonToP6Create(object sender, RoutedEventArgs e)
        {
            //Должен изменить запись
        }
    }
}
