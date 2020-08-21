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
    public partial class Registro_Alimento : UserControl
    {
        Conexion2 conexion = new Conexion2();
        ControlAlimento controlAlimento = new ControlAlimento();


        public Registro_Alimento()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String codigoBarras = textBox3.Text.ToString();
            Console.WriteLine(codigoBarras);
            String marca = textBox1.Text.ToString();
            int cantidadSacos = int.Parse(textBox4.Text);
            Console.WriteLine(cantidadSacos);
            float pesoSacos = float.Parse(textBox2.Text);
            Console.WriteLine(pesoSacos);
            if(controlAlimento.guardarAlimento(conexion, codigoBarras, marca, cantidadSacos, pesoSacos) == 1)
            {
                MessageBox.Show("Registro exitoso");
                this.Hide();
            }
            else
            {
                MessageBox.Show("HUBO ERROR AL GUARDAR");
            }

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

        private void Registro_Alimento_Load(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
