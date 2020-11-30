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
    [XmlRoot(ElementName = "Groups")]
    public class DishCategoryComposition : IEnumerable<DishCategory>
    {
        [XmlArrayItem("ListOfGroup")]
        private List<DishCategory> _list;

        public event EventHandler Changed;

        public DishCategoryComposition(List<DishCategory> Group)
        {
            _list = Group;
        }

        public DishCategoryComposition() : this(new List<DishCategory>())
        {
        }

        public DishCategoryComposition SetList(List<DishCategory> list)
        {
            _list = list;

            if (Changed != null) Changed(this, new EventArgs());

            return this;
        }

        public DishCategory this[int i]
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

        public int this[DishCategory i]
        {
            get
            {
                return _list.IndexOf(i);
            }
        }
        public DishCategoryComposition Add(DishCategory group)
        {

            if (!_list.Contains(group))
                if (!_list.Any(i => i.Name.Equals(group.Name, StringComparison.CurrentCultureIgnoreCase)))
                    _list.Add(group);

            if (Changed != null) Changed(this, new EventArgs());

            return this;
        }

        public DishCategoryComposition Edit(int index, string name)
        {
            if (!_list.Any(t => t.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)))
                _list[index].Name = name;

            if (Changed != null) Changed(this, new EventArgs());

            return this;
        }

        public DishCategoryComposition Remove(DishCategory group)
        {
            _list.Remove(group);

            if (Changed != null) Changed(this, new EventArgs());

            return this;
        }

        public DishCategoryComposition Remove(int Index)
        {
            _list.RemoveAt(Index);

            if (Changed != null) Changed(this, new EventArgs());

            return this;
        }

        public int Count()
        {
            return _list.Count;
        }

        public IEnumerator<DishCategory> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}
