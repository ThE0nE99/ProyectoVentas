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

    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        CVenta cVenta = new CVenta();
        EVenta eVenta = new EVenta();
        eVenta.CodigoCliente = 12;
        eVenta.CodigoUsuario = 13;
        eVenta.FechaHoraVenta = DateTime.Now;
        eVenta.ImpuestoVenta = 12;
        eVenta.TotalVenta = 13;
        eVenta.EstadoVenta = "A";

        List<EDetalleVenta> lista = new List<EDetalleVenta>();

        EDetalleVenta eDetalle = new EDetalleVenta();

        //eDetalle.CodigoVenta = 14;
        eDetalle.CodigoArticulo = 13;
        eDetalle.CantidadDetalleVenta = 12;
        eDetalle.PrecioDetalleVenta = 12;
        eDetalle.DescuentoDetalleVenta = 1;

        lista.Add(eDetalle);

        EDetalleVenta eDetalle2 = new EDetalleVenta();
        
        //eDetalle2.CodigoVenta = 14;
        eDetalle2.CodigoArticulo = 10;
        eDetalle2.CantidadDetalleVenta = 11;
        eDetalle2.PrecioDetalleVenta = 12;
        eDetalle2.DescuentoDetalleVenta = 11;

        lista.Add(eDetalle2);

        cVenta.Insertar_Venta(eVenta, lista);
    }
}