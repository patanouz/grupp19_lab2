using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp19_lab2
{
    public class LärarLag : ILärarlag
    {

        private List<Teacher> lärarLista;
        private List<Kurs> kursLista;

        public string lagNamn { get; set; }

        public LärarLag(string lagNamn)
        {
            this.lagNamn = lagNamn;
            lärarLista = new List<Teacher>();
            kursLista = new List<Kurs>();
        }

        //Konstruktor som huvudsakligen behövs för att skapa lärarlag ifrån databasen.
        public LärarLag(Int64 Id, string LärarLista)
        {
            //TODO: fixa detta
        }

        public void LäggTillLärare(params Teacher[] teacher)
        {
            lärarLista.AddRange(teacher);
            
            foreach (Teacher t in teacher)
            {
                t.LäggtillLärarlag(this);
            }
        }

        public void LäggTillKurs(params Kurs[] kurser)
        {
            kursLista.AddRange(kurser);
        }

        public string HämtaNamn()
        {
            return lagNamn;
        }

        public void TaBortLärare(params Teacher[] teacher)
        {
            foreach(Teacher t in teacher)
            {
                if(lärarLista.Contains(t))
                {
                    lärarLista.Remove(t);
                }
            }
        }

        public void TaBortKurs(params Kurs[] kurs)
        {
            foreach (Kurs k in kurs)
            {
                if (kursLista.Contains(k))
                {
                    kursLista.Remove(k);
                }
            }
        }

        public override string ToString()
        {
            return HämtaNamn();
        }


    }
}
