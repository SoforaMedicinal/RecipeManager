﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RecipeManager
{

    public class RecipeManagerData
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<DishCategory> DishCategory { get; set; }
        public List<Recipe> Recipes { get; set; }
    }

    public static class RecipeDataManager
    {
        public static void SaveData(string path, RecipeManagerData storage)
        {
            using (var stream = new FileStream(path, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(RecipeManagerData));
                serializer.Serialize(stream, storage);
            }
        }

        public static RecipeManagerData LoadData(string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var serializer = new XmlSerializer(typeof(RecipeManagerData));
                var storage = (RecipeManagerData)serializer.Deserialize(fileStream);

                List<Recipe> tmpRecipes = new List<Recipe>();
                foreach (var itemRecipe in storage.Recipes)
                {
                    IngredientStorage ingredients = new IngredientStorage();
                    Ingredient tmpIngredient;
                    foreach (var itemIngredient in itemRecipe.IngredientStorage)
                    {
                        tmpIngredient = storage.Ingredients.FindLast(t => t.Name == itemIngredient.Name);
                        ingredients.Add(tmpIngredient);
                    }
                    DishCategory group = storage.DishCategory.FindLast(t => t.Name == itemRecipe.DishCategory.Name);
                    Recipe recipe = Recipe.Create(itemRecipe.Description, group, ingredients, itemRecipe.RecipeSteps).Value;
                    tmpRecipes.Add(recipe);
                }
                storage.Recipes = tmpRecipes;
                return storage;
            }
        }
    }
}
