using RecipeProject.WPF.Enums;
using RecipeProject.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RecipeProject.WPF.Commands;

namespace RecipeProject.WPF.ViewModels
{
    public class RecipeDetailsFormViewModel : ViewModelBase
    {
        private ModalNavigationStore _modalNavigationStore;
        public ViewModelBase CurrentViewModel => _modalNavigationStore.CurrentViewModel;
        public bool IsModalOpen => _modalNavigationStore.IsModalOpen;

        private string _title;
        public string Title
        {
            get { return _title; }
            set 
            { 
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                OnPropertyChanged(nameof(ImagePath));
            }
        }
        private Meal _meal;
        public Meal Meal
        {
            get { return _meal; }
            set
            {
                _meal = value;
                OnPropertyChanged(nameof(Meal));
            }
        }
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        public RecipeDetailsFormViewModel(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;

            CancelCommand = new ViewModelCommand(executeCancelCommand);
            SubmitCommand = new ViewModelCommand(executeSubmitCommand, canExecuteSubmitCommand);
        }

        private void executeSubmitCommand(object obj)
        {
            
        }

        private bool canExecuteSubmitCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Description))
            {
                validData = false;
            }
            else
            {
                validData = true;
            }

            return validData;
        }

        private void executeCancelCommand(object obj)
        {
            _modalNavigationStore.Close();
        }

        
    }
}
