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
        List<LärarLag> lärarlag = new List<LärarLag>();
        private string email { get; set; }
        private string telefonnummer { get; set; }
        public Teacher(string förnamn, string efternamn, string personnummer) : base(förnamn, efternamn, personnummer)
        {
            
        }

        //Konstruktor som huvudsakligen behövs för att skapa lärare ifrån databasen.
        public Teacher(string Personnummer, string Förnamn, string Efternamn, string Email, string Telefonnummer) : base(Förnamn, Efternamn, Personnummer)
        {

            this.email = Email;
            this.telefonnummer = Telefonnummer;
                             
        }

        public void LäggtillLärarlag(params LärarLag[] lärarlag)
        {
            this.lärarlag.AddRange(lärarlag);
        }

        public override string ToString()
        {
            return HämtaNamn();
        }

    }
}
