using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Álgebra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Det2 nuevo = new Det2();
            nuevo.MdiParent = this;
            nuevo.Show();

        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Det3 nuevo = new Det3();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Det4 nuevo = new Det4();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void x2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inv2 nuevo = new Inv2();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void x3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inv3 nuevo = new Inv3();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void x4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inv4 nuevo = new Inv4();
            nuevo.MdiParent = this;
            nuevo.Show();
        }
    }
}
