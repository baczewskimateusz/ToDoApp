using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TodoApp.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        public string _username;
        public string _email;
        public string _password;
        public string _repeatedPassword;

        public string Username
        {
            get { return _username; }
            set {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string RepeatedPassword
        {
            get { return _repeatedPassword; }
            set
            {
                _repeatedPassword = value;
                OnPropertyChanged(nameof(RepeatedPassword));
            }
        }

        public ICommand RegisterCommand {  get; }
        public ICommand ReturnCommand { get; }
                    
    }

}
