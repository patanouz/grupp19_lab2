
namespace grupp19_lab2
{
    partial class HanteraLärarlag
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
            this.availableTeacherListBox = new System.Windows.Forms.ListBox();
            this.chosenTeacherListBox = new System.Windows.Forms.ListBox();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.removeTeacherButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.newTeamLabel = new System.Windows.Forms.Label();
            this.saveTeamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // availableTeacherListBox
            // 
            this.availableTeacherListBox.FormattingEnabled = true;
            this.availableTeacherListBox.Location = new System.Drawing.Point(375, 80);
            this.availableTeacherListBox.Margin = new System.Windows.Forms.Padding(2);
            this.availableTeacherListBox.Name = "availableTeacherListBox";
            this.availableTeacherListBox.Size = new System.Drawing.Size(150, 277);
            this.availableTeacherListBox.TabIndex = 12;
            this.availableTeacherListBox.SelectedIndexChanged += new System.EventHandler(this.availableTeacherListBox_SelectedIndexChanged);
            // 
            // chosenTeacherListBox
            // 
            this.chosenTeacherListBox.FormattingEnabled = true;
            this.chosenTeacherListBox.Location = new System.Drawing.Point(583, 80);
            this.chosenTeacherListBox.Margin = new System.Windows.Forms.Padding(2);
            this.chosenTeacherListBox.Name = "chosenTeacherListBox";
            this.chosenTeacherListBox.Size = new System.Drawing.Size(150, 277);
            this.chosenTeacherListBox.TabIndex = 13;
            this.chosenTeacherListBox.SelectedIndexChanged += new System.EventHandler(this.chosenTeacherListBox_SelectedIndexChanged);
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(529, 140);
            this.addTeacherButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(50, 29);
            this.addTeacherButton.TabIndex = 14;
            this.addTeacherButton.Text = ">";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // removeTeacherButton
            // 
            this.removeTeacherButton.Location = new System.Drawing.Point(529, 218);
            this.removeTeacherButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeTeacherButton.Name = "removeTeacherButton";
            this.removeTeacherButton.Size = new System.Drawing.Size(50, 29);
            this.removeTeacherButton.TabIndex = 15;
            this.removeTeacherButton.Text = "<";
            this.removeTeacherButton.UseVisualStyleBackColor = true;
            this.removeTeacherButton.Click += new System.EventHandler(this.removeTeacherButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(48, 102);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 17;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newTeamLabel
            // 
            this.newTeamLabel.AutoSize = true;
            this.newTeamLabel.Location = new System.Drawing.Point(45, 86);
            this.newTeamLabel.Name = "newTeamLabel";
            this.newTeamLabel.Size = new System.Drawing.Size(71, 13);
            this.newTeamLabel.TabIndex = 18;
            this.newTeamLabel.Text = "Lärarlagnamn";
            // 
            // saveTeamButton
            // 
            this.saveTeamButton.Location = new System.Drawing.Point(342, 402);
            this.saveTeamButton.Name = "saveTeamButton";
            this.saveTeamButton.Size = new System.Drawing.Size(75, 23);
            this.saveTeamButton.TabIndex = 19;
            this.saveTeamButton.Text = "Spara";
            this.saveTeamButton.UseVisualStyleBackColor = true;
            this.saveTeamButton.Click += new System.EventHandler(this.saveTeamButton_Click);
            // 
            // HanteraLärarlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.saveTeamButton);
            this.Controls.Add(this.newTeamLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.removeTeacherButton);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.chosenTeacherListBox);
            this.Controls.Add(this.availableTeacherListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HanteraLärarlag";
            this.Text = "HanteraLärarlag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox availableTeacherListBox;
        private System.Windows.Forms.ListBox chosenTeacherListBox;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button removeTeacherButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label newTeamLabel;
        private System.Windows.Forms.Button saveTeamButton;
    }
}