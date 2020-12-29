using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupp19_lab2
{
    public partial class Form1 : Form
    {

        Studenter studenter;
        Kurser kurser;
        Lärare lärare;
        Betyg betyg;
        Hjälp hjälp;
        
        Form[] allaSidor;

        Point startPoint = new Point(0, 0);

        

        public Form1()
        {
            InitializeComponent();
            studenter = new Studenter(this);
            kurser = new Kurser(this);
            lärare = new Lärare(this);
            betyg = new Betyg(this);
            hjälp = new Hjälp(this);

            allaSidor = new Form[5];
            allaSidor[0] = studenter;
            allaSidor[1] = kurser;
            allaSidor[2] = lärare;
            allaSidor[3] = betyg;
            allaSidor[4] = hjälp;




            foreach(Form f in allaSidor)
            {
                f.MdiParent = this;
            }

            resetVisiblity();
            studenter.Show();

            /*
            studenter.BackColor = Color.Maroon;
            kurser.BackColor = Color.Aqua;
            lärare.BackColor = Color.Beige;
            betyg.BackColor = Color.Chocolate;
            hjälp.BackColor = Color.Coral;
            
            */

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            var mdiclient = this.Controls.OfType<MdiClient>().Single();
            this.SuspendLayout();
            mdiclient.SuspendLayout();
            var hdiff = mdiclient.Size.Width - mdiclient.ClientSize.Width;
            var vdiff = mdiclient.Size.Height - mdiclient.ClientSize.Height;
            var size = new Size(mdiclient.Width + hdiff, mdiclient.Height + vdiff);
            var location = new Point(mdiclient.Left - (hdiff / 2), mdiclient.Top - (vdiff / 2));
            mdiclient.Dock = DockStyle.None;
            mdiclient.Size = size;
            mdiclient.Location = location;
            mdiclient.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            mdiclient.ResumeLayout(true);
            this.ResumeLayout(true);
            base.OnLoad(e);

        }

        
        private void resetVisiblity()
        {
             foreach(Form f in allaSidor)
            {
                f.Hide();
                f.Location = startPoint;

            }
        }

        private void studenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            studenter.Show();
            studenter.Location = startPoint;

        }

        private void kurserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            kurser.Show();
            kurser.Location = startPoint;

        }

        private void lärareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            lärare.Show();
            lärare.Location = startPoint;

        }

        private void betygToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            betyg.Show();
            betyg.Location = startPoint;

        }

        private void hjälpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            hjälp.Show();
            hjälp.Location = startPoint;

        }

       
    }
}
