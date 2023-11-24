<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="PAgregarCliente.aspx.cs" Inherits="WebFrom_Cliente_PAgregarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Button ID="btnMenu" Text="Menu" runat="server" OnClick="btnMenu_Click"/>

<h2>Formulario de Registro de Cliente</h2>
<div>
<label for="txbRazonSocialCliente">Razon Social:</label>
<asp:TextBox ID="txbRazonSocialCliente" runat="server" CssClass="form-control" />
</div>
<div>
<label for="txbCiONitCliente">CI o NIT:</label>
<asp:TextBox ID="txbCiONitCliente" runat="server" TextMode="Number" CssClass="form-control" />
</div>
<div>
<label for="ddlTipoCliente">Tipo Cliente:</label>
<asp:DropDownList ID="ddlTipoCliente" runat="server" CssClass="form-control">
<asp:ListItem Text="Seleccionar Cliente" Value="" />
<asp:ListItem Text="1" Value="1" />
<asp:ListItem Text="2" Value="2" />
</asp:DropDownList>
</div>
<div>
<label for="txbDirecionCliente">Direccion Cliente:</label>
<asp:TextBox ID="txbDirecionCliente" runat="server" CssClass="form-control" />
</div>
<div>
<label for="txbCelularCliente">Celular:</label>
<asp:TextBox ID="txbCelularCliente" runat="server" TextMode="Number" CssClass="form-control" />
</div>
<div>
<asp:Label runat="server" ID="lblInsercion"></asp:Label>
</div>
<div>
<asp:Button ID="btnAgregarCliente" runat="server" Text="Agregar Cliente" OnClick="btnAgregarCliente_Click" CssClass="btn btn-primary" />
</div>
 
    <div>
<h1>Ver Cliente</h1>
<asp:Label runat="server" Text="Buscar Cliente: Codigo "></asp:Label>
<asp:TextBox ID="txbCodigoCliente" runat="server"></asp:TextBox>
<asp:Button ID="btnBuscarCliente" Text="Buscar" runat="server" OnClick="btnBuscarCliente_Click" />
<asp:Label runat="server" ID="lbObtenerCliente"></asp:Label>
</div>
 
    <div>
<h1>Actualizar Cliente</h1>
<asp:Label runat="server" Text="Actualizar Cliente: Codigo Cliente"></asp:Label>
<asp:TextBox ID="txbCodigoClienteActualizar" runat="server"></asp:TextBox>
 
        <asp:Button ID="btnBuscarClienteActualizar" Text="Buscar" runat="server" OnClick="btnBuscarClienteActualizar_Click" />
<asp:Label runat="server" Text="Razon Social Cliente: "></asp:Label>
<asp:TextBox ID="txbRazonSocialClienteActualizar" runat="server"></asp:TextBox>
 
        <asp:Label runat="server" Text="CI o NIT: "></asp:Label>
<asp:TextBox ID="txbCiONitClienteActualizar" runat="server"></asp:TextBox>
 
        <asp:Label runat="server" Text="Tipo Cliente: "></asp:Label>
<asp:TextBox ID="txbTipoClienteActualizar" runat="server"></asp:TextBox>
 
        <asp:Label runat="server" Text="Direccion Cliente: "></asp:Label>
<asp:TextBox ID="txbDireccActualizar" runat="server"></asp:TextBox>
 
        <asp:Label runat="server" Text="Celular Cliente: "></asp:Label>
<asp:TextBox ID="txbCelularClienteActualizar" runat="server"></asp:TextBox>
 
        <asp:Label runat="server" Text="Estado Cliente: "></asp:Label>
<asp:TextBox ID="txbEstadoActualizar" runat="server"></asp:TextBox>
 
        <asp:Button ID="btnActualizarCliente" Text="Actualizar Cliente" runat="server" OnClick="btnActualizarCliente_Click" />
<asp:Label runat="server" ID="lbActualizar"></asp:Label>
</div>
 
    <div>
<h1>Eliminar Cliente</h1>
<asp:Label runat="server" Text="Eliminar Cliente: Codigo Cliente "></asp:Label>
<asp:TextBox ID="txbCodigoClienteEliminar" runat="server"></asp:TextBox>
<asp:Button ID="btnBuscarClienteEliminar" Text="Buscar" runat="server" OnClick="btnBuscarClienteEliminar_Click" />
<asp:Label runat="server" ID="lbEliminar"></asp:Label>
</div>    
 
        <div>
            <h1>Ver todos los Clientes</h1>
            <asp:Button ID="btnVerClientes" Text="Buscar" runat="server" OnClick="btnVerClientes_Click" />
            <asp:GridView ID="gridViewClientes" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="RazonSocialCliente" HeaderText="Razón Social" />
                    <asp:BoundField DataField="CiONitCliente" HeaderText="CioNit" />
                    <asp:BoundField DataField="TipoCliente" HeaderText="TipoCliente" />
                    <asp:BoundField DataField="DirecionCliente" HeaderText="Direccion" />
                    <asp:BoundField DataField="CelularCliente" HeaderText="Celular Cliente" />
                </Columns>
            </asp:GridView>

        </div>
 
</asp:Content>
 


        







































   