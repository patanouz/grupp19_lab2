﻿
namespace grupp19_lab2
{
    partial class Lärare
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
            this.teacherListBox = new System.Windows.Forms.ListBox();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.teacherSearchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteTeacherButton = new System.Windows.Forms.Button();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.personnrLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.personnrTextbox = new System.Windows.Forms.TextBox();
            this.firstnameTextbox = new System.Windows.Forms.TextBox();
            this.lastnameTextbox = new System.Windows.Forms.TextBox();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.mailTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // teacherListBox
            // 
            this.teacherListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teacherListBox.FormattingEnabled = true;
            this.teacherListBox.Location = new System.Drawing.Point(28, 140);
            this.teacherListBox.Name = "teacherListBox";
            this.teacherListBox.Size = new System.Drawing.Size(337, 299);
            this.teacherListBox.TabIndex = 0;
            this.teacherListBox.SelectedIndexChanged += new System.EventHandler(this.teacherListBox_SelectedIndexChanged);
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Font = new System.Drawing.Font("Segoe UI", 21.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLabel.Location = new System.Drawing.Point(21, 17);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(105, 41);
            this.teacherLabel.TabIndex = 1;
            this.teacherLabel.Text = "Lärare";
            // 
            // teacherSearchBox
            // 
            this.teacherSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teacherSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.teacherSearchBox.Location = new System.Drawing.Point(28, 88);
            this.teacherSearchBox.Multiline = true;
            this.teacherSearchBox.Name = "teacherSearchBox";
            this.teacherSearchBox.Size = new System.Drawing.Size(271, 23);
            this.teacherSearchBox.TabIndex = 2;
            this.teacherSearchBox.TextChanged += new System.EventHandler(this.teacherSearchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchButton.Location = new System.Drawing.Point(299, 88);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(67, 25);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Sök";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteTeacherButton
            // 
            this.deleteTeacherButton.BackColor = System.Drawing.Color.Firebrick;
            this.deleteTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeacherButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTeacherButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteTeacherButton.Location = new System.Drawing.Point(27, 454);
            this.deleteTeacherButton.Name = "deleteTeacherButton";
            this.deleteTeacherButton.Size = new System.Drawing.Size(106, 34);
            this.deleteTeacherButton.TabIndex = 4;
            this.deleteTeacherButton.Text = "Ta bort";
            this.deleteTeacherButton.UseVisualStyleBackColor = false;
            this.deleteTeacherButton.Click += new System.EventHandler(this.deleteTeacherButton_Click);
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeacherButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeacherButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTeacherButton.Location = new System.Drawing.Point(140, 454);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(227, 34);
            this.addTeacherButton.TabIndex = 5;
            this.addTeacherButton.Text = "Lägg till ny lärare";
            this.addTeacherButton.UseVisualStyleBackColor = false;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // personnrLabel
            // 
            this.personnrLabel.AutoSize = true;
            this.personnrLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.personnrLabel.Location = new System.Drawing.Point(462, 119);
            this.personnrLabel.Name = "personnrLabel";
            this.personnrLabel.Size = new System.Drawing.Size(96, 17);
            this.personnrLabel.TabIndex = 6;
            this.personnrLabel.Text = "Personnummer";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.firstNameLabel.Location = new System.Drawing.Point(462, 185);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(59, 17);
            this.firstNameLabel.TabIndex = 7;
            this.firstNameLabel.Text = "Förnamn";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lastNameLabel.Location = new System.Drawing.Point(462, 243);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(67, 17);
            this.lastNameLabel.TabIndex = 8;
            this.lastNameLabel.Text = "Efternamn";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.phoneNumberLabel.Location = new System.Drawing.Point(462, 303);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(98, 17);
            this.phoneNumberLabel.TabIndex = 9;
            this.phoneNumberLabel.Text = "Telefonnummer";
            this.phoneNumberLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.mailLabel.Location = new System.Drawing.Point(462, 363);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(84, 17);
            this.mailLabel.TabIndex = 10;
            this.mailLabel.Text = "Epost adress";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelButton.Enabled = false;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelButton.Location = new System.Drawing.Point(644, 454);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 34);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Avbryt";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveButton.Location = new System.Drawing.Point(465, 454);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(172, 34);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Spara";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // personnrTextbox
            // 
            this.personnrTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personnrTextbox.Location = new System.Drawing.Point(465, 150);
            this.personnrTextbox.Multiline = true;
            this.personnrTextbox.Name = "personnrTextbox";
            this.personnrTextbox.ReadOnly = true;
            this.personnrTextbox.Size = new System.Drawing.Size(286, 22);
            this.personnrTextbox.TabIndex = 22;
            // 
            // firstnameTextbox
            // 
            this.firstnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstnameTextbox.Location = new System.Drawing.Point(465, 205);
            this.firstnameTextbox.Multiline = true;
            this.firstnameTextbox.Name = "firstnameTextbox";
            this.firstnameTextbox.ReadOnly = true;
            this.firstnameTextbox.Size = new System.Drawing.Size(286, 22);
            this.firstnameTextbox.TabIndex = 23;
            // 
            // lastnameTextbox
            // 
            this.lastnameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastnameTextbox.Location = new System.Drawing.Point(465, 263);
            this.lastnameTextbox.Multiline = true;
            this.lastnameTextbox.Name = "lastnameTextbox";
            this.lastnameTextbox.ReadOnly = true;
            this.lastnameTextbox.Size = new System.Drawing.Size(286, 22);
            this.lastnameTextbox.TabIndex = 24;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextbox.Location = new System.Drawing.Point(465, 323);
            this.phoneTextbox.Multiline = true;
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.ReadOnly = true;
            this.phoneTextbox.Size = new System.Drawing.Size(286, 22);
            this.phoneTextbox.TabIndex = 25;
            // 
            // mailTextbox
            // 
            this.mailTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailTextbox.Location = new System.Drawing.Point(465, 383);
            this.mailTextbox.Multiline = true;
            this.mailTextbox.Name = "mailTextbox";
            this.mailTextbox.ReadOnly = true;
            this.mailTextbox.Size = new System.Drawing.Size(286, 22);
            this.mailTextbox.TabIndex = 26;
            // 
            // Lärare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.mailTextbox);
            this.Controls.Add(this.phoneTextbox);
            this.Controls.Add(this.lastnameTextbox);
            this.Controls.Add(this.firstnameTextbox);
            this.Controls.Add(this.personnrTextbox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.personnrLabel);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.deleteTeacherButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.teacherSearchBox);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.teacherListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lärare";
            this.Text = "Lärare";
            this.Load += new System.EventHandler(this.Lärare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox teacherListBox;
        private System.Windows.Forms.Label teacherLabel;
        private System.Windows.Forms.TextBox teacherSearchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteTeacherButton;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Label personnrLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox personnrTextbox;
        private System.Windows.Forms.TextBox firstnameTextbox;
        private System.Windows.Forms.TextBox lastnameTextbox;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.TextBox mailTextbox;
    }
}