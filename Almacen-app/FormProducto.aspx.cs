using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;

namespace Almacen_app
{
    public partial class FormProducto : System.Web.UI.Page
    {
        public bool confirmaEliminacion { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            confirmaEliminacion = false;
            txtId.Enabled = false;
            try
            {
                if (!IsPostBack)
                {
                    MaderaNegocio negocioMadera = new MaderaNegocio();
                    CategoriaNegocio negocioCategoria = new CategoriaNegocio();
                    List<Madera> listaMadera = negocioMadera.listar();
                    List<Categoria> listaCategoria = negocioCategoria.listar();
                    ddlMadera.DataSource = listaMadera;
                    ddlMadera.DataValueField = "Id";
                    ddlMadera.DataTextField = "Descripcion";
                    ddlMadera.DataBind();

                    ddlCategoria.DataSource = listaCategoria;
                    ddlCategoria.DataValueField = "Id";
                    ddlCategoria.DataTextField = "Descripcion";
                    ddlCategoria.DataBind();
                }
                string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
                if(id != "" && !IsPostBack)
                {
                    ProductoNegocio negocio = new ProductoNegocio();
                    Producto seleccionado = (negocio.SelectItemFromId(id))[0];
                    txtId.Text = seleccionado.Id.ToString();
                    txtNombre.Text = seleccionado.Nombre;
                    txtDescripcion.Text = seleccionado.Descripcion;
                    txtPrecio.Text = seleccionado.Precio.ToString();
                    txtUrlImagen.Text = seleccionado.UrlImagen;
                    ddlCategoria.SelectedValue = seleccionado.Categoria.Id.ToString();
                    ddlMadera.SelectedValue = seleccionado.Madera.Id.ToString();
                    txtUrlImagen_TextChanged(sender, e);
                    btnAceptar.Text = "Modificar";
                    btnEliminar.Visible = true;
                    txtId.Visible = true;
                    lblId.Visible = true;
                }
            }
            catch(Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevo = new Producto();
                ProductoNegocio negocio = new ProductoNegocio();
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.UrlImagen = txtUrlImagen.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);
                nuevo.Madera = new Madera();
                nuevo.Madera.Id = int.Parse(ddlMadera.SelectedValue);
                nuevo.Categoria = new Categoria();
                nuevo.Categoria.Id = int.Parse(ddlCategoria.SelectedValue);
                
                if(Request.QueryString["id"] != null)
                {
                    nuevo.Id = int.Parse(Request.QueryString["id"].ToString());
                    negocio.modificarSP(nuevo);
                }
                else
                    negocio.agregarSP(nuevo);
                Response.Redirect("PanelDeControl.aspx", false);
            }
            catch(Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }

        protected void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            imgProducto.ImageUrl = txtUrlImagen.Text;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            confirmaEliminacion = true;
        }

        protected void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkConfrimaEliminacion.Checked)
                {
                    ProductoNegocio negocio = new ProductoNegocio();
                    negocio.EliminarProducto(int.Parse(txtId.Text));
                    Response.Redirect("PanelDeControl.aspx", false);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}