<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="EliminarEvento.aspx.cs" Inherits="PracticaHotel.Formulario_web13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">
    Eliminar
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="tituloPagina" runat="server">
    Eliminar
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenido" runat="server">
    <asp:DropDownList ID="eliminarEventos" runat="server" AutoPostBack="True" DataTextField="Fecha" DataValueField="Fecha" style="margin-top:5%"></asp:DropDownList>
    <br><br/>
    <asp:Label ID="infoEvento" runat="server"></asp:Label>
    <br><br/>
    <asp:Button ID="elimiarSeleccion" runat="server" Text="Eliminar" OnClick="elimiarSeleccion_Click"/>
</asp:Content>
