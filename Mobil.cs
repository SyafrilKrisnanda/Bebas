using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebas
{
    public class Mobil
    {
        public string merk = "";
        public string tipe = "";

        public void NyalakanMesin(string merk, string tipe)
        {
            Console.WriteLine("Mesin Mobil " + merk + " bertipe " + tipe + " Menyala");
        }

        public void MatikanMesin(string merk, string tipe)
        {
            Console.WriteLine("Mesin Mobil " + merk + " bertipe " + tipe + " Mati");
        }

    }

    public class Toyota : Mobil
    {
        public new string merk = "Toyota";
    }

    class Agya : Toyota
    {
        public new string tipe = "Agya";
    }

    class Avanza : Toyota
    {
        public new string tipe = "Avanza";

        public void NyalakanLampu(string merk, string tipe)
        {
            Console.WriteLine("Lampu Mobil Merk " + merk + " bertipe " + tipe + " menyala ");
        }
    }

    class Innova : Toyota
    {
       public new string tipe = "Innova";
    }

    class Daihatsu : Mobil
    {
        public new string merk= "Daihatsu";
    }

    class Ayla : Daihatsu
    {
        public new string tipe = "Ayla";
    }

    class Xenis : Daihatsu
    {
        public new string tipe = "Xenia";
    }

    class Honda : Mobil
    {
        public new string tipe = "honda";
    }

    class Brio : Honda
    {
        public new string tipe = "Brio";
    }

    class Civic : Honda
    {
        public new string tipe = "Civic";

        public void VtecKickedln()
        {
            Console.WriteLine(" Ngeeng Woooshh!!!!");
        }
    }

}
