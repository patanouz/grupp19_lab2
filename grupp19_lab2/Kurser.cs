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
    public partial class Kurser : Form
    {

        Form1 form1;
        List<Kurs> kursLista = new List<Kurs>();
        List<Student> studentLista = new List<Student>();
        List<LärarLag> lararlag = new List<LärarLag>();

        public Kurser(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            StartData();
            UppdateraKursListBox();

        }

        private void Kurser_Load(object sender, EventArgs e)
        {

        }

        private void UppdateraKursListBox() // Metod för att uppdatera listan med studenter vi har i lager.
        {
            kursListBox.Items.Clear();
            foreach (Kurs item in kursLista)
            {
                kursListBox.Items.Add(item.HämtaNamn());
            }
        }

        private void UppdateraLärarlagComboBoc()
        {
            lärarlagComboBox.Items.Clear();
            foreach (LärarLag ll in lararlag)
            {
               // lärarlagComboBox.Items.Add(ll.)
            }
        }

        private void StartData()
        {
            kursLista.Add(new Kurs("Roliga kursen", 1));
            kursLista.Add(new Kurs("OOAD", 2));
            kursLista.Add(new Kurs("Dataaa", 3));
        }
    }
}
