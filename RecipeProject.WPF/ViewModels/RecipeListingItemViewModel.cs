using RecipeProject.WPF.Commands;
using RecipeProject.WPF.Enums;
using RecipeProject.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeProject.WPF.ViewModels
{
    public class RecipeListingItemViewModel : ViewModelBase
    {
        public RecipeModel RecipeModel { get; set; }
        public string Title => RecipeModel.Title;
        public string ImagePath => RecipeModel.ImagePath;
        public ICommand EditRecipeCommand { get; }
        public ICommand DeleteRecipeCommand { get; }
        public ICommand IsAddedRecipeCommand { get; }
        public RecipeListingItemViewModel(RecipeModel recipeModel)
        {
            RecipeModel = recipeModel;
        }
    }
}
