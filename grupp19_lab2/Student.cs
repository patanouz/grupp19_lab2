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

        public int studentId { get; private set; }
        private Dictionary<IBetygsunderlag, string> kurslista;
        public IReadOnlyDictionary<IBetygsunderlag, string> läsbarKurslista { get { return kurslista; } } //returnerar en endast läsbar Dictionary

        public Student(string förnamn, string efternamn, string personnummer, int studentId) : base(förnamn, efternamn, personnummer)
        {
            kurslista = new Dictionary<IBetygsunderlag, string>();
            this.studentId = studentId;
        }

        public override int HämtaId()
        {
            return studentId;
        }

        public void LäggTillBetysunderlag(IBetygsunderlag underlag)
        {
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


        public override string ToString()
        {
            return Förnamn + " " + efternamn;
        }


    }
}
