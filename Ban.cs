using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebas
{
    public class Ban
    {
        public string Merk;
    }

    class Michelin : Ban
    {
        public string Merk = "Michelin";
    }

    class Bridgestone : Ban
    {
        public string Merk = "Bridgeston";
    }
}
