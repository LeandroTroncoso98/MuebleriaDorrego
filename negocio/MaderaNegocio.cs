using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MaderaNegocio
    {
        public List<Madera> listar()
        {
            List<Madera> lista = new List<Madera>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Select Id, Descripcion from Madera");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Madera aux = new Madera();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (String)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
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
