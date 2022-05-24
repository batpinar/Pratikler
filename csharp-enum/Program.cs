using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;
            if (sıcaklık <= (int)HavaDurumu.Normal)
            {
                System.Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekliyelim");
            }else if (sıcaklık >= (int)HavaDurumu.Sıcak || sıcaklık > (int)HavaDurumu.CokSıcak)
            {
                System.Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.Sıcak)
            {
                System.Console.WriteLine("Hadi dışarı çıkalım");
            }
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk =5,
        Normal = 20,
        Sıcak = 30,
        CokSıcak = 35

    }
}
