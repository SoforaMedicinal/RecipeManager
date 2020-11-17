namespace RecipeManager
{
    partial class RecipeDiary
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRecipe = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.vlRevipeSteps = new System.Windows.Forms.ListView();
            this.RecipeSteps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvIngredientsRecipe = new System.Windows.Forms.ListView();
            this.Ingredients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainListView = new System.Windows.Forms.ListView();
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupofDish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.txtNameGrou = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditGrou = new System.Windows.Forms.Button();
            this.btnDeleteGrou = new System.Windows.Forms.Button();
            this.btnAddGrou = new System.Windows.Forms.Button();
            this.lvGroup = new System.Windows.Forms.ListView();
            this.DishCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageIngredientGroup = new System.Windows.Forms.TabPage();
            this.txtNameIngr = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnEditIngr = new System.Windows.Forms.Button();
            this.btnDeleteIngr = new System.Windows.Forms.Button();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.lvIngredient = new System.Windows.Forms.ListView();
            this.ingridients = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPageRecipe.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            this.tabPageIngredientGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRecipe);
            this.tabControl1.Controls.Add(this.tabPageCategory);
            this.tabControl1.Controls.Add(this.tabPageIngredientGroup);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 636);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRecipe
            // 
            this.tabPageRecipe.Controls.Add(this.btnEdit);
            this.tabPageRecipe.Controls.Add(this.btnDelete);
            this.tabPageRecipe.Controls.Add(this.btnAdd);
            this.tabPageRecipe.Controls.Add(this.vlRevipeSteps);
            this.tabPageRecipe.Controls.Add(this.lvIngredientsRecipe);
            this.tabPageRecipe.Controls.Add(this.mainListView);
            this.tabPageRecipe.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecipe.Name = "tabPageRecipe";
            this.tabPageRecipe.Size = new System.Drawing.Size(816, 610);
            this.tabPageRecipe.TabIndex = 0;
            this.tabPageRecipe.Text = "Рецепты";
            this.tabPageRecipe.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(339, 570);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(420, 570);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(258, 570);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // vlRevipeSteps
            // 
            this.vlRevipeSteps.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.vlRevipeSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.vlRevipeSteps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RecipeSteps});
            this.vlRevipeSteps.FullRowSelect = true;
            this.vlRevipeSteps.GridLines = true;
            this.vlRevipeSteps.HideSelection = false;
            this.vlRevipeSteps.Location = new System.Drawing.Point(567, 35);
            this.vlRevipeSteps.MultiSelect = false;
            this.vlRevipeSteps.Name = "vlRevipeSteps";
            this.vlRevipeSteps.ShowGroups = false;
            this.vlRevipeSteps.Size = new System.Drawing.Size(215, 501);
            this.vlRevipeSteps.TabIndex = 8;
            this.vlRevipeSteps.UseCompatibleStateImageBehavior = false;
            this.vlRevipeSteps.View = System.Windows.Forms.View.Details;
            // 
            // RecipeSteps
            // 
            this.RecipeSteps.Tag = "";
            this.RecipeSteps.Text = "Последовательность приготовления";
            this.RecipeSteps.Width = 210;
            // 
            // lvIngredientsRecipe
            // 
            this.lvIngredientsRecipe.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvIngredientsRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lvIngredientsRecipe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ingredients});
            this.lvIngredientsRecipe.FullRowSelect = true;
            this.lvIngredientsRecipe.GridLines = true;
            this.lvIngredientsRecipe.HideSelection = false;
            this.lvIngredientsRecipe.Location = new System.Drawing.Point(383, 35);
            this.lvIngredientsRecipe.MultiSelect = false;
            this.lvIngredientsRecipe.Name = "lvIngredientsRecipe";
            this.lvIngredientsRecipe.ShowGroups = false;
            this.lvIngredientsRecipe.Size = new System.Drawing.Size(178, 501);
            this.lvIngredientsRecipe.TabIndex = 7;
            this.lvIngredientsRecipe.UseCompatibleStateImageBehavior = false;
            this.lvIngredientsRecipe.View = System.Windows.Forms.View.Details;
            this.lvIngredientsRecipe.SelectedIndexChanged += new System.EventHandler(this.LvIngredientsRecipe_SelectedIndexChanged);
            // 
            // Ingredients
            // 
            this.Ingredients.Tag = "";
            this.Ingredients.Text = "Ингредиенты";
            this.Ingredients.Width = 171;
            // 
            // mainListView
            // 
            this.mainListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.mainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.GroupofDish});
            this.mainListView.FullRowSelect = true;
            this.mainListView.GridLines = true;
            this.mainListView.HideSelection = false;
            this.mainListView.Location = new System.Drawing.Point(27, 35);
            this.mainListView.MultiSelect = false;
            this.mainListView.Name = "mainListView";
            this.mainListView.ShowGroups = false;
            this.mainListView.Size = new System.Drawing.Size(350, 501);
            this.mainListView.TabIndex = 6;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            // 
            // Description
            // 
            this.Description.Tag = "";
            this.Description.Text = "Описание";
            this.Description.Width = 191;
            // 
            // GroupofDish
            // 
            this.GroupofDish.Text = "Категория";
            this.GroupofDish.Width = 147;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.txtNameGrou);
            this.tabPageCategory.Controls.Add(this.label1);
            this.tabPageCategory.Controls.Add(this.btnEditGrou);
            this.tabPageCategory.Controls.Add(this.btnDeleteGrou);
            this.tabPageCategory.Controls.Add(this.btnAddGrou);
            this.tabPageCategory.Controls.Add(this.lvGroup);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Size = new System.Drawing.Size(816, 610);
            this.tabPageCategory.TabIndex = 1;
            this.tabPageCategory.Text = "Категории блюд";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // txtNameGrou
            // 
            this.txtNameGrou.Location = new System.Drawing.Point(472, 36);
            this.txtNameGrou.Name = "txtNameGrou";
            this.txtNameGrou.Size = new System.Drawing.Size(146, 20);
            this.txtNameGrou.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Название";
            // 
            // btnEditGrou
            // 
            this.btnEditGrou.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditGrou.Location = new System.Drawing.Point(503, 71);
            this.btnEditGrou.Name = "btnEditGrou";
            this.btnEditGrou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditGrou.Size = new System.Drawing.Size(75, 23);
            this.btnEditGrou.TabIndex = 27;
            this.btnEditGrou.TabStop = false;
            this.btnEditGrou.Text = "Изменить";
            this.btnEditGrou.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGrou
            // 
            this.btnDeleteGrou.Location = new System.Drawing.Point(630, 71);
            this.btnDeleteGrou.Name = "btnDeleteGrou";
            this.btnDeleteGrou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteGrou.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGrou.TabIndex = 26;
            this.btnDeleteGrou.TabStop = false;
            this.btnDeleteGrou.Text = "Удалить";
            this.btnDeleteGrou.UseVisualStyleBackColor = true;
            // 
            // btnAddGrou
            // 
            this.btnAddGrou.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddGrou.Location = new System.Drawing.Point(375, 71);
            this.btnAddGrou.Name = "btnAddGrou";
            this.btnAddGrou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddGrou.Size = new System.Drawing.Size(75, 23);
            this.btnAddGrou.TabIndex = 25;
            this.btnAddGrou.TabStop = false;
            this.btnAddGrou.Text = "Добавить";
            this.btnAddGrou.UseVisualStyleBackColor = true;
            // 
            // lvGroup
            // 
            this.lvGroup.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lvGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DishCategory});
            this.lvGroup.FullRowSelect = true;
            this.lvGroup.GridLines = true;
            this.lvGroup.HideSelection = false;
            this.lvGroup.Location = new System.Drawing.Point(44, 21);
            this.lvGroup.MultiSelect = false;
            this.lvGroup.Name = "lvGroup";
            this.lvGroup.ShowGroups = false;
            this.lvGroup.Size = new System.Drawing.Size(254, 561);
            this.lvGroup.TabIndex = 24;
            this.lvGroup.UseCompatibleStateImageBehavior = false;
            this.lvGroup.View = System.Windows.Forms.View.Details;
            // 
            // DishCategory
            // 
            this.DishCategory.Tag = "";
            this.DishCategory.Text = "Категории";
            this.DishCategory.Width = 248;
            // 
            // tabPageIngredientGroup
            // 
            this.tabPageIngredientGroup.Controls.Add(this.txtNameIngr);
            this.tabPageIngredientGroup.Controls.Add(this.lblText);
            this.tabPageIngredientGroup.Controls.Add(this.btnEditIngr);
            this.tabPageIngredientGroup.Controls.Add(this.btnDeleteIngr);
            this.tabPageIngredientGroup.Controls.Add(this.btnAddIngr);
            this.tabPageIngredientGroup.Controls.Add(this.lvIngredient);
            this.tabPageIngredientGroup.Location = new System.Drawing.Point(4, 22);
            this.tabPageIngredientGroup.Name = "tabPageIngredientGroup";
            this.tabPageIngredientGroup.Size = new System.Drawing.Size(816, 610);
            this.tabPageIngredientGroup.TabIndex = 0;
            this.tabPageIngredientGroup.Text = "Ингредиенты";
            this.tabPageIngredientGroup.UseVisualStyleBackColor = true;
            // 
            // txtNameIngr
            // 
            this.txtNameIngr.Location = new System.Drawing.Point(470, 42);
            this.txtNameIngr.Name = "txtNameIngr";
            this.txtNameIngr.Size = new System.Drawing.Size(146, 20);
            this.txtNameIngr.TabIndex = 17;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(394, 45);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(57, 13);
            this.lblText.TabIndex = 16;
            this.lblText.Text = "Название";
            // 
            // btnEditIngr
            // 
            this.btnEditIngr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditIngr.Location = new System.Drawing.Point(495, 80);
            this.btnEditIngr.Name = "btnEditIngr";
            this.btnEditIngr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditIngr.Size = new System.Drawing.Size(75, 23);
            this.btnEditIngr.TabIndex = 15;
            this.btnEditIngr.TabStop = false;
            this.btnEditIngr.Text = "Изменить";
            this.btnEditIngr.UseVisualStyleBackColor = true;
            this.btnEditIngr.Click += new System.EventHandler(this.btnEditIngr_Click);
            // 
            // btnDeleteIngr
            // 
            this.btnDeleteIngr.Location = new System.Drawing.Point(619, 80);
            this.btnDeleteIngr.Name = "btnDeleteIngr";
            this.btnDeleteIngr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteIngr.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteIngr.TabIndex = 13;
            this.btnDeleteIngr.TabStop = false;
            this.btnDeleteIngr.Text = "Удалить";
            this.btnDeleteIngr.UseVisualStyleBackColor = true;
            this.btnDeleteIngr.Click += new System.EventHandler(this.btnDeleteIngr_Click);
            // 
            // btnAddIngr
            // 
            this.btnAddIngr.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddIngr.Location = new System.Drawing.Point(376, 80);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddIngr.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngr.TabIndex = 12;
            this.btnAddIngr.TabStop = false;
            this.btnAddIngr.Text = "Добавить";
            this.btnAddIngr.UseVisualStyleBackColor = true;
            this.btnAddIngr.Click += new System.EventHandler(this.btnAddIngr_Click);
            // 
            // lvIngredient
            // 
            this.lvIngredient.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lvIngredient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ingridients});
            this.lvIngredient.FullRowSelect = true;
            this.lvIngredient.GridLines = true;
            this.lvIngredient.HideSelection = false;
            this.lvIngredient.Location = new System.Drawing.Point(57, 27);
            this.lvIngredient.MultiSelect = false;
            this.lvIngredient.Name = "lvIngredient";
            this.lvIngredient.ShowGroups = false;
            this.lvIngredient.Size = new System.Drawing.Size(253, 557);
            this.lvIngredient.TabIndex = 8;
            this.lvIngredient.UseCompatibleStateImageBehavior = false;
            this.lvIngredient.View = System.Windows.Forms.View.Details;
            // 
            // ingridients
            // 
            this.ingridients.Tag = "";
            this.ingridients.Text = "Ингредиенты";
            this.ingridients.Width = 248;
            // 
            // RecipeDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 636);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RecipeDiary";
            this.Text = "Менеджер рецептов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRecipe.ResumeLayout(false);
            this.tabPageCategory.ResumeLayout(false);
            this.tabPageCategory.PerformLayout();
            this.tabPageIngredientGroup.ResumeLayout(false);
            this.tabPageIngredientGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRecipe;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView vlRevipeSteps;
        private System.Windows.Forms.ColumnHeader RecipeSteps;
        private System.Windows.Forms.ListView lvIngredientsRecipe;
        private System.Windows.Forms.ColumnHeader Ingredients;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader GroupofDish;
        private System.Windows.Forms.TabPage tabPageIngredientGroup;
        private System.Windows.Forms.ListView lvIngredient;
        private System.Windows.Forms.ColumnHeader ingridients;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnEditIngr;
        private System.Windows.Forms.Button btnDeleteIngr;
        private System.Windows.Forms.Button btnAddIngr;
        private System.Windows.Forms.TextBox txtNameIngr;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.TextBox txtNameGrou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditGrou;
        private System.Windows.Forms.Button btnDeleteGrou;
        private System.Windows.Forms.Button btnAddGrou;
        private System.Windows.Forms.ListView lvGroup;
        private System.Windows.Forms.ColumnHeader DishCategory;
    }
}

