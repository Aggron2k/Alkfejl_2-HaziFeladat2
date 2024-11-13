using HaziFeladat2.DAO;
using HaziFeladat2.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaziFeladat2.Controller
{
    class PetController
    {
        private readonly IPetDAO dao;

        public PetController(IPetDAO petDao)
        {
            dao = petDao;
        }

        public bool AddPet(Pets pet)
        {
            int id = dao.PetsCount();
            pet.ID = id;

            return dao.AddPet(pet);
        }

        public bool DeletePet(int id) {
            return true; //TODO
        }

        public bool UpdatePet(Pets pet)
        {
            return dao.UpdatePet(pet);
        }

        public IEnumerable<Pets> GetPets() {
            return dao.GetPets();
        }

        public Pets GetPets(int id) {
            return dao.GetPets(id);
        }

        //TODO: Delete, Modify 







    }
}
