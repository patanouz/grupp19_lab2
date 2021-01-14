using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Denna funkar nu!

namespace grupp19_lab2
{
    public partial class Kurser : Form
    {
        Form1 form1;
        List<LärarLag> lararlagLista = new List<LärarLag>();
        List<Kursmoment> kursmomentLista = new List<Kursmoment>();
        List<Student> addedStudents = new List<Student>();
        List<Student> availableStudents = new List<Student>();    

        public Kurser(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            lararlagLista.AddRange(form1.Databasanslutning().HämtaLärarlag());
            availableStudents.AddRange(form1.Databasanslutning().HämtaStudenter());
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
                availableStudentsListBox.Items.Add(s);
            }
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
                foreach (Student s in addedStudentsListBox.Items)
                {
                    addedStudents.Add(s);
                    s.LäggTillBetysunderlag(k);
                    
                }
                k.LäggTillStudent(addedStudents.ToArray());
                k.LäggTillLärarlag(new LärarLag(lärarlagComboBox.Text));
                addedStudentsListBox.Items.Clear();
                availableStudentsListBox.Items.Clear();
                UppdateraStudenterListBox();
                UppdateraLärarlagComboBox();
                kursNamnTextBox.Clear();
                kursmomentListBox.Items.Clear();
                addedStudents.Clear();
                form1.Databasanslutning().SparaNyKurs(k);
                MessageBox.Show($"Kursen {k.HämtaNamn()} är tillagd.", "Info");

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
            bool validated = false;

            if (kursNamnTextBox.Text == "")
            {
                MessageBox.Show("Kursen saknar namn.", "Varning");
                return validated;
            }
            if (lärarlagComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Kursen saknar lärarlag.", "Varning");
                return validated;
            }
            if (kursmomentListBox.Items.Count == 0)
            {
                MessageBox.Show("Kursen saknar kursmoment.", "Varning");
                return validated;
            }
            if (addedStudentsListBox.Items.Count == 0)
            {
                MessageBox.Show("Kursen saknar studenter.", "Varning");
                return validated;
            }

            validated = true;
            return validated;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
