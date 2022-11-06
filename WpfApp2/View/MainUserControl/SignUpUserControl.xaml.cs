using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using WpfApp2.Core;
using WpfApp2.Model;
using WpfApp2.ViewModel;

namespace WpfApp2.View.MainUserControl
{
    /// <summary>
    /// Логика взаимодействия для SignUpUserControl.xaml
    /// </summary>
    public partial class SignUpUserControl : UserControl
    {
        private LoginUCViewModel ViewModel = null;
        DispatcherTimer timer = new DispatcherTimer();
        public SignUpUserControl(LoginUCViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
            ViewModel = viewModel;
        }
        public bool IsTextBoxNotEmpty(params TextBox[] textBoxes)
        {
            int countOfNotNulls = 0;
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (textBoxes[i].Text.Trim() != String.Empty)
                    countOfNotNulls++;
            }
            if (countOfNotNulls == textBoxes.Length)
                return true;
            else
                return false;
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
            try
            {
                if(IsTextBoxNotEmpty(LoginTB, FirstNameTB, LastNameTB, AgeTB) 
                    && PasswordPB.Password.Trim() != String.Empty)
                {
                    MyFrame.DB.Users.Add(new User
                    {
                        UserLogin = LoginTB.Text,
                        UserFirstName = FirstNameTB.Text,
                        UserLastName = LastNameTB.Text,
                        UserAge = AgeTB.Text,
                        UserPassword = PasswordPB.Password,
                        UserProfileImage = borderProfileImage.ImageSource.ToString(),
                        UserRegistrationDate = DateTime.Now.ToString()
                    });
                    MyFrame.DB.SaveChanges();
                    MyFrame.Frame.GoBack();
                    MDSSnackbarUnsavedChanges.IsActive = true;
                    MDSSnackbarMessage.Content = "Registration was successful";
                }
                else
                {
                    MDSSnackbarUnsavedChanges.IsActive = true;
                    MDSSnackbarMessage.Content = "Fiil the fields";
                    MDSSnackbarMessage.ActionContent = "OK!";
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Interval = new TimeSpan(0, 0, 0, 0, 3000);
                    timer.Start();
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            MDSSnackbarUnsavedChanges.IsActive = false;
        }

        private void MDSSnackbarMessage_ActionClick(object sender, RoutedEventArgs e)
        {
            MDSSnackbarUnsavedChanges.IsActive = false;
        }
    }
}
