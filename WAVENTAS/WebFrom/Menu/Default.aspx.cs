using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebFrom_Menu_Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{

	}

    protected void btnArticulo_Click(object sender, EventArgs e)
    {
		Response.Redirect("~/WebFrom/Articulo/Default.aspx");
	}

	protected void btnCliente_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/WebFrom/Cliente/PAgregarCliente.aspx");
	}

	protected void btnIngreso_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/WebFrom/Ingreso/PAgregarIngreso.aspx");
	}

	protected void btnProveedor_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/WebFrom/Proveedor/Default.aspx");
	}

	protected void btnUsuario_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/WebFrom/Usuario/PAgregarUsuario.aspx");
	}

	protected void btnVenta_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/WebFrom/Venta/APVenta.aspx");
	}
}