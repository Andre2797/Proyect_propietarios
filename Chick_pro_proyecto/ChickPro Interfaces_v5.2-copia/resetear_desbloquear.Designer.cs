namespace ChickPro_Interfaces
{
    partial class resetear_desbloquear
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.resetear = new System.Windows.Forms.Button();
            this.desbloquear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.estad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.direccio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.ComboBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.usuari = new System.Windows.Forms.TextBox();
            this.cedul = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.contraseñ = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 189);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(494, 363);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 69);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 26);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(516, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 33);
            this.label1.TabIndex = 27;
            this.label1.Text = "Gestión de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Número de Cédula";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(74, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 42);
            this.button2.TabIndex = 32;
            this.button2.Text = "REGRESAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // resetear
            // 
            this.resetear.BackColor = System.Drawing.Color.Brown;
            this.resetear.Enabled = false;
            this.resetear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetear.Location = new System.Drawing.Point(222, 602);
            this.resetear.Name = "resetear";
            this.resetear.Size = new System.Drawing.Size(129, 42);
            this.resetear.TabIndex = 33;
            this.resetear.Text = "RESETEAR";
            this.resetear.UseVisualStyleBackColor = false;
            this.resetear.Click += new System.EventHandler(this.Button3_Click);
            // 
            // desbloquear
            // 
            this.desbloquear.BackColor = System.Drawing.Color.Brown;
            this.desbloquear.Enabled = false;
            this.desbloquear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.desbloquear.Location = new System.Drawing.Point(358, 602);
            this.desbloquear.Name = "desbloquear";
            this.desbloquear.Size = new System.Drawing.Size(190, 42);
            this.desbloquear.TabIndex = 34;
            this.desbloquear.Text = "DESBLOQUEAR";
            this.desbloquear.UseVisualStyleBackColor = false;
            this.desbloquear.Click += new System.EventHandler(this.Button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.estad);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.direccio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cargo);
            this.panel1.Controls.Add(this.telefono);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.usuari);
            this.panel1.Controls.Add(this.cedul);
            this.panel1.Controls.Add(this.apellido);
            this.panel1.Controls.Add(this.contraseñ);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(590, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 515);
            this.panel1.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(36, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 119;
            this.label12.Text = "USUARIO";
            // 
            // estad
            // 
            this.estad.Enabled = false;
            this.estad.Location = new System.Drawing.Point(194, 457);
            this.estad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.estad.Name = "estad";
            this.estad.Size = new System.Drawing.Size(148, 26);
            this.estad.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 117;
            this.label9.Text = "Estado";
            // 
            // direccio
            // 
            this.direccio.Location = new System.Drawing.Point(194, 409);
            this.direccio.Name = "direccio";
            this.direccio.Size = new System.Drawing.Size(304, 26);
            this.direccio.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 115;
            this.label5.Text = "Dirección";
            // 
            // cargo
            // 
            this.cargo.Enabled = false;
            this.cargo.FormattingEnabled = true;
            this.cargo.Items.AddRange(new object[] {
            "Gerente",
            "Administrador de Galpón"});
            this.cargo.Location = new System.Drawing.Point(194, 140);
            this.cargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(247, 28);
            this.cargo.TabIndex = 114;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(194, 357);
            this.telefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(148, 26);
            this.telefono.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(33, 362);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 112;
            this.label11.Text = "Teléfono";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(194, 195);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(304, 26);
            this.nombre.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(33, 206);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 110;
            this.label10.Text = "Nombre";
            // 
            // usuari
            // 
            this.usuari.Location = new System.Drawing.Point(194, 5);
            this.usuari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usuari.Name = "usuari";
            this.usuari.Size = new System.Drawing.Size(304, 26);
            this.usuari.TabIndex = 109;
            // 
            // cedul
            // 
            this.cedul.Enabled = false;
            this.cedul.Location = new System.Drawing.Point(194, 302);
            this.cedul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cedul.Name = "cedul";
            this.cedul.Size = new System.Drawing.Size(304, 26);
            this.cedul.TabIndex = 108;
            // 
            // apellido
            // 
            this.apellido.Enabled = false;
            this.apellido.Location = new System.Drawing.Point(194, 251);
            this.apellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(304, 26);
            this.apellido.TabIndex = 107;
            // 
            // contraseñ
            // 
            this.contraseñ.Location = new System.Drawing.Point(194, 69);
            this.contraseñ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contraseñ.Name = "contraseñ";
            this.contraseñ.Size = new System.Drawing.Size(304, 26);
            this.contraseñ.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(33, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 105;
            this.label8.Text = "Cédula";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(36, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 104;
            this.label7.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(36, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(36, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "CONTRASEÑA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(36, -20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 101;
            this.label6.Text = "USUARIO";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 135);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 24);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "RESETEAR";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.RadioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(315, 135);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(158, 24);
            this.radioButton2.TabIndex = 37;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DESBLOQUEAR";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.RadioButton2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(886, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 38;
            // 
            // resetear_desbloquear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.desbloquear);
            this.Controls.Add(this.resetear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "resetear_desbloquear";
            this.Size = new System.Drawing.Size(1234, 649);
            this.Load += new System.EventHandler(this.Resetear_desbloquear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button resetear;
        private System.Windows.Forms.Button desbloquear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox estad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox direccio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cargo;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox usuari;
        private System.Windows.Forms.TextBox cedul;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox contraseñ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
