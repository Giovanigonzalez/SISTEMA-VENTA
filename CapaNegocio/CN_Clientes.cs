using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
  
        public class CN_Clientes
        {
            private CD_Cliente objcd_Cliente = new CD_Cliente();

            public List<Cliente> Listar()
            {
                return objcd_Cliente.Listar();
            }

            public int Registrar(Cliente obj, out string Mensaje)
            {
                Mensaje = string.Empty;

                if (string.IsNullOrWhiteSpace(obj.Documento))
                {
                    Mensaje += "Documento de Cliente requerido\n";
                }

                if (string.IsNullOrWhiteSpace(obj.NombreCompleto))
                {
                    Mensaje += "Nombre de Cliente requerido\n";
                }

                if (string.IsNullOrWhiteSpace(obj.Correo))
                {
                    Mensaje += "Correo de Cliente requerido\n";
                }

                if (string.IsNullOrEmpty(Mensaje))
                {
                    return objcd_Cliente.Registrar(obj, out Mensaje);
                }

                return 0;
            }


            public bool Editar(Cliente obj, out string Mensaje)
            {
                Mensaje = string.Empty;

                if (string.IsNullOrWhiteSpace(obj.Documento))
                {
                    Mensaje += "Documento de Cliente requerido\n";
                }

                if (string.IsNullOrWhiteSpace(obj.NombreCompleto))
                {
                    Mensaje += "Nombre de Cliente requerido\n";
                }

                if (string.IsNullOrWhiteSpace(obj.Correo))
                {
                    Mensaje += "Correo de Cliente requerido\n";
                }

                if (string.IsNullOrEmpty(Mensaje))
                {
                    return objcd_Cliente.Editar(obj, out Mensaje);
                }

                return false;

            }
            public bool Eliminar(Cliente obj, out string Mensaje)
            {
                return objcd_Cliente.Eliminar(obj, out Mensaje);
            }
        }
    }

