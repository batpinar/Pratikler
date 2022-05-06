using System;

namespace diziler_array_sinif_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORT
            int[] numberArray ={13,23,54,87,23,54,61,11,3,2};

            System.Console.WriteLine("*** UnOrdered Array ***");
            foreach (var number in numberArray)
            {
                System.Console.Write(number + " ");
            }

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");

            System.Console.WriteLine("*** Ordered Array ***");
            Array.Sort(numberArray);

            foreach (var number in numberArray)
            {
                System.Console.Write(number + " ");
            }

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");

            //CLEAR
            System.Console.WriteLine("*** Array Clear ***");
            Array.Clear(numberArray,6,1);
            Array.Clear(numberArray,4,1);

            foreach (var number in numberArray)
            {
                System.Console.Write(number + " ");
            }

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");

            //REVERSE

            System.Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(numberArray);

            foreach (var number in numberArray)
            {
                System.Console.Write(number + " ");
            }

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");

            //INDEXOF
            System.Console.WriteLine("*** Array IndexOf ***");

            System.Console.WriteLine("11 sayısının dizi içerisinde bulunduğu index numarası: " + Array.IndexOf(numberArray,11));

            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");

            //RESIZE

            System.Console.WriteLine("*** Array Resize ***");
            Array.Sort(numberArray);
            Array.Reverse(numberArray);
             Array.Resize<int>(ref numberArray,9);
             foreach (var number in numberArray)
            {
                System.Console.Write(number + " ");
            }

             System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");

            System.Console.WriteLine("*** After Resize added number ***");
             numberArray[8] = 99;

             foreach (var number in numberArray)
            {
                System.Console.Write(number + " ");
            }


        }
    }
}
