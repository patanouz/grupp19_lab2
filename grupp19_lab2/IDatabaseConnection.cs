using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupp19_lab2
{
    public interface IDatabaseConnection
    {
        //Studenter
        Student[] HämtaStudenter();
        void SparaNyStudent(Student student);
        void TaBortStudent(Student student);
        void RedigeraStudent(Student student);

        //Kurser
        Kurs[] HämtaKurser();
        void SparaNyKurs(Kurs kurs);
        void TaBortKurs(Kurs kurs);
        void RedigeraKurs(Kurs kurs);

        //Kursmoment
        Kursmoment[] HämtaKursmoment();
        void SparaNyttKursmoment(Kursmoment kursmoment);
        void TaBortKursmoment(Kursmoment kursmoment);
        void RedigeraKursmoment(Kursmoment kursmoment);

        //Lärare
        Teacher[] HämtaLärare();
        void SparaNyLärare(Teacher lärare);
        void TaBortLärare(Teacher lärare);
        void RedigeraLärare(Teacher lärare);

        //Lärarlag
        LärarLag[] HämtaLärarlag();
        void SparaNyttLärarlag(LärarLag lärarlag);
        void TaBortLärarlag(LärarLag lärarlag);
        void RedigeraLärarlag(LärarLag lärarlag);


       

    }
}
