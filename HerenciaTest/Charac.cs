using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTest
{
    abstract internal class Charac
    {
        public int Strength { get; set; } 
        public int Agility { get; set; }
        public int Intelligence { get; set; }

        public string name { get; set; }
        public string skillType { get; set; }
    }
}
