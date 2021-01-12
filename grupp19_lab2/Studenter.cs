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
        List<Student> söktaStudenter = new List<Student>();
        bool HållerPåAttSkapaNyStudent;

        public Studenter(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            studentLista.AddRange(form1.Databasanslutning().HämtaStudenter());
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

        private void studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studentListBox.SelectedIndex<0)
            {
                return;
            }
            if (söktaStudenter.Count < studentListBox.Items.Count)
            {
                PersonnummerTextBox.Text = studentLista[studentListBox.SelectedIndex].personnummer;
                FörnamnTextBox.Text = studentLista[studentListBox.SelectedIndex].Förnamn;
                EfternamnTextBox.Text = studentLista[studentListBox.SelectedIndex].efternamn;
                //TelefonnummerTextBox.Text=studentLista[studentListBox.SelectedIndex].Telefon; // Ska läggas till i Person klassen
                //EpostTextBox.Text.Length = studentLista[studentListBox.SelectedIndex].Epost; // Ska läggas till i person klassen
            }
            else
            {
                PersonnummerTextBox.Text = söktaStudenter[studentListBox.SelectedIndex].personnummer;
                FörnamnTextBox.Text = söktaStudenter[studentListBox.SelectedIndex].Förnamn;
                EfternamnTextBox.Text = söktaStudenter[studentListBox.SelectedIndex].efternamn;
                //TelefonnummerTextBox.Text=studentLista[studentListBox.SelectedIndex].Telefon; // Ska läggas till i Person klassen
                //EpostTextBox.Text.Length = studentLista[studentListBox.SelectedIndex].Epost; // Ska läggas till i person klassen
            }

        }

        private void SkapaNyStundentButton_Click(object sender, EventArgs e) //TODO: Går att skapa en student med värde noll.
        {
            PersonnummerTextBox.Text = "";
            FörnamnTextBox.Text = "";
            EfternamnTextBox.Text = "";
            TelefonnummerTextBox.Text = "";
            EpostTextBox.Text = "";
            studentListBox.SelectedIndex = -1;
            HållerPåAttSkapaNyStudent = true;
            PersonnummerTextBox.Enabled = true;
            PersonnummerTextBox.Focus();
        }

        private void FörnamnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SparaButton_Click(object sender, EventArgs e)
        {
            if (HållerPåAttSkapaNyStudent)
            {
                Student nyStudent = new Student(FörnamnTextBox.Text, EfternamnTextBox.Text, PersonnummerTextBox.Text); //TODO: Lägga till saknade attribut sen.                                                                                                     //TelefonnummerTextBox.Text, Eposttextbox.text
                form1.Databasanslutning().SparaNyStudent(nyStudent);
                HållerPåAttSkapaNyStudent = false;
                PersonnummerTextBox.Enabled = false;
                studentLista.Clear();
                studentLista.AddRange(form1.Databasanslutning().HämtaStudenter());
                UppdateraStudentListBox();
            }
            // Normalt sett hade vi inte behövt loopa genom det, men eftersom det går att söka behövs den.
            foreach (Student item in studentLista)
            {
                if (item.personnummer==PersonnummerTextBox.Text)
                {
                    item.Förnamn = FörnamnTextBox.Text;
                    item.efternamn = EfternamnTextBox.Text;
                    //TODO: fylla på med sista attribut sen..
                    UppdateraStudentListBox();
                }
            }
            PersonnummerTextBox.Text = "";
            FörnamnTextBox.Text = "";
            EfternamnTextBox.Text = "";
            TelefonnummerTextBox.Text = "";
            EpostTextBox.Text = "";
           
           // UppdateraStudentListBox(); // Metod som rensar listan och sedan printar alla nya ändringar som sker.
        }

        private void TaBortStudentButton_Click(object sender, EventArgs e)
        {
            if (studentListBox.SelectedIndex < 0)
            {
                return;
            }
            if (studentLista.Count <= 0) { return; }
            if (söktaStudenter.Count<studentListBox.Items.Count)
            {                
                form1.Databasanslutning().TaBortStudent(studentLista[studentListBox.SelectedIndex]);
                studentLista.Clear();
                studentLista.AddRange(form1.Databasanslutning().HämtaStudenter());
                UppdateraStudentListBox();
                PersonnummerTextBox.Text = "";
                FörnamnTextBox.Text = "";
                EfternamnTextBox.Text = "";
                TelefonnummerTextBox.Text = "";
                EpostTextBox.Text = "";
                return;
            }
            form1.Databasanslutning().TaBortStudent((söktaStudenter[studentListBox.SelectedIndex]));
            studentLista.Clear();
            studentLista.AddRange(form1.Databasanslutning().HämtaStudenter());

            //TODO: Ska läggas till en messagebox som frågar om man verkligen vill...
            UppdateraStudentListBox();
        }

        private void SearchButton_Click(object sender, EventArgs e) //Sökfunktion för studenter som även ger felmeddelande när ingen sökt gubbe finns.
        {
            studentListBox.SelectedIndex = -1;
            PersonnummerTextBox.Text = "";
            FörnamnTextBox.Text = "";
            EfternamnTextBox.Text = "";
            TelefonnummerTextBox.Text = "";
            EpostTextBox.Text = "";
            söktaStudenter.Clear();
            studentListBox.Items.Clear();
            bool hittatNgt = false;
            foreach (var item in studentLista)
            {
                if (item.HämtaNamn().ToLower().Contains(SearcchTextBox.Text.ToLower()))
                {
                    hittatNgt = true;
                    söktaStudenter.Add(item);
                } 
            }
            if (!hittatNgt)
            {
                MessageBox.Show("Fanns ingen med det namnet du...");
                UppdateraStudentListBox();
            }
            studentListBox.Items.AddRange(söktaStudenter.ToArray());
            SearcchTextBox.Text = "";
        }

        private void SearcchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

