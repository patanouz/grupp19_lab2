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
            Teacher[] q = new Teacher[1];

            //Anton: Tog bort denna skiten, den blir fel och jag tror den har spökat för dig med.
            //Teacher l = new Teacher("testc", "testc", "testc");
            //q[0] = l;
            //chosenTeacherListBox.Items.AddRange(q);
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
          //  MessageBox.Show(availableTeacherListBox.SelectedItem.GetType() + "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            if (availableTeacherListBox.SelectedIndex > -1)
            {

                /*Anton: här gjrode jag såhär:
                 * 1. Lägg till i andra listan med listboxindex
                 * 2. Lägg till text i andra listbox utefter index
                 * 3. Tog bort ifrån första listan
                 * 4. Tog bort ifrån andra listboxen utefter index.
                 * 
                 * Alltså studentlista först, och listbox därefter.
                 */
                newTeacherList.Add(lärarLista[availableTeacherListBox.SelectedIndex]);
                chosenTeacherListBox.Items.Add(lärarLista[availableTeacherListBox.SelectedIndex]);
                lärarLista.RemoveAt(availableTeacherListBox.SelectedIndex);
                availableTeacherListBox.Items.RemoveAt(availableTeacherListBox.SelectedIndex);


               /*Teacher k = new Teacher(lärarLista[availableTeacherListBox.SelectedIndex].personnummer, lärarLista[availableTeacherListBox.SelectedIndex].Förnamn, lärarLista[availableTeacherListBox.SelectedIndex].efternamn);
                chosenTeacherListBox.Items.Add(availableTeacherListBox.Items[availableTeacherListBox.SelectedIndex]);
                availableTeacherListBox.Items.Remove(availableTeacherListBox.Items[availableTeacherListBox.SelectedIndex]);
                newTeacherList.Add(k);

                */
            }
        }

        private void removeTeacherButton_Click(object sender, EventArgs e)
        {
            if (chosenTeacherListBox.SelectedIndex > -1)
            {

                /*Anton: här gjrode jag såhär:
                 * 1. Lägg till i andra listan med listboxindex
                 * 2. Lägg till text i andra listbox utefter index
                 * 3. Tog bort ifrån första listan
                 * 4. Tog bort ifrån andra listboxen utefter index.
                 * 
                 * Alltså studentlista först, och listbox därefter.
                 */
                lärarLista.Add(newTeacherList[chosenTeacherListBox.SelectedIndex]);
                availableTeacherListBox.Items.Add(newTeacherList[chosenTeacherListBox.SelectedIndex]);
                newTeacherList.RemoveAt(chosenTeacherListBox.SelectedIndex);
                chosenTeacherListBox.Items.RemoveAt(chosenTeacherListBox.SelectedIndex);

                



                /* MessageBox.Show(chosenTeacherListBox.Items[chosenTeacherListBox.SelectedIndex].ToString());
                 MessageBox.Show(chosenTeacherListBox.Items[chosenTeacherListBox.SelectedIndex].GetType() + "");
                 foreach (Teacher item in newTeacherList)
                 {
                     if (item.Förnamn == chosenTeacherListBox.Items[chosenTeacherListBox.SelectedIndex].ToString())
                     {
                         MessageBox.Show(chosenTeacherListBox.Items[chosenTeacherListBox.SelectedIndex].GetType() + "");
                     }
                 } */

                // Vill ta bort objekthelvetet som är likadant i listbox och med listan "newTeacherList"

                //Anton: Detta var min skit i felsökningssyfte.
                /*string s = "";
                foreach (var item in newTeacherList)
                {
                    s += item;
                    s += "\n";
                }

                MessageBox.Show(s);
                */

                //Detta var din skit
                /*
                bool argPojke = false;
                foreach (Teacher item in newTeacherList)
                {
                    if (chosenTeacherListBox.Items[chosenTeacherListBox.SelectedIndex].ToString().Equals(item.Förnamn + " " + item.efternamn))
                    {
                        argPojke = true;
                        if (argPojke == true)
                        {
                            MessageBox.Show("Arg pojke glad?");
                        }
                    }
                }
                availableTeacherListBox.Items.Add(chosenTeacherListBox.Items[chosenTeacherListBox.SelectedIndex]);
                chosenTeacherListBox.Items.Remove(chosenTeacherListBox.Items[chosenTeacherListBox.SelectedIndex]);
                /*foreach (Teacher item in newTeacherList)
                {
                    MessageBox.Show(item + "");
                }*/
                //  MessageBox.Show(chosenTeacherListBox.Items[chosenTeacherListBox.SelectedIndex].ToString());
                int foundIndex;
            }
        }

        private void createTeam()
        {
            LärarLag k = new LärarLag(nameBox.Text);
            List<Teacher> temporaryTeacherList = new List<Teacher>();
            foreach(Teacher item in newTeacherList)
            {
                temporaryTeacherList.Add(item);
                MessageBox.Show(item.personnummer);
                MessageBox.Show(item.efternamn);
                MessageBox.Show(item.Förnamn);
            }
            lararlagLista.Add(k);
            MessageBox.Show(k + " was created!");
        }

        private void saveTeamButton_Click(object sender, EventArgs e)
        {
            createTeam();
        }

        private void chosenTeacherListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Teacher T = (Teacher)chosenTeacherListBox.Items[0]; 
           // MessageBox.Show(chosenTeacherListBox.SelectedItem.GetType() + "");
        }

        private void HanteraLärarlag_Load(object sender, EventArgs e)
        {

        }
    }
}
