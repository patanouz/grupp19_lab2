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
    public partial class Studenter : Form
    {
        

        Form1 form1;
        List<Student> studentLista = new List<Student>();
        bool HållerPåAttSkapaNyStudent;

        //Testkommentar

        //Testkommentar 2

        public Studenter(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            studentLista.AddRange(form1.Test().HämtaStudenter());
            UppdateraStudentListBox();
        }

        private void UppdateraStudentListBox() // Metod för att uppdatera listan med studenter vi har i lager.
        {
            studentListBox.Items.Clear();
            foreach (Student item in studentLista)
            {
                studentListBox.Items.Add(item.HämtaNamn());
            }
        }

        private void Studenter_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void ÅrgångTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            if (studentListBox.SelectedIndex == -1) return;
            PersonnummerTextBox.Text = studentLista[studentListBox.SelectedIndex].personnummer;
            FörnamnTextBox.Text = studentLista[studentListBox.SelectedIndex].Förnamn;
            EfternamnTextBox.Text = studentLista[studentListBox.SelectedIndex].efternamn;
            //TelefonnummerTextBox.Text = studentLista[studentListBox.SelectedIndex].telefonnummer;
            //EpostTextBox.Text= studentLista[studentListBox.SelectedIndex].epost;
            //SexuellTextBox.Text= studentLista[studentListBox.SelectedIndex].sexuellPreferens;
        }

        private void SkapaNyStundentButton_Click(object sender, EventArgs e)
        {
            HållerPåAttSkapaNyStudent = true;
            
            if (HållerPåAttSkapaNyStudent)
            {
                // Student nyStudent = new Student("","","",int.Parse(PersonnummerTextBox.Text));
                Student nyStudent = new Student("", "", "", 2);
            }
           
            PersonnummerTextBox.Focus();
            // studentLista.Add(nyStudent);
            // UppdateraStudentListBox();
            studentListBox.Items.Add("");
            studentListBox.SelectedIndex = studentListBox.Items.Count-1;

        }

        private void FörnamnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SparaButton_Click(object sender, EventArgs e)
        {
           

            //studentLista[studentListBox.SelectedIndex].personnummer = PersonnummerTextBox.Text;
            studentLista[studentListBox.SelectedIndex].Förnamn = FörnamnTextBox.Text;
            studentLista[studentListBox.SelectedIndex].efternamn = EfternamnTextBox.Text;
            
            UppdateraStudentListBox(); // Metod som rensar listan och sedan printar alla nya ändringar som sker.

        }

        private void TaBortStudentButton_Click(object sender, EventArgs e)
        {
            if (studentLista.Count <= 0) { return; }
            studentLista.RemoveAt(studentListBox.SelectedIndex);
            UppdateraStudentListBox();
        }
    }
}

