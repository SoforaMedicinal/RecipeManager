using System;
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
        
        private static readonly ObjectStorage instance = new ObjectStorage();

        public static ObjectStorage GetInstance()
        {
            return instance;
        }

        private ObjectStorage()
        {
            _ingredient = new IngredientStorage();
            _recipe = new RecipeStorage();
            _group = new Constract();

        }

        

        private IngredientStorage _ingredient;

        private RecipeStorage _recipe;

        private Constract _group;

        public void SetData(RecipeManagerData data)
        {
            if (data != null)
            {
                _ingredient.SetList(data.Ingredients);
                _recipe.SetList(data.Recipes);
                _group.SetList(data.DishCategory); 
            }
        }
        public RecipeStorage GetRecipe()
        {
            return _recipe;
        }

        public IngredientStorage GetIngredient()
        {
            return _ingredient;
        }

        public Constract GetGroups()
        {
            return _group;
        }

    }
}
