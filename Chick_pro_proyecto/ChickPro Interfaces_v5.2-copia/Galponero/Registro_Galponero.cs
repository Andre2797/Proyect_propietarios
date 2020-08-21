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
//using ChickPro_Interfaces.control;

namespace ChickPro_Interfaces
{
    public partial class Registro_Galponero : UserControl
    {
        Conexion2 conexion = new Conexion2();
        ControlGalponero controlG = new ControlGalponero();



        public Registro_Galponero()
        {
            InitializeComponent();
            
        }

        private void Registro_Galponero_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           

           
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

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if ((CedulaGalp.Text == "") || (Nombre.Text=="")|| (Apellido.Text=="") || (direcion.Text=="") || (Telefon.Text==""))
            {
                MessageBox.Show("Error al ingresar: Algún campo en blanco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else { 
            String cedula = CedulaGalp.Text.ToString();

            if (VerificaCedula(cedula))
            {
                String priNombre = Nombre.Text.ToString();
                String priApellido = Apellido.Text.ToString();
                String direccion = direcion.Text.ToString();
                String telefono = Telefon.Text.ToString();
                char sexo;
                String rendimientoGalponeor = "0%";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy - MM - dd";
                String fechaInicioLboral = dateTimePicker1.Value.ToString();
                String estado = "ACTIVO";
                String creacionidGalponasig = galponAsignado.SelectedItem.ToString();

                if (radioButton1.Checked == true)
                {
                    sexo = 'M';
                }
                else
                    sexo = 'F';

                if (controlG.guardarGalponero(conexion, cedula, priNombre, priApellido, direccion, telefono, sexo, rendimientoGalponeor, fechaInicioLboral, estado, creacionidGalponasig) == 1)
                {
                    MessageBox.Show("Registrado con éxito");
                   
                }
                else
                {
                    MessageBox.Show("HUBO ERROR AL GUARDAR");
                }
                //conexion.consultaLsitaDB("insert into chickPro.galponero values ('" + cedula + "', '" + primNombre + "', '" + primPellido + "', '" + segNombre + "', '" + segmApellido + "', '" + direccion + "', '" + telefono + "', " + rendimineto + ", '" + fecha + "', 1, " + salario + ", " + Galponero_idUsuario + ");");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cédula incorecta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        }

        //private void CedulaGalp_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
        //    {
        //        MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        e.Handled = true;
        //        return;
        //    }
        //}
        //private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

        //    {
        //        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        e.Handled = true;

        //        return;
        //    }
        //}
        //private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

        //    {
        //        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        e.Handled = true;

        //        return;
        //    }
        //}

        //private void Telefon_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

        //    {
        //        MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        e.Handled = true;

        //        return;

        //    }
        //}
        public bool VerificaCedula(string ced)
        {
            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincia = 24;
            const int tercerDigito = 6;

            if (int.TryParse(ced, out isNumeric) && ced.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincia) && digitoTres < tercerDigito)
                {
                    var digitoVerificadorRecibido = Convert.ToInt32(ced[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) * Convert.ToInt32(ced[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;
                    return digitoVerificadorObtenido == digitoVerificadorRecibido;
                }
                return false;
            }
            return false;
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta acción cerrará el sistema", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void Telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void CedulaGalp_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Nombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

                return;
            }
        }

        private void Apellido_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

                return;
            }
        }

        private void Telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
