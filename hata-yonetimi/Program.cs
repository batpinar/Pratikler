using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("girmiş olduğunuz sayi: " + sayi);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hata: "+ ex.Message.ToString());
            }
            finally{
                System.Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
                
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine("Boş değer girdiniz.");
                System.Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Veri tipi uyuşmuyor.");
                System.Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine("Çok büyük veye çok küçük değer girdiniz.");
                System.Console.WriteLine(ex);
            }
            finally{
                System.Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}
