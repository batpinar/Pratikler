using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Köpek","Kuş"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve Eğirişim
            renkler[0] = "Mavi";

            dizi[3] = 10;

            System.Console.WriteLine(hayvanlar[1]);
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(renkler[0]);

            //Döngüler dizi kullanımı
            //Klavyeden girilen n tane değerin ortalamasını bulan program

            System.Console.WriteLine("Lütfen dizinin eleman sayısını giriniz: ");
            int diziLength = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziLength];

            for(int i = 0; i < diziLength; i++){
                System.Console.WriteLine("Lütfen {0}. sayıyı giriniz",i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayıDizisi)
            {
                toplam += sayi;
            }
            System.Console.WriteLine("Ortalama: " + toplam/diziLength);
        }
    }
}
