﻿
namespace grupp19_lab2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lärareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betygToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyKursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hanteraKurserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studenterToolStripMenuItem,
            this.kurserToolStripMenuItem,
            this.lärareToolStripMenuItem,
            this.betygToolStripMenuItem,
            this.hjälpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studenterToolStripMenuItem
            // 
            this.studenterToolStripMenuItem.Name = "studenterToolStripMenuItem";
            this.studenterToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.studenterToolStripMenuItem.Text = "Studenter";
            this.studenterToolStripMenuItem.Click += new System.EventHandler(this.studenterToolStripMenuItem_Click);
            // 
            // kurserToolStripMenuItem
            // 
            this.kurserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyKursToolStripMenuItem,
            this.hanteraKurserToolStripMenuItem});
            this.kurserToolStripMenuItem.Name = "kurserToolStripMenuItem";
            this.kurserToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.kurserToolStripMenuItem.Text = "Kurser";
            this.kurserToolStripMenuItem.Click += new System.EventHandler(this.kurserToolStripMenuItem_Click);
            this.kurserToolStripMenuItem.MouseHover += new System.EventHandler(this.kurserToolStripMenuItem_MouseHover);
            // 
            // lärareToolStripMenuItem
            // 
            this.lärareToolStripMenuItem.Name = "lärareToolStripMenuItem";
            this.lärareToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.lärareToolStripMenuItem.Text = "Lärare";
            this.lärareToolStripMenuItem.Click += new System.EventHandler(this.lärareToolStripMenuItem_Click);
            // 
            // betygToolStripMenuItem
            // 
            this.betygToolStripMenuItem.Name = "betygToolStripMenuItem";
            this.betygToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.betygToolStripMenuItem.Text = "Betyg";
            this.betygToolStripMenuItem.Click += new System.EventHandler(this.betygToolStripMenuItem_Click);
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hjälpToolStripMenuItem.Text = "Hjälp";
            this.hjälpToolStripMenuItem.Click += new System.EventHandler(this.hjälpToolStripMenuItem_Click);
            // 
            // nyKursToolStripMenuItem
            // 
            this.nyKursToolStripMenuItem.Name = "nyKursToolStripMenuItem";
            this.nyKursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nyKursToolStripMenuItem.Text = "Ny kurs";
            this.nyKursToolStripMenuItem.Click += new System.EventHandler(this.nyKursToolStripMenuItem_Click);
            // 
            // hanteraKurserToolStripMenuItem
            // 
            this.hanteraKurserToolStripMenuItem.Name = "hanteraKurserToolStripMenuItem";
            this.hanteraKurserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hanteraKurserToolStripMenuItem.Text = "Hantera kurser";
            this.hanteraKurserToolStripMenuItem.Click += new System.EventHandler(this.hanteraKurserToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ny Kurs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lärareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betygToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyKursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hanteraKurserToolStripMenuItem;
    }
}

