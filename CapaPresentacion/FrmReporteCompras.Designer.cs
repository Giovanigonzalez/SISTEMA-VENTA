namespace CapaPresentacion
{
    partial class FrmReporteCompras
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtfechainicio = new System.Windows.Forms.DateTimePicker();
            this.txtfechafin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnbuscarresultado = new FontAwesome.Sharp.IconButton();
            this.cboproveedor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btndescargar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(854, 68);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporte Compras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha inicio";
            // 
            // txtfechainicio
            // 
            this.txtfechainicio.CustomFormat = "dd/MM/yyyy";
            this.txtfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechainicio.Location = new System.Drawing.Point(85, 45);
            this.txtfechainicio.Name = "txtfechainicio";
            this.txtfechainicio.Size = new System.Drawing.Size(96, 20);
            this.txtfechainicio.TabIndex = 4;
            // 
            // txtfechafin
            // 
            this.txtfechafin.CustomFormat = "dd/MM/yyyy";
            this.txtfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfechafin.Location = new System.Drawing.Point(250, 44);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.Size = new System.Drawing.Size(96, 20);
            this.txtfechafin.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(196, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha fin";
            // 
            // btnbuscarresultado
            // 
            this.btnbuscarresultado.BackColor = System.Drawing.Color.White;
            this.btnbuscarresultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscarresultado.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscarresultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarresultado.ForeColor = System.Drawing.Color.White;
            this.btnbuscarresultado.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.btnbuscarresultado.IconColor = System.Drawing.Color.Black;
            this.btnbuscarresultado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscarresultado.IconSize = 16;
            this.btnbuscarresultado.Location = new System.Drawing.Point(584, 44);
            this.btnbuscarresultado.Name = "btnbuscarresultado";
            this.btnbuscarresultado.Size = new System.Drawing.Size(47, 23);
            this.btnbuscarresultado.TabIndex = 56;
            this.btnbuscarresultado.UseVisualStyleBackColor = false;
            this.btnbuscarresultado.Click += new System.EventHandler(this.btnbuscarresultado_Click_1);
            // 
            // cboproveedor
            // 
            this.cboproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboproveedor.FormattingEnabled = true;
            this.cboproveedor.Location = new System.Drawing.Point(417, 44);
            this.cboproveedor.Name = "cboproveedor";
            this.cboproveedor.Size = new System.Drawing.Size(161, 21);
            this.cboproveedor.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(357, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "proveedor:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(854, 307);
            this.label5.TabIndex = 57;
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
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoProveedor,
            this.RazonSocial,
            this.CodigoProducto,
            this.NombreProducto,
            this.Categoria,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdata.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdata.Location = new System.Drawing.Point(21, 140);
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
            this.dgvdata.Size = new System.Drawing.Size(829, 220);
            this.dgvdata.TabIndex = 58;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 150;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registro";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            // 
            // DocumentoProveedor
            // 
            this.DocumentoProveedor.HeaderText = "Documento Proveedor";
            this.DocumentoProveedor.Name = "DocumentoProveedor";
            this.DocumentoProveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "RazonSocial";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
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
            this.btnbuscar.Location = new System.Drawing.Point(748, 98);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 23);
            this.btnbuscar.TabIndex = 62;
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
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(801, 98);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(47, 23);
            this.btnlimpiarbuscador.TabIndex = 63;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            this.btnlimpiarbuscador.Click += new System.EventHandler(this.btnlimpiarbuscador_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(603, 101);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(130, 20);
            this.txtbusqueda.TabIndex = 61;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(436, 100);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(161, 21);
            this.cbobusqueda.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(376, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Buscar por: ";
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
            this.btndescargar.Location = new System.Drawing.Point(21, 92);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(134, 36);
            this.btndescargar.TabIndex = 66;
            this.btndescargar.Text = "Descargar Exel";
            this.btndescargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndescargar.UseVisualStyleBackColor = false;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // FrmReporteCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 398);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbobusqueda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnbuscarresultado);
            this.Controls.Add(this.cboproveedor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtfechafin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtfechainicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmReporteCompras";
            this.Text = "FrmReporteCompras";
            this.Load += new System.EventHandler(this.FrmReporteCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtfechainicio;
        private System.Windows.Forms.DateTimePicker txtfechafin;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnbuscarresultado;
        private System.Windows.Forms.ComboBox cboproveedor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btndescargar;
    }
}