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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void ButtonToP4(object sender, RoutedEventArgs e)
        {
            AppData.NavigateClass.globalFrame.Navigate(new Page4());
        }

        private void ButtonToP5If(object sender, RoutedEventArgs e)
        {
            if (TextLogin.Text == "1")
            {
                AppData.NavigateClass.globalFrame.Navigate(new Page5());
            }
            else if (TextLogin.Text == "2")
            {
                AppData.NavigateClass.globalFrame.Navigate(new Page6());
            }
        }
    }
}
