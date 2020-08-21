using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using ChickPro_Interfaces.control;
using System.Text.RegularExpressions;

namespace ChickPro_Interfaces
{
    
    public partial class asignar_login : UserControl
    { 
         //Conexion conexion = new Conexion();
        public asignar_login()
        {
            InitializeComponent();
            contrasenia.PasswordChar='*';
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        public static Boolean ValidarPass(string plainText)
        {
            //var input = "P@ssw0rd";
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMinimum8Chars = new Regex(@".{8,}");
            var isValidated = hasNumber.IsMatch(plainText) && hasUpperChar.IsMatch(plainText) && hasMinimum8Chars.IsMatch(plainText);
            //Console.WriteLine(isValidated);
            return isValidated;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            String numCedula=cedula.Text;
            String Usuario= usuario.Text;
            String Contrasenia=contrasenia.Text;
            String nombreUsuario=nombre.Text;
            String apellidoUsuario=apellido.Text;
            String direccionUsuario=direccion.Text;
            String telefonoUsuario=telefono.Text;
            String estado="ACTIVO";
            String cargo1=cargo.SelectedItem.ToString();


            //SqlConnection validar1 = new SqlConnection("Data Source=DESKTOP-OSAPH95\\PRUEBAS;Initial Catalog=Chick_Pro;Integrated Security=True");
            //try
            //{
            //    validar1.Open();
            //}
            //catch
            //{
            //    MessageBox.Show("No se pudo hacer Conexión", "ERROR");
            //}
            //String query1 = "Select usuario from chickpro.usuario where numCedula = '"+nombreUsuario+"'";
            ////String query = "EXEC SP_INSERTAR_ADMIN '" + numCedula + "','" + Usuario + "','" + Contrasenia + "','" + nombreUsuario + "','" + apellidoUsuario + "','" + direccionUsuario + "','" + telefonoUsuario + "','" + estado + "','" + cargo1 + "'";
            //SqlCommand comando = new SqlCommand(query1, validar1);
            //SqlDataReader leer;
            //leer = comando.ExecuteReader();
            //Boolean Existe = leer.HasRows;
            //validar1.Close();
            //if ()
            //{
            // MessageBox.Show("\tUsuario Existente\n\tUtilice otro nombre de ususario");
            //}
            if (ValidarPass(contrasenia.Text))
            {
                SqlConnection validar = new SqlConnection("Server=(local);Database=Chick_Pro;Integrated Security=true");
                try
                {
                    validar.Open();
                }
                catch
                {
                    MessageBox.Show("No se pudo hacer Conexión", "ERROR");
                }
                String query = "EXEC SP_INSERTAR_ADMIN '" + numCedula + "','" + Usuario + "','" + Contrasenia + "','" + nombreUsuario + "','" + apellidoUsuario + "','" + direccionUsuario + "','" + telefonoUsuario + "','" + estado + "','" + cargo1 + "'";
                SqlCommand comando1 = new SqlCommand(query, validar);
                SqlDataReader leer2;
                leer2 = comando1.ExecuteReader();
                Boolean Existe1 = leer2.HasRows;
                validar.Close();
                MessageBox.Show("Registro Exitoso");
                this.Hide();
                
                
            }
            else if(!ValidarPass(contrasenia.Text))
            {
                 MessageBox.Show("Contraseña incorrecta");
            }
            //else if (Existe == true && ValidarPass(contrasenia.Text))
            //{
            //    MessageBox.Show("\tUsuario Existente\n\tUtilice otro nombre de ususario");
            //}
        }
        private void Modo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta acción cerrará el sistema", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Asignar_login_Load(object sender, EventArgs e)
        {

        }

        private void Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Contrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Contrasenia_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }

}
