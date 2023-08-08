// See https://aka.ms/new-console-template for more information
using Matematik;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        Dortıslem dortıslem = new Dortıslem();
        //dortıslem.Topla(5, 6);

        //dortıslem.Topla(6, 9);

        //dortıslem.Cıkar(5, 6);

        //dortıslem.Carp(142, 56);

        //dortıslem.Bolme(20, 5);

        //Console.Write("Toplama İşlemi için Sayi 1 giriniz:");
        //string sayi1 = Console.ReadLine();


        //Console.Write("Toplama İşlemi için Sayi 2 giriniz:");
        //string sayi2 = Console.ReadLine();

        //dortıslem.Topla(int.Parse(sayi1), int.Parse(sayi2));

        //Console.Write("Cıkarma İşlemi için Sayi 1 giriniz");
        //string sayi11 = Console.ReadLine();

        //Console.Write("Cıkarma İşlemi için Sayi 2 giriniz");
        //string sayi22 = Console.ReadLine();

        //dortıslem.Cıkar(int.Parse(sayi11), int.Parse(sayi22));

        //Console.WriteLine("Carpma işlemi için sayı 1 giriniz");
        //string sayi5 = Console.ReadLine();

        //Console.WriteLine("Carpma islemi icin sayı 2 giriniz");
        //string sayi6 = Console.ReadLine();

        //dortıslem.Carp(int.Parse(sayi5), int.Parse(sayi6));

        //Console.WriteLine("Bölme islemi icin sayı 1 giriniz");
        //string sayi0 = Console.ReadLine();

        //Console.WriteLine("Bölme islemi icin sayı 2 giriniz");
        //string sayi00 = Console.ReadLine();

        //dortıslem.Bolme(int.Parse(sayi0), int.Parse(sayi00));

        Console.WriteLine("Toplama için 1");
        Console.WriteLine("Cıkarma icin 2");
        Console.WriteLine("Bölme icin 3");
        Console.WriteLine("Carpma icin 4");

        Console.WriteLine("Islem numarası giriniz");
        string islem = Console.ReadLine();

        Console.WriteLine("Sayı 1 giriniz");
        string sayi100= Console.ReadLine();

        Console.WriteLine("Sayı 2 giriniz");
        string sayi10 = Console.ReadLine();

        



        if (islem == "1")
        {
            dortıslem.Topla(int.Parse(sayi100), int.Parse(sayi10));
        } 

        else if (islem == "2")
        {
            dortıslem.Cıkar(int.Parse(sayi100), int.Parse (sayi10));
        }

        else if(islem == "3")
        {
            dortıslem.Bolme(int.Parse(sayi100), int.Parse(sayi10));

        }

        else if (islem == "4") {

            dortıslem.Carp(int.Parse(sayi100), int.Parse(sayi10));

        }

        else
        {



            Console.WriteLine("Hatalı islem");
        }
        








    }
}