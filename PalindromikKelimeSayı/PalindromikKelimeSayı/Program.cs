using System;

namespace PalindromikKelimeSayı
{
    class Program
    {
        static void Main(string[] args)
        {

            //Girilen bir sayı ya da kelimenin palindromik olup olmadığını sorgulama:

            Console.WriteLine("  BİR SAYI YA DA YAZI GİRİŞİ YAPINIZ :  ");
            string kelime = Console.ReadLine(  );
            string kelimeTers = "";

            for (int i = kelime.Length-1; i >= 0; i--)
            {
                kelimeTers += kelime[i];
            }
            Console.WriteLine("  Girdiğiniz sayı ya da yazının tersi===>" + " " + kelimeTers  );
            if (kelime == kelimeTers)
            {
                Console.WriteLine("  Palindromiktir.  ");
            }
            else
            {
                Console.WriteLine("  Palindromik değildir.");
            }









            Console.ReadLine();
        }
    }
}
