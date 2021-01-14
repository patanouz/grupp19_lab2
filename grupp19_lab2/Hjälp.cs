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
    public partial class Hjälp : Form
    {
        
        Form1 form1;
        List<Kurs> kurser;

        List<Student> studenter;

        private IDatabaseConnection databas;

        IReadOnlyDictionary<IBetygsunderlag, string> Test;
        public Hjälp(Form1 form1)
        {
            
            this.form1 = form1;
            InitializeComponent();

            //1. Studenter
            //2. Kurser
            //3. Kursmoment
            //4. Lärare
            //5. Lärarlag


            //Test databas
            databas = form1.Databasanslutning();
            kurser = new List<Kurs>(databas.HämtaKurser());
            

            listBox1.Items.AddRange(databas.HämtaStudenter());
            listBox2.Items.AddRange(databas.HämtaKurser());
            listBox3.Items.AddRange(databas.HämtaKursmoment());
            listBox4.Items.AddRange(databas.HämtaLärare());
            listBox5.Items.AddRange(databas.HämtaLärarlag());



            ///
            ///
            studenter = new List<Student>();
            studenter.AddRange(form1.Databasanslutning().HämtaStudenter());
            listBox6.Items.AddRange(studenter.ToArray());

            for (int i = 0; i < form1.Databasanslutning().HämtaKurser().Length; i++)
            {
                studenter[0].LäggTillBetysunderlag(form1.Databasanslutning().HämtaKurser()[i]);
            }
            
            ///
            ///

        }

        private void Hjälp_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(databas.HämtaStudenter());
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            //var test = studenter[0].HämtaNamn();
            //MessageBox.Show(test);
            listBox7.Items.Clear();

            

            foreach(var item in studenter[listBox6.SelectedIndex].läsbarKurslista)
            {
                listBox7.Items.Add(item.Key);
            }


            
        }
    }
    }

