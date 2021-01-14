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
    public partial class Lärare : Form
    {
        Form1 form1;
        List<Teacher> lärarLista = new List<Teacher>();
        List<Teacher> searchLärare = new List<Teacher>();
        public Lärare(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            lärarLista.AddRange(form1.Databasanslutning().HämtaLärare());
            UpdateTeacherListBox();
        }
        private void UpdateTeacherListBox()
        {
            lärarLista.Clear();
            lärarLista.AddRange(form1.Databasanslutning().HämtaLärare());
            teacherListBox.Items.Clear();
            foreach (Teacher item in lärarLista)
            {
                teacherListBox.Items.Add(item.HämtaNamn());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void teacherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teacherListBox.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                personnrTextbox.Text = lärarLista[teacherListBox.SelectedIndex].personnummer;
                firstnameTextbox.Text = lärarLista[teacherListBox.SelectedIndex].Förnamn;
                lastnameTextbox.Text = lärarLista[teacherListBox.SelectedIndex].efternamn;
                phoneTextbox.Text = lärarLista[teacherListBox.SelectedIndex].telefonnummer;
                mailTextbox.Text = lärarLista[teacherListBox.SelectedIndex].email;
            }
        }

        private void teacherSearchBox_TextChanged(object sender, EventArgs e)
        {
            clearTextBoxesAndButtons();
            teacherListBox.Enabled = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            teacherListBox.Enabled = true;
            FindTeacherSearch();
        }

        private void FindTeacherSearch()
        {
            teacherListBox.SelectedIndex = -1;
            personnrTextbox.Text = "";
            firstnameTextbox.Text = "";
            lastnameTextbox.Text = "";
            mailTextbox.Text = "";
            phoneTextbox.Text = "";
            searchLärare.Clear();
            teacherListBox.Items.Clear();
            bool foundTeacher = false;

            foreach (Teacher item in lärarLista)
            {
                if (item.HämtaNamn().ToLower().Contains(teacherSearchBox.Text.ToLower()))
                {
                    foundTeacher = true;
                    searchLärare.Add(item);
                }
            }
            if (!foundTeacher)
            {
                MessageBox.Show("Fanns ingen med det namnet du...");
                UpdateTeacherListBox();
            }
            teacherSearchBox.Text = "";
            teacherListBox.Items.AddRange(searchLärare.ToArray());
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            clearTextBoxesAndButtons();
            personnrTextbox.ReadOnly = false;
            firstnameTextbox.ReadOnly = false;
            lastnameTextbox.ReadOnly = false;
            mailTextbox.ReadOnly = false;
            phoneTextbox.ReadOnly = false;
            cancelButton.Enabled = true;
            saveButton.Enabled = true;
            teacherListBox.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            checkInput();
            UpdateTeacherListBox();
            clearTextBoxesAndButtons();
            teacherListBox.Enabled = true;
        }
        private void checkInput()
        {
            if(!string.IsNullOrEmpty(personnrTextbox.Text) && !string.IsNullOrEmpty(firstnameTextbox.Text) && !string.IsNullOrEmpty(lastnameTextbox.Text) && !string.IsNullOrEmpty(phoneTextbox.Text) && !string.IsNullOrEmpty(mailTextbox.Text))
            {
                addNewTeacher();
            }
            else
            {
                MessageBox.Show("Alla fält behöver fyllas i.");
            }
        }

        private void addNewTeacher()
        {
            Teacher addedTeacher = new Teacher(firstnameTextbox.Text, lastnameTextbox.Text, personnrTextbox.Text, phoneTextbox.Text, mailTextbox.Text); // Saknas attribut
            form1.Databasanslutning().SparaNyLärare(addedTeacher);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clearTextBoxesAndButtons();
            teacherListBox.Enabled = true;
        }
        
        private void clearTextBoxesAndButtons()
        {
            personnrTextbox.Text = "";
            firstnameTextbox.Text = "";
            lastnameTextbox.Text = "";
            mailTextbox.Text = "";
            phoneTextbox.Text = "";
            personnrTextbox.ReadOnly = true;
            firstnameTextbox.ReadOnly = true;
            lastnameTextbox.ReadOnly = true;
            mailTextbox.ReadOnly = true;
            phoneTextbox.ReadOnly = true;
            cancelButton.Enabled = false;
            saveButton.Enabled = false;
        }

        // Den här metoden får jag inte att fungera. Henrik
        private void deleteTeacherButton_Click(object sender, EventArgs e)
        {
            if (teacherListBox.SelectedItems.Count != 0)
            {
                DialogResult result = MessageBox.Show("Vill du ta bort " + lärarLista[teacherListBox.SelectedIndex].Förnamn + " " + lärarLista[teacherListBox.SelectedIndex].efternamn, "Varning!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                   while (teacherListBox.SelectedIndex != -1)
                   {
                       form1.Databasanslutning().TaBortLärare(lärarLista[teacherListBox.SelectedIndex]);
                        lärarLista.RemoveAt(teacherListBox.SelectedIndex);
                        UpdateTeacherListBox();
                   }
                }
            }
            clearTextBoxesAndButtons();
        }

        private void Lärare_Load(object sender, EventArgs e)
        {

        }
    }
}
