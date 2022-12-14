using RecipeProject.WPF.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeProject.WPF.Models
{
    public class RecipeModel
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public Meal Meal { get; set; }
        public bool IsAdded { get; set; }
        public RecipeModel(string title, string imagePath, string description, Meal meal, bool isAdded)
        {
            Title = title;
            ImagePath = imagePath;
            Description = description;
            Meal = meal;
            IsAdded = isAdded;
        }
    }
}
