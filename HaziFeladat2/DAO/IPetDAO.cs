using HaziFeladat2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaziFeladat2.DAO
{
    internal interface IPetDAO
    {
        IEnumerable<Pets> GetPets();
        Pets GetPets(int petID);
        bool AddPet(Pets pet);
        bool UpdatePet(Pets pet);
        bool DeletePet(Pets pet);

        int PetsCount();

    }
}
