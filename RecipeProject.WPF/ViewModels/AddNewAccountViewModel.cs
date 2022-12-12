using RecipeProject.WPF.Commands;
using RecipeProject.WPF.Models;
using RecipeProject.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeProject.WPF.ViewModels
{
    public class AddNewAccountViewModel : ViewModelBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;
        private Guid _userId;
        private string _username;
        private SecureString _password;

        public Guid UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                OnPropertyChanged(nameof(UserId));
            }
        }
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        public SecureString Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public ICommand SignUpUserCommand { get; }
        public ICommand CancelCommand { get;  }
        public AddNewAccountViewModel(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;

            SignUpUserCommand = new ViewModelCommand(executeSignUpCommand, canExecuteSignUpCommand);
            CancelCommand = new ViewModelCommand(executeCancelCommand);
        }

        private void executeCancelCommand(object obj)
        {
            _modalNavigationStore.Close();
        }

        private bool canExecuteSignUpCommand(object obj)
        {
            bool validData;

            if (string.IsNullOrEmpty(Username) || Username.Length < 3 || Password == null || Password.Length < 3)
            {
                validData = false;
            }
            else
            {
                validData = true;
            }
            return validData;
        }

        private void executeSignUpCommand(object obj)
        {
            
        }
    }
}
