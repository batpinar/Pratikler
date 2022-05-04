using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            sbyte b = 20;
            short c = 39;

            int d = a+b+c;
            System.Console.WriteLine("d:" + d);

            long h = d;
            System.Console.WriteLine("h:" + h);

            float i = h;
            System.Console.WriteLine("i:" + i);

            string e = "Berkan";
            char f = 'A';
            object g = e+f+d;
            System.Console.WriteLine("g:" + g);

            //explicit

            System.Console.WriteLine("Explicit Conversion");

            int x = 4 ;
            byte y = (byte)x;
            System.Console.WriteLine("y:" +y);

            int z = 100;
            byte t = (byte)z;
            System.Console.WriteLine("t:" +t);

            float w = 10.3f;
            byte v = (byte)w;
            System.Console.WriteLine("v:"+v);

            //ToString method

            int xx = 6;
            string yy = xx.ToString();
            System.Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            System.Console.WriteLine("zz:" + zz);

            //Sytem.Convert

            System.Console.WriteLine("---- System.Converte -----");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;
            
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            System.Console.WriteLine("Toplam:" + Toplam);


            //parse

            System.Console.WriteLine("--------- Parse ---------");
            ParseMethod();

        }

        public static void ParseMethod(){
            string metin1 = "10";
            string metin2 = "10.23";
            int rakam1;
            double  double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            System.Console.WriteLine("Rakam1:" + rakam1);
            System.Console.WriteLine("Double1:" + double1);

            
        }
    }
}
