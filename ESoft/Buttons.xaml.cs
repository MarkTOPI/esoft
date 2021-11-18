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

namespace ESoft
{
    /// <summary>
    /// Логика взаимодействия для Buttons.xaml
    /// </summary>
    public partial class Buttons : Page
    {
        public Buttons()
        {
            InitializeComponent();
        }

        private void ClientBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new CrudClients());
        }

        private void RieltorBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new AddRealtor());
        }

        private void ObjectBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new Object());
        }
    }
}
