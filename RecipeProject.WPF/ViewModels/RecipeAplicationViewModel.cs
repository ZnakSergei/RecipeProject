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
        public string Username { get; set; }
        public ICommand AddNewRecipeCommand { get; }
        public ICommand AddRecipeCommand { get; }
        public ICommand EditUserCommand { get; }
        public ICommand LogOutCommand { get; }
    }
}
