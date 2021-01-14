using System;
using System.Linq;
using System.Data.SQLite;
using System.Data;
using Dapper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace grupp19_lab2
{
    class SqliteDatabaseConnection : IDatabaseConnection
    {

        //Tillfälliga listor som kommer behövas fram tills att databasen är klar, än så länge så är bara HämtaKurser() och HämtaKurser() *nästan* klara.
        List<Student> studentLista = new List<Student>();
        List<Kurs> kursLista = new List<Kurs>();
        List<Kursmoment> kursmomentLista = new List<Kursmoment>();
        List<Teacher> lärarLista = new List<Teacher>();
        List<LärarLag> lärarlagLista = new List<LärarLag>();



        public SqliteDatabaseConnection()
        {
            //Ifyllnadsdata

            //Studenter
            studentLista.Add(new Student("Test", "Testsson", "123456"));
            studentLista.Add(new Student("Anders", "Andersson", "654321"));
            studentLista.Add(new Student("Bertil", "Bengtsson", "567234"));
            studentLista.Add(new Student("Caroline", "Carlsson", "098765"));

            //Kurser
            kursLista.Add(new Kurs("Test av IT-system", 0));
            kursLista.Add(new Kurs("Objektorienterad Systemutveckling 1", 1));
            kursLista.Add(new Kurs("Databasteknik", 2));
            kursLista.Add(new Kurs("Webbdesign", 3));

            //Kursmoment
            kursmomentLista.Add(new Kursmoment("Testtenta", kursLista[0]));
            kursmomentLista.Add(new Kursmoment("Programmeringstenta", kursLista[1]));
            kursmomentLista.Add(new Kursmoment("Databastenta", kursLista[2]));
            kursmomentLista.Add(new Kursmoment("Programmeringstenta", kursLista[3]));

            //Lärare
            lärarLista.Add(new Teacher("Brynolf", "Håkansson", "123"));
            lärarLista.Add(new Teacher("Rune", "Holta", "456"));

            //Studenter i kurs
            //kursLista[0].LäggTillStudent(studentLista.ToArray());
            //kursLista[2].LäggTillStudent(studentLista.ToArray());

            //Lärarlag
            lärarlagLista.Add(new LärarLag("Första lärarlaget"));
            lärarlagLista[0].LäggTillLärare(lärarLista[0]);

            lärarlagLista.Add(new LärarLag("OOSU gruppen"));
            lärarlagLista[1].LäggTillLärare(lärarLista[1]);
            kursLista[1].LäggTillLärarlag(lärarlagLista[1]);

            //studenter som läser kurser
           
            studentLista[0].LäggTillBetysunderlag(kursLista[0]);
            studentLista[1].LäggTillBetysunderlag(kursLista[1]);
            studentLista[1].LäggTillBetysunderlag(kursLista[2]);
            studentLista[1].LäggTillBetysunderlag(kursLista[3]);
            studentLista[2].LäggTillBetysunderlag(kursLista[2]); 
            



        }

        public Kurs[] HämtaKurser()
        {
            return kursLista.ToArray();
            /*
             * Ej klar med databasdelen, detta är det närmst fungerande.
             * 
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                var output = cnn.Query("Select * from Kurs", new DynamicParameters());

                var json = JsonConvert.SerializeObject(output, Formatting.Indented);
                JArray jsonArray = JArray.Parse(json);

                Kurs[] kurser = new Kurs[jsonArray.Count];
                for (int i = 0; i < jsonArray.Count; i++)
                {

                    string[] studenter = jsonArray[i]["Studenter"].ToString().Split(',');
                    string[] kursmoment = jsonArray[i]["Kursmoment"].ToString().Split(',');

                    List<Student> studentArray = new List<Student>();
                    List<Kursmoment> kursmomentArray = new List<Kursmoment>();

                    foreach (string s in studenter)
                    {
                        var student = cnn.Query<Student>("Select * from Student where Personnummer='" + s + "'", new DynamicParameters());
                        studentArray.AddRange(student);
                    }
                    /*foreach (string s in kursmoment)
                    {
                        var moment = cnn.Query<Kursmoment>("Select * from Kursmoment where KursmomentId='" + s + "'", new DynamicParameters());
                        kursmomentArray.AddRange(moment);
                    }
                    
                    kurser[i] = new Kurs(jsonArray[i]["Kursnamn"].ToString(),int.Parse(jsonArray[i]["Id"].ToObject<string>()));
                    kurser[i].LäggTillStudent(studentArray.ToArray());
                    kurser[i].LäggTillKursmoment(kursmomentArray.ToArray());

                }

                return kurser;
            }*/

            
        }

        public Kursmoment[] HämtaKursmoment()
        {
            return kursmomentLista.ToArray();
        }

        public Teacher[] HämtaLärare()
        {
            return lärarLista.ToArray();
        }

        public LärarLag[] HämtaLärarlag()
        {
            return lärarlagLista.ToArray();
        }

        public Student[] HämtaStudenter()
        {

            return studentLista.ToArray();

            /*
             * 
             * Inte klar med databas för studenter ännu, bara påbörjat det.
             * 
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                
                var output = cnn.Query<Student>("select * from Student", new DynamicParameters());

                Student[] studentArray = output.ToArray();

                return studentArray;
            }*/
        }

        public void RedigeraKurs(Kurs kurs)
        {
            //Har endast med databasen att göra, så den behövs inte ännu. 
        }

        public void RedigeraKursmoment(Kursmoment kursmoment)
        {
            //Har endast med databasen att göra, så den behövs inte ännu.
        }

        public void RedigeraLärare(Teacher lärare)
        {
            //Har endast med databasen att göra, så den behövs inte ännu.
        }

        public void RedigeraLärarlag(LärarLag lärarlag)
        {
            //Har endast med databasen att göra, så den behövs inte ännu.
        }

        public void RedigeraStudent(Student student)
        {
            //Har endast med databasen att göra, så den behövs inte ännu.
        }

        public void SparaNyKurs(Kurs kurs)
        {
            kursLista.Add(kurs);
        }

        public void SparaNyLärare(Teacher lärare)
        {
            lärarLista.Add(lärare);
        }

        public void SparaNyStudent(Student student)
        {
            studentLista.Add(student);
        }

        public void SparaNyttKursmoment(Kursmoment kursmoment)
        {
            kursmomentLista.Add(kursmoment);
        }

        public void SparaNyttLärarlag(LärarLag lärarlag)
        {
            lärarlagLista.Add(lärarlag);
        }

        public void TaBortKurs(Kurs kurs)
        {
            kursLista.Remove(kurs);
        }

        public void TaBortKursmoment(Kursmoment kursmoment)
        {
            kursmomentLista.Remove(kursmoment);
        }

        public void TaBortLärare(Teacher lärare)
        {
            lärarLista.Remove(lärare);
        }

        public void TaBortLärarlag(LärarLag lärarlag)
        {
            lärarlagLista.Remove(lärarlag);
        }

        public void TaBortStudent(Student student)
        {
            studentLista.Remove(student);
        }

        private string LoadConnectionString(string id = "Default")
        { 
            return "Data Source=.\\Databas.db;version=3;";
        }
    }
}
