using HaziFeladat2.Controller;
using HaziFeladat2.DAO;
using HaziFeladat2.Models;
using HaziFeladat2.Views;
using HaziFeladat2.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaziFeladat2.Views
{
    public partial class PetMain : Form
    {
        private PetController PetController;

        //private List<Pets> CreateDefaultPets()
        //{
        //    return new List<Pets>
        //        {
        //            new Pets { ID = 1, Name = "Borzsi", Sex = "Male", Age = 2, Weight = 10.0, Category = "Dog" },
        //        };
        //}
        public PetMain()
        {
            InitializeComponent();
            IPetDAO petDao = new PetMemoryDAO();
            PetController = new PetController(petDao);

            //dataGridView1.DataSource = CreateDefaultPets();
            dataGridView1.DataSource = null;
        }

        private void PetMain_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                // Hozzáférhetsz az első sorhoz vagy a kijelölt sorhoz
                var firstRow = dataGridView1.Rows[0];
                var cellValue = firstRow.Cells[0].Value;
                //MessageBox.Show("Az első sor első cellájának értéke: " + cellValue?.ToString());
            }
            else
            {
                //MessageBox.Show("Nincs adat a DataGridView-ben.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(PetController.CountPets() <= 0)
            {
                MessageBox.Show("Nincs bejegyzett Háziállat, hoz létre!");
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = PetController.GetPets();
            }
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPetForm form = new AddPetForm();

            var dialogres = form.ShowDialog();
            if (dialogres == DialogResult.OK)
            {
                PetController.AddPet(form.savePet);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Hozzáférünk a kijelölt sorhoz, mert a RowIndex érvényes
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Példa: Olvasunk egy cella értéket
                var cellValue = selectedRow.Cells[0].Value; // Az első cella értéke
                //MessageBox.Show("Kijelölt cella értéke: " + cellValue?.ToString());
            }
            else
            {
                // Nincs érvényes sor kiválasztva
                //MessageBox.Show("Nincs kiválasztva sor.");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedRow = dataGridView1.CurrentRow;
                var cellValue = selectedRow.Cells[0].Value;
                //MessageBox.Show("A kijelölt sor első cellájának értéke: " + cellValue?.ToString());
            }
        }
    }
}
