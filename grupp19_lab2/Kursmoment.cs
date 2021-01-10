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

        public Kursmoment(string momentNamn)
        {
            this.momentNamn = momentNamn;
        }

        public int HämtaKurskod()
        {
            if(kurs == null)
            {
                return -1;
            }

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
