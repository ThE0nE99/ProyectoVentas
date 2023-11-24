using SWLNVENTAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebFrom_Venta_APVenta : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
       btnNuevoRegistro.Visible = false;
    }
    protected void btnInsertarVenta_Click(object sender, EventArgs e)
    {
        try
        {
            CVenta cVenta = new CVenta();
            EVenta eVenta = new EVenta();
            eVenta.CodigoCliente = int.Parse(txtCodigoClienteVenta.Text);
            eVenta.CodigoUsuario = int.Parse(txtCodigoUsuarioVenta.Text);
            eVenta.FechaHoraVenta = DateTime.Now;
            eVenta.ImpuestoVenta = double.Parse(txtImpuestoVenta.Text);
            eVenta.TotalVenta = double.Parse(txtTotalVenta.Text);
            eVenta.EstadoVenta = txtEstadoVenta.Text;

            List<EDetalleVenta> lista = new List<EDetalleVenta>();

            EDetalleVenta eDetalle = new EDetalleVenta();

            eDetalle.CodigoArticulo = int.Parse(txtCantidadArticulo.Text);
            eDetalle.CantidadDetalleVenta = int.Parse(txtCantidadDetalleVenta.Text);
            eDetalle.PrecioDetalleVenta = double.Parse(txtPrecioDetalleVenta.Text);
            eDetalle.DescuentoDetalleVenta = double.Parse(txtDescuentoDetalleVenta.Text);

            lista.Add(eDetalle);

            cVenta.Insertar_Venta(eVenta, lista);
            lblInformacion.Text = "Registro Insertado Correctamente";
            btnInsertarVenta.Visible = false;
            btnNuevoRegistro.Visible = true;
            OcultarCamposEdicion();
        }
        catch (Exception)
        {
            lblInformacion.Text = "Error al insertar el registro: ";
        }
       

    }
    private void OcultarCamposEdicion()
    {
        txtCodigoClienteVenta.Text = "";
        txtCodigoUsuarioVenta.Text = "";
        txtImpuestoVenta.Text = "";
        txtTotalVenta.Text = "";
        txtEstadoVenta.Text = "";

        txtCantidadArticulo.Text = "";
        txtCantidadDetalleVenta.Text = "";
        txtPrecioDetalleVenta.Text = "";
        txtDescuentoDetalleVenta.Text = "";
    }
    protected void btnNuevoRegistro_Click(object sender, EventArgs e)
    {
        btnInsertarVenta.Visible = true;
        lblInformacion.Text = "";
    }
	protected void btnMenu_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/WebFrom/Menu/Default.aspx");
	}
}