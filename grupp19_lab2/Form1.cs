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
        HanteraKurser hanteraKurser;
        HanteraLärarlag hanteraLärarlag;

        Form[] allaSidor;

        Point startPoint = new Point(0, 0);

        private IDatabaseConnection databas;


        public Form1()
        {
            databas = new SqliteDatabaseConnection();

            InitializeComponent();
            studenter = new Studenter(this);
            kurser = new Kurser(this);
            lärare = new Lärare(this);
            betyg = new Betyg(this);
            hjälp = new Hjälp(this);
            hanteraKurser = new HanteraKurser(this);
            hanteraLärarlag = new HanteraLärarlag(this);

            allaSidor = new Form[7];
            allaSidor[0] = studenter;
            allaSidor[1] = kurser;
            allaSidor[2] = lärare;  
            allaSidor[3] = betyg;
            allaSidor[4] = hjälp;
            allaSidor[5] = hanteraKurser;
            allaSidor[6] = hanteraLärarlag;

            foreach (Form f in allaSidor)
            {
                f.MdiParent = this;
            }

            resetVisiblity();
            studenter.Show();

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
            foreach (Form f in allaSidor)
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


        private void betygToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            betyg.Show();
            betyg.Location = startPoint;
            betyg.Uppdatera();

        }

        private void hjälpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            hjälp.Show();
            hjälp.Location = startPoint;

        }
    

        private void nyKursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            kurser.Show();
            kurser.Location = startPoint;
            kurser.Uppdatera();

        }

        private void hanteraKurserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            hanteraKurser.Show();
            hanteraKurser.Location = startPoint;
            hanteraKurser.Uppdatera();

        }

        private void kurserToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            if (sender is ToolStripDropDownItem)
            {
                ToolStripDropDownItem item = sender as ToolStripDropDownItem;
                if (item.HasDropDownItems && !item.DropDown.Visible)
                {
                    item.ShowDropDown();
                }
            }
        }

        public IDatabaseConnection Databasanslutning()
        {
            return databas;

        }

        private void hanteraLärareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            lärare.Show();
            lärare.Location = startPoint;

        }

        private void hanteraLärarlagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetVisiblity();
            hanteraLärarlag.Show();
            hanteraLärarlag.Location = startPoint;

        }

        private void lärareToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            if (sender is ToolStripDropDownItem)
            {
                ToolStripDropDownItem item = sender as ToolStripDropDownItem;
                if (item.HasDropDownItems && !item.DropDown.Visible)
                {
                    item.ShowDropDown();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
