<%@ Page Title="" Language="C#" MasterPageFile="~/Personal.Master" AutoEventWireup="true" CodeBehind="FormProducto.aspx.cs" Inherits="Almacen_app.FormProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container">
        <div class="row mt-5">
            <div class="col-12 col-md-6">
                <div class="mb-3">
                    <asp:label runat="server" for="txtId" class="form-label" Visible="false" ID="lblId">Id:</asp:label>
                    <asp:TextBox runat="server" ID="txtId" CssClass="form-control" Visible="false"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtNombre" class="form-label">Nombre: </label>
                    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtDescripcion" class="form-label">Descripcíon</label>
                    <asp:TextBox runat="server" TextMode="MultiLine" ID="txtDescripcion" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="txtPrecio" class="form-label">Precio:</label>
                    <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="ddlMadera" class="form-label">Tipo de madera:</label>
                    <asp:DropDownList ID="ddlMadera" CssClass="form-select" runat="server"></asp:DropDownList>
                </div>
                <div class="mb-3">
                    <label for="ddlCategoria" class="form-label">Categoría:</label>
                    <asp:DropDownList ID="ddlCategoria" CssClass="form-select" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="col-12 col-md-6">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="mb-3">
                            <label for="txtUrlImagen" class="form-label">Url de la imagen: </label>
                            <asp:TextBox runat="server" CssClass="form-control" AutoPostBack="true" ID="txtUrlImagen" OnTextChanged="txtUrlImagen_TextChanged"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <asp:Image ImageUrl="https://grupoact.com.ar/wp-content/uploads/2020/04/placeholder.png" runat="server" ID="imgProducto" Width="60%" />
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
            <updatepanel id="UpdatePanel2" runate="server">
                <contenttemplate>
                    <div class="col-12 col-md-3">
                        <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-success mb-2" OnClick="btnAceptar_Click" runat="server" />
                        <a class="btn btn-secondary text-decoration-none mb-2" href="PanelDeControl.aspx">Cancelar</a>
                        <asp:Button Text="Eliminar" ID="btnEliminar" CssClass="btn btn-outline-danger mb-2" OnClick="btnEliminar_Click" runat="server" Visible="true" />
                    </div>

                    <%if (confirmaEliminacion)
                        {%>
                    <div class="col-md-4 col-12 border border-danger justify-content-between p-2 mb-2 bg-light">
                        <asp:CheckBox Text="Confirma eliminar el producto" ID="chkConfrimaEliminacion" runat="server" CssClass="mb-2" />
                        <asp:Button Text="Eliminar producto" ID="btnConfirmarEliminacion" OnClick="btnConfirmarEliminacion_Click" CssClass="btn btn-danger mb-2" runat="server" />
                    </div>
                    <%}%>
                </contenttemplate>
            </updatepanel>
        </div>
    </div>
</asp:Content>
