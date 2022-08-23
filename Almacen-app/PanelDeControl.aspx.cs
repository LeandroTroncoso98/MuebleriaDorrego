using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;

namespace Almacen_app
{
    public partial class PanelDeControl : System.Web.UI.Page
    {
        public List<Producto> ListaProductos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ProductoNegocio negocio = new ProductoNegocio();
            Session.Add("listaProductos", negocio.listarConSP());
            dgvProducto.DataSource = Session["listaProductos"];
            dgvProducto.DataBind();
        }

        protected void dgvProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = dgvProducto.SelectedDataKey.Value.ToString();
            Response.Redirect("FormProducto.aspx?id=" + id);
        }

        protected void dgvProducto_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvProducto.PageIndex = e.NewPageIndex;
            dgvProducto.DataBind();
        }

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Producto> lista = (List<Producto>)Session["listaProductos"];
            List<Producto> listaFiltrada = lista.FindAll(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper()));
            dgvProducto.DataSource = listaFiltrada;
            dgvProducto.DataBind();
        }

        
    }
}