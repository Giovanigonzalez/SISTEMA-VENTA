using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {

        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuario objusuario)
        {
            usuarioActual = objusuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permiso> ListapPermisos = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = ListapPermisos.Any(m => m.NombreMenu == iconmenu.Name);

                if(encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }


            lblusuario.Text = usuarioActual.NombreCompleto;
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null) {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if(FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            /*CONFIGURAR EL FORMULARIO*/
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            /*INSERTAR EL FORMULARIO*/
            contenedor.Controls.Add(formulario);
            formulario.Show();


        }
        private void menuusuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender,new FrmUsuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new FrmCategoria());
        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new FrmProducto());
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new FrmVentas(usuarioActual));
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new FrmDetalleVenta());
        }

        private void subumenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new FrmCompras(usuarioActual));
        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new FrmDetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProveedores());
        }


        private void submenunegocio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new FrmNegocio());
        }

        private void submenureportecompra_Click(object sender, EventArgs e)
        {
           AbrirFormulario(menureportes, new FrmReporteCompras());
        }

        private void submenureporteventa_Click(object sender, EventArgs e)
        {
           AbrirFormulario(menureportes, new FrmReporteVentas());
        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            mdAcercade md = new mdAcercade();
            md.ShowDialog();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
