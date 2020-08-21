using ChickPro_Interfaces.control;
using ChickPro_Interfaces.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.dao
{
    class GalponeroDAO
    {
        private Conexion2 conexion = new Conexion2();
        private Galponero galpnero;
        int done = 0;
        int sexo = 0;
        Boolean sex = true;

        public GalponeroDAO(Conexion2 conexion)
        {
            this.conexion = conexion;
        }
        public int guardarGlponero(Galponero g)
        {

            try
            {

                done = conexion.consultaLsitaDB("EXEC SP_INSERTARGALPNERO '" + g.getCedula() + "', '" + g.getPriNombre() + "', '" + g.getPriApellido() + "', '" + g.getDireccion() + "', '" + g.getTelefono() + "', '" + g.getRendimientoGalponeor() + "', '" + g.getSexo() + "', '" + g.getFechaInicioLboral() + "', '" + g.getEstado() + "', '" + g.getCreacionidGalponasig() + "';");
                Console.WriteLine("" + done);
            }
            catch (Exception)
            {
            }
            return done;
        }


        public Galponero buscarGalponero(String cedula1)
        {
            conexion.getCon().Open();
            try
            {
                using (var comando = new SqlConnection(conexion.getConnection_string()))
                using (var cmd = comando.CreateCommand())
                {
                    comando.Open();
                    cmd.CommandText = "SELECT * FROM chickPro.galponero WHERE numCedula ='" + cedula1 + "'";
                    //cmd.Parameters.AddWithValue("@cedula1", cedula1);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            String cedula = reader["numCedula"].ToString();
                            String priNombre = reader["nombreGalp"].ToString();
                            String priApellido = reader["apellidoGalp"].ToString();
                            String direccion = reader["direccionGalp"].ToString();
                            String telefono = reader["telefonoGalp"].ToString();
                            String rendimientoGalponeor = reader["rendimientoGalp"].ToString();
                            char sexo = char.Parse(reader["sexo"].ToString());
                            String fechaInicioLboral = reader["fechaInicioLaboral"].ToString();
                            String estado = reader["estadoGalponero"].ToString();
                            String creacionidGalponasig = reader["creacionGalpon_codGalpon"].ToString();

                            int salario = int.Parse(reader["salario"].ToString());
                            int Usuario_idUsuario = int.Parse(reader["salario"].ToString());

                            galpnero = new Galponero(cedula, priNombre, priApellido, direccion, telefono, sexo, rendimientoGalponeor, fechaInicioLboral, estado, creacionidGalponasig);
                            //Console.WriteLine(""+galpnero.getCedula()+""+galpnero.getPriNombre());
                        }
                        comando.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de sintaxis" + ex);
            }
            return galpnero;
        }
    }
}
