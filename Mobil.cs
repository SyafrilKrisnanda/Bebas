using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebas
{
    public class Mobil
    {
        string merk;
        string tipe;
        string Ban ;

        public void NyalakanMesin(string merk, string tipe)
        {
            Console.WriteLine("Mesin Mobil " + merk + " bertipe " + tipe + " Menyala");
        }

        public void MatikanMesin(string merk, string tipe)
        {
            Console.WriteLine("Mesin Mobil " + merk + " bertipe " + tipe + " Mati");
        }

    }

    public class Toyota : ToyotaBase, Mobil
    {
    }

    class Agya : Toyota
    {
        string tipe = "Toyota";
    }

    class Avanza : Toyota
    {
        string tipe = "Avanza";

        void NyalakanLampu()
        {
            Console.WriteLine("Lampu Mobil Merk " + merk + " bertipe " + tipe + " menyala ");
        }
    }

    class Innova : Toyota
    {
        string tipe = "Innova";
    }

    class Daihatsu : Mobil
    {
        string merk= "Daihatsu";
    }

    class Ayla : Daihatsu
    {
        string tipe = "Ayla";
    }

    class Xenis : Daihatsu
    {
        string tipe = "Xenia";
    }

    class Honda : Mobil
    {
        string tipe;
    }

    class Brio : Honda
    {
        string tipe = "Brio";
    }

    class Civic : Honda
    {
        string tipe = "Civic";

        public void VtecKickedln()
        {
            Console.WriteLine(" Ngeeng Woooshh!!!!");
        }
    }

}
