using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdGen;

namespace HaziFeladat2.Models
{
    public class Pets
    {
        public long ID { get; set; }
        public String Name { get; set; }
        public String Sex { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public String Category { get; set; }
    }
}
