using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //değer tutucu- alias (takma isim)

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("eşittir butonu");
            }
            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("sisteme giriş başarılı");

            }
            else
            {
                Console.WriteLine("sisteme giriş hatalı");
            }
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
