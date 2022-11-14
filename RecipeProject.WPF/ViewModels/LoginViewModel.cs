using RecipeProject.WPF.Commands;
using RecipeProject.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeProject.WPF.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        private SecureString _password;
        private string _errorMessage;
        private bool _isViewVisible = true;

        private ModalNavigationStore _modalNavigationStore;
        public ViewModelBase CurrentViewModel => _modalNavigationStore.CurrentViewModel;
        public bool IsModalOpen => _modalNavigationStore.IsModalOpen;

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
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public bool IsViewVisible
        {
            get { return _isViewVisible; }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }
        }

        public ICommand SignInCommand { get; }
        public ICommand CreateNewAccountCommand { get; }
        public ICommand RecoveryPasswordCommand { get; }
        public ICommand RememberPasswordCommand { get; }

        public LoginViewModel(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
            _modalNavigationStore.CurrentViewModelChanged += _modalNavigationStore_CurrentViewModelChanged;

            SignInCommand = new ViewModelCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
            RecoveryPasswordCommand = new ViewModelCommand(ExecuteRecoverCommand);
            CreateNewAccountCommand = new ViewModelCommand(ExecuteCreateNewAccountCommand);
        }

        private void _modalNavigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }

        private void ExecuteCreateNewAccountCommand(object obj)
        {
            AddNewAccountViewModel addNewAccountViewModel = new AddNewAccountViewModel(_modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = addNewAccountViewModel;
        }

        private void ExecuteRecoverCommand(object obj)
        {
            throw new NotImplementedException();
        }

        private void ExecuteLoginCommand(object obj)
        {
            if (CanExecuteLoginCommand(obj) == true)
            {
                IsViewVisible = false;
            }
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrEmpty(Username) || Username.Length < 3 || Password == null || Password.Length < 3)
            {
                validData= false;
            }
            else
            {
                validData = true;
            }

            return validData;
        }
        protected override void Dispose()
        {
            _modalNavigationStore.CurrentViewModelChanged -= _modalNavigationStore_CurrentViewModelChanged;

            base.Dispose();
        }
    }
}
