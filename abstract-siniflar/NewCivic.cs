namespace abstract_siniflar
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }

        public override Renk StandartrengiNe()
        {
            return Renk.Gri;
        }
    }
}