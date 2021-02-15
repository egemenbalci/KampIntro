using System;

namespace dongu
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kursu";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";

            //array- dizi 
            string[] kurslar = new string[] { "Yazılım geliştirici kursu", "programlamaya başlangıç için temel kurs", "java", "c#", "python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu- footer");
    
        }
        

    }
}
