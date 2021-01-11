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
            kursLista.AddRange(form1.Databasanslutning().HämtaKurser());
            InitializeComponent();
            UppdateraKurserListBox();
            KollaVald();
        }

        private void HanteraKurser_Load(object sender, EventArgs e)
        {

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
            KollaVald();
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

            lärarlagTextBox.Text = kursLista[kurserListBox.SelectedIndex].HämtaLärarlag().lagNamn;
        }

        private void KollaVald()
        {
            if (kurserListBox.SelectedIndex == -1)
            {
                addKursButton.Enabled = false;
                removeKursButton.Enabled = false;
            }
            else
            {
                addKursButton.Enabled = true;
                removeKursButton.Enabled = true;
            }
            if (kursmomentListBox.SelectedIndex == -1)
            {
                addKursmomentButton.Enabled = false;
                removeKursmomentButton.Enabled = false;
            }
            else
            {
                addKursmomentButton.Enabled = true;
                removeKursmomentButton.Enabled = true;
            }
            if (studentListBox.SelectedIndex == -1)
            {
                addStudentButton.Enabled = false;
                removeStudentButton.Enabled = false;
            }
            else
            {
                addStudentButton.Enabled = true;
                removeStudentButton.Enabled = true;
            }
        }

        private void kursmomentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KollaVald();
        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KollaVald();
        }

        private void addKursButton_Click(object sender, EventArgs e)
        {
            UppdateraKurserListBox();
        }

        private void removeKursButton_Click(object sender, EventArgs e)
        {
            kursLista.RemoveAt(kurserListBox.SelectedIndex); // Kolla om denna funkar
        }

        private void addKursmomentButton_Click(object sender, EventArgs e)
        {

        }

        private void removeKursmomentButton_Click(object sender, EventArgs e)
        {

        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {

        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
