// See https://aka.ms/new-console-template for more information,

using Metotlar;

Console.WriteLine("Hello, World!");


string urunadı = "elma";
double fiyatı = 15;
string aciklama = "amasya elması";

Urun urun1 = new Urun();
urun1.Adı = "Elma";
urun1.Fiyatı = 15;
urun1.Aciklama = "Amasya Elması";


Urun urun2 = new Urun();
urun2.Adı = "Karpuz";
urun2.Fiyatı = 30;
urun2.Aciklama = "Diyarbakır Karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2}; 

foreach (Urun urun in urunler)

{

    Console.WriteLine(urun.Adı);
    
}

Console.WriteLine(".......Metotlar.....");


SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);


sepetManager.Ekle2("Elma","kırmızı elma", 12, 10);
sepetManager.Ekle2("Armut", "iri armut", 12, 8);
sepetManager.Ekle2("elma", "yeşil elma", 12, 50);


