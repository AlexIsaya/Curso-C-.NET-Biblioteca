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
    public partial class libros : frmplantilla
    {
        public libros()
        {
            InitializeComponent();
        }

        private void libros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alquilerLibrosDataSet.Libros' Puede moverla o quitarla según sea necesario.
            //this.librosTableAdapter.Fill(this.alquilerLibrosDataSet.Libros);
            librosBindingSource.AddNew();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alquilerLibrosDataSet);

        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.alquilerLibrosDataSet);
        }
    }
}
