using RecipeProject.WPF.Stores;

namespace RecipeProject.WPF.ViewModels;

public class AddNewRecipeViewModel : ViewModelBase
{
    public  RecipeDetailsFormViewModel RecipeDetailsFormViewModel { get; set; }

    public AddNewRecipeViewModel(ModalNavigationStore modalNavigationStore)
    {
        RecipeDetailsFormViewModel = new RecipeDetailsFormViewModel(modalNavigationStore);
    }
}