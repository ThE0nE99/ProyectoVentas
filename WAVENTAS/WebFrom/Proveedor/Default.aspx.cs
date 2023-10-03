using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebFrom_Proveedor_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAgregarProveedor_Click(object sender, EventArgs e)
    {
        CVProveedor cProveedor = new CVProveedor();
        int codigoProveedor = cProveedor.Obtener_VProveedor_O_SiguienteCodigoProveedor();
        cProveedor.Insertar_VProveedor_I(codigoProveedor, txtTipoProveedor.Text, txtRazonSocialProveedor.Text, txtDireccionProveedor.Text, txtCelularProveedor.Text, txtCorreoProveedor.Text);
    }
}