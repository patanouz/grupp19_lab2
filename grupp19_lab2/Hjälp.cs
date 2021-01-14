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

