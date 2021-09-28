using AS2Parcial2.Modelo.DAO;
using AS2Parcial2.Modelo.DTO;
using AS2Parcial2.Vista.Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2Parcial2.Controlador
{
    class ControladorEmpleado
    {
        private CatalogoEmpleado catalogo = null;
        private AgregarEmpleado mantinsertar = null;
        private ActualizarEmpleado mantactualizar = null;
        private EliminarEmpleado manteliminar = null;

        // insertar

        public ControladorEmpleado(AgregarEmpleado Mantenimiento)
        {
            mantinsertar = Mantenimiento;
            mantinsertar.btnAgregarPuesto.Click += BtnAgregarPuesto_Click;
        }

        private void BtnAgregarPuesto_Click(object sender, EventArgs e)
        {
            DAOEmpleado modeloAgregar = new DAOEmpleado();
            DTOEmpleado modelo = new DTOEmpleado();
            modelo.codigo_empleado = mantinsertar.txtEmpleadoCodigo.Text;
            modelo.nombre_empleado = mantinsertar.txtEmpleadoNombre.Text;
            modelo.codigo_puesto = mantinsertar.txtCodigoPuestoEmpleado.Text;
            modelo.codigo_departamento = mantinsertar.txtCodigoDeptEmpleado.Text;
            modelo.sueldo_empleado = float.Parse(mantinsertar.txtSueldoEmpleado.Text, CultureInfo.InvariantCulture.NumberFormat);
            modelo.estatus_empleado = mantinsertar.txtEstatusEmpleado.Text;
            modeloAgregar.AgregarEmpleado(modelo);
        }

        // ver catálogo

        public ControladorEmpleado(CatalogoEmpleado Catalogo)
        {
            catalogo = Catalogo;
            DAOEmpleado ver = new DAOEmpleado();
            var list = ver.MostrarEmpleados();
            var bindingList = new BindingList<DTOEmpleado>(list);
            var source = new BindingSource(bindingList, null);
            catalogo.DGVPuestos.DataSource = source;
        }

        // actualizar

        public ControladorEmpleado(ActualizarEmpleado MantenimientoActualizar)
        {
            mantactualizar = MantenimientoActualizar;
            mantactualizar.btnActualizarPuesto.Click += BtnActualizarPuesto_Click;
            mantactualizar.DGVPuestos.CellClick += DGVPuestos_CellClick;

            DAOEmpleado modeloactualizar = new DAOEmpleado();
            var list = modeloactualizar.MostrarEmpleados();
            var bindingList = new BindingList<DTOEmpleado>(list);
            var source = new BindingSource(bindingList, null);
            mantactualizar.DGVPuestos.DataSource = source;
        }

        private void DGVPuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mantactualizar.txtEmpleadoCodigo.Text = mantactualizar.DGVPuestos.SelectedRows[0].Cells[0].Value.ToString();
            mantactualizar.txtEmpleadoNombre.Text = mantactualizar.DGVPuestos.SelectedRows[0].Cells[1].Value.ToString();
            mantactualizar.txtCodigoPuestoEmpleado.Text = mantactualizar.DGVPuestos.SelectedRows[0].Cells[2].Value.ToString();
            mantactualizar.txtCodigoDeptEmpleado.Text = mantactualizar.DGVPuestos.SelectedRows[0].Cells[3].Value.ToString();
            mantactualizar.txtSueldoEmpleado.Text = mantactualizar.DGVPuestos.SelectedRows[0].Cells[4].Value.ToString();
            mantactualizar.txtEstatusEmpleado.Text = mantactualizar.DGVPuestos.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void BtnActualizarPuesto_Click(object sender, EventArgs e)
        {
            DAOEmpleado modeloactualizar = new DAOEmpleado();
            DTOEmpleado modelo = new DTOEmpleado();

            modelo.codigo_empleado = mantactualizar.txtEmpleadoCodigo.Text;
            modelo.nombre_empleado = mantactualizar.txtEmpleadoNombre.Text;
            modelo.codigo_puesto = mantactualizar.txtCodigoPuestoEmpleado.Text;
            modelo.codigo_departamento = mantactualizar.txtCodigoDeptEmpleado.Text;
            modelo.sueldo_empleado = float.Parse(mantactualizar.txtSueldoEmpleado.Text, CultureInfo.InvariantCulture.NumberFormat);
            modelo.estatus_empleado = mantactualizar.txtEstatusEmpleado.Text;
            modeloactualizar.ModificarEmpleado(modelo);

            var list = modeloactualizar.MostrarEmpleados();
            var bindingList = new BindingList<DTOEmpleado>(list);
            var source = new BindingSource(bindingList, null);
            mantactualizar.DGVPuestos.DataSource = source;
        }

        // eliminar

        public ControladorEmpleado(EliminarEmpleado EliminarPuesto)
        {
            manteliminar = EliminarPuesto;
            manteliminar.btnEliminarPuesto.Click += BtnEliminarPuesto_Click; ;
            manteliminar.DGVPuestos.CellClick += DGVPuestos_CellClick1; ;

            DAOEmpleado modeloactualizar = new DAOEmpleado();
            var list = modeloactualizar.MostrarEmpleados();
            var bindingList = new BindingList<DTOEmpleado>(list);
            var source = new BindingSource(bindingList, null);
            manteliminar.DGVPuestos.DataSource = source;
        }

        private void DGVPuestos_CellClick1(object sender, DataGridViewCellEventArgs e)
        {
            manteliminar.txtEmpleadoCodigo.Text = manteliminar.DGVPuestos.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void BtnEliminarPuesto_Click(object sender, EventArgs e)
        {
            DAOEmpleado modeloactualizar = new DAOEmpleado();
            DTOEmpleado modelo = new DTOEmpleado();

            modelo.codigo_empleado = manteliminar.txtEmpleadoCodigo.Text;
            modeloactualizar.EliminarEmpleado(modelo);

            var list = modeloactualizar.MostrarEmpleados();
            var bindingList = new BindingList<DTOEmpleado>(list);
            var source = new BindingSource(bindingList, null);
            manteliminar.DGVPuestos.DataSource = source;
        }
    }
}