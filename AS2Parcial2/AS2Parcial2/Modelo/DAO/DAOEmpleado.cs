using AS2Parcial2.Modelo.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2Parcial2.Modelo.DAO
{
    class DAOEmpleado
    {
        private ConexionODBC ConexionODBC = new ConexionODBC();

        public DTOEmpleado AgregarEmpleado(DTOEmpleado modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
               "INSERT INTO empleado (codigo_empleado, nombre_empleado, codigo_puesto, codigo_departamento, sueldo_empleado, estatus_empleado) " +
               "VALUES (?codigo_empleado?, ?nombre_empleado?, ?codigo_puesto?, ?codigo_departamento?, ?sueldo_empleado?, ?estatus_empleado?);";
                var ValorDeVariables = new
                {
                    codigo_empleado = modelo.codigo_empleado,
                    nombre_empleado = modelo.nombre_empleado,
                    codigo_puesto = modelo.codigo_puesto,
                    codigo_departamento = modelo.codigo_departamento,
                    sueldo_empleado = modelo.sueldo_empleado,
                    estatus_empleado = modelo.estatus_empleado
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<DTOEmpleado> MostrarEmpleados()
        {
            List<DTOEmpleado> sqlresultado = new List<DTOEmpleado>();
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM empleado;";
                sqlresultado = conexionODBC.Query<DTOEmpleado>(sqlconsulta).ToList();
                ConexionODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }

        public DTOEmpleado ModificarEmpleado(DTOEmpleado modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE empleado SET nombre_empleado = ?nombre_empleado?" +
                ", codigo_puesto = ?codigo_puesto?, codigo_departamento = ?codigo_departamento?" +
                ", sueldo_empleado = ?sueldo_empleado?, estatus_empleado = ?estatus_empleado?" +
                " WHERE codigo_empleado = ?codigo_empleado?;";
                var ValorDeVariables = new
                {
                    codigo_empleado = modelo.codigo_empleado,
                    nombre_empleado = modelo.nombre_empleado,
                    codigo_puesto = modelo.codigo_puesto,
                    codigo_departamento = modelo.codigo_departamento,
                    sueldo_empleado = modelo.sueldo_empleado,
                    estatus_empleado = modelo.estatus_empleado
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public DTOEmpleado EliminarEmpleado(DTOEmpleado modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM empleado WHERE codigo_empleado = ?codigo_empleado?;";
                var ValorDeVariables = new
                {
                    codigo_empleado = modelo.codigo_empleado
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}