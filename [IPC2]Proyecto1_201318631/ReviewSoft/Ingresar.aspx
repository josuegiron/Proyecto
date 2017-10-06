<%@ Page Title="" Language="C#" MasterPageFile="~/public/include/MasterPage.master" AutoEventWireup="true" CodeFile="Ingresar.aspx.cs" Inherits="Ingresar" %>

<asp:Content ID="Content" ContentPlaceHolderID="Contenido" runat="Server">

    <form id="form1" runat="server">
        <div style="height: auto">
            <div style="height: auto">
            <span class="" style="margin-top: 7px;">Usuario:</span>
            <asp:TextBox ID="txtUsuario" CssClass="" runat="server"></asp:TextBox>
            </div>
            <div style="height: auto">
            <span class="cFR cPosRel TextoLogin" style="margin-top: 7px;">Password:</span>
            <asp:TextBox ID="txtContraseña" TextMode="Password" CssClass="txtControl" runat="server"></asp:TextBox>
            </div>
            <div style="height: auto">
                <div>                
                    <asp:Button CssClass="button1"  ID="btnIniciar" runat="server" OnClick="btnIniciar_Click" Text="Ingresar" />

                </div>
                <div class="button">
                    <a href="Registro.aspx">Registrar</a>
                </div>
                <asp:Label ID="lblMensaje" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
            </div>

        </div>
                
         
    </form>

</asp:Content>