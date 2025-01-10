using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAPSpizirnaProjekt
{
    public class SpravaJidel <T>
    {
        public List<T> listPotravin;
        public List<T> nakupniSeznam;

        //Konstruktor
        public SpravaJidel()
        {
            listPotravin = new List<T>();
            nakupniSeznam = new List<T>();
    }

        // SEZNAM PORTRAVIN
        // pridani potraviny do seznamu potravin
        public void pridejPotravinuNaList(T nove)
        {
            listPotravin.Add(nove);
        }

        public void smazPotravinu (Guid idPotraviny)
        {
            // TODO
        }

        //ziskani seznamu proslych potravin
        public List<T> proslePotraviny ()
        {
            DateTime dnes = DateTime.Today;
            List<T> proslepotraviny = new List<T>();
            foreach (T potravina in listPotravin)
            {
                // TODO
                // kdyz bude spotreba mensi nez promenna dnes
            }
            return proslepotraviny;
        }

        // ziskani seznamu potravin co za tyden projdou
        public List<T> prochazejiciPotraviny()
        {
            DateTime dnes = DateTime.Today;
            DateTime zatyden = DateTime.Today.AddDays(7);
            List<T> prochazejicipotraviny = new List<T>();
            foreach (T potravina in listPotravin)
            {
                // TODO
                // kdyz bude spotreba mezi promennou dnes (vcetne) a promennou zatyden
            }
            return prochazejicipotraviny;
        }

        // ziskani seznamu potravin co jsou ok
        public List<T> okPotraviny()
        {
            DateTime zatyden = DateTime.Today.AddDays(7);
            List<T> okpotraviny = new List<T>();
            foreach (T potravina in listPotravin)
            {
                // TODO
                // kdyz bude spotreba vetsi nez promenna zatyden
            }
            return okpotraviny;
        }





        // NAKUPNI SEZNAM
        // pridani potraviny do nakupniho seznamu
        public void pridejPotravinuNaNakupak(T nove)
        {
            nakupniSeznam.Add(nove);
        }

        // smazani celeho nakupniho seznamu
        public void smazNakupniSeznam(T nove)
        {
            nakupniSeznam.Clear();
        }





    }

}