using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listarConSP()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("storedListar");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = decimal.Round((decimal)datos.Lector["Precio"], 2);
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Madera = new Madera();
                    aux.Madera.Id = (int)datos.Lector["IdMadera"];
                    aux.Madera.Descripcion = (string)datos.Lector["Madera"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Producto> SelectItemFromId(string id)
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select P.Id, P.Nombre, P.Descripcion,P.IdMadera,M.Descripcion Madera,P.Precio, P.IdCategoria,C.Descripcion Categoria, P.UrlImagen from Producto P, Categoria C, Madera M where P.IdCategoria = C.Id and P.IdMadera = M.Id and P.Id = ", id);
                datos.ejecutarLectura();
                
                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = decimal.Round((decimal)datos.Lector["Precio"], 2);
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Madera = new Madera();
                    aux.Madera.Id = (int)datos.Lector["IdMadera"];
                    aux.Madera.Descripcion = (string)datos.Lector["Madera"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void agregarSP(Producto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearProcedimiento("storedAltaProducto");
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@desc", nuevo.Descripcion);
                datos.setearParametro("@idMadera", nuevo.Madera.Id);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@urlImagen", nuevo.UrlImagen);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void modificarSP(Producto producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("storedModificar");
                datos.setearParametro("@id", producto.Id);
                datos.setearParametro("@nombre", producto.Nombre);
                datos.setearParametro("@desc", producto.Descripcion);
                datos.setearParametro("@idMadera", producto.Madera.Id);
                datos.setearParametro("@precio", producto.Precio);
                datos.setearParametro("@idCategoria", producto.Categoria.Id);
                datos.setearParametro("@urlImagen", producto.UrlImagen);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void EliminarProducto(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("storedEliminarProducto");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }


        }
    }
}
