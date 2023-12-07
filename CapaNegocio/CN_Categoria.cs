using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objCD_Categoria = new CD_Categoria();

        public List<Categoria> Listar()
        {
            return objCD_Categoria.Listar();
        }

        public int Registrar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje += "Descripcion de Categoria requerido\n";
            }


            if (string.IsNullOrEmpty(Mensaje))
            {
                return objCD_Categoria.Registrar(obj, out Mensaje);
            }

            return 0;
        }


        public bool Editar(Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje += "Descripcion de Categoria requerido\n";
            }


            if (string.IsNullOrEmpty(Mensaje))
            {
                return objCD_Categoria.Editar(obj, out Mensaje);
            }

            return false;

        }
        public bool Eliminar(Categoria obj, out string Mensaje)
        {
            return objCD_Categoria.Eliminar(obj, out Mensaje);
        }

    }
}
