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
using ChickPro_Interfaces.Conexion;

namespace ChickPro_Interfaces
{
    public partial class Buscar_consumo_alimento : UserControl
    {
        private CD_Conexion conexion = new CD_Conexion();

        public Buscar_consumo_alimento()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            buscar();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BuscarLote_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Búsqueda exitosa");
        }

        void buscar()
        {
            SqlDataAdapter da = new SqlDataAdapter("mostrarSacoAlimento", conexion.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dateTimePicker1.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
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
    }
}
