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
using Capa_Negocio;
using ChickPro_Interfaces.control;
using ChickPro_Interfaces.Conexion;

namespace ChickPro_Interfaces
{
   
    public partial class buscarPollos : UserControl

    {
        CN_registroGalpon registroGalpon = new CN_registroGalpon();
        Conexion2 conexion = new Conexion2();
        ControlGalponero control =  new ControlGalponero();
        CD_Conexion conect = new CD_Conexion();

        public buscarPollos()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void BuscarLote_Click(object sender, EventArgs e)
        {
            buscar();
        }

        public void mostrarRegistroGalpon()
        {
            CN_registroGalpon registroGalpon2 = new CN_registroGalpon();
            dataGridView1.DataSource = registroGalpon2.mostrarRegistroGalpon();
          
            
        }

        public void mostrarHistoricoGalpon()
        {
            CN_registroGalpon registroGalpon3 = new CN_registroGalpon();
            dataGridView1.DataSource = registroGalpon3.mostrarHistoricoGalpon();
        }


        private void BuscarPollos_Load(object sender, EventArgs e)
        {
            
                mostrarRegistroGalpon();
           
        }


        void buscar()
        {
            SqlDataAdapter da = new SqlDataAdapter("mostrarHistoricoGalpon1", conect.AbrirConexion());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@fecha", SqlDbType.DateTime).Value = dateTimePicker1.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Registro.Checked)
            {
               // textBox1.Enabled = true;
                String a = textBox1.Text;
                string query = "EXEC msotrar_registro_galpon_filtro '" + a + "'";
                conexion.consultaLsitaDB(query);
                SqlCommand comando = new SqlCommand(query, conexion.getCon());
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }else if (HIstorico.Checked)
            {
                //dateTimePicker1.Enabled = true;
                buscar();
            }
        }

        private void Registro_CheckedChanged(object sender, EventArgs e)
        {
            mostrarRegistroGalpon();  
        }

        private void HIstorico_CheckedChanged(object sender, EventArgs e)
        {
            mostrarHistoricoGalpon();
        }
    }
}
