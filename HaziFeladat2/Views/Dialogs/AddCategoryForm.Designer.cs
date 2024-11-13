namespace HaziFeladat2.Views.Dialogs
{
    partial class AddCategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PetListBox = new ListBox();
            CategTextBox = new TextBox();
            AddButton = new Button();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // PetListBox
            // 
            PetListBox.FormattingEnabled = true;
            PetListBox.ItemHeight = 15;
            PetListBox.Location = new Point(43, 50);
            PetListBox.Name = "PetListBox";
            PetListBox.Size = new Size(180, 334);
            PetListBox.TabIndex = 0;
            // 
            // CategTextBox
            // 
            CategTextBox.Location = new Point(245, 50);
            CategTextBox.Name = "CategTextBox";
            CategTextBox.Size = new Size(127, 23);
            CategTextBox.TabIndex = 2;
            CategTextBox.TextChanged += textBox1_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(387, 50);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(245, 361);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveButton);
            Controls.Add(AddButton);
            Controls.Add(CategTextBox);
            Controls.Add(PetListBox);
            Name = "AddCategoryForm";
            Text = "AddCategoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox PetListBox;
        private TextBox CategTextBox;
        private Button AddButton;
        private Button SaveButton;
    }
}