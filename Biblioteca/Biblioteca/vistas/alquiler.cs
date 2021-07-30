using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.negocio;
using Biblioteca.modelo;

namespace Biblioteca.vistas
{
    public partial class alquiler : frmplantilla
    {
        public alquiler()
        {
            InitializeComponent();
        }

        private void alquiler_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'alquilerLibrosDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.alquilerLibrosDataSet.Libros);
            // TODO: esta línea de código carga datos en la tabla 'alquilerLibrosDataSet.Socios' Puede moverla o quitarla según sea necesario.
            this.sociosTableAdapter.Fill(this.alquilerLibrosDataSet.Socios);

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alquiler alq = new Alquiler();
            alq.fecha = dateTimePicker1.Value;
            //alq.id_libros = Convert.ToInt32(comboBox2.SelectedItem);
            alq.id_libros = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            alq.id_socios = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            cnAlquiler cnalq = new cnAlquiler();
            cnalq.GuardarAlquilerNegocio(alq);
            dataGridView1.DataSource = null;
            LlenarTabla();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LlenarTabla()
        {
            Alquiler alq = new Alquiler();
            AlquilerLibrosEntities db = new AlquilerLibrosEntities();

            var datos = from a in db.Alquiler
                        select new
                        {
                            socio = a.Socios.nombre,
                            libro = a.Libros.nombre,
                            fecha = a.fecha
                        };
            dataGridView1.DataSource = datos.ToList();

        }
        
    }
}
