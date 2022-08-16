using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace Almacen_app
{
    public partial class NuestrosProductos : System.Web.UI.Page
    {
        public List<Producto> ListaProductos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            ListaProductos = negocio.listarConSP();
            if (!IsPostBack)
            {
                repRepetidor.DataSource = ListaProductos;
                repRepetidor.DataBind();
            }

        }
    }
}