<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="WebFrom_Proveedor_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <h2>Formulario de Registro de Usuario</h2>

<div>
<label for="txtTipoProveedor ">TipoProveedor :</label>
<asp:TextBox ID="txtTipoProveedor" runat="server" CssClass="form-control" />
</div>
<div>
<label for="txtRazonSocialProveedor">RazonSocialProveedor:</label>
<asp:TextBox ID="txtRazonSocialProveedor" runat="server" CssClass="form-control" />
</div>
<div>
<label for="txtDireccionProveedor">DireccionProveedor:</label>
<asp:TextBox ID="txtDireccionProveedor" runat="server" CssClass="form-control" />
</div>
<div>
<label for="txtCelularProveedor">CelularProveedor:</label>
<asp:TextBox ID="txtCelularProveedor" runat="server" CssClass="form-control" />
</div>
<div>
<label for="CorreoProveedor">CorreoProveedor:</label>
<asp:TextBox ID="txtCorreoProveedor" runat="server"  CssClass="form-control" />
</div>

<div>
<asp:Button ID="btnAgregarProveedor" runat="server" Text="AgregarProveedor" OnClick="btnAgregarProveedor_Click" CssClass="btn btn-primary" />
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

