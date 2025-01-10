using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace PAPSpizirnaProjekt
{
    public class Potravina
    {
        Guid id;
        string nazev;
        DateTime spotreba;
        int mnozstvi;

        //Konstruktor
        public Potravina (string jmeno, DateTime spotrebujdo, int novemnozstvi) {
            id = Guid.NewGuid();
            nazev = jmeno;
            spotreba = spotrebujdo;
            mnozstvi = novemnozstvi;
        }

        // Destruktor
        ~Potravina()  
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
        public DateTime Spotreba
        {
            get => spotreba;
            set => spotreba = value;
        }

        // Uprava ziskaneho data
        public string zobrazStringDatum()
        {
            return spotreba.ToString("d", CultureInfo.CreateSpecificCulture("es-ES"));
        }



    }
}
