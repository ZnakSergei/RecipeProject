using RecipeProject.WPF.Models;
using RecipeProject.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeProject.WPF.Stores
{
    public class SelectedRecipeStore
    {
        private RecipeModel _selectedRecipe;
        public RecipeModel SelectedRecipe
        {
            get { return _selectedRecipe; }
            set
            {
                _selectedRecipe = value;
                SelectedRecipeChanged?.Invoke();
            }
        }
        public Action SelectedRecipeChanged { get; set; }
    }
}
