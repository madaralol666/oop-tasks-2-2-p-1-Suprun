using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WpfApp2.Core;
using WpfApp2.ViewModel;

namespace WpfApp2.View.MainUserControl
{
    /// <summary>
    /// Логика взаимодействия для SignUpUserControl.xaml
    /// </summary>
    public partial class SignUpUserControl : UserControl
    {
        private LoginUCViewModel ViewModel = null;
        public SignUpUserControl(LoginUCViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            ViewModel = viewModel;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Frame.GoBack();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Border_Drop(object sender, DragEventArgs e)
        {
            try
            {
                string[] photo = (string[])e.Data.GetData(DataFormats.FileDrop);
                borderProfileImage.ImageSource = new BitmapImage(new Uri($"{photo[0]}", UriKind.Relative));
                photo = null;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void loadPictureBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            if (openFileDialog.ShowDialog() == true)
                borderProfileImage.ImageSource = new BitmapImage(new Uri($"{openFileDialog.FileName}", UriKind.Relative));
        }

        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Frame.Navigate(new LoginUserControl(ViewModel));
        }
    }
}
