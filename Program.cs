﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract19112879
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            Mobil mobil = new Mobil();
            Motor motor = new Motor();
            Perahu perahu = new Perahu();
            Pesawat pesawat = new Pesawat();

            perahu.Melaju();
            perahu.Warna = "Hijau";
            perahu.Kecepatan = 30;
            perahu.JumlahRoda = 0;
            Console.WriteLine("Warna Perahu :{0} ", perahu.Warna);
            Console.WriteLine("Kecepatan Perahu :{0} ", perahu.Kecepatan);
            Console.WriteLine("Jumlah roda Perahu :{0} ", perahu.JumlahRoda);
            Console.WriteLine("---------------------");

            mobil.Melaju();
            Console.WriteLine("Warna Mobil :{0} ", mobil.Warna);
            Console.WriteLine("Kecepatan Mobil :{0} ", mobil.Kecepatan);
            Console.WriteLine("Jumlah roda Mobil :{0} ", mobil.JumlahRoda);
            Console.WriteLine("---------------------");

            motor.Melaju();
            Console.WriteLine("Warna Motor :{0} ", motor.Warna);
            Console.WriteLine("Kecepatan Motor :{0} ", motor.Kecepatan);
            Console.WriteLine("Jumlah roda Motor :{0} ", motor.JumlahRoda);
            Console.WriteLine("---------------------");

            pesawat.Melaju();
            Console.WriteLine("Warna Pesawat :{0} ", pesawat.Warna);
            Console.WriteLine("Kecepatan Pesawat :{0} ", pesawat.Kecepatan);
            Console.WriteLine("Jumlah roda Pesawat :{0} ", pesawat.JumlahRoda);

            Console.ReadKey();
        }
    }
}
