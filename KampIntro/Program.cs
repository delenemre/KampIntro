// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string KategoriEtiketi = "Kategori";

int OgrenciSaisi = 32000;

double FaizOrani = 1.45;

double DolarDun = 7.35;

double DolarBugun = 7.45;




bool SistemeGFirisYapmismi = false;


if (DolarDun > DolarBugun)
{
    Console.WriteLine ("AzalışButonu");

}
else if (DolarDun<DolarBugun)
{
    Console.WriteLine("Artıs Butonu");

     
}
else
{
    Console.WriteLine("Degismedi Oku");


}





if (SistemeGFirisYapmismi == true )
{
    Console.WriteLine("kULLanıcı Ayarları Butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}

Console.WriteLine (KategoriEtiketi);
