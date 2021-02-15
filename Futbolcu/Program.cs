using System;

namespace Futbolcu
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolcu gs = new Futbolcu();
            gs.Ad = "Muslera";
            gs.Mevki = "Kaleci";
            gs.No = 1;

            Futbolcu fb = new Futbolcu();
            fb.Ad = "Gustavo";
            fb.Mevki = "Orta saha";
            fb.No = 20;

            Futbolcu bjk = new Futbolcu();
            bjk.Ad = "Atiba";
            bjk.Mevki = "Orta saha";
            bjk.No = 13;

            Futbolcu[] futbol = new Futbolcu[] { gs, fb, bjk };
            foreach (var futbolcu in futbol)
            {
                Console.WriteLine(futbolcu.Mevki + " "+futbolcu.No+" "+futbolcu.Ad);
            }
        }
    }
    class Futbolcu
    {
        public string Ad { get; set; }
        public string Mevki { get; set; }
        public int No { get; set; }
    }
}
