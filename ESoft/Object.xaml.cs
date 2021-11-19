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
    /// Логика взаимодействия для Object.xaml
    /// </summary>
    public partial class Object : Page
    {
        public Object()
        {
            InitializeComponent();
            gridData.ItemsSource = RealEstateAgencyEntities2.GetContext().districts.ToList();
        }

        private void addHouse_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new addObject());
        }

        private void insertHouse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
