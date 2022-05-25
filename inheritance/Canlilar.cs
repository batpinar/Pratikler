using System;

namespace inheritance
{
    public  class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar Beslenir.");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }
        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar");
        }

        public virtual void UyaranlarTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}