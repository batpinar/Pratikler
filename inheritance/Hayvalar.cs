using System;

namespace inheritance
{
    public class Hayvalar : Canlilar
    {
        protected void Adabtasyon()
        {
            Console.WriteLine("Hayvanlar adabtasyon kurabilir.");
        }
    }

    public class Surungenler : Hayvalar
    {
        public Surungenler()
        {
            base.Adabtasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SurunerekHareketEderler()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler");
        }
    }
    
    public class Kuslar : Hayvalar
    {
        public Kuslar()
        {
            base.Adabtasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar.");
        }
    }
}