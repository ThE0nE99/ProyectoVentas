using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNVENTAS;

public partial class WebFrom_Proveedor_Default : System.Web.UI.Page
{
    #region Controladoras
    CArticulo cArticulo = new CArticulo();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }
    }

    protected void btnBuscarArticulo_Click(object sender, EventArgs e)
    {
        if (int.Parse(txbCodigoArticulo.Text) > 0)
        {
            int codigoArticulo = int.Parse(txbCodigoArticulo.Text);
            //Buscamos un Articulo en la base de datos con el Codigo
            EVArticulo articulo = cArticulo.Obtener_VArticulo_O(codigoArticulo);
            if (articulo != null)
            {   
                EVArticulo eVArticulo = cArticulo.Obtener_VArticulo_O(codigoArticulo);
                lbObtener.Text = "Categoria: " + eVArticulo.CategoriaArticulo + "  Nombre: " + eVArticulo.NombreArticulo +
                "  Precio Compra: " + eVArticulo.PrecioCompraArticulo + "  Precio Venta: " + eVArticulo.PrecioVentaArticulo + "  Stock: " + eVArticulo.StockArticulo;
            }
        }

    }

    protected void btnCrearArticulo_Click(object sender, EventArgs e)
    {
        int codigoArticulo = cArticulo.Obtener_VArticulo_O_SiguienteCodigoArticulo(), stockArticulo = int.Parse(txbStockArticulo.Text);
        string categoriaArticulo = txbCategoriaArticulo.Text, nombreArticulo = txbNombreArticulo.Text;
        double precioCompraArticulo = double.Parse(txbPrecioCompraArticulo.Text), precioVentaArticulo = double.Parse(txbPrecioVentaArticulo.Text);
        cArticulo.Insertar_VArticulo_I(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
    }

    protected void btnVerArticulos_Click(object sender, EventArgs e)
    {
        List<EVArticulo> lstEVArticulos = cArticulo.Obtener_GRol_O_Todo();
        foreach (var articulo in lstEVArticulos)
        {
            lbObtenerTodos.Text += "  Categoria: " + articulo.CategoriaArticulo + "  Nombre: " + articulo.NombreArticulo +
            "  Precio Compra: " + articulo.PrecioCompraArticulo + "  Precio Venta: " + articulo.PrecioVentaArticulo + "  Stock: " + articulo.StockArticulo + "\n";
        }
    }
    protected void btnBuscarArticuloActualizar_Click(object sender, EventArgs e)
    {
        if (int.Parse(txbCodigoArticuloActualizar.Text) > 0)
        {
            int codigoArticulo = int.Parse(txbCodigoArticuloActualizar.Text);
            //Buscamos un Articulo en la base de datos con el Codigo
            EVArticulo articulo = cArticulo.Obtener_VArticulo_O(codigoArticulo);
            if (articulo != null)
            {
                EVArticulo eVArticulo = cArticulo.Obtener_VArticulo_O(codigoArticulo);
                txbCategoriaArticuloActualizar.Text = eVArticulo.CategoriaArticulo;
                txbNombreArticuloActualizar.Text = eVArticulo.NombreArticulo;
                txbPrecioCompraArticuloActualizar.Text = eVArticulo.PrecioCompraArticulo.ToString();
                txbPrecioVentaArticuloActualizar.Text = eVArticulo.PrecioVentaArticulo.ToString();
                txbStockArticuloActualizar.Text = eVArticulo.StockArticulo.ToString();
            }
        }
    }
    protected void btnActualizarArticulo_Click(object sender, EventArgs e)
    {
        int codigoArticulo = int.Parse(txbCodigoArticuloActualizar.Text), stockArticulo = int.Parse(txbStockArticuloActualizar.Text);
        string categoriaArticulo = txbCategoriaArticuloActualizar.Text, nombreArticulo = txbNombreArticuloActualizar.Text;
        double precioCompraArticulo = double.Parse(txbPrecioCompraArticuloActualizar.Text), precioVentaArticulo = double.Parse(txbPrecioVentaArticuloActualizar.Text);
        cArticulo.Actualizar_VArticulo_A(codigoArticulo, categoriaArticulo, nombreArticulo, precioCompraArticulo, precioVentaArticulo, stockArticulo);
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
            }
        }
    }
}