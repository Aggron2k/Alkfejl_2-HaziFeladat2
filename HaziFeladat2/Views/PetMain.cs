using HaziFeladat2.Controller;
using HaziFeladat2.DAO;
using HaziFeladat2.Models;
using HaziFeladat2.Views;
using HaziFeladat2.Views.Dialogs;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace HaziFeladat2.Views
{
    public partial class PetMain : Form
    {
        private PetController PetController;

        private string connectionString;

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
            IPetDAO petDao = new PetDBDAO();
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
            if (PetController.CountPets() <= 0)
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
            if (!(dataGridView1.CurrentRow?.DataBoundItem is Pets pet))
            {
                return;
            }

            AddPetForm form = new AddPetForm(pet);

            var dialogRes = form.ShowDialog();

            if (dialogRes == DialogResult.OK)
            {
                PetController.UpdatePet(form.savePet);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = PetController.GetPets();
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

        private void szeretedAzÁllatokattToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void szeretedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Szereted az állatokat?", "Fontos Kérdés!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Szuper vagy :)");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Bruh :(");
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.Title = "Mentés másként";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filePath = saveFileDialog.FileName;

                        var petData = new StringBuilder();
                        foreach (var pet in PetController.GetPets())
                        {
                            petData.AppendLine($"ID: {pet.ID}");
                            petData.AppendLine($"Name: {pet.Name}");
                            petData.AppendLine($"Sex: {pet.Sex}");
                            petData.AppendLine($"Age: {pet.Age}");
                            petData.AppendLine($"Weight: {pet.Weight}");
                            petData.AppendLine($"Category: {pet.Category}");
                            petData.AppendLine();
                        }

                        System.IO.File.WriteAllText(filePath, petData.ToString());

                        MessageBox.Show("A kisállatok adatai sikeresen exportálva!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hiba történt a mentés során: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void selectDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQLite Database (*.db)|*.db";
                openFileDialog.Title = "Válaszd ki az adatbázis fájlt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // A kiválasztott fájl elérési útvonalának elmentése a connectionString változóba
                    connectionString = $"Data Source={openFileDialog.FileName}";

                    // Az adatok listázása az adatbázisból
                    LoadData();
                }
            }
        }

        private void LoadData()
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Nincs kiválasztva adatbázisfájl!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new SqliteConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM pets"; // Az adatbázis lekérdezése

                        using (var reader = command.ExecuteReader())
                        {
                            // DataTable létrehozása és oszlopok beállítása a lekérdezett adatok alapján
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader); // A reader adatainak betöltése a DataTable-be

                            // Adatok megjelenítése a DataGridView-ban
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hiba történt az adatbázishoz való csatlakozáskor: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
