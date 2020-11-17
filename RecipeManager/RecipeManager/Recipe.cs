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
        public DishCategory DishCategory { get; set; }

        [XmlArray]
        public IngredientStorage IngredientStorage { get; set; }

        [XmlAttribute(AttributeName = "Этапы приготовления")]
        public string RecipeSteps { get; set; }

        protected Recipe()
        {

        }

        protected Recipe(string description, DishCategory dishCategory, IngredientStorage ingredientStorage, string recipeSteps)
        {
            Description = description;
            DishCategory = dishCategory;
            IngredientStorage = ingredientStorage;
            RecipeSteps = recipeSteps;
        }

        public static Result<Recipe> Create(string description, DishCategory group, IngredientStorage ingredients, string recipeSteps)
        {
            var errors = new List<string>();

            if (group is null) { errors.Add("Выберите категорию блюда"); };
            if (string.IsNullOrEmpty(description)) { errors.Add("Описание не может быть пустое"); }
            if (string.IsNullOrEmpty(recipeSteps)) { errors.Add("Вы не указали последовательность приготовления"); }
            if (ingredients.Count() == 0) { errors.Add("Вы не добавили ни одного ингредиента"); }

            if (errors.Any())
            {
                return Result<Recipe>.Fail(errors);
            }

            var context = Regex.Replace(description, @"\s+", " ").Trim();
            return Result<Recipe>.Success(new Recipe(context, group, ingredients, recipeSteps));
        }

        public override string ToString()
        {
            return string.Format($"Description : {Description}\nGroup : {DishCategory}\nIngredients : {IngredientStorage}\nRecipeSteps : {RecipeSteps}");
        }
    }
}
