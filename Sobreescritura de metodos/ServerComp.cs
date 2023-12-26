

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituraDeMetodos
{
    internal class ServerComp:Computer, highBenchMark

    {
        public string benchMark()
        {
            return "Doing BenachMark on a server computer";
        }
    }
}
