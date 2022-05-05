using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {   
            // System.Console.WriteLine("Lütfen bir sayı giriniz.");
            // int sayi = int.Parse(Console.ReadLine());
            // int sayac = 1;
            // int toplam = 0;
            // while(sayac<=sayi){
            //     toplam+=sayac;
            //     sayac++;
            // }
            // System.Console.WriteLine(toplam/sayi);

            // 'a' dan 'z' ye kadar olan harfleri conlose a  yazdır.

            // char ch = 'a';
            //     while (ch <= 'z')
            //     {
            //         System.Console.Write(ch + " ");
            //         ch++;

            //     }

            // FOREACH

            string[] arabalar = {"BMW", "FORD", "TOYOTA", "NISSAN", "OPEL"};

            foreach (var araba in arabalar)
            {
                System.Console.Write(araba + "  ");
            
            }
        } 
    }
}
