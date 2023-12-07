using CapaNegocio;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmNegocio : Form
    {
        public FrmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imagebyte)
        {
            MemoryStream sm = new MemoryStream();
            sm.Write(imagebyte, 0, imagebyte.Length);

            Image image = new Bitmap(sm);
            return image;
        }

        private void FrmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimagen = new CN_Negocio().obtenerlogo(out obtenido);

            if (obtenido)
                piclogo.Image = ByteToImage(byteimagen);


            Negocio datos = new CN_Negocio().ObtenerDatos();

            txtnombre.Text = datos.Nombre;
            txtruc.Text = datos.Ruc;
            txtdireccion.Text = datos.Direccion;
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oopenFileDialog = new OpenFileDialog();
            oopenFileDialog.FileName = "Files|*.jpg;*.jpng;*.png";

            if(oopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(oopenFileDialog.FileName);
                bool respuesta = new CN_Negocio().actualizarlogo(byteimage,out mensaje);

                if(respuesta)
                    piclogo.Image = ByteToImage(byteimage);
                else
                    MessageBox.Show(mensaje,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            Negocio obj = new Negocio()
            {
                Nombre = txtnombre.Text,
                Ruc = txtruc.Text,
                Direccion = txtdireccion.Text
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if(respuesta)
                MessageBox.Show("LOS DATOS FUERON GUARDADOS", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("ERROR AL GURDAR LOS DATOS", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
