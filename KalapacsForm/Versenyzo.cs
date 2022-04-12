using System.Linq;

namespace KalapacsForm
{
    internal class Versenyzo
    {
        public string Nev { get; private set; }
        public char Csoport { get; private set; }
        private string NemzetEsKod { get; set; }
        private float[] Dobasok { get; set; } = new float[3];

        public float Eredmeny
        {
            get
            {
                float e = this.Dobasok.Max();
                return e >= 0 ? e : -1F;
            }
        }

        public string Nemzet =>
            this.NemzetEsKod.Substring(0, this.NemzetEsKod.Length - 6);

        public string Kod =>
            this.NemzetEsKod.Split(' ').Last().Trim('(', ')');

        public string Sorozat { get; private set; }

        public Versenyzo(string sor)
        {
            var splts = sor.Split(';');

            this.Nev = splts[0];
            this.Csoport = char.Parse(splts[1]);
            this.NemzetEsKod = splts[2];

            this.Sorozat = $"{splts[3]};{splts[4]};{splts[5]}";

            for (int i = 0; i < this.Dobasok.Length; i++)
            {
                if (splts[i + 3] == "X")
                    this.Dobasok[i] = -1F;
                else if (splts[i + 3] == "-")
                    this.Dobasok[i] = -2F;
                else
                    this.Dobasok[i] = float.Parse(splts[i + 3]);
            }
        }

    }
}
