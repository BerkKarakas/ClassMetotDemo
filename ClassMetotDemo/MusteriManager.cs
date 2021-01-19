using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " sisteme eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " Sistemden silindi");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musteri Adi : " + musteri.Adi + ", " + "Musteri Soyadı : " + musteri.Soyadi + ", " + "Musteri Yasi : " + musteri.Yasi + ", " + "Musteri Memleketi : " + musteri.Memleketi + ", " + "Musteri Meslegi : " + musteri.Meslegi);
        }


    }
}
