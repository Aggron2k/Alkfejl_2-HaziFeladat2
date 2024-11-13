using HaziFeladat2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaziFeladat2.DAO
{
    public class PetMemoryDAO : IPetDAO
    {
        public IList<Pets> pets = new List<Pets>();
        public bool AddPet(Pets pet)
        {
            if(pet == null)
            {
                return false;
            }
            if(pets.Any(x => x.Name == pet.Name))
            {
                MessageBox.Show("Létezik már ilyen háziállat a nyilvántartásban!");
                return false;
            }
            pets.Add(pet);
            return true;
        }
        

        public Pets GetPets(int petID)
        {
            return pets.FirstOrDefault(x => x.ID == petID);
        }

        public IEnumerable<Pets> GetPets()
        {
            return pets;
        }

        public bool DeletePet(Pets pet)
        {
            return pets.Remove(pet);
        }

        public bool UpdatePet(Pets pet)
        {
            int storedIndex = pets.IndexOf(pets.FirstOrDefault(x => x.ID == pet.ID));

            if (storedIndex == -1)
            {
                return false;
            }

            pets[storedIndex] = pet;
            return true;
        }

        public int PetsCount()
        {
            return pets.Count();
        }
    }
}
