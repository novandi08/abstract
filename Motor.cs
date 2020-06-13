using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract19112879
{
    public class Motor : Darat
    {
        public Motor()
        {
            Warna = "Merah";
            JumlahRoda = 2;
            Kecepatan = 100;
        }

        public override void Mengerem()
        {
            Console.WriteLine("Motor Mengerem .. !!!");
        }
    }
}
