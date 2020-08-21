namespace ChickPro_Interfaces
{
    partial class Registro_Envio_de_Pollos
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cantJaulas = new System.Windows.Forms.TextBox();
            this.chofer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codEnvio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cantPollos = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.pesoPromedio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.galpon3 = new System.Windows.Forms.RadioButton();
            this.galpon2 = new System.Windows.Forms.RadioButton();
            this.galpon1 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cantMachDet = new System.Windows.Forms.TextBox();
            this.cantHemDet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Galpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantHembras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantMachos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoPromedio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(864, 536);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 45);
            this.button2.TabIndex = 22;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1007, 536);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "FINALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cantJaulas
            // 
            this.cantJaulas.Location = new System.Drawing.Point(396, 300);
            this.cantJaulas.Margin = new System.Windows.Forms.Padding(4);
            this.cantJaulas.Name = "cantJaulas";
            this.cantJaulas.Size = new System.Drawing.Size(188, 30);
            this.cantJaulas.TabIndex = 20;
            this.cantJaulas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CantJaulas_KeyDown);
            this.cantJaulas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantJaulas_KeyPress);
            // 
            // chofer
            // 
            this.chofer.Location = new System.Drawing.Point(396, 233);
            this.chofer.Margin = new System.Windows.Forms.Padding(4);
            this.chofer.Name = "chofer";
            this.chofer.Size = new System.Drawing.Size(189, 30);
            this.chofer.TabIndex = 17;
            this.chofer.TextChanged += new System.EventHandler(this.Chofer_TextChanged);
            this.chofer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chofer_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cantidad de Jaulas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha de Envío";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Código de Envío";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registro Envío de Pollos";
            // 
            // codEnvio
            // 
            this.codEnvio.Enabled = false;
            this.codEnvio.Location = new System.Drawing.Point(397, 121);
            this.codEnvio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codEnvio.Name = "codEnvio";
            this.codEnvio.Size = new System.Drawing.Size(187, 30);
            this.codEnvio.TabIndex = 24;
            this.codEnvio.TextChanged += new System.EventHandler(this.TextBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(178, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nombre del Chofer";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(396, 174);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 28);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad total de Pollos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Peso Neto de Envío";
            // 
            // cantPollos
            // 
            this.cantPollos.Enabled = false;
            this.cantPollos.Location = new System.Drawing.Point(288, 299);
            this.cantPollos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cantPollos.Name = "cantPollos";
            this.cantPollos.Size = new System.Drawing.Size(133, 26);
            this.cantPollos.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(288, 346);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(133, 26);
            this.textBox6.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.cantPollos);
            this.panel1.Controls.Add(this.pesoPromedio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.galpon3);
            this.panel1.Controls.Add(this.galpon2);
            this.panel1.Controls.Add(this.galpon1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cantMachDet);
            this.panel1.Controls.Add(this.cantHemDet);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(648, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 467);
            this.panel1.TabIndex = 33;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CadetBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(288, 401);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 38);
            this.button5.TabIndex = 13;
            this.button5.Text = "INGRESAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // pesoPromedio
            // 
            this.pesoPromedio.Location = new System.Drawing.Point(289, 247);
            this.pesoPromedio.Margin = new System.Windows.Forms.Padding(4);
            this.pesoPromedio.Name = "pesoPromedio";
            this.pesoPromedio.Size = new System.Drawing.Size(132, 26);
            this.pesoPromedio.TabIndex = 11;
            this.pesoPromedio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PesoPromedio_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(137, 253);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Peso promedio";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(289, 204);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(132, 26);
            this.textBox9.TabIndex = 9;
            this.textBox9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TextBox9_MouseMove);
            this.textBox9.TextChanged += new System.EventHandler(this.TextBox9_TextChanged);
            this.textBox9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextBox9_MouseMove);
            // 
            // galpon3
            // 
            this.galpon3.AutoSize = true;
            this.galpon3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galpon3.Location = new System.Drawing.Point(346, 65);
            this.galpon3.Margin = new System.Windows.Forms.Padding(4);
            this.galpon3.Name = "galpon3";
            this.galpon3.Size = new System.Drawing.Size(107, 24);
            this.galpon3.TabIndex = 8;
            this.galpon3.TabStop = true;
            this.galpon3.Text = "Galpón 3";
            this.galpon3.UseVisualStyleBackColor = true;
            // 
            // galpon2
            // 
            this.galpon2.AutoSize = true;
            this.galpon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galpon2.Location = new System.Drawing.Point(186, 65);
            this.galpon2.Margin = new System.Windows.Forms.Padding(4);
            this.galpon2.Name = "galpon2";
            this.galpon2.Size = new System.Drawing.Size(102, 24);
            this.galpon2.TabIndex = 7;
            this.galpon2.TabStop = true;
            this.galpon2.Text = "Galpón2";
            this.galpon2.UseVisualStyleBackColor = true;
            // 
            // galpon1
            // 
            this.galpon1.AutoSize = true;
            this.galpon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.galpon1.Location = new System.Drawing.Point(34, 65);
            this.galpon1.Margin = new System.Windows.Forms.Padding(4);
            this.galpon1.Name = "galpon1";
            this.galpon1.Size = new System.Drawing.Size(107, 24);
            this.galpon1.TabIndex = 6;
            this.galpon1.TabStop = true;
            this.galpon1.Text = "Galpón 1";
            this.galpon1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(156, 204);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Subtotal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(166, 23);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(193, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Detalle Envío de Pollos";
            // 
            // cantMachDet
            // 
            this.cantMachDet.Location = new System.Drawing.Point(289, 160);
            this.cantMachDet.Margin = new System.Windows.Forms.Padding(4);
            this.cantMachDet.Name = "cantMachDet";
            this.cantMachDet.Size = new System.Drawing.Size(132, 26);
            this.cantMachDet.TabIndex = 3;
            this.cantMachDet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantMachDet_KeyPress);
            // 
            // cantHemDet
            // 
            this.cantHemDet.Location = new System.Drawing.Point(289, 120);
            this.cantHemDet.Margin = new System.Windows.Forms.Padding(4);
            this.cantHemDet.Name = "cantHemDet";
            this.cantHemDet.Size = new System.Drawing.Size(132, 26);
            this.cantHemDet.TabIndex = 2;
            this.cantHemDet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantHemDet_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(92, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cantidad de Machos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 124);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cantidad de Hembras";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Galpon,
            this.CantHembras,
            this.CantMachos,
            this.Subtotal,
            this.pesoPromedio1});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(34, 408);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(606, 109);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Galpon
            // 
            this.Galpon.HeaderText = "Galpon";
            this.Galpon.MinimumWidth = 8;
            this.Galpon.Name = "Galpon";
            this.Galpon.ReadOnly = true;
            this.Galpon.Width = 150;
            // 
            // CantHembras
            // 
            this.CantHembras.HeaderText = "Cant Hembras";
            this.CantHembras.MinimumWidth = 8;
            this.CantHembras.Name = "CantHembras";
            this.CantHembras.ReadOnly = true;
            this.CantHembras.Width = 150;
            // 
            // CantMachos
            // 
            this.CantMachos.HeaderText = "CantMachos";
            this.CantMachos.MinimumWidth = 8;
            this.CantMachos.Name = "CantMachos";
            this.CantMachos.ReadOnly = true;
            this.CantMachos.Width = 150;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 8;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 150;
            // 
            // pesoPromedio1
            // 
            this.pesoPromedio1.HeaderText = "PesoPromedio";
            this.pesoPromedio1.MinimumWidth = 8;
            this.pesoPromedio1.Name = "pesoPromedio1";
            this.pesoPromedio1.ReadOnly = true;
            this.pesoPromedio1.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "kg";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(428, 346);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "kg";
            // 
            // Registro_Envio_de_Pollos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChickPro_Interfaces.Properties.Resources.BackgroundBLUE1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.codEnvio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cantJaulas);
            this.Controls.Add(this.chofer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro_Envio_de_Pollos";
            this.Size = new System.Drawing.Size(1182, 620);
            this.Load += new System.EventHandler(this.Registro_Envio_de_Pollos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cantJaulas;
        private System.Windows.Forms.TextBox chofer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codEnvio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cantPollos;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pesoPromedio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.RadioButton galpon3;
        private System.Windows.Forms.RadioButton galpon2;
        private System.Windows.Forms.RadioButton galpon1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cantMachDet;
        private System.Windows.Forms.TextBox cantHemDet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Galpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantHembras;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantMachos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoPromedio1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
    }
}
