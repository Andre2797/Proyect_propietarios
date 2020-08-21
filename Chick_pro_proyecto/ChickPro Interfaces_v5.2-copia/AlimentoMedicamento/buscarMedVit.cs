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

namespace ChickPro_Interfaces
{
    public partial class buscarSaludPollos : UserControl
    {
        public buscarSaludPollos()
        {
            InitializeComponent();
            cargartabla();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        Conexion2 conexion = new Conexion2();

        public void cargartabla()
        {
            SqlCommand comando = new SqlCommand("EXEC SP_BuscarDatosVitamina", conexion.getCon());
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
            DialogResult res = MessageBox.Show("Esta acción cerrará el sistema", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Búsqueda exitosa");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            String galpon = textBox1.Text;
            string query = "SELECT * FROM chickpro.medicamentovit" +
                " WHERE creacionGalpon_codGalpon LIKE '" + galpon + "%'";
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
