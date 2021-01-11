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
        List<LärarLag> lararlagLista = new List<LärarLag>();
        List<Kursmoment> kursmomentLista = new List<Kursmoment>();
        List<Student> addedStudents = new List<Student>();
        List<Student> availableStudents = new List<Student>();

        public Kurser(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            StartData();
            availableStudents.AddRange(studentLista);
            UppdateraLärarlagComboBox();
            UppdateraStudenterListBox();
            KollaVald();
            
        }

        private void Kurser_Load(object sender, EventArgs e)
        {

        }


        private void UppdateraLärarlagComboBox()
        {
            lärarlagComboBox.Items.Clear();
            foreach (LärarLag ll in lararlagLista)
            {
               lärarlagComboBox.Items.Add(ll);
            }
        }

        private void UppdateraStudenterListBox()
        {
            availableStudentsListBox.Items.Clear();
            foreach (Student s in availableStudents)
            {
                availableStudentsListBox.Items.Add(s.HämtaNamn());
            }
        }

        private void UppdateraAddedStudentsListBox()
        {
            addedStudentsListBox.Items.Clear();
            foreach (Student s in addedStudents)
            {
                addedStudentsListBox.Items.Add(s.HämtaNamn());
            }
        }

        private void StartData()
        {
            kursLista.Add(new Kurs("Roliga kursen", 1));
            kursLista.Add(new Kurs("OOAD", 2));
            kursLista.Add(new Kurs("Dataaa", 3));
            lararlagLista.Add(new LärarLag("Lag 1"));
            lararlagLista.Add(new LärarLag("B-laget"));
            studentLista.Add(new Student("Rune", "Holta", "721108-5588"));
            studentLista.Add(new Student("Brynolf", "Håkansson", "821108-4535"));
            studentLista.Add(new Student("Jovarn", "Christersson", "951218-5682"));
            studentLista.Add(new Student("Conny", "Oskarsson", "820530-5678"));
        }

        private void addKursmomentButton_Click(object sender, EventArgs e)
        {
            kursmomentListBox.Items.Add(kursmomentTextBox.Text);
            kursmomentTextBox.Clear();
        }

        private void addKursButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                Kurs k = new Kurs(kursNamnTextBox.Text, 1);

                foreach (string item in kursmomentListBox.Items)
                {
                    Kursmoment km = new Kursmoment(item, k);
                    kursmomentLista.Add(km);

                }

                k.LäggTillKursmoment(kursmomentLista.ToArray());
                k.LäggTillStudent(addedStudents.ToArray());
                addedStudentsListBox.Items.Clear();
                availableStudentsListBox.Items.Clear();
                UppdateraStudenterListBox();
                UppdateraLärarlagComboBox();
                kursNamnTextBox.Clear();
                kursmomentListBox.Items.Clear();
                addedStudents.Clear();
                // Lägg till lärarlag
                // Skriv kurs till databasen
            }
        }

        private void kurserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addStudentbutton_Click(object sender, EventArgs e)
        {
            addedStudentsListBox.Items.Add(availableStudentsListBox.SelectedItem);
            availableStudentsListBox.Items.Remove(availableStudentsListBox.SelectedItem);
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            availableStudentsListBox.Items.Add(addedStudentsListBox.SelectedItem);
            addedStudentsListBox.Items.Remove(addedStudentsListBox.SelectedItem);
        }

        private void KollaVald()
        {
            if (availableStudentsListBox.SelectedIndex == -1)
            {
                addStudentbutton.Enabled = false;
            }
            else
            {
                addStudentbutton.Enabled = true;
            }
            if (addedStudentsListBox.SelectedIndex == -1)
            {
                removeStudentButton.Enabled = false;
            }
            else
            {
                removeStudentButton.Enabled = true;
            }
        }

        private void availableStudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KollaVald();
        }

        private void addedStudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KollaVald();
        }

        private bool ValidateForm()
        {
            bool Validated = false;

            if (kursNamnTextBox.Text == "")
            {
                MessageBox.Show("Kursen saknar namn.");
                return Validated;
            }
            if (lärarlagComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Kursen saknar lärarlag.");
            }


            return Validated;
        }
    }
}
