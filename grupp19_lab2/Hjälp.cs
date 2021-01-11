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

        private SqliteDatabaseConnection databas;

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
            databas = new SqliteDatabaseConnection();
            kurser = new List<Kurs>(databas.HämtaKurser());
            

            listBox1.Items.AddRange(databas.HämtaStudenter());
            listBox2.Items.AddRange(databas.HämtaKurser());
            listBox3.Items.AddRange(databas.HämtaKursmoment());
            listBox4.Items.AddRange(databas.HämtaLärare());
            listBox5.Items.AddRange(databas.HämtaLärarlag());

        }

        private void Hjälp_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
            
        }
    }

