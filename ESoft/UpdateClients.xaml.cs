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
    /// Логика взаимодействия для UpdateClients.xaml
    /// </summary>
    public partial class UpdateClients : Page
    {

        private clients _currentClient = new clients();

        public UpdateClients(clients clients)
        {
            InitializeComponent();
            if (clients != null)
                _currentClient = clients;
            DataContext = _currentClient;
        }

        private void insertClients_Click(object sender, RoutedEventArgs e)
        {
            RealEstateAgencyEntities2.GetContext().SaveChanges();
            MessageBox.Show("Клиент успешно изменен");
        }
    }
}
