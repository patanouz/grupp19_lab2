using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp19_lab2
{
    public abstract class Person : IPerson
    {
        public string Förnamn { get; set; }
        public string efternamn { get; set; }
        public string personnummer { get; private set; }


        public Person(string förnamn, string efternamn, string personnummer)
        {
            this.Förnamn = förnamn;
            this.efternamn = efternamn;
            this.personnummer = personnummer;

        }

        public virtual int HämtaId()
        {
            //anta att -1 är en felkod, det ska inte gå att ha -1 som id. 
            return -1;
        }

        public string HämtaNamn()
        {
            return Förnamn + " " + efternamn;
        }
    }
}
