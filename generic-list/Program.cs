using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir
            List<int> sayiList = new List<int>();
            sayiList.Add(32);
            sayiList.Add(1);
            sayiList.Add(4);
            sayiList.Add(5);
            sayiList.Add(29);
            sayiList.Add(43);

            List<string> renkList = new List<string>();
            renkList.Add("Kırmızı");
            renkList.Add("Mavi");
            renkList.Add("Turuncu");
            renkList.Add("Sarı");
            renkList.Add("Yeşil");

            // Count
            Console.WriteLine(sayiList.Count);
            Console.WriteLine(renkList.Count);

            //ForEach ve List.ForEach ile elemanlara erişim
            foreach (var item in sayiList)
                Console.WriteLine(sayiList);
            foreach (var item in renkList)
                Console.WriteLine(renkList);

            sayiList.ForEach(sayi => Console.WriteLine(sayi));
            renkList.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkarma

            sayiList.Remove(4);
            renkList.Remove("Kırmızı");

            sayiList.ForEach(sayi => Console.WriteLine(sayi));
            renkList.ForEach(renk => Console.WriteLine(renk));

            sayiList.RemoveAt(0);
            renkList.RemoveAt(1);
            sayiList.ForEach(sayi => Console.WriteLine(sayi));
            renkList.ForEach(renk => Console.WriteLine(renk));

            // Liste içerisinde arama
            if(sayiList.Contains(29))
            {
                Console.WriteLine("29 Liste içerisinden bulundu.");
            }
            
            //Eleman ile index'e erişme

            Console.WriteLine(renkList.BinarySearch("Yeşil"));

            //Diziyi Listeye çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanListesi.Clear();

            //List içerisine nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Berkan";
            kullanıcı1.Soyisim = "Atpınar";
            kullanıcı1.Yas = 29;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim = "Özcan";
            kullanıcı2.Soyisim = "Çalıskan";
            kullanıcı2.Yas = 26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas=24
            });
            foreach (var kullanıcı in kullanıcıListesi)
            {
                System.Console.WriteLine("Kullanıcı Adı" + kullanıcı.Isim);
                System.Console.WriteLine("Kullanıcı Adı" + kullanıcı.Soyisim);
                System.Console.WriteLine("Kullanıcı Adı" + kullanıcı.Yas);
            }

            yeniListe.Clear();
        }
    }

    public class Kullanıcılar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
