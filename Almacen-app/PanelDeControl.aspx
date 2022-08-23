<%@ Page Title="" Language="C#" MasterPageFile="~/Personal.Master" AutoEventWireup="true" CodeBehind="PanelDeControl.aspx.cs" Inherits="Almacen_app.PanelDeControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <asp:GridView ID="dgvProducto" runat="server" CssClass="table table-hover table-active mt-5" DataKeyNames="Id" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvProducto_SelectedIndexChanged" OnPageIndexChanging="dgvProducto_PageIndexChanging" AllowPaging="true" PageSize="10" HeaderStyle-CssClass="table-dark" RowStyle-CssClass="table-light">
                    <Columns>
                        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                        <asp:BoundField HeaderText="Precío" DataField="Precio" />
                        <asp:BoundField HeaderText="Tipo" DataField="Madera" />
                        <asp:BoundField HeaderText="Categoria" DataField="Categoria" />
                        <asp:CommandField HeaderText="Acciones" ShowSelectButton="true" SelectText="Seleccionar" ControlStyle-CssClass="text-decoration-none btn btn-primary" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <div class="row">
            <div class="col-3 col-md-4">
                <h6 class="text-secondary text-center display-6">Filtrar: </h6>
            </div>
            <div class="col-9 mt-2 col-md-8">
                <asp:TextBox runat="server" CssClass="form-control mb-5" ID="txtFiltro" AutoPostBack="true" OnTextChanged="txtFiltro_TextChanged"></asp:TextBox>
            </div>
        </div>
    </div>
</asp:Content>
