using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Dortıslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç :" + toplam);
        }

        public void Cıkar(int sayi1, int sayi2)
        {
            int Kalan = sayi1 - sayi2;
            Console.WriteLine("Sonuç :" + Kalan);
        }

        public void Carp(int sayi1, int sayi2)
        {
            int Carpımı = sayi1 * sayi2;
            Console.WriteLine("Sonuç :" + Carpımı);
        }

        public void Bolme(int sayi1, int sayi2)
        {
            int Bolum = sayi1 / sayi2;
            Console.WriteLine("Sonuç :" + Bolum );
        }




    }
}
