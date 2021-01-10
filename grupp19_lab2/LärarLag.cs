using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp19_lab2
{
    public class LärarLag
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

        public void LäggTillLärare(params Teacher[] teacher)
        {
            lärarLista.AddRange(teacher);
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




        
    }
}
