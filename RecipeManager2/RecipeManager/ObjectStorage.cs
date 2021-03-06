﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;

namespace RecipeManager
{
    public class ObjectStorage
    {
        #region Singleton
        private static readonly ObjectStorage instance = new ObjectStorage();

        public static ObjectStorage GetInstance()
        {
            return instance;
        }

        private ObjectStorage()
        {
            _ingredient = new IngredientStorage();
            _recipe = new RecipeContainer();
            _group = new DishCategoryComposition();

            /*
            //_group.Add(Group.Create("Пусто").Value);
            _group.Add(Group.Create("Десерты").Value);
            _group.Add(Group.Create("Основные блюда").Value);

            //_ingredient.Add(Ingredient.Create("Курица").Value);
            _ingredient.Add(Ingredient.Create("Говядина").Value);
            _ingredient.Add(Ingredient.Create("Лук").Value);

            var res = Recipe.Create(
                description: "КуриГов",
                group: _group[1],
                ingredients: new IngredientContainer(new List<Ingredient>() { _ingredient[0], _ingredient[1] }),
                recipeSteps: "Без понятия"
                );  
            _recipe.Add(res.Value);
            */
        }

        #endregion

        private IngredientStorage _ingredient;

        private RecipeContainer _recipe;

        private DishCategoryComposition _group;

        public void SetData(RecipeManagerData data)
        {
            if (data != null)
            {
                _ingredient.SetList(data.Ingredients);
                _recipe.SetList(data.Recipes);
                _group.SetList(data.Groups); 
            }
        }
        public RecipeContainer GetRecipe()
        {
            return _recipe;
        }

        public IngredientStorage GetIngredient()
        {
            return _ingredient;
        }
        public IngredientStorage GetIngredientForRemove()
        {
            return _ingredient;
        }

        public DishCategoryComposition GetGroups()
        {
            return _group;
        }

    }
}
