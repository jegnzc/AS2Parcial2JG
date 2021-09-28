using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2Parcial2.Modelo.DTO
{
    class DTODepartamento
    {
        public string codigo_departamento { get; set; }
        public string nombre_departamento { get; set; }
        public string estatus_departamento { get; set; }

        public DTODepartamento(string codigo_departamento, string nombre_departamento, string estatus_departamento)
        {
            this.codigo_departamento = codigo_departamento;
            this.nombre_departamento = nombre_departamento;
            this.estatus_departamento = estatus_departamento;
        }

        public DTODepartamento()
        {
        }
    }
}