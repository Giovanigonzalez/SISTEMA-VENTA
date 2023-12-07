using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {
            private CD_Usuario objcd_usuario = new CD_Usuario();

            public List<Usuario> Listar()
            {
                return objcd_usuario.Listar();
            }

            public int Registrar(Usuario obj, out string Mensaje)
            {
                Mensaje = string.Empty;

                if (string.IsNullOrWhiteSpace(obj.Documento))
                {
                    Mensaje += "Documento de usuario requerido\n";
                }

                if (string.IsNullOrWhiteSpace(obj.NombreCompleto))
                {
                    Mensaje += "Nombre de usuario requerido\n";
                }

                if (string.IsNullOrWhiteSpace(obj.Clave))
                {
                    Mensaje += "Clave de usuario requerido\n";
                }

                if (string.IsNullOrEmpty(Mensaje))
                {
                    return objcd_usuario.Registrar(obj, out Mensaje);
                }

                return 0;
            }


            public bool Editar(Usuario obj, out string Mensaje)
            {
                Mensaje = string.Empty;

                if (string.IsNullOrWhiteSpace(obj.Documento))
                {
                    Mensaje += "Documento de usuario requerido\n";
                }

                if (string.IsNullOrWhiteSpace(obj.NombreCompleto))
                {
                    Mensaje += "Nombre de usuario requerido\n";
                }

                if (string.IsNullOrWhiteSpace(obj.Clave))
                {
                    Mensaje += "Clave de usuario requerido\n";
                }

                if (string.IsNullOrEmpty(Mensaje))
                {
                    return objcd_usuario.Editar(obj, out Mensaje);
                }

                return false;

            }
            public bool Eliminar(Usuario obj, out string Mensaje)
            {
                return objcd_usuario.Eliminar(obj, out Mensaje);
            }
        }
}
