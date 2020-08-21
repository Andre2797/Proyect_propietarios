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
    public partial class Modificar_Experimento : UserControl
    {
        public Modificar_Experimento()
        {
            InitializeComponent();
            cargartabla();
            button2.Enabled = false;

            codigoExperimento.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            galponAsignado.Enabled = false;
            productosExperimento1.Enabled = false;

            productoExperimental2.Enabled = false;

            productosExperimento3.Enabled = false;





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
            string query = "select * from chickpro.detalleExperimento1";
            SqlCommand comando = new SqlCommand(query, validar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            SqlDataReader leer;
            leer = comando.ExecuteReader();

        }

        int primCampo;
        private void dgv_detalleEdit(Object sender, DataGridViewCellEventArgs e)
        {
            primCampo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["codExperimento"].Value.ToString());
            codigoExperimento.Text = primCampo.ToString();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           // Conexion2 conexion = new Conexion2();
           // int codigoExperimento = int.Parse(this.codigoExperimento.Text.ToString());
           // fechaSelecion.Format = DateTimePickerFormat.Custom;
           // fechaSelecion.CustomFormat = "yyyy - MM - dd";
           // String fechaRegistro = fechaSelecion.Value.ToString();

           // String tipo = "";
           // if (radioButton1.Checked == true)
           // {
           //     tipo = "Enzimas";

           // }
           // else if (radioButton2.Checked == true)
           // {
           //     tipo = "Alimento";
           // }
           //// String productoExperimental1 = BoxMachos.Text.ToString();
           // //String productoExperimental2 = BoxProducto2.Text.ToString();
           //// String productoExperimental3 = BoxProducto3.Text.ToString();
           // //String experimento = productoExperimental1 + "," + productoExperimental2 + "," + productoExperimental3;
           // int cantidadMachos = int.Parse(this.codigoExperimento.Text.ToString());
           // //int cantidadHembras = int.Parse(BoxHembras.Text.ToString());
           // //float pesoInicial = float.Parse(BoxPeso.Text.ToString());
           // //String estado = "Activo";
           // String galpón = galponAsignado.Text.ToString();

           //// string query = "update [Chick_Pro].[chickpro].[experimento] set cantMachos = "+cantidadMachos+"," +
           // //    "cantHembras = "+cantidadHembras+"";
           // //int done = conexion.consultaLsitaDB(query);
           // //String quey1 = "insert into [Chick_Pro].[chickpro].[actualizacionexperimento] values ('" + fechaRegistro + "'," +
           //  //   " " + cantidadMachos + ", " + cantidadHembras + ", " + pesoInicial + "," + galpón + ")";
           //// int done1 = conexion.consultaLsitaDB(query);
           //// SqlCommand comando = new SqlCommand(query, conexion.getCon());
           //// SqlDataAdapter adaptador = new SqlDataAdapter();
           //// adaptador.SelectCommand = comando;
           // DataTable tabla = new DataTable();
           // //adaptador.Fill(tabla);
           // dataGridView1.DataSource = tabla;

           ///// if (done == 1 && done1 == 1)
           // //{
           //     MessageBox.Show("Actualización exitosa");
           //     this.Hide();
           //     //Perro perro = new Perro();
           //     //perro.Show();

           // //}
           //// else MessageBox.Show("Error de actualización");



            MessageBox.Show("Actualización  Exitosa");
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //ingresoMódulos ingresoMódulos = new ingresoMódulos();
            //ingresoMódulos.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea abandonar el sistema?", "Cerrar",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                //e.Cancel = true;
                Application.Exit();
            }
        }

        private void Modificar_Experimento_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //String a = codigoExperimento.Text.ToString();
            //string query = "select* from [Chick_Pro].[chickpro].[experimento] where estado = 'Activo' AND codExperimento LIKE'" + a + "'+'%'";
            //conexion.consultaLsitaDB(query);
            //SqlCommand comando = new SqlCommand(query, conexion.getCon());
            //SqlDataAdapter adaptador = new SqlDataAdapter();
            //adaptador.SelectCommand = comando;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dataGridView1.DataSource = tabla;
        }

        private void Label7_Click(object sender, EventArgs e)
        {
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //String a = codigoExperimento.Text.ToString();
            //string query = "select* from [Chick_Pro].[chickpro].[experimento] where estado = 'Activo' AND codExperimento LIKE'" + a + "'+'%'";
            //conexion.consultaLsitaDB(query);
            //SqlCommand comando = new SqlCommand(query, conexion.getCon());
            //SqlDataAdapter adaptador = new SqlDataAdapter();
            ///adaptador.SelectCommand = comando;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dataGridView1.DataSource = tabla;
        }

        //private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        fechaSelecion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //        String tipoSeleccion = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //        if (tipoSeleccion == "Enzimas")
        //        {
        //            radioButton1.Checked.ToString();
        //        }
        //        else
        //        {
        //            radioButton2.Checked.ToString();
        //        }
        //     //   BoxProducto1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //     //   BoxProducto2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        //     //   BoxProducto3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        //     //   BoxMachos.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        //     //   BoxHembras.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        //     //   BoxPeso.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        //     //   BoxGalpón.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        //        button2.Enabled = true;
        //    }
        //    catch
        //    {

        //    }
        //}
        String fecha1;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoExperimento.Text = dataGridView1.Rows[e.RowIndex].Cells["codExperimento"].Value.ToString();


            fecha1 = fechaSelecion.Text = dataGridView1.Rows[e.RowIndex].Cells["fechaRegistro"].Value.ToString();
            fechaSelecion.Format = DateTimePickerFormat.Custom;
            fechaSelecion.CustomFormat = "yyyy - MM - dd";
            fechaSelecion.Text = fecha1;
            String fechaInicioLboral = fechaSelecion.Value.ToString();


            String tipooo= dataGridView1.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
            if (tipooo.Equals("Enzimas"))
            {
                radioButton1.Checked = true;
            }
            else {
                radioButton2.Checked = true;
            }
            productosExperimento1.Text = dataGridView1.Rows[e.RowIndex].Cells["productoExperimental1"].Value.ToString();
            machos1.Text = dataGridView1.Rows[e.RowIndex].Cells["cantMachos1"].Value.ToString();
            hembras1.Text = dataGridView1.Rows[e.RowIndex].Cells["cantHembras1"].Value.ToString();
            pesoIncial1.Text = dataGridView1.Rows[e.RowIndex].Cells["pesoInicial1"].Value.ToString();
            productoExperimental2.Text = dataGridView1.Rows[e.RowIndex].Cells["productoExperimental2"].Value.ToString();
            macho2.Text = dataGridView1.Rows[e.RowIndex].Cells["cantMachos2"].Value.ToString();
            Hembras2.Text = dataGridView1.Rows[e.RowIndex].Cells["cantHembras2"].Value.ToString();
            pesoInicial2.Text = dataGridView1.Rows[e.RowIndex].Cells["pesoInicial2"].Value.ToString();
            productosExperimento3.Text = dataGridView1.Rows[e.RowIndex].Cells["productoExperimental3"].Value.ToString();
            machos3.Text = dataGridView1.Rows[e.RowIndex].Cells["cantMachos3"].Value.ToString();
            hembras3.Text = dataGridView1.Rows[e.RowIndex].Cells["cantHembras3"].Value.ToString();
            pesoInicial3.Text = dataGridView1.Rows[e.RowIndex].Cells["pesoInicial3"].Value.ToString();
            galponAsignado.Text = dataGridView1.Rows[e.RowIndex].Cells["galponAsignado"].Value.ToString();
            button2.Enabled = true;
        }

        private void Hembras2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
