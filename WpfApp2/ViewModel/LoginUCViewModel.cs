using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.ViewModel
{
    public class LoginUCViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string nameElement=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameElement));
        }

        private string _loginField = "danya";

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
        private string _loginHint = "danya2";

        public string LoginHint
        {
            get => _loginHint;
            set { _loginHint = value; OnPropertyChanged(); }
        }
        private string _passwordHint = "danya4";

        public string PasswordHint
        {
            get => _passwordHint;
            set { _passwordHint = value; OnPropertyChanged(); }
        }

    }
}
