using System;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id= 1111111;
            musteri1.Adi = "Uğur";
            musteri1.Soyadi = "Coşkuner";
            musteri1.Yasi = 28;


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2222222;
            musteri2.Adi = "Nur";
            musteri2.Soyadi = "Coşkuner";
            musteri2.Yasi = 27;


            Musteri[] musteriler = new Musteri[] {musteri1,musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine( "----Müşteri Listesi-----" );

            musteriManager.Listele(musteriler);

            Console.WriteLine("---Eklendi---");
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("---Silindi---");
            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);


            
         
        }
    }
}
