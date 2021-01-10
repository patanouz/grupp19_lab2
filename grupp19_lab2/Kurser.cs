﻿using System;
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
    public partial class Kurser : Form
    {

        Form1 form1;
        List<Kurs> kursLista = new List<Kurs>();
        List<Student> studentLista = new List<Student>();
        List<LärarLag> lararlagLista = new List<LärarLag>();
        List<Kursmoment> kursmomentLista = new List<Kursmoment>();
        List<Student> addedStudents = new List<Student>();

        public Kurser(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            StartData();
            UppdateraLärarlagComboBox();
            UppdateraStudenterListBox();
        }

        private void Kurser_Load(object sender, EventArgs e)
        {

        }


        private void UppdateraLärarlagComboBox()
        {
            lärarlagComboBox.Items.Clear();
            foreach (LärarLag ll in lararlagLista)
            {
                //lärarlagComboBox.Items.Add(ll.Hämtanamn());
            }
        }

        private void UppdateraStudenterListBox()
        {
            availableStudentsListBox.Items.Clear();
            foreach (Student s in studentLista)
            {
                availableStudentsListBox.Items.Add(s.HämtaNamn());
            }
        }

        private void UppdateraAddedStudentsListBox()
        {
            addedStudentsListBox.Items.Clear();
            foreach (Student s in addedStudents)
            {
                addedStudentsListBox.Items.Add(s.HämtaNamn());
            }
        }

        private void StartData()
        {
            kursLista.Add(new Kurs("Roliga kursen", 1));
            kursLista.Add(new Kurs("OOAD", 2));
            kursLista.Add(new Kurs("Dataaa", 3));
            lararlagLista.Add(new LärarLag("Lag 1"));
            lararlagLista.Add(new LärarLag("B-laget"));
            studentLista.Add(new Student("Rune", "Holta", "721108-5588", 1));
            studentLista.Add(new Student("Brynolf", "Håkansson", "821108-4535", 2));
            studentLista.Add(new Student("Jovarn", "Christersson", "951218-5682", 3));
            studentLista.Add(new Student("Conny", "Oskarsson", "820530-5678", 4));
        }

        private void addKursmomentButton_Click(object sender, EventArgs e)
        {
            kursmomentListBox.Items.Add(kursmomentTextBox.Text);
            kursmomentTextBox.Clear();
        }

        private void addKursButton_Click(object sender, EventArgs e)
        {
            Kurs k = new Kurs(kursNamnTextBox.Text, 1);
            //k.LäggTillStudent(addedStudents);

        }
    }
}
