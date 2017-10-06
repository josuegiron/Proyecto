<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/public/include/MasterPage.master" CodeFile="Registro.aspx.cs" Inherits="Registro" %>

<asp:Content ID="Content" ContentPlaceHolderID="Contenido" runat="Server">
    <form id="form2" runat="server">
            <div class="cFL cPosRel" style="width: 450px; height: auto;">
                <div class="cFL cPosRel" style="width: 100px; height: 25px;">
                    <span class="cFR cPosRel TextoLogin" style="margin-top: 7px;">Usuario:</span>
                </div>
                <div class="cFL cPosRel" style="width: 290px; height: 25px;">
                    <asp:TextBox ID="txtUsuario" CssClass="txtControl" runat="server"></asp:TextBox>
                    <asp:Label ID="errorUsuario" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </div>
                <div class="cFL cPosRel" style="width: 100px; height: 25px; margin-top: 15px;">
                    <span class="cFR cPosRel TextoLogin" style="margin-top: 7px;">Password:</span>
                    
                </div>
                <div class="cFL cPosRel" style="width: 290px; height: 25px; margin-top: 15px;">
                    <asp:TextBox ID="txtContraseña" TextMode="Password" CssClass="txtControl" runat="server"></asp:TextBox>
                    <asp:Label ID="errorPassword" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </div> 
                <div class="cFL cPosRel" style="width: 100px; height: 25px; margin-top: 15px;">
                    <span class="cFR cPosRel TextoLogin" style="margin-top: 7px;">Nombre:</span>
                </div>
                <div class="cFL cPosRel" style="width: 290px; height: 25px; margin-top: 15px;">
                    <asp:TextBox ID="txtNombre"  CssClass="txtControl" runat="server"></asp:TextBox>
                    <asp:Label ID="errorNombre" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </div>
                 <div class="cFL cPosRel" style="width: 100px; height: 25px; margin-top: 15px;">
                    <span class="cFR cPosRel TextoLogin" style="margin-top: 7px;">Apellido:</span>
                </div>
                <div class="cFL cPosRel" style="width: 290px; height: 25px; margin-top: 15px;">
                    <asp:TextBox ID="txtApellido"  CssClass="txtControl" runat="server"></asp:TextBox>
                    <asp:Label ID="errorApellido" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </div>
                 <div class="cFL cPosRel" style="width: 100px; height: 25px; margin-top: 15px;">
                    <span class="cFR cPosRel TextoLogin" style="margin-top: 7px;">Correo:</span>
                </div>
                <div class="cFL cPosRel" style="width: 290px; height: 25px; margin-top: 15px;">
                    <asp:TextBox ID="txtCorreo" CssClass="txtControl" runat="server"></asp:TextBox>
                    <asp:Label ID="errorCorreo" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </div>
                 <div class="cFL cPosRel" style="width: 100px; height: 25px; margin-top: 15px;">
                    <span class="cFR cPosRel TextoLogin" style="margin-top: 7px;">Fecha:</span>
                </div>
                <div class="cFL cPosRel" style="width: 290px; height: 25px; margin-top: 15px;">
                    
                    <asp:Button ID="selFecha" runat="server" Text="" CssClass="txtControl"  OnClick="selFecha_Click"/>

                     
                        <asp:Calendar style="position: absolute; z-index: 1; margin-left: 10px;" ID="Calendar1" CssClass ="calendar" runat="server" Visible="False" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" SelectedDate="2017-10-05" VisibleDate="2017-10-05" Width="200px" OnSelectionChanged="Calendar1_SelectionChanged" FirstDayOfWeek="Sunday">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                        </asp:Calendar>
                    
                        
                    
                    <asp:Label ID="errorFechaNac" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                </div>
               
                    <div`>
                        <div class="cFL cPosRel" style="width: 100px; height: 25px; margin-top: 15px;">
                        <span class="cFR cPosRel TextoLogin" style="margin-top: 7px;">Profesión:</span>
                    </div>
                    <div class="cFL cPosRel" style="width: 290px; height: 25px; margin-top: 15px;">
                        <asp:TextBox ID="txtProfesion" CssClass="txtControl" runat="server"></asp:TextBox>
                        <asp:Label ID="errorProfesion" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                    </div>
                </div>
                 
                <div class="cFL cPosRel" style="width: 460px;">
                    <div style="width: 120px; height: 30px; margin-left: auto; margin-right: auto; margin-top: 15px;">
                        <asp:Button ID="ptnRegistrar" runat="server"  CssClass="button" OnClick="btnRegistrar_Click" Text="Registrar" />
                    </div>
                </div>
            </div>
            <asp:Label ID="lblMensaje" CssClass="cFL" runat="server" ForeColor="#996600"></asp:Label>
                    
     
    </form>
</asp:Content>