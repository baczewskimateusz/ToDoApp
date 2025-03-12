using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Stores;
using TodoApp.ViewModels;

namespace TodoApp.Commands
{
    public class NavigationCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigationCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = new LoginViewModel();
        }
    }
}
