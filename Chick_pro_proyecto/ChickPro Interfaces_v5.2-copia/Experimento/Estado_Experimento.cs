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
    public partial class Estado_Experimento : UserControl
    {
        public Estado_Experimento()
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
            MessageBox.Show("Modificación Exitosa");
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Busqueda Exitosa");
        }

        private void Estado_Experimento_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            String a = textBox7.Text.ToString();
            string query = "select* from [Chick_Pro].[chickpro].[experimento] where estado = 'Activo' AND codExperimento LIKE'" + a + "'+'%'";
            conexion.consultaLsitaDB(query);
            SqlCommand comando = new SqlCommand(query, conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de dar de baja a este experimento?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String a = textBox7.Text.ToString();
                string query = "update [Chick_Pro].[chickpro].[experimento] set estado = 'Desactivo' AND codExperimento LIKE'" + a + "'+'%'";
                int done = conexion.consultaLsitaDB(query);
                SqlCommand comando = new SqlCommand(query, conexion.getCon());
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

                if (done == 1)
                {
                    MessageBox.Show("Dada de baja con éxito");
                    this.Hide();

                }
                else MessageBox.Show("Error al dar de baja");
            }

        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea abandonar el sistema?", "Cerrar",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                //e.Cancel = true;
                Application.Exit();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de dar de alta a este experimento?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String a = textBox7.Text.ToString();
                string query = "update [Chick_Pro].[chickpro].[experimento] set estado = 'Activo' AND codExperimento LIKE'" + a + "'+'%'";
                int done = conexion.consultaLsitaDB(query);
                SqlCommand comando = new SqlCommand(query, conexion.getCon());
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;

                if (done == 1)
                {
                    MessageBox.Show("Dada de alta con éxito");
                    this.Hide();

                }
                else MessageBox.Show("Error al dar de alta");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            String a = textBox7.Text.ToString();
            string query = "select* from [Chick_Pro].[chickpro].[experimento] where estado = 'Activo' AND codExperimento LIKE'" + a + "'+'%'";
            conexion.consultaLsitaDB(query);
            SqlCommand comando = new SqlCommand(query, conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }
}
