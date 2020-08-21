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
//using ChickPro_Interfaces.modelo;

namespace ChickPro_Interfaces
{
    public partial class Buscar_Galponero : UserControl
    {

        Conexion2 conexion = new Conexion2();
        ControlGalponero control = new ControlGalponero();
        public Buscar_Galponero()
        {
            InitializeComponent();
            cargartabla();
        }

        public void cargartabla()
        {
            SqlCommand comando = new SqlCommand("EXEC SP_MOSTRAR_All_GALPONERO;", conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }



        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cargartabla();
            textBox1.Text="";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta acción cerrará el sistema", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Buscar_Galponero_Load(object sender, EventArgs e)
        {
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (ACTIVOS.Checked == true) {
                String a = textBox1.Text;
                //select * from chickpro.galponero where  numCedula like '1710%' and  estadoGalponero='ACTIVO';
                string query = "select * from chickpro.galponero where  numCedula like '"+a+"%' and  estadoGalponero='ACTIVO';";
                conexion.consultaLsitaDB(query);
                SqlCommand comando = new SqlCommand(query, conexion.getCon());
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            } else if (INACTIVOS.Checked == true) {
                String a = textBox1.Text;
                //select * from chickpro.galponero where  numCedula like '1710%' and  estadoGalponero='INACTIVO';
                string query = "select * from chickpro.galponero where  numCedula like '" + a + "%' and  estadoGalponero='INACTIVO';";
                conexion.consultaLsitaDB(query);
                SqlCommand comando = new SqlCommand(query, conexion.getCon());
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            } else {
                String a = textBox1.Text;
                string query = "EXEC SP_MOSTRAR_GALPONERO_POR_FILTRO '" + a + "'";
                conexion.consultaLsitaDB(query);
                SqlCommand comando = new SqlCommand(query, conexion.getCon());
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
        }

        private void INACTIVOS_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select* from chickpro.galponero where estadoGalponero = 'INACTIVO';", conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void INACTIVOS_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select* from chickpro.galponero where estadoGalponero = 'ACTIVO';", conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void ACTIVOS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
