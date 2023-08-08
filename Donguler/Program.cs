// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string kurs1 = "Yazılım Gelıstırmr";
string kurs2 = "Programlama Baslangıc";
String kurs3 = "java";

//array dizi birden fazla ürün tutmak ıcın
// length eleman sayısı dongude . konularak kullanılır
// DİZELERİ DONGU ILE CALISTIRDIK

string[] kurslar = new string[] { "Yazılım Gelıstırmr", "Programlama Baslangıc",

    "java","python"};






for (int i = 0; i < kurslar.Length; i++)

{
    Console.WriteLine(kurslar[i]);

}

Console.WriteLine("for bıttı foreach yazılacak ");



foreach (string kurs in kurslar)

{
    Console.WriteLine(kurs);
     
}

Console.WriteLine("sayfasonu");






