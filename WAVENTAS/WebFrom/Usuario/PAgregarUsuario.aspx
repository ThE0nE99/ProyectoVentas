<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MasterPage.master" AutoEventWireup="true" CodeFile="PAgregarUsuario.aspx.cs" Inherits="WebFrom_Usuario_PAgregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <asp:Button ID="btnMenu" Text="Menu" runat="server" OnClick="btnMenu_Click"/>
    <h1>Formulario de Registro de Usuario</h1>
        <hr />
        <h3>Insertar</h3>
    <div>
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
            <asp:DropDownList ID="CmbRol" runat="server" CssClass="form-control">
                <asp:ListItem Text="Seleccionar Rol" Value="" />
                <asp:ListItem Text="Estudiante" Value="ES" />
                <asp:ListItem Text="Administrativo" Value="AD" />
                
            </asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        </div>
    </div>
     <hr />
<h3>Ver datos</h3>
<div>
<div>
<label for="txtId">Codigo Usuario:</label>
<asp:TextBox ID="txtId" runat="server" CssClass="form-control" />
</div>
<div>
<asp:Button ID="Button1" runat="server" Text="Ver datos" OnClick="btnVerDatos_Click" CssClass="btn btn-primary" />
</div>
 
       <table border="1">
<tr>
<th>Nombre Completo</th>
<th>Contacto</th>
<th>Correo</th>
<th>Clave</th>
<th>Estado</th>
</tr>
<tr>
<td><asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></td>
<td><asp:Label ID="lblContacto" runat="server" Text=""></asp:Label></td>
<td><asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label></td>
<td><asp:Label ID="lblClave" runat="server" Text=""></asp:Label></td>
<td><asp:Label ID="lblEstado" runat="server" Text=""></asp:Label></td>
</tr>
</table>
</div>
<hr />
        <h3>Editar</h3>
    <div>
        <div>
            <label for="txtIdEditar">Codigo Usuario:</label>
            <asp:TextBox ID="txtIdEditar" runat="server" CssClass="form-control" />
        </div>
        <div>
            <asp:Button ID="btnBuscarEditar" runat="server" Text="Buscar" OnClick="btnBuscarEditar_Click" CssClass="btn btn-primary" />
        </div>
        <div>
            <label for="txtNombresEditar">Nombres:</label>
            <asp:TextBox ID="txtNombresEditar" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtApellidosEditar">Apellidos:</label>
            <asp:TextBox ID="txtApellidosEditar" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtCelularEditar">Celular:</label>
            <asp:TextBox ID="txtCelularEditar" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtCorreoEditar">Correo Electrónico:</label>
            <asp:TextBox ID="txtCorreoEditar" runat="server" CssClass="form-control" />
        </div>
        <div>
            <label for="txtClaveEditar">Clave:</label>
            <asp:TextBox ID="txtClaveEditar" runat="server" TextMode="Password" CssClass="form-control" />
        </div>
        <div>
            <label for="ddlRolEditar">Rol de Usuario:</label>
            <asp:DropDownList ID="ddlRolEditar" runat="server" CssClass="form-control">
                <asp:ListItem Text="Seleccionar Rol" Value="" />
                <asp:ListItem Text="Estudiante" Value="ES" />
                <asp:ListItem Text="Administrativo" Value="AD" />
                
            </asp:DropDownList>
        </div>
        <div>
            <label for="txtEstadoEditar">Estado:</label>
            <asp:TextBox ID="txtEstadoEditar" runat="server" CssClass="form-control" />
        </div>
        <div>
            <asp:Button ID="btnEditar" runat="server" Text="Editar" OnClick="btnEditar_Click" CssClass="btn btn-primary" />
        </div>
    </div>
     <hr />
        <h3>Eliminar</h3>
    <div>
        <div>
            <label for="txtIdEliminar">Codigo Usuario:</label>
            <asp:TextBox ID="txtIdEliminar" runat="server" CssClass="form-control" />
        </div>
        <div>
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="btn btn-primary" />
        </div>
        <div>
             <asp:Label ID="txtEliminarInformacion" runat="server" Text=""></asp:Label>
        </div>
    </div>
    
        <div>
            <h1>Ver todos los Usuarios</h1>
            <asp:Button ID="btnVerUsuaarios" Text="Buscar" runat="server" OnClick="btnVerUsuaarios_Click" />
            <asp:GridView ID="gridViewUsuarios" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="NombresUsuario" HeaderText="Nombres Usuario" />
                    <asp:BoundField DataField="ApellidosUsuario" HeaderText="Apellidos Usuario" />
                    <asp:BoundField DataField="CelularUsuario" HeaderText="Celular Usuario" />
                    <asp:BoundField DataField="CorreoUsuario" HeaderText="Correo Usuario" />
                    <asp:BoundField DataField="RolUsuario" HeaderText="Rol Usuario" />
                </Columns>
            </asp:GridView>

        </div>
</asp:Content>

