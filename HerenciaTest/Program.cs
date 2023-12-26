using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SubClasse zerker = new SubClasse();
            SubClasse sage = new SubClasse();
            //The object Charac is a type abstract and cannot be instansed
            Charac mage = new Charac();
            Charac archer = new Charac();
            
            mage.Intelligence = 10;
            archer.Intelligence = 6;
            zerker.Intelligence = 1;

            List<Charac> listCharac = new List<Charac>();
            listCharac.Add(mage);
            listCharac.Add(archer);
            listCharac.Add(zerker);

            //listCharac[0].Intelligence = 5;
            //Console.WriteLine($"The intelligence of mage is: {listCharac[0].Intelligence}");
            //listCharac.Remove(zerker);

            //Console.WriteLine($"The ammount of characters are {listCharac.Count}");

            foreach(Charac pj in listCharac) 
            {
                Console.WriteLine($"Intelligence: {pj.Intelligence}");
            }

            Console.ReadKey();





            zerker.Strength = 1;

        }
    }
}
