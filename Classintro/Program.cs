// See https://aka.ms/new-console-template for more information
using System;


//static void kodu class tanımlama için referans bulur
static  void Main(string[] args)
{
    string adi = "emre";
    int yas = 26;

Kurs kurs1 = new Kurs();

    kurs1.KursAdi = "c#";
    kurs1.Egitmeni = "emre";
    kurs1.izlenmeOrani = 85;

    Kurs kurs2 = new Kurs();
    kurs2.KursAdi = "python";
    kurs2.Egitmeni = "ahmnet";
    kurs2.izlenmeOrani = 65;

    Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmeni);


}
class Kurs

{
    public string KursAdi { get; set; }

    public string Egitmeni { get; set; }

    public string izlenmeOrani { get; set; }


}







Console.WriteLine("Hello, World!");



 


