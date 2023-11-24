using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNVENTAS;

public partial class WebFrom_Proveedor_Default : System.Web.UI.Page
{
	#region Controladoras
	CArticulo cArticulo = new CArticulo();
	bool actualizar = false;
	#endregion

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			verArticulos();
		}
	}

	protected void btnBuscarArticulo_Click(object sender, EventArgs e)
	{
		if (int.Parse(txbCodigoArticulo.Text) > 0)
		{
			DataTable table = new DataTable();
			table.Columns.Add("Codigo");
			table.Columns.Add("Categoria");
			table.Columns.Add("Nombre");
			table.Columns.Add("Precio Compra");
			table.Columns.Add("Precio Venta");
			table.Columns.Add("Stock");
			int codigoArticulo = int.Parse(txbCodigoArticulo.Text);
			//Buscamos un Articulo en la base de datos con el Codigo
			EVArticulo articulo = cArticulo.Obtener_VArticulo_O(codigoArticulo);
			if (articulo != null)
			{
				EVArticulo eVArticulo = cArticulo.Obtener_VArticulo_O(codigoArticulo);
				table.Rows.Add(articulo.CodigoArticulo, articulo.CategoriaArticulo, articulo.NombreArticulo, articulo.PrecioCompraArticulo,
				articulo.PrecioVentaArticulo, articulo.StockArticulo);
				DataGridArticulo.DataSource = table;
				DataGridArticulo.DataBind();
			}
		}
	}

	protected void btnGuardarArticulo_Click(object sender, EventArgs e)
	{
		int codigoArticulo = cArticulo.Obtener_VArticulo_O_SiguienteCodigoArticulo(), stockArticulo = int.Parse(txbStockArticulo.Text);
		string categoriaArticulo = txbCategoriaArticulo.Text, nombreArticulo = txbNombreArticulo.Text;
		double precioCompraArticulo = double.Parse(txbPrecioCompraArticulo.Text), precioVentaArticulo = double.Parse(txbPrecioVentaArticulo.Text);
		if (txbCodigoArticuloActualizar.Text.Equals(string.Empty))
		{
			cArticulo.Insertar_VArticulo_I(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
			lbArticulo.Text = "SE HA INSERTADO EXITOSAMENTE";

		}
		else
		{
			codigoArticulo = int.Parse(txbCodigoArticuloActualizar.Text);
			cArticulo.Actualizar_VArticulo_A(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
			lbArticulo.Text = "SE HA ACTUALIZADO EXITOSAMENTE";
			btnGuardarArticulo.Text = "Crear Nuevo Articulo";
		}
		verArticulos();

		txbCodigoArticuloActualizar.Text = ""; txbStockArticulo.Text = "";
		txbCategoriaArticulo.Text = ""; txbNombreArticulo.Text = "";
		txbPrecioCompraArticulo.Text = ""; txbPrecioVentaArticulo.Text = "";

	}

	protected void verArticulos()
	{
		DataTable table = new DataTable();
		table.Columns.Add("Codigo");
		table.Columns.Add("Categoria");
		table.Columns.Add("Nombre");
		table.Columns.Add("Precio Compra");
		table.Columns.Add("Precio Venta");
		table.Columns.Add("Stock");

		List<EVArticulo> lstEVArticulos = cArticulo.Obtener_GRol_O_Todo();
		foreach (var articulo in lstEVArticulos)
		{
			table.Rows.Add(articulo.CodigoArticulo, articulo.CategoriaArticulo, articulo.NombreArticulo, articulo.PrecioCompraArticulo,
				articulo.PrecioVentaArticulo, articulo.StockArticulo);
		}
		DataGridArticulo.DataSource = table;
		DataGridArticulo.DataBind();
	}
	protected void btnBuscarArticuloActualizar_Click(object sender, EventArgs e)
	{
		if (int.Parse(txbCodigoArticuloActualizar.Text) > 0)
		{
			lbArticulo.Text = "";
			btnGuardarArticulo.Text = "Actualizar";
			int codigoArticulo = int.Parse(txbCodigoArticuloActualizar.Text);
			//Buscamos un Articulo en la base de datos con el Codigo
			EVArticulo articulo = cArticulo.Obtener_VArticulo_O(codigoArticulo);
			if (articulo != null)
			{
				actualizar = true;
				EVArticulo eVArticulo = cArticulo.Obtener_VArticulo_O(codigoArticulo);
				txbCategoriaArticulo.Text = eVArticulo.CategoriaArticulo;
				txbNombreArticulo.Text = eVArticulo.NombreArticulo;
				txbPrecioCompraArticulo.Text = eVArticulo.PrecioCompraArticulo.ToString();
				txbPrecioVentaArticulo.Text = eVArticulo.PrecioVentaArticulo.ToString();
				txbStockArticulo.Text = eVArticulo.StockArticulo.ToString();
			}
		}
	}
	protected void btnBuscarArticuloEliminar_Click(object sender, EventArgs e)
	{
		if (int.Parse(txbCodigoArticuloEliminar.Text) > 0)
		{
			int codigoArticulo = int.Parse(txbCodigoArticuloEliminar.Text);
			//Buscamos un Articulo en la base de datos con el Codigo
			EVArticulo articulo = cArticulo.Obtener_VArticulo_O(codigoArticulo);
			if (articulo != null)
			{
				cArticulo.Eliminar_VArticulo_E(codigoArticulo);
				lbEliminar.Text = "SE HA ELIMINADO EXITOSAMENTE";
				verArticulos();
			}
		}
	}

	protected void btnVerTodo_Click(object sender, EventArgs e)
	{
		verArticulos();
	}

	protected void btnMenu_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/WebFrom/Menu/Default.aspx");
	}
}