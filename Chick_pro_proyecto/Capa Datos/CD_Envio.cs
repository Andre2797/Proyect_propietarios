using ChickPro_Interfaces.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Envio
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarEnvio()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEnvioPollos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable mostrarDetalle() {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrardetalle1";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void insertarEnvio( DateTime fechaEnvio, string chofer, int cantJaulas)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarEnvioPollos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fechaEnvio", fechaEnvio);
            comando.Parameters.AddWithValue("@chofer", chofer);
            comando.Parameters.AddWithValue("@cantidadJaulas", cantJaulas);
            //comando.Parameters.AddWithValue("@totalPollos", total);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public int ponerCodigo()
        {
            comando.Connection = conexion.AbrirConexion();
            Int32 codEnvio = 0;
            codEnvio= Convert.ToInt32( comando.CommandText = "select max(chickpro.enviopollos.idenvioPollos) from chickpro.enviopollos");
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            return codEnvio;
        }

        public void insertarDetalle(int codGalpon, int cantHembras, int cantMachos, double pesoPromedio, int codEnvio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarDetalleEnvio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codGalpon", codGalpon);
            comando.Parameters.AddWithValue("@cantHembras", cantHembras);
            comando.Parameters.AddWithValue("@cantMachos", cantMachos);
            comando.Parameters.AddWithValue("@pesoPromedio", pesoPromedio);
            comando.Parameters.AddWithValue("@codEnvio", codEnvio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }



    }
}
