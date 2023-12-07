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
using ClosedXML.Excel;

namespace CapaPresentacion
{
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtcodigo.Clear();
            txtnombre.Clear();
            txtdescripcion.Clear();
            cbocategoria.SelectedIndex = 0;
            cboestado.SelectedIndex = 0;

            txtcodigo.Select();

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { valor = 0, texto = "Inactivo" });
            cboestado.DisplayMember = "texto";
            cboestado.ValueMember = "valor";
            cboestado.SelectedIndex = 0;

            List<Categoria> ListaCategoria = new CN_Categoria().Listar();
            foreach (Categoria item in ListaCategoria)
            {
                cbocategoria.Items.Add(new OpcionCombo() { valor = item.IdCategoria, texto = item.Descripcion });
            }
            cbocategoria.DisplayMember = "texto";
            cbocategoria.ValueMember = "valor";
            cbocategoria.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "texto";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;

            //LLENAR DATAGRID DE USUARIOS
            List<Producto> listaproducto = new CN_Producto().Listar();
            foreach (Producto item in listaproducto)
            {
                dgvdata.Rows.Add(new object[] {"",
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.oCategoria.IdCategoria,
                    item.oCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Estado == true ?1 :0,
                    item.Estado == true ? "Activo" : "Inactivo",
            });
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Producto objproducto = new Producto()
            {
                IdProducto = Convert.ToInt32(txtid.Text),
                Codigo = txtcodigo.Text,
                Nombre = txtnombre.Text,
                Descripcion = txtdescripcion.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria.SelectedItem).valor) },
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).valor) == 1 ? true : false
            };

            if (objproducto.IdProducto == 0)
            {
                int idgenerado = new CN_Producto().Registrar(objproducto, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"",idgenerado,txtcodigo.Text,txtnombre.Text,txtdescripcion.Text,
                    ((OpcionCombo)cbocategoria.SelectedItem).valor.ToString(),
                    ((OpcionCombo)cbocategoria.SelectedItem).texto.ToString(),
                    "0",
                    "0.00",
                    "0.00",
                    ((OpcionCombo)cboestado.SelectedItem).valor.ToString(),
                    ((OpcionCombo)cboestado.SelectedItem).texto.ToString(),
                });
                    limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Producto().Editar(objproducto, out mensaje);
                if (resultado is true)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["Codigo"].Value = txtcodigo.Text;
                    row.Cells["Nombre"].Value = txtnombre.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbocategoria.SelectedItem).texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).texto.ToString();

                    limpiar();

                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) { return; }


            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["id"].Value.ToString();
                    txtcodigo.Text = dgvdata.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtnombre.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtdescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();


                    foreach (OpcionCombo oc in cbocategoria.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = cbocategoria.Items.IndexOf(oc);
                            cbocategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in cboestado.Items)
                    {
                        if (Convert.ToInt32(oc.valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(oc);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }

            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar este Producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto objProducto = new Producto()
                    {
                        IdProducto = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Producto().Eliminar(objProducto, out mensaje);

                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                limpiar();

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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay documentos para importar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn colum in dgvdata.Columns)
                {
                    if (colum.HeaderText != "" && colum.Visible)
                    {
                        dt.Columns.Add(colum.HeaderText, typeof(string));
                    }
                }

                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[11].Value.ToString()
                        }

                            );
                    }
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Reporte de producto_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Exel Files | *.xlsx";
                if(savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt,"Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al Generar Reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }







    }
}
