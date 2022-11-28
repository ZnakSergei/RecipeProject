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
        private SelectedRecipeStore _selectedRecipeStore;
        public RecipeListingViewModel RecipeListingViewModel { get; set; }
        public RecipeDetailsViewModel RecipeDetailsViewModel { get; set; }
        public string Username { get; set; }
        public ICommand AddNewRecipeCommand { get; }
        public ICommand EditUserCommand { get; }
        public ICommand LogOutCommand { get; }
        public RecipeAplicationViewModel(SelectedRecipeStore selectedRecipeStore)
        {
            RecipeListingViewModel= new RecipeListingViewModel(selectedRecipeStore);
            RecipeDetailsViewModel = new RecipeDetailsViewModel(selectedRecipeStore);
            AddNewRecipeCommand = new ViewModelCommand(ExecuteAddRecipeCommand);
        }

        private void ExecuteAddRecipeCommand(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
