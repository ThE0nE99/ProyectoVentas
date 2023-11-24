<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="WebFrom_Proveedor_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
  <div>
           <asp:Button ID="btnMenu" Text="Menu" runat="server" OnClick="btnMenu_Click"/>
            <h1>ARTICULO</h1>
            <asp:Label runat="server" Text="Actualizar Articulo: Codigo Articulo "></asp:Label>
            <asp:TextBox ID="txbCodigoArticuloActualizar" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" Text="Buscar" runat="server" OnClick="btnBuscarArticuloActualizar_Click" />
            <br>
            <asp:Label runat="server" Text="Categoria Articulo: "></asp:Label>
            <asp:TextBox ID="txbCategoriaArticulo" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Nombre Articulo: "></asp:Label>
            <asp:TextBox ID="txbNombreArticulo" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Precio Compra Articulo: "></asp:Label>
            <asp:TextBox ID="txbPrecioCompraArticulo" runat="server"></asp:TextBox>
            <br>
            <asp:Label runat="server" Text="Precio Venta Articulo: "></asp:Label>
            <asp:TextBox ID="txbPrecioVentaArticulo" runat="server"></asp:TextBox>
            <asp:Label runat="server" Text="Stock Articulo: "></asp:Label>
            <asp:TextBox ID="txbStockArticulo" runat="server"></asp:TextBox>
            <br>
            <asp:Button ID="btnGuardarArticulo" Text="Crear Nuevo Articulo" runat="server" OnClick="btnGuardarArticulo_Click" />
            <br>
            <asp:Label runat="server" ID="lbArticulo"></asp:Label>
        </div>
    <hr>
        <div>
            <h1>Ver Articulos</h1>
            <asp:Label runat="server" Text="Buscar Articulo: Codigo Articulo "></asp:Label>
            <asp:TextBox ID="txbCodigoArticulo" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarArticulo" Text="Buscar" runat="server" OnClick="btnBuscarArticulo_Click" />
            <asp:Button ID="btnVerTodo" Text="Ver Todo" runat="server" OnClick="btnVerTodo_Click" />
    <hr>
            <br>
            <asp:DataGrid ID="DataGridArticulo" runat="server"> </asp:DataGrid>
            <asp:Label runat="server" ID="lbObtenerTodos"></asp:Label>
        </div>
    <hr>
        <div>
            <h1>Eliminar Articulo</h1>
            <asp:Label runat="server" Text="Eliminar Articulo: Codigo Articulo "></asp:Label>
            <asp:TextBox ID="txbCodigoArticuloEliminar" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscarArticuloEliminar" Text="Buscar" runat="server" OnClick="btnBuscarArticuloEliminar_Click" />
            <br>
            <asp:Label runat="server" ID="lbEliminar"></asp:Label>
        </div>
    </div>
</asp:Content>
