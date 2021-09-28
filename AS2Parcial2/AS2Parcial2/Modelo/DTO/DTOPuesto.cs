using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2Parcial2.Modelo.DTO
{
    public class DTOPuesto
    {
        public string codigo_puesto { get; set; }
        public string nombre_puesto { get; set; }
        public string estatus_puesto { get; set; }

        public DTOPuesto(string codigo_puesto, string nombre_puesto, string estatus_puesto)
        {
            this.codigo_puesto = codigo_puesto;
            this.nombre_puesto = nombre_puesto;
            this.estatus_puesto = estatus_puesto;
        }

        public DTOPuesto()
        {
        }
    }
}