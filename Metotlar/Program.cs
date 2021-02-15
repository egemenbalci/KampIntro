using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Armut";
            urun2.Fiyati = 20;
            urun2.Aciklama = "İyi armut";

            Product[] meyveler = new Product[] { urun1, urun2 };
            foreach (Product meyve in meyveler)
            {
                Console.WriteLine(meyve.Adi);
                Console.WriteLine(meyve.Fiyati);
                Console.WriteLine(meyve.Aciklama);
                Console.WriteLine("-----------------------");


            }

            Console.WriteLine("--------------Metotlar-----------------");
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,5);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,5);
            sepetManager.Ekle2("Kayısı", "Malatya kayısısı", 12,5);




        }
    }
}
