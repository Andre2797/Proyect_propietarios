namespace ChickPro_Interfaces
{
    partial class ingresoSistemaChickPro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.SalirChickPro = new System.Windows.Forms.Button();
            this.IngresoChickPro = new System.Windows.Forms.Button();
            this.modo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(70, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(45, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(159, 140);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(247, 26);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(159, 200);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(247, 26);
            this.textBoxContraseña.TabIndex = 3;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.TextBoxContraseña_TextChanged);
            this.textBoxContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxContraseña_KeyDown);
            // 
            // SalirChickPro
            // 
            this.SalirChickPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SalirChickPro.Location = new System.Drawing.Point(286, 457);
            this.SalirChickPro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SalirChickPro.Name = "SalirChickPro";
            this.SalirChickPro.Size = new System.Drawing.Size(260, 63);
            this.SalirChickPro.TabIndex = 4;
            this.SalirChickPro.Text = "SALIR DEL SISTEMA";
            this.SalirChickPro.UseVisualStyleBackColor = false;
            this.SalirChickPro.Click += new System.EventHandler(this.SalirChickPro_Click);
            // 
            // IngresoChickPro
            // 
            this.IngresoChickPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IngresoChickPro.Location = new System.Drawing.Point(14, 457);
            this.IngresoChickPro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IngresoChickPro.Name = "IngresoChickPro";
            this.IngresoChickPro.Size = new System.Drawing.Size(260, 63);
            this.IngresoChickPro.TabIndex = 5;
            this.IngresoChickPro.Text = "INGRESAR AL SISTEMA";
            this.IngresoChickPro.UseVisualStyleBackColor = false;
            this.IngresoChickPro.Click += new System.EventHandler(this.IngresoChickPro_Click);
            // 
            // modo
            // 
            this.modo.FormattingEnabled = true;
            this.modo.Items.AddRange(new object[] {
            "Administrador del Sistema",
            "Administrador de Galpón",
            "Gerente"});
            this.modo.Location = new System.Drawing.Point(159, 80);
            this.modo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modo.Name = "modo";
            this.modo.Size = new System.Drawing.Size(247, 28);
            this.modo.TabIndex = 8;
            this.modo.Text = "Administrador del Sistema";
            this.modo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(86, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modo";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(369, 231);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(197, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CAMBIAR CONTRASEÑA";
            // 
            // ingresoSistemaChickPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ChickPro_Interfaces.Properties.Resources.ChickProSistem;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 512);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modo);
            this.Controls.Add(this.IngresoChickPro);
            this.Controls.Add(this.SalirChickPro);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ingresoSistemaChickPro";
            this.Text = "Ingreso ChickPRO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IngresoSistemaChickPro_FormClosing);
            this.Load += new System.EventHandler(this.IngresoSistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button SalirChickPro;
        private System.Windows.Forms.Button IngresoChickPro;
        private System.Windows.Forms.ComboBox modo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}