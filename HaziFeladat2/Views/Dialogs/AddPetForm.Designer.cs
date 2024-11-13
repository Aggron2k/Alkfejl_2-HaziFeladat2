namespace HaziFeladat2.Views.Dialogs
{
    partial class AddPetForm
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
            ID = new Label();
            IDTextBox = new TextBox();
            NameTextBox = new TextBox();
            PetName = new Label();
            SexGroup = new GroupBox();
            male = new RadioButton();
            female = new RadioButton();
            Age = new Label();
            AgeNumericUpDown = new NumericUpDown();
            WeightNumericUpDown = new NumericUpDown();
            Weight = new Label();
            CategoryComboBox = new ComboBox();
            label1 = new Label();
            AddCategButton = new Button();
            SaveButton = new Button();
            BackButton = new Button();
            pictureBox1 = new PictureBox();
            BigText = new Label();
            SexGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AgeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WeightNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(35, 28);
            ID.Name = "ID";
            ID.Size = new Size(21, 15);
            ID.TabIndex = 0;
            ID.Text = "ID:";
            ID.Click += label1_Click;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(112, 25);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(128, 23);
            IDTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(112, 73);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(128, 23);
            NameTextBox.TabIndex = 2;
            // 
            // PetName
            // 
            PetName.AutoSize = true;
            PetName.Location = new Point(35, 76);
            PetName.Name = "PetName";
            PetName.Size = new Size(42, 15);
            PetName.TabIndex = 3;
            PetName.Text = "Name:";
            // 
            // SexGroup
            // 
            SexGroup.Controls.Add(male);
            SexGroup.Controls.Add(female);
            SexGroup.Location = new Point(35, 121);
            SexGroup.Name = "SexGroup";
            SexGroup.Size = new Size(283, 46);
            SexGroup.TabIndex = 4;
            SexGroup.TabStop = false;
            SexGroup.Text = "Sex:";
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(168, 21);
            male.Name = "male";
            male.Size = new Size(51, 19);
            male.TabIndex = 1;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(24, 21);
            female.Name = "female";
            female.Size = new Size(63, 19);
            female.TabIndex = 0;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(35, 193);
            Age.Name = "Age";
            Age.Size = new Size(31, 15);
            Age.TabIndex = 5;
            Age.Text = "Age:";
            // 
            // AgeNumericUpDown
            // 
            AgeNumericUpDown.Location = new Point(120, 191);
            AgeNumericUpDown.Name = "AgeNumericUpDown";
            AgeNumericUpDown.Size = new Size(120, 23);
            AgeNumericUpDown.TabIndex = 6;
            AgeNumericUpDown.ValueChanged += AgeNumericUpDown_ValueChanged;
            // 
            // WeightNumericUpDown
            // 
            WeightNumericUpDown.DecimalPlaces = 1;
            WeightNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            WeightNumericUpDown.Location = new Point(120, 239);
            WeightNumericUpDown.Name = "WeightNumericUpDown";
            WeightNumericUpDown.Size = new Size(120, 23);
            WeightNumericUpDown.TabIndex = 8;
            WeightNumericUpDown.ValueChanged += WeightNumericUpDown_ValueChanged;
            // 
            // Weight
            // 
            Weight.AutoSize = true;
            Weight.Location = new Point(35, 241);
            Weight.Name = "Weight";
            Weight.Size = new Size(48, 15);
            Weight.TabIndex = 7;
            Weight.Text = "Weight:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(120, 293);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(121, 23);
            CategoryComboBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 296);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 10;
            label1.Text = "Category:";
            // 
            // AddCategButton
            // 
            AddCategButton.Location = new Point(260, 293);
            AddCategButton.Name = "AddCategButton";
            AddCategButton.Size = new Size(156, 23);
            AddCategButton.TabIndex = 11;
            AddCategButton.Text = "AddNewCategory";
            AddCategButton.UseVisualStyleBackColor = true;
            AddCategButton.Click += AddCategButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(59, 366);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(90, 38);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(164, 366);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(90, 38);
            BackButton.TabIndex = 13;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pets;
            pictureBox1.Location = new Point(509, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // BigText
            // 
            BigText.AutoSize = true;
            BigText.Font = new Font("Segoe UI", 20F);
            BigText.Location = new Point(509, 177);
            BigText.Name = "BigText";
            BigText.Size = new Size(261, 37);
            BigText.TabIndex = 15;
            BigText.Text = "Állat hozzáadó Form";
            // 
            // AddPetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(BigText);
            Controls.Add(pictureBox1);
            Controls.Add(BackButton);
            Controls.Add(SaveButton);
            Controls.Add(AddCategButton);
            Controls.Add(label1);
            Controls.Add(CategoryComboBox);
            Controls.Add(WeightNumericUpDown);
            Controls.Add(Weight);
            Controls.Add(AgeNumericUpDown);
            Controls.Add(Age);
            Controls.Add(SexGroup);
            Controls.Add(PetName);
            Controls.Add(NameTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(ID);
            Name = "AddPetForm";
            Text = "AddPetForm";
            Load += AddPetForm_Load;
            SexGroup.ResumeLayout(false);
            SexGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AgeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)WeightNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ID;
        private TextBox IDTextBox;
        private TextBox NameTextBox;
        private Label PetName;
        private GroupBox SexGroup;
        private RadioButton male;
        private RadioButton female;
        private Label Age;
        private NumericUpDown AgeNumericUpDown;
        private NumericUpDown WeightNumericUpDown;
        private Label Weight;
        private ComboBox CategoryComboBox;
        private Label label1;
        private Button AddCategButton;
        private Button SaveButton;
        private Button BackButton;
        private PictureBox pictureBox1;
        private Label BigText;
    }
}