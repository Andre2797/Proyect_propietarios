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

namespace ChickPro_Interfaces
{
    public partial class Salud_Pollos : UserControl
    {

        Conexion2 conexion = new Conexion2();
        ControlVitamina vitamina = new ControlVitamina();

        public Salud_Pollos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String galpon = textBox1.Text.ToString();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy - MM - dd";
            String fecha = dateTimePicker1.Value.ToString();
            int edad = int.Parse(textBox2.Text.ToString());
            String justificacion = richTextBox1.Text.ToString();
            String opcion = "";
            if (checkBox1.Checked == true)
            {
                opcion = "Medicamento";
            }
            if (checkBox2.Checked == true)
            {
                opcion = "Vitamina";
            }
            String nombre = textBox3.Text.ToString();
            float dosis = float.Parse(textBox4.Text.ToString());
            //String query = "EXEC SP_RegistroVitamina "

            if (vitamina.guardarVitamina(conexion, fecha, edad, opcion, nombre, dosis, galpon, justificacion) == 1)
            {
                MessageBox.Show("Registro exitoso");
                this.Hide();
            }
            else
            {
                MessageBox.Show("HUBO ERROR AL GUARDAR");
            }


            //MessageBox.Show("Registro exitoso");
            //this.Hide();
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

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void RichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
