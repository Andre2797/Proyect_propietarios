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
    public partial class Actualizar_Galponero : UserControl
    {
        public Actualizar_Galponero()
        {
            InitializeComponent();
            cargartabla();
            button3.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        Conexion2 conexion = new Conexion2();

        public void cargartabla()
        {
            SqlCommand comando = new SqlCommand("EXEC SP_MOSTRAR_All_GALPONERO; ", conexion.getCon());
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        String primCampo;
        private void dgv_detalleEdit(Object sender, DataGridViewCellEventArgs e) {
            primCampo = dataGridView1.Rows[e.RowIndex].Cells["cedula"].Value.ToString();
            textBox1.Text = primCampo;

        }


        private void Actualizar_Galponero_Load(object sender, EventArgs e)
        {
            

              
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cargartabla();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            String cedula1 = textBox1.Text;
            String direccion = textBox4.Text;
            String telefono = textBox5.Text;
            String rendimiento = textBox6.Text;
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy - MM - dd";
            //String fecha = dateTimePicker1.Value.ToString();
            //EXEC SP_ACTUALIZAR_GALPONERO '"+cedula1+"','"+direccion+"','"+telefono+"','"+rendimiento+"','"+fecha+"'
            string query = "EXEC SP_ACTUALIZAR_GALPONERO '" + cedula1 + "','" + direccion + "','" + telefono + "','" + rendimiento + "%'";
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
                MessageBox.Show("Actualización exitosa");
               
            }
            else MessageBox.Show("Error al buscar");

            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //ingresoMódulos ingresoMódulos = new ingresoMódulos();
            //ingresoMódulos.Show();
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

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        String fecha;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["numCedula"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["nombreGalp"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["apellidoGalp"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["direccionGalp"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["telefonoGalp"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["rendimientoGalp"].Value.ToString();
            //fecha = dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["fechaInicioLaboral"].Value.ToString();
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy - MM - dd";
            //dateTimePicker1.Text = fecha;
            //String fechaInicioLboral = dateTimePicker1.Value.ToString();
            button3.Enabled = true; 
        }

        private void TextBox7_MouseDown(object sender, MouseEventArgs e)
        {
            dataGridView1.Enabled=true;
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
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
