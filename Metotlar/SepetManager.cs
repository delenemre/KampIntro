using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi : " + urun.adı);



        }

        public void Ekle2(string urunadi , string aciklama, double fiyat, int stokAdeti)
        {


            Console.WriteLine( "Tebrikler sepete eklendi :" + urunadi );
        }
    }
}
