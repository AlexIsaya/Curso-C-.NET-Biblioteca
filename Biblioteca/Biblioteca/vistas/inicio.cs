using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.vistas
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            libros lib = new libros();
            lib.MdiParent = this;
            lib.Show();
        }

        private void altasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            empleados soc = new empleados();
            soc.MdiParent = this;
            soc.Show();
        }

        private void altasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            alquiler alq = new alquiler();
            alq.MdiParent=this;
            alq.Show();
        }
    }
}
