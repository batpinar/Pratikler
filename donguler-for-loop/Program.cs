using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("Bir sayı giriniz: ");
            // int sayi = int.Parse(Console.ReadLine());

            // for (int i = 1; i < sayi; i++)
            // {
            //     if(i % 2 == 1){
            //         System.Console.Write("Output:  ");
            //         System.Console.WriteLine(i);
            //     }
            
            // }

            // int tekToplam = 0;
            // int ciftToplam = 0;
            // for (int j = 1; j <1000; j++)
            // {
            //     if(j%2==1)
            //         tekToplam+= j;
            //     else
            //         ciftToplam+= j;
            // }
            // System.Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
            // System.Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);

            for(int i = 1; i < 10; i++ ){
                if(i==4)
                break;
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine("--------------------");

            for(int j = 1; j<10; j++){
                if(j==5)
                continue;
                System.Console.Write(j+" ");
            }

        }
    }
}