using AS2Parcial2.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2Parcial2.Vista.Empleado
{
    public partial class ActualizarEmpleado : Form
    {
        public ActualizarEmpleado()
        {
            InitializeComponent();
            ControladorEmpleado controlador = new ControladorEmpleado(this);
        }
    }
}