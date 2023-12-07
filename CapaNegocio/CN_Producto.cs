﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private CD_Producto objcd_Producto = new CD_Producto();

        public List<Producto> Listar()
        {
            return objcd_Producto.Listar();
        }

        public int Registrar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Codigo))
            {
                Mensaje += "Codigo de Producto requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Nombre))
            {
                Mensaje += "Nombre de Producto requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje += "Descripcion de Producto requerido\n";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {
                return objcd_Producto.Registrar(obj, out Mensaje);
            }

            return 0;
        }


        public bool Editar(Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.Codigo))
            {
                Mensaje += "Codigo de Producto requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Nombre))
            {
                Mensaje += "Nombre de Producto requerido\n";
            }

            if (string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                Mensaje += "Descripcion de Producto requerido\n";
            }

            if (string.IsNullOrEmpty(Mensaje))
            {
                return objcd_Producto.Editar(obj, out Mensaje);
            }

            return false;

        }
        public bool Eliminar(Producto obj, out string Mensaje)
        {
            return objcd_Producto.Eliminar(obj, out Mensaje);
        }

    }
}
