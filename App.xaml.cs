using System.Windows;
using TodoApp.Models;
using TodoApp.Stores;
using TodoApp.ViewModels;

namespace TodoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //private readonly User _user;

        
        private readonly NavigationStore _navigationStore;

        public App()
        {
            //_user = new User("testUsername", "test@gmail.com", "testPassword");
            _navigationStore = new NavigationStore();   
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new LoginViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
