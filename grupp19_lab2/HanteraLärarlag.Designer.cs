﻿
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
            this.saveTeamButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // availableTeacherListBox
            // 
            this.availableTeacherListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.availableTeacherListBox.FormattingEnabled = true;
            this.availableTeacherListBox.ItemHeight = 24;
            this.availableTeacherListBox.Location = new System.Drawing.Point(46, 330);
            this.availableTeacherListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.availableTeacherListBox.Name = "availableTeacherListBox";
            this.availableTeacherListBox.Size = new System.Drawing.Size(656, 312);
            this.availableTeacherListBox.TabIndex = 12;
            this.availableTeacherListBox.SelectedIndexChanged += new System.EventHandler(this.availableTeacherListBox_SelectedIndexChanged);
            // 
            // chosenTeacherListBox
            // 
            this.chosenTeacherListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chosenTeacherListBox.FormattingEnabled = true;
            this.chosenTeacherListBox.ItemHeight = 24;
            this.chosenTeacherListBox.Location = new System.Drawing.Point(738, 330);
            this.chosenTeacherListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chosenTeacherListBox.Name = "chosenTeacherListBox";
            this.chosenTeacherListBox.Size = new System.Drawing.Size(656, 312);
            this.chosenTeacherListBox.TabIndex = 13;
            this.chosenTeacherListBox.SelectedIndexChanged += new System.EventHandler(this.chosenTeacherListBox_SelectedIndexChanged);
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.addTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeacherButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacherButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTeacherButton.Location = new System.Drawing.Point(46, 660);
            this.addTeacherButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(151, 54);
            this.addTeacherButton.TabIndex = 14;
            this.addTeacherButton.Text = "Lägg till";
            this.addTeacherButton.UseVisualStyleBackColor = false;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // removeTeacherButton
            // 
            this.removeTeacherButton.BackColor = System.Drawing.Color.Firebrick;
            this.removeTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeTeacherButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTeacherButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.removeTeacherButton.Location = new System.Drawing.Point(738, 660);
            this.removeTeacherButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeTeacherButton.Name = "removeTeacherButton";
            this.removeTeacherButton.Size = new System.Drawing.Size(151, 54);
            this.removeTeacherButton.TabIndex = 15;
            this.removeTeacherButton.Text = "Ta bort";
            this.removeTeacherButton.UseVisualStyleBackColor = false;
            this.removeTeacherButton.Click += new System.EventHandler(this.removeTeacherButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameBox.Location = new System.Drawing.Point(46, 209);
            this.nameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nameBox.Multiline = true;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(656, 43);
            this.nameBox.TabIndex = 17;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // saveTeamButton
            // 
            this.saveTeamButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.saveTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveTeamButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTeamButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveTeamButton.Location = new System.Drawing.Point(46, 857);
            this.saveTeamButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.saveTeamButton.Name = "saveTeamButton";
            this.saveTeamButton.Size = new System.Drawing.Size(234, 54);
            this.saveTeamButton.TabIndex = 19;
            this.saveTeamButton.Text = "Spara";
            this.saveTeamButton.UseVisualStyleBackColor = false;
            this.saveTeamButton.Click += new System.EventHandler(this.saveTeamButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 68);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lärarlag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Skapa ett nytt lärarlag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tillgängliga lärare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(732, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 32);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tillagda lärare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 805);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Spara lärarlaget?";
            // 
            // HanteraLärarlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 991);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveTeamButton);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.removeTeacherButton);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.chosenTeacherListBox);
            this.Controls.Add(this.availableTeacherListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "HanteraLärarlag";
            this.Text = "HanteraLärarlag";
            this.Load += new System.EventHandler(this.HanteraLärarlag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox availableTeacherListBox;
        private System.Windows.Forms.ListBox chosenTeacherListBox;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button removeTeacherButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button saveTeamButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}