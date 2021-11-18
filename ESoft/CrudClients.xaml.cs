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
    /// Логика взаимодействия для AddClients.xaml
    /// </summary>
    public partial class CrudClients : Page
    {
        RealEstateAgencyEntities2 db = new RealEstateAgencyEntities2();
        public static DataGrid datagrid;

        public clients clients = new clients();

        public CrudClients()
        {
            InitializeComponent();
            DataContext = clients;
            gridData.ItemsSource = RealEstateAgencyEntities2.GetContext().clients.ToList();
        }

        private void addClients_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new AddClients());
        }

        private void insertClients_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new UpdateClients());
        }

        private void deleteClients_Click(object sender, RoutedEventArgs e)
        {
            var clientRemoving = gridData.SelectedItems.Cast<clients>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {clientRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    RealEstateAgencyEntities2.GetContext().clients.RemoveRange(clientRemoving);
                    RealEstateAgencyEntities2.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    gridData.ItemsSource = RealEstateAgencyEntities2.GetContext().clients.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            db = new RealEstateAgencyEntities2();
            gridData.ItemsSource = db.clients.ToList();
        }
    }
}
