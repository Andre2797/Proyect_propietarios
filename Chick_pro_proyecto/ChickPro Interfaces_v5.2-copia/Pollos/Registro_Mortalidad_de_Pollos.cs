using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using System.Data.SqlClient;
using ChickPro_Interfaces.Conexion;

namespace ChickPro_Interfaces
{
    public partial class Registro_Cantidad_de_Pollos : UserControl
    {
        
        CN_registroMortalidad mortalidad = new CN_registroMortalidad();
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        public Registro_Cantidad_de_Pollos()
        {
            InitializeComponent();
        }



        public Int32 ponerCodigo()
        {
            string sql = "select max(chickpro.enviopollos.idenvioPollos)+1 from chickpro.enviopollos";
            SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
            Int32 codEnvio1 = Convert.ToInt32(comando.ExecuteScalar());
            return codEnvio1;
        }

        public int RegistrarGalpon()
        {
            Int32 codEnvio1 = 0;
            if (galpon1.Checked)
            {
                string sql = "select max(codRegistroGalpon) from chickpro.registrogalpon where creacionGalpon_codGalpon='g01'";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                codEnvio1 = Convert.ToInt32(comando.ExecuteScalar());

            }
            else if (galpon2.Checked)
            {
                string sql = "select max(codRegistroGalpon) from chickpro.registrogalpon where creacionGalpon_codGalpon='g02'";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                codEnvio1 = Convert.ToInt32(comando.ExecuteScalar());


            }
            else if (galpon3.Checked)
            {
                string sql = "select max(codRegistroGalpon) from chickpro.registrogalpon where creacionGalpon_codGalpon='g03'";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                codEnvio1 = Convert.ToInt32(comando.ExecuteScalar());

            }
            return codEnvio1;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string idm = Convert.ToString(RegistrarGalpon());
            try
            {
                mortalidad.insertarmortalidad(dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox7.Text,textBox6.Text,Convert.ToString( RegistrarGalpon()));
                //if (galpon1.Checked)
                //{
                //    string cod="g01";
                //    mortalidad.insertarmortalidad(idm, dateTimePicker1.Value.ToString("yyyy-MM-dd"),cod , textBox6.Text, textBox7.Text);
                //}
                //else if (galpon2.Checked)
                //{
                //    string cod = "g02";
                //    mortalidad.insertarmortalidad(idm, dateTimePicker1.Value.ToString("yyyy-MM-dd"), cod, textBox6.Text, textBox7.Text);


                //}
                //else if (galpon3.Checked)
                //{
                //    string cod = "g03";
                //    mortalidad.insertarmortalidad(idm, dateTimePicker1.Value.ToString("yyyy-MM-dd"), cod, textBox6.Text, textBox7.Text);

                //}
              

                MessageBox.Show("Registro de Mortalidad Exitoso");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ingresar los datos por:" +idm);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Registro_Cantidad_de_Pollos_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta acción cerrará el sistema", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
