
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
            this.kursmomentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // kurserListBox
            // 
            this.kurserListBox.FormattingEnabled = true;
            this.kurserListBox.ItemHeight = 20;
            this.kurserListBox.Location = new System.Drawing.Point(59, 119);
            this.kurserListBox.Name = "kurserListBox";
            this.kurserListBox.Size = new System.Drawing.Size(247, 404);
            this.kurserListBox.TabIndex = 0;
            this.kurserListBox.SelectedIndexChanged += new System.EventHandler(this.kurserListBox_SelectedIndexChanged);
            // 
            // kursmomentListBox
            // 
            this.kursmomentListBox.FormattingEnabled = true;
            this.kursmomentListBox.ItemHeight = 20;
            this.kursmomentListBox.Location = new System.Drawing.Point(357, 119);
            this.kursmomentListBox.Name = "kursmomentListBox";
            this.kursmomentListBox.Size = new System.Drawing.Size(247, 404);
            this.kursmomentListBox.TabIndex = 1;
            this.kursmomentListBox.SelectedIndexChanged += new System.EventHandler(this.kursmomentListBox_SelectedIndexChanged);
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 20;
            this.studentListBox.Location = new System.Drawing.Point(647, 119);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(257, 404);
            this.studentListBox.TabIndex = 2;
            this.studentListBox.SelectedIndexChanged += new System.EventHandler(this.studentListBox_SelectedIndexChanged);
            // 
            // kurserLabel
            // 
            this.kurserLabel.AutoSize = true;
            this.kurserLabel.Location = new System.Drawing.Point(59, 93);
            this.kurserLabel.Name = "kurserLabel";
            this.kurserLabel.Size = new System.Drawing.Size(55, 20);
            this.kurserLabel.TabIndex = 3;
            this.kurserLabel.Text = "Kurser";
            // 
            // kursmomentLabel
            // 
            this.kursmomentLabel.AutoSize = true;
            this.kursmomentLabel.Location = new System.Drawing.Point(357, 92);
            this.kursmomentLabel.Name = "kursmomentLabel";
            this.kursmomentLabel.Size = new System.Drawing.Size(99, 20);
            this.kursmomentLabel.TabIndex = 4;
            this.kursmomentLabel.Text = "Kursmoment";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(647, 93);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(80, 20);
            this.studentLabel.TabIndex = 5;
            this.studentLabel.Text = "Studenter";
            // 
            // lärarlagLabel
            // 
            this.lärarlagLabel.AutoSize = true;
            this.lärarlagLabel.Location = new System.Drawing.Point(59, 32);
            this.lärarlagLabel.Name = "lärarlagLabel";
            this.lärarlagLabel.Size = new System.Drawing.Size(67, 20);
            this.lärarlagLabel.TabIndex = 6;
            this.lärarlagLabel.Text = "Lärarlag";
            // 
            // removeKursmomentButton
            // 
            this.removeKursmomentButton.Location = new System.Drawing.Point(437, 530);
            this.removeKursmomentButton.Name = "removeKursmomentButton";
            this.removeKursmomentButton.Size = new System.Drawing.Size(71, 44);
            this.removeKursmomentButton.TabIndex = 9;
            this.removeKursmomentButton.Text = "-";
            this.removeKursmomentButton.UseVisualStyleBackColor = true;
            this.removeKursmomentButton.Click += new System.EventHandler(this.removeKursmomentButton_Click);
            // 
            // removeKursButton
            // 
            this.removeKursButton.Location = new System.Drawing.Point(143, 529);
            this.removeKursButton.Name = "removeKursButton";
            this.removeKursButton.Size = new System.Drawing.Size(71, 44);
            this.removeKursButton.TabIndex = 11;
            this.removeKursButton.Text = "-";
            this.removeKursButton.UseVisualStyleBackColor = true;
            this.removeKursButton.Click += new System.EventHandler(this.removeKursButton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(737, 530);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(71, 44);
            this.removeStudentButton.TabIndex = 13;
            this.removeStudentButton.Text = "-";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // aktuelltLärarlagLabel
            // 
            this.aktuelltLärarlagLabel.AutoSize = true;
            this.aktuelltLärarlagLabel.Location = new System.Drawing.Point(57, 61);
            this.aktuelltLärarlagLabel.Name = "aktuelltLärarlagLabel";
            this.aktuelltLärarlagLabel.Size = new System.Drawing.Size(123, 20);
            this.aktuelltLärarlagLabel.TabIndex = 14;
            this.aktuelltLärarlagLabel.Text = "Kursens lärarlag";
            // 
            // addKursmomentTextBox
            // 
            this.addKursmomentTextBox.Location = new System.Drawing.Point(22, 62);
            this.addKursmomentTextBox.Name = "addKursmomentTextBox";
            this.addKursmomentTextBox.Size = new System.Drawing.Size(206, 26);
            this.addKursmomentTextBox.TabIndex = 15;
            // 
            // kursmomentGroupBox
            // 
            this.kursmomentGroupBox.Controls.Add(this.addKursmomentButton);
            this.kursmomentGroupBox.Controls.Add(this.label1);
            this.kursmomentGroupBox.Controls.Add(this.addKursmomentTextBox);
            this.kursmomentGroupBox.Location = new System.Drawing.Point(357, 591);
            this.kursmomentGroupBox.Name = "kursmomentGroupBox";
            this.kursmomentGroupBox.Size = new System.Drawing.Size(247, 183);
            this.kursmomentGroupBox.TabIndex = 16;
            this.kursmomentGroupBox.TabStop = false;
            this.kursmomentGroupBox.Text = "Kursmoment";
            // 
            // addKursmomentButton
            // 
            this.addKursmomentButton.Location = new System.Drawing.Point(65, 106);
            this.addKursmomentButton.Name = "addKursmomentButton";
            this.addKursmomentButton.Size = new System.Drawing.Size(111, 59);
            this.addKursmomentButton.TabIndex = 17;
            this.addKursmomentButton.Text = "Lägg till kursmoment";
            this.addKursmomentButton.UseVisualStyleBackColor = true;
            this.addKursmomentButton.Click += new System.EventHandler(this.addKursmomentButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kursmoment";
            // 
            // addStudentComboBox
            // 
            this.addStudentComboBox.FormattingEnabled = true;
            this.addStudentComboBox.Location = new System.Drawing.Point(651, 652);
            this.addStudentComboBox.Name = "addStudentComboBox";
            this.addStudentComboBox.Size = new System.Drawing.Size(212, 28);
            this.addStudentComboBox.TabIndex = 17;
            this.addStudentComboBox.SelectedIndexChanged += new System.EventHandler(this.addStudentComboBox_SelectedIndexChanged);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(694, 694);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(123, 58);
            this.addStudentButton.TabIndex = 18;
            this.addStudentButton.Text = "Lägg till student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click_1);
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Location = new System.Drawing.Point(647, 591);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(231, 183);
            this.studentGroupBox.TabIndex = 19;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Studenter";
            // 
            // HanteraKurser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 826);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.addStudentComboBox);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HanteraKurser";
            this.Text = "HanteraKurser";
            this.Load += new System.EventHandler(this.HanteraKurser_Load);
            this.kursmomentGroupBox.ResumeLayout(false);
            this.kursmomentGroupBox.PerformLayout();
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
    }
}