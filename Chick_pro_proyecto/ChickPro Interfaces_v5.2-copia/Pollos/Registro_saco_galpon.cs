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
    public partial class Registro_saco_galpon : UserControl
    {
        public Registro_saco_galpon()
        {
            InitializeComponent();
            cargartabla();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        Conexion2 conexion = new Conexion2();
        String marca;
        String codigoBarras;
        int cantidadSacosOriginal = 0;
        int nuevaCantidad = 0;

        public void cargartabla()
        {
            SqlCommand comando = new SqlCommand("EXEC SP_BuscarDatosAlimento", conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            String codigo_Galpon = textBox3.Text.ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy - MM - dd";
            String fecha = dateTimePicker1.Value.ToString();
            int sacosDestinados = int.Parse(textBox1.Text.ToString());
            int control = calculos(sacosDestinados);
            if (control == 1)
            {
                String query = "EXEC SP_RegistroAsignacionSacos '" + fecha + "'," + sacosDestinados + ",'" + codigoBarras + "','" + codigo_Galpon + "'";
                int done = conexion.consultaLsitaDB(query);

                //if (done == 1)
                //{
                //    MessageBox.Show("Actualización exitosa");
                //}
                //else MessageBox.Show("Error al buscar");
            }

            else this.Hide();


            MessageBox.Show("Registro Exitoso");
            this.Hide();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            marca = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            codigoBarras = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cantidadSacosOriginal = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            textBox2.Text = marca;
        }

        public int calculos(int sacosDest)
        {
            int retorno = 0;
            nuevaCantidad = cantidadSacosOriginal - sacosDest;
            String query = "EXEC SP_ActualizarTablaAlimento '" + codigoBarras + "', " + nuevaCantidad + "";
            int done = conexion.consultaLsitaDB(query);
            
            if (done == 1)
            {
                retorno = 1;
                return retorno;
            }
            else
            {
                return retorno;
            }

        }

    }
}
