using RecipeProject.WPF.Enums;
using RecipeProject.WPF.Models;
using RecipeProject.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RecipeProject.WPF.ViewModels
{
    public class RecipeListingViewModel : ViewModelBase
    {
        private SelectedRecipeStore _selectedRecipeStore;
        public ObservableCollection<RecipeListingItemViewModel> Recipies { get; set; }
        private RecipeListingItemViewModel _selectedRecipe;
        public RecipeListingItemViewModel SelectedRecipe
        {
            get
            {
                return _selectedRecipe;
            }
            set
            {
                _selectedRecipe = value;
                OnPropertyChanged(nameof(SelectedRecipe));

                _selectedRecipeStore.SelectedRecipe = _selectedRecipe.RecipeModel;
            }
        } 
        public RecipeListingViewModel(SelectedRecipeStore selectedRecipeStore)
        {
            _selectedRecipeStore = selectedRecipeStore;

            Recipies = new ObservableCollection<RecipeListingItemViewModel>();

            Recipies.Add(new RecipeListingItemViewModel(new RecipeModel("First", "image", "Description1", Meal.Breakfast, true)));
            Recipies.Add(new RecipeListingItemViewModel(new RecipeModel("Second", "image", "Description2", Meal.Breakfast, true)));
            Recipies.Add(new RecipeListingItemViewModel(new RecipeModel("Third", "image", "Description3", Meal.Breakfast, true)));
            Recipies.Add(new RecipeListingItemViewModel(new RecipeModel("Third", "image", "Description4", Meal.Breakfast, true)));
            Recipies.Add(new RecipeListingItemViewModel(new RecipeModel("Third", "image", "Description5", Meal.Breakfast, true)));
            Recipies.Add(new RecipeListingItemViewModel(new RecipeModel("Third", "image", "Description6", Meal.Breakfast, true)));
            Recipies.Add(new RecipeListingItemViewModel(new RecipeModel("Third", "image", "Description7", Meal.Breakfast, true)));
            Recipies.Add(new RecipeListingItemViewModel(new RecipeModel("Third", "image", "Description8", Meal.Breakfast, true)));
            Recipies.Add(new RecipeListingItemViewModel(new RecipeModel("Third", "image", "Description9", Meal.Breakfast, false)));
        }
    }
}
