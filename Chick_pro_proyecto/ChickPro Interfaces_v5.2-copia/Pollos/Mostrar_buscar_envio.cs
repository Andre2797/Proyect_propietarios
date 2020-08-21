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
    public partial class Mostrar_buscar_envio : UserControl
    {
        CN_Envio objetoCN = new CN_Envio();
        private CD_Conexion conexion = new CD_Conexion();
        string codEnvio = "";

        public Mostrar_buscar_envio()
        {
            InitializeComponent();
            panel1.Hide();
            textBox1.Hide();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BuscarLote_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void mostrarEnvio() {
            dataGridView1.DataSource = objetoCN.MostrarEnvio();
        }

        void buscar() {
            SqlDataAdapter da = new SqlDataAdapter("buscarFechaEnvioPollos",conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dateTimePicker1.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        void mostrarDetalleEnvio() {
            SqlDataAdapter da = new SqlDataAdapter("mostrardetalle1", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@codEnvio", SqlDbType.Int).Value = textBox1.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView2.DataSource = dt;
        }

        private void Mostrar_buscar_envio_Load(object sender, EventArgs e)
        {
            mostrarEnvio();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            mostrarDetalleEnvio();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["idenvioPollos"].Value.ToString();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.panel1.Hide();

        }
    }
}
