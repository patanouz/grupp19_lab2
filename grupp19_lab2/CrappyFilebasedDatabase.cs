using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupp19_lab2
{
    public class CrappyFilebasedDatabase
    {

        string[] arr = File.ReadAllLines("C:\\Users\\norep\\source\\repos\\grupp19_lab2\\grupp19_lab2\\data.txt");

        public CrappyFilebasedDatabase()
        {

        }

        public Kurs[] HämtaKurser()
        {
            throw new NotImplementedException();
        }

        public Kursmoment[] HämtaKursmoment()
        {
            throw new NotImplementedException();
        }

        public Lärare[] HämtaLärare()
        {
            throw new NotImplementedException();
        }

        public LärarLag[] HämtaLärarlag()
        {
            throw new NotImplementedException();
        }

        public Student[] HämtaStudenter()
        {
            

            List<String> arr2 = new List<String>();
            bool found = false;
            foreach(string s in arr)
            {

                if (s.Contains("Kurser"))
                {
                    break;
                }

                if (found)
                {
                    arr2.Add(s);
                }

                if(s.Contains("Studenter"))
                {
                    found = true;
                }

                
            }

            Student[] studentlista = new Student[arr2.Count];

            for (int i = 0; i < arr2.Count; i++)
            {
                
                string[] temp = arr2[i].Split(':');
                studentlista[i] = new Student(temp[0], temp[1], temp[2], int.Parse(temp[3]));

            }

            return studentlista;
        }

        public void RedigeraKurs(Kurs kurs)
        {
            throw new NotImplementedException();
        }

        public void RedigeraKursmoment(Kursmoment kursmoment)
        {
            throw new NotImplementedException();
        }

        public void RedigeraLärare(Lärare lärare)
        {
            throw new NotImplementedException();
        }

        public void RedigeraLärarlag(LärarLag lärarlag)
        {
            throw new NotImplementedException();
        }

        public void RedigeraStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void SparaNyKurs(Kurs kurs)
        {
            throw new NotImplementedException();
        }

        public void SparaNyLärare(Lärare lärare)
        {
            throw new NotImplementedException();
        }

        public void SparaNyStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void SparaNyttKursmoment(Kursmoment kursmoment)
        {
            throw new NotImplementedException();
        }

        public void SparaNyttLärarlag(LärarLag lärarlag)
        {
            throw new NotImplementedException();
        }

        public void TaBortKurs(Kurs kurs)
        {
            throw new NotImplementedException();
        }

        public void TaBortKursmoment(Kursmoment kursmoment)
        {
            throw new NotImplementedException();
        }

        public void TaBortLärare(Lärare lärare)
        {
            throw new NotImplementedException();
        }

        public void TaBortLärarlag(LärarLag lärarlag)
        {
            throw new NotImplementedException();
        }

        public void TaBortStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
