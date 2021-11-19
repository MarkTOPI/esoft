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
    /// Логика взаимодействия для addObject.xaml
    /// </summary>
    public partial class addObject : Page
    {
        RealEstateAgencyEntities2 db = new RealEstateAgencyEntities2();
        public addObject()
        {
            InitializeComponent();
        }

        private void addHouse_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Объект добавлен");
            RealEstateAgencyEntities2.GetContext().SaveChanges();

            districts newDiscticts = new districts()
            {
                Addres_City = City.Text,
                Address_Street = Street.Text,
                Address_house = HouseNumber.Text,
                Address_number = Convert.ToDouble(ApartmentNumber)
            };

            db.districts.Add(newDiscticts);
            db.SaveChanges();
            RealEstateAgencyEntities2.GetContext().SaveChanges();
        }
    }
}
