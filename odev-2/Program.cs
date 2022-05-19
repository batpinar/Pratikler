using System;
using System.Collections;
using System.Collections.Generic;



namespace odev_2
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ 1. Soru ************");
            // Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın.
            //  (ArrayList sınıfını kullanara yazınız.)
                // Negatif ve numeric olmayan girişleri engelleyin.
                // Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                // Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

                // Console.WriteLine("Klavyeden 20 adet pozitif sayı giriniz: ");
                // int n = 20;
                // ArrayList asalSayilar = new ArrayList();
                // ArrayList asalOlmayanSayilar = new ArrayList();
                // int asalToplam = 0;
                // int asalOlmayanToplam = 0;
                // try
                // {
                //     for (int i = 0; i < n; i++)
                //     {
                //         int number = int.Parse(Console.ReadLine()) ;
                //         if(asalmi(number))
                //         {
                //             asalSayilar.Add(number);
                //             asalToplam += number;
                //         }else
                //         {
                //             asalOlmayanSayilar.Add(number);
                //             asalOlmayanToplam += number;
                //         }
                //     }
                // }
                // catch (System.Exception)
                // {
                //     System.Console.WriteLine("Yanlış değer girdiniz.");
                // }
                
                // asalSayilar.Sort();
                // asalSayilar.Reverse();
                // System.Console.WriteLine("****** Asal Sayilar ******");
                // System.Console.WriteLine(asalSayilar.Count);
                // System.Console.WriteLine(asalToplam / n);
                // foreach (var item in asalSayilar)
                // {
                //     System.Console.Write(item + " ");
                // }

                //     System.Console.WriteLine("");

                // asalOlmayanSayilar.Sort();
                // asalOlmayanSayilar.Reverse();
                // System.Console.WriteLine("****** Asal Olmayan Sayilar ******");
                // System.Console.WriteLine(asalOlmayanSayilar.Count);
                // System.Console.WriteLine(asalOlmayanToplam / n);
                // foreach (var item in asalOlmayanSayilar)
                // {
                //     System.Console.Write(item + " ");
                // }

                Console.WriteLine("************ 2. Soru ************");
                // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
                // her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama
                // toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
                // ArrayList sayilar = new ArrayList();
                // var n = 20;
                // Console.WriteLine("Klavyeden 20 adet sayı giriniz: ");
                
                // for (int i = 0; i < n; i++)
                // {
                //     int number = int.Parse(Console.ReadLine()) ;
                //     sayilar.Add(number);
                // }
                // sayilar.Sort();
                // System.Console.WriteLine("*** En küçük 3 sayı ***");
                // for (int i = 0; i < 3; i++)
                // {
                //     Console.WriteLine(sayilar[i]);
                // }
                // sayilar.Reverse();
                // System.Console.WriteLine("*** En büyük 3 sayı ***");
                // for (int i = 0; i < 3; i++)
                // {
                //     Console.WriteLine(sayilar[i]);
                // }

                Console.WriteLine("************ 3. Soru ************");
                // Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde 
                // saklayan ve dizinin elemanlarını sıralayan programı yazınız.
                
                char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
                ArrayList sesliDizi = new ArrayList();
                Console.Write("Cümle Giriniz: ");
                string cumle = Console.ReadLine().ToLower();

                for (int i = 0; i < sesliler.Length; i++)
                {
                    for (int j = 0; j < cumle.Length; j++)
                    {
                        if (cumle[j] == sesliler[i])
                        {
                            sesliDizi.Add(sesliler[i]);
                        }
                    }
                }   
                foreach (var sesli in sesliDizi)
                {
                    System.Console.WriteLine(sesli + " ");
                }
        }

        
        // public static bool asalmi(int sayi)
        // {
        //     bool durum = false;
 
        //     int kontrol = 0;
 
        //     for (int i = 2; i < sayi; i++)
        //     {
        //          if (sayi % i == 0) 
        //         {
        //             kontrol = 1;
        //             break;
        //         }
        //     }
        //     if (kontrol == 1)
        //     {
        //         durum = false;
        //     }
        //     else
        //     {
        //         durum = true;
        //     }
        //     return durum;
        // }
    }
}
