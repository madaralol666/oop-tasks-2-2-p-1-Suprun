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

        private string _loginField = "myaso";

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

    }
}
