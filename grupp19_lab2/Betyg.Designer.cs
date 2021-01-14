
namespace grupp19_lab2
{
    partial class Betyg
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
            this.KursmomentTextBox = new System.Windows.Forms.TextBox();
            this.KursBetygListBox = new System.Windows.Forms.ListBox();
            this.BetygListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BetygComboBox = new System.Windows.Forms.ComboBox();
            this.KursTextBox = new System.Windows.Forms.TextBox();
            this.StudentTextBox = new System.Windows.Forms.TextBox();
            this.KurserListBox = new System.Windows.Forms.ListBox();
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.SparaButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KursmomentTextBox
            // 
            this.KursmomentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KursmomentTextBox.Location = new System.Drawing.Point(537, 335);
            this.KursmomentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.KursmomentTextBox.Multiline = true;
            this.KursmomentTextBox.Name = "KursmomentTextBox";
            this.KursmomentTextBox.Size = new System.Drawing.Size(214, 27);
            this.KursmomentTextBox.TabIndex = 51;
            // 
            // KursBetygListBox
            // 
            this.KursBetygListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KursBetygListBox.FormattingEnabled = true;
            this.KursBetygListBox.Location = new System.Drawing.Point(38, 407);
            this.KursBetygListBox.Margin = new System.Windows.Forms.Padding(2);
            this.KursBetygListBox.Name = "KursBetygListBox";
            this.KursBetygListBox.Size = new System.Drawing.Size(300, 91);
            this.KursBetygListBox.TabIndex = 50;
            this.KursBetygListBox.SelectedIndexChanged += new System.EventHandler(this.KursBetygListBox_SelectedIndexChanged);
            // 
            // BetygListBox
            // 
            this.BetygListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BetygListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetygListBox.FormattingEnabled = true;
            this.BetygListBox.Location = new System.Drawing.Point(337, 407);
            this.BetygListBox.Margin = new System.Windows.Forms.Padding(2);
            this.BetygListBox.Name = "BetygListBox";
            this.BetygListBox.Size = new System.Drawing.Size(80, 91);
            this.BetygListBox.TabIndex = 49;
            this.BetygListBox.SelectedIndexChanged += new System.EventHandler(this.BetygListBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(532, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 30);
            this.label9.TabIndex = 48;
            this.label9.Text = "Sätt betyg";
            // 
            // BetygComboBox
            // 
            this.BetygComboBox.Enabled = false;
            this.BetygComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BetygComboBox.FormattingEnabled = true;
            this.BetygComboBox.ItemHeight = 13;
            this.BetygComboBox.Items.AddRange(new object[] {
            "Välj ett betyg...",
            "VG",
            "G",
            "IG"});
            this.BetygComboBox.Location = new System.Drawing.Point(537, 404);
            this.BetygComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.BetygComboBox.Name = "BetygComboBox";
            this.BetygComboBox.Size = new System.Drawing.Size(216, 21);
            this.BetygComboBox.TabIndex = 47;
            this.BetygComboBox.SelectedIndexChanged += new System.EventHandler(this.BetygComboBox_SelectedIndexChanged);
            // 
            // KursTextBox
            // 
            this.KursTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KursTextBox.Location = new System.Drawing.Point(537, 269);
            this.KursTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.KursTextBox.Multiline = true;
            this.KursTextBox.Name = "KursTextBox";
            this.KursTextBox.Size = new System.Drawing.Size(214, 27);
            this.KursTextBox.TabIndex = 46;
            // 
            // StudentTextBox
            // 
            this.StudentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentTextBox.Location = new System.Drawing.Point(537, 205);
            this.StudentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StudentTextBox.Multiline = true;
            this.StudentTextBox.Name = "StudentTextBox";
            this.StudentTextBox.Size = new System.Drawing.Size(214, 28);
            this.StudentTextBox.TabIndex = 45;
            // 
            // KurserListBox
            // 
            this.KurserListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KurserListBox.FormattingEnabled = true;
            this.KurserListBox.Location = new System.Drawing.Point(38, 271);
            this.KurserListBox.Margin = new System.Windows.Forms.Padding(2);
            this.KurserListBox.Name = "KurserListBox";
            this.KurserListBox.Size = new System.Drawing.Size(379, 91);
            this.KurserListBox.TabIndex = 44;
            this.KurserListBox.SelectedIndexChanged += new System.EventHandler(this.KurserListBox_SelectedIndexChanged);
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.Location = new System.Drawing.Point(38, 138);
            this.StudentListBox.Margin = new System.Windows.Forms.Padding(2);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(380, 95);
            this.StudentListBox.TabIndex = 43;
            this.StudentListBox.SelectedIndexChanged += new System.EventHandler(this.StudentListBox_SelectedIndexChanged);
            // 
            // SparaButton
            // 
            this.SparaButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SparaButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SparaButton.Enabled = false;
            this.SparaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SparaButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SparaButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SparaButton.Location = new System.Drawing.Point(537, 464);
            this.SparaButton.Name = "SparaButton";
            this.SparaButton.Size = new System.Drawing.Size(129, 34);
            this.SparaButton.TabIndex = 42;
            this.SparaButton.Text = "Spara";
            this.SparaButton.UseVisualStyleBackColor = false;
            this.SparaButton.Click += new System.EventHandler(this.SparaButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 382);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Betyg";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Kursmoment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Kurs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Kursmoment och betyg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Kurser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 41);
            this.label1.TabIndex = 34;
            this.label1.Text = "Betygsättning";
            // 
            // Betyg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.KursmomentTextBox);
            this.Controls.Add(this.KursBetygListBox);
            this.Controls.Add(this.BetygListBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BetygComboBox);
            this.Controls.Add(this.KursTextBox);
            this.Controls.Add(this.StudentTextBox);
            this.Controls.Add(this.KurserListBox);
            this.Controls.Add(this.StudentListBox);
            this.Controls.Add(this.SparaButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Betyg";
            this.Text = "Betyg";
            this.Load += new System.EventHandler(this.Betyg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KursmomentTextBox;
        private System.Windows.Forms.ListBox KursBetygListBox;
        private System.Windows.Forms.ListBox BetygListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox BetygComboBox;
        private System.Windows.Forms.TextBox KursTextBox;
        private System.Windows.Forms.TextBox StudentTextBox;
        private System.Windows.Forms.ListBox KurserListBox;
        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.Button SparaButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}