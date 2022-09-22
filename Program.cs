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
            Mobil mobil1 = new Mobil() { merk = "Toyota", Merk = "Micheline", tipe = "Agya" };
            mobil1.NyalakanMesin("Toyota", "Agya");
            Console.WriteLine(mobil1.Merk);
/*            Console.WriteLine(mobil1.merk);
            Console.WriteLine(mobil1.tipe);
            Console.WriteLine(mobil1.Merk);*/

            Toyota mobil2 = new Toyota() { tipe = "Avanza", Merk = "Bridgestone"};
/*            Console.WriteLine(mobil2.Merk);
            Console.WriteLine(mobil2.tipe);*/
            mobil2.NyalakanMesin("Honda", "Avanza");
            

            Civic civic1 = new Civic() {merk = "Honda", Merk = "Bridgestone", tipe = "Civic"};
            civic1.VtecKickedln();
            civic1.NyalakanMesin("Honda", "Civic");

            Honda honda1 = new Honda();
            honda1.NyalakanMesin(civic1.merk, civic1.tipe);
  
        }
    }
}
