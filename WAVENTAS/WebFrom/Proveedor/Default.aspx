<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="WebFrom_Proveedor_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <h2>Formulario de Registro de Usuario</h2>

<div>
<label for="txtTipoProveedor ">TipoProveedor :</label>
<asp:TextBox ID="txbTipoProveedor" runat="server" CssClass="form-control" />
</div>
<div>
<label for="txtRazonSocialProveedor">RazonSocialProveedor:</label>
<asp:TextBox ID="txbRazonSocialProveedor" runat="server" CssClass="form-control" />
</div>
<div>
<label for="txtDireccionProveedor">DireccionProveedor:</label>
<asp:TextBox ID="txbDireccionProveedor" runat="server" CssClass="form-control" />
</div>
<div>
<label for="txtCelularProveedor">CelularProveedor:</label>
<asp:TextBox ID="txbCelularProveedor" runat="server" CssClass="form-control" />
</div>
<div>
<label for="CorreoProveedor">CorreoProveedor:</label>
<asp:TextBox ID="txbCorreoProveedor" runat="server"  CssClass="form-control" />
</div>

<div>
<asp:Button ID="btnAgregarProveedor" runat="server" Text="AgregarProveedor" OnClick="btnAgregarProveedor_Click" CssClass="btn btn-primary" />
</div>
        <div>
            <h1>Ver Proveedor</h1>
            <asp:Label runat="server" Text="Buscar Articulo: Codigo  "></asp:Label>
            <asp:TextBox ID="txbCodigoProveedor" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarProveedor" Text="Buscar" runat="server" OnClick="btnBuscarProveedor_Click" />
            <asp:Label runat="server" ID="lbObtenerProveedor"></asp:Label>
        </div>


        <div>
            <h1>Actualizar Proveedor</h1>
            <asp:Label runat="server" Text="Actualizar Proveedor: Codigo Proveedor"></asp:Label>
            <asp:TextBox ID="txbCodigoProveedorActualizar" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarProveedorActualizar" Text="Buscar" runat="server" OnClick="btnBuscarProveedorActualizar_Click" />

            <asp:Label runat="server" Text="Tipo Proveedor: "></asp:Label>
            <asp:TextBox ID="txbTipoProveedorActualizar" runat="server"></asp:TextBox>

            <asp:Label runat="server" Text="Razon Social Proveedor: "></asp:Label>
            <asp:TextBox ID="txbRazonSocialProveedorActualizar" runat="server"></asp:TextBox>

            <asp:Label runat="server" Text="Direccion Proveedor: "></asp:Label>
            <asp:TextBox ID="txbDireccionProveedorActualizar" runat="server"></asp:TextBox>

            <asp:Label runat="server" Text="Celular Proveedor: "></asp:Label>
            <asp:TextBox ID="txbCelularProveedorActualizar" runat="server"></asp:TextBox>

            <asp:Label runat="server" Text="Correo Proveedor: "></asp:Label>
            <asp:TextBox ID="txbCorreoProveedorActualizar" runat="server"></asp:TextBox>

            <asp:Button ID="btnActualizarProveedor" Text="Actualizar Proveedor" runat="server" OnClick="btnActualizarProveedor_Click" />
            <asp:Label runat="server" ID="lbActualizar"></asp:Label>
        </div>
        <div>
            <h1>Eliminar Articulo</h1>
            <asp:Label runat="server" Text="Eliminar Proveedor: Codigo Proveedor "></asp:Label>
            <asp:TextBox ID="txbCodigoProveedorEliminar" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarProveedorEliminar" Text="Buscar" runat="server" OnClick="btnBuscarProveedorEliminar_Click"/>
            <asp:Label runat="server" ID="lbEliminar"></asp:Label>
        </div>

</asp:Content>

