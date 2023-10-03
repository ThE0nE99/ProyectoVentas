<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="PAgregarUsuario.aspx.cs" Inherits="WebFrom_Usuario_PAgregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Formulario de Registro de Usuario</h2>

        <div>
            <label for="txtNombres">Nombres:</label>
            <asp:TextBox ID="txtNombres" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtApellidos">Apellidos:</label>
            <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtCelular">Celular:</label>
            <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtCorreo">Correo Electrónico:</label>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtClave">Clave:</label>
            <asp:TextBox ID="txtClave" runat="server" TextMode="Password" CssClass="form-control" />
        </div>
        <div>
            <label for="ddlRol">Rol de Usuario:</label>
            <asp:DropDownList ID="ddlRol" runat="server" CssClass="form-control">
                <asp:ListItem Text="Seleccionar Rol" Value="" />
                <asp:ListItem Text="Rol 1" Value="A" />
                <asp:ListItem Text="Rol 2" Value="B" />
                
            </asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        </div>
    <asp:Label ID="lblCodigo" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblApellido" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblContacto" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblClave" runat="server" Text=""></asp:Label>
    <asp:Label ID="lblEstado" runat="server" Text=""></asp:Label>

    <asp:GridView ID="GridViewUsuarios" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="NombresUsuario" HeaderText="Nombres" />
        <asp:BoundField DataField="ApellidosUsuario" HeaderText="Apellidos" />
        <asp:BoundField DataField="CelularUsuario" HeaderText="Celular" />
        <asp:BoundField DataField="CorreoUsuario" HeaderText="Correo" />
        <asp:BoundField DataField="ClaveUsuario" HeaderText="Clave" />
        <asp:BoundField DataField="Estado" HeaderText="Estado" />
    </Columns>
</asp:GridView>
</asp:Content>

