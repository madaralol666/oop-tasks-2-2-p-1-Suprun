using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp2.ViewModel
{
    public class LoginUCViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string nameElement=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameElement));
        }


        private string _loginField;
        public string LoginField
        {
            get => _loginField; 
            set
            { 
                _loginField = value;
                OnPropertyChanged();
            }
        }


        private string _passwordField;
        public string PasswordField
        {
            get => _passwordField;
            set { 
                _passwordField = value;
                OnPropertyChanged();
            }
        }


        private string _ageField;
        public string AgeField
        {
            get => _ageField;
            set { _ageField = value; OnPropertyChanged(); }
        }


        private string _firstNameField;
        public string FirstNameField
        {
            get => _firstNameField;
            set { _firstNameField = value; OnPropertyChanged(); }
        }

        private string _lastNameField;
        public string LastNameField
        {
            get => _lastNameField;
            set { _lastNameField = value; OnPropertyChanged(); }
        }

        private string _registerDateField;
        public string RegisterDateField
        {
            get => _registerDateField;
            set { _registerDateField = value; OnPropertyChanged(); }
        }

        private string _imagePath = "/Images/load-photo-bg.png";
        public string ImagePath
        {
            get => _imagePath;
            set
            {
                _imagePath = value;
                OnPropertyChanged();
            }
        }


        private string _loginHint = "Login";
        public string LoginHint
        {
            get => _loginHint;
            set { _loginHint = value; OnPropertyChanged(); }
        }


        private string _passwordHint = "Password";
        public string PasswordHint
        {
            get => _passwordHint;
            set { _passwordHint = value; OnPropertyChanged(); }
        }


        private string _ageHint = "Age";
        public string AgeHint
        {
            get => _ageHint;
            set { _ageHint = value; OnPropertyChanged(); }
        }


        private string _firstNameHint = "First name";
        public string FirstNameHint
        {
            get => _firstNameHint;
            set { _firstNameHint = value; OnPropertyChanged(); }
        }


        private string _lastNameHint = "Last name";
        public string LastNameHint
        {
            get => _lastNameHint;
            set { _lastNameHint = value; OnPropertyChanged(); }
        }
    }
}
