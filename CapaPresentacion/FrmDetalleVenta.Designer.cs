namespace CapaPresentacion
{
    partial class FrmDetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btndescargar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txtnumerodocumento = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdocumentocliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmontototal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtmontopago = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndescargar
            // 
            this.btndescargar.BackColor = System.Drawing.Color.White;
            this.btndescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndescargar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btndescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndescargar.ForeColor = System.Drawing.Color.Black;
            this.btndescargar.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btndescargar.IconColor = System.Drawing.Color.ForestGreen;
            this.btndescargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btndescargar.IconSize = 16;
            this.btndescargar.Location = new System.Drawing.Point(604, 460);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(134, 36);
            this.btndescargar.TabIndex = 77;
            this.btndescargar.Text = "Descargar PDF";
            this.btndescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(172, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Total a Pagar";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvdata.Location = new System.Drawing.Point(172, 273);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvdata.RowTemplate.Height = 28;
            this.dgvdata.Size = new System.Drawing.Size(566, 180);
            this.dgvdata.TabIndex = 74;
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.Location = new System.Drawing.Point(466, 38);
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Size = new System.Drawing.Size(59, 20);
            this.txtnumerodocumento.TabIndex = 28;
            this.txtnumerodocumento.Visible = false;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(196, 38);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(196, 20);
            this.txtnombrecliente.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nombre del Cliente";
            // 
            // txtdocumentocliente
            // 
            this.txtdocumentocliente.Location = new System.Drawing.Point(10, 39);
            this.txtdocumentocliente.Name = "txtdocumentocliente";
            this.txtdocumentocliente.Size = new System.Drawing.Size(164, 20);
            this.txtdocumentocliente.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Numero de Documento";
            // 
            // txtmontototal
            // 
            this.txtmontototal.Location = new System.Drawing.Point(246, 465);
            this.txtmontototal.Name = "txtmontototal";
            this.txtmontototal.Size = new System.Drawing.Size(69, 20);
            this.txtmontototal.TabIndex = 76;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtnumerodocumento);
            this.groupBox1.Controls.Add(this.txtnombrecliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdocumentocliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(163, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 75);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de Cliente";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(368, 39);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(157, 20);
            this.txtusuario.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Usuario";
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.Location = new System.Drawing.Point(174, 39);
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.Size = new System.Drawing.Size(175, 20);
            this.txttipodocumento.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tipo Documento";
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(10, 40);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(145, 20);
            this.txtfecha.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtusuario);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txttipodocumento);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtfecha);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(163, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 75);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Fecha";
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
            this.btnbuscar.Location = new System.Drawing.Point(604, 56);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 20);
            this.btnbuscar.TabIndex = 70;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 16;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(657, 56);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(47, 20);
            this.btnlimpiarbuscador.TabIndex = 71;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(468, 56);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(130, 20);
            this.txtbusqueda.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(344, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Numero de documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 67;
            this.label2.Text = "Detalle Venta";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 489);
            this.label1.TabIndex = 66;
            // 
            // txtcambio
            // 
            this.txtcambio.Location = new System.Drawing.Point(514, 465);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(83, 20);
            this.txtcambio.TabIndex = 80;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(471, 470);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 81;
            this.label14.Text = "Cambio";
            // 
            // txtmontopago
            // 
            this.txtmontopago.Location = new System.Drawing.Point(379, 465);
            this.txtmontopago.Name = "txtmontopago";
            this.txtmontopago.Size = new System.Drawing.Size(83, 20);
            this.txtmontopago.TabIndex = 78;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(323, 472);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 79;
            this.label13.Text = "Paga Con:";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 120;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 120;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 120;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 120;
            // 
            // FrmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 524);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtmontopago);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.txtmontototal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalleVenta";
            this.Text = "FrmDetalleVenta";
            this.Load += new System.EventHandler(this.FrmDetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btndescargar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.TextBox txtnumerodocumento;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdocumentocliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmontototal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtmontopago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}