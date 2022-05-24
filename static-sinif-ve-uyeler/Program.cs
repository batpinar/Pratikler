using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayse", "Yılmaz" , "IK");
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Deniz", "Arda" , "IK");
            Calisan calisan2 = new Calisan("Berkan", "Atpınar" , "IK");
            Console.WriteLine("Çalışan Sayısı: {0}",Calisan.CalisanSayisi);

            Islemler.Topla(100,200);
            Console.WriteLine("Toplama işlemi sonucu: {}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu: {}",Islemler.Çıkar(400,200));

        }
    }

    class Calisan
    {
        private static int _calisanSayisi;

        public static int CalisanSayisi { get => _calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            _calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            _calisanSayisi++; 
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2 ;
        }

        public static long Çıkar(int sayi1,int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
