namespace Delegati
{
    internal class Radnik
    {
        public Radnik(string ime, string prezime, string radnoMesto)
        {
            Ime = ime;
            Prezime = prezime;
            RadnoMesto = radnoMesto;
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string RadnoMesto { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime + " " + RadnoMesto;
        }
    }
}