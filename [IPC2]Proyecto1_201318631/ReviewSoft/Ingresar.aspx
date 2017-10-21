<%@ Page Title="" Language="C#" MasterPageFile="~/public/include/MasterPage.master" AutoEventWireup="true" CodeFile="Ingresar.aspx.cs" Inherits="Ingresar" %>

<asp:Content ID="head" runat="server" ContentPlaceHolderID="head" >
    <link href="css/Estilo.css" type="text/css" rel="stylesheet" id="stylesheet"  />
    <title>Ingresar</title>
</asp:Content>

<asp:Content ID="Content" ContentPlaceHolderID="Contenido" runat="Server">
   
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:TextBox ID="txtUsuario" CssClass="textbox" runat="server" placeholder="Usuario"></asp:TextBox>
            </div>
            <div >
                <asp:TextBox ID="txtContraseña" TextMode="Password" CssClass="textbox" runat="server"  placeholder="Contraseña"></asp:TextBox>
            </div>
            <div>
                <div>                
                    <asp:Button ID="btnIniciar" CssClass="boton-accion" OnClick="btnIniciar_Click"  Text="Ingresar" runat="server"></asp:Button>
                    
                </div>
                <div>
                    <a class="button a" href="Registro.aspx">Registrar</a>
                </div>
                    <asp:label id="lblMensaje" class="cFL" runat="server" forecolor="#996600"></asp:label>
            </div>
        </div>
    </form>

</asp:Content>