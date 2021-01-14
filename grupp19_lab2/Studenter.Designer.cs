
namespace grupp19_lab2
{
    partial class Studenter
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PersonnummerTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FörnamnTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EfternamnTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TelefonnummerTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.EpostTextBox = new System.Windows.Forms.TextBox();
            this.SkapaNyStundentButton = new System.Windows.Forms.Button();
            this.TaBortStudentButton = new System.Windows.Forms.Button();
            this.SparaButton = new System.Windows.Forms.Button();
            this.SearcchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // studentListBox
            // 
            this.studentListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(23, 141);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(339, 299);
            this.studentListBox.TabIndex = 0;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Studenter i lager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Skapa / Redigera";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PersonnummerTextBox
            // 
            this.PersonnummerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonnummerTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PersonnummerTextBox.Enabled = false;
            this.PersonnummerTextBox.Location = new System.Drawing.Point(485, 159);
            this.PersonnummerTextBox.Multiline = true;
            this.PersonnummerTextBox.Name = "PersonnummerTextBox";
            this.PersonnummerTextBox.Size = new System.Drawing.Size(266, 23);
            this.PersonnummerTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(483, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Personnummer";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(483, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Förnamn";
            // 
            // FörnamnTextBox
            // 
            this.FörnamnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FörnamnTextBox.Location = new System.Drawing.Point(485, 214);
            this.FörnamnTextBox.Multiline = true;
            this.FörnamnTextBox.Name = "FörnamnTextBox";
            this.FörnamnTextBox.Size = new System.Drawing.Size(266, 23);
            this.FörnamnTextBox.TabIndex = 10;
            this.FörnamnTextBox.TextChanged += new System.EventHandler(this.FörnamnTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Efternamn";
            // 
            // EfternamnTextBox
            // 
            this.EfternamnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EfternamnTextBox.Location = new System.Drawing.Point(485, 272);
            this.EfternamnTextBox.Multiline = true;
            this.EfternamnTextBox.Name = "EfternamnTextBox";
            this.EfternamnTextBox.Size = new System.Drawing.Size(266, 23);
            this.EfternamnTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(483, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Telefonnummer";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TelefonnummerTextBox
            // 
            this.TelefonnummerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelefonnummerTextBox.Location = new System.Drawing.Point(485, 332);
            this.TelefonnummerTextBox.Multiline = true;
            this.TelefonnummerTextBox.Name = "TelefonnummerTextBox";
            this.TelefonnummerTextBox.Size = new System.Drawing.Size(266, 23);
            this.TelefonnummerTextBox.TabIndex = 14;
            this.TelefonnummerTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(483, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Epost adress";
            // 
            // EpostTextBox
            // 
            this.EpostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EpostTextBox.Location = new System.Drawing.Point(485, 392);
            this.EpostTextBox.Multiline = true;
            this.EpostTextBox.Name = "EpostTextBox";
            this.EpostTextBox.Size = new System.Drawing.Size(266, 23);
            this.EpostTextBox.TabIndex = 16;
            // 
            // SkapaNyStundentButton
            // 
            this.SkapaNyStundentButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SkapaNyStundentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkapaNyStundentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkapaNyStundentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkapaNyStundentButton.Location = new System.Drawing.Point(135, 445);
            this.SkapaNyStundentButton.Name = "SkapaNyStundentButton";
            this.SkapaNyStundentButton.Size = new System.Drawing.Size(227, 34);
            this.SkapaNyStundentButton.TabIndex = 20;
            this.SkapaNyStundentButton.Text = "Ny Student";
            this.SkapaNyStundentButton.UseVisualStyleBackColor = false;
            this.SkapaNyStundentButton.Click += new System.EventHandler(this.SkapaNyStundentButton_Click);
            // 
            // TaBortStudentButton
            // 
            this.TaBortStudentButton.BackColor = System.Drawing.Color.Firebrick;
            this.TaBortStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaBortStudentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaBortStudentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaBortStudentButton.Location = new System.Drawing.Point(23, 445);
            this.TaBortStudentButton.Name = "TaBortStudentButton";
            this.TaBortStudentButton.Size = new System.Drawing.Size(106, 34);
            this.TaBortStudentButton.TabIndex = 21;
            this.TaBortStudentButton.Text = "Ta bort";
            this.TaBortStudentButton.UseVisualStyleBackColor = false;
            this.TaBortStudentButton.Click += new System.EventHandler(this.TaBortStudentButton_Click);
            // 
            // SparaButton
            // 
            this.SparaButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SparaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SparaButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SparaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SparaButton.Location = new System.Drawing.Point(485, 445);
            this.SparaButton.Name = "SparaButton";
            this.SparaButton.Size = new System.Drawing.Size(129, 34);
            this.SparaButton.TabIndex = 22;
            this.SparaButton.Text = "Spara";
            this.SparaButton.UseVisualStyleBackColor = false;
            this.SparaButton.Click += new System.EventHandler(this.SparaButton_Click);
            // 
            // SearcchTextBox
            // 
            this.SearcchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearcchTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearcchTextBox.Location = new System.Drawing.Point(23, 89);
            this.SearcchTextBox.Multiline = true;
            this.SearcchTextBox.Name = "SearcchTextBox";
            this.SearcchTextBox.Size = new System.Drawing.Size(273, 25);
            this.SearcchTextBox.TabIndex = 23;
            this.SearcchTextBox.TextChanged += new System.EventHandler(this.SearcchTextBox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchButton.Location = new System.Drawing.Point(295, 89);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(67, 25);
            this.SearchButton.TabIndex = 24;
            this.SearchButton.Text = "Sök";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Studenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearcchTextBox);
            this.Controls.Add(this.SparaButton);
            this.Controls.Add(this.TaBortStudentButton);
            this.Controls.Add(this.SkapaNyStundentButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EpostTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TelefonnummerTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EfternamnTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FörnamnTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PersonnummerTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Studenter";
            this.Text = "Studenter";
            this.Load += new System.EventHandler(this.Studenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PersonnummerTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TelefonnummerTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EfternamnTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FörnamnTextBox;
        private System.Windows.Forms.Button SparaButton;
        private System.Windows.Forms.Button TaBortStudentButton;
        private System.Windows.Forms.Button SkapaNyStundentButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EpostTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearcchTextBox;
    }
}