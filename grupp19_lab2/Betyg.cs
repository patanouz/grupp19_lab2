using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupp19_lab2
{
    
    
   
    public partial class Betyg : Form
    {
        Form1 form1;
        List<Student> studentLista = new List<Student>();
        private SqliteDatabaseConnection databas;
        public Betyg(Form1 form1)
        {

            this.form1 = form1;
            InitializeComponent();
            List<string> betyg = new List<string>(2);
            betyg.Add("-");
            betyg.Add("G");
            betyg.Add("VG");

            databas = new SqliteDatabaseConnection();
            ListBox1.Items.AddRange(databas.HämtaStudenter());
           /*ListBox2.Items.AddRange(databas.HämtaKurser());
            ListBox3.Items.AddRange(databas.HämtaKursmoment());
            */
            comboBox2.Items.AddRange(databas.HämtaKursmoment());
           

                foreach (string a in betyg)
            {
                comboBox1.Items.Add(a);

            }

        }

        private void Betyg_Load(object sender, EventArgs e)
        {



        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void Elev_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Studieresultat> sr = new List<Studieresultat>();
            sr.Add(new Studieresultat("Anders Andersson", "Webbdesign", "Testtenta", "G"));
            /*
             * sr.Add(new Studieresultat(studentnamn=textBox1.Text, kurs=comboBox2.SelectedItem.Text, kursmoment= comboBox1.SelectedItem.Text, betyg=comboBox2.SelectedItem.Text
             * 
             */
            textBox1.Text = ListBox1.SelectedItem.ToString();
            //Skapar en array för att lagra kurser
            Kurs[] kurslista = new Kurs[0];
            Kursmoment[] kursmomentlista = new Kursmoment[0];
            kursmomentlista = databas.HämtaKursmoment().ToArray();
            //Lägger in kurser i arrayen
            kurslista = databas.HämtaKurser().ToArray();

            for (int i = 0; i < sr.Count; i++)
            {

                if (ListBox1.SelectedItem.ToString() == (sr[i].Studentnamn))
                {
                    for (int j = 0; j < kurslista.Length; j++)
                    {
                        if (kurslista[j].ToString().Contains(sr[i].Kurs))
                        {
                            ListBox2.Items.Add(sr[i].Kurs);
                            j++;

                            for (int y = 0; y < kursmomentlista.Length; y++)
                            {
                                if (kursmomentlista[y].ToString().Contains(sr[i].Kursmoment))
                                {
                                    ListBox3.Items.Add(sr[i].Kursmoment);
                                    y++;

                                }

                            }


                        }

                    }
                }


            }






        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Studieresultat
    {
        private string studentnamn;
        private string kurs;
        private string kursmoment;
        private string betygresultat;
        public Studieresultat(string studentnamn, string kurs, string kursmoment, string betygresultat)
        {
            this.studentnamn = studentnamn;
            this.kurs = kurs;
            this.kursmoment = kursmoment;
            this.betygresultat = betygresultat;
        }
        public string Studentnamn
        {
            get { return studentnamn; }
            set { studentnamn = value; }
        }
        public string Kurs
        {
            get { return kurs; }
            set { kurs = value; }
        }
        public string Kursmoment
        {
            get { return kursmoment; }
            set { kursmoment = value; }
        }
        public string BetygsResultat
        {
            get { return betygresultat; }
            set { betygresultat = value; }
        }

    }
}
