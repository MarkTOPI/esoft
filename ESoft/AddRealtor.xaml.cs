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
        RealEstateAgencyEntities2 db = new RealEstateAgencyEntities2();
        private agents agents = new agents();

        public AddRealtor()
        {
            InitializeComponent();
            DataContext = agents;
            gridData.ItemsSource = RealEstateAgencyEntities2.GetContext().agents.ToList();
        }

        private void addRielt_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new NewRieltor());
        }

        private void updateRielt_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new InsertRieltor());
        }

        private void deleteRielt_Click(object sender, RoutedEventArgs e)
        {
            var rieltorRemoving = gridData.SelectedItems.Cast<agents>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {rieltorRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    RealEstateAgencyEntities2.GetContext().agents.RemoveRange(rieltorRemoving);
                    RealEstateAgencyEntities2.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    gridData.ItemsSource = RealEstateAgencyEntities2.GetContext().agents.ToList();
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
            gridData.ItemsSource = db.agents.ToList();
        }
    }
}
