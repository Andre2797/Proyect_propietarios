namespace ChickPro_Interfaces
{
    partial class ingresomodulo2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónDeGalponerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLoteDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEnvíoDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMortalidadDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentoDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVitaminasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDelExperimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ChickPro_Interfaces.Properties.Resources.ChickProSistem;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 497);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDeGalponerosToolStripMenuItem,
            this.gestiónDePollosToolStripMenuItem,
            this.alimentoDePollosToolStripMenuItem,
            this.gestiónDelExperimentoToolStripMenuItem,
            this.ayuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1321, 38);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónDeGalponerosToolStripMenuItem
            // 
            this.administraciónDeGalponerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem});
            this.administraciónDeGalponerosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.engineer_vector_icon_png_247858;
            this.administraciónDeGalponerosToolStripMenuItem.Name = "administraciónDeGalponerosToolStripMenuItem";
            this.administraciónDeGalponerosToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.administraciónDeGalponerosToolStripMenuItem.Text = "Administración de Galponeros";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.buscarToolStripMenuItem.Text = "Consulta Galponero";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.BuscarToolStripMenuItem_Click);
            // 
            // gestiónDePollosToolStripMenuItem
            // 
            this.gestiónDePollosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarLoteDePollosToolStripMenuItem,
            this.buscarEnvíoDePollosToolStripMenuItem,
            this.buscarMortalidadDePollosToolStripMenuItem});
            this.gestiónDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.kisspng_rooster_chicken_bird_icon_cock_avatar_5a8ec51a9a9995_6206599515193060106333;
            this.gestiónDePollosToolStripMenuItem.Name = "gestiónDePollosToolStripMenuItem";
            this.gestiónDePollosToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.gestiónDePollosToolStripMenuItem.Text = "Gestión de Pollos";
            // 
            // buscarLoteDePollosToolStripMenuItem
            // 
            this.buscarLoteDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarLoteDePollosToolStripMenuItem.Name = "buscarLoteDePollosToolStripMenuItem";
            this.buscarLoteDePollosToolStripMenuItem.Size = new System.Drawing.Size(377, 36);
            this.buscarLoteDePollosToolStripMenuItem.Text = "Consulta Galpón de Pollos";
            this.buscarLoteDePollosToolStripMenuItem.Click += new System.EventHandler(this.BuscarLoteDePollosToolStripMenuItem_Click);
            // 
            // buscarEnvíoDePollosToolStripMenuItem
            // 
            this.buscarEnvíoDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarEnvíoDePollosToolStripMenuItem.Name = "buscarEnvíoDePollosToolStripMenuItem";
            this.buscarEnvíoDePollosToolStripMenuItem.Size = new System.Drawing.Size(377, 36);
            this.buscarEnvíoDePollosToolStripMenuItem.Text = "Consulta Envío de Pollos";
            // 
            // buscarMortalidadDePollosToolStripMenuItem
            // 
            this.buscarMortalidadDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarMortalidadDePollosToolStripMenuItem.Name = "buscarMortalidadDePollosToolStripMenuItem";
            this.buscarMortalidadDePollosToolStripMenuItem.Size = new System.Drawing.Size(377, 36);
            this.buscarMortalidadDePollosToolStripMenuItem.Text = "Consulta Mortalidad de Pollos";
            // 
            // alimentoDePollosToolStripMenuItem
            // 
            this.alimentoDePollosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarAlimentoToolStripMenuItem,
            this.buscarVitaminasToolStripMenuItem});
            this.alimentoDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.istockphoto_959666700_1024x1024;
            this.alimentoDePollosToolStripMenuItem.Name = "alimentoDePollosToolStripMenuItem";
            this.alimentoDePollosToolStripMenuItem.Size = new System.Drawing.Size(320, 32);
            this.alimentoDePollosToolStripMenuItem.Text = "Gestión del Alimento de Pollos";
            // 
            // buscarAlimentoToolStripMenuItem
            // 
            this.buscarAlimentoToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarAlimentoToolStripMenuItem.Name = "buscarAlimentoToolStripMenuItem";
            this.buscarAlimentoToolStripMenuItem.Size = new System.Drawing.Size(513, 36);
            this.buscarAlimentoToolStripMenuItem.Text = "Consulta Consumo de Alimentos";
            this.buscarAlimentoToolStripMenuItem.Click += new System.EventHandler(this.BuscarAlimentoToolStripMenuItem_Click);
            // 
            // buscarVitaminasToolStripMenuItem
            // 
            this.buscarVitaminasToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarVitaminasToolStripMenuItem.Name = "buscarVitaminasToolStripMenuItem";
            this.buscarVitaminasToolStripMenuItem.Size = new System.Drawing.Size(513, 36);
            this.buscarVitaminasToolStripMenuItem.Text = "Consulta Vitaminas y Medicamentos de Pollos";
            this.buscarVitaminasToolStripMenuItem.Click += new System.EventHandler(this.BuscarVitaminasToolStripMenuItem_Click);
            // 
            // gestiónDelExperimentoToolStripMenuItem
            // 
            this.gestiónDelExperimentoToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources._75414584_icono_de_pictograma_de_tubo_de_prueba_química_equipo_de_la_cristalería_o_del_vaso_de_laboratorio_aislado;
            this.gestiónDelExperimentoToolStripMenuItem.Name = "gestiónDelExperimentoToolStripMenuItem";
            this.gestiónDelExperimentoToolStripMenuItem.Size = new System.Drawing.Size(266, 32);
            this.gestiónDelExperimentoToolStripMenuItem.Text = "Gestión del Experimento";
            // 
            // ayuda
            // 
            this.ayuda.BackgroundImage = global::ChickPro_Interfaces.Properties.Resources._16056;
            this.ayuda.Image = global::ChickPro_Interfaces.Properties.Resources._16056;
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(108, 32);
            this.ayuda.Text = "Ayuda";
            // 
            // ingresomodulo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1321, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "ingresomodulo2";
            this.RightToLeftLayout = true;
            this.Text = "Módulos ChickPro -Gerente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ingresomodulo2_FormClosing);
            this.Load += new System.EventHandler(this.Ingresomodulo2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeGalponerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarLoteDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentoDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAlimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVitaminasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDelExperimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayuda;
        private System.Windows.Forms.ToolStripMenuItem buscarEnvíoDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMortalidadDePollosToolStripMenuItem;
    }
}