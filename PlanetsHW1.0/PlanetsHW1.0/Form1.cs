using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetsHW1._0
{
    public partial class Form1 : Form
    {
        Astro[] astros;
        
        bool[] items = new bool[] { false, false, false };

        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            astros = new Astro[]
            {
            new Sun(pictureBox1.ClientSize.Width * 0.1f, pictureBox1.ClientSize.Width * 0.1f, 25, 25),
            new Planet(pictureBox1.ClientSize.Width * 0.3f, pictureBox1.ClientSize.Width * 0.3f, 50 + pictureBox1.ClientSize.Width * 0.1f, 50 + pictureBox1.ClientSize.Width * 0.1f),
            new Comet(pictureBox1.ClientSize.Width * 0.15f, pictureBox1.ClientSize.Width * 0.15f, 300 + pictureBox1.ClientSize.Width * 0.1f + pictureBox1.ClientSize.Width * 0.3f, 50 + pictureBox1.ClientSize.Width * 0.1f)
            };
            if (items[0] == true)
                astros[0].Draw(e.Graphics);
            if (items[1] == true)
                astros[1].Draw(e.Graphics);
            if (items[2] == true)
                astros[2].Draw(e.Graphics);

        }

        /*private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            if (items[0] == true)
                astros[0].Draw(e.Graphics);
            if (items[1] == true)
                astros[1].Draw(e.Graphics);
            if (items[2] == true)
                astros[2].Draw(e.Graphics);
            Invalidate();
        }*/

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void sunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sunToolStripMenuItem.Checked == true)
                items[0] = true;
            else
                items[0] = false;

            pictureBox1.Invalidate();
        }
        private void saturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saturnToolStripMenuItem.Checked == true)
                items[1] = true;
            else
                items[1] = false;

            pictureBox1.Invalidate();
        }
        private void cometToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cometToolStripMenuItem.Checked == true)
                items[2] = true;
            else
                items[2] = false;

            pictureBox1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Checked = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }
    }
}
