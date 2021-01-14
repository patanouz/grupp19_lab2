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
    public partial class Betyg : Form
    {
        Form1 form1;
        List<Student> studenter;
        Kurs aktuellKurs;
        IBetygsunderlag aktuelltBetygsUnderlag;

        public Betyg(Form1 form1)
        {
            studenter = new List<Student>();
            this.form1 = form1;
            InitializeComponent();
            BetygComboBox.SelectedIndex = 0;
            BetygComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            StudentTextBox.ReadOnly = true;
            StudentTextBox.BackColor = Color.White;

            KursTextBox.ReadOnly = true;
            KursTextBox.BackColor = Color.White;

            KursmomentTextBox.ReadOnly = true;
            KursmomentTextBox.BackColor = Color.White;

        }

        private void Betyg_Load(object sender, EventArgs e)
        {

        }

        public void Uppdatera()
        {
            StudentListBox.Items.Clear();
            BetygListBox.Items.Clear();
            studenter.AddRange(form1.Databasanslutning().HämtaStudenter());
            StudentListBox.Items.AddRange(form1.Databasanslutning().HämtaStudenter());

            KursTextBox.Text = "";
            KursmomentTextBox.Text = "";
            SparaButton.Enabled = false;
            BetygComboBox.Enabled = false;
            BetygComboBox.SelectedIndex = 0;

            KurserListBox.Items.Clear();
            BetygListBox.Items.Clear();
            KursBetygListBox.Items.Clear();

        }

        private void StudentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentListBox.SelectedIndex < 0)
            {
                return;
            }

            StudentTextBox.Text = studenter[StudentListBox.SelectedIndex].HämtaNamn();
            KursTextBox.Text = "";
            KursmomentTextBox.Text = "";
            SparaButton.Enabled = false;
            BetygComboBox.Enabled = false;
            BetygComboBox.SelectedIndex = 0;

            KurserListBox.Items.Clear();
            BetygListBox.Items.Clear();
            KursBetygListBox.Items.Clear();
            foreach (var item in studenter[StudentListBox.SelectedIndex].läsbarKurslista)
            {
                if (item.Key.GetType() == typeof(Kurs))
                {
                    KurserListBox.Items.Add(item.Key);
                }
            }

        }

        private void KurserListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KurserListBox.SelectedIndex < 0)
            {
                return;
            }

            KursTextBox.Text = KurserListBox.SelectedItem.ToString();
            SparaButton.Enabled = false;
            BetygComboBox.Enabled = false;
            BetygComboBox.SelectedIndex = 0;

            aktuellKurs = (Kurs)KurserListBox.Items[KurserListBox.SelectedIndex];

            KursBetygListBox.Items.Clear();
            BetygListBox.Items.Clear();
            KursBetygListBox.Items.Add(aktuellKurs);
            BetygListBox.Items.Add(studenter[StudentListBox.SelectedIndex].läsbarKurslista[aktuellKurs]);

            foreach (var item in aktuellKurs.HämtaKursmoment())
            {
                KursBetygListBox.Items.Add(item);
                BetygListBox.Items.Add(studenter[StudentListBox.SelectedIndex].läsbarKurslista[item]);
            }

        }

        private void SparaButton_Click(object sender, EventArgs e)
        {
            studenter[StudentListBox.SelectedIndex].UppdateraBetyg(aktuelltBetygsUnderlag, BetygComboBox.SelectedItem.ToString());

            KursBetygListBox.Items.Clear();
            BetygListBox.Items.Clear();
            KursBetygListBox.Items.Add(aktuellKurs);
            BetygListBox.Items.Add(studenter[StudentListBox.SelectedIndex].läsbarKurslista[aktuellKurs]);

            foreach (var item in aktuellKurs.HämtaKursmoment())
            {
                KursBetygListBox.Items.Add(item);
                BetygListBox.Items.Add(studenter[StudentListBox.SelectedIndex].läsbarKurslista[item]);
            }
            MessageBox.Show("Betyget är sparat!", "Hantera betyg");
        }

        private void KursBetygListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KursBetygListBox.SelectedIndex < 0)
            {
                return;
            }
            BetygListBox.SelectedIndex = KursBetygListBox.SelectedIndex;
            BetygComboBox.Enabled = true;
            BetygComboBox.SelectedIndex = 0;
            KursmomentTextBox.Text = KursBetygListBox.Items[KursBetygListBox.SelectedIndex].ToString();
            aktuelltBetygsUnderlag = (IBetygsunderlag)KursBetygListBox.Items[KursBetygListBox.SelectedIndex];

        }

        private void BetygComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BetygComboBox.SelectedIndex > 0)
            {
                SparaButton.Enabled = true;
            }
            else
            {
                SparaButton.Enabled = false;
            }

        }

        private void BetygListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KursBetygListBox.SelectedIndex < 0)
            {
                return;
            }
            KursBetygListBox.SelectedIndex = BetygListBox.SelectedIndex;

        }
    }
}
