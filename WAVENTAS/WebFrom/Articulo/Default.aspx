<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="WebFrom_Proveedor_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
        <div>
            <h1>CREAR NUEVO ARTICULO</h1>
            <asp:Label runat="server" Text="Categoria Articulo: "></asp:Label>
            <asp:TextBox ID="txbCategoriaArticulo" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Nombre Articulo: "></asp:Label>
            <asp:TextBox ID="txbNombreArticulo" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Precio Compra Articulo: "></asp:Label>
            <asp:TextBox ID="txbPrecioCompraArticulo" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Precio Venta Articulo: "></asp:Label>
            <asp:TextBox ID="txbPrecioVentaArticulo" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Stock Articulo: "></asp:Label>
            <asp:TextBox ID="txbStockArticulo" runat="server"></asp:TextBox>
            <asp:Button ID="btnCrearArticulo" Text="Crear Nuevo Articulo" runat="server" OnClick="btnCrearArticulo_Click" />
            <asp:Label runat="server" ID="lbInsertar"></asp:Label>
        </div>
        <div>
            <h1>Ver Articulo</h1>
            <asp:Label runat="server" Text="Buscar Articulo: Codigo Articulo "></asp:Label>
            <asp:TextBox ID="txbCodigoArticulo" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarArticulo" Text="Buscar" runat="server" OnClick="btnBuscarArticulo_Click" />
            <asp:Label runat="server" ID="lbObtener"></asp:Label>
        </div>
        <div>
            <h1>Ver todos los Articulos</h1>
            <asp:Button ID="btnVerArticulos" Text="Buscar" runat="server" OnClick="btnVerArticulos_Click" />
            <asp:Label runat="server" ID="lbObtenerTodos"></asp:Label>
        </div>
        <div>
            <h1>Actualizar Articulo</h1>
            <asp:Label runat="server" Text="Actualizar Articulo: Codigo Articulo "></asp:Label>
            <asp:TextBox ID="txbCodigoArticuloActualizar" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarArticuloActualizar" Text="Buscar" runat="server" OnClick="btnBuscarArticuloActualizar_Click" />
            <asp:Label runat="server" Text="Categoria Articulo: "></asp:Label>
            <asp:TextBox ID="txbCategoriaArticuloActualizar" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Nombre Articulo: "></asp:Label>
            <asp:TextBox ID="txbNombreArticuloActualizar" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Precio Compra Articulo: "></asp:Label>
            <asp:TextBox ID="txbPrecioCompraArticuloActualizar" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Precio Venta Articulo: "></asp:Label>
            <asp:TextBox ID="txbPrecioVentaArticuloActualizar" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Stock Articulo: "></asp:Label>
            <asp:TextBox ID="txbStockArticuloActualizar" runat="server"></asp:TextBox>
            <asp:Button ID="btnActualizarArticulo" Text="Actualizar Articulo" runat="server" OnClick="btnActualizarArticulo_Click" />
            <asp:Label runat="server" ID="lbActualizar"></asp:Label>
        </div>
        <div>
            <h1>Eliminar Articulo</h1>
            <asp:Label runat="server" Text="Eliminar Articulo: Codigo Articulo "></asp:Label>
            <asp:TextBox ID="txbCodigoArticuloEliminar" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarArticuloEliminar" Text="Buscar" runat="server" OnClick="btnBuscarArticuloEliminar_Click" />
            <asp:Label runat="server" ID="lbEliminar"></asp:Label>
        </div>
    </div>
</asp:Content>

