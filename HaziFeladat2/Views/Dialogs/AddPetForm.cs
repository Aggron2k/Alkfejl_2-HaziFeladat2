using System;
using HaziFeladat2.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IdGen;
using HaziFeladat2.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HaziFeladat2.Views.Dialogs
{
    public partial class AddPetForm : Form
    {

        public Pets savePet { get; set; }
        public AddPetForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPetForm_Load(object sender, EventArgs e)
        {
            var generator = new IdGenerator(0);
            var id = generator.CreateId();
            IDTextBox.Text = Convert.ToString(id);
        }

        private void AgeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (AgeNumericUpDown.Value < 0)
            {
                AgeNumericUpDown.Value = 0;
            }
        }

        private void WeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (WeightNumericUpDown.Value < 0)
            {
                WeightNumericUpDown.Value = 0;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCategButton_Click(object sender, EventArgs e)
        {
            CategoryComboBox.Items.Clear();

            AddCategoryForm form = new AddCategoryForm();

            var dialogres = form.ShowDialog();
            if (dialogres == DialogResult.OK)
            {
                foreach(var category in form.CategoriesP)
                {
                    CategoryComboBox.Items.Add(category);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(NameTextBox.Text == "" || (!male.Checked && !female.Checked) || AgeNumericUpDown.Value == 0 ||
                WeightNumericUpDown.Value == 0 || CategoryComboBox.Text == ""){
                MessageBox.Show("Nem lehet 0 vagy üres egyik értéke sem!", "Figyelem!");
            }
            else
            {
                savePet = new Pets();
                savePet.ID = Convert.ToInt64(IDTextBox.Text);
                //MessageBox.Show(IDTextBox.Text);
                savePet.Name = NameTextBox.Text;

                if (male.Checked)
                {
                    savePet.Sex = "Male";
                }
                if (female.Checked)
                {
                    savePet.Sex = "Female";
                }

                savePet.Age = Convert.ToInt32(AgeNumericUpDown.Value);
                savePet.Weight = Convert.ToDouble(WeightNumericUpDown.Value);
                savePet.Category = CategoryComboBox.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
