<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="WebFrom_Menu_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnArticulo" Text="Articulo" runat="server" OnClick="btnArticulo_Click"/> <br />
            <asp:Button ID="btnCliente" Text="Cliente" runat="server" OnClick="btnCliente_Click"/> <br />
            <asp:Button ID="btnIngreso" Text="Ingreso" runat="server" OnClick="btnIngreso_Click"/> <br />
            <asp:Button ID="btnProveedor" Text="Proveedor" runat="server" OnClick="btnProveedor_Click"/> <br />
            <asp:Button ID="btnUsuario" Text="Usuario" runat="server" OnClick="btnUsuario_Click"/> <br />
            <asp:Button ID="btnVenta" Text="Venta" runat="server" OnClick="btnVenta_Click"/> <br />

        </div>
    </form>
</body>
</html>
