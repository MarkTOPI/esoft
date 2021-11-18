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

        RealEstateAgencyEntities2 db = new RealEstateAgencyEntities2();

        public UpdateClients()
        {
            InitializeComponent();
        }

        private void insertClients_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(IdTxt.Text);
            var uRow = db.clients.Where(c => c.Id == num).FirstOrDefault();
            uRow.FirstName = FirstNameTxt.Text;
            uRow.MiddleName = MiddleNameTxt.Text;
            uRow.LastName = LastNameTxt.Text;
            uRow.Email = EmailTxt.Text;
            uRow.Phone = PhoneTxt.Text;
            db.SaveChanges();
            CrudClients.datagrid.ItemsSource = db.clients.ToList();
            MessageBox.Show("Клиент успешно изменен");
        }
    }
}
