
namespace grupp19_lab2
{
    partial class Kurser
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
            this.lärarlagComboBox = new System.Windows.Forms.ComboBox();
            this.lärarlagLabel = new System.Windows.Forms.Label();
            this.kursmomentTextBox = new System.Windows.Forms.TextBox();
            this.kursmomentLabel = new System.Windows.Forms.Label();
            this.kursNamnTextBox = new System.Windows.Forms.TextBox();
            this.kursNamnLabel = new System.Windows.Forms.Label();
            this.kursmomentListBox = new System.Windows.Forms.ListBox();
            this.addKursmomentButton = new System.Windows.Forms.Button();
            this.kursmomentGroupBox = new System.Windows.Forms.GroupBox();
            this.addKursButton = new System.Windows.Forms.Button();
            this.availableStudentsListBox = new System.Windows.Forms.ListBox();
            this.addedStudentsListBox = new System.Windows.Forms.ListBox();
            this.addStudentbutton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lärarlagComboBox
            // 
            this.lärarlagComboBox.FormattingEnabled = true;
            this.lärarlagComboBox.Location = new System.Drawing.Point(95, 219);
            this.lärarlagComboBox.Name = "lärarlagComboBox";
            this.lärarlagComboBox.Size = new System.Drawing.Size(137, 28);
            this.lärarlagComboBox.TabIndex = 1;
            // 
            // lärarlagLabel
            // 
            this.lärarlagLabel.AutoSize = true;
            this.lärarlagLabel.Location = new System.Drawing.Point(95, 193);
            this.lärarlagLabel.Name = "lärarlagLabel";
            this.lärarlagLabel.Size = new System.Drawing.Size(67, 20);
            this.lärarlagLabel.TabIndex = 2;
            this.lärarlagLabel.Text = "Lärarlag";
            // 
            // kursmomentTextBox
            // 
            this.kursmomentTextBox.Location = new System.Drawing.Point(95, 520);
            this.kursmomentTextBox.Name = "kursmomentTextBox";
            this.kursmomentTextBox.Size = new System.Drawing.Size(160, 26);
            this.kursmomentTextBox.TabIndex = 3;
            // 
            // kursmomentLabel
            // 
            this.kursmomentLabel.AutoSize = true;
            this.kursmomentLabel.Location = new System.Drawing.Point(91, 496);
            this.kursmomentLabel.Name = "kursmomentLabel";
            this.kursmomentLabel.Size = new System.Drawing.Size(99, 20);
            this.kursmomentLabel.TabIndex = 4;
            this.kursmomentLabel.Text = "Kursmoment";
            // 
            // kursNamnTextBox
            // 
            this.kursNamnTextBox.Location = new System.Drawing.Point(95, 119);
            this.kursNamnTextBox.Name = "kursNamnTextBox";
            this.kursNamnTextBox.Size = new System.Drawing.Size(181, 26);
            this.kursNamnTextBox.TabIndex = 5;
            // 
            // kursNamnLabel
            // 
            this.kursNamnLabel.AutoSize = true;
            this.kursNamnLabel.Location = new System.Drawing.Point(96, 95);
            this.kursNamnLabel.Name = "kursNamnLabel";
            this.kursNamnLabel.Size = new System.Drawing.Size(81, 20);
            this.kursNamnLabel.TabIndex = 6;
            this.kursNamnLabel.Text = "Kursnamn";
            // 
            // kursmomentListBox
            // 
            this.kursmomentListBox.FormattingEnabled = true;
            this.kursmomentListBox.ItemHeight = 20;
            this.kursmomentListBox.Location = new System.Drawing.Point(295, 468);
            this.kursmomentListBox.Name = "kursmomentListBox";
            this.kursmomentListBox.Size = new System.Drawing.Size(192, 204);
            this.kursmomentListBox.TabIndex = 7;
            // 
            // addKursmomentButton
            // 
            this.addKursmomentButton.Location = new System.Drawing.Point(100, 565);
            this.addKursmomentButton.Name = "addKursmomentButton";
            this.addKursmomentButton.Size = new System.Drawing.Size(120, 53);
            this.addKursmomentButton.TabIndex = 8;
            this.addKursmomentButton.Text = "Lägg till";
            this.addKursmomentButton.UseVisualStyleBackColor = true;
            this.addKursmomentButton.Click += new System.EventHandler(this.addKursmomentButton_Click);
            // 
            // kursmomentGroupBox
            // 
            this.kursmomentGroupBox.Location = new System.Drawing.Point(84, 436);
            this.kursmomentGroupBox.Name = "kursmomentGroupBox";
            this.kursmomentGroupBox.Size = new System.Drawing.Size(454, 292);
            this.kursmomentGroupBox.TabIndex = 9;
            this.kursmomentGroupBox.TabStop = false;
            this.kursmomentGroupBox.Text = "Kursmoment";
            // 
            // addKursButton
            // 
            this.addKursButton.Location = new System.Drawing.Point(807, 600);
            this.addKursButton.Name = "addKursButton";
            this.addKursButton.Size = new System.Drawing.Size(120, 53);
            this.addKursButton.TabIndex = 10;
            this.addKursButton.Text = "Lägg till kurs";
            this.addKursButton.UseVisualStyleBackColor = true;
            this.addKursButton.Click += new System.EventHandler(this.addKursButton_Click);
            // 
            // availableStudentsListBox
            // 
            this.availableStudentsListBox.FormattingEnabled = true;
            this.availableStudentsListBox.ItemHeight = 20;
            this.availableStudentsListBox.Location = new System.Drawing.Point(598, 68);
            this.availableStudentsListBox.Name = "availableStudentsListBox";
            this.availableStudentsListBox.Size = new System.Drawing.Size(223, 424);
            this.availableStudentsListBox.TabIndex = 11;
            this.availableStudentsListBox.SelectedIndexChanged += new System.EventHandler(this.availableStudentsListBox_SelectedIndexChanged);
            // 
            // addedStudentsListBox
            // 
            this.addedStudentsListBox.FormattingEnabled = true;
            this.addedStudentsListBox.ItemHeight = 20;
            this.addedStudentsListBox.Location = new System.Drawing.Point(914, 68);
            this.addedStudentsListBox.Name = "addedStudentsListBox";
            this.addedStudentsListBox.Size = new System.Drawing.Size(223, 424);
            this.addedStudentsListBox.TabIndex = 12;
            this.addedStudentsListBox.SelectedIndexChanged += new System.EventHandler(this.addedStudentsListBox_SelectedIndexChanged);
            // 
            // addStudentbutton
            // 
            this.addStudentbutton.Location = new System.Drawing.Point(827, 175);
            this.addStudentbutton.Name = "addStudentbutton";
            this.addStudentbutton.Size = new System.Drawing.Size(75, 45);
            this.addStudentbutton.TabIndex = 13;
            this.addStudentbutton.Text = ">";
            this.addStudentbutton.UseVisualStyleBackColor = true;
            this.addStudentbutton.Click += new System.EventHandler(this.addStudentbutton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(827, 258);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(75, 45);
            this.removeStudentButton.TabIndex = 14;
            this.removeStudentButton.Text = "<";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // Kurser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 826);
            this.Controls.Add(this.removeStudentButton);
            this.Controls.Add(this.addStudentbutton);
            this.Controls.Add(this.addedStudentsListBox);
            this.Controls.Add(this.availableStudentsListBox);
            this.Controls.Add(this.addKursButton);
            this.Controls.Add(this.addKursmomentButton);
            this.Controls.Add(this.kursmomentListBox);
            this.Controls.Add(this.kursNamnLabel);
            this.Controls.Add(this.kursNamnTextBox);
            this.Controls.Add(this.kursmomentLabel);
            this.Controls.Add(this.kursmomentTextBox);
            this.Controls.Add(this.lärarlagLabel);
            this.Controls.Add(this.lärarlagComboBox);
            this.Controls.Add(this.kursmomentGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kurser";
            this.Text = "Kurser";
            this.Load += new System.EventHandler(this.Kurser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox lärarlagComboBox;
        private System.Windows.Forms.Label lärarlagLabel;
        private System.Windows.Forms.TextBox kursmomentTextBox;
        private System.Windows.Forms.Label kursmomentLabel;
        private System.Windows.Forms.TextBox kursNamnTextBox;
        private System.Windows.Forms.Label kursNamnLabel;
        private System.Windows.Forms.ListBox kursmomentListBox;
        private System.Windows.Forms.Button addKursmomentButton;
        private System.Windows.Forms.GroupBox kursmomentGroupBox;
        private System.Windows.Forms.Button addKursButton;
        private System.Windows.Forms.ListBox availableStudentsListBox;
        private System.Windows.Forms.ListBox addedStudentsListBox;
        private System.Windows.Forms.Button addStudentbutton;
        private System.Windows.Forms.Button removeStudentButton;
    }
}