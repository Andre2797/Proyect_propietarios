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
    public partial class Registro_de_Experimento : UserControl
    {
        public Registro_de_Experimento()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
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

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy - MM - dd";
            String fechaRegistro = dateTimePicker1.Value.ToString();

            String tipo = "";
            if (radioButton1.Checked)
            {
            tipo = "Enzimas";
            }
            else 
            {
            tipo = "Alimento";
            }
            String productoExperimental1 = ProductosExperimentales1.Text.ToString();
            String macho1 = Machos1.Text.ToString();
            String hembras1 = Hembras1.Text.ToString();
            String inici1 = pesoInicial1.Text.ToString();

            String productoExperimental2 = ProductosExperimentales2.Text.ToString();
            String macho2 = Machos2.Text.ToString();
            String hembr2 = Hembras2.Text.ToString();
            String inici2 = pesoInicio2.Text.ToString();

            String productoExperimental3 = ProductosExperimentales3.Text.ToString();
            String macho3 = Machos3.Text.ToString();
            String hembr3 = Hembras3.Text.ToString();
            String inici3 = pesoInicial3.Text.ToString();

            String codigoExprimento = CodigoExperimento.Text.ToString();
            String asignado = galponAsignado.Text.ToString();

            string query = "insert into chickpro.detalleExperimento1 values('"+codigoExprimento+"','"+fechaRegistro+"','"+tipo+"','"+productoExperimental1+"','"+macho1+"','"+hembras1+"','"+inici1+"','"+productoExperimental2+"','"+macho2+"','"+hembr2+"','"+inici2+"','"+productoExperimental3+"','"+macho3+"','"+hembr3+"','"+inici3+"','"+asignado+"') ";
            SqlCommand comando = new SqlCommand(query, validar);
            SqlDataReader leer;
            leer = comando.ExecuteReader();
            MessageBox.Show("Registro Exitoso");
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
            DialogResult res = MessageBox.Show("¿Desea abandonar el sistema?", "Cerrar",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                //e.Cancel = true;
                Application.Exit();
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
