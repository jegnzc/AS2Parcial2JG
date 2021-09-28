using AS2Parcial2.Modelo.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2Parcial2.Modelo
{
    public class DAOPuesto
    {
        private ConexionODBC ConexionODBC = new ConexionODBC();

        public DTOPuesto AgregarPuesto(DTOPuesto modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
               "INSERT INTO puesto (codigo_puesto, nombre_puesto, estatus_puesto) " +
               "VALUES (?codigo_puesto?, ?nombre_puesto?, ?estatus_puesto?);";
                var ValorDeVariables = new
                {
                    codigo_puesto = modelo.codigo_puesto,
                    nombre_puesto = modelo.nombre_puesto,
                    estatus_puesto = modelo.estatus_puesto
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<DTOPuesto> mostrarPuesto()
        {
            List<DTOPuesto> sqlresultado = new List<DTOPuesto>();
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM puesto;";
                sqlresultado = conexionODBC.Query<DTOPuesto>(sqlconsulta).ToList();
                ConexionODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }

        public DTOPuesto ModificarPuesto(DTOPuesto modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "UPDATE puesto SET nombre_puesto = ?nombre_puesto?" +
                ", estatus_puesto = ?estatus_puesto?" +
                " WHERE codigo_puesto = ?codigo_puesto?;";
                var ValorDeVariables = new
                {
                    nombre_puesto = modelo.nombre_puesto,
                    estatus_puesto = modelo.estatus_puesto,
                    codigo_puesto = modelo.codigo_puesto
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public DTOPuesto EliminarPuesto(DTOPuesto modelo)
        {
            OdbcConnection conexionODBC = ConexionODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "DELETE FROM puesto WHERE codigo_puesto = ?codigo_puesto?;";
                var ValorDeVariables = new
                {
                    codigo_puesto = modelo.codigo_puesto
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ConexionODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }
    }
}