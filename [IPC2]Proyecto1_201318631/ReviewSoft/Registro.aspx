<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/public/include/MasterPage.master" CodeFile="Registro.aspx.cs" Inherits="Registro" %>
<asp:Content ID="head" runat="server" ContentPlaceHolderID="head" >
    <link href="css/Estilo.css" type="text/css" rel="stylesheet" id="stylesheet"  />
    <title>Registro</title>
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="Contenido" runat="Server">
    <form id="form1" runat="server">
        <h1>Registro</h1>
        <table class="tabla">
            <tr>
                <td>Usuario: 
                </td>
                <td>
                    <asp:TextBox ID="txtUsuario" CssClass="textbox" runat="server" placeholder="Usuario"></asp:TextBox>
                    <asp:Label ID="errorUsuario" CssClass="" runat="server" ForeColor="#996600"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Contraseña: 
                </td>
                <td>
                    <asp:TextBox ID="txtContraseña" TextMode="Password" CssClass="textbox" runat="server" placeholder="Contraseña"></asp:TextBox>
                    <asp:Label ID="errorPassword" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Nombre: 
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" CssClass="textbox" runat="server" placeholder="Nombre"></asp:TextBox>
                    <asp:Label ID="errorNombre" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Apellido: 
                </td>
                <td>
                    <asp:TextBox ID="txtApellido" CssClass="textbox" runat="server" placeholder="Apellido"></asp:TextBox>
                    <asp:Label ID="errorApellido" CssClass="" runat="server" ForeColor="#996600"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Correo: 
                </td>
                <td>
                    <asp:TextBox ID="txtCorreo" CssClass="textbox" runat="server" placeholder="Correo"></asp:TextBox>
                    <asp:Label ID="errorCorreo" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Fecha: 
                </td>
                <td>
                    <asp:Button ID="selFecha" runat="server" Text="Fecha" CssClass="textbox" OnClick="selFecha_Click" BorderStyle="Solid" Height="35px" Width="210px"  />
                    <asp:Calendar ID="Calendar1" CssClass="calendar" runat="server" Visible="False" SelectedDate="2017-10-05" VisibleDate="2017-10-05" OnSelectionChanged="Calendar1_SelectionChanged" FirstDayOfWeek="Sunday"></asp:Calendar>
                    <asp:Label ID="errorFechaNac" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Profesión: 
                </td>
                <td>
                    <asp:TextBox ID="txtProfesion" CssClass="textbox" runat="server" placeholder="Profesión"></asp:TextBox>
                    <asp:Label ID="errorProfesion" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <a href="Ingresar.aspx">Ingresar</a>
                </td>
                <td>
                    <asp:Button ID="ptnRegistrar" runat="server" CssClass="boton-accion" OnClick="btnRegistrar_Click" Text="Registrar" />
                </td>
            </tr>
        </table>

    </form>
</asp:Content>