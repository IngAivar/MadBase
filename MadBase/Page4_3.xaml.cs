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
    /// Логика взаимодействия для Page4_3.xaml
    /// </summary>
    public partial class Page4_3 : Page
    {
        public Page4_3()
        {
            InitializeComponent();
        }

        private void ButtonToP4(object sender, MouseButtonEventArgs e)
        {
            AppData.NavigateClass.globalFrame.Navigate(new Page4());
        }

        private void ButtonToP4Create(object sender, RoutedEventArgs e)
        {
            //Должен изменить граф6666666
        }
    }
}
