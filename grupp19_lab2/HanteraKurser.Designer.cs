
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
            // 
            // studentListBox
            // 
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.ItemHeight = 20;
            this.studentListBox.Location = new System.Drawing.Point(647, 119);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(257, 404);
            this.studentListBox.TabIndex = 2;
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
            this.lärarlagLabel.Location = new System.Drawing.Point(59, 544);
            this.lärarlagLabel.Name = "lärarlagLabel";
            this.lärarlagLabel.Size = new System.Drawing.Size(67, 20);
            this.lärarlagLabel.TabIndex = 6;
            this.lärarlagLabel.Text = "Lärarlag";
            // 
            // lärarlagTextBox
            // 
            this.lärarlagTextBox.Location = new System.Drawing.Point(59, 568);
            this.lärarlagTextBox.Name = "lärarlagTextBox";
            this.lärarlagTextBox.Size = new System.Drawing.Size(247, 26);
            this.lärarlagTextBox.TabIndex = 7;
            // 
            // HanteraKurser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 826);
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
    }
}