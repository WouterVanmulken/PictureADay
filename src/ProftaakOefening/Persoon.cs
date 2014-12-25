using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakOefening
{
    //unnecisary class since we use a database
    class Persoon
    {
        string naam;
        int leeftijd;


        public Persoon(string naam, int leeftijd)
        {
            this.naam = naam;
            this.leeftijd=leeftijd;
        }
        public string Naam   // the Name property
        {
            get { return naam;  }
            set { naam = value; }
        }
        public int Leeftijd   // the Name property
        {
            get { return leeftijd; }
            set { leeftijd = value; }
        }

    }
}
