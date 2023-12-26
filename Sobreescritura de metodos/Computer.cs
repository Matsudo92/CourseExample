using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraDeMetodos
{
    internal class Computer
    {
        public string proccesor { get; set; }
        public string powerSupply { get; set; }
        public string motherboard { get; set; }

        public virtual string doProcess()
        {
            return "Processing in 0.5ghz...";
        }
    
    
    
    
    
    }

}
