<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ModificarEvento.aspx.cs" Inherits="PracticaHotel.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="titulo" runat="server">
    Modificar
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="tituloPagina" runat="server">
    Modificar
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenido" runat="server">
    <table style="margin:auto; margin-top: 30px; border:solid; border-color: #1c1c1c; border-radius:5px; border-collapse: separate !important; text-align:left">
        <tr>
            <td>
                Fecha
            </td>
            <td>
                <asp:DropDownList ID="fechaEventos" runat="server" AutoPostBack="True" DataTextField="Fecha" DataValueField="Fecha" style="margin-top:5%"></asp:DropDownList>
                <br />
            </td>
            <td>
                <asp:Label  ID="fechaMensaje" runat="server" ForeColor="Red"/>
            </td>
        </tr>
        <tr>
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
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnModificar_Click"/>
            </td>
            <td>
                <asp:Label  ID="botonMensaje" runat="server" ForeColor="Red"/>
            </td>
        </tr>
    </table>
</asp:Content>
