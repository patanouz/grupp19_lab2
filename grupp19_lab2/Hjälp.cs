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
        List<Student> arr;
        Form1 form1;
        IReadOnlyDictionary<IBetygsunderlag, string> Test;
        public Hjälp(Form1 form1)
        {
            
            this.form1 = form1;
            InitializeComponent();

            arr = new List<Student>();
            arr.AddRange(form1.Test().HämtaStudenter());

            arr.Add(new Student("Testare", "Testersson", "789", 8));

            comboBox1.SelectedIndex = 0;
            

            Test = arr[0].läsbarKurslista;

            Kurs TestKurs = new Kurs("Test av IT-system", 5);
            Kurs OOSU = new Kurs("Objektorienterad systemutveckling", 6);
            
            arr[0].LäggTillBetysunderlag(TestKurs, "VG");
            arr[0].LäggTillBetysunderlag(OOSU);
            arr[1].LäggTillBetysunderlag(TestKurs, "MVG");



            listBox1.Items.AddRange(arr.ToArray());
            
            //listBox1.SelectedIndex = 0; //Den här kan behövas, har ni inte med den så kommer programmet att krasha om du trycker i rutan utanför någon student

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBox1.Text, textBox2.Text, "12345", 5);
            

            listBox1.Items.Add(student.HämtaNamn());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            listBox2.Items.Clear();

            Test = arr[listBox1.SelectedIndex].läsbarKurslista;

            foreach(var item in Test)
            {
                listBox2.Items.Add(item.Key.HämtaNamn());   
            }

            /*
            Kurs Test = new Kurs("Test av IT-system", 5);
            Kurs OOSU = new Kurs("Objektorienterad systemutveckling", 6);
            listBox2.Items.Clear();
            arr[listBox1.SelectedIndex].LäggTillBetysunderlag(Test, "VG");
            arr[listBox1.SelectedIndex].LäggTillBetysunderlag(OOSU, "G");

            string[] test = arr[listBox1.SelectedIndex].HämtaKursOchBetyglista();

            foreach (var item in test)
            {
                listBox2.Items.Add(item);
            } */
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string test = listBox2.Items[listBox2.SelectedIndex].ToString();

            

            foreach (var item in Test)
            {
                if (test.Equals(item.Key.HämtaNamn()))
                {
                    
                    textBox3.Text = item.Value;
                    
                }
            }
        }

        private void Hjälp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Test)
            {

                    arr[listBox1.SelectedIndex].UppdateraBetyg(item.Key, "MVG");
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
