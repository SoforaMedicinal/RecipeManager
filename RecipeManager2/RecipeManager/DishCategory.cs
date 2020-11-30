using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RecipeManager
{
    [Serializable]
    public class DishCategory
    {
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }

        protected DishCategory(string name)
        {
            Name = name;
        }
        protected DishCategory()
        { }

        public static Result<DishCategory> Create(string name)
        {
            var errors = new List<string>();

            if (string.IsNullOrEmpty(name)) { errors.Add("Title cannot be empty"); }


            if (errors.Any())
            {
                return Result<DishCategory>.Fail(errors);
            }

            var context = Regex.Replace(name, @"\s+", " ").Trim();
            return Result<DishCategory>.Success(new DishCategory(context));
        }
        public override string ToString()
        {
            return string.Format($"Name : {Name}");
        }
    }
}
