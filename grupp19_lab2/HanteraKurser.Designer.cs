﻿
namespace grupp19_lab2
{
    partial class HanteraKurser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kurserListBox = new System.Windows.Forms.ListBox();
            this.kursmomentListBox = new System.Windows.Forms.ListBox();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.kurserLabel = new System.Windows.Forms.Label();
            this.kursmomentLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.lärarlagLabel = new System.Windows.Forms.Label();
            this.removeKursmomentButton = new System.Windows.Forms.Button();
            this.removeKursButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.aktuelltLärarlagLabel = new System.Windows.Forms.Label();
            this.addKursmomentTextBox = new System.Windows.Forms.TextBox();
            this.kursmomentGroupBox = new System.Windows.Forms.GroupBox();
            this.addKursmomentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addStudentComboBox = new System.Windows.Forms.ComboBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kursmomentGroupBox.SuspendLayout();
            this.studentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // kurserListBox
            // 
            this.kurserListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kurserListBox.FormattingEnabled = true;
            this.kurserListBox.ItemHeight = 24;
            this.kurserListBox.Location = new System.Drawing.Point(45, 186);
            this.kurserListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kurserListBox.Name = "kurserListBox";
            this.kurserListBox.Size = new System.Drawing.Size(693, 192);
            this.kurserListBox.TabIndex = 0;
            this.kurserListBox.SelectedIndexChanged += new System.EventHandler(this.kurserListBox_SelectedIndexChanged);
            // 
            // kursmomentListBox
            // 
            this.kursmomentListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kursmomentListBox.FormattingEnabled = true;
            this.kursmomentListBox.ItemHeight = 24;
            this.kursmomentListBox.Location = new System.Drawing.Point(48, 450);
            this.kursmomentListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kursmomentListBox.Name = "kursmomentListBox";
            this.kursmomentListBox.Size = new System.Drawing.Size(693, 192);
            this.kursmomentListBox.TabIndex = 1;
            this.kursmomentListBox.SelectedIndexChanged += new System.EventHandler(this.kursmomentListBox_SelectedIndexChanged);
            // 
            // studentListBox
            // 
            this.studentListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 24;
            this.studentListBox.Location = new System.Drawing.Point(47, 704);
            this.studentListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(693, 192);
            this.studentListBox.TabIndex = 2;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // kurserLabel
            // 
            this.kurserLabel.AutoSize = true;
            this.kurserLabel.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurserLabel.Location = new System.Drawing.Point(39, 151);
            this.kurserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kurserLabel.Name = "kurserLabel";
            this.kurserLabel.Size = new System.Drawing.Size(82, 32);
            this.kurserLabel.TabIndex = 3;
            this.kurserLabel.Text = "Kurser";
            // 
            // kursmomentLabel
            // 
            this.kursmomentLabel.AutoSize = true;
            this.kursmomentLabel.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kursmomentLabel.Location = new System.Drawing.Point(43, 412);
            this.kursmomentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kursmomentLabel.Name = "kursmomentLabel";
            this.kursmomentLabel.Size = new System.Drawing.Size(152, 32);
            this.kursmomentLabel.TabIndex = 4;
            this.kursmomentLabel.Text = "Kursmoment";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLabel.Location = new System.Drawing.Point(43, 664);
            this.studentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(119, 32);
            this.studentLabel.TabIndex = 5;
            this.studentLabel.Text = "Studenter";
            // 
            // lärarlagLabel
            // 
            this.lärarlagLabel.AutoSize = true;
            this.lärarlagLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lärarlagLabel.Location = new System.Drawing.Point(1045, 186);
            this.lärarlagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lärarlagLabel.Name = "lärarlagLabel";
            this.lärarlagLabel.Size = new System.Drawing.Size(121, 38);
            this.lärarlagLabel.TabIndex = 6;
            this.lärarlagLabel.Text = "Lärarlag:";
            // 
            // removeKursmomentButton
            // 
            this.removeKursmomentButton.BackColor = System.Drawing.Color.Firebrick;
            this.removeKursmomentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeKursmomentButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeKursmomentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeKursmomentButton.Location = new System.Drawing.Point(749, 450);
            this.removeKursmomentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeKursmomentButton.Name = "removeKursmomentButton";
            this.removeKursmomentButton.Size = new System.Drawing.Size(129, 52);
            this.removeKursmomentButton.TabIndex = 9;
            this.removeKursmomentButton.Text = "Ta Bort";
            this.removeKursmomentButton.UseVisualStyleBackColor = false;
            this.removeKursmomentButton.Click += new System.EventHandler(this.removeKursmomentButton_Click);
            // 
            // removeKursButton
            // 
            this.removeKursButton.BackColor = System.Drawing.Color.Firebrick;
            this.removeKursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeKursButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeKursButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeKursButton.Location = new System.Drawing.Point(746, 186);
            this.removeKursButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeKursButton.Name = "removeKursButton";
            this.removeKursButton.Size = new System.Drawing.Size(129, 52);
            this.removeKursButton.TabIndex = 11;
            this.removeKursButton.Text = "Ta bort";
            this.removeKursButton.UseVisualStyleBackColor = false;
            this.removeKursButton.Click += new System.EventHandler(this.removeKursButton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.BackColor = System.Drawing.Color.Firebrick;
            this.removeStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStudentButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStudentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeStudentButton.Location = new System.Drawing.Point(746, 706);
            this.removeStudentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(129, 52);
            this.removeStudentButton.TabIndex = 13;
            this.removeStudentButton.Text = "Ta Bort";
            this.removeStudentButton.UseVisualStyleBackColor = false;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // aktuelltLärarlagLabel
            // 
            this.aktuelltLärarlagLabel.AutoSize = true;
            this.aktuelltLärarlagLabel.Location = new System.Drawing.Point(1049, 233);
            this.aktuelltLärarlagLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aktuelltLärarlagLabel.Name = "aktuelltLärarlagLabel";
            this.aktuelltLärarlagLabel.Size = new System.Drawing.Size(154, 25);
            this.aktuelltLärarlagLabel.TabIndex = 14;
            this.aktuelltLärarlagLabel.Text = "Kursens lärarlag";
            // 
            // addKursmomentTextBox
            // 
            this.addKursmomentTextBox.Location = new System.Drawing.Point(14, 99);
            this.addKursmomentTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addKursmomentTextBox.Name = "addKursmomentTextBox";
            this.addKursmomentTextBox.Size = new System.Drawing.Size(305, 45);
            this.addKursmomentTextBox.TabIndex = 15;
            // 
            // kursmomentGroupBox
            // 
            this.kursmomentGroupBox.Controls.Add(this.addKursmomentButton);
            this.kursmomentGroupBox.Controls.Add(this.label1);
            this.kursmomentGroupBox.Controls.Add(this.addKursmomentTextBox);
            this.kursmomentGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kursmomentGroupBox.Location = new System.Drawing.Point(1052, 609);
            this.kursmomentGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kursmomentGroupBox.Name = "kursmomentGroupBox";
            this.kursmomentGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kursmomentGroupBox.Size = new System.Drawing.Size(327, 266);
            this.kursmomentGroupBox.TabIndex = 16;
            this.kursmomentGroupBox.TabStop = false;
            this.kursmomentGroupBox.Text = "Kursmoment";
            // 
            // addKursmomentButton
            // 
            this.addKursmomentButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.addKursmomentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addKursmomentButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addKursmomentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addKursmomentButton.Location = new System.Drawing.Point(15, 159);
            this.addKursmomentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addKursmomentButton.Name = "addKursmomentButton";
            this.addKursmomentButton.Size = new System.Drawing.Size(136, 70);
            this.addKursmomentButton.TabIndex = 17;
            this.addKursmomentButton.Text = "Lägg till";
            this.addKursmomentButton.UseVisualStyleBackColor = false;
            this.addKursmomentButton.Click += new System.EventHandler(this.addKursmomentButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ange moment";
            // 
            // addStudentComboBox
            // 
            this.addStudentComboBox.FormattingEnabled = true;
            this.addStudentComboBox.Location = new System.Drawing.Point(14, 64);
            this.addStudentComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addStudentComboBox.Name = "addStudentComboBox";
            this.addStudentComboBox.Size = new System.Drawing.Size(305, 46);
            this.addStudentComboBox.TabIndex = 17;
            this.addStudentComboBox.SelectedIndexChanged += new System.EventHandler(this.addStudentComboBox_SelectedIndexChanged);
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addStudentButton.Location = new System.Drawing.Point(14, 124);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(136, 69);
            this.addStudentButton.TabIndex = 18;
            this.addStudentButton.Text = "Lägg till";
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click_1);
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.addStudentComboBox);
            this.studentGroupBox.Controls.Add(this.addStudentButton);
            this.studentGroupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGroupBox.Location = new System.Drawing.Point(1052, 318);
            this.studentGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studentGroupBox.Size = new System.Drawing.Size(327, 219);
            this.studentGroupBox.TabIndex = 19;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Studenter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 70);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hantera kurs";
            // 
            // HanteraKurser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 992);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aktuelltLärarlagLabel);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.removeKursButton);
            this.Controls.Add(this.removeKursmomentButton);
            this.Controls.Add(this.lärarlagLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.kursmomentLabel);
            this.Controls.Add(this.kurserLabel);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.kursmomentListBox);
            this.Controls.Add(this.kurserListBox);
            this.Controls.Add(this.kursmomentGroupBox);
            this.Controls.Add(this.studentGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "HanteraKurser";
            this.Text = "HanteraKurser";
            this.Load += new System.EventHandler(this.HanteraKurser_Load);
            this.kursmomentGroupBox.ResumeLayout(false);
            this.kursmomentGroupBox.PerformLayout();
            this.studentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox kurserListBox;
        private System.Windows.Forms.ListBox kursmomentListBox;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label kurserLabel;
        private System.Windows.Forms.Label kursmomentLabel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label lärarlagLabel;
        private System.Windows.Forms.Button removeKursmomentButton;
        private System.Windows.Forms.Button removeKursButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Label aktuelltLärarlagLabel;
        private System.Windows.Forms.TextBox addKursmomentTextBox;
        private System.Windows.Forms.GroupBox kursmomentGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addKursmomentButton;
        private System.Windows.Forms.ComboBox addStudentComboBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.Label label2;
    }
}