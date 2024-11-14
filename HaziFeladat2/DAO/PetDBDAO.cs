using HaziFeladat2.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;

namespace HaziFeladat2.DAO
{
    internal class PetDBDAO : IPetDAO
    {
        private const string connectionString = @"Data Source=db\pets.db";

        public PetDBDAO()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db");
            if (!Directory.Exists(dbPath))
            {
                Directory.CreateDirectory(dbPath);
            }

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"
                CREATE TABLE IF NOT EXISTS pets (
                    id INTEGER PRIMARY KEY,
                    name TEXT NOT NULL,
                    sex TEXT NOT NULL,
                    age INTEGER NOT NULL,
                    weight REAL NOT NULL,
                    category TEXT NOT NULL
                );";
                    command.ExecuteNonQuery();
                }
            }
        }


        public bool AddPet(Pets pet)
        {
            bool rv = false;

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO pets (name, sex, age, weight, category)
                                            VALUES (@name, @sex, @age, @weight, @category)";
                    command.Parameters.AddWithValue("@name", pet.Name);
                    command.Parameters.AddWithValue("@sex", pet.Sex);
                    command.Parameters.AddWithValue("@age", pet.Age);
                    command.Parameters.AddWithValue("@weight", pet.Weight);
                    command.Parameters.AddWithValue("@category", pet.Category);

                    int row = command.ExecuteNonQuery();
                    rv = row > 0;
                }
            }

            return rv;
        }

        public bool DeletePet(Pets pet)
        {
            bool rv = false;

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM pets WHERE id = @id";
                    command.Parameters.AddWithValue("@id", pet.ID);

                    int row = command.ExecuteNonQuery();
                    rv = row > 0;
                }
            }

            return rv;
        }

        public IEnumerable<Pets> GetPets()
        {
            List<Pets> petsList = new List<Pets>();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM pets";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pets newHero = new Pets
                            {
                                ID = reader.GetInt64(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                Sex = reader.GetString(reader.GetOrdinal("sex")),
                                Age = reader.GetInt32(reader.GetOrdinal("age")),
                                Weight = reader.GetDouble(reader.GetOrdinal("weight")),
                                Category = reader.GetString(reader.GetOrdinal("category"))
                            };

                            petsList.Add(newHero);
                        }
                    }
                }
            }

            return petsList;
        }

        public Pets GetPets(int petID)
        {
            Pets pet = null;

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM pets WHERE id = @id";
                    command.Parameters.AddWithValue("@id", petID);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pet = new Pets
                            {
                                ID = reader.GetInt64(reader.GetOrdinal("id")),
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                Sex = reader.GetString(reader.GetOrdinal("sex")),
                                Age = reader.GetInt32(reader.GetOrdinal("age")),
                                Weight = reader.GetDouble(reader.GetOrdinal("weight")),
                                Category = reader.GetString(reader.GetOrdinal("category"))
                            };
                        }
                    }
                }
            }

            return pet;
        }

        public int PetsCount()
        {
            int count = 0;

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT COUNT(*) FROM pets";
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return count;
        }

        public bool UpdatePet(Pets pet)
        {
            bool rv = false;

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"
                        UPDATE pets 
                        SET name = @name, sex = @sex, age = @age, weight = @weight, category = @category
                        WHERE id = @id";
                    command.Parameters.AddWithValue("@name", pet.Name);
                    command.Parameters.AddWithValue("@sex", pet.Sex);
                    command.Parameters.AddWithValue("@age", pet.Age);
                    command.Parameters.AddWithValue("@weight", pet.Weight);
                    command.Parameters.AddWithValue("@category", pet.Category);
                    command.Parameters.AddWithValue("@id", pet.ID);

                    int row = command.ExecuteNonQuery();
                    rv = row > 0;
                }
            }

            return rv;
        }
    }
}
