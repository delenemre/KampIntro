// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





    Dortıslem dortıslem = new Dortıslem();
    dortıslem.Topla(5, 6);

    dortıslem.Topla(6, 9);




internal class Dortıslem
{
    public void Topla(int sayi1, int sayi2)
    {
        int toplam = sayi1 + sayi2;
        Console.WriteLine("Sonuç :" + toplam);
    }
}
