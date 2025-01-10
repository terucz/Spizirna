using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPSpizirnaProjekt
{
    class SpravaReceptu<T>
    {
        List<T> recepty;

        //Konstruktor
        public SpravaReceptu()
        { }

        // pridani noveho receptu
        public void pridejRecept(T nove)
        {
            recepty.Add(nove);
        }

        public void smazRecept (Guid idreceptu)
        {
            foreach (T recept in recepty)
            {
                // TODO
                // pokud se id v T rovna guid v parametru
            }
        }

        // ziskani dostupnych receptu
        public List<T> dostupneRecepty ()
        {
            List<T> dostupne = new List<T>();
            foreach (T recept in recepty)
            {
                dostupne.Add(recept);
            }
            return dostupne;
        }

        // ziskani nedostupnych receptu
        public List<T> nedostupneRecepty()
        {
            List<T> nedostupne = new List<T> ();
            foreach (T recept in recepty)
            {
                nedostupne.Add(recept);
            }
            return nedostupne;
        }
    }
}
