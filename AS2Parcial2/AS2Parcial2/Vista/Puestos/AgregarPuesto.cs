using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2Parcial2.Vista
{
    public partial class AgregarPuesto : Form
    {
        public AgregarPuesto()
        {
            InitializeComponent();
            ControladorPuestos controlador = new ControladorPuestos(this);
        }
    }
}