using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;
using TodoApp.Stores;

namespace TodoApp.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        private readonly NavigationStore _navigationStore;

        public MainViewModel( NavigationStore navigationStore) 
        {
            _navigationStore = navigationStore;
        }
    }
}
