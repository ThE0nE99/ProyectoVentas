using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebFrom_Proveedor_Default : System.Web.UI.Page
{
    #region Controladoras
    CVProveedor cProveedor = new CVProveedor();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAgregarProveedor_Click(object sender, EventArgs e)
    {
        int codigoProveedor = cProveedor.Obtener_VProveedor_O_SiguienteCodigoProveedor();
        cProveedor.Insertar_VProveedor_I(codigoProveedor, txbTipoProveedor.Text, txbRazonSocialProveedor.Text, txbDireccionProveedor.Text, txbCelularProveedor.Text, txbCorreoProveedor.Text);
    }
    protected void btnBuscarProveedor_Click(object sender, EventArgs e)
    {
        if (int.Parse(txbCodigoProveedor.Text) > 0)
        {
            EVProveedor eVproveedor = cProveedor.Obtener_VProveedor_O(int.Parse(txbCodigoProveedor.Text));
            if (eVproveedor != null)
            {
                EVProveedor eVProveedor = cProveedor.Obtener_VProveedor_O(int.Parse(txbCodigoProveedor.Text));
                lbObtenerProveedor.Text = "  TipoProveedor: " + eVProveedor.TipoProveedor + "  RazonSocial Proveedor: " + eVProveedor.RazonSocialProveedor + "  DireccionProveedor: " + eVProveedor.DireccionProveedor + "  CelularProveedor: " + eVProveedor.CelularProveedor + "CorreoProveedor: " + eVProveedor.CorreoProveedor ;
            }
        }
    }

    protected void btnBuscarProveedorActualizar_Click(object sender, EventArgs e)
    {
        if (int.Parse(txbCodigoProveedorActualizar.Text) > 0)
        {
            EVProveedor eVproveedor = cProveedor.Obtener_VProveedor_O(int.Parse(txbCodigoProveedorActualizar.Text));
            if (eVproveedor != null)
            {
                EVProveedor eVProveedor = cProveedor.Obtener_VProveedor_O(int.Parse(txbCodigoProveedorActualizar.Text));
                txbTipoProveedorActualizar.Text = eVProveedor.TipoProveedor;
                txbRazonSocialProveedorActualizar.Text = eVProveedor.RazonSocialProveedor;
                txbDireccionProveedorActualizar.Text = eVProveedor.DireccionProveedor;
                txbCelularProveedorActualizar.Text = eVProveedor.CelularProveedor;
                txbCorreoProveedorActualizar.Text = eVProveedor.CorreoProveedor;
            }
        }
    }
    protected void btnActualizarProveedor_Click(object sender, EventArgs e)
    {
        cProveedor.Actualizar_VProveedor_A(int.Parse(txbCodigoProveedorActualizar.Text), txbTipoProveedorActualizar.Text, txbRazonSocialProveedorActualizar.Text, txbDireccionProveedorActualizar.Text, txbCelularProveedorActualizar.Text, txbCorreoProveedorActualizar.Text,"AC");
    }
    protected void btnBuscarProveedorEliminar_Click(object sender, EventArgs e)
    {
        if (int.Parse(txbCodigoProveedorEliminar.Text) > 0)
        {
            EVProveedor articulo = cProveedor.Obtener_VProveedor_O(int.Parse(txbCodigoProveedorEliminar.Text));
            if (articulo != null)
            {
                cProveedor.Eliminar_VProveedor_E(int.Parse(txbCodigoProveedorEliminar.Text));
            }
        }
    }

    protected void btnVerProveedores_Click(object sender, EventArgs e)
    {
        lbObtenerTodos.Text = "";
        List<EVProveedor> lstEVArticulos = cProveedor.Obtener_VProveedor_O_Todo();
        foreach (var proveedor in lstEVArticulos)
        {
            lbObtenerTodos.Text += "  TipoProveedor: " + proveedor.TipoProveedor + "  RazonSocial Proveedor: " + proveedor.RazonSocialProveedor + "  DireccionProveedor: " + proveedor.DireccionProveedor + "  CelularProveedor: " + proveedor.CelularProveedor + "CorreoProveedor: " + proveedor.CorreoProveedor + "\n";
        }
    }
}