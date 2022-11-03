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
using WpfApp2.Core;

namespace WpfApp2.View.MainUserControl
{
    /// <summary>
    /// Логика взаимодействия для LoginUC.xaml
    /// </summary>
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Frame.Navigate(new LoginUserControl());
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Frame.Navigate(new SignUpUserControl());
        }
    }
}
