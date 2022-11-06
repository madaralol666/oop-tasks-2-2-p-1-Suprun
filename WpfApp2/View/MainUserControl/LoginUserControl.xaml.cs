using System;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfApp2.Core;
using WpfApp2.Model;
using WpfApp2.ViewModel;

namespace WpfApp2.View.MainUserControl
{
    /// <summary>
    /// Логика взаимодействия для LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl(LoginUCViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            LoginTB.Text = $"@{viewModel.LoginField}";

            var userInfo = (from u in MyFrame.DB.Users
                        where u.UserLogin == viewModel.LoginField
                        select u).SingleOrDefault();

            viewModel.FirstNameField = userInfo.UserFirstName;
            viewModel.LastNameField = userInfo.UserLastName;
            viewModel.AgeField = userInfo.UserAge;
            viewModel.RegisterDateField = userInfo.UserRegistrationDate;
            viewModel.ImagePath = userInfo.UserProfileImage;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SignOutBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Frame.Navigate(new LoginUC());
        }
    }
}
