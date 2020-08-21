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
//using ChickPro_Interfaces.control;

namespace ChickPro_Interfaces
{
    public partial class DarDeAlataGalponero : UserControl
    {
        Conexion2 conexion = new Conexion2();
        public DarDeAlataGalponero()
        {
            InitializeComponent();
            cargartabla();
            button3.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void cargartabla()
        {
            SqlCommand comando = new SqlCommand("EXEC SP_MOSTRAR_All_GALPONERO;", conexion.getCon());
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

        private void Button4_Click(object sender, EventArgs e)
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
            cargartabla();
            textBox7.Text = "";
        }
        static String primNombre;
        static String primApellido;
        private void Button3_Click(object sender, EventArgs e)
        {
            using (var comando1 = new SqlConnection(conexion.getConnection_string()))
            using (var cmd = comando1.CreateCommand())
            {
                comando1.Open();
                cmd.CommandText = "EXEC SP_MOSTRAR_GALPONERO_POR_FILTRO '" + cedula1 + "'";
                //cmd.Parameters.AddWithValue("@cedula1", cedula1);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String cedula = reader["numCedula"].ToString();
                        primNombre = reader["nombreGalp"].ToString();
                        primApellido = reader["apellidoGalp"].ToString();
                    }
                }
            }
            String sms = "SEGURO DESEA DAR DE BAJA A " + primNombre + " " + primApellido + "";

            const string caption = "Form Closing";
            var result = MessageBox.Show(sms, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "EXEC SP_ELIMINAR_GALPONERO '" + cedula1 + "'";
                int done = conexion.consultaLsitaDB(query);
                SqlCommand comando = new SqlCommand(query, conexion.getCon());
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
                if (done == 1)
                {
                    cargartabla();
                    MessageBox.Show("Dado de baja  exitoso");
                }
                else MessageBox.Show("Dado de baja  fallido");
                this.Hide();
            }
            else { }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            String a = textBox7.Text;
            string query = "EXEC SP_MOSTRAR_GALPONERO_POR_FILTRO '" + a + "'";
            conexion.consultaLsitaDB(query);
            SqlCommand comando = new SqlCommand(query, conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
        public static String cedula1;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cedula1 = dataGridView1.Rows[e.RowIndex].Cells["numCedula"].Value.ToString();
            //button3.Enabled = true;
        }
        private void TextBox7_MouseDown(object sender, MouseEventArgs e)
        {
            dataGridView1.Enabled = true;
        }

        private void TextBox7_TextChanged_1(object sender, EventArgs e)
        {
            String a = textBox7.Text;
            string query = "EXEC SP_MOSTRAR_GALPONERO_POR_FILTRO '" + a + "'";
            conexion.consultaLsitaDB(query);
            SqlCommand comando = new SqlCommand(query, conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
       
        private void DataGridView1_Click(object sender, EventArgs e)
        {
           
        }

        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cedula1 = dataGridView1.Rows[e.RowIndex].Cells["numCedula"].Value.ToString();
            button3.Enabled = true;
        }

        private void TextBox7_MouseDown_1(object sender, MouseEventArgs e)
        {
            dataGridView1.Enabled = true;
        }
    }
    }


