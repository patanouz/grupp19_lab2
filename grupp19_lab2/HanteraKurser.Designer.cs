
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
            this.lärarlagTextBox = new System.Windows.Forms.TextBox();
            this.addKursmomentButton = new System.Windows.Forms.Button();
            this.removeKursmomentButton = new System.Windows.Forms.Button();
            this.removeKursButton = new System.Windows.Forms.Button();
            this.addKursButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
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
            // lärarlagTextBox
            // 
            this.lärarlagTextBox.Location = new System.Drawing.Point(59, 56);
            this.lärarlagTextBox.Name = "lärarlagTextBox";
            this.lärarlagTextBox.Size = new System.Drawing.Size(247, 26);
            this.lärarlagTextBox.TabIndex = 7;
            // 
            // addKursmomentButton
            // 
            this.addKursmomentButton.Location = new System.Drawing.Point(385, 529);
            this.addKursmomentButton.Name = "addKursmomentButton";
            this.addKursmomentButton.Size = new System.Drawing.Size(71, 44);
            this.addKursmomentButton.TabIndex = 8;
            this.addKursmomentButton.Text = "+";
            this.addKursmomentButton.UseVisualStyleBackColor = true;
            this.addKursmomentButton.Click += new System.EventHandler(this.addKursmomentButton_Click);
            // 
            // removeKursmomentButton
            // 
            this.removeKursmomentButton.Location = new System.Drawing.Point(482, 529);
            this.removeKursmomentButton.Name = "removeKursmomentButton";
            this.removeKursmomentButton.Size = new System.Drawing.Size(71, 44);
            this.removeKursmomentButton.TabIndex = 9;
            this.removeKursmomentButton.Text = "-";
            this.removeKursmomentButton.UseVisualStyleBackColor = true;
            this.removeKursmomentButton.Click += new System.EventHandler(this.removeKursmomentButton_Click);
            // 
            // removeKursButton
            // 
            this.removeKursButton.Location = new System.Drawing.Point(184, 529);
            this.removeKursButton.Name = "removeKursButton";
            this.removeKursButton.Size = new System.Drawing.Size(71, 44);
            this.removeKursButton.TabIndex = 11;
            this.removeKursButton.Text = "-";
            this.removeKursButton.UseVisualStyleBackColor = true;
            this.removeKursButton.Click += new System.EventHandler(this.removeKursButton_Click);
            // 
            // addKursButton
            // 
            this.addKursButton.Location = new System.Drawing.Point(87, 529);
            this.addKursButton.Name = "addKursButton";
            this.addKursButton.Size = new System.Drawing.Size(71, 44);
            this.addKursButton.TabIndex = 10;
            this.addKursButton.Text = "+";
            this.addKursButton.UseVisualStyleBackColor = true;
            this.addKursButton.Click += new System.EventHandler(this.addKursButton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(776, 530);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(71, 44);
            this.removeStudentButton.TabIndex = 13;
            this.removeStudentButton.Text = "-";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(679, 529);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(71, 44);
            this.addStudentButton.TabIndex = 12;
            this.addStudentButton.Text = "+";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // HanteraKurser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 826);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.removeKursButton);
            this.Controls.Add(this.addKursButton);
            this.Controls.Add(this.removeKursmomentButton);
            this.Controls.Add(this.addKursmomentButton);
            this.Controls.Add(this.lärarlagTextBox);
            this.Controls.Add(this.lärarlagLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.kursmomentLabel);
            this.Controls.Add(this.kurserLabel);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.kursmomentListBox);
            this.Controls.Add(this.kurserListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HanteraKurser";
            this.Text = "HanteraKurser";
            this.Load += new System.EventHandler(this.HanteraKurser_Load);
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
        private System.Windows.Forms.TextBox lärarlagTextBox;
        private System.Windows.Forms.Button addKursmomentButton;
        private System.Windows.Forms.Button removeKursmomentButton;
        private System.Windows.Forms.Button removeKursButton;
        private System.Windows.Forms.Button addKursButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Button addStudentButton;
    }
}