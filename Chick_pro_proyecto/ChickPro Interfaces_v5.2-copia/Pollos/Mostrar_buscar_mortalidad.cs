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
using ChickPro_Interfaces.Conexion;
using System.Data.SqlClient;

namespace ChickPro_Interfaces
{
    public partial class Mostrar_buscar_mortalidad : UserControl
    {
        CN_registroMortalidad mortalidadGalpon = new CN_registroMortalidad();
        CD_Conexion conexion = new CD_Conexion();
        public Mostrar_buscar_mortalidad()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea abandonar el sistema?", "Cerrar",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                //e.Cancel = true;
                Application.Exit();
            }
        }
        public void mostrarMortalidadGalpon()
        {
            dataGridView1.DataSource = mortalidadGalpon.mostrarMortalisdadGalpon();

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BuscarLote_Click(object sender, EventArgs e)
        {
            buscar();
            MessageBox.Show("Búsqueda exitosa");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Mostrar_buscar_mortalidad_Load(object sender, EventArgs e)
        {
            mostrarMortalidadGalpon();
        }
        void buscar()
        {
            SqlDataAdapter da = new SqlDataAdapter("buscarFechaMortalidad", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dateTimePicker1.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
