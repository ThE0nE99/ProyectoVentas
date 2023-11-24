using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNVENTAS;

public partial class WebFrom_Ingreso_PAgregarIngreso : System.Web.UI.Page
{
    private CAlmacen cAlmacen = new CAlmacen();
    protected void Page_Load(object sender, EventArgs e)
    {
        btnNuevoRegistro.Visible = false;
    }

    protected void btnAgregarIngreso_Click(object sender, EventArgs e)
    {
        //EIngreso eIngreso = new EIngreso();
        //eIngreso.CodigoProveedor = 1;
        //eIngreso.CodigoUsuario = 1;
        //eIngreso.FechaIngreso = DateTime.Now;
        //eIngreso.ImpuestoIngreso = 1;
        //eIngreso.TotalIngreso = 1;
        //List<EDetalleIngreso> lista = new List<EDetalleIngreso>();
        //EDetalleIngreso eDetalleIngreso = null;
        //eDetalleIngreso = new EDetalleIngreso();
        //eDetalleIngreso.CodigoArticulo = 1;
        //eDetalleIngreso.CantidadIngreso = 1;
        //eDetalleIngreso.PrecioIngreso = 1;
        //lista.Add(eDetalleIngreso);
        //eDetalleIngreso = new EDetalleIngreso();
        //eDetalleIngreso.CodigoArticulo = 2;
        //eDetalleIngreso.CantidadIngreso = 2;
        //eDetalleIngreso.PrecioIngreso = 2;
        //lista.Add(eDetalleIngreso);

        //cAlmacen.Insertar_Ingreso(eIngreso, lista);

        EIngreso eIngreso = new EIngreso();
        eIngreso.CodigoProveedor = int.Parse(txbCodigoProveedor.Text);
        eIngreso.CodigoUsuario = int.Parse(txbCodigoUsuario.Text);
        eIngreso.FechaIngreso = DateTime.Now;
        eIngreso.ImpuestoIngreso = decimal.Parse(txbImpuestoIngreso.Text);
        eIngreso.TotalIngreso = int.Parse(txbTotalIngreso.Text);
        eIngreso.EstadoIngreso = txbEstadoIngreso.Text;
        List<EDetalleIngreso> lista = new List<EDetalleIngreso>();
        EDetalleIngreso eDetalleIngreso = null;
        eDetalleIngreso = new EDetalleIngreso();
        eDetalleIngreso.CodigoArticulo = int.Parse(txbCodigoArticulo.Text);
        eDetalleIngreso.CantidadIngreso = int.Parse(txbCantidadIngreso.Text);
        eDetalleIngreso.PrecioIngreso = double.Parse(txbPrecioIngreso.Text);
        lista.Add(eDetalleIngreso);
        cAlmacen.Insertar_Ingreso(eIngreso, lista);
        lblInsercion.Text = "Registro Insertado Correctamente";
        btnAgregarIngreso.Visible = false;
        btnNuevoRegistro.Visible = true;
        OcultarCamposDeInsercion();

    }
    private void OcultarCamposDeInsercion()
    {
        txbCodigoProveedor.Text = " ";
        txbCodigoUsuario.Text = " ";
        txbImpuestoIngreso.Text = " ";
        txbTotalIngreso.Text = " ";
        txbEstadoIngreso.Text = " ";

        txbCodigoArticulo.Text = " ";
        txbCantidadIngreso.Text = " ";
        txbPrecioIngreso.Text = " ";

    }
    protected void btnNuevoRegistro_Click(object sender, EventArgs e)
    {
        btnAgregarIngreso.Visible = true;
        lblInsercion.Text = " ";
    }

	protected void btnMenu_Click(object sender, EventArgs e)
	{

		Response.Redirect("~/WebFrom/Menu/Default.aspx");
	}
}