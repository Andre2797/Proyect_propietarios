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
using ChickPro_Interfaces.Conexion;
using System.Data.SqlClient;

namespace ChickPro_Interfaces
{
    public partial class Registro_Envio_de_Pollos : UserControl
    {
        CN_Envio envioPollos = new CN_Envio();
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();


        public Registro_Envio_de_Pollos()
        {
            InitializeComponent();
            codEnvio.Text=Convert.ToString(ponerCodigo());
            panel1.Enabled = false;
            this.Size = new Size(300, 300);
            //panel1.Hide();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void Button4_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    envioPollos.insertarEnvioPollos(dateTimePicker1.Value.ToString("yyyy-MM-dd"), chofer.Text, cantJaulas.Text);
            //    MessageBox.Show("Registro Exitoso");
            //    panel1.Enabled = true;
            //    //panel1.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No se pudo ingresar los datos por:"+ex);
            //}
        }

        
        private void Registro_Envio_de_Pollos_Load(object sender, EventArgs e)
        {
            
        }

        public int RegistrarGalpon()
        {
            Int32 codEnvio1=0;
            if (galpon1.Checked)
            {
                string sql = "select max(codRegistroGalpon) from chickpro.registrogalpon where creacionGalpon_codGalpon='g01'";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                codEnvio1 = Convert.ToInt32(comando.ExecuteScalar());
                
            }
            else if (galpon2.Checked)
            {
                string sql = "select max(codRegistroGalpon) from chickpro.registrogalpon where creacionGalpon_codGalpon='g02'";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                codEnvio1 = Convert.ToInt32(comando.ExecuteScalar());
                

            }else if(galpon3.Checked)
            {
                string sql = "select max(codRegistroGalpon) from chickpro.registrogalpon where creacionGalpon_codGalpon='g03'";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                codEnvio1 = Convert.ToInt32(comando.ExecuteScalar());
                
            }
            return codEnvio1;
        }

        public int cantMachosExistentes()
        {
            int existe = 0;
            if (galpon1.Checked)
            {
                string sql = "select cantidadMachos from chickpro.registrogalpon where creacionGalpon_codGalpon = 'g01' and codRegistroGalpon = (select max(codRegistroGalpon) from chickpro.registrogalpon)";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                existe = Convert.ToInt32(comando.ExecuteScalar());
            }else if(galpon2.Checked){
                string sql = "select cantidadMachos from chickpro.registrogalpon where creacionGalpon_codGalpon = 'g02' and codRegistroGalpon = (select max(codRegistroGalpon) from chickpro.registrogalpon)";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                existe = Convert.ToInt32(comando.ExecuteScalar());
            }else if (galpon3.Checked){
                string sql = "select cantidadMachos from chickpro.registrogalpon where creacionGalpon_codGalpon = 'g03' and codRegistroGalpon = (select max(codRegistroGalpon) from chickpro.registrogalpon)";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                existe = Convert.ToInt32(comando.ExecuteScalar());
            }
            return existe;
        }

        public int cantHembrasExistentes()
        {
            int existe = 0;
            if (galpon1.Checked)
            {
                string sql = "select cantidadHembras from chickpro.registrogalpon where creacionGalpon_codGalpon = 'g01' and codRegistroGalpon = (select max(codRegistroGalpon) from chickpro.registrogalpon)";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                existe = Convert.ToInt32(comando.ExecuteScalar());
            }
            else if (galpon2.Checked)
            {
                string sql = "select cantidadHembras from chickpro.registrogalpon where creacionGalpon_codGalpon = 'g02' and codRegistroGalpon = (select max(codRegistroGalpon) from chickpro.registrogalpon)";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                existe = Convert.ToInt32(comando.ExecuteScalar());
            }
            else if (galpon3.Checked)
            {
                string sql = "select cantidadHembras from chickpro.registrogalpon where creacionGalpon_codGalpon = 'g03' and codRegistroGalpon = (select max(codRegistroGalpon) from chickpro.registrogalpon)";
                SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
                existe = Convert.ToInt32(comando.ExecuteScalar());
            }
            return existe;
        }

        public Boolean existenciasPollos() {
            if(Convert.ToInt32(cantHemDet.Text) > cantHembrasExistentes())
            {

            }
            return true;
        }

        public int ponerCodigo()
        {
            string sql = "select max(chickpro.enviopollos.idenvioPollos)+1 from chickpro.enviopollos";
            SqlCommand comando = new SqlCommand(sql, conexion.AbrirConexion());
            Int32 codEnvio1 = Convert.ToInt32(comando.ExecuteScalar());
            return codEnvio1;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void refrescarCampos()
        {
            cantHemDet.Clear();
            cantMachDet.Clear();
            textBox9.Clear();
            pesoPromedio.Clear();
           
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            //if ((cantHembrasExistentes()>=int.Parse( cantHemDet.Text)) && (cantMachosExistentes() >= int.Parse(cantMachDet.Text)))
            //{
                try
                {
                    envioPollos.insertarDetallesEnvio(Convert.ToString(RegistrarGalpon()), cantHemDet.Text, cantMachDet.Text, pesoPromedio.Text, codEnvio.Text);
                    MessageBox.Show("Registro Exitoso");

                    int n = dataGridView1.Rows.Add();
                    if (galpon1.Checked)
                    {
                        dataGridView1.Rows[n].Cells[0].Value = "g01";
                        dataGridView1.Rows[n].Cells[1].Value = cantHemDet.Text;
                        dataGridView1.Rows[n].Cells[2].Value = cantMachDet.Text;
                        dataGridView1.Rows[n].Cells[3].Value = textBox9.Text;
                        dataGridView1.Rows[n].Cells[4].Value = pesoPromedio.Text;
                        refrescarCampos();
                        cantPollos.Text = Convert.ToString(sumaSubtotales());
                        textBox6.Text = Convert.ToString(sumaPesos());
                    }
                    else if (galpon2.Checked)
                    {
                        dataGridView1.Rows[n].Cells[0].Value = "g02";
                        dataGridView1.Rows[n].Cells[1].Value = cantHemDet.Text;
                        dataGridView1.Rows[n].Cells[2].Value = cantMachDet.Text;
                        dataGridView1.Rows[n].Cells[3].Value = textBox9.Text;
                        dataGridView1.Rows[n].Cells[4].Value = pesoPromedio.Text;
                        refrescarCampos();
                        cantPollos.Text = Convert.ToString(sumaSubtotales());
                        textBox6.Text = Convert.ToString(sumaPesos());
                    }
                    else if (galpon3.Checked)
                    {
                        dataGridView1.Rows[n].Cells[0].Value = "g03";
                        dataGridView1.Rows[n].Cells[1].Value = cantHemDet.Text;
                        dataGridView1.Rows[n].Cells[2].Value = cantMachDet.Text;
                        dataGridView1.Rows[n].Cells[3].Value = textBox9.Text;
                        dataGridView1.Rows[n].Cells[4].Value = pesoPromedio.Text;
                        refrescarCampos();
                        cantPollos.Text = Convert.ToString(sumaSubtotales());
                        textBox6.Text = Convert.ToString(sumaPesos());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ingresar los datos por:" + ex);
                }
            //}else if (cantMachosExistentes()<int.Parse(cantMachDet.Text))
            //{
            //    MessageBox.Show("No hay suficientes Machos en el Galpón", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //} else if (cantHembrasExistentes()<int.Parse(cantHemDet.Text))
            //{
            //    MessageBox.Show("No hay suficientes Hembras en el Galpón", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
           
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            //textBox9.Text = cantHemDet.Text + cantMachDet.Text;
        }

        private void TextBox9_MouseMove(object sender, MouseEventArgs e)
        {
            int cantH = Int32.Parse(cantHemDet.Text);
            int cantM = Int32.Parse(cantMachDet.Text);
            int suma = cantM + cantH;
            textBox9.Text = Convert.ToString(suma);
            //textBox9.Enabled = false;
        }

        public int sumaSubtotales()
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToInt32(row.Cells["Subtotal"].Value);
            }
            return total;
        }

        public double sumaPesos()
        {
            double totalPesos = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalPesos += Convert.ToDouble(row.Cells["pesoPromedio1"].Value);
            }
            return totalPesos;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CantHemDet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CantMachDet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void PesoPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Chofer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Chofer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CantJaulas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void CantJaulas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                try
                {
                    envioPollos.insertarEnvioPollos(dateTimePicker1.Value.ToString("yyyy-MM-dd"), chofer.Text, cantJaulas.Text);
                    //MessageBox.Show("Registro Exitoso");
                    panel1.Enabled = true;
                    //panel1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo ingresar los datos por:" + ex);
                }
            }
        }
    }
}
