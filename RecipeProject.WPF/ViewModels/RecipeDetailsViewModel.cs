using RecipeProject.WPF.Models;
using RecipeProject.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RecipeProject.WPF.ViewModels
{
    public class RecipeDetailsViewModel : ViewModelBase
    {
        private SelectedRecipeStore _selectedRecipeStore;
        private RecipeModel SelectedRecipe => _selectedRecipeStore.SelectedRecipe;
        public string Description => SelectedRecipe?.Description ?? "Recipe is not selected";
        public RecipeDetailsViewModel(SelectedRecipeStore selectedRecipeStore)
        {
            _selectedRecipeStore = selectedRecipeStore;

            _selectedRecipeStore.SelectedRecipeChanged += _selectedRecipeStore_RecipeChanged;
        }
        private void _selectedRecipeStore_RecipeChanged()
        {
            OnPropertyChanged(nameof(Description));
        }
    }
}
