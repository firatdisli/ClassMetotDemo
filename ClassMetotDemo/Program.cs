using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 101;
            musteri1.MusteriAd = "Fırat";
            musteri1.MusteriSoyad = "Dsl";
            musteri1.MusteriBakiye = 1000;

            Musteri musteri2 = new Musteri();
            musteri2.ID = 102;
            musteri2.MusteriAd = "Ahmet";
            musteri2.MusteriSoyad = "Çlk";
            musteri2.MusteriBakiye = 1500;

            Musterşmanager.MusteriAdd(musteri1);
            Musterşmanager.MusteriSil(musteri2);

            Console.WriteLine("-----------<<<<<>>>>>----------");
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            Musterşmanager.MusteriList(musteriler);
        }
    }
}
