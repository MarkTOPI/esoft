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

        RealEstateAgencyEntities1 db = new RealEstateAgencyEntities1();
        public static DataGrid datagrid;

        private void Load()
        {
            gridData.ItemsSource = db.clients.ToList();
            datagrid = gridData;
        }

        public CrudClients()
        {
            InitializeComponent();
            //gridData.ItemsSource = RealEstateAgencyEntities1.GetContext().clients.ToList();
            Load();
        }

        private void addClients_Click(object sender, RoutedEventArgs e)
        {
            if ((PhoneTxt.Text != "" && EmailTxt.Text == "") || (PhoneTxt.Text == "" && EmailTxt.Text != "") || (PhoneTxt.Text != "" && EmailTxt.Text != ""))
            {
                MessageBox.Show("Пользователь добавлен");
                RealEstateAgencyEntities1.GetContext().SaveChanges();
            } else
            {
                MessageBox.Show("Пользователь не добавлен");
            }

            clients newClients = new clients()
            {
                FirstName = FirstNameTxt.Text,
                MiddleName = MiddleNameTxt.Text,
                LastName = LastNameTxt.Text,
                Phone = PhoneTxt.Text,
                Email = EmailTxt.Text
            };

            db.clients.Add(newClients);
            db.SaveChanges();
            datagrid.ItemsSource = db.clients.ToList();

        }

        private void insertClients_Click(object sender, RoutedEventArgs e)
        {
            if ((PhoneTxt.Text != "" && EmailTxt.Text == "") || (PhoneTxt.Text == "" && EmailTxt.Text != "") || (PhoneTxt.Text != "" && EmailTxt.Text != ""))
            {
                MessageBox.Show("Пользователь добавлен");
                RealEstateAgencyEntities1.GetContext().SaveChanges();
            }
            else
            {
                MessageBox.Show("Пользователь не добавлен");
            }

        }

        private void deleteClients_Click(object sender, RoutedEventArgs e)
        {
            var clientRemoving = gridData.SelectedItems.Cast<clients>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {clientRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    RealEstateAgencyEntities1.GetContext().clients.RemoveRange(clientRemoving);
                    RealEstateAgencyEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    gridData.ItemsSource = RealEstateAgencyEntities1.GetContext().clients.ToList();
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
