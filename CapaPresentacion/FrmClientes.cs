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

namespace CapaPresentacion
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtdocumento.Clear();
            txtnombrecompleto.Clear();
            txtcorreo.Clear();
            txttelefono.Clear();
            cboestado.SelectedIndex = 0;

            txtdocumento.Select();

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { valor = 1, texto = "Activo" });
            cboestado.Items.Add(new OpcionCombo() { valor = 0, texto = "Inactivo" });
            cboestado.DisplayMember = "texto";
            cboestado.ValueMember = "valor";
            cboestado.SelectedIndex = 0;

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
            List<Cliente> lista = new CN_Clientes().Listar();
            foreach (Cliente item in lista)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdCliente,item.Documento,item.NombreCompleto,item.Correo,item.Telefono,
                item.Estado == true ?1 :0,
                item.Estado == true ? "Activo" : "Inactivo",
            });
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Cliente obj = new Cliente()
            {
                IdCliente = Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Telefono = txttelefono.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).valor) == 1 ? true : false
            };

            if (obj.IdCliente == 0)
            {
                int idgenerado = new CN_Clientes().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"",idgenerado,txtdocumento.Text,txtnombrecompleto.Text,txtcorreo.Text,txttelefono.Text,
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
                bool resultado = new CN_Clientes().Editar(obj, out mensaje);
                if (resultado is true)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["id"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Telefono"].Value = txttelefono.Text;
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar a este Cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Cliente obj = new Cliente()
                    {
                        IdCliente = Convert.ToInt32(txtid.Text)
                    };

                    bool respuesta = new CN_Clientes().Eliminar(obj, out mensaje);

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
                    txtdocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtnombrecompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txttelefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();



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
