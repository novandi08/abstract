using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract19112879
{
    public class Mobil : Darat
    {
        public Mobil()
        {
            Warna = "Merah";
            JumlahRoda = 4;
            Kecepatan = 100;
        }

        public new void Mengerem()
        {
            Console.WriteLine("Mobil Mengerem di tanah .. !!!");
        }
    }
}
