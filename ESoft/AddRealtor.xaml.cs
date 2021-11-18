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
    /// Логика взаимодействия для AddRealtor.xaml
    /// </summary>
    public partial class AddRealtor : Page
    {

        private clients clients = new clients();

        public AddRealtor()
        {
            InitializeComponent();
            DataContext = clients;
            gridData.ItemsSource = RealEstateAgencyEntities2.GetContext().clients.ToList();
        }

        private void addClients_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Добавлено");
        }

        private void addRielt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updateRielt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
