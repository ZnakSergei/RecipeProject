using RecipeProject.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeProject.WPF.ViewModels
{
    public class RecipeDetailsViewModel : ViewModelBase
    {
        public RecipeModel RecipeModel { get; set; }
        public string Description => RecipeModel.Description;
    }
}
