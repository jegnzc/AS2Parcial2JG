using AS2Parcial2.Vista;
using AS2Parcial2.Vista.Puestos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2Parcial2
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        //private AgregarPuesto f2;

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (f2 == null)
            //{
            //    f2 = new CatalogoPuestos();
            //    f2.MdiParent = this;
            //    f2.FormClosed += F2_FormClosed;
            //    f2.Show();
            //}
            //else
            //{
            //    f2.Activate();
            //}
        }

        //private void F2_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    f2 = null;
        //}

        private CatalogoPuestos CatalogoPuestos = null;

        private void btnVerPuestos_Click(object sender, EventArgs e)
        {
            CatalogoPuestos = new CatalogoPuestos();
            CatalogoPuestos.MdiParent = this;
            CatalogoPuestos.Show();
        }

        private AgregarPuesto AgregarPuesto = null;

        private void btnInsertarPuesto_Click(object sender, EventArgs e)
        {
            AgregarPuesto = new AgregarPuesto();
            AgregarPuesto.MdiParent = this;
            AgregarPuesto.Show();
        }

        private ActualizarPuesto ActualizarPuesto = null;

        private void btnActualizarPuesto_Click(object sender, EventArgs e)
        {
            ActualizarPuesto = new ActualizarPuesto();
            ActualizarPuesto.MdiParent = this;
            ActualizarPuesto.Show();
        }

        private EliminarPuesto EliminarPuesto = null;

        private void btnEliminarPuesto_Click(object sender, EventArgs e)
        {
            EliminarPuesto = new EliminarPuesto();
            EliminarPuesto.MdiParent = this;
            EliminarPuesto.Show();
        }
    }
}