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
    public partial class Modificar_galpon : UserControl
    {
        CN_registroGalpon registroGalpon = new CN_registroGalpon();
        CN_registroGalpon registroGalpon2 = new CN_registroGalpon();
        string idregistro=null;
        private bool editar = false;
        public Modificar_galpon()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                dataGridView1.DataSource = registroGalpon.mostrarRegistroGalpon();
                textBoxmachos.Text = dataGridView1.CurrentRow.Cells["cantidadMachos"].Value.ToString();
                hembras.Text = dataGridView1.CurrentRow.Cells["cantidadHembras"].Value.ToString();
                textBoxedad.Text = dataGridView1.CurrentRow.Cells["edadPromedio"].Value.ToString();
                peso.Text = dataGridView1.CurrentRow.Cells["pesoPromedio"].Value.ToString();
                date = dataGridView1.CurrentRow.Cells["fechaRegistro"].Value.ToString();
                MessageBox.Show("Actualización  Exitosa");
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Seeccione una fila por favor");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (editar == true)
            {
                string crg = dataGridView1.CurrentRow.Cells["codRegistroGalpon"].Value.ToString();
                try
                {
                   
                    registroGalpon.editargalpon(textBoxedad.Text, peso.Text, textBoxmachos.Text, hembras.Text,
                    region.Text, galpon.Text,idregistro);
                    registroGalpon2.insertarhistoricogalpon(textBoxedad.Text, peso.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"),crg);
                    MessageBox.Show("Se Actualizó correctamente");
                    mostrarRegistroGalpon();
                    editar = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo Actualizar"+ex);
                }
            }

           


        }
        public void mostrarRegistroGalpon()
        {
            CN_registroGalpon registroGalpon1 = new CN_registroGalpon();

            dataGridView1.DataSource = registroGalpon1.mostrarRegistroGalpon();

        }

        private void Modificar_galpon_Load(object sender, EventArgs e)
        {
            mostrarRegistroGalpon();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                textBoxedad.Text = dataGridView1.CurrentRow.Cells["edadPromedio"].Value.ToString();
                peso.Text = dataGridView1.CurrentRow.Cells["pesoPromedio"].Value.ToString();
                region.Text = dataGridView1.CurrentRow.Cells["region"].Value.ToString();
                textBoxedad.Text = dataGridView1.CurrentRow.Cells["edadPromedio"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["fechaRegistro"].Value.ToString();
                textBoxmachos.Text = dataGridView1.CurrentRow.Cells["cantidadMachos"].Value.ToString();
                hembras.Text = dataGridView1.CurrentRow.Cells["cantidadMachos"].Value.ToString();
                galpon.Text = dataGridView1.CurrentRow.Cells["creacionGalpon_codGalpon"].Value.ToString();
                idregistro= dataGridView1.CurrentRow.Cells["codRegistroGalpon"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selccione una fila por favor");
            }
        }
        
    }
}




