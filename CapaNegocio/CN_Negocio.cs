using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        private CD_Negocio objcd_Negocio = new CD_Negocio();

        public Negocio ObtenerDatos()
        {
            return objcd_Negocio.ObtenerDatos();
        }

        public bool GuardarDatos(Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Nombre))
            {
                Mensaje += "Documento de Negocio requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Ruc))
            {
                Mensaje += "Nombre de Negocio requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Direccion))
            {
                Mensaje += "Clave de Negocio requerido\n";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {
                return objcd_Negocio.GuardarDatos(obj, out Mensaje);
            }

            return false;
        }

        public byte[] obtenerlogo(out bool obtenido)
        {
            return objcd_Negocio.obtenerlogo(out obtenido);
        }

        public bool actualizarlogo(byte[] imagen,out string mensaje)
        {
            return objcd_Negocio.actualizarlogo(imagen,out mensaje);
        }


    }
}
