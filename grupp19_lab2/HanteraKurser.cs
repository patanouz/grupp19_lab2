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
    public partial class HanteraKurser : Form
    {
        List<Kurs> kursLista = new List<Kurs>();
        List<Kursmoment> kursmomentLista = new List<Kursmoment>();
        List<Student> studentLista = new List<Student>();
        

        Form1 form1;
        public HanteraKurser(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            StartData();
            UppdateraKurserListBox();
        }

        private void HanteraKurser_Load(object sender, EventArgs e)
        {

        }
        private void StartData()
        {
            Kurs k1 = new Kurs("Roliga kursen", 1);
            Kurs k2 = new Kurs("Håriga kursen", 2);
            kursLista.Add(k1);
            kursLista.Add(k2);
            List<Kursmoment> kursMoment1 = new List<Kursmoment>();
            List<Kursmoment> kursMoment2 = new List<Kursmoment>();
            Kursmoment km1 = new Kursmoment("Tentamen", k1);
            Kursmoment km2 = new Kursmoment("Laboration 1", k1);
            Kursmoment km3 = new Kursmoment("Laboration 2", k2);
            kursMoment1.Add(km1);
            kursMoment1.Add(km2);
            kursMoment2.Add(km3);
            kursLista[0].LäggTillKursmoment(kursMoment1.ToArray());
            kursLista[1].LäggTillKursmoment(kursMoment2.ToArray());
            List<Student> student1 = new List<Student>();
            List<Student> student2 = new List<Student>();
            Student s1 = new Student("Rune", "Holta", "820529-8554", 1);
            Student s2 = new Student("Jovarn", "Christersson", "830430-8554", 2);
            Student s3 = new Student("Gert-Ove", "Möller", "720529-8554", 3);
            Student s4 = new Student("Brynolf", "Håkansson", "520529-8554", 4);
            Student s5 = new Student("Kjell", "Tjomasson", "850529-8554", 5);
            student1.Add(s1);
            student1.Add(s2);
            student1.Add(s3);
            student2.Add(s4);
            student2.Add(s5);
            k1.LäggTillStudent(student1.ToArray());
            k2.LäggTillStudent(student2.ToArray());
        }

        private void UppdateraKurserListBox()
        {
            kurserListBox.Items.Clear();
            foreach (Kurs s in kursLista)
            {
                kurserListBox.Items.Add(s.HämtaNamn());
            }
        }

        private void kurserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kursmomentListBox.Items.Clear();
            kursmomentLista = kursLista[kurserListBox.SelectedIndex].HämtaKursmoment();
            foreach (Kursmoment km in kursmomentLista)
            {
                kursmomentListBox.Items.Add(km.HämtaNamn());
            }
            studentListBox.Items.Clear();
            studentLista = kursLista[kurserListBox.SelectedIndex].HämtaStudent();
            foreach (Student s in studentLista)
            {
                studentListBox.Items.Add(s.HämtaNamn());
            }

            lärarlagTextBox.Text = kursLista[kurserListBox.SelectedIndex].;
        }
    }
}
