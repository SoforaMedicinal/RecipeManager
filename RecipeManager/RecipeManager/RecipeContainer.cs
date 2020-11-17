using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RecipeManager
{
    [Serializable]
    [XmlRoot(ElementName = "Recipes")]
    public class RecipeStorage : IEnumerable<Recipe>
    {
        public event EventHandler Changed;

        [XmlArrayItem("Список рецептов")]
        private List<Recipe> _list;

        public RecipeStorage(List<Recipe> RecipeList)
        {
            _list = RecipeList;
        }
        public RecipeStorage() : this(new List<Recipe>())
        {
        }

       
        public RecipeStorage(SerializationInfo info, StreamingContext context)
        {
            this._list = (List<Recipe>)info.GetValue("Рецепты", typeof(List<Recipe>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Рецепты", _list);
        }
       

        public Recipe this[int i]
        {
            get
            {
                return _list[i];
            }

            set
            {
                _list[i] = value;
            }
        }

        public RecipeStorage Add(Recipe recipe)
        {
            _list.Add(recipe);

            Changed?.Invoke(this, new EventArgs());

            return this;
        }

        public RecipeStorage SetList(List<Recipe> list)
        {
            _list = list;

            Changed?.Invoke(this, new EventArgs());

            return this;
        }


        public RecipeStorage Remove(Recipe recipe)
        {
            _list.Remove(recipe);

            Changed?.Invoke(this, new EventArgs());

            return this;
        }
        public RecipeStorage Remove(int Index)
        {
            _list.RemoveAt(Index);

            Changed?.Invoke(this, new EventArgs());

            return this;
        }

        public int Count()
        {
            return _list.Count;
        }

        public IEnumerator<Recipe> GetEnumerator()
        {
            return ((IEnumerable<Recipe>)_list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}
