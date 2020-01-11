namespace Delegati
{
    internal class Auto
    {
        public Auto(string marka, string model, int godiste)
        {
            Marka = marka;
            Model = model;
            Godiste = godiste;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public int Godiste { get; set; }

        public override string ToString()
        {
            return Marka + " " + Model + " " + Godiste;
        }
    }
}