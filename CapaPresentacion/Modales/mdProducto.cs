using CapaEntidad;
using CapaNegocio;
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

namespace CapaPresentacion.Modales
{
    public partial class mdProducto : Form
    {
        public Producto _Producto { get; set; }
        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "texto";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;

            List<Producto> listaproducto = new CN_Producto().Listar();
            foreach (Producto item in listaproducto)
            {
                dgvdata.Rows.Add(new object[] {
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                });
            }

        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icolumn = e.ColumnIndex;

            if (irow >= 0 && icolumn > 0)
            {
                _Producto = new Producto()
                {
                    IdProducto = Convert.ToInt32(dgvdata.Rows[irow].Cells["Id"].Value.ToString()),
                    Codigo = dgvdata.Rows[irow].Cells["Codigo"].Value.ToString(),
                    Nombre = dgvdata.Rows[irow].Cells["Nombre"].Value.ToString(),
                    Stock = Convert.ToInt32(dgvdata.Rows[irow].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(dgvdata.Rows[irow].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dgvdata.Rows[irow].Cells["PrecioVenta"].Value.ToString())
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbobusqueda.SelectedItem).valor.ToString();
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnafiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

    }
}
