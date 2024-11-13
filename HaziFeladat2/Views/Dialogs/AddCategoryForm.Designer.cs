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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pets;
            pictureBox1.Location = new Point(327, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(SaveButton);
            Controls.Add(AddButton);
            Controls.Add(CategTextBox);
            Controls.Add(PetListBox);
            Name = "AddCategoryForm";
            Text = "AddCategoryForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox PetListBox;
        private TextBox CategTextBox;
        private Button AddButton;
        private Button SaveButton;
        private PictureBox pictureBox1;
    }
}