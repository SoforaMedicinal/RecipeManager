using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RecipeManager
{
    [Serializable]
    [XmlRoot(ElementName = "Ingredients")]
    public class IngredientStorage : IEnumerable<Ingredient>
    {
        [XmlArrayItem("ListOfIngredient")]
        private List<Ingredient> _list;

        public event EventHandler Changed;

        public IngredientStorage(List<Ingredient> IngredientList)
        {
            _list = IngredientList;
        }

        public IngredientStorage() : this(new List<Ingredient>())
        {
        }

        public IngredientStorage SetList(List<Ingredient> list)
        {
            _list = list;

            Changed?.Invoke(this, new EventArgs());

            return this;
        }

        public Ingredient this[int i]
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
        public int this[Ingredient i]
        {
            get
            {
                return _list.IndexOf(i);
            }
        }

        public IngredientStorage Add(Ingredient ingredient)
        {
            if (!_list.Contains(ingredient))
                if (!_list.Any(i => i.Name.Equals(ingredient.Name, StringComparison.CurrentCultureIgnoreCase)))
                {
                    _list.Add(ingredient);
                    Changed?.Invoke(this, new EventArgs());
                }



            return this;
        }

        public IngredientStorage Edit(int index, string name)
        {
            if (!_list.Any(t => t.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)))
                _list[index].Name = name;

            Changed?.Invoke(this, new EventArgs());

            return this;
        }

        public IngredientStorage Delete(Ingredient ingredient)
        {
            _list.Remove(ingredient);

            Changed?.Invoke(this, new EventArgs());

            return this;
        }

        public IngredientStorage Delete(int Index)
        {
            _list.RemoveAt(Index);

            Changed?.Invoke(this, new EventArgs());

            return this;
        }

        public int Count()
        {
            return _list.Count;
        }

        public IEnumerator<Ingredient> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
