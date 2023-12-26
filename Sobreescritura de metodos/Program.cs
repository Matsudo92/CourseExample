
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraDeMetodos   
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BasicComp serv1 = new BasicComp();
            //serv1.proccesor = "i3";
            //serv1.displayBrand = "Samsung Curve";

            //AverageComp serv2 = new AverageComp();
            //serv2.proccesor = "i5";

            //List<Computer> computers = new List<Computer>();
            //computers.Add(serv1);
            //computers.Add(new GamerComp());
            //computers.Add(new Laptop());
            //computers.Add(serv2);
            //computers.Add(new BasicComp());
            //computers.Add(new ServerComp());

            //// I create a list of interface from interface highBenchMark
            //List<highBenchMark> listBenachMarkComp = new List<highBenchMark>();
            //listBenachMarkComp.Add(new ServerComp());
            //listBenachMarkComp.Add(new GamerComp());
            


            //foreach (Computer item in computers) 
            //{
            //    Console.WriteLine(item.doProcess());
            //}

            //Computer comp1 = serv1;
            //BasicComp pc1 = (BasicComp)comp1;

            //pc1.displayBrand = "Cosarir";
            //Console.WriteLine(serv1.displayBrand);
            //Console.WriteLine(serv2.doProcess());

            GamerComp gcomp1 = new GamerComp();
            gcomp1.VideoCard = new VideoCard();

            Console.ReadKey();
        }
    }
}
