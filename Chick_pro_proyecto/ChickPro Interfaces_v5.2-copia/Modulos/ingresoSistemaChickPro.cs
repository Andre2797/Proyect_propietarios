using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickPro_Interfaces
{
    public partial class ingresoSistemaChickPro : Form
    {
        int contador = 0;
        public ingresoSistemaChickPro()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void IngresoSistema_Load(object sender, EventArgs e)
        {

        }

        public  String []  camposAcounting() {
            SqlConnection validar = new SqlConnection("Server=(local);Database=Chick_Pro;Integrated Security=true");
            try
            {
                validar.Open();
            }
            catch
            {
                MessageBox.Show("No se pudo hacer Conexión", "ERROR");
            }
            string query = "Select * from chickpro.usuario where usuario='" + textBoxUsuario.Text + "'";
            SqlCommand comando = new SqlCommand(query, validar);
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            String[] a = new string[5];
            if (leer.Read())
            {
                a[4] = leer["numCedula"].ToString();
                a[0]= leer["usuario"].ToString();
                a[1] = leer["contrasenia"].ToString();
                a[3] = leer["estado"].ToString();
                a[2] = leer["cargo"].ToString();
            }
            return a;
        }

        private void IngresoChickPro_Click(object sender, EventArgs e)
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
            string query = "Select * from chickpro.usuario where usuario='" + textBoxUsuario.Text +"'";
            SqlCommand comando = new SqlCommand(query, validar);
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            //Boolean Existe = leer.HasRows;
            validar.Close();
            String cargo = modo.SelectedItem.ToString();
            String[] a = new string[5];
            for (int i=0;i<5;i++) {
                a[i] = camposAcounting()[i];
                Console.WriteLine(""+a[i]);//borrar
            }
            //
            Console.WriteLine(""+ textBoxUsuario.Text);
            Console.WriteLine(""+ textBoxContraseña.Text);
            Console.WriteLine(""+ cargo);
            Console.WriteLine(""+ a[3]);
            if      (textBoxUsuario.Text.Equals(a[0]) && textBoxContraseña.Text.Equals(a[1]) && cargo == "Administrador del Sistema" && a[3]=="ACTIVO")
                {
                    Admin_Sistema sis = new Admin_Sistema();
                    sis.Show();
                    this.Hide();
                }
            else if (textBoxUsuario.Text.Equals(a[0]) && textBoxContraseña.Text.Equals(a[1]) && cargo == "Administrador de Galpón" && a[3]=="ACTIVO")
                {
                    ingresoMódulos ingresar = new ingresoMódulos();
                    ingresar.Show();
                    this.Hide();
                }
            else if (textBoxUsuario.Text.Equals(a[0]) && textBoxContraseña.Text.Equals(a[1]) && cargo == "Gerente" && a[3] == "ACTIVO")
                {
                ingresomodulo2 ingresar = new ingresomodulo2();
                ingresar.Show();
                this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                    contador+=1;
                    if (contador == 3)
                {
                    SqlConnection actualizar = new SqlConnection("Server=(local);Database=Chick_Pro;Integrated Security=true");
                    try
                    {
                        actualizar.Open();
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo hacer Conexión", "ERROR");
                    }
                    //estado del usuario-
                    string query2 = "UPDATE chickpro.usuario set estado = 'INACTIVO' where numCedula='" + a[4] + "';";
                    SqlCommand comando2 = new SqlCommand(query2, actualizar);
                    comando2.ExecuteNonQuery();
                    //comando2.Parameters.AddWithValue("@estado", "false");
                    //comando2.Parameters.AddWithValue("@name", textBoxUsuario.Text);
                    //comando2.ExecuteNonQuery();
                    MessageBox.Show("Usuario bloqueado");
                    actualizar.Close();
                    }
                }
        }

        private void SalirChickPro_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta acción cerrará el sistema", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void TextBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            textBoxContraseña.PasswordChar = '*';
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IngresoSistemaChickPro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta acción cerrará el sistema", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.ExitThread();
            }

        }

        private void TextBoxContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
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
                string query = "Select * from chickpro.usuario where usuario='" + textBoxUsuario.Text + "'";
                SqlCommand comando = new SqlCommand(query, validar);
                SqlDataReader leer;
                leer = comando.ExecuteReader();
                //Boolean Existe = leer.HasRows;
                validar.Close();
                String cargo = modo.SelectedItem.ToString();
                String[] a = new string[5];
                for (int i = 0; i < 5; i++)
                {
                    a[i] = camposAcounting()[i];
                    Console.WriteLine("" + a[i]);//borrar
                }
                //
                Console.WriteLine("" + textBoxUsuario.Text);
                Console.WriteLine("" + textBoxContraseña.Text);
                Console.WriteLine("" + cargo);
                Console.WriteLine("" + a[3]);
                if (textBoxUsuario.Text.Equals(a[0]) && textBoxContraseña.Text.Equals(a[1]) && cargo == "Administrador del Sistema" && a[3] == "ACTIVO")
                {
                    Admin_Sistema sis = new Admin_Sistema();
                    sis.Show();
                    this.Hide();
                }
                else if (textBoxUsuario.Text.Equals(a[0]) && textBoxContraseña.Text.Equals(a[1]) && cargo == "Administrador de Galpón" && a[3] == "ACTIVO")
                {
                    ingresoMódulos ingresar = new ingresoMódulos();
                    ingresar.Show();
                    this.Hide();
                }
                else if (textBoxUsuario.Text.Equals(a[0]) && textBoxContraseña.Text.Equals(a[1]) && cargo == "Gerente" && a[3] == "ACTIVO")
                {
                    ingresomodulo2 ingresar = new ingresomodulo2();
                    ingresar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectos");
                    contador += 1;
                    if (contador == 3)
                    {
                        SqlConnection actualizar = new SqlConnection("Server=(local);Database=Chick_Pro;Integrated Security=true");
                        try
                        {
                            actualizar.Open();
                        }
                        catch
                        {
                            MessageBox.Show("No se pudo hacer Conexión", "ERROR");
                        }
                        //estado del usuario-
                        string query2 = "UPDATE chickpro.usuario set estado = 'INACTIVO' where numCedula='" + a[4] + "';";
                        SqlCommand comando2 = new SqlCommand(query2, actualizar);
                        comando2.ExecuteNonQuery();
                        //comando2.Parameters.AddWithValue("@estado", "false");
                        //comando2.Parameters.AddWithValue("@name", textBoxUsuario.Text);
                        //comando2.ExecuteNonQuery();
                        MessageBox.Show("Usuario bloqueado");
                        actualizar.Close();
                    }
                }



            };
        }
    }
}
