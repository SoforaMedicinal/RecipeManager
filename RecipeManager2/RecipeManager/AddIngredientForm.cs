using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeManager {
    public partial class AddIngredientForm : Form {
        private IngredientStorage _ingredients;


        public AddIngredientForm(IngredientStorage container) {

            InitializeComponent();
            _ingredients = container;
            ListOutput(_ingredients);
        }

        public AddIngredientForm(ListView.ListViewItemCollection items)
        {
        }

        public Ingredient[] Ingredient
        {
            get
            {
                var selectedIngredients = new List<Ingredient>();
                foreach (int i in listView1.SelectedIndices) {
                    selectedIngredients.Add(_ingredients[i]);
                }
                return selectedIngredients.ToArray();
            }
        }
        private void ListOutput(IngredientStorage container) {
            for (int i = 0; i < container.Count(); i++) {
                listView1.Items.Add(container[i].Name);
            }
        }
    }
}
