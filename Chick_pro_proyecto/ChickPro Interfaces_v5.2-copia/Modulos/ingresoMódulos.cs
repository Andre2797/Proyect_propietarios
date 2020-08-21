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
    public partial class ingresoMódulos : Form
    {
        public static ingresoMódulos mdiobj;
        public ingresoMódulos()
        {
            InitializeComponent();
            this.CenterToScreen();
           
            //this.DefaultMaximumSize();
        }


        private void SalidaMódulos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegresarMódulos_Click(object sender, EventArgs e)
        {
            ingresoSistemaChickPro ingresoSistemaChickPro = new ingresoSistemaChickPro();
            ingresoSistemaChickPro.Show();
            this.Hide();
        
            //gestiónDeGalponeros gestiónDeGalponeros = new gestiónDeGalponeros();
            //gestiónDeGalponeros.Show();
            //this.Hide();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //registroGalponero ingresoGalponero = new registroGalponero();
            
            Registro_Galponero ingresoGalponero = new Registro_Galponero();
            if (panel1.Contains(ingresoGalponero)==false)
            {
                panel1.Controls.Add(ingresoGalponero);
                ingresoGalponero.Dock = DockStyle.Fill;
                ingresoGalponero.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                ingresoGalponero.BringToFront();
            }
            
        }

        private void ActualizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar_Galponero actualizarGalponero = new Actualizar_Galponero();
            if (panel1.Contains(actualizarGalponero) == false)
            {
                panel1.Controls.Add(actualizarGalponero);
                actualizarGalponero.Dock = DockStyle.Fill;
                actualizarGalponero.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                actualizarGalponero.BringToFront();
            }

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

        private void RegistroDeLoteDePollosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Lote_de_Pollos lote = new Registro_Lote_de_Pollos();
            if (panel1.Contains(lote) == false)
            {
                panel1.Controls.Add(lote);
                lote.Dock = DockStyle.Fill;
                lote.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                lote.BringToFront();
            }
        }

        private void RegistroCantidadDePollosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Cantidad_de_Pollos cantidad = new Registro_Cantidad_de_Pollos();
            if (panel1.Contains(cantidad) == false)
            {
                panel1.Controls.Add(cantidad);
                cantidad.Dock = DockStyle.Fill;
                cantidad.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                cantidad.BringToFront();
            }

        }

        private void RegistroEnvíoDePollosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Envio_de_Pollos envio = new Registro_Envio_de_Pollos();
            if (panel1.Contains(envio) == false)
            {
                panel1.Controls.Add(envio);
                envio.Dock = DockStyle.Fill;
                envio.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                envio.BringToFront();
            }
        }

        private void RegistrarAlimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_Alimento alimento = new Registro_Alimento();
            if (panel1.Contains(alimento) == false)
            {
                panel1.Controls.Add(alimento);
                alimento.Dock = DockStyle.Fill;
                alimento.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;
            }
            else
            {
                alimento.BringToFront();
            }
        }

        private void RepartirAlimentoEnPorcionesAdecuadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reparticion_Porciones_Adecuadas porcion = new Reparticion_Porciones_Adecuadas();
            if (panel1.Contains(porcion) == false)
            {
                panel1.Controls.Add(porcion);
                porcion.Dock = DockStyle.Fill;
                porcion.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;
            }
            else
            {
                porcion.BringToFront();
            }
        }

        private void RegistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AccesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarDeAlataGalponero dardealta = new DarDeAlataGalponero();
            if (panel1.Contains(dardealta) == false)
            {
                panel1.Controls.Add(dardealta);
                dardealta.Dock = DockStyle.Fill;
                dardealta.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                // ayuda.Enabled = false;

            }
            else
            {
                dardealta.BringToFront();
            }
        }

        private void RegistroDeDatosDelExperimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro_de_Experimento registroExperimento = new Registro_de_Experimento();
            if (panel1.Contains(registroExperimento) == false)
            {
                panel1.Controls.Add(registroExperimento);
                registroExperimento.Dock = DockStyle.Fill;
                registroExperimento.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
               // ayuda.Enabled = false;

            }
            else
            {
                registroExperimento.BringToFront();
            }
        }

        private void ActuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_Experimento ModificarExperimento = new Modificar_Experimento();
            if (panel1.Contains(ModificarExperimento) == false)
            {
                panel1.Controls.Add(ModificarExperimento);
                ModificarExperimento.Dock = DockStyle.Fill;
                ModificarExperimento.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                ModificarExperimento.BringToFront();
            }
        }

        private void DadaDeAltaAlExperimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar_detalle_experimento estadoExperimento = new Mostrar_detalle_experimento();
            //Estado_Experimento  = new Estado_Experimento();
            if (panel1.Contains(estadoExperimento) == false)
            {
                panel1.Controls.Add(estadoExperimento);
                estadoExperimento.Dock = DockStyle.Fill;
                estadoExperimento.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;

            }
            else
            {
                estadoExperimento.BringToFront();
            }

        }

        private void IngresoMódulos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            


        }

        private void Registro_Galponero1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            administraciónDeGalponerosToolStripMenuItem.Enabled = true;
            gestiónDePollosToolStripMenuItem.Enabled = true;
            alimentoDePollosToolStripMenuItem.Enabled = true;
            gestiónDelExperimentoToolStripMenuItem.Enabled = true;
            //ayuda.Enabled = true;
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
                //administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                //gestiónDePollosToolStripMenuItem.Enabled = false;
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
               // ayuda.Enabled = false;

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

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void AlimentoDePollosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void IngresoMódulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta acción cerrará el sistema", "Cerrar",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void RegistroDeMedicamentoParaPollosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salud_Pollos salud = new Salud_Pollos();
            if (panel1.Contains(salud) == false)
            {
                panel1.Controls.Add(salud);
                salud.Dock = DockStyle.Fill;
                salud.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;
            }
            else
            {
                salud.BringToFront();
            }

        }

        private void ActualizaciónDeGalpónDePolloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar_galpon modificar = new Modificar_galpon();
            if (panel1.Contains(modificar) == false)
            {
                panel1.Controls.Add(modificar);
                modificar.Dock = DockStyle.Fill;
                modificar.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;
            }
            else
            {
                modificar.BringToFront();
            }
        }

        private void BuscarMortalidadDePollosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar_buscar_mortalidad mortalidad = new Mostrar_buscar_mortalidad ();
            if (panel1.Contains(mortalidad) == false)
            {
                panel1.Controls.Add(mortalidad);
                mortalidad.Dock = DockStyle.Fill;
                mortalidad.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;
            }
            else
            {
                mortalidad.BringToFront();
            }
        }

        private void BuscarEnvíoDePollosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar_buscar_envio envio= new Mostrar_buscar_envio();
            if (panel1.Contains(envio) == false)
            {
                panel1.Controls.Add(envio);
                envio.Dock = DockStyle.Fill;
                envio.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;
            }
            else
            {
                envio.BringToFront();
            }
        }

        private void VisualizaciónDeDetalleDeCrianzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar_detalle_crianza crianza = new Mostrar_detalle_crianza();
            if (panel1.Contains(crianza) == false)
            {
                panel1.Controls.Add(crianza);
                crianza.Dock = DockStyle.Fill;
                crianza.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;
            }
            else
            {
                crianza.BringToFront();
            }
        }

        private void RegistroDeSacosPorGalpónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registro_saco_galpon saco = new Registro_saco_galpon();
            if (panel1.Contains(saco) == false)
            {
                panel1.Controls.Add(saco);
                saco.Dock = DockStyle.Fill;
                saco.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;
            }
            else
            {
                saco.BringToFront();
            }
        }

        private void MostrarDetalleDeExperimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar_detalle_experimento saco = new Mostrar_detalle_experimento();
            if (panel1.Contains(saco) == false)
            {
                panel1.Controls.Add(saco);
                saco.Dock = DockStyle.Fill;
                saco.BringToFront();
                administraciónDeGalponerosToolStripMenuItem.Enabled = false;
                gestiónDePollosToolStripMenuItem.Enabled = false;
                alimentoDePollosToolStripMenuItem.Enabled = false;
                gestiónDelExperimentoToolStripMenuItem.Enabled = false;
                //ayuda.Enabled = false;
            }
            else
            {
                saco.BringToFront();
            }
        }
    }
}
