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
    public partial class CatalogoPuestos : Form
    {
        public CatalogoPuestos()
        {
            InitializeComponent();
            ControladorPuestos controlador = new ControladorPuestos(this);
        }
    }
}