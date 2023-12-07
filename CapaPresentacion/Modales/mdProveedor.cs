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
    public partial class mdProveedor : Form
    {

        public Proveedor _Proveedor { get; set; }
        public mdProveedor()
        {
            InitializeComponent();
        }

        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true) //&& columna.Name != "btnseleccionar"
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { valor = columna.Name, texto = columna.HeaderText });
                }
            }

            cbobusqueda.DisplayMember = "texto";
            cbobusqueda.ValueMember = "valor";
            cbobusqueda.SelectedIndex = 0;


            //LLENAR DATAGRID DE proveedores
            List<Proveedor> lista = new CN_Proveedor().Listar();
            foreach (Proveedor item in lista)
            {
                dgvdata.Rows.Add(new object[] {item.IdProveedor,item.Documento,item.RazonSocial
            });
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int irow = e.RowIndex;
            int icolumn = e.ColumnIndex;

            if(irow >=0 && icolumn > 0)
            {
                _Proveedor = new Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgvdata.Rows[irow].Cells["Id"].Value.ToString()),
                    Documento = dgvdata.Rows[irow].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvdata.Rows[irow].Cells["RazonSocial"].Value.ToString()
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
