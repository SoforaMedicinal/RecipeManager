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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mainListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvIngredientsRecipe = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.vlRevipeSteps = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabPageIngredientGroup = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNameIngr = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnEditIngr = new System.Windows.Forms.Button();
            this.btnDeleteIngr = new System.Windows.Forms.Button();
            this.btnAddIngr = new System.Windows.Forms.Button();
            this.lvIngredient = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNameGrou = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditGrou = new System.Windows.Forms.Button();
            this.btnDeleteGrou = new System.Windows.Forms.Button();
            this.btnAddGrou = new System.Windows.Forms.Button();
            this.lvGroup = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPageRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 601);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRecipe
            // 
            this.tabPageRecipe.Controls.Add(this.splitContainer1);
            this.tabPageRecipe.Controls.Add(this.panel1);
            this.tabPageRecipe.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageRecipe.Name = "tabPageRecipe";
            this.tabPageRecipe.Size = new System.Drawing.Size(1050, 575);
            this.tabPageRecipe.TabIndex = 0;
            this.tabPageRecipe.Text = "Рецепты";
            this.tabPageRecipe.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mainListView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1050, 481);
            this.splitContainer1.SplitterDistance = 508;
            this.splitContainer1.TabIndex = 15;
            // 
            // mainListView
            // 
            this.mainListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mainListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainListView.FullRowSelect = true;
            this.mainListView.GridLines = true;
            this.mainListView.HideSelection = false;
            this.mainListView.Location = new System.Drawing.Point(0, 0);
            this.mainListView.Margin = new System.Windows.Forms.Padding(4);
            this.mainListView.MultiSelect = false;
            this.mainListView.Name = "mainListView";
            this.mainListView.ShowGroups = false;
            this.mainListView.Size = new System.Drawing.Size(508, 481);
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
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvIngredientsRecipe);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel2);
            this.splitContainer2.Size = new System.Drawing.Size(538, 481);
            this.splitContainer2.SplitterDistance = 179;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvIngredientsRecipe
            // 
            this.lvIngredientsRecipe.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvIngredientsRecipe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.lvIngredientsRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIngredientsRecipe.FullRowSelect = true;
            this.lvIngredientsRecipe.GridLines = true;
            this.lvIngredientsRecipe.HideSelection = false;
            this.lvIngredientsRecipe.Location = new System.Drawing.Point(0, 0);
            this.lvIngredientsRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.lvIngredientsRecipe.MultiSelect = false;
            this.lvIngredientsRecipe.Name = "lvIngredientsRecipe";
            this.lvIngredientsRecipe.ShowGroups = false;
            this.lvIngredientsRecipe.Size = new System.Drawing.Size(179, 481);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.vlRevipeSteps);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 481);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Этапы приготовления";
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
            this.vlRevipeSteps.Location = new System.Drawing.Point(8, 28);
            this.vlRevipeSteps.Margin = new System.Windows.Forms.Padding(4);
            this.vlRevipeSteps.MultiSelect = false;
            this.vlRevipeSteps.Name = "vlRevipeSteps";
            this.vlRevipeSteps.ShowGroups = false;
            this.vlRevipeSteps.Size = new System.Drawing.Size(338, 446);
            this.vlRevipeSteps.TabIndex = 8;
            this.vlRevipeSteps.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "";
            this.columnHeader4.Text = "Этапы приготовления";
            this.columnHeader4.Width = 210;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 94);
            this.panel1.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(356, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Создать";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(600, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Location = new System.Drawing.Point(478, 22);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(112, 34);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabPageIngredientGroup
            // 
            this.tabPageIngredientGroup.Controls.Add(this.groupBox2);
            this.tabPageIngredientGroup.Controls.Add(this.groupBox1);
            this.tabPageIngredientGroup.Location = new System.Drawing.Point(4, 22);
            this.tabPageIngredientGroup.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageIngredientGroup.Name = "tabPageIngredientGroup";
            this.tabPageIngredientGroup.Size = new System.Drawing.Size(1050, 575);
            this.tabPageIngredientGroup.TabIndex = 0;
            this.tabPageIngredientGroup.Text = "Ингредиенты/Категории";
            this.tabPageIngredientGroup.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(4, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(526, 565);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // txtNameIngr
            // 
            this.txtNameIngr.Location = new System.Drawing.Point(104, 18);
            this.txtNameIngr.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameIngr.Name = "txtNameIngr";
            this.txtNameIngr.Size = new System.Drawing.Size(252, 20);
            this.txtNameIngr.TabIndex = 17;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(9, 22);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(57, 13);
            this.lblText.TabIndex = 16;
            this.lblText.Text = "Название";
            // 
            // btnEditIngr
            // 
            this.btnEditIngr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditIngr.Location = new System.Drawing.Point(135, 57);
            this.btnEditIngr.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditIngr.Name = "btnEditIngr";
            this.btnEditIngr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditIngr.Size = new System.Drawing.Size(112, 34);
            this.btnEditIngr.TabIndex = 15;
            this.btnEditIngr.TabStop = false;
            this.btnEditIngr.Text = "Изменить";
            this.btnEditIngr.UseVisualStyleBackColor = true;
            this.btnEditIngr.Click += new System.EventHandler(this.btnEditIngr_Click);
            // 
            // btnDeleteIngr
            // 
            this.btnDeleteIngr.Location = new System.Drawing.Point(256, 57);
            this.btnDeleteIngr.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteIngr.Name = "btnDeleteIngr";
            this.btnDeleteIngr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteIngr.Size = new System.Drawing.Size(112, 34);
            this.btnDeleteIngr.TabIndex = 13;
            this.btnDeleteIngr.TabStop = false;
            this.btnDeleteIngr.Text = "Удалить";
            this.btnDeleteIngr.UseVisualStyleBackColor = true;
            this.btnDeleteIngr.Click += new System.EventHandler(this.btnDeleteIngr_Click);
            // 
            // btnAddIngr
            // 
            this.btnAddIngr.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddIngr.Location = new System.Drawing.Point(14, 57);
            this.btnAddIngr.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddIngr.Name = "btnAddIngr";
            this.btnAddIngr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddIngr.Size = new System.Drawing.Size(112, 34);
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
            this.lvIngredient.Location = new System.Drawing.Point(9, 100);
            this.lvIngredient.Margin = new System.Windows.Forms.Padding(4);
            this.lvIngredient.MultiSelect = false;
            this.lvIngredient.Name = "lvIngredient";
            this.lvIngredient.ShowGroups = false;
            this.lvIngredient.Size = new System.Drawing.Size(506, 458);
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
            this.groupBox1.Location = new System.Drawing.Point(531, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(519, 564);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // txtNameGrou
            // 
            this.txtNameGrou.Location = new System.Drawing.Point(123, 18);
            this.txtNameGrou.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameGrou.Name = "txtNameGrou";
            this.txtNameGrou.Size = new System.Drawing.Size(248, 20);
            this.txtNameGrou.TabIndex = 23;
            this.txtNameGrou.TextChanged += new System.EventHandler(this.TxtNameGrou_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnEditGrou
            // 
            this.btnEditGrou.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditGrou.Location = new System.Drawing.Point(154, 57);
            this.btnEditGrou.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditGrou.Name = "btnEditGrou";
            this.btnEditGrou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditGrou.Size = new System.Drawing.Size(106, 34);
            this.btnEditGrou.TabIndex = 21;
            this.btnEditGrou.TabStop = false;
            this.btnEditGrou.Text = "Изменить";
            this.btnEditGrou.UseVisualStyleBackColor = true;
            this.btnEditGrou.Click += new System.EventHandler(this.btnEditGrou_Click);
            // 
            // btnDeleteGrou
            // 
            this.btnDeleteGrou.Location = new System.Drawing.Point(276, 57);
            this.btnDeleteGrou.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGrou.Name = "btnDeleteGrou";
            this.btnDeleteGrou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteGrou.Size = new System.Drawing.Size(106, 34);
            this.btnDeleteGrou.TabIndex = 20;
            this.btnDeleteGrou.TabStop = false;
            this.btnDeleteGrou.Text = "Удалить";
            this.btnDeleteGrou.UseVisualStyleBackColor = true;
            this.btnDeleteGrou.Click += new System.EventHandler(this.btnDeleteGrou_Click);
            // 
            // btnAddGrou
            // 
            this.btnAddGrou.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddGrou.Location = new System.Drawing.Point(33, 57);
            this.btnAddGrou.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGrou.Name = "btnAddGrou";
            this.btnAddGrou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddGrou.Size = new System.Drawing.Size(106, 34);
            this.btnAddGrou.TabIndex = 19;
            this.btnAddGrou.TabStop = false;
            this.btnAddGrou.Text = "Создать";
            this.btnAddGrou.UseVisualStyleBackColor = true;
            this.btnAddGrou.Click += new System.EventHandler(this.btnAddGrou_Click);
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
            this.lvGroup.Location = new System.Drawing.Point(9, 100);
            this.lvGroup.Margin = new System.Windows.Forms.Padding(4);
            this.lvGroup.MultiSelect = false;
            this.lvGroup.Name = "lvGroup";
            this.lvGroup.ShowGroups = false;
            this.lvGroup.Size = new System.Drawing.Size(498, 456);
            this.lvGroup.TabIndex = 18;
            this.lvGroup.UseCompatibleStateImageBehavior = false;
            this.lvGroup.View = System.Windows.Forms.View.Details;
            this.lvGroup.SelectedIndexChanged += new System.EventHandler(this.LvGroup_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "";
            this.columnHeader6.Text = "Категории";
            this.columnHeader6.Width = 248;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1058, 601);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1074, 640);
            this.Name = "Form1";
            this.Text = "Менеджер рецептов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRecipe.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

