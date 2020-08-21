using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChickPro_Interfaces.control
{
    public class Conexion2

    {
        public Conexion2()
        {
        }
        SqlConnection con = new SqlConnection("Server=(local);Database=Chick_Pro;Integrated Security=true");
        private string connection_string = "Server=(local);Database=Chick_Pro;Integrated Security=true";
        private SqlConnection connection;
        private SqlCommand command_query;

        public String getConnection_string()
        {
            return connection_string;
        }
        public SqlConnection getCon()
        {
            return con;
        }
        public int consultaLsitaDB(string query_string_param)
        {
            connection = new SqlConnection(connection_string);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command_query = new SqlCommand(query_string_param, connection);
                command_query.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("1");
                return 1;
            }
            else
            {
                Console.WriteLine("0 EN LA CONSULTA DE CONEXION");
                return 0;
            }
        }


        public Boolean consultaLsitaExiste(string query_string_param1)
        {
            connection = new SqlConnection(connection_string);
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                command_query = new SqlCommand(query_string_param1, connection);
                command_query.ExecuteNonQuery();
                // connection.Close();
                Console.WriteLine("1");

                SqlDataReader leer;
                leer = command_query.ExecuteReader();
                Boolean Existe = leer.HasRows;


                return Existe;
            }
            else
            {
                Console.WriteLine("0 EN LA CONSULTA DE CONEXION");
                return false;
            }



        }

        internal void Open()
        {
            throw new NotImplementedException();
        }


        //private string query_string = "";
        //  private string[][] result_matriz;
        // private SqlDataReader readerSet;
        //private MD5 md5_convertor = System.Security.Cryptography.MD5.Create();
        //byte[] inputBytes, hash;
        //private StringBuilder builder_string;
        //private string md5_string(string pass)
        //{
        //    inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
        //    hash = md5_convertor.ComputeHash(inputBytes);
        //    builder_string = new StringBuilder();
        //    for (byte i = 0; i < hash.Length; i++)
        //    {
        //        builder_string.Append(hash[i].ToString("X2"));
        //    }
        //    return builder_string.ToString();
        //}
        //public Usuario validarLoggin(string user, string pass)
        //{
        //    Usuario user_object;
        //    connection = new SqlConnection(connection_string);
        //    connection.Open();
        //    if (connection.State == System.Data.ConnectionState.Open)
        //    {
        //        query_string = "select idUsuario,nombreUsuario,loggin,pass from usuario where bloqueado = 1;";
        //        command_query = new SqlCommand(query_string, connection);
        //        readerSet = command_query.ExecuteReader();
        //        while (readerSet.Read())
        //        {
        //            if (user.ToString() == Convert.ToString(readerSet["loggin"]) && md5_string(pass.ToString()) == Convert.ToString(readerSet["pass"]))
        //            {
        //                user_object = new Usuario(Convert.ToInt32(readerSet["idUsuario"]), Convert.ToString(readerSet["loggin"]), Convert.ToString(readerSet["nombreUsuario"]), Convert.ToString(readerSet["loggin"]));
        //                return user_object;
        //            }
        //        }
        //        connection.Close();
        //        return null;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Error en la conexión de base de datos");
        //        return null;
        //    }
        //}

    }
}
