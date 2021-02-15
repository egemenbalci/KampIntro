using System;

namespace gunler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hafta = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            foreach (string gunler in hafta)
            {
                Console.WriteLine(gunler);
            }
        }
    }
}
