using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            mobil1.NyalakanMesin("Toyota", "Agya");

            Mobil mobil2 = new Mobil();
            mobil2.NyalakanMesin("Daihatsu", "Ayla");
            

            Civic civic1 = new Civic();
            civic1.VtecKickedln();
        }
    }
}
