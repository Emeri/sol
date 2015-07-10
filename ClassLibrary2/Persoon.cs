using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Persoon
    {
        private DateTime _geboorteDatum;

        public DateTime GeboorteDatum
        {
            get { return _geboorteDatum; }
            set { _geboorteDatum = value; }
        }

        public int GeefLeeftijd()
        {
           
            int leeftijd = (DateTime.Today.Year - this._geboorteDatum.Year) - 1;
            if (DateTime.Today.Month > this._geboorteDatum.Month ||
                    ((DateTime.Today.Month == this._geboorteDatum.Month) && (DateTime.Today.Day >= this._geboorteDatum.Day)))
            {
                leeftijd++;
                // comment
            }

            return leeftijd;
        }
    }
}
