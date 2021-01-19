using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Yılmaz";
            musteri1.Yasi = 30;
            musteri1.Memleketi = "İstanbul";
            musteri1.Meslegi = "Öğretmen";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Çamlı";
            musteri2.Yasi = 42;
            musteri2.Memleketi = "İzmir";
            musteri2.Meslegi = "Mühendis";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Selma";
            musteri3.Soyadi = "Demirci";
            musteri3.Yasi = 23;
            musteri3.Memleketi = "Çanakkale";
            musteri3.Meslegi = "Öğrenci";



            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Sil(musteri2);
            musterimanager.Listele(musteri3);
        }
    }
}
