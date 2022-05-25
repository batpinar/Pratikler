namespace abstract_siniflar
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public virtual Renk StandartrengiNe()
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarkaninAraci(); 

    }
}