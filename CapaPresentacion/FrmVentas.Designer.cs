namespace CapaPresentacion
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbotipodocumento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdoccliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnbuscarproducto = new FontAwesome.Sharp.IconButton();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnagregar = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btneliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtpagacon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnregistrar = new FontAwesome.Sharp.IconButton();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(827, 423);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registro Venta";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cbotipodocumento);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtfecha);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(43, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 75);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Venta";
            // 
            // cbotipodocumento
            // 
            this.cbotipodocumento.FormattingEnabled = true;
            this.cbotipodocumento.Location = new System.Drawing.Point(167, 43);
            this.cbotipodocumento.Name = "cbotipodocumento";
            this.cbotipodocumento.Size = new System.Drawing.Size(175, 21);
            this.cbotipodocumento.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tipo Documento";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(9, 43);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(145, 20);
            this.txtfecha.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtnombrecliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdoccliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(418, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 75);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion deCliente";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 16;
            this.btnbuscar.Location = new System.Drawing.Point(142, 42);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(32, 20);
            this.btnbuscar.TabIndex = 59;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(184, 42);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(204, 20);
            this.txtnombrecliente.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nombre Completo";
            // 
            // txtdoccliente
            // 
            this.txtdoccliente.Location = new System.Drawing.Point(9, 43);
            this.txtdoccliente.Name = "txtdoccliente";
            this.txtdoccliente.Size = new System.Drawing.Size(127, 20);
            this.txtdoccliente.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Numero de Documento";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtcantidad);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtstock);
            this.groupBox2.Controls.Add(this.txtprecio);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtidproducto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnbuscarproducto);
            this.groupBox2.Controls.Add(this.txtproducto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtcodproducto);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(43, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 75);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion de Producto";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(520, 42);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(120, 20);
            this.txtcantidad.TabIndex = 31;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(517, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Cantidad";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(440, 42);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(65, 20);
            this.txtstock.TabIndex = 28;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(351, 42);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(73, 20);
            this.txtprecio.TabIndex = 28;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Stock";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(100, 19);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(24, 20);
            this.txtidproducto.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Precio ";
            // 
            // btnbuscarproducto
            // 
            this.btnbuscarproducto.BackColor = System.Drawing.Color.White;
            this.btnbuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarproducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarproducto.ForeColor = System.Drawing.Color.White;
            this.btnbuscarproducto.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.btnbuscarproducto.IconColor = System.Drawing.Color.Black;
            this.btnbuscarproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarproducto.IconSize = 16;
            this.btnbuscarproducto.Location = new System.Drawing.Point(130, 43);
            this.btnbuscarproducto.Name = "btnbuscarproducto";
            this.btnbuscarproducto.Size = new System.Drawing.Size(29, 19);
            this.btnbuscarproducto.TabIndex = 26;
            this.btnbuscarproducto.UseVisualStyleBackColor = false;
            this.btnbuscarproducto.Click += new System.EventHandler(this.btnbuscarproducto_Click);
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(182, 42);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(149, 20);
            this.txtproducto.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Producto";
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.Location = new System.Drawing.Point(9, 43);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.Size = new System.Drawing.Size(115, 20);
            this.txtcodproducto.TabIndex = 25;
            this.txtcodproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodproducto_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cod. Producto";
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.White;
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnagregar.IconColor = System.Drawing.Color.ForestGreen;
            this.btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregar.IconSize = 30;
            this.btnagregar.Location = new System.Drawing.Point(707, 161);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(99, 75);
            this.btnagregar.TabIndex = 64;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproducto,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal,
            this.btneliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.Location = new System.Drawing.Point(43, 247);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(710, 180);
            this.dgvdata.TabIndex = 65;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // idproducto
            // 
            this.idproducto.HeaderText = "idproducto";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            this.idproducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 150;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btneliminar
            // 
            this.btneliminar.HeaderText = "";
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.ReadOnly = true;
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.Location = new System.Drawing.Point(762, 265);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.Size = new System.Drawing.Size(83, 20);
            this.txttotalpagar.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(759, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Total a Pagar";
            // 
            // txtpagacon
            // 
            this.txtpagacon.Location = new System.Drawing.Point(762, 314);
            this.txtpagacon.Name = "txtpagacon";
            this.txtpagacon.Size = new System.Drawing.Size(83, 20);
            this.txtpagacon.TabIndex = 66;
            this.txtpagacon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpagacon_KeyDown);
            this.txtpagacon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpagacon_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(759, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 67;
            this.label13.Text = "Paga Con:";
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(762, 363);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(83, 20);
            this.txtcambio.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(759, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "Cambio";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.White;
            this.btnregistrar.ForeColor = System.Drawing.Color.Black;
            this.btnregistrar.IconChar = FontAwesome.Sharp.IconChar.SdCard;
            this.btnregistrar.IconColor = System.Drawing.Color.DeepSkyBlue;
            this.btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistrar.IconSize = 20;
            this.btnregistrar.Location = new System.Drawing.Point(759, 391);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(86, 36);
            this.btnregistrar.TabIndex = 70;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 449);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtpagacon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txttotalpagar);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbotipodocumento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdoccliente;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnbuscarproducto;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnagregar;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btneliminar;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtpagacon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label14;
        private FontAwesome.Sharp.IconButton btnregistrar;
    }
}