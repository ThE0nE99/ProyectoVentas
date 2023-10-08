<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="PAgregarIngreso.aspx.cs" Inherits="WebFrom_Ingreso_PAgregarIngreso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Formulario de Registro de Ingreso</h2>
    <div>
        <label for="txbCodigoProveedor">Codigo Proveedor:</label>
        <asp:TextBox ID="txbCodigoProveedor" runat="server" TextMode="Number" CssClass="form-control" />
    </div>
    <div>
        <label for="txbCodigoUsuario">Codigo Usuario:</label>
        <asp:TextBox ID="txbCodigoUsuario" runat="server" TextMode="Number" CssClass="form-control" />
    </div>
    <div>
        <label for="txbFechaIngreso">Fecha Ingreso:</label>
        <asp:TextBox ID="txbFechaIngreso" runat="server" TextMode="Date" CssClass="form-control" />
        
    </div>
    <div>
        <label for="txbImpuestoIngreso">Impuesto Ingreso:</label>
        <asp:TextBox ID="txbImpuestoIngreso" runat="server" TextMode="Number" CssClass="form-control" />
    </div>
    <div>
        <label for="txbTotalIngreso">Total Ingreso:</label>
        <asp:TextBox ID="txbTotalIngreso" runat="server" TextMode="Number" CssClass="form-control" />
    </div>
     <div>
        <label for="txbEstadoIngreso">Estado Ingreso:</label>
        <asp:TextBox ID="txbEstadoIngreso" runat="server" TextMode="Number" CssClass="form-control" />
    </div>
     
    <div>
        <asp:Label runat="server" ID="lblInsercion"></asp:Label>
    </div>
   

    <hr />

     <h2>Formulario Detalle Ingreso</h2>
   
    <div>
        <label for="txbCodigoArticulo">Codigo Articulo:</label>
        <asp:TextBox ID="txbCodigoArticulo" runat="server" TextMode="Number" CssClass="form-control" />
    </div>
    <div>
        <label for="txbCantidadIngreso">Cantidad Ingreso:</label>
        <asp:TextBox ID="txbCantidadIngreso" runat="server" TextMode="Number" CssClass="form-control" />
        
    </div>
    <div>
        <label for="txbPrecioIngreso">Precio Ingreso:</label>
        <asp:TextBox ID="txbPrecioIngreso" runat="server" TextMode="Number" CssClass="form-control" />
    </div>
     <div>
          <asp:Button ID="btnNuevoRegistro" runat="server" Text="Insertar Nuevo Registro" OnClick="btnNuevoRegistro_Click" CssClass="btn btn-primary" />
     </div>
     <div>
        <asp:Button ID="btnAgregarIngreso" runat="server" Text="Agregar Ingreso" OnClick="btnAgregarIngreso_Click" CssClass="btn btn-primary" />
    </div>
</asp:Content>

