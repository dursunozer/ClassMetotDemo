using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.İd = 1;
            musteri1.MusteriAdi = "Dursun";
            musteri1.Musterisoyadi = "Özer";

            Musteri musteri2 = new Musteri();
            musteri2.İd = 2;
            musteri2.MusteriAdi = "Abdussamed";
            musteri2.Musterisoyadi = "Özer";

            Musteri musteri3 = new Musteri();
            musteri3.İd = 3;
            musteri3.MusteriAdi = "Engin";
            musteri3.Musterisoyadi = "Demirog";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var item in musteriler)
            {
                Console.WriteLine("Müşteri İd : " + item.İd);
                Console.WriteLine("Müşteri Adı : " + item.MusteriAdi);
                Console.WriteLine("Müşteri Soyadı : " + item.Musterisoyadi);
                Console.WriteLine("********");

            }
            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Sil(musteri2);
            musterimanager.Ekle(musteri3);

        }
    }
}