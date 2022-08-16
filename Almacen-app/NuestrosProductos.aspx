<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.Master" AutoEventWireup="true" CodeBehind="NuestrosProductos.aspx.cs" Inherits="Almacen_app.NuestrosProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container mt-5">
        <div class="row">
            <div class="col-12">
                <h1 class="display-1 text-center">Nuestros productos:</h1>
            </div>
            <asp:Repeater runat="server" ID="repRepetidor">
                <ItemTemplate>
                    <div class="col-12 col-md-4">
                        <div class="card mt-3">
                            <img src="<%#Eval("UrlImagen")%>" class="card-img-top img-fluid" alt="imagen">
                            <div class="card-body">
                                <h5 class="card-title text-center"><%#Eval("Nombre")%></h5>
                                <h6 class="card-subtitle text-muted mb-2">Precio: $<%#Eval("Precio")%></h6>
                                <p class="card-text"><%#Eval("Descripcion")%></p>
                                <span class="badge rounded-pill bg-warning text-dark">#<%#Eval("Categoria")%></span>
                                <span class="badge rounded-pill bg-success text-white">#<%#Eval("Madera") %></span>
                            </div>

                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </section>
</asp:Content>
