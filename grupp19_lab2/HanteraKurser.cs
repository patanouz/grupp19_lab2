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
        List<Student> allaStudenter = new List<Student>();
        List<Student> temporäraStudenter = new List<Student>();
        List<Student> comboBoxStudenter = new List<Student>();
        
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

        private void UppdateraKursmomentListBox()
        {
            kursmomentListBox.Items.Clear();
            kursmomentLista = kursLista[kurserListBox.SelectedIndex].HämtaKursmoment();
            foreach (Kursmoment km in kursmomentLista)
            {
                kursmomentListBox.Items.Add(km.HämtaNamn());
            }
        }

        private void UppdateraStudentListBox()
        {
            studentListBox.Items.Clear();
            studentLista = kursLista[kurserListBox.SelectedIndex].HämtaStudenter();
            foreach (Student s in studentLista)
            {
                studentListBox.Items.Add(s.HämtaNamn());
            }
        }

        private void UppdateraStudentComboBox()
        {
            if (kurserListBox.SelectedIndex != -1)
            {
                addStudentComboBox.Items.Clear();
                allaStudenter.Clear();
                temporäraStudenter.Clear();
                allaStudenter.AddRange(form1.Databasanslutning().HämtaStudenter());
                temporäraStudenter.AddRange(kursLista[kurserListBox.SelectedIndex].HämtaStudenter());
                foreach (Student s in allaStudenter)
                {
                    if (!kursLista[kurserListBox.SelectedIndex].HämtaStudenter().Contains(s))
                    {
                        addStudentComboBox.Items.Add(s);
                        comboBoxStudenter.Add(s);
                    }
                }
            }            
        }
        
        private void kurserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentListBox.SelectedIndex = -1;
            kursmomentListBox.SelectedIndex = -1;

            if (kurserListBox.SelectedIndex != -1)
            {
                KollaVald();

                kursmomentListBox.Items.Clear();

                if ((kursmomentLista = kursLista[kurserListBox.SelectedIndex].HämtaKursmoment()) != null)
                {
                    UppdateraKursmomentListBox();
                }
                
                studentListBox.Items.Clear();
                if ((studentLista = kursLista[kurserListBox.SelectedIndex].HämtaStudenter()) != null)
                {
                    UppdateraStudentListBox();
                }

                KollaLärarlag();
                UppdateraStudentComboBox();
                
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
            // Gå till andra layouten "Ny kurs".
        }

        private void removeKursButton_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show($"Vill du verkligen ta bort kursen " +
                $"{kursLista[kurserListBox.SelectedIndex].HämtaNamn()}?", "Varning", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                kursLista.RemoveAt(kurserListBox.SelectedIndex);
                UppdateraKurserListBox();
                kursmomentListBox.Items.Clear();
                studentListBox.Items.Clear();
                kurserListBox.SelectedItem = -1;
                KollaVald();
            }
            
        }

        private void addKursmomentButton_Click(object sender, EventArgs e)
        {
            // Lägg till nya kursmoment
        }

        private void removeKursmomentButton_Click(object sender, EventArgs e)
        {            
            DialogResult resultat = MessageBox.Show($"Vill du verkligen ta bort " +
                $"{kursmomentLista[kursmomentListBox.SelectedIndex].HämtaNamn()} från kursen " +
                $"{kursLista[kurserListBox.SelectedIndex].HämtaNamn()}?", "Varning", MessageBoxButtons.YesNo);

            if (resultat == DialogResult.Yes)
            {
                kursmomentLista.RemoveAt(kursmomentListBox.SelectedIndex);
                UppdateraKursmomentListBox();
                kursmomentListBox.SelectedIndex = -1;
                KollaVald();
            }
            
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            // Denna används ej!
        }

        private void removeStudentButton_Click(object sender, EventArgs e)
        {
            DialogResult resultat = MessageBox.Show($"Vill du verkligen ta bort " +
                $"{studentLista[studentListBox.SelectedIndex].HämtaNamn()} från kursen " +
                $"{kursLista[kurserListBox.SelectedIndex].HämtaNamn()}?", "Varning", MessageBoxButtons.YesNo);
            if (resultat == DialogResult.Yes)
            {
                studentLista.RemoveAt(studentListBox.SelectedIndex);
                UppdateraStudentListBox();
                studentListBox.SelectedItem = -1;
                KollaVald();
            }            

        }

        private void addLärarlagButton_Click(object sender, EventArgs e)
        {
           // Denna används ej!

        }

        private void removeLärarlagButton_Click(object sender, EventArgs e)
        {
            
            // Denna används ej!

        }

        private void KollaVald()
        {
            if (kurserListBox.SelectedIndex == -1)
            {

                removeKursButton.Enabled = false;
                addKursmomentButton.Enabled = false;
                addKursmomentButton.Enabled = false;
                addStudentButton.Enabled = false;

            }
            else
            {

                removeKursButton.Enabled = true;
                addKursmomentButton.Enabled = true;
                addKursmomentButton.Enabled = true;
                addStudentButton.Enabled = true;

            }
            if (kursmomentListBox.SelectedIndex == -1)
            {
                removeKursmomentButton.Enabled = false;
            }
            else
            {
                addKursmomentButton.Enabled = true;
                removeKursmomentButton.Enabled = true;
            }
            if (studentListBox.SelectedIndex == -1)
            {
                removeStudentButton.Enabled = false;
            }
            else
            {
                addKursmomentButton.Enabled = true;
                removeStudentButton.Enabled = true;
            }
            if (addStudentComboBox.SelectedIndex == -1)
            {
                addStudentButton.Enabled = false;
            }
            else
            {
                addStudentButton.Enabled = true;
            }
        }

        private void KollaLärarlag()
        {
            if (kursLista[kurserListBox.SelectedIndex].HämtaLärarlag() == null)
            {
                aktuelltLärarlagLabel.Text = "Lärarlag saknas";

            }
            else
            {
                aktuelltLärarlagLabel.Text = kursLista[kurserListBox.SelectedIndex].HämtaLärarlag().lagNamn;

            }
        }

        private void addKursmomentButton_Click_1(object sender, EventArgs e)
        {
            if (addKursmomentTextBox.Text == null || addKursmomentTextBox.Text == "")
            {
                MessageBox.Show("Kursmoment saknar namn.", "Varning");
            }
            else
            {
                Kursmoment km = new Kursmoment(addKursmomentTextBox.Text, kursLista[kurserListBox.SelectedIndex]);
                UppdateraKursmomentListBox();
                addKursmomentTextBox.Clear();
            }
            
        }

        private void addStudentButton_Click_1(object sender, EventArgs e)
        {
            if (addStudentComboBox.SelectedIndex != -1)
            {
                kursLista[kurserListBox.SelectedIndex].LäggTillStudent(comboBoxStudenter[addStudentComboBox.SelectedIndex]);
                UppdateraStudentListBox();
                UppdateraStudentComboBox();

            }                        
        }

        private void addStudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            KollaVald();
        }
    }
}
