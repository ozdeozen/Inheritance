using System;
class BaseKisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public void AdSoyadYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}");
    }
}
class Ogrenci : BaseKisi
{
    public int OgrenciNo { get; set; }
    public void BilgiYazdir()
    {
        Console.WriteLine($"Öğrenci Numarası: {OgrenciNo}");
        AdSoyadYazdir();  // base sınıftaki metodu çağırma
    }
}
class Ogretmen : BaseKisi
{
    public double Maas { get; set; }
    public void BilgiYazdir()
    {
        Console.WriteLine($"Maaş: {Maas} TL");
        AdSoyadYazdir();  // base sınıftaki metodu çağırma
    }
}

class Program
{
    static void Main()
    {
        // öğrenci nesnesi oluşturma ve değer atama
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Özde",
            Soyad = "Özen",
            OgrenciNo = 42223
        };

        // öğretmen nesnesi oluşturma ve değer atama
        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Ayla",
            Soyad = "Özen",
            Maas = 75000.50
        };

        // konsol ekranına bilgileri yazdırma
        Console.WriteLine("Öğrenci Bilgileri:");
        ogrenci.BilgiYazdir();

        Console.WriteLine("\nÖğretmen Bilgileri:");
        ogretmen.BilgiYazdir();
    }
}
