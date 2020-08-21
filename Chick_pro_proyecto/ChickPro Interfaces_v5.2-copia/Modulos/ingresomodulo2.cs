using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChickPro_Interfaces
{
    public partial class ingresomodulo2 : Form
    {
        public ingresomodulo2()
        {
            InitializeComponent();
        }

        private void BuscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_Galponero buscarGalponero = new Buscar_Galponero();
            if (panel1.Contains(buscarGalponero) == false)
            {
                panel1.Controls.Add(buscarGalponero);
                buscarGalponero.Dock = DockStyle.Fill;
                buscarGalponero.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                buscarGalponero.BringToFront();
            }
        }

        private void BuscarLoteDePollosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarPollos buscarlote = new buscarPollos();
            if (panel1.Contains(buscarlote) == false)
            {
                panel1.Controls.Add(buscarlote);
                buscarlote.Dock = DockStyle.Fill;
                buscarlote.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                buscarlote.BringToFront();
            }
        }

        private void BuscarAlimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar_consumo_alimento buscaralimento = new Buscar_consumo_alimento();
            if (panel1.Contains(buscaralimento) == false)
            {
                panel1.Controls.Add(buscaralimento);
                buscaralimento.Dock = DockStyle.Fill;
                buscaralimento.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                buscaralimento.BringToFront();
            }
        }

        private void BuscarVitaminasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarSaludPollos buscarsalud = new buscarSaludPollos();
            if (panel1.Contains(buscarsalud) == false)
            {
                panel1.Controls.Add(buscarsalud);
                buscarsalud.Dock = DockStyle.Fill;
                buscarsalud.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                buscarsalud.BringToFront();
            }
        }

        private void BuscarExperimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buscarExperimento buscarexperimento = new buscarExperimento();
            if (panel1.Contains(buscarexperimento) == false)
            {
                panel1.Controls.Add(buscarexperimento);
                buscarexperimento.Dock = DockStyle.Fill;
                buscarexperimento.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                buscarexperimento.BringToFront();
            }
        }

        private void Ingresomodulo2_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            administraciónDeGalponerosToolStripMenuItem.Enabled = true;
            gestiónDePollosToolStripMenuItem.Enabled = true;
            alimentoDePollosToolStripMenuItem.Enabled = true;
            gestiónDelExperimentoToolStripMenuItem.Enabled = true;
           // ayuda.Enabled = true;
        }

        private void Ingresomodulo2_FormClosing(object sender, FormClosingEventArgs e)
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
