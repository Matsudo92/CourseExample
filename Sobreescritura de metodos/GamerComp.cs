using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraDeMetodos
{
    internal class GamerComp : Computer
    {
        public GamerComp() 
        {
            Processor = new Processor();
        }
        
       public string Case { get; set; }
       public int Fans { get; set; }

       public Processor Processor { get; }

       public VideoCard VideoCard { get; set; }


    }
}


