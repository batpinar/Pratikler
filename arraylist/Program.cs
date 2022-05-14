using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            
            ArrayList list = new ArrayList();
                // list.Add("Ayşe");
                list.Add(2);
                // list.Add(true);
                // list.Add('A');

                //içerisinde verilere erişim

                // Console.WriteLine(list[1]);

                // foreach (var item in list)
                // {
                //     Console.WriteLine(item);
                // }

                //AddRange
                Console.WriteLine("****** Add Range *******");
                // string[] renkler = {"kırmızı", "sarı","yeşil"};
                List<int> sayilar= new List<int>(){1,3,7,23,8,6};
                // list.AddRange(renkler);
                list.AddRange(sayilar);

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

                //Sort
                Console.WriteLine("****** Sort *****");
                list.Sort();

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

                //Binary Search
                Console.WriteLine("****** Binary Search ******");
                Console.WriteLine(list.BinarySearch(9));

                //Reverse
                Console.WriteLine("****** Reverse ******");
                list.Reverse();

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

                //Clear
                list.Clear();

                

        }
    }
}
