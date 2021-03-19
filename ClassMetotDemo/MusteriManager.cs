using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + " Artık Yeni Müşterimizsiniz");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.İd + " : id li Kullanıcı Silindi");
        }
    }
}

