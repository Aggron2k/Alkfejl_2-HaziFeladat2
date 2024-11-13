using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HaziFeladat2.Views.Dialogs
{
    public partial class AddCategoryForm : Form
    {
        public List<string> CategoriesP { get; private set; } = new List<string>();

        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CategTextBox.Text))
            {
                var findkey = CategoriesP.Find(x => x.Equals(CategTextBox.Text));
                if (findkey != null)
                {
                    MessageBox.Show("Ilyen már létezik!", "Hiba!");
                }
                else
                {
                    PetListBox.Items.Add(CategTextBox.Text);
                    CategoriesP.Add(CategTextBox.Text);
                    CategTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("Meg kell adni a Kategóriát!", "Figyelem!");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}