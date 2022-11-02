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
    /// Логика взаимодействия для MainLoginPage.xaml
    /// </summary>
    public partial class MainLoginPage : Page
    {
        public MainLoginPage()
        {
            InitializeComponent();
        }

        private  void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                  User userModel =  MyMainFrame.DB.Users.FirstOrDefault(u => u.UserName == TBlogin.Text && u.UserPhone == PBpassword.Password);

                if (userModel == null)
                {
                    MessageBox.Show("Все плохо - тут еды нет", 
                                    "Системное сообщение", 
                                    MessageBoxButton.OK, 
                                    MessageBoxImage.Error);
                }
                else
                {
                    switch (userModel.RoleID)
                    {
                        case 1:
                            MessageBox.Show("1",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                            //Application.Current.Shutdown();
                            break;
                        case 2:
                            MessageBox.Show("2",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                           // Application.Current.Shutdown();
                            break;
                        case 3:
                            MessageBox.Show("3",
                                    "Системное сообщение",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                            //Application.Current.Shutdown();
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),
                                   "Системное сообщение",
                                   MessageBoxButton.OK,
                                   MessageBoxImage.Error);
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyMainFrame.TestFrame.Navigate(new MainRegistrationPage());
        }
    }
}
