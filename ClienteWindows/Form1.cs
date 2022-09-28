using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TCategoria c1 = new TCategoria();
            c1.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TProducto p1 = new TProducto();
            p1.Show();
        }
    }
}
