using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPSpizirnaProjekt
{
    public class Ingredience
    {
        string nazev;
        int mnozstvi;
        Recept kampatri;

        // Konstruktor
        public Ingredience (string jmeno, int novemnozstvi, Recept recept)
        {
            nazev = jmeno;
            mnozstvi = novemnozstvi;
            kampatri = recept;
        }

        // Destruktor
        ~Ingredience()
        {
            // dopsat případně pokud něco se musí dodělat při mazání
        }

        // Gettery a settery pro vlasnosti
        public string Nazev
        {
            get => nazev;
            set => nazev = value;
        }
        public int Mnozstvi
        {
            get => mnozstvi;
            set => mnozstvi = value;
        }

    }
}
