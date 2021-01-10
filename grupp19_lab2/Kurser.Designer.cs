
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
            this.kursListBox = new System.Windows.Forms.ListBox();
            this.lärarlagComboBox = new System.Windows.Forms.ComboBox();
            this.lärarlagLabel = new System.Windows.Forms.Label();
            this.kursmomentTextBox = new System.Windows.Forms.TextBox();
            this.kursmomentLabel = new System.Windows.Forms.Label();
            this.kursNamnTextBox = new System.Windows.Forms.TextBox();
            this.kursNamnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kursListBox
            // 
            this.kursListBox.FormattingEnabled = true;
            this.kursListBox.ItemHeight = 20;
            this.kursListBox.Location = new System.Drawing.Point(786, 100);
            this.kursListBox.Name = "kursListBox";
            this.kursListBox.Size = new System.Drawing.Size(285, 364);
            this.kursListBox.TabIndex = 0;
            // 
            // lärarlagComboBox
            // 
            this.lärarlagComboBox.FormattingEnabled = true;
            this.lärarlagComboBox.Location = new System.Drawing.Point(118, 552);
            this.lärarlagComboBox.Name = "lärarlagComboBox";
            this.lärarlagComboBox.Size = new System.Drawing.Size(137, 28);
            this.lärarlagComboBox.TabIndex = 1;
            // 
            // lärarlagLabel
            // 
            this.lärarlagLabel.AutoSize = true;
            this.lärarlagLabel.Location = new System.Drawing.Point(117, 526);
            this.lärarlagLabel.Name = "lärarlagLabel";
            this.lärarlagLabel.Size = new System.Drawing.Size(67, 20);
            this.lärarlagLabel.TabIndex = 2;
            this.lärarlagLabel.Text = "Lärarlag";
            // 
            // kursmomentTextBox
            // 
            this.kursmomentTextBox.Location = new System.Drawing.Point(124, 642);
            this.kursmomentTextBox.Name = "kursmomentTextBox";
            this.kursmomentTextBox.Size = new System.Drawing.Size(160, 26);
            this.kursmomentTextBox.TabIndex = 3;
            // 
            // kursmomentLabel
            // 
            this.kursmomentLabel.AutoSize = true;
            this.kursmomentLabel.Location = new System.Drawing.Point(121, 616);
            this.kursmomentLabel.Name = "kursmomentLabel";
            this.kursmomentLabel.Size = new System.Drawing.Size(99, 20);
            this.kursmomentLabel.TabIndex = 4;
            this.kursmomentLabel.Text = "Kursmoment";
            // 
            // kursNamnTextBox
            // 
            this.kursNamnTextBox.Location = new System.Drawing.Point(118, 157);
            this.kursNamnTextBox.Name = "kursNamnTextBox";
            this.kursNamnTextBox.Size = new System.Drawing.Size(181, 26);
            this.kursNamnTextBox.TabIndex = 5;
            // 
            // kursNamnLabel
            // 
            this.kursNamnLabel.AutoSize = true;
            this.kursNamnLabel.Location = new System.Drawing.Point(118, 131);
            this.kursNamnLabel.Name = "kursNamnLabel";
            this.kursNamnLabel.Size = new System.Drawing.Size(81, 20);
            this.kursNamnLabel.TabIndex = 6;
            this.kursNamnLabel.Text = "Kursnamn";
            // 
            // Kurser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 826);
            this.Controls.Add(this.kursNamnLabel);
            this.Controls.Add(this.kursNamnTextBox);
            this.Controls.Add(this.kursmomentLabel);
            this.Controls.Add(this.kursmomentTextBox);
            this.Controls.Add(this.lärarlagLabel);
            this.Controls.Add(this.lärarlagComboBox);
            this.Controls.Add(this.kursListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kurser";
            this.Text = "Kurser";
            this.Load += new System.EventHandler(this.Kurser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox kursListBox;
        private System.Windows.Forms.ComboBox lärarlagComboBox;
        private System.Windows.Forms.Label lärarlagLabel;
        private System.Windows.Forms.TextBox kursmomentTextBox;
        private System.Windows.Forms.Label kursmomentLabel;
        private System.Windows.Forms.TextBox kursNamnTextBox;
        private System.Windows.Forms.Label kursNamnLabel;
    }
}