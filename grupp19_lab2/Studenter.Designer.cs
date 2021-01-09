
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
            this.label11 = new System.Windows.Forms.Label();
            this.SexuellTextBox = new System.Windows.Forms.TextBox();
            this.SkapaNyStundentButton = new System.Windows.Forms.Button();
            this.TaBortStudentButton = new System.Windows.Forms.Button();
            this.SparaButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.studentListBox.ItemHeight = 24;
            this.studentListBox.Location = new System.Drawing.Point(61, 306);
            this.studentListBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(622, 552);
            this.studentListBox.TabIndex = 0;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Studenter i lager";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(856, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 50);
            this.label5.TabIndex = 7;
            this.label5.Text = "Skapa / Redigera";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PersonnummerTextBox
            // 
            this.PersonnummerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PersonnummerTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PersonnummerTextBox.Location = new System.Drawing.Point(865, 221);
            this.PersonnummerTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PersonnummerTextBox.Multiline = true;
            this.PersonnummerTextBox.Name = "PersonnummerTextBox";
            this.PersonnummerTextBox.Size = new System.Drawing.Size(488, 42);
            this.PersonnummerTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(860, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Personnummer";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(860, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Förnamn";
            // 
            // FörnamnTextBox
            // 
            this.FörnamnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FörnamnTextBox.Location = new System.Drawing.Point(865, 323);
            this.FörnamnTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FörnamnTextBox.Multiline = true;
            this.FörnamnTextBox.Name = "FörnamnTextBox";
            this.FörnamnTextBox.Size = new System.Drawing.Size(488, 42);
            this.FörnamnTextBox.TabIndex = 10;
            this.FörnamnTextBox.TextChanged += new System.EventHandler(this.FörnamnTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(860, 393);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Efternamn";
            // 
            // EfternamnTextBox
            // 
            this.EfternamnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EfternamnTextBox.Location = new System.Drawing.Point(865, 430);
            this.EfternamnTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EfternamnTextBox.Multiline = true;
            this.EfternamnTextBox.Name = "EfternamnTextBox";
            this.EfternamnTextBox.Size = new System.Drawing.Size(488, 42);
            this.EfternamnTextBox.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(860, 504);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Telefonnummer";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TelefonnummerTextBox
            // 
            this.TelefonnummerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TelefonnummerTextBox.Location = new System.Drawing.Point(865, 541);
            this.TelefonnummerTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TelefonnummerTextBox.Multiline = true;
            this.TelefonnummerTextBox.Name = "TelefonnummerTextBox";
            this.TelefonnummerTextBox.Size = new System.Drawing.Size(488, 42);
            this.TelefonnummerTextBox.TabIndex = 14;
            this.TelefonnummerTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(860, 615);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "Epost adress";
            // 
            // EpostTextBox
            // 
            this.EpostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EpostTextBox.Location = new System.Drawing.Point(865, 652);
            this.EpostTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EpostTextBox.Multiline = true;
            this.EpostTextBox.Name = "EpostTextBox";
            this.EpostTextBox.Size = new System.Drawing.Size(488, 42);
            this.EpostTextBox.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(860, 724);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 31);
            this.label11.TabIndex = 19;
            this.label11.Text = "Sexuell preferens";
            // 
            // SexuellTextBox
            // 
            this.SexuellTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SexuellTextBox.Location = new System.Drawing.Point(865, 761);
            this.SexuellTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SexuellTextBox.Multiline = true;
            this.SexuellTextBox.Name = "SexuellTextBox";
            this.SexuellTextBox.Size = new System.Drawing.Size(488, 42);
            this.SexuellTextBox.TabIndex = 18;
            // 
            // SkapaNyStundentButton
            // 
            this.SkapaNyStundentButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SkapaNyStundentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SkapaNyStundentButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkapaNyStundentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SkapaNyStundentButton.Location = new System.Drawing.Point(266, 868);
            this.SkapaNyStundentButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SkapaNyStundentButton.Name = "SkapaNyStundentButton";
            this.SkapaNyStundentButton.Size = new System.Drawing.Size(417, 63);
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
            this.TaBortStudentButton.Location = new System.Drawing.Point(60, 868);
            this.TaBortStudentButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TaBortStudentButton.Name = "TaBortStudentButton";
            this.TaBortStudentButton.Size = new System.Drawing.Size(194, 63);
            this.TaBortStudentButton.TabIndex = 21;
            this.TaBortStudentButton.Text = "Ta bort";
            this.TaBortStudentButton.UseVisualStyleBackColor = false;
            this.TaBortStudentButton.Click += new System.EventHandler(this.TaBortStudentButton_Click);
            // 
            // SparaButton
            // 
            this.SparaButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SparaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SparaButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SparaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SparaButton.Location = new System.Drawing.Point(865, 868);
            this.SparaButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SparaButton.Name = "SparaButton";
            this.SparaButton.Size = new System.Drawing.Size(237, 63);
            this.SparaButton.TabIndex = 22;
            this.SparaButton.Text = "Spara";
            this.SparaButton.UseVisualStyleBackColor = false;
            this.SparaButton.Click += new System.EventHandler(this.SparaButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(61, 210);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 46);
            this.textBox1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(560, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 46);
            this.button1.TabIndex = 24;
            this.button1.Text = "Sök";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Studenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1437, 991);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SparaButton);
            this.Controls.Add(this.TaBortStudentButton);
            this.Controls.Add(this.SkapaNyStundentButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SexuellTextBox);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox SexuellTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox EpostTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}