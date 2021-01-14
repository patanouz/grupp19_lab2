using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupp19_lab2
{
    public class Student : Person
    {

        
        private Dictionary<IBetygsunderlag, string> kurslista;
        public IReadOnlyDictionary<IBetygsunderlag, string> läsbarKurslista { get { return kurslista; } } //returnerar en endast läsbar Dictionary

        public Student(string förnamn, string efternamn, string personnummer) : base(förnamn, efternamn, personnummer)
        {
            kurslista = new Dictionary<IBetygsunderlag, string>();
            
        }

        //Konstruktor som huvudsakligen behövs för att skapa studenter ifrån databasen.
        public Student(string Personnummer, string Förnamn, string Efternamn, string Email, string Telefonnummer, string Kurser, string Betyg) : base(Förnamn, Efternamn, Personnummer)
        {
            //TODO: Hantera all denna skit.
            kurslista = new Dictionary<IBetygsunderlag, string>();
            base.email = Email;
            base.telefonnummer = Telefonnummer;
        }

        public void LäggTillBetysunderlag(IBetygsunderlag underlag)
        {

            MessageBox.Show(this.HämtaNamn() + " lägger till: " + underlag.HämtaNamn());

            if(kurslista.ContainsKey(underlag))
            {
                return;
            }
            kurslista.Add(underlag, "-");

        }

        public void LäggTillBetysunderlag(IBetygsunderlag underlag, string betyg)
        {
            kurslista.Add(underlag, betyg);

        } 


        public string[] HämtaKursOchBetyglista()
        {
            string[] lista = new string[kurslista.Count];
            int i = 0;

            
            foreach (KeyValuePair<IBetygsunderlag, string> entry in kurslista)
            {
                lista[i] = entry.Key.HämtaNamn() + " " + entry.Value;
                i++;
            } 


            return lista;
        }

        public void UppdateraBetyg(IBetygsunderlag underlag, string nyttBetyg)
        {
            kurslista[underlag] = nyttBetyg; 
        }

        public void TabortKurs(IBetygsunderlag underlag)
        {
            if(kurslista.ContainsKey(underlag))
            {
                kurslista.Remove(underlag);
            }
        }


        public override string ToString()
        {
            return Förnamn + " " + efternamn;
        }


    }
}
