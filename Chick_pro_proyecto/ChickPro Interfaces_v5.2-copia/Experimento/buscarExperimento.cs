using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChickPro_Interfaces.control;
using System.Data.SqlClient;

namespace ChickPro_Interfaces
{
    public partial class buscarExperimento : UserControl
    {
        public buscarExperimento()
        {
            InitializeComponent();
            cargartabla();
        }
        Conexion2 conexion = new Conexion2();
        public void cargartabla()
        {

            SqlCommand comando = new SqlCommand("select * from [Chick_Pro].[chickpro].[experimento] where estado = 'Activo'", conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text.ToString();
            string query = "select* from [Chick_Pro].[chickpro].[experimento] where estado = 'Activo' AND codExperimento LIKE'" + a + "'+'%'";
            conexion.consultaLsitaDB(query);
            SqlCommand comando = new SqlCommand(query, conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            String a = textBox1.Text.ToString();
            string query = "select* from [Chick_Pro].[chickpro].[experimento] where estado = 'Activo' AND codExperimento LIKE'" + a + "'+'%'";
            conexion.consultaLsitaDB(query);
            SqlCommand comando = new SqlCommand(query, conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
