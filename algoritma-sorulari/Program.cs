using System;

namespace algoritma_sorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının 
            // girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            /*
            System.Console.Write("Lütfen pozitif bir sayı giriniz: ");
            int numberPositive = Convert.ToInt32(Console.ReadLine());
            int [] numbers = new int[numberPositive] ;
            for (int i = 0; i < numberPositive; i++)
            {
                System.Console.Write("Girmiş olduğunuz sayı kadar pozitif sayı giriniz: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var number in numbers)
            {   
                if(number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
                
            }
            */
            //*******************************************************************************

            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //  Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş 
            // olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            /*
            System.Console.Write("Lütfen  bir sayı giriniz ve bu sayı m olsun: ");
            int m = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Lütfen bir sayı daha girin ve bu sayı n olsun: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int [] dizi = new int[n] ;
            for (int i = 0; i < n; i++)
            {
                System.Console.Write("Girmiş olduğunuz n sayısı adetince pozitif sayı giriniz: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            foreach (var sayi in dizi)
            {
                if(sayi == m){
                    Console.WriteLine(sayi + " sayısı m'e eşit.");
                }
                else if (sayi % m == 0)
                {
                    Console.WriteLine(sayi + " sayısı m'e tam bölünüyor");
                }
            }
            */
            //*******************************************************************************

            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            //  Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini 
            // yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            /*
            System.Console.Write("Lütfen pozitif bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string [] words = new string[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write(i+1 +". kelime: ");
                words[i] = Console.ReadLine();
            }

            Array.Reverse(words);

            foreach (var word in words)
            {
                System.Console.Write(word + " ");
            }
            */
            //*******************************************************************************

            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //  Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            System.Console.WriteLine("Metni girin: ");
            string sentences = Console.ReadLine();

            string [] words = sentences.Split(' ');
            System.Console.WriteLine("Cümledeki kelime sayısı: " + words.Length);
            
            string[] dizi = sentences.Split(" ");
            sentences = string.Join("",dizi);

            System.Console.WriteLine(sentences);

            char [] harfler = sentences.ToCharArray();

            foreach (var harf in harfler)
            {
                System.Console.Write(harf + " ");
            }

            System.Console.WriteLine();

            int harfSayisi = harfler.Length;

            System.Console.WriteLine("Cümledeki toplam harf sayısı: " + harfSayisi);
              
        } 
    }
}
