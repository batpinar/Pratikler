using System;

namespace recursive_ectension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif - Öz yineleme
            //3*4 = 3*3*3*3

            int result =1;
            for(int i = 1; i < 5; i++){
                result = result * 3;
                System.Console.WriteLine(result);
            }
                System.Console.WriteLine("**** Recursice result  ***");
            Islemler instance = new();
            System.Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar

            string ifade ="Berkan Atpınar";
            bool sonuc = ifade.checkSpaces();
            System.Console.WriteLine(ifade.checkSpaces());
            if(sonuc){
                System.Console.WriteLine(ifade.removeWhiteSpaces());
                System.Console.WriteLine(ifade.makeUpperCase());
                System.Console.WriteLine(ifade.makeLowerCase());
            }

            int [] dizi = {6,4,8,1,2,56,0,9};
            dizi.sortArray();
            dizi.ekranaYazdir();

            System.Console.WriteLine("");

            int sayi = 6;
            System.Console.WriteLine(sayi.isEvenNumber());

            System.Console.WriteLine(ifade.getFirstCharacter());
        }
    }

    public class Islemler
    {
            public int Expo(int sayi, int üs){
                if(üs<2){
                    return sayi;

                }else{
                    return Expo(sayi, üs-1)* sayi;
                }
            }
            //Expo(3,4)
            //Expo(3,3) *3;
            //Expo(3,2) *3 *3;
            //Expo(3,1) *3 *3 *3;
            // 3*3*3*3 = 3^4;
    }

        //Extension class'ının static olması gerekli
    public static class Extension
    {
         public static bool checkSpaces(this string param)
         {
              return param.Contains(" ");
         }

         public static string removeWhiteSpaces(this string param){
             string[] dizi = param.Split(" ");
             return string.Join("*",dizi);
         }

         public static string makeUpperCase(this string param)
         {
             return param.ToUpper();
         }

         public static string makeLowerCase(this string param)
         {
             return param.ToLower();
         }

         public static int[] sortArray(this int[] param)
         {
             Array.Sort(param);
             return param;
         }

         public static void ekranaYazdir(this int[] param){
             foreach (var item in param)
             {
                 System.Console.Write(item + " ");
             }
         }

         public static bool isEvenNumber(this int param){
             return param % 2 == 0;    
         }

         public static string getFirstCharacter(this string param)
         {
             return param.Substring(0,1);
         }
    }
}
