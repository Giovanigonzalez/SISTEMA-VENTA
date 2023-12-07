using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using CapaPresentacion.utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCompras : Form
    {
        private Usuario _usuario;
        public FrmCompras(Usuario ousuario = null)
        {
            _usuario = ousuario;
            InitializeComponent();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { valor = "Boleta", texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { valor = "Factura", texto = "Factura" });
            cbotipodocumento.DisplayMember = "texto";
            cbotipodocumento.ValueMember = "valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtidproducto.Text = "0";
            txtidproveedor.Text = "0";
        }

        private void btnbuscarproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if(result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtdocproveedor.Text = modal._Proveedor.Documento;
                    txtnombreproveedor.Text = modal._Proveedor.RazonSocial;
                }
                else
                {
                    txtdocproveedor.Select();
                }

            }
        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodproducto.Text = modal._Producto.Codigo;
                    txtproducto.Text = modal._Producto.Nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodproducto.Select();
                }

            }
        }

        private void txtcodproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Producto oproducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodproducto.Text && p.Estado == true).FirstOrDefault();

                if(oproducto != null)
                {
                    txtcodproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oproducto.IdProducto.ToString();
                    txtproducto.Text = oproducto.Nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "0";
                    txtproducto.Text = "";
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool productoexiste = false;

            if(int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("DEBE SELECCIONAR UN PRODUCTO", "Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!decimal.TryParse(txtpreciocompra.Text,out preciocompra))
            {
                MessageBox.Show("PRECIO COMPRA - FORMATO DE MONEDA INCORRECTO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                MessageBox.Show("PRECIO VENTA- FORMATO DE MONEDA INCORRECTO", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(DataGridViewRow fila in dgvdata.Rows )
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    productoexiste = true;
                    break;
                }
            }

            if (!productoexiste)
            {
                dgvdata.Rows.Add(new object[]
                {
                    txtidproducto.Text.ToString(),
                    txtproducto.Text,
                    preciocompra.ToString("0.00"),
                    precioventa.ToString("0.00"),
                    txtcantidad.Value.ToString(),
                    (txtcantidad.Value * preciocompra).ToString("0.00"),
                });

                CalcuarTotal();
                LimpiarProducto();
                txtcodproducto.Select();
            }

        }

        private void LimpiarProducto()
        {
            txtidproducto.Text = "0";
            txtcodproducto.Clear();
            txtcodproducto.BackColor = Color.White;
            txtproducto.Clear();
            txtpreciocompra.Clear();
            txtprecioventa.Clear();
            txtcantidad.Value = 1;
        }

        private void CalcuarTotal()
        {
            decimal total = 0;
            if(dgvdata.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
                }
            }
            txttotalpagar.Text = total.ToString("0.00");
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) { return; }


            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.eliminar.Width;
                var h = Properties.Resources.eliminar.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.eliminar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;
                if(indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    CalcuarTotal();

                }
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && txtpreciocompra.Text.Trim().Length == 0)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && txtpreciocompra.Text.Trim().Length == 0)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtidproveedor.Text) == 0) 
            {
                MessageBox.Show("DEBE SELECCIONAR UN PROVEEDOR", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("DEBE INGRESAR AL MENOS UN PRODUCTO EN LA COMPRA", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            DataTable Detalle_Compra = new DataTable();

            Detalle_Compra.Columns.Add("IdProducto", typeof(int));
            Detalle_Compra.Columns.Add("PrecioCompra", typeof(decimal));
            Detalle_Compra.Columns.Add("PrecioVenta", typeof(decimal));
            Detalle_Compra.Columns.Add("Cantidad", typeof(int));
            Detalle_Compra.Columns.Add("MontoTotal", typeof(decimal));

            foreach(DataGridViewRow row in dgvdata.Rows)
            {
                Detalle_Compra.Rows.Add(new object[]
                {
                    Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                    row.Cells["PrecioCompra"].Value.ToString(),
                    row.Cells["PrecioVenta"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                    row.Cells["SubTotal"].Value.ToString()

                }); ;
            }

            int idcorrelativo = new CN_Compra().obtenercorrelativo();
            string numerodocumento = string.Format("{0:00000}",idcorrelativo);

            Compra ocompra = new Compra()
            {
                oUsuario = new Usuario() { IdUsuario = _usuario.IdUsuario},
                oProveedor = new Proveedor() { IdProveedor = Convert.ToInt32(txtidproveedor.Text) },
                TipoDocumento = ((OpcionCombo)cbotipodocumento.SelectedItem).texto,
                NumeroDocumento = numerodocumento,
                MontoTotal = Convert.ToDecimal(txttotalpagar.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(ocompra, Detalle_Compra,out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada\n" + numerodocumento + "\n\nDesea copiarlo al portapapeles?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numerodocumento);

                txtidproveedor.Text = "0";
                txtdocproveedor.Text = "";
                txtnombreproveedor.Text = "";
                dgvdata.Rows.Clear();
                CalcuarTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
