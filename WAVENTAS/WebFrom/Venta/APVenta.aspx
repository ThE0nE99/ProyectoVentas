<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="APVenta.aspx.cs" Inherits="WebFrom_Venta_APVenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Registrar Venta </h1>
        <hr />
        <h3>Insertar</h3>
    <div>
        
        <div>
            <label for="txtCodigoClienteVenta">Codigo Cliente:</label>
            <asp:TextBox ID="txtCodigoClienteVenta" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtCodigoUsuarioVenta">Codigo Usuario:</label>
            <asp:TextBox ID="txtCodigoUsuarioVenta" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtImpuestoVenta">Impuesto:</label>
            <asp:TextBox ID="txtImpuestoVenta" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtTotalVenta">Total Venta:</label>
            <asp:TextBox ID="txtTotalVenta" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtEstadoVenta">Estado:</label>
            <asp:TextBox ID="txtEstadoVenta" runat="server" CssClass="form-control" />
        </div>
    </div>
    <hr />
     <h3>Insertar Detalle Venta</h3>
        <div>
             <label for="txtCantidadArticulo">Codigo Articulo:</label>
            <asp:TextBox ID="txtCantidadArticulo" runat="server" CssClass="form-control" />
        </div>
        <div>
             <label for="txtCantidadDetalleVenta">Cantidad Artiuo:</label>
            <asp:TextBox ID="txtCantidadDetalleVenta" runat="server" CssClass="form-control" />
        </div>
        <div>
             <label for="txtPrecioDetalleVenta">Precio:</label>
            <asp:TextBox ID="txtPrecioDetalleVenta" runat="server" CssClass="form-control" />
        </div>
        <div>
             <label for="txtDescuentoDetalleVenta">Descuento :</label>
            <asp:TextBox ID="txtDescuentoDetalleVenta" runat="server" CssClass="form-control" />
        </div>
     <div>
            <asp:Button ID="btnInsertarVenta" runat="server" Text="Insertar Venta" OnClick="btnInsertarVenta_Click" CssClass="btn btn-primary" />
     </div>
     <div>
            <asp:Button ID="btnNuevoRegistro" runat="server" Text="Insertar Nuevo Registro" OnClick="btnNuevoRegistro_Click" CssClass="btn btn-primary" />
     </div>
    <asp:Label ID="lblInformacion" runat="server" Text=""></asp:Label>
</asp:Content>

