using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp19_lab2
{
    interface ILärarlag
    {

        void LäggTillLärare(params Teacher[] teacher);

        void LäggTillKurs(params Kurs[] kurser);

        string HämtaNamn();

        void TaBortLärare(params Teacher[] teacher);

        void TaBortKurs(params Kurs[] kurs);
    }
}
