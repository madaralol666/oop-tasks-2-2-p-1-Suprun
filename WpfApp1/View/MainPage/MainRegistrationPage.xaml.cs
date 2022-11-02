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
using WpfApp1.Core;
using WpfApp1.Model;

namespace WpfApp1.View.MainPage
{
    /// <summary>
    /// Логика взаимодействия для MainRegistrationPage.xaml
    /// </summary>
    public partial class MainRegistrationPage : Page
    {
        public MainRegistrationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyMainFrame.TestFrame.Navigate(new MainLoginPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MyMainFrame.DB.Users.Add(new User 
                { 
                    UserName = TBlogin.Text,
                    UserPhone = PBpassword.Password,
                    RoleID = 2
                });
                MyMainFrame.DB.SaveChanges();
                MessageBox.Show("За дело бирйотся мясник", "Системное мясо", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
