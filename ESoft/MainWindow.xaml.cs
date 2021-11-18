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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.frame = frameMain;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.GoBack();
        }

        private void ClientBtn_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Navigate(new CrudClients());
        }

        private void RieltorBtn_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Navigate(new AddRealtor());
        }

        private void frameMain_ContentRendered_1(object sender, EventArgs e)
        {
            if (frameMain.CanGoBack)
            {
                BackBtn.Visibility = Visibility.Visible;
            }
            else
            {
                BackBtn.Visibility = Visibility.Hidden;
            }
        }

        private void ObjectBtn_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Navigate(new Object());
        }
    }
}
