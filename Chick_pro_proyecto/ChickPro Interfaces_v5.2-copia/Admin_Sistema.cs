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
    public partial class Admin_Sistema : Form
    {
        public Admin_Sistema()
        {
            InitializeComponent();
        }

        private void AsignarLoginProvicionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void CrearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignar_login login = new asignar_login();

            if (panel1.Contains(login) == false)
            {
                panel1.Controls.Add(login);
                login.Dock = DockStyle.Fill;
                login.BringToFront();
                //sistemaToolStripMenuItem.Enabled = false;
            }
        }

        private void DesbloquearResetearContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetear_desbloquear login = new resetear_desbloquear();

            if (panel1.Contains(login) == false)
            {
                panel1.Controls.Add(login);
                login.Dock = DockStyle.Fill;
                login.BringToFront();
            }
        }

        private void Admin_Sistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta acción cerrará el sistema", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void RegresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ingresoSistemaChickPro schp = new ingresoSistemaChickPro();
            schp.Show();
        }

        private void CrearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignar_login login = new asignar_login();

            if (panel1.Contains(login) == false)
            {
                panel1.Controls.Add(login);
                login.Dock = DockStyle.Fill;
                login.BringToFront();
                //sistemaToolStripMenuItem.Enabled = false;
            }
        }

        private void ResetearContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetear_desbloquear login = new resetear_desbloquear();

            if (panel1.Contains(login) == false)
            {
                panel1.Controls.Add(login);
                login.Dock = DockStyle.Fill;
                login.BringToFront();
            }
        }
    }
}
