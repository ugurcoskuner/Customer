using System;
using System.Collections.Generic;
using System.Text;

namespace Musteri
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sisteme Eklnedi : " +  musteri.Id);
        }

        public void  Sil(Musteri musteri)
        {
            Console.WriteLine("Musteri Sistemden Silindi : " + musteri.Adi);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id'si : " + musteri.Id);
                Console.WriteLine("Müsteri Adi : " + musteri.Adi);
                Console.WriteLine("Müsteri Soyadi :" + musteri.Soyadi);
            }
        }
    }

}
