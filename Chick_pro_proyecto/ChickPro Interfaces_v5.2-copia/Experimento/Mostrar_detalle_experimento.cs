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

namespace ChickPro_Interfaces
{
    public partial class Mostrar_detalle_experimento : UserControl
    {
        public Mostrar_detalle_experimento()
        {
            InitializeComponent();
            cargartabla();
            String alimento = "Aviforte";
            textBox1.Text = alimento;
        }


        public void cargartabla()
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
            string query = "select * from chickpro.detalleExperimento2";
            SqlCommand comando = new SqlCommand(query, validar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            SqlDataReader leer;
            leer = comando.ExecuteReader();

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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BuscarLote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Búsqueda exitosa");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
