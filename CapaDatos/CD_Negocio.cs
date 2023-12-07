using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio ObtenerDatos()
        {
            Negocio obj = new Negocio();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    string query = "select IdNegocio,Nombre,RUC,Direccion from negocio";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            obj = new Negocio()
                            {
                                IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                Ruc = dr["RUC"].ToString(),
                                Direccion = dr["Direccion"].ToString()
                            };
                        }
                    }
                }
            }
            catch
            {
                obj = new Negocio();
            }

            return obj;

        }


        public bool GuardarDatos(Negocio objeto,out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update NEGOCIO set Nombre = @nombre,");
                    query.AppendLine("RUC = @ruc,");
                    query.AppendLine("Direccion = @direccion");
                    query.AppendLine("where IdNegocio = 1");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@ruc", objeto.Ruc);
                    cmd.Parameters.AddWithValue("@direccion", objeto.Direccion);
                    cmd.CommandType = CommandType.Text;


                    if(cmd.ExecuteNonQuery () < 1)
                    {
                        mensaje = "ERROR AL GUARDAR LOS DATOS";
                    }
                }
            }
            catch(Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }

        public byte[] obtenerlogo(out bool obtenido)
        {
            obtenido = true;
            byte[] logobyte = new byte[0];

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    string query = "select Logo from NEGOCIO where IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            logobyte = (Byte[])dr["Logo"];
                        }
                    }
                }
            }
            catch
            {
                obtenido = false;
                logobyte = new byte[0];
            }
            return logobyte;
        }

        public bool actualizarlogo(byte[] image, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update NEGOCIO set Logo = @imagen");
                    query.AppendLine("where IdNegocio = 1");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@imagen", image);
                    cmd.CommandType = CommandType.Text;


                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "ERROR AL GUARDAR LOS DATOS";
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;
            }
            return respuesta;
        }



    }
}
