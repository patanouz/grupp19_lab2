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
        private int kurskod;
        private Kurs kurs;

        public Kursmoment(string momentNamn, int kurskod, Kurs kurs)
        {
            this.momentNamn = momentNamn;
            this.kurskod = kurskod;
            this.kurs = kurs;
        }

        public int HämtaKurskod()
        {
            return kurskod;
        }

        public string HämtaNamn()
        {
            return momentNamn;
        }
    }
}
