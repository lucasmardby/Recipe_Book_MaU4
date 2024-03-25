﻿namespace MaUWinForms4
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpAddRecipe = new GroupBox();
            lblNameRecipe = new Label();
            txtNameRecipe = new TextBox();
            btnAddIngredient = new Button();
            lblCategory = new Label();
            cmbFoodCategory = new ComboBox();
            btnAddRecipe = new Button();
            lstRecipe = new ListBox();
            lblListName = new Label();
            lblListCategory = new Label();
            lblNumOfIngredients = new Label();
            txtDescription = new TextBox();
            grpAddRecipe.SuspendLayout();
            SuspendLayout();
            // 
            // grpAddRecipe
            // 
            grpAddRecipe.Controls.Add(txtDescription);
            grpAddRecipe.Controls.Add(btnAddRecipe);
            grpAddRecipe.Controls.Add(btnAddIngredient);
            grpAddRecipe.Controls.Add(cmbFoodCategory);
            grpAddRecipe.Controls.Add(lblCategory);
            grpAddRecipe.Controls.Add(txtNameRecipe);
            grpAddRecipe.Controls.Add(lblNameRecipe);
            grpAddRecipe.Location = new Point(12, 12);
            grpAddRecipe.Name = "grpAddRecipe";
            grpAddRecipe.Size = new Size(375, 394);
            grpAddRecipe.TabIndex = 0;
            grpAddRecipe.TabStop = false;
            grpAddRecipe.Text = "Add new recipe";
            // 
            // lblNameRecipe
            // 
            lblNameRecipe.AutoSize = true;
            lblNameRecipe.Location = new Point(16, 37);
            lblNameRecipe.Name = "lblNameRecipe";
            lblNameRecipe.Size = new Size(91, 15);
            lblNameRecipe.TabIndex = 0;
            lblNameRecipe.Text = "Name of Recipe";
            // 
            // txtNameRecipe
            // 
            txtNameRecipe.Location = new Point(125, 34);
            txtNameRecipe.Name = "txtNameRecipe";
            txtNameRecipe.Size = new Size(227, 23);
            txtNameRecipe.TabIndex = 1;
            // 
            // btnAddIngredient
            // 
            btnAddIngredient.Location = new Point(244, 71);
            btnAddIngredient.Name = "btnAddIngredient";
            btnAddIngredient.Size = new Size(108, 23);
            btnAddIngredient.TabIndex = 1;
            btnAddIngredient.Text = "Add Ingredients";
            btnAddIngredient.UseVisualStyleBackColor = true;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(16, 74);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // cmbFoodCategory
            // 
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Location = new Point(125, 71);
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.Size = new Size(99, 23);
            cmbFoodCategory.TabIndex = 2;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new Point(16, 348);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(336, 23);
            btnAddRecipe.TabIndex = 1;
            btnAddRecipe.Text = "Add Recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            // 
            // lstRecipe
            // 
            lstRecipe.FormattingEnabled = true;
            lstRecipe.ItemHeight = 15;
            lstRecipe.Location = new Point(393, 50);
            lstRecipe.Name = "lstRecipe";
            lstRecipe.Size = new Size(360, 304);
            lstRecipe.TabIndex = 1;
            // 
            // lblListName
            // 
            lblListName.AutoSize = true;
            lblListName.Location = new Point(432, 22);
            lblListName.Name = "lblListName";
            lblListName.Size = new Size(39, 15);
            lblListName.TabIndex = 2;
            lblListName.Text = "Name";
            // 
            // lblListCategory
            // 
            lblListCategory.AutoSize = true;
            lblListCategory.Location = new Point(539, 22);
            lblListCategory.Name = "lblListCategory";
            lblListCategory.Size = new Size(55, 15);
            lblListCategory.TabIndex = 3;
            lblListCategory.Text = "Category";
            // 
            // lblNumOfIngredients
            // 
            lblNumOfIngredients.AutoSize = true;
            lblNumOfIngredients.Location = new Point(651, 22);
            lblNumOfIngredients.Name = "lblNumOfIngredients";
            lblNumOfIngredients.Size = new Size(102, 15);
            lblNumOfIngredients.TabIndex = 4;
            lblNumOfIngredients.Text = "No. of Ingredients";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(16, 100);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(336, 242);
            txtDescription.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 450);
            Controls.Add(lblNumOfIngredients);
            Controls.Add(lblListCategory);
            Controls.Add(lblListName);
            Controls.Add(lstRecipe);
            Controls.Add(grpAddRecipe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipe Book, Lucas Mårdby";
            grpAddRecipe.ResumeLayout(false);
            grpAddRecipe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpAddRecipe;
        private Button btnAddRecipe;
        private Button btnAddIngredient;
        private ComboBox cmbFoodCategory;
        private Label lblCategory;
        private TextBox txtNameRecipe;
        private Label lblNameRecipe;
        private ListBox lstRecipe;
        private Label lblListName;
        private Label lblListCategory;
        private Label lblNumOfIngredients;
        private TextBox txtDescription;
    }
}