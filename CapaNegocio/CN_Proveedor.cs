using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();

        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Documento))
            {
                Mensaje += "Documento de Proveedor requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Correo))
            {
                Mensaje += "correo de Proveedor requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.RazonSocial))
            {
                Mensaje += "RazonSocial de Proveedor requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Telefono))
            {
                Mensaje += "telefono de Proveedor requerido\n";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {
                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }

            return 0;
        }


        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Documento))
            {
                Mensaje += "Documento de Proveedor requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Correo))
            {
                Mensaje += "Correo de Proveedor requerido\n";
            }

            if(string.IsNullOrWhiteSpace(obj.RazonSocial))
            {
                Mensaje += "RazonSocial de Proveedor requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Telefono))
            {
                Mensaje += "Telefono de Proveedor requerido\n";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {
                return objcd_Proveedor.Editar(obj, out Mensaje);
            }

            return false;

        }
        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            return objcd_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
