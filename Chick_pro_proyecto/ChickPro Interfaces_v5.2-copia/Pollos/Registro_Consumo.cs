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
    public partial class Reparticion_Porciones_Adecuadas : UserControl
    {
        public Reparticion_Porciones_Adecuadas()
        {
            InitializeComponent();
            cargarTabla();
        }

        Conexion2 conexion = new Conexion2();
        int identificador = 0;
        String galpon;
        int cantidadDestinada = 0;
        int almacenar = 0;

        public void cargarTabla()
        {
            SqlCommand comando = new SqlCommand("EXEC SP_ConsultaDisponibles1", conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void Button1_Click(object sender, EventArgs e)
        { 


            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy - MM - dd";
            String fecha = dateTimePicker1.Value.ToString();
            int consumo = int.Parse(textBox2.Text.ToString());
            int SaldoFinal = calculos(consumo);
          //consulta co el resto del star
            int NuevoSaldoFinal=  int.Parse(textBox4.Text.ToString());

            SqlConnection validar = new SqlConnection("Server=(local);Database=Chick_Pro;Integrated Security=true");
            try
            {
                validar.Open();
            }
            catch
            {
                MessageBox.Show("No se pudo hacer Conexión", "ERROR");
            }
            string query = "EXEC SP_RegistroDeConsumo1 '" + fecha + "'," + NuevoSaldoFinal + "," + consumo + "," + identificador + "";
            SqlCommand comando = new SqlCommand(query, validar);
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            MessageBox.Show("Registro exitoso");
            cargarTabla();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //ingresoMódulos ingresoMódulos = new ingresoMódulos();
            //ingresoMódulos.Show();
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

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            identificador = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            galpon = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cantidadDestinada = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            textBox3.Text = galpon;
            textBox1.Text = cantidadDestinada.ToString();
        }

        //public int consultarDatos(int indentificacionAlimento)
        //{
        //    String query = "EXEC SP_ActualizarTablaAlimento '" + codigoBarras + "', " + nuevaCantidad + "";
        //    int done = conexion.consultaLsitaDB(query);
        //}

        public int calculos(int sacosConsumidos)
        {
            int retorno = 0;
            almacenar = cantidadDestinada - sacosConsumidos;
            retorno = almacenar;
            textBox4.Text = retorno.ToString();
            return retorno;
        }

        private void Reparticion_Porciones_Adecuadas_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
