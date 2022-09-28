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
    public partial class TProducto : Form
    {
        //private static ServiceReference1.CPASoapClient servicio;

        public TProducto()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            /*servicio = new ServiceReference1.CPASoapClient();
            gvRuc.DataSource = servicio.ListarRuc().Tables[0];*/
        }
    }
}
