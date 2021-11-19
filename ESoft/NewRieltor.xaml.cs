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
    /// Логика взаимодействия для NewRieltor.xaml
    /// </summary>
    public partial class NewRieltor : Page
    {
        RealEstateAgencyEntities2 db = new RealEstateAgencyEntities2();
        public NewRieltor()
        {
            InitializeComponent();
        }

        private void addRielt_Click(object sender, RoutedEventArgs e)
        {
            if (FirstName.Text != "" && MiddleName.Text != "" && LastName.Text != "")
            {
                MessageBox.Show("Пользователь добавлен");
                RealEstateAgencyEntities2.GetContext().SaveChanges();
            } else
            {
                MessageBox.Show("Риелтор не добавлен");
            }
            agents newAgents = new agents()
            {
                FirstName = FirstName.Text,
                MiddleName = MiddleName.Text,
                LastName = LastName.Text,
                DealShare = Convert.ToDouble(Share)
            };

            db.agents.Add(newAgents);
            db.SaveChanges();
            RealEstateAgencyEntities2.GetContext().SaveChanges();
        }
    }
}
