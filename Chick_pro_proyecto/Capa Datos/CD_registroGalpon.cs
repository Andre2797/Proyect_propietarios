using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChickPro_Interfaces.Conexion;

namespace Capa_Datos
{
    public class CD_registroGalpon

    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tabla2 = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable mostrarRegistroGalpon()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarRegistroGalpon";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable mostrarHistoricoGalpon()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrarHistoricoGalpon";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla2.Load(leer);
            conexion.CerrarConexion();
            return tabla2;
        }

        public void InsertarRegistroGalpon(string cg,int edad, double peso,int ctm,int cth, string region,DateTime fecha
            )
        {
           // int id = id_max();
            int total = ctm + cth;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarRegistroGalpon";
            comando.CommandType = CommandType.StoredProcedure;
            // comando.Parameters.AddWithValue("@codRegistroGalpon", id);
            comando.Parameters.AddWithValue("@creacionGalpon_codGalpon", cg);
            comando.Parameters.AddWithValue("@edadPromedio", edad);
            comando.Parameters.AddWithValue("@pesoPromedio", peso);
            comando.Parameters.AddWithValue("@cantidadMachos", ctm);
            comando.Parameters.AddWithValue("@cantidadHembras", cth);
            comando.Parameters.AddWithValue("@region", region);
            comando.Parameters.AddWithValue("@fechaRegistro", fecha);
            comando.Parameters.AddWithValue("@totalPollos", total);
            

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            
        }

        //public int id_max()
        //{
        //    comando.Connection = conexion.AbrirConexion();

        //    return Int32.Parse(comando.CommandText = "Select max(codRegistroGalpon)+1 from chickpro.registrogalpon ");
        //}
        public void EditarRegistroGalpon(int edad, double peso, int ctm, int cth, string region, string cg,int id)
        {
            // int id = id_max();
            int total = ctm + cth;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editarRegistrarGalpon";
            comando.CommandType = CommandType.StoredProcedure;
            // comando.Parameters.AddWithValue("@codRegistroGalpon", id);
            comando.Parameters.AddWithValue("@edadPromedio", edad);
            comando.Parameters.AddWithValue("@pesoPromedio", peso);
            comando.Parameters.AddWithValue("@cantidadMachos", ctm);
            comando.Parameters.AddWithValue("@cantidadHembras", cth);
            comando.Parameters.AddWithValue("@region", region);
            //comando.Parameters.AddWithValue("@fechaRegistro", fecha);
            comando.Parameters.AddWithValue("@totalPollos", total);
            comando.Parameters.AddWithValue("@creacioGalpon_codGalpon", cg);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void InsertarHistoricoregistroGalpon(int edad, double peso,DateTime fecha, int crg  )
        {
           
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insertarHistoricoRegistroGalpon";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@edadModificada", edad);
            comando.Parameters.AddWithValue("@pesomod", peso);
            comando.Parameters.AddWithValue("@fechamod", fecha);
            comando.Parameters.AddWithValue("@registro_cod",crg);


            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }



    }
}
