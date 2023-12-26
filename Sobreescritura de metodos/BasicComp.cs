using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraDeMetodos
{
    internal class BasicComp: Computer
    {
        public int ram {  get; set; }
        public int hardisc { get; set; }
        public string displayBrand {  get; set; }

        //public override string ToString()
        //{
        //    return $"The proccesor is: {proccesor}" ;
        //}

        //public override string doProcess()
        //{
        //    return $"Processing in 1.2Ghz";
        //}


    }
}
