using System;

namespace gittigidiyor
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Marka = "toshiba";
            urun1.Model = "model1";
            urun1.Fiyat = 1500;

            Urun urun2 = new Urun();
            urun2.Marka = "acer";
            urun2.Model = "modelz";
            urun2.Fiyat = 2500;

            Urun urun3 = new Urun();
            urun3.Marka = "monster";
            urun3.Model = "modely";
            urun3.Fiyat = 5500;


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };
            
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Marka+" "+urun.Model+" "+urun.Fiyat);
            }
            
        }
    }
    class Urun
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Fiyat { get; set; }
    }
}
