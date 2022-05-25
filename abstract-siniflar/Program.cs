using System;

namespace abstract_siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************** INTERFACE *******************");
           Focus focus = new Focus();
           Console.WriteLine(focus.HangiMarkaninAraci().ToString());
           Console.WriteLine(focus.KacTekerlektenOlusur());
           Console.WriteLine(focus.StandartrengiNe().ToString());

           Console.WriteLine("***********************************");
           Civic civic = new Civic();
           Console.WriteLine(civic.HangiMarkaninAraci().ToString());
           Console.WriteLine(civic.KacTekerlektenOlusur());
           Console.WriteLine(civic.StandartrengiNe().ToString());

            //Yukardaki oluşturduğumuz kod yapısını interface ile oluşturduk.
            //Aşağıda oluşturduğumuz kod yapısı interface yapısnın eksiklerini
            //abstract ile  refactor ederek yeni bir yapı oluşturduk.
            
            Console.WriteLine("**************** ABSTRACT *******************");
            NewFocus newFocus = new NewFocus();
            Console.WriteLine(newFocus.HangiMarkaninAraci().ToString());
            Console.WriteLine(newFocus.KacTekerlektenOlusur());
            Console.WriteLine(newFocus.StandartrengiNe().ToString());

            Console.WriteLine("***********************************");
            NewCivic newCivic = new NewCivic();
            Console.WriteLine(newCivic.HangiMarkaninAraci().ToString());
            Console.WriteLine(newCivic.KacTekerlektenOlusur());
            Console.WriteLine(newCivic.StandartrengiNe().ToString());


        }
    }
}
