using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            //TryParse bool bir deger döner
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc){
                System.Console.WriteLine("Başarılı!");
                System.Console.WriteLine(outSayi);
            }
            else{
                System.Console.WriteLine("Başarısız!");
            }

            Metotlar instance = new Metotlar();
            instance.Toplam(11,3, out int toplamSonuc);
            System.Console.WriteLine(toplamSonuc);

            // Metot Aşırı Yükleme - OverLoading
            int ifade = 999;
            instance.ekranaYazdır(Convert.ToString(ifade));
            instance.ekranaYazdır(ifade);
            instance.ekranaYazdır("Berkan ","Atpınar");



        }
    }

    class Metotlar{
        public void Toplam(int a, int b, out int toplam){
            toplam = a+b;
        }

        public void ekranaYazdır(string veri){
            System.Console.WriteLine(veri);
        }

        public void ekranaYazdır(int veri){
            System.Console.WriteLine(veri);
        }

        public void ekranaYazdır(string veri1, string veri2){
            System.Console.WriteLine(veri1 + veri2);
        }
    }
}
