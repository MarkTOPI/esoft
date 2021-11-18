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
    public partial class AddClients : Page
    {

        RealEstateAgencyEntities2 db = new RealEstateAgencyEntities2();

        public AddClients()
        {
            InitializeComponent();
        }

        private void addClients_Click(object sender, RoutedEventArgs e)
        {
            if ((PhoneTxt.Text != "" && EmailTxt.Text == "") || (PhoneTxt.Text == "" && EmailTxt.Text != "") || (PhoneTxt.Text != "" && EmailTxt.Text != ""))
            {
                MessageBox.Show("Пользователь добавлен");
                RealEstateAgencyEntities2.GetContext().SaveChanges();
            }
            else
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
            RealEstateAgencyEntities2.GetContext().SaveChanges();

        }
    }
}
