using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Security.Authentication.Web.Provider;
using Command.Implementation;

namespace _2SemesterProjekt.CustomerFolder
{
    public class CustomerCreateCommands : ICommand
    {
        private CustomerViewModelFactory _viewModelFactory;


        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModelFactory.CreateDomainObject(new CustomerViewModel());
        }

        public event EventHandler CanExecuteChanged;
    }
}
