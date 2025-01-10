using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPSpizirnaProjekt
{
    public class Recept<T>
    {
        Guid id;
        string nazev;
        public List<T> ingredience;
        bool dostupny = false;

        //Konstruktor
        public Recept (string jmeno, List<T> ingr)
        {
            id = Guid.NewGuid();
            nazev = jmeno;
            ingredience = ingr;
            ingredience = new List<T>();
        }

        // Destruktor
        ~Recept()
        {
            // dopsat případně pokud něco se musí dodělat při mazání
        }

        // Gettery a settery
        public string Nazev
        {
            get => nazev;
            set => nazev = value;
        }
        public bool Dostupny
        {
            get => dostupny;
            set => dostupny = value;
        }



    }
}
