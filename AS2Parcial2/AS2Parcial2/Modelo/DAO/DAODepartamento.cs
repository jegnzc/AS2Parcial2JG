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
    class DAODepartamento
    {
        private ConexionODBC ConexionODBC = new ConexionODBC();

        public DTODepartamento AgregarDepartamento(DTODepartamento modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
               "INSERT INTO puesto (codigo_departamento, nombre_departamento, estatus_departamento) " +
               "VALUES (?codigo_departamento?, ?nombre_departamento?, ?estatus_departamento?);";
                var ValorDeVariables = new
                {
                    codigo_departamento = modelo.codigo_departamento,
                    nombre_departamento = modelo.nombre_departamento,
                    estatus_departamento = modelo.estatus_departamento
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<DTODepartamento> MostrarDepartamentos()
        {
            List<DTODepartamento> sqlresultado = new List<DTODepartamento>();
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM departamento;";
                sqlresultado = conexionODBC.Query<DTODepartamento>(sqlconsulta).ToList();
                ConexionODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }

        public DTODepartamento ModificarDepartamento(DTODepartamento modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE departamento SET nombre_departamento = ?nombre_departamento?" +
                ", estatus_departamento = ?estatus_departamento?" +
                " WHERE codigo_departamento = ?codigo_departamento?;";
                var ValorDeVariables = new
                {
                    codigo_departamento = modelo.codigo_departamento,
                    nombre_departamento = modelo.nombre_departamento,
                    estatus_departamento = modelo.estatus_departamento
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public DTODepartamento EliminarDepartamento(DTODepartamento modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM departamento WHERE codigo_departamento = ?codigo_departamento?;";
                var ValorDeVariables = new
                {
                    codigo_puesto = modelo.codigo_departamento
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}