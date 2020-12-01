namespace RecipeManager
{
    partial class Form1
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
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvIngredientsRecipe = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageIngredientGroup = new System.Windows.Forms.TabPage();
            this.txtNameIngr = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnEditIngr = new System.Windows.Forms.Button();
            this.btnDeleteIngr = new System.Windows.Forms.Button();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.lvIngredient = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGroup = new System.Windows.Forms.ListView();
            this.btnAddGrou = new System.Windows.Forms.Button();
            this.btnDeleteGrou = new System.Windows.Forms.Button();
            this.btnEditGrou = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameGrou = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageRecipe.SuspendLayout();
            this.tabPageIngredientGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRecipe);
            this.tabControl1.Controls.Add(this.tabPageIngredientGroup);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 551);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRecipe
            // 
            this.tabPageRecipe.Controls.Add(this.label2);
            this.tabPageRecipe.Controls.Add(this.btnEdit);
            this.tabPageRecipe.Controls.Add(this.btnDelete);
            this.tabPageRecipe.Controls.Add(this.btnAdd);
            this.tabPageRecipe.Controls.Add(this.vlRevipeSteps);
            this.tabPageRecipe.Controls.Add(this.lvIngredientsRecipe);
            this.tabPageRecipe.Controls.Add(this.mainListView);
            this.tabPageRecipe.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecipe.Name = "tabPageRecipe";
            this.tabPageRecipe.Size = new System.Drawing.Size(703, 525);
            this.tabPageRecipe.TabIndex = 0;
            this.tabPageRecipe.Text = "Recipes";
            this.tabPageRecipe.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(324, 452);
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
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(405, 452);
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
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(243, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Создать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // vlRevipeSteps
            // 
            this.vlRevipeSteps.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.vlRevipeSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vlRevipeSteps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.vlRevipeSteps.FullRowSelect = true;
            this.vlRevipeSteps.GridLines = true;
            this.vlRevipeSteps.HideSelection = false;
            this.vlRevipeSteps.Location = new System.Drawing.Point(503, 30);
            this.vlRevipeSteps.MultiSelect = false;
            this.vlRevipeSteps.Name = "vlRevipeSteps";
            this.vlRevipeSteps.ShowGroups = false;
            this.vlRevipeSteps.Size = new System.Drawing.Size(197, 413);
            this.vlRevipeSteps.TabIndex = 8;
            this.vlRevipeSteps.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "";
            this.columnHeader4.Text = "Этапы приготовления";
            this.columnHeader4.Width = 210;
            // 
            // lvIngredientsRecipe
            // 
            this.lvIngredientsRecipe.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvIngredientsRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvIngredientsRecipe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lvIngredientsRecipe.FullRowSelect = true;
            this.lvIngredientsRecipe.GridLines = true;
            this.lvIngredientsRecipe.HideSelection = false;
            this.lvIngredientsRecipe.Location = new System.Drawing.Point(319, 3);
            this.lvIngredientsRecipe.MultiSelect = false;
            this.lvIngredientsRecipe.Name = "lvIngredientsRecipe";
            this.lvIngredientsRecipe.ShowGroups = false;
            this.lvIngredientsRecipe.Size = new System.Drawing.Size(178, 440);
            this.lvIngredientsRecipe.TabIndex = 7;
            this.lvIngredientsRecipe.UseCompatibleStateImageBehavior = false;
            this.lvIngredientsRecipe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "";
            this.columnHeader3.Text = "Ингредиенты";
            this.columnHeader3.Width = 171;
            // 
            // mainListView
            // 
            this.mainListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.mainListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mainListView.FullRowSelect = true;
            this.mainListView.GridLines = true;
            this.mainListView.HideSelection = false;
            this.mainListView.Location = new System.Drawing.Point(6, 3);
            this.mainListView.MultiSelect = false;
            this.mainListView.Name = "mainListView";
            this.mainListView.ShowGroups = false;
            this.mainListView.Size = new System.Drawing.Size(307, 440);
            this.mainListView.TabIndex = 6;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "Описание";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Категория";
            this.columnHeader2.Width = 147;
            // 
            // tabPageIngredientGroup
            // 
            this.tabPageIngredientGroup.Controls.Add(this.groupBox2);
            this.tabPageIngredientGroup.Controls.Add(this.groupBox1);
            this.tabPageIngredientGroup.Location = new System.Drawing.Point(4, 22);
            this.tabPageIngredientGroup.Name = "tabPageIngredientGroup";
            this.tabPageIngredientGroup.Size = new System.Drawing.Size(703, 525);
            this.tabPageIngredientGroup.TabIndex = 0;
            this.tabPageIngredientGroup.Text = "Ingredients/Groups";
            this.tabPageIngredientGroup.UseVisualStyleBackColor = true;
            // 
            // txtNameIngr
            // 
            this.txtNameIngr.Location = new System.Drawing.Point(69, 12);
            this.txtNameIngr.Name = "txtNameIngr";
            this.txtNameIngr.Size = new System.Drawing.Size(169, 20);
            this.txtNameIngr.TabIndex = 17;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(6, 15);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(57, 13);
            this.lblText.TabIndex = 16;
            this.lblText.Text = "Название";
            // 
            // btnEditIngr
            // 
            this.btnEditIngr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditIngr.Location = new System.Drawing.Point(90, 38);
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
            this.btnDeleteIngr.Location = new System.Drawing.Point(171, 38);
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
            this.btnAddIngr.Location = new System.Drawing.Point(9, 38);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddIngr.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngr.TabIndex = 12;
            this.btnAddIngr.TabStop = false;
            this.btnAddIngr.Text = "Создать";
            this.btnAddIngr.UseVisualStyleBackColor = true;
            this.btnAddIngr.Click += new System.EventHandler(this.btnAddIngr_Click);
            // 
            // lvIngredient
            // 
            this.lvIngredient.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvIngredient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvIngredient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.lvIngredient.FullRowSelect = true;
            this.lvIngredient.GridLines = true;
            this.lvIngredient.HideSelection = false;
            this.lvIngredient.Location = new System.Drawing.Point(6, 67);
            this.lvIngredient.MultiSelect = false;
            this.lvIngredient.Name = "lvIngredient";
            this.lvIngredient.ShowGroups = false;
            this.lvIngredient.Size = new System.Drawing.Size(339, 452);
            this.lvIngredient.TabIndex = 8;
            this.lvIngredient.UseCompatibleStateImageBehavior = false;
            this.lvIngredient.View = System.Windows.Forms.View.Details;
            this.lvIngredient.SelectedIndexChanged += new System.EventHandler(this.LvIngredient_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "";
            this.columnHeader5.Text = "Ингредиенты";
            this.columnHeader5.Width = 248;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Этапы приготовления";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.txtNameIngr);
            this.groupBox2.Controls.Add(this.lblText);
            this.groupBox2.Controls.Add(this.btnEditIngr);
            this.groupBox2.Controls.Add(this.btnDeleteIngr);
            this.groupBox2.Controls.Add(this.btnAddIngr);
            this.groupBox2.Controls.Add(this.lvIngredient);
            this.groupBox2.Location = new System.Drawing.Point(3, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 522);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtNameGrou);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEditGrou);
            this.groupBox1.Controls.Add(this.btnDeleteGrou);
            this.groupBox1.Controls.Add(this.btnAddGrou);
            this.groupBox1.Controls.Add(this.lvGroup);
            this.groupBox1.Location = new System.Drawing.Point(354, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 521);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "";
            this.columnHeader6.Text = "Категории";
            this.columnHeader6.Width = 248;
            // 
            // lvGroup
            // 
            this.lvGroup.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6});
            this.lvGroup.FullRowSelect = true;
            this.lvGroup.GridLines = true;
            this.lvGroup.HideSelection = false;
            this.lvGroup.Location = new System.Drawing.Point(6, 67);
            this.lvGroup.MultiSelect = false;
            this.lvGroup.Name = "lvGroup";
            this.lvGroup.ShowGroups = false;
            this.lvGroup.Size = new System.Drawing.Size(333, 451);
            this.lvGroup.TabIndex = 18;
            this.lvGroup.UseCompatibleStateImageBehavior = false;
            this.lvGroup.View = System.Windows.Forms.View.Details;
            this.lvGroup.SelectedIndexChanged += new System.EventHandler(this.LvGroup_SelectedIndexChanged);
            // 
            // btnAddGrou
            // 
            this.btnAddGrou.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddGrou.Location = new System.Drawing.Point(22, 38);
            this.btnAddGrou.Name = "btnAddGrou";
            this.btnAddGrou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddGrou.Size = new System.Drawing.Size(71, 23);
            this.btnAddGrou.TabIndex = 19;
            this.btnAddGrou.TabStop = false;
            this.btnAddGrou.Text = "Создать";
            this.btnAddGrou.UseVisualStyleBackColor = true;
            this.btnAddGrou.Click += new System.EventHandler(this.btnAddGrou_Click);
            // 
            // btnDeleteGrou
            // 
            this.btnDeleteGrou.Location = new System.Drawing.Point(184, 38);
            this.btnDeleteGrou.Name = "btnDeleteGrou";
            this.btnDeleteGrou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteGrou.Size = new System.Drawing.Size(71, 23);
            this.btnDeleteGrou.TabIndex = 20;
            this.btnDeleteGrou.TabStop = false;
            this.btnDeleteGrou.Text = "Удалить";
            this.btnDeleteGrou.UseVisualStyleBackColor = true;
            this.btnDeleteGrou.Click += new System.EventHandler(this.btnDeleteGrou_Click);
            // 
            // btnEditGrou
            // 
            this.btnEditGrou.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditGrou.Location = new System.Drawing.Point(103, 38);
            this.btnEditGrou.Name = "btnEditGrou";
            this.btnEditGrou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditGrou.Size = new System.Drawing.Size(71, 23);
            this.btnEditGrou.TabIndex = 21;
            this.btnEditGrou.TabStop = false;
            this.btnEditGrou.Text = "Изменить";
            this.btnEditGrou.UseVisualStyleBackColor = true;
            this.btnEditGrou.Click += new System.EventHandler(this.btnEditGrou_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtNameGrou
            // 
            this.txtNameGrou.Location = new System.Drawing.Point(82, 12);
            this.txtNameGrou.Name = "txtNameGrou";
            this.txtNameGrou.Size = new System.Drawing.Size(167, 20);
            this.txtNameGrou.TabIndex = 23;
            this.txtNameGrou.TextChanged += new System.EventHandler(this.TxtNameGrou_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(711, 551);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(727, 590);
            this.Name = "Form1";
            this.Text = "Менеджер рецептов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRecipe.ResumeLayout(false);
            this.tabPageRecipe.PerformLayout();
            this.tabPageIngredientGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRecipe;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView vlRevipeSteps;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvIngredientsRecipe;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tabPageIngredientGroup;
        private System.Windows.Forms.ListView lvIngredient;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnEditIngr;
        private System.Windows.Forms.Button btnDeleteIngr;
        private System.Windows.Forms.Button btnAddIngr;
        private System.Windows.Forms.TextBox txtNameIngr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNameGrou;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditGrou;
        private System.Windows.Forms.Button btnDeleteGrou;
        private System.Windows.Forms.Button btnAddGrou;
        private System.Windows.Forms.ListView lvGroup;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

