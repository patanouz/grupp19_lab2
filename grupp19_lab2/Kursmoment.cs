using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp19_lab2
{
    public class Kursmoment : IBetygsunderlag
    {
        private string momentNamn;
        private Kurs kurs;

        public Kursmoment(string momentNamn, Kurs kurs)
        {
            this.momentNamn = momentNamn;
            this.kurs = kurs;
            kurs.LäggTillKursmoment(this); //lägger till sig själv i kursmoment. 
        }

        //Konstruktor som huvudsakligen behövs för att skapa kursmoment ifrån databasen.
        public Kursmoment(Int64 Id, string Momentnamn, Kurs kurs)
        {
            //TODO: Fixa detta
        }


        public int HämtaKurskod()
        {
            return kurs.HämtaKurskod();

        }

        public string HämtaNamn()
        {
            return momentNamn;

        }

        public void LäggTillKurs(Kurs kurs)
        {
            this.kurs = kurs;
        }
    }
}
