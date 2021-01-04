using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp19_lab2
{
    public class Kurs : IBetygsunderlag
    {

        private string kursNamn;
        private int kurskod;
        private List<Student> studentLista;
        private List<Kursmoment> kursmoment;
        private LärarLag lärarlag;

        public Kurs(string kursNamn, int kurskod)
        {
            this.studentLista = new List<Student>();
            this.kursmoment = new List<Kursmoment>();
            this.kursNamn = kursNamn;
            this.kurskod = kurskod;
        }



        public void LäggTillStudent(params Student[] studenter)
        {
            studentLista.AddRange(studenter);
        }

        public int HämtaKurskod()
        {
            return kurskod;
        }

        public string HämtaNamn()
        {
            return kursNamn;
        }

        public LärarLag HämtaLärarlag()
        {
            return lärarlag;

        }

        public List<Kursmoment> HämtaKursmoment()
        {
            return kursmoment;
        }

        public void LäggTillLärarlag(LärarLag lärarlag)
        {
            this.lärarlag = lärarlag;
        }

        public void LäggTillKursmoment(params Kursmoment[] kursmoment)
        {
            this.kursmoment.AddRange(kursmoment);
        }


    }
}