<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ListarEventos.aspx.cs" Inherits="PracticaHotel.Formulario_web2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">
    Listar
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="tituloPagina" runat="server">
    Listar
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenido" runat="server">
    <asp:GridView ID="eventos" 
        runat="server" style="margin:auto; margin-top: 30px; border:solid; border-color: #1c1c1c; border-radius:5px;
        border-collapse: separate !important">
    </asp:GridView>
</asp:Content>
