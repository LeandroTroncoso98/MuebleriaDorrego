<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Almacen_app.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="container mt-5">
        <div class="row">
            <div class="col-12">
                <h3 class="text-center">¿Buscas muebles para tu hogar al precio mas accesible?</h3>
            </div>
            <div class="col-12 mt-3">
                <div class="carousel carousel-dark slide carousel-fade" id="mi-carousel" data-bs-ride="carousel">
                    <div class="carousel-inner">
                        <div class="carousel-item active" data-bs-interval="4000">

                            <img src="img/carousel1.jpg" class="w-100" />
                        </div>
                        <div class="carousel-item" data-bs-interval="4000">
                            <img src="img/carousel2.jpg" class="w-100" />
                        </div>
                        <div class="carousel-item" data-bs-interval="4000">
                            <img src="img/carousel3.jpg" class="w-100" />
                        </div>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#mi-carousel" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Anterior</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#mi-carousel" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Siguiente</span>
                    </button>
                    <!--Indicadores-->
                    <div class="carousel-indicators">
                        <button type="button" class="active" data-bs-target="#mi-carousel" data-bs-slide-to="0" aria-label="slide 1"></button>
                        <button type="button" class="" data-bs-target="#mi-carousel" data-bs-slide-to="1" aria-label="slide 2"></button>
                        <button type="button" class="" data-bs-target="#mi-carousel" data-bs-slide-to="2" aria-label="slide 3"></button>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class="container mt-5">
        <div class="row">
            <div class="col-12 col-md-6 align-self-center">
                <h4 class="display-4 text-center text-md-start">Vení a conocernos.</h4>
                <p class="text-secondary">Te esperamos para ayudarte a elegír el mejor estilo para tu hogar.</p>
            </div>
            <div class="col-12 col-md-6">
                <img src="Img/Conocenos.jpg" class="img-fluid img-thumbnail" />
            </div>
        </div>
        <div class="row mt-5">
            <div class="col-12 col-md-6">
                <img src="Img/envioDomicilio.jpg" class="img-fluid" />
            </div>
            <div class="col-12 col-md-6 align-self-center">
                <h4 class="display-4 text-center text-md-end">Envío a domicilio.</h4>
                <p class="text-secondary">Contamos con envio a domicilio para que tu compra sea de lo mas agradable a la hora de volver a casa.</p>
            </div>
        </div>
    </section>


</asp:Content>
