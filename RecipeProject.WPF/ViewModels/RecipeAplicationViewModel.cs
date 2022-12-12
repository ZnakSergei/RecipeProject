using RecipeProject.WPF.Commands;
using RecipeProject.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeProject.WPF.ViewModels
{
    public class RecipeAplicationViewModel : ViewModelBase
    {
        private ModalNavigationStore _modalNavigationStore;
        public ViewModelBase CurrentViewModel => _modalNavigationStore.CurrentViewModel;
        public bool IsModalOpen => _modalNavigationStore.IsModalOpen;
        private SelectedRecipeStore _selectedRecipeStore;
        public RecipeListingViewModel RecipeListingViewModel { get; set; }
        public RecipeDetailsViewModel RecipeDetailsViewModel { get; set; }
        public string Username { get; set; }
        public ICommand AddNewRecipeCommand { get; }
        public ICommand EditUserCommand { get; }
        public ICommand LogOutCommand { get; }
        public RecipeAplicationViewModel(SelectedRecipeStore selectedRecipeStore, ModalNavigationStore modalNavigationStoreStore)
        {
            _modalNavigationStore = modalNavigationStoreStore;
            _modalNavigationStore.CurrentViewModelChanged += _modalNavigationStore_ViewModelChanged;
            
            RecipeListingViewModel= new RecipeListingViewModel(selectedRecipeStore);
            RecipeDetailsViewModel = new RecipeDetailsViewModel(selectedRecipeStore);
            AddNewRecipeCommand = new ViewModelCommand(ExecuteAddRecipeCommand);
        }

        private void _modalNavigationStore_ViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }

        private void ExecuteAddRecipeCommand(object obj)
        {
            var addNewRecipeViewModel = new AddNewRecipeViewModel(_modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = addNewRecipeViewModel;
        }
    }
}
