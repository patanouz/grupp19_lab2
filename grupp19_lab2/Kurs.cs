using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp19_lab2
{
    public class Kurs : IBetygsunderlag
    {

        private string kursnamn;
        private int kurskod;
        private List<Student> studentLista;
        private List<Kursmoment> kursmoment;
        private LärarLag lärarlag;

        public Kurs(string kursnamn, int kurskod)
        {
            this.studentLista = new List<Student>();
            this.kursmoment = new List<Kursmoment>();
            this.kursnamn = kursnamn;
            this.kurskod = kurskod;
        }

        //Konstruktor som huvudsakligen behövs för att skapa kurs ifrån databasen.
        public Kurs(Int64 Id, string Kursnamn, Int64 Lärarlag, string Kursmoment, string Studenter)
        {
            this.kurskod = (int)Id;
            /* 
             * Jag är Medveten om att detta kan gå fel, men det är en autoincrement som börjar på 1 
             * så jag väntar med att fixa den tills att någon skapat mer än 2 miljarder kurser. 
             * Lycka till med det.
             */
            kursnamn = Kursnamn;
            
        }

        public void LäggTillStudent(params Student[] studenter)
        {
            studentLista.AddRange(studenter);
        }

        public List<Student> HämtaStudenter()
        {
            return studentLista;
        }

        public int HämtaKurskod()
        {
            return kurskod;
        }

        public string HämtaNamn()
        {
            return kursnamn;
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

        public void BytNamnPåKurs(string kursNamn)
        {
            //this.kursNamn = kursNamn;
        }

        public override string ToString()
        {
            return kursnamn;
        }



    }
}