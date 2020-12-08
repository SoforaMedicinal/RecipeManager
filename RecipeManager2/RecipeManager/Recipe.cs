using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace RecipeManager
{
    [Serializable]
    public class Recipe
    {
        [XmlAttribute(AttributeName = "Описание")]
        public string Description { get; set; }

        [XmlElement]
        public DishCategory Group { get; set; }

        [XmlArray]
        public IngredientStorage Ingredients { get; set; }

        [XmlAttribute(AttributeName = "Этапы приготовления")]
        public string RecipeSteps { get; set; }

        protected Recipe()
        {

        }

        protected Recipe(string description, DishCategory group, IngredientStorage ingredients, string recipeSteps)
        {
            Description = description;
            Group = group;
            Ingredients = ingredients;
            RecipeSteps = recipeSteps;
        }

        public static Result<Recipe> Create(string description, DishCategory group, IngredientStorage ingredients, string recipeSteps)
        {
            var errors = new List<string>();

            if (group is null) { errors.Add("Рецепт должен содержать категорию"); };
            if (string.IsNullOrEmpty(description)) { errors.Add("Описание не может быть пустым"); }
            if (string.IsNullOrEmpty(recipeSteps)) { errors.Add("Укажите шаги рецепта"); }
            if (ingredients.Count() == 0) { errors.Add("Рецепт должен содержать ингредиенты"); }

            if (errors.Any())
            {
                return Result<Recipe>.Fail(errors);
            }

            var context = Regex.Replace(description, @"\s+", " ").Trim();
            return Result<Recipe>.Success(new Recipe(context, group, ingredients, recipeSteps));
        }

        public override string ToString()
        {
            return string.Format($"Описание : {Description}\nКатегория : {Group}\nИнгредиенты : {Ingredients}\nЭтапы приготовления : {RecipeSteps}");
        }
    }
}
