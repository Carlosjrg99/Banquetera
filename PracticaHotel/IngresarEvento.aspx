<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="IngresarEvento.aspx.cs" Inherits="PracticaHotel.Formulario_web11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">
    Ingresar
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="tituloPagina" runat="server">
    Ingresar
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenido" runat="server">
    <table style="margin:auto; margin-top: 30px; border:solid; border-color: #1c1c1c; border-radius:5px; border-collapse: separate !important; text-align:left">
        <tr>
            <td>
                Nombre
            </td>
            <td>
                <asp:TextBox ID="nombre" runat="server" placeholder="Nombre" required="true"/>
                <br />
            </td>
            <td>
                <asp:Label  ID="nombreMensaje" runat="server" ForeColor="Red"/>
            </td>
        </tr>
        <tr>
            <td>
                Dirección
            </td>
            <td>
                <asp:TextBox ID="direccion" runat="server" placeholder="Dirección" required="true"/>
                <br />
            </td>
            <td>
                <asp:Label  ID="direccionMensaje" runat="server" ForeColor="Red"/>
            </td>
        </tr>
        <tr>
            <td>
                Email
            </td>
            <td>
                <asp:TextBox ID="email" runat="server" placeholder="Correo@mail.com" TextMode="Email" required="true"/>
            </td>
            <td>
                <asp:Label  ID="emailMensaje" runat="server" ForeColor="Red"/>
            </td>
        </tr>
        <tr>
            <td>
                Teléfono
            </td>
            <td>
                <asp:TextBox ID="telefono" runat="server" placeholder="987654321" required="true"/>
                <br />
            </td>
            <td>
                <asp:Label  ID="telefonoMensaje" runat="server" ForeColor="Red"/>
            </td>
        </tr>
        <tr>
            <td>
                Fecha
            </td>
            <td>
                <asp:TextBox ID="fecha" runat="server" placeholder="Nombre" TextMode="Date" required="true"/>
                <br />
            </td>
            <td>
                <asp:Label  ID="fechaMensaje" runat="server" ForeColor="Red"/>
            </td>
        </tr>
        <tr>
            <td>
                Cantidad de Personas
            </td>
            <td>
                <asp:TextBox ID="personas" runat="server" placeholder="0" TextMode="Number" required="true"/>
                <br />
            </td>
            <td>
                <asp:Label  ID="personasMensaje" runat="server" ForeColor="Red"/>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align:center">
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="ingresarEvento"/>
            </td>
            <td>
                <asp:Label  ID="botonMensaje" runat="server" ForeColor="Red"/>
            </td>
        </tr>
    </table>
</asp:Content>
