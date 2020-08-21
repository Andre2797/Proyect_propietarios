using ChickPro_Interfaces.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_registroMortalidadcs
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable mostrarRegistroMortalidad()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarRegistroMortalidad";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarMortalidad(DateTime fechaR,int cthm,int ctmm,int cod_registro
      )
        {
            // int id = id_max();
           // int total = ctmm + cthm;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "registrarMortalidad";
            comando.CommandType = CommandType.StoredProcedure;
            // comando.Parameters.AddWithValue("@codRegistroGalpon", id);

            comando.Parameters.AddWithValue("@fechaRegistroMortalidad",fechaR);
       
            comando.Parameters.AddWithValue("@cantHembrasMuertas", cthm);
            comando.Parameters.AddWithValue("@cantMachosMuertos ", ctmm);
            comando.Parameters.AddWithValue("@codRegistro", cod_registro);

            //comando.Parameters.AddWithValue("@registroGalpon_codRegistroGalpon ", idm);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}
