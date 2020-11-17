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
    public class Constract : IEnumerable<DishCategory>
    {
        [XmlArrayItem("ListOfGroup")]
        private List<DishCategory> _list;

        public event EventHandler Changed;

        public Constract(List<DishCategory> Group)
        {
            _list = Group;
        }

        public Constract() : this(new List<DishCategory>())
        {
        }

        public Constract SetList(List<DishCategory> list)
        {
            _list = list;

            Changed?.Invoke(this, new EventArgs());

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
        public Constract Add(DishCategory group)
        {

            if (!_list.Contains(group))
                if (!_list.Any(i => i.Name.Equals(group.Name, StringComparison.CurrentCultureIgnoreCase)))
                    _list.Add(group);

            Changed?.Invoke(this, new EventArgs());

            return this;
        }

        public Constract Edit(int index, string name)
        {
            if (!_list.Any(t => t.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)))
                _list[index].Name = name;

            Changed?.Invoke(this, new EventArgs());

            return this;
        }

        public Constract Delete(DishCategory group)
        {
            _list.Remove(group);

            Changed?.Invoke(this, new EventArgs());

            return this;
        }

        public Constract Delete(int Index)
        {
            _list.RemoveAt(Index);

            Changed?.Invoke(this, new EventArgs());

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
