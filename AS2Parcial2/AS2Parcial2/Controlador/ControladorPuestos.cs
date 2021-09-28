using AS2Parcial2.Modelo;
using AS2Parcial2.Modelo.DTO;
using AS2Parcial2.Vista;
using AS2Parcial2.Vista.Puestos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2Parcial2
{
    public class ControladorPuestos
    {
        private CatalogoPuestos catalogo = null;
        private AgregarPuesto mantinsertar = null;
        private ActualizarPuesto mantactualizar = null;
        private EliminarPuesto manteliminar = null;

        // insertar

        public ControladorPuestos(AgregarPuesto Mantenimiento)
        {
            mantinsertar = Mantenimiento;
            mantinsertar.btnAgregarPuesto.Click += BtnAgregarPuesto_Click;
        }

        private void BtnAgregarPuesto_Click(object sender, EventArgs e)
        {
            DAOPuesto modeloAgregar = new DAOPuesto();
            DTOPuesto modelo = new DTOPuesto();
            modelo.codigo_puesto = mantinsertar.txtPuestoCodigo.Text;
            modelo.nombre_puesto = mantinsertar.txtPuestoNombre.Text;
            modelo.estatus_puesto = mantinsertar.txtPuestoEstado.Text;
            modeloAgregar.AgregarPuesto(modelo);
        }

        // ver catálogo

        public ControladorPuestos(CatalogoPuestos Catalogo)
        {
            catalogo = Catalogo;
            DAOPuesto ver = new DAOPuesto();
            var list = ver.mostrarPuesto();
            var bindingList = new BindingList<DTOPuesto>(list);
            var source = new BindingSource(bindingList, null);
            catalogo.DGVPuestos.DataSource = source;
        }

        // actualizar

        public ControladorPuestos(ActualizarPuesto MantenimientoActualizar)
        {
            mantactualizar = MantenimientoActualizar;
            mantactualizar.btnActualizarPuesto.Click += BtnActualizarPuesto_Click;
            mantactualizar.DGVPuestos.CellClick += DGVPuestos_CellClick;

            DAOPuesto modeloactualizar = new DAOPuesto();
            var list = modeloactualizar.mostrarPuesto();
            var bindingList = new BindingList<DTOPuesto>(list);
            var source = new BindingSource(bindingList, null);
            mantactualizar.DGVPuestos.DataSource = source;
        }

        private void DGVPuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mantactualizar.txtPuestoCodigo.Text = mantactualizar.DGVPuestos.SelectedRows[0].Cells[0].Value.ToString();
            mantactualizar.txtPuestoNombre.Text = mantactualizar.DGVPuestos.SelectedRows[0].Cells[1].Value.ToString();
            mantactualizar.txtPuestoEstado.Text = mantactualizar.DGVPuestos.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void BtnActualizarPuesto_Click(object sender, EventArgs e)
        {
            DAOPuesto modeloactualizar = new DAOPuesto();
            DTOPuesto modelo = new DTOPuesto();

            modelo.codigo_puesto = mantactualizar.txtPuestoCodigo.Text;
            modelo.nombre_puesto = mantactualizar.txtPuestoNombre.Text;
            modelo.estatus_puesto = mantactualizar.txtPuestoEstado.Text;
            modeloactualizar.ModificarPuesto(modelo);

            var list = modeloactualizar.mostrarPuesto();
            var bindingList = new BindingList<DTOPuesto>(list);
            var source = new BindingSource(bindingList, null);
            mantactualizar.DGVPuestos.DataSource = source;
        }

        // eliminar

        public ControladorPuestos(EliminarPuesto EliminarPuesto)
        {
            manteliminar = EliminarPuesto;
            manteliminar.btnEliminarPuesto.Click += BtnEliminarPuesto_Click; ;
            manteliminar.DGVPuestos.CellClick += DGVPuestos_CellClick1; ;

            DAOPuesto modeloactualizar = new DAOPuesto();
            var list = modeloactualizar.mostrarPuesto();
            var bindingList = new BindingList<DTOPuesto>(list);
            var source = new BindingSource(bindingList, null);
            manteliminar.DGVPuestos.DataSource = source;
        }

        private void DGVPuestos_CellClick1(object sender, DataGridViewCellEventArgs e)
        {
            manteliminar.txtPuestoCodigo.Text = manteliminar.DGVPuestos.SelectedRows[0].Cells[0].Value.ToString();
            manteliminar.txtPuestoNombre.Text = manteliminar.DGVPuestos.SelectedRows[0].Cells[1].Value.ToString();
            manteliminar.txtPuestoEstado.Text = manteliminar.DGVPuestos.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void BtnEliminarPuesto_Click(object sender, EventArgs e)
        {
            DAOPuesto modeloactualizar = new DAOPuesto();
            DTOPuesto modelo = new DTOPuesto();

            modelo.codigo_puesto = manteliminar.txtPuestoCodigo.Text;
            modeloactualizar.EliminarPuesto(modelo);

            var list = modeloactualizar.mostrarPuesto();
            var bindingList = new BindingList<DTOPuesto>(list);
            var source = new BindingSource(bindingList, null);
            manteliminar.DGVPuestos.DataSource = source;
        }
    }
}