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
    public partial class HanteraLärarlag : Form
    {
        List<LärarLag> lararlagLista = new List<LärarLag>();
        List<Teacher> lärarLista = new List<Teacher>();
        List<Teacher> newTeacherList = new List<Teacher>();
        Form1 form1;
        public HanteraLärarlag(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            lärarLista.AddRange(form1.Databasanslutning().HämtaLärare());
            lararlagLista.AddRange(form1.Databasanslutning().HämtaLärarlag());
            UpdateAvailableTeacherListBox();
        }

        private void UpdateAvailableTeacherListBox()
        {
            availableTeacherListBox.Items.Clear();
            foreach (Teacher item in lärarLista)
            {
                availableTeacherListBox.Items.Add(item.HämtaNamn());
            }
        }

        private void availableTeacherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            if (availableTeacherListBox.SelectedIndex > -1)
            {
                newTeacherList.Add(lärarLista[availableTeacherListBox.SelectedIndex]);
                chosenTeacherListBox.Items.Add(lärarLista[availableTeacherListBox.SelectedIndex]);
                lärarLista.RemoveAt(availableTeacherListBox.SelectedIndex);
                availableTeacherListBox.Items.RemoveAt(availableTeacherListBox.SelectedIndex);
            }
        }

        private void removeTeacherButton_Click(object sender, EventArgs e)
        {
            if (chosenTeacherListBox.SelectedIndex > -1)
            {
                lärarLista.Add(newTeacherList[chosenTeacherListBox.SelectedIndex]);
                availableTeacherListBox.Items.Add(newTeacherList[chosenTeacherListBox.SelectedIndex]);
                newTeacherList.RemoveAt(chosenTeacherListBox.SelectedIndex);
                chosenTeacherListBox.Items.RemoveAt(chosenTeacherListBox.SelectedIndex);
            }
        }

        private void createTeam()
        {
           LärarLag k = new LärarLag(nameBox.Text);
           List<Teacher> temporaryTeacherList = new List<Teacher>();
            foreach(Teacher item in newTeacherList)
            {
                temporaryTeacherList.Add(item);
            }
            form1.Databasanslutning().SparaNyttLärarlag(k);
            MessageBox.Show(k + " was created!");
        }

        private void teamInputCheck()
        {
            if (!string.IsNullOrEmpty(nameBox.Text) && chosenTeacherListBox.Items.Count > 0)
            {
                createTeam();
            }
            else
            {
                MessageBox.Show("Saknas data. Kontrollera att allt är ifyllt.");
            }
        }

        private void saveTeamButton_Click(object sender, EventArgs e)
        {
            teamInputCheck();
        }

        private void chosenTeacherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HanteraLärarlag_Load(object sender, EventArgs e)
        {
          // Suttit och försökt dona med det här lite. Har inte gått bra, tror jag är väldigt trög och trött just nu :D 
        }
    }
}
