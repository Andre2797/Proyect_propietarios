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

namespace ChickPro_Interfaces
{ 
    public partial class Registro_Lote_de_Pollos : UserControl
    {
        CN_registroGalpon registroGalpon = new CN_registroGalpon();
        public Registro_Lote_de_Pollos()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                registroGalpon.insertargalpon(textBox2.Text, textBox3.Text, textBox6.Text, textBox7.Text,
                    textBox4.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox1.Text); ;

                MessageBox.Show("Registro Exitoso");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ingresar los datos por:" +ex+ textBox2.Text + textBox3.Text + textBox6.Text + textBox7.Text +
                    textBox4.Text + dateTimePicker1.Value.ToString("yyyy-MM-dd") + textBox1.Text);
            }


        }

        private void Button1_Click(object sender, EventArgs e)
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

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
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
                //           MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
