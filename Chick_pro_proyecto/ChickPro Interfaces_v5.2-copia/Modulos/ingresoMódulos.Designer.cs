namespace ChickPro_Interfaces
{
    partial class ingresoMódulos
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
            this.salidaMódulos = new System.Windows.Forms.Button();
            this.regresarMódulos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónDeGalponerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeLoteDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLoteDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizaciónDeGalpónDePolloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroCantidadDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMortalidadDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEnvíoDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarEnvíoDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentoDePollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeSacosPorGalpónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.repartirAlimentoEnPorcionesAdecuadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeMedicamentoParaPollosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVitaminasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDelExperimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeDatosDelExperimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mostrarDetalleDeExperimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salidaMódulos
            // 
            this.salidaMódulos.BackColor = System.Drawing.Color.PaleVioletRed;
            this.salidaMódulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaMódulos.Location = new System.Drawing.Point(522, 708);
            this.salidaMódulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.salidaMódulos.Name = "salidaMódulos";
            this.salidaMódulos.Size = new System.Drawing.Size(174, 54);
            this.salidaMódulos.TabIndex = 5;
            this.salidaMódulos.Text = "SALIR";
            this.salidaMódulos.UseVisualStyleBackColor = false;
            this.salidaMódulos.Click += new System.EventHandler(this.SalidaMódulos_Click);
            // 
            // regresarMódulos
            // 
            this.regresarMódulos.BackColor = System.Drawing.Color.PaleVioletRed;
            this.regresarMódulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarMódulos.Location = new System.Drawing.Point(358, 708);
            this.regresarMódulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regresarMódulos.Name = "regresarMódulos";
            this.regresarMódulos.Size = new System.Drawing.Size(177, 54);
            this.regresarMódulos.TabIndex = 6;
            this.regresarMódulos.Text = "REGRESAR";
            this.regresarMódulos.UseVisualStyleBackColor = false;
            this.regresarMódulos.Click += new System.EventHandler(this.RegresarMódulos_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1187, 38);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // administraciónDeGalponerosToolStripMenuItem
            // 
            this.administraciónDeGalponerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.actualizaciónToolStripMenuItem,
            this.accesoToolStripMenuItem});
            this.administraciónDeGalponerosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.engineer_vector_icon_png_247858;
            this.administraciónDeGalponerosToolStripMenuItem.Name = "administraciónDeGalponerosToolStripMenuItem";
            this.administraciónDeGalponerosToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.administraciónDeGalponerosToolStripMenuItem.Text = "Galponeros";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources._45477357_edit_records_vector_icon_style_is_bicolor_flat_symbol_blue_and_gray_colors_rounded_angles_white_back;
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(398, 36);
            this.registroToolStripMenuItem.Text = "Registro de Galponero ";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.RegistroToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(398, 36);
            this.buscarToolStripMenuItem.Text = "Consulta de Galponero";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.BuscarToolStripMenuItem_Click);
            // 
            // actualizaciónToolStripMenuItem
            // 
            this.actualizaciónToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.depositphotos_104222158_stock_illustration_refresh_arrows_flat_vector_symbol;
            this.actualizaciónToolStripMenuItem.Name = "actualizaciónToolStripMenuItem";
            this.actualizaciónToolStripMenuItem.Size = new System.Drawing.Size(398, 36);
            this.actualizaciónToolStripMenuItem.Text = "Actualización de Galponero";
            this.actualizaciónToolStripMenuItem.Click += new System.EventHandler(this.ActualizaciónToolStripMenuItem_Click);
            // 
            // accesoToolStripMenuItem
            // 
            this.accesoToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.equis;
            this.accesoToolStripMenuItem.Name = "accesoToolStripMenuItem";
            this.accesoToolStripMenuItem.Size = new System.Drawing.Size(398, 36);
            this.accesoToolStripMenuItem.Text = "Cambio de Estado de Galponero";
            this.accesoToolStripMenuItem.Click += new System.EventHandler(this.AccesoToolStripMenuItem_Click);
            // 
            // gestiónDePollosToolStripMenuItem
            // 
            this.gestiónDePollosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeLoteDePollosToolStripMenuItem,
            this.buscarLoteDePollosToolStripMenuItem,
            this.actualizaciónDeGalpónDePolloToolStripMenuItem,
            this.registroCantidadDePollosToolStripMenuItem,
            this.buscarMortalidadDePollosToolStripMenuItem,
            this.registroEnvíoDePollosToolStripMenuItem,
            this.buscarEnvíoDePollosToolStripMenuItem});
            this.gestiónDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.kisspng_rooster_chicken_bird_icon_cock_avatar_5a8ec51a9a9995_6206599515193060106333;
            this.gestiónDePollosToolStripMenuItem.Name = "gestiónDePollosToolStripMenuItem";
            this.gestiónDePollosToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.gestiónDePollosToolStripMenuItem.Text = "Gestión de Pollos";
            // 
            // registroDeLoteDePollosToolStripMenuItem
            // 
            this.registroDeLoteDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources._45477357_edit_records_vector_icon_style_is_bicolor_flat_symbol_blue_and_gray_colors_rounded_angles_white_back;
            this.registroDeLoteDePollosToolStripMenuItem.Name = "registroDeLoteDePollosToolStripMenuItem";
            this.registroDeLoteDePollosToolStripMenuItem.Size = new System.Drawing.Size(404, 36);
            this.registroDeLoteDePollosToolStripMenuItem.Text = "Registro de Lote de Pollos";
            this.registroDeLoteDePollosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeLoteDePollosToolStripMenuItem_Click);
            // 
            // buscarLoteDePollosToolStripMenuItem
            // 
            this.buscarLoteDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarLoteDePollosToolStripMenuItem.Name = "buscarLoteDePollosToolStripMenuItem";
            this.buscarLoteDePollosToolStripMenuItem.Size = new System.Drawing.Size(404, 36);
            this.buscarLoteDePollosToolStripMenuItem.Text = "Consulta de Lote de Pollos";
            this.buscarLoteDePollosToolStripMenuItem.Click += new System.EventHandler(this.BuscarLoteDePollosToolStripMenuItem_Click);
            // 
            // actualizaciónDeGalpónDePolloToolStripMenuItem
            // 
            this.actualizaciónDeGalpónDePolloToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.depositphotos_104222158_stock_illustration_refresh_arrows_flat_vector_symbol;
            this.actualizaciónDeGalpónDePolloToolStripMenuItem.Name = "actualizaciónDeGalpónDePolloToolStripMenuItem";
            this.actualizaciónDeGalpónDePolloToolStripMenuItem.Size = new System.Drawing.Size(404, 36);
            this.actualizaciónDeGalpónDePolloToolStripMenuItem.Text = "Actualización de Lote de Pollos";
            this.actualizaciónDeGalpónDePolloToolStripMenuItem.Click += new System.EventHandler(this.ActualizaciónDeGalpónDePolloToolStripMenuItem_Click);
            // 
            // registroCantidadDePollosToolStripMenuItem
            // 
            this.registroCantidadDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources._45477357_edit_records_vector_icon_style_is_bicolor_flat_symbol_blue_and_gray_colors_rounded_angles_white_back;
            this.registroCantidadDePollosToolStripMenuItem.Name = "registroCantidadDePollosToolStripMenuItem";
            this.registroCantidadDePollosToolStripMenuItem.Size = new System.Drawing.Size(404, 36);
            this.registroCantidadDePollosToolStripMenuItem.Text = "Registro de Mortalidad de Pollos";
            this.registroCantidadDePollosToolStripMenuItem.Click += new System.EventHandler(this.RegistroCantidadDePollosToolStripMenuItem_Click);
            // 
            // buscarMortalidadDePollosToolStripMenuItem
            // 
            this.buscarMortalidadDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarMortalidadDePollosToolStripMenuItem.Name = "buscarMortalidadDePollosToolStripMenuItem";
            this.buscarMortalidadDePollosToolStripMenuItem.Size = new System.Drawing.Size(404, 36);
            this.buscarMortalidadDePollosToolStripMenuItem.Text = "Consulta de Mortalidad de Pollos";
            this.buscarMortalidadDePollosToolStripMenuItem.Click += new System.EventHandler(this.BuscarMortalidadDePollosToolStripMenuItem_Click);
            // 
            // registroEnvíoDePollosToolStripMenuItem
            // 
            this.registroEnvíoDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources._45477357_edit_records_vector_icon_style_is_bicolor_flat_symbol_blue_and_gray_colors_rounded_angles_white_back;
            this.registroEnvíoDePollosToolStripMenuItem.Name = "registroEnvíoDePollosToolStripMenuItem";
            this.registroEnvíoDePollosToolStripMenuItem.Size = new System.Drawing.Size(404, 36);
            this.registroEnvíoDePollosToolStripMenuItem.Text = "Registro de Envío de Pollos";
            this.registroEnvíoDePollosToolStripMenuItem.Click += new System.EventHandler(this.RegistroEnvíoDePollosToolStripMenuItem_Click);
            // 
            // buscarEnvíoDePollosToolStripMenuItem
            // 
            this.buscarEnvíoDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarEnvíoDePollosToolStripMenuItem.Name = "buscarEnvíoDePollosToolStripMenuItem";
            this.buscarEnvíoDePollosToolStripMenuItem.Size = new System.Drawing.Size(404, 36);
            this.buscarEnvíoDePollosToolStripMenuItem.Text = "Consulta de Envío de Pollos";
            this.buscarEnvíoDePollosToolStripMenuItem.Click += new System.EventHandler(this.BuscarEnvíoDePollosToolStripMenuItem_Click);
            // 
            // alimentoDePollosToolStripMenuItem
            // 
            this.alimentoDePollosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAlimentoToolStripMenuItem,
            this.registroDeSacosPorGalpónToolStripMenuItem1,
            this.repartirAlimentoEnPorcionesAdecuadasToolStripMenuItem,
            this.buscarAlimentoToolStripMenuItem,
            this.registroDeMedicamentoParaPollosToolStripMenuItem,
            this.buscarVitaminasToolStripMenuItem});
            this.alimentoDePollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.istockphoto_959666700_1024x1024;
            this.alimentoDePollosToolStripMenuItem.Name = "alimentoDePollosToolStripMenuItem";
            this.alimentoDePollosToolStripMenuItem.Size = new System.Drawing.Size(251, 32);
            this.alimentoDePollosToolStripMenuItem.Text = "Alimentación de Pollos";
            this.alimentoDePollosToolStripMenuItem.Click += new System.EventHandler(this.AlimentoDePollosToolStripMenuItem_Click);
            // 
            // registrarAlimentoToolStripMenuItem
            // 
            this.registrarAlimentoToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources._45477357_edit_records_vector_icon_style_is_bicolor_flat_symbol_blue_and_gray_colors_rounded_angles_white_back;
            this.registrarAlimentoToolStripMenuItem.Name = "registrarAlimentoToolStripMenuItem";
            this.registrarAlimentoToolStripMenuItem.Size = new System.Drawing.Size(532, 36);
            this.registrarAlimentoToolStripMenuItem.Text = "Registro de Alimento";
            this.registrarAlimentoToolStripMenuItem.Click += new System.EventHandler(this.RegistrarAlimentoToolStripMenuItem_Click);
            // 
            // registroDeSacosPorGalpónToolStripMenuItem1
            // 
            this.registroDeSacosPorGalpónToolStripMenuItem1.Image = global::ChickPro_Interfaces.Properties.Resources._45477357_edit_records_vector_icon_style_is_bicolor_flat_symbol_blue_and_gray_colors_rounded_angles_white_back;
            this.registroDeSacosPorGalpónToolStripMenuItem1.Name = "registroDeSacosPorGalpónToolStripMenuItem1";
            this.registroDeSacosPorGalpónToolStripMenuItem1.Size = new System.Drawing.Size(532, 36);
            this.registroDeSacosPorGalpónToolStripMenuItem1.Text = "Registro de Sacos por Lote";
            this.registroDeSacosPorGalpónToolStripMenuItem1.Click += new System.EventHandler(this.RegistroDeSacosPorGalpónToolStripMenuItem1_Click);
            // 
            // repartirAlimentoEnPorcionesAdecuadasToolStripMenuItem
            // 
            this.repartirAlimentoEnPorcionesAdecuadasToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources._45477357_edit_records_vector_icon_style_is_bicolor_flat_symbol_blue_and_gray_colors_rounded_angles_white_back;
            this.repartirAlimentoEnPorcionesAdecuadasToolStripMenuItem.Name = "repartirAlimentoEnPorcionesAdecuadasToolStripMenuItem";
            this.repartirAlimentoEnPorcionesAdecuadasToolStripMenuItem.Size = new System.Drawing.Size(532, 36);
            this.repartirAlimentoEnPorcionesAdecuadasToolStripMenuItem.Text = "Registro de Consumo de Alimentos";
            this.repartirAlimentoEnPorcionesAdecuadasToolStripMenuItem.Click += new System.EventHandler(this.RepartirAlimentoEnPorcionesAdecuadasToolStripMenuItem_Click);
            // 
            // buscarAlimentoToolStripMenuItem
            // 
            this.buscarAlimentoToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarAlimentoToolStripMenuItem.Name = "buscarAlimentoToolStripMenuItem";
            this.buscarAlimentoToolStripMenuItem.Size = new System.Drawing.Size(532, 36);
            this.buscarAlimentoToolStripMenuItem.Text = "Consulta de Consumo de Alimento";
            this.buscarAlimentoToolStripMenuItem.Click += new System.EventHandler(this.BuscarAlimentoToolStripMenuItem_Click);
            // 
            // registroDeMedicamentoParaPollosToolStripMenuItem
            // 
            this.registroDeMedicamentoParaPollosToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources._45477357_edit_records_vector_icon_style_is_bicolor_flat_symbol_blue_and_gray_colors_rounded_angles_white_back;
            this.registroDeMedicamentoParaPollosToolStripMenuItem.Name = "registroDeMedicamentoParaPollosToolStripMenuItem";
            this.registroDeMedicamentoParaPollosToolStripMenuItem.Size = new System.Drawing.Size(532, 36);
            this.registroDeMedicamentoParaPollosToolStripMenuItem.Text = "Registro de Medicamento para Pollos";
            this.registroDeMedicamentoParaPollosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeMedicamentoParaPollosToolStripMenuItem_Click);
            // 
            // buscarVitaminasToolStripMenuItem
            // 
            this.buscarVitaminasToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.download;
            this.buscarVitaminasToolStripMenuItem.Name = "buscarVitaminasToolStripMenuItem";
            this.buscarVitaminasToolStripMenuItem.Size = new System.Drawing.Size(532, 36);
            this.buscarVitaminasToolStripMenuItem.Text = "Consulta de Vitaminas y Medicamento de Pollos";
            this.buscarVitaminasToolStripMenuItem.Click += new System.EventHandler(this.BuscarVitaminasToolStripMenuItem_Click);
            // 
            // gestiónDelExperimentoToolStripMenuItem
            // 
            this.gestiónDelExperimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeDatosDelExperimentoToolStripMenuItem,
            this.actuToolStripMenuItem,
            this.mostrarDetalleDeExperimentoToolStripMenuItem});
            this.gestiónDelExperimentoToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources._75414584_icono_de_pictograma_de_tubo_de_prueba_química_equipo_de_la_cristalería_o_del_vaso_de_laboratorio_aislado;
            this.gestiónDelExperimentoToolStripMenuItem.Name = "gestiónDelExperimentoToolStripMenuItem";
            this.gestiónDelExperimentoToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.gestiónDelExperimentoToolStripMenuItem.Text = "Experimento";
            // 
            // registroDeDatosDelExperimentoToolStripMenuItem
            // 
            this.registroDeDatosDelExperimentoToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources._45477357_edit_records_vector_icon_style_is_bicolor_flat_symbol_blue_and_gray_colors_rounded_angles_white_back;
            this.registroDeDatosDelExperimentoToolStripMenuItem.Name = "registroDeDatosDelExperimentoToolStripMenuItem";
            this.registroDeDatosDelExperimentoToolStripMenuItem.Size = new System.Drawing.Size(460, 36);
            this.registroDeDatosDelExperimentoToolStripMenuItem.Text = "Registro de Datos del Experimento";
            this.registroDeDatosDelExperimentoToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeDatosDelExperimentoToolStripMenuItem_Click);
            // 
            // actuToolStripMenuItem
            // 
            this.actuToolStripMenuItem.Image = global::ChickPro_Interfaces.Properties.Resources.depositphotos_104222158_stock_illustration_refresh_arrows_flat_vector_symbol;
            this.actuToolStripMenuItem.Name = "actuToolStripMenuItem";
            this.actuToolStripMenuItem.Size = new System.Drawing.Size(460, 36);
            this.actuToolStripMenuItem.Text = "Actualización de Datos del Experimento";
            this.actuToolStripMenuItem.Click += new System.EventHandler(this.ActuToolStripMenuItem_Click);
            // 
            // ayuda
            // 
            this.ayuda.BackgroundImage = global::ChickPro_Interfaces.Properties.Resources._16056;
            this.ayuda.Image = global::ChickPro_Interfaces.Properties.Resources._16056;
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(108, 32);
            this.ayuda.Text = "Ayuda";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ChickPro_Interfaces.Properties.Resources.ChickProSistem;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 501);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // mostrarDetalleDeExperimentoToolStripMenuItem
            // 
            this.mostrarDetalleDeExperimentoToolStripMenuItem.Name = "mostrarDetalleDeExperimentoToolStripMenuItem";
            this.mostrarDetalleDeExperimentoToolStripMenuItem.Size = new System.Drawing.Size(460, 36);
            this.mostrarDetalleDeExperimentoToolStripMenuItem.Text = "Mostrar Detalle de Experimento";
            this.mostrarDetalleDeExperimentoToolStripMenuItem.Click += new System.EventHandler(this.MostrarDetalleDeExperimentoToolStripMenuItem_Click);
            // 
            // ingresoMódulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChickPro_Interfaces.Properties.Resources.ChickProSistem1;
            this.ClientSize = new System.Drawing.Size(1187, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regresarMódulos);
            this.Controls.Add(this.salidaMódulos);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ingresoMódulos";
            this.RightToLeftLayout = true;
            this.Text = "Módulos ChickPro - Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IngresoMódulos_FormClosing);
            this.Load += new System.EventHandler(this.IngresoMódulos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button salidaMódulos;
        private System.Windows.Forms.Button regresarMódulos;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeGalponerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentoDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDelExperimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeLoteDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroCantidadDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEnvíoDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAlimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repartirAlimentoEnPorcionesAdecuadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeDatosDelExperimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actuToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem buscarLoteDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAlimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVitaminasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayuda;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualizaciónDeGalpónDePolloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMortalidadDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarEnvíoDePollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeSacosPorGalpónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registroDeMedicamentoParaPollosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDetalleDeExperimentoToolStripMenuItem;
    }
}