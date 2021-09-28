using AS2Parcial2.Vista;
using AS2Parcial2.Vista.Departamento;
using AS2Parcial2.Vista.Empleado;
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

        // DEPARTAMENTOS
        private void btnVerDepartamentos_Click(object sender, EventArgs e)
        {
            CatalogoDepartamento CatalogoDepartamento = new CatalogoDepartamento();
            CatalogoDepartamento.MdiParent = this;
            CatalogoDepartamento.Show();
        }

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            CatalogoEmpleado CatalogoEmpleado = new CatalogoEmpleado();
            CatalogoEmpleado.MdiParent = this;
            CatalogoEmpleado.Show();
        }

        private void btnInsertarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado AgregarEmpleado = new AgregarEmpleado();
            AgregarEmpleado.MdiParent = this;
            AgregarEmpleado.Show();
        }

        private void btnInsertarDepartamento_Click(object sender, EventArgs e)
        {
            AgregarDepartamento AgregarDepartamento = new AgregarDepartamento();
            AgregarDepartamento.MdiParent = this;
            AgregarDepartamento.Show();
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            ActualizarEmpleado ActualizarEmpleado = new ActualizarEmpleado();
            ActualizarEmpleado.MdiParent = this;
            ActualizarEmpleado.Show();
        }

        private void btnActualizarDepartamento_Click(object sender, EventArgs e)
        {
            ActualizarDepartamento ActualizarDepartamento = new ActualizarDepartamento();
            ActualizarDepartamento.MdiParent = this;
            ActualizarDepartamento.Show();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            EliminarEmpleado EliminarEmpleado = new EliminarEmpleado();
            EliminarEmpleado.MdiParent = this;
            EliminarEmpleado.Show();
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
        {
            EliminarDepartamento EliminarDepartamento = new EliminarDepartamento();
            EliminarDepartamento.MdiParent = this;
            EliminarDepartamento.Show();
        }
    }
}