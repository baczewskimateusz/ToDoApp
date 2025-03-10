using System.Windows.Input;

namespace TodoApp.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string? _username;
        private string? _password;

        public string Username
        {
            get { return _username; }
            set {
                _username = value;
                OnPropertyChanged(nameof(Username));    
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

        public ICommand LoginCommand { get; }
        public ICommand ForgotPasswordCommand { get; }
        public ICommand RegisterCommand { get;}
    }
}
