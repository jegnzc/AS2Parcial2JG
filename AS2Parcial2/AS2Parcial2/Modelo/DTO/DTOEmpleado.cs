using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2Parcial2.Modelo.DTO
{
    class DTOEmpleado
    {
        public string codigo_empleado { get; set; }
        public string nombre_empleado { get; set; }
        public string codigo_puesto { get; set; }
        public string codigo_departamento { get; set; }
        public float sueldo_empleado { get; set; }
        public string estatus_empleado { get; set; }

        public DTOEmpleado()
        {
        }
    }
}