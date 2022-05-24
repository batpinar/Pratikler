using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;

            Console.WriteLine("Class Alan Hesapla : {0}",dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_struct;
            dikdortgen_struct.KisaKenar = 3;
            dikdortgen_struct.UzunKenar = 4;
             // new Dikdortgen_Struct(3,4);
             // new ile oluşturmadan da struct çağırabiliriz
             //Structlar initial değer atamıyor. null ve benzeri gibi
            Console.WriteLine("Struct Alan Hesapla : {0}",dikdortgen_struct.AlanHesapla());
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        //Construtor
        public Dikdortgen()
        {
            KisaKenar = 5;
            UzunKenar = 6;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        //Parametresiz Struct constuctor oluşturamıyoruz. Parametre alması lazım.
        public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
