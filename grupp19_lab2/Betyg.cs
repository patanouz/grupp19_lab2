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
        List<Student> studentLista = new List<Student>();
        private SqliteDatabaseConnection databas;
        public Betyg(Form1 form1)
        {

            this.form1 = form1;
            InitializeComponent();
            List<string> betyg = new List<string>(2);
            betyg.Add("-");
            betyg.Add("G");
            betyg.Add("VG");

            databas = new SqliteDatabaseConnection();
            ListBox1.Items.AddRange(databas.HämtaStudenter());
            ListBox2.Items.AddRange(databas.HämtaKurser());
            ListBox3.Items.AddRange(databas.HämtaKursmoment());
            comboBox2.Items.AddRange(databas.HämtaKursmoment());
           

                foreach (string a in betyg)
            {
                comboBox1.Items.Add(a);

            }

        }

        private void Betyg_Load(object sender, EventArgs e)
        {



        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void Elev_SelectedIndexChanged(object sender, EventArgs e)
        {
        


        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
