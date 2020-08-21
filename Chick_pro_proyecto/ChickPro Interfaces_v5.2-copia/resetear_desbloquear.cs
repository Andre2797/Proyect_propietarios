using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ChickPro_Interfaces.control;
using System.Data.SqlClient;
using ChickPro_Interfaces.control;

namespace ChickPro_Interfaces
{
    public partial class resetear_desbloquear : UserControl
    {
      //Conexion conexion = new Conexion();
        Conexion2 conexion = new Conexion2();
        public resetear_desbloquear()
        {
            InitializeComponent();
            cargartabla();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            dataGridView1.Enabled= false;
            desbloquear.Enabled = false;
            estad.Enabled = false;
            contraseñ.Enabled = false;
            usuari.Enabled = false;
            nombre.Enabled = false;
            telefono.Enabled = false;
            direccio.Enabled = false;
            resetear.Enabled= false;
            desbloquear.Enabled= false;
        }


        public void cargartabla()
        {
            SqlCommand comando = new SqlCommand("EXEC SP_MOSTRAR_All_USUARIOS;", conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
           String uss = usuari.Text;
           String con = contraseñ.Text;
           String cedu = cedul.Text;
            SqlConnection validar1 = new SqlConnection("Server=(local);Database=Chick_Pro;Integrated Security=true");
            try
            {
                validar1.Open();
            }
            catch
            {
                MessageBox.Show("No se pudo hacer Conexión", "ERROR");
            }
            String query1 = "UPDATE chickpro.usuario set usuario = '"+uss+"', contrasenia='"+con+"' where numCedula = '" + cedu + "';";
            //UPDATE chickpro.usuario set estado = 'ACTIVO' where numCedula = '1710121167';
            SqlCommand comando = new SqlCommand(query1, validar1);
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            Boolean Existe = leer.HasRows;
            MessageBox.Show("Usuario reseteado");
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            String cedu = cedul.Text;
            SqlConnection validar1 = new SqlConnection("Server=(local);Database=Chick_Pro;Integrated Security=true");
            try
            {
                validar1.Open();
            }
            catch
            {
                MessageBox.Show("No se pudo hacer Conexión", "ERROR");
            }
            String query1 = "UPDATE chickpro.usuario set estado = 'ACTIVO' where numCedula = '"+cedu+"';";
            //UPDATE chickpro.usuario set estado = 'ACTIVO' where numCedula = '1710121167';
            SqlCommand comando = new SqlCommand(query1, validar1);
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            Boolean Existe = leer.HasRows;
            //validar1.Close();
            MessageBox.Show("Usuario desbloqueado");
            this.Hide();
        }

        private void Resetear_desbloquear_Load(object sender, EventArgs e)
        {    
         

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // panel1.Enabled = true;

                desbloquear.Enabled = true;
                estad.Enabled = false;
                contraseñ.Enabled = true;
                usuari.Enabled = true;
                nombre.Enabled = false;
                telefono.Enabled = false;
                direccio.Enabled = false;
                resetear.Enabled = true;
                usuari.Text = "temporal";
                contraseñ.Text = "temporal";
                MessageBox.Show("contraseña y usuario asignados\nprecione resetear para asignar las credenciales\n o asigne credencialespreopias si ya uso estas");
            }
            else
            {
               // panel1.Enabled = false;
              //resetear.Enabled = false;
            }
        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
               // panel1.Enabled = true;
                desbloquear.Enabled = true;
                estad.Enabled = true;
                contraseñ.Enabled = false;
                usuari.Enabled = false;
                nombre.Enabled = false;
                telefono.Enabled = false;
                direccio.Enabled = false;
          

                MessageBox.Show("\tEl usuario esta activado ahora\n\tprecione DESBLOQUER para guardar su nuevo estado");
                estad.Text = "ACTIVO";
                desbloquear.Enabled = true;
            }
            else
            {
                //panel1.Enabled = false;
                //button4.Enabled =false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // [numCedula],[usuario],[contrasenia],[nombreUsuario],[apellidoUsuario],[direccionUsuario],[telefonoUsuario],[estado],[cargo]
            cedul.Text = dataGridView1.Rows[e.RowIndex].Cells["numCedula"].Value.ToString();
            usuari.Text = dataGridView1.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            contraseñ.Text = dataGridView1.Rows[e.RowIndex].Cells["contrasenia"].Value.ToString();
            nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombreUsuario"].Value.ToString();
            apellido.Text = dataGridView1.Rows[e.RowIndex].Cells["apellidoUsuario"].Value.ToString();
            direccio.Text = dataGridView1.Rows[e.RowIndex].Cells["direccionUsuario"].Value.ToString();
            telefono.Text = dataGridView1.Rows[e.RowIndex].Cells["telefonoUsuario"].Value.ToString();
            estad.Text = dataGridView1.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            cargo.Text = dataGridView1.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            string query = "EXEC [SP_MOSTRAR_USUARIO_POR_FILTRO]'" + a + "'";
            conexion.consultaLsitaDB(query);
            SqlCommand comando = new SqlCommand(query, conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            dataGridView1.Enabled= true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
      }
    }

