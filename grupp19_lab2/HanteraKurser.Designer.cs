
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
            this.lärarlagLabel = new System.Windows.Forms.Label();
            this.removeKursmomentButton = new System.Windows.Forms.Button();
            this.removeKursButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.aktuelltLärarlagLabel = new System.Windows.Forms.Label();
            this.addKursmomentTextBox = new System.Windows.Forms.TextBox();
            this.kursmomentGroupBox = new System.Windows.Forms.GroupBox();
            this.addKursmomentButton = new System.Windows.Forms.Button();
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
            this.kurserListBox.Location = new System.Drawing.Point(25, 90);
            this.kurserListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kurserListBox.Name = "kurserListBox";
            this.kurserListBox.Size = new System.Drawing.Size(427, 273);
            this.kurserListBox.TabIndex = 0;
            this.kurserListBox.SelectedIndexChanged += new System.EventHandler(this.kurserListBox_SelectedIndexChanged);
            // 
            // kursmomentListBox
            // 
            this.kursmomentListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kursmomentListBox.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kursmomentListBox.FormattingEnabled = true;
            this.kursmomentListBox.Location = new System.Drawing.Point(8, 62);
            this.kursmomentListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kursmomentListBox.Name = "kursmomentListBox";
            this.kursmomentListBox.Size = new System.Drawing.Size(249, 91);
            this.kursmomentListBox.TabIndex = 1;
            this.kursmomentListBox.SelectedIndexChanged += new System.EventHandler(this.kursmomentListBox_SelectedIndexChanged);
            // 
            // studentListBox
            // 
            this.studentListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentListBox.Font = new System.Drawing.Font("Segoe UI", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(8, 65);
            this.studentListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(248, 117);
            this.studentListBox.TabIndex = 2;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // kurserLabel
            // 
            this.kurserLabel.AutoSize = true;
            this.kurserLabel.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurserLabel.Location = new System.Drawing.Point(21, 71);
            this.kurserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kurserLabel.Name = "kurserLabel";
            this.kurserLabel.Size = new System.Drawing.Size(48, 19);
            this.kurserLabel.TabIndex = 3;
            this.kurserLabel.Text = "Kurser";
            // 
            // lärarlagLabel
            // 
            this.lärarlagLabel.AutoSize = true;
            this.lärarlagLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lärarlagLabel.Location = new System.Drawing.Point(21, 437);
            this.lärarlagLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lärarlagLabel.Name = "lärarlagLabel";
            this.lärarlagLabel.Size = new System.Drawing.Size(150, 21);
            this.lärarlagLabel.TabIndex = 6;
            this.lärarlagLabel.Text = "Lärarlag för kursen:";
            // 
            // removeKursmomentButton
            // 
            this.removeKursmomentButton.BackColor = System.Drawing.Color.Firebrick;
            this.removeKursmomentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeKursmomentButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeKursmomentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeKursmomentButton.Location = new System.Drawing.Point(8, 160);
            this.removeKursmomentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeKursmomentButton.Name = "removeKursmomentButton";
            this.removeKursmomentButton.Size = new System.Drawing.Size(70, 28);
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
            this.removeKursButton.Location = new System.Drawing.Point(25, 366);
            this.removeKursButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeKursButton.Name = "removeKursButton";
            this.removeKursButton.Size = new System.Drawing.Size(70, 28);
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
            this.removeStudentButton.Location = new System.Drawing.Point(8, 190);
            this.removeStudentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(70, 28);
            this.removeStudentButton.TabIndex = 13;
            this.removeStudentButton.Text = "Ta Bort";
            this.removeStudentButton.UseVisualStyleBackColor = false;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // aktuelltLärarlagLabel
            // 
            this.aktuelltLärarlagLabel.AutoSize = true;
            this.aktuelltLärarlagLabel.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktuelltLärarlagLabel.Location = new System.Drawing.Point(21, 460);
            this.aktuelltLärarlagLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aktuelltLärarlagLabel.Name = "aktuelltLärarlagLabel";
            this.aktuelltLärarlagLabel.Size = new System.Drawing.Size(106, 19);
            this.aktuelltLärarlagLabel.TabIndex = 14;
            this.aktuelltLärarlagLabel.Text = "Kursens lärarlag";
            // 
            // addKursmomentTextBox
            // 
            this.addKursmomentTextBox.Location = new System.Drawing.Point(8, 26);
            this.addKursmomentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addKursmomentTextBox.Name = "addKursmomentTextBox";
            this.addKursmomentTextBox.Size = new System.Drawing.Size(173, 25);
            this.addKursmomentTextBox.TabIndex = 15;
            // 
            // kursmomentGroupBox
            // 
            this.kursmomentGroupBox.Controls.Add(this.addKursmomentButton);
            this.kursmomentGroupBox.Controls.Add(this.addKursmomentTextBox);
            this.kursmomentGroupBox.Controls.Add(this.kursmomentListBox);
            this.kursmomentGroupBox.Controls.Add(this.removeKursmomentButton);
            this.kursmomentGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kursmomentGroupBox.Location = new System.Drawing.Point(502, 71);
            this.kursmomentGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kursmomentGroupBox.Name = "kursmomentGroupBox";
            this.kursmomentGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kursmomentGroupBox.Size = new System.Drawing.Size(264, 198);
            this.kursmomentGroupBox.TabIndex = 16;
            this.kursmomentGroupBox.TabStop = false;
            this.kursmomentGroupBox.Text = "Hantera kursmoment";
            // 
            // addKursmomentButton
            // 
            this.addKursmomentButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addKursmomentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addKursmomentButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addKursmomentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addKursmomentButton.Location = new System.Drawing.Point(183, 20);
            this.addKursmomentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addKursmomentButton.Name = "addKursmomentButton";
            this.addKursmomentButton.Size = new System.Drawing.Size(74, 32);
            this.addKursmomentButton.TabIndex = 17;
            this.addKursmomentButton.Text = "Lägg till";
            this.addKursmomentButton.UseVisualStyleBackColor = false;
            this.addKursmomentButton.Click += new System.EventHandler(this.addKursmomentButton_Click_1);
            // 
            // addStudentComboBox
            // 
            this.addStudentComboBox.FormattingEnabled = true;
            this.addStudentComboBox.Location = new System.Drawing.Point(7, 27);
            this.addStudentComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStudentComboBox.Name = "addStudentComboBox";
            this.addStudentComboBox.Size = new System.Drawing.Size(173, 25);
            this.addStudentComboBox.TabIndex = 17;
            this.addStudentComboBox.SelectedIndexChanged += new System.EventHandler(this.addStudentComboBox_SelectedIndexChanged);
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addStudentButton.Location = new System.Drawing.Point(182, 20);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(74, 33);
            this.addStudentButton.TabIndex = 18;
            this.addStudentButton.Text = "Lägg till";
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click_1);
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.addStudentComboBox);
            this.studentGroupBox.Controls.Add(this.addStudentButton);
            this.studentGroupBox.Controls.Add(this.studentListBox);
            this.studentGroupBox.Controls.Add(this.removeStudentButton);
            this.studentGroupBox.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGroupBox.Location = new System.Drawing.Point(502, 291);
            this.studentGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentGroupBox.Size = new System.Drawing.Size(264, 230);
            this.studentGroupBox.TabIndex = 19;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Hantera studenter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 41);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hantera kurs";
            // 
            // HanteraKurser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aktuelltLärarlagLabel);
            this.Controls.Add(this.removeKursButton);
            this.Controls.Add(this.lärarlagLabel);
            this.Controls.Add(this.kurserLabel);
            this.Controls.Add(this.kurserListBox);
            this.Controls.Add(this.kursmomentGroupBox);
            this.Controls.Add(this.studentGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label lärarlagLabel;
        private System.Windows.Forms.Button removeKursmomentButton;
        private System.Windows.Forms.Button removeKursButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Label aktuelltLärarlagLabel;
        private System.Windows.Forms.TextBox addKursmomentTextBox;
        private System.Windows.Forms.GroupBox kursmomentGroupBox;
        private System.Windows.Forms.Button addKursmomentButton;
        private System.Windows.Forms.ComboBox addStudentComboBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.Label label2;
    }
}