﻿using System;
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
using WpfApp2.Core;
using WpfApp2.Model;
using WpfApp2.ViewModel;

namespace WpfApp2.View.MainUserControl
{
    /// <summary>
    /// Логика взаимодействия для LoginUC.xaml
    /// </summary>
    public partial class LoginUC : UserControl
    {
        private LoginUCViewModel viewModel = null;
        public LoginUC()
        {
            InitializeComponent();
            viewModel = (LoginUCViewModel)Resources["viewModel"];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                User userModel = MyFrame.DB.Users.FirstOrDefault(u => u.UserLogin == LoginTextBox.Text && u.UserPassword == PasswordPasswordBox.Password);

                if (userModel == null)
                {
                    MessageBox.Show("Неверные данные",
                                    "Ошибка",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
                else
                {
                    MyFrame.Frame.Navigate(new LoginUserControl(viewModel));
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

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Frame.Navigate(new SignUpUserControl(viewModel));
        }
    }
}
