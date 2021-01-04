using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp19_lab2
{

    //får köra denna på engelska för det finns redan något som heter lärare och jag är dålig på synonymer och är för trött för att googla.
    public class Teacher : Person
    {
        public int lärarId { get; private set; } 
        public Teacher(string förnamn, string efternamn, string personnummer, int lärarId) : base(förnamn, efternamn, personnummer)
        {
            this.lärarId = lärarId;
        }

        public override int HämtaId()
        {
            return lärarId;
        }
    }
}
